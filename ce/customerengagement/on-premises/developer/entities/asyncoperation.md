---
title: "System Job (AsyncOperation)  entity reference (Dynamics 365 Customer Engagement) | Microsoft Docs"
description: "Includes schema information and supported messages for the System Job (AsyncOperation)  entity."
ms.date: 08/30/2022
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "KumarVivek"
ms.author: "kvivek"
search.audienceType: 
  - developer
---

# System Job (AsyncOperation)  entity reference

Process whose execution can proceed independently or in the background.


## Messages

|Message|SDK class or method|
|-|-|
|Create|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|Update|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

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

#### OperationType Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|System Event||
|2|Bulk Email||
|3|Import File Parse||
|4|Transform Parse Data||
|5|Import||
|6|Activity Propagation||
|7|Duplicate Detection Rule Publish||
|8|Bulk Duplicate Detection||
|9|SQM Data Collection||
|10|Workflow||
|11|Quick Campaign||
|12|Matchcode Update||
|13|Bulk Delete||
|14|Deletion Service||
|15|Index Management||
|16|Collect Organization Statistics||
|17|Import Subprocess||
|18|Calculate Organization Storage Size||
|19|Collect Organization Database Statistics||
|20|Collection Organization Size Statistics||
|21|Database Tuning||
|22|Calculate Organization Maximum Storage Size||
|23|Bulk Delete Subprocess||
|24|Update Statistic Intervals||
|25|Organization Full Text Catalog Index||
|26|Database log backup||
|27|Update Contract States||
|28|DBCC SHRINKDATABASE maintenance job||
|29|DBCC SHRINKFILE maintenance job||
|30|Reindex all indices maintenance job||
|31|Storage Limit Notification||
|32|Cleanup inactive workflow assemblies||
|35|Recurring Series Expansion||
|38|Import Sample Data||
|40|Goal Roll Up||
|41|Audit Partition Creation||
|42|Check For Language Pack Updates||
|43|Provision Language Pack||
|44|Update Organization Database||
|45|Update Solution||
|46|Regenerate Entity Row Count Snapshot Data||
|47|Regenerate Read Share Snapshot Data||
|49|Post to Yammer||
|50|Outgoing Activity||
|51|Incoming Email Processing||
|52|Mailbox Test Access||
|53|Encryption Health Check||
|54|Execute Async Request||
|56|Update Entitlement States||
|57|Calculate Rollup Field||
|58|Mass Calculate Rollup Field||
|59|Import Translation||
|62|Convert Date And Time Behavior||
|63|EntityKey Index Creation||
|65|Update Knowledge Article States||
|68|Resource Booking Sync||
|69|Relationship Assistant Cards||
|71|Cleanup Solution Components||
|72|App Module Metadata Operation||
|73|ALM Anomaly Detection Operation||
|75|Flow Notification||



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
|Targets|account,accountleads,activitymimeattachment,activitypointer,annotation,annualfiscalcalendar,appointment,attributemap,bookableresource,bookableresourcebooking,bookableresourcebookingexchangesyncidmapping,bookableresourcebookingheader,bookableresourcecategory,bookableresourcecategoryassn,bookableresourcecharacteristic,bookableresourcegroup,bookingstatus,bulkoperation,bulkoperationlog,businessunit,businessunitnewsarticle,calendar,campaign,campaignactivity,campaignactivityitem,campaignitem,campaignresponse,channelaccessprofile,channelaccessprofilerule,characteristic,childincidentcount,commitment,competitor,competitoraddress,competitorproduct,competitorsalesliterature,connection,connectionrole,constraintbasedgroup,contact,contactinvoices,contactleads,contactorders,contactquotes,contract,contractdetail,contracttemplate,convertrule,customeraddress,customeropportunityrole,customerrelationship,discount,discounttype,displaystring,dynamicproperty,dynamicpropertyassociation,dynamicpropertyinstance,dynamicpropertyoptionsetitem,email,emailserverprofile,entitlement,entitlementchannel,entitlementcontacts,entitlementproducts,entitlementtemplate,entitlementtemplatechannel,entitlementtemplateproducts,entitymap,equipment,externalparty,externalpartyitem,fax,fixedmonthlyfiscalcalendar,goal,goalrollupquery,import,importdata,importfile,importlog,importmap,incident,incidentknowledgebaserecord,incidentresolution,interactionforemail,invoice,invoicedetail,isvconfig,kbarticle,kbarticlecomment,kbarticletemplate,knowledgearticle,knowledgearticleincident,knowledgebaserecord,lead,leadaddress,leadcompetitors,leadproduct,leadtoopportunitysalesprocess,letter,list,listmember,mailbox,mailmergetemplate,metric,monthlyfiscalcalendar,msdyn_postalbum,msdyn_postconfig,msdyn_postruleconfig,msdyn_relationshipinsightsunifiedconfig,msdyn_siconfig,msdyn_wallsavedquery,msdyn_wallsavedqueryusersettings,opportunity,opportunityclose,opportunitycompetitors,opportunityproduct,opportunitysalesprocess,orderclose,organization,phonecall,phonetocaseprocess,position,post,postfollow,pricelevel,privilege,product,productassociation,productpricelevel,productsalesliterature,productsubstitute,quarterlyfiscalcalendar,queue,queueitem,quote,quoteclose,quotedetail,ratingmodel,ratingvalue,recurringappointmentmaster,relationshiprole,relationshiprolemap,report,resource,resourcegroup,resourcegroupexpansion,resourcespec,role,rollupfield,routingrule,routingruleitem,salesliterature,salesliteratureitem,salesorder,salesorderdetail,salesprocessinstance,savedquery,semiannualfiscalcalendar,service,serviceappointment,servicecontractcontacts,sharepointdocumentlocation,sharepointsite,similarityrule,site,sla,socialactivity,socialprofile,subject,systemform,systemuser,task,team,template,territory,theme,topic,topichistory,topicmodel,topicmodelconfiguration,topicmodelexecutionhistory,transactioncurrency,uom,uomschedule,userform,usermapping,userquery|
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
|Description|Root execution context of the job that trigerred async job.|
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

#### StateCode Choices/Options

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

#### StatusCode Choices/Options

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

#### IsWaitingForEvent Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



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

#### WorkflowIsBlocked Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



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

Same as the [AsyncOperation_MailboxTrackingFolder](mailboxtrackingfolder.md#BKMK_AsyncOperation_MailboxTrackingFolder) many-to-one relationship for the [mailboxtrackingfolder](mailboxtrackingfolder.md) entity.

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

Same as the [AsyncOperation_BulkDeleteOperation](bulkdeleteoperation.md#BKMK_AsyncOperation_BulkDeleteOperation) many-to-one relationship for the [bulkdeleteoperation](bulkdeleteoperation.md) entity.

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

Same as the [lk_workflowlog_asyncoperation_childworkflow](workflowlog.md#BKMK_lk_workflowlog_asyncoperation_childworkflow) many-to-one relationship for the [workflowlog](workflowlog.md) entity.

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

Same as the [AsyncOperation_Emails](email.md#BKMK_AsyncOperation_Emails) many-to-one relationship for the [email](email.md) entity.

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

Same as the [AsyncOperation_DuplicateBaseRecord](duplicaterecord.md#BKMK_AsyncOperation_DuplicateBaseRecord) many-to-one relationship for the [duplicaterecord](duplicaterecord.md) entity.

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

Same as the [lk_workflowlog_asyncoperations](workflowlog.md#BKMK_lk_workflowlog_asyncoperations) many-to-one relationship for the [workflowlog](workflowlog.md) entity.

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

Same as the [AsyncOperation_SocialActivities](socialactivity.md#BKMK_AsyncOperation_SocialActivities) many-to-one relationship for the [socialactivity](socialactivity.md) entity.

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

- [theme_AsyncOperations](#BKMK_theme_AsyncOperations)
- [usermapping_AsyncOperations](#BKMK_usermapping_AsyncOperations)
- [interactionforemail_AsyncOperations](#BKMK_interactionforemail_AsyncOperations)
- [knowledgearticle_AsyncOperations](#BKMK_knowledgearticle_AsyncOperations)
- [post_AsyncOperations](#BKMK_post_AsyncOperations)
- [position_AsyncOperations](#BKMK_position_AsyncOperations)
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
- [msdyn_relationshipinsightsunifiedconfig_AsyncOperations](#BKMK_msdyn_relationshipinsightsunifiedconfig_AsyncOperations)
- [msdyn_siconfig_AsyncOperations](#BKMK_msdyn_siconfig_AsyncOperations)
- [msdyn_postalbum_AsyncOperations](#BKMK_msdyn_postalbum_AsyncOperations)
- [msdyn_postconfig_AsyncOperations](#BKMK_msdyn_postconfig_AsyncOperations)
- [msdyn_postruleconfig_AsyncOperations](#BKMK_msdyn_postruleconfig_AsyncOperations)
- [msdyn_wallsavedquery_AsyncOperations](#BKMK_msdyn_wallsavedquery_AsyncOperations)
- [msdyn_wallsavedqueryusersettings_AsyncOperations](#BKMK_msdyn_wallsavedqueryusersettings_AsyncOperations)
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


### <a name="BKMK_theme_AsyncOperations"></a> theme_AsyncOperations

See the [theme_AsyncOperations](theme.md#BKMK_theme_AsyncOperations) one-to-many relationship for the [theme](theme.md) entity.

### <a name="BKMK_usermapping_AsyncOperations"></a> usermapping_AsyncOperations

See the [usermapping_AsyncOperations](usermapping.md#BKMK_usermapping_AsyncOperations) one-to-many relationship for the [usermapping](usermapping.md) entity.

### <a name="BKMK_interactionforemail_AsyncOperations"></a> interactionforemail_AsyncOperations

See the [interactionforemail_AsyncOperations](interactionforemail.md#BKMK_interactionforemail_AsyncOperations) one-to-many relationship for the [interactionforemail](interactionforemail.md) entity.

### <a name="BKMK_knowledgearticle_AsyncOperations"></a> knowledgearticle_AsyncOperations

See the [knowledgearticle_AsyncOperations](knowledgearticle.md#BKMK_knowledgearticle_AsyncOperations) one-to-many relationship for the [knowledgearticle](knowledgearticle.md) entity.

### <a name="BKMK_post_AsyncOperations"></a> post_AsyncOperations

See the [post_AsyncOperations](post.md#BKMK_post_AsyncOperations) one-to-many relationship for the [post](post.md) entity.

### <a name="BKMK_position_AsyncOperations"></a> position_AsyncOperations

See the [position_AsyncOperations](position.md#BKMK_position_AsyncOperations) one-to-many relationship for the [position](position.md) entity.

### <a name="BKMK_Territory_AsyncOperations"></a> Territory_AsyncOperations

**Added by**: Application Common Solution

See the [Territory_AsyncOperations](territory.md#BKMK_Territory_AsyncOperations) one-to-many relationship for the [territory](territory.md) entity.

### <a name="BKMK_leadaddress_AsyncOperations"></a> leadaddress_AsyncOperations

**Added by**: Lead Management Solution

See the [leadaddress_AsyncOperations](leadaddress.md#BKMK_leadaddress_AsyncOperations) one-to-many relationship for the [leadaddress](leadaddress.md) entity.

### <a name="BKMK_Lead_AsyncOperations"></a> Lead_AsyncOperations

**Added by**: Lead Management Solution

See the [Lead_AsyncOperations](lead.md#BKMK_Lead_AsyncOperations) one-to-many relationship for the [lead](lead.md) entity.

### <a name="BKMK_dynamicproperty_AsyncOperations"></a> dynamicproperty_AsyncOperations

**Added by**: Product Management Solution

See the [dynamicproperty_AsyncOperations](dynamicproperty.md#BKMK_dynamicproperty_AsyncOperations) one-to-many relationship for the [dynamicproperty](dynamicproperty.md) entity.

### <a name="BKMK_dynamicpropertyassociation_AsyncOperations"></a> dynamicpropertyassociation_AsyncOperations

**Added by**: Product Management Solution

See the [dynamicpropertyassociation_AsyncOperations](dynamicpropertyassociation.md#BKMK_dynamicpropertyassociation_AsyncOperations) one-to-many relationship for the [dynamicpropertyassociation](dynamicpropertyassociation.md) entity.

### <a name="BKMK_dynamicpropertyinstance_AsyncOperations"></a> dynamicpropertyinstance_AsyncOperations

**Added by**: Product Management Solution

See the [dynamicpropertyinstance_AsyncOperations](dynamicpropertyinstance.md#BKMK_dynamicpropertyinstance_AsyncOperations) one-to-many relationship for the [dynamicpropertyinstance](dynamicpropertyinstance.md) entity.

### <a name="BKMK_dynamicpropertyoptionsetitem_AsyncOperations"></a> dynamicpropertyoptionsetitem_AsyncOperations

**Added by**: Product Management Solution

See the [dynamicpropertyoptionsetitem_AsyncOperations](dynamicpropertyoptionsetitem.md#BKMK_dynamicpropertyoptionsetitem_AsyncOperations) one-to-many relationship for the [dynamicpropertyoptionsetitem](dynamicpropertyoptionsetitem.md) entity.

### <a name="BKMK_PriceLevel_AsyncOperations"></a> PriceLevel_AsyncOperations

**Added by**: Product Management Solution

See the [PriceLevel_AsyncOperations](pricelevel.md#BKMK_PriceLevel_AsyncOperations) one-to-many relationship for the [pricelevel](pricelevel.md) entity.

### <a name="BKMK_Product_AsyncOperations"></a> Product_AsyncOperations

**Added by**: Product Management Solution

See the [Product_AsyncOperations](product.md#BKMK_Product_AsyncOperations) one-to-many relationship for the [product](product.md) entity.

### <a name="BKMK_ProductAssociation_AsyncOperations"></a> ProductAssociation_AsyncOperations

**Added by**: Product Management Solution

See the [ProductAssociation_AsyncOperations](productassociation.md#BKMK_ProductAssociation_AsyncOperations) one-to-many relationship for the [productassociation](productassociation.md) entity.

### <a name="BKMK_ProductPriceLevel_AsyncOperations"></a> ProductPriceLevel_AsyncOperations

**Added by**: Product Management Solution

See the [ProductPriceLevel_AsyncOperations](productpricelevel.md#BKMK_ProductPriceLevel_AsyncOperations) one-to-many relationship for the [productpricelevel](productpricelevel.md) entity.

### <a name="BKMK_ProductSubstitute_AsyncOperations"></a> ProductSubstitute_AsyncOperations

**Added by**: Product Management Solution

See the [ProductSubstitute_AsyncOperations](productsubstitute.md#BKMK_ProductSubstitute_AsyncOperations) one-to-many relationship for the [productsubstitute](productsubstitute.md) entity.

### <a name="BKMK_UoM_AsyncOperations"></a> UoM_AsyncOperations

**Added by**: Product Management Solution

See the [UoM_AsyncOperations](uom.md#BKMK_UoM_AsyncOperations) one-to-many relationship for the [uom](uom.md) entity.

### <a name="BKMK_UoMSchedule_AsyncOperations"></a> UoMSchedule_AsyncOperations

**Added by**: Product Management Solution

See the [UoMSchedule_AsyncOperations](uomschedule.md#BKMK_UoMSchedule_AsyncOperations) one-to-many relationship for the [uomschedule](uomschedule.md) entity.

### <a name="BKMK_bookableresource_AsyncOperations"></a> bookableresource_AsyncOperations

**Added by**: Scheduling Solution

See the [bookableresource_AsyncOperations](bookableresource.md#BKMK_bookableresource_AsyncOperations) one-to-many relationship for the [bookableresource](bookableresource.md) entity.

### <a name="BKMK_bookableresourcebooking_AsyncOperations"></a> bookableresourcebooking_AsyncOperations

**Added by**: Scheduling Solution

See the [bookableresourcebooking_AsyncOperations](bookableresourcebooking.md#BKMK_bookableresourcebooking_AsyncOperations) one-to-many relationship for the [bookableresourcebooking](bookableresourcebooking.md) entity.

### <a name="BKMK_bookableresourcebookingheader_AsyncOperations"></a> bookableresourcebookingheader_AsyncOperations

**Added by**: Scheduling Solution

See the [bookableresourcebookingheader_AsyncOperations](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_AsyncOperations) one-to-many relationship for the [bookableresourcebookingheader](bookableresourcebookingheader.md) entity.

### <a name="BKMK_bookableresourcecategory_AsyncOperations"></a> bookableresourcecategory_AsyncOperations

**Added by**: Scheduling Solution

See the [bookableresourcecategory_AsyncOperations](bookableresourcecategory.md#BKMK_bookableresourcecategory_AsyncOperations) one-to-many relationship for the [bookableresourcecategory](bookableresourcecategory.md) entity.

### <a name="BKMK_bookableresourcecategoryassn_AsyncOperations"></a> bookableresourcecategoryassn_AsyncOperations

**Added by**: Scheduling Solution

See the [bookableresourcecategoryassn_AsyncOperations](bookableresourcecategoryassn.md#BKMK_bookableresourcecategoryassn_AsyncOperations) one-to-many relationship for the [bookableresourcecategoryassn](bookableresourcecategoryassn.md) entity.

### <a name="BKMK_bookableresourcecharacteristic_AsyncOperations"></a> bookableresourcecharacteristic_AsyncOperations

**Added by**: Scheduling Solution

See the [bookableresourcecharacteristic_AsyncOperations](bookableresourcecharacteristic.md#BKMK_bookableresourcecharacteristic_AsyncOperations) one-to-many relationship for the [bookableresourcecharacteristic](bookableresourcecharacteristic.md) entity.

### <a name="BKMK_bookableresourcegroup_AsyncOperations"></a> bookableresourcegroup_AsyncOperations

**Added by**: Scheduling Solution

See the [bookableresourcegroup_AsyncOperations](bookableresourcegroup.md#BKMK_bookableresourcegroup_AsyncOperations) one-to-many relationship for the [bookableresourcegroup](bookableresourcegroup.md) entity.

### <a name="BKMK_bookingstatus_AsyncOperations"></a> bookingstatus_AsyncOperations

**Added by**: Scheduling Solution

See the [bookingstatus_AsyncOperations](bookingstatus.md#BKMK_bookingstatus_AsyncOperations) one-to-many relationship for the [bookingstatus](bookingstatus.md) entity.

### <a name="BKMK_characteristic_AsyncOperations"></a> characteristic_AsyncOperations

**Added by**: Scheduling Solution

See the [characteristic_AsyncOperations](characteristic.md#BKMK_characteristic_AsyncOperations) one-to-many relationship for the [characteristic](characteristic.md) entity.

### <a name="BKMK_ratingmodel_AsyncOperations"></a> ratingmodel_AsyncOperations

**Added by**: Scheduling Solution

See the [ratingmodel_AsyncOperations](ratingmodel.md#BKMK_ratingmodel_AsyncOperations) one-to-many relationship for the [ratingmodel](ratingmodel.md) entity.

### <a name="BKMK_ratingvalue_AsyncOperations"></a> ratingvalue_AsyncOperations

**Added by**: Scheduling Solution

See the [ratingvalue_AsyncOperations](ratingvalue.md#BKMK_ratingvalue_AsyncOperations) one-to-many relationship for the [ratingvalue](ratingvalue.md) entity.

### <a name="BKMK_BulkOperation_AsyncOperations"></a> BulkOperation_AsyncOperations

**Added by**: Marketing Solution

See the [BulkOperation_AsyncOperations](bulkoperation.md#BKMK_BulkOperation_AsyncOperations) one-to-many relationship for the [bulkoperation](bulkoperation.md) entity.

### <a name="BKMK_BulkOperationLog_AsyncOperations"></a> BulkOperationLog_AsyncOperations

**Added by**: Marketing Solution

See the [BulkOperationLog_AsyncOperations](bulkoperationlog.md#BKMK_BulkOperationLog_AsyncOperations) one-to-many relationship for the [bulkoperationlog](bulkoperationlog.md) entity.

### <a name="BKMK_Campaign_AsyncOperations"></a> Campaign_AsyncOperations

**Added by**: Marketing Solution

See the [Campaign_AsyncOperations](campaign.md#BKMK_Campaign_AsyncOperations) one-to-many relationship for the [campaign](campaign.md) entity.

### <a name="BKMK_CampaignActivity_AsyncOperations"></a> CampaignActivity_AsyncOperations

**Added by**: Marketing Solution

See the [CampaignActivity_AsyncOperations](campaignactivity.md#BKMK_CampaignActivity_AsyncOperations) one-to-many relationship for the [campaignactivity](campaignactivity.md) entity.

### <a name="BKMK_CampaignResponse_AsyncOperations"></a> CampaignResponse_AsyncOperations

**Added by**: Marketing Solution

See the [CampaignResponse_AsyncOperations](campaignresponse.md#BKMK_CampaignResponse_AsyncOperations) one-to-many relationship for the [campaignresponse](campaignresponse.md) entity.

### <a name="BKMK_List_AsyncOperations"></a> List_AsyncOperations

**Added by**: Marketing Solution

See the [List_AsyncOperations](list.md#BKMK_List_AsyncOperations) one-to-many relationship for the [list](list.md) entity.

### <a name="BKMK_ConstraintBasedGroup_AsyncOperations"></a> ConstraintBasedGroup_AsyncOperations

**Added by**: Service Solution

See the [ConstraintBasedGroup_AsyncOperations](constraintbasedgroup.md#BKMK_ConstraintBasedGroup_AsyncOperations) one-to-many relationship for the [constraintbasedgroup](constraintbasedgroup.md) entity.

### <a name="BKMK_Contract_AsyncOperations"></a> Contract_AsyncOperations

**Added by**: Service Solution

See the [Contract_AsyncOperations](contract.md#BKMK_Contract_AsyncOperations) one-to-many relationship for the [contract](contract.md) entity.

### <a name="BKMK_ContractDetail_AsyncOperations"></a> ContractDetail_AsyncOperations

**Added by**: Service Solution

See the [ContractDetail_AsyncOperations](contractdetail.md#BKMK_ContractDetail_AsyncOperations) one-to-many relationship for the [contractdetail](contractdetail.md) entity.

### <a name="BKMK_ContractTemplate_AsyncOperations"></a> ContractTemplate_AsyncOperations

**Added by**: Service Solution

See the [ContractTemplate_AsyncOperations](contracttemplate.md#BKMK_ContractTemplate_AsyncOperations) one-to-many relationship for the [contracttemplate](contracttemplate.md) entity.

### <a name="BKMK_entitlement_AsyncOperations"></a> entitlement_AsyncOperations

**Added by**: Service Solution

See the [entitlement_AsyncOperations](entitlement.md#BKMK_entitlement_AsyncOperations) one-to-many relationship for the [entitlement](entitlement.md) entity.

### <a name="BKMK_entitlementchannel_AsyncOperations"></a> entitlementchannel_AsyncOperations

**Added by**: Service Solution

See the [entitlementchannel_AsyncOperations](entitlementchannel.md#BKMK_entitlementchannel_AsyncOperations) one-to-many relationship for the [entitlementchannel](entitlementchannel.md) entity.

### <a name="BKMK_entitlementtemplate_AsyncOperations"></a> entitlementtemplate_AsyncOperations

**Added by**: Service Solution

See the [entitlementtemplate_AsyncOperations](entitlementtemplate.md#BKMK_entitlementtemplate_AsyncOperations) one-to-many relationship for the [entitlementtemplate](entitlementtemplate.md) entity.

### <a name="BKMK_entitlementtemplatechannel_AsyncOperations"></a> entitlementtemplatechannel_AsyncOperations

**Added by**: Service Solution

See the [entitlementtemplatechannel_AsyncOperations](entitlementtemplatechannel.md#BKMK_entitlementtemplatechannel_AsyncOperations) one-to-many relationship for the [entitlementtemplatechannel](entitlementtemplatechannel.md) entity.

### <a name="BKMK_Equipment_AsyncOperations"></a> Equipment_AsyncOperations

**Added by**: Service Solution

See the [Equipment_AsyncOperations](equipment.md#BKMK_Equipment_AsyncOperations) one-to-many relationship for the [equipment](equipment.md) entity.

### <a name="BKMK_Incident_AsyncOperations"></a> Incident_AsyncOperations

**Added by**: Service Solution

See the [Incident_AsyncOperations](incident.md#BKMK_Incident_AsyncOperations) one-to-many relationship for the [incident](incident.md) entity.

### <a name="BKMK_IncidentResolution_AsyncOperations"></a> IncidentResolution_AsyncOperations

**Added by**: Service Solution

See the [IncidentResolution_AsyncOperations](incidentresolution.md#BKMK_IncidentResolution_AsyncOperations) one-to-many relationship for the [incidentresolution](incidentresolution.md) entity.

### <a name="BKMK_knowledgearticleincident_AsyncOperations"></a> knowledgearticleincident_AsyncOperations

**Added by**: Service Solution

See the [knowledgearticleincident_AsyncOperations](knowledgearticleincident.md#BKMK_knowledgearticleincident_AsyncOperations) one-to-many relationship for the [knowledgearticleincident](knowledgearticleincident.md) entity.

### <a name="BKMK_phonetocaseprocess_AsyncOperations"></a> phonetocaseprocess_AsyncOperations

**Added by**: Service Solution

See the [phonetocaseprocess_AsyncOperations](phonetocaseprocess.md#BKMK_phonetocaseprocess_AsyncOperations) one-to-many relationship for the [phonetocaseprocess](phonetocaseprocess.md) entity.

### <a name="BKMK_Resource_AsyncOperations"></a> Resource_AsyncOperations

**Added by**: Service Solution

See the [Resource_AsyncOperations](resource.md#BKMK_Resource_AsyncOperations) one-to-many relationship for the [resource](resource.md) entity.

### <a name="BKMK_ResourceGroup_AsyncOperations"></a> ResourceGroup_AsyncOperations

**Added by**: Service Solution

See the [ResourceGroup_AsyncOperations](resourcegroup.md#BKMK_ResourceGroup_AsyncOperations) one-to-many relationship for the [resourcegroup](resourcegroup.md) entity.

### <a name="BKMK_ResourceSpec_AsyncOperations"></a> ResourceSpec_AsyncOperations

**Added by**: Service Solution

See the [ResourceSpec_AsyncOperations](resourcespec.md#BKMK_ResourceSpec_AsyncOperations) one-to-many relationship for the [resourcespec](resourcespec.md) entity.

### <a name="BKMK_Service_AsyncOperations"></a> Service_AsyncOperations

**Added by**: Service Solution

See the [Service_AsyncOperations](service.md#BKMK_Service_AsyncOperations) one-to-many relationship for the [service](service.md) entity.

### <a name="BKMK_ServiceAppointment_AsyncOperations"></a> ServiceAppointment_AsyncOperations

**Added by**: Service Solution

See the [ServiceAppointment_AsyncOperations](serviceappointment.md#BKMK_ServiceAppointment_AsyncOperations) one-to-many relationship for the [serviceappointment](serviceappointment.md) entity.

### <a name="BKMK_Site_AsyncOperations"></a> Site_AsyncOperations

**Added by**: Service Solution

See the [Site_AsyncOperations](site.md#BKMK_Site_AsyncOperations) one-to-many relationship for the [site](site.md) entity.

### <a name="BKMK_Discount_AsyncOperations"></a> Discount_AsyncOperations

**Added by**: Sales Solution

See the [Discount_AsyncOperations](discount.md#BKMK_Discount_AsyncOperations) one-to-many relationship for the [discount](discount.md) entity.

### <a name="BKMK_DiscountType_AsyncOperations"></a> DiscountType_AsyncOperations

**Added by**: Sales Solution

See the [DiscountType_AsyncOperations](discounttype.md#BKMK_DiscountType_AsyncOperations) one-to-many relationship for the [discounttype](discounttype.md) entity.

### <a name="BKMK_Invoice_AsyncOperations"></a> Invoice_AsyncOperations

**Added by**: Sales Solution

See the [Invoice_AsyncOperations](invoice.md#BKMK_Invoice_AsyncOperations) one-to-many relationship for the [invoice](invoice.md) entity.

### <a name="BKMK_InvoiceDetail_AsyncOperations"></a> InvoiceDetail_AsyncOperations

**Added by**: Sales Solution

See the [InvoiceDetail_AsyncOperations](invoicedetail.md#BKMK_InvoiceDetail_AsyncOperations) one-to-many relationship for the [invoicedetail](invoicedetail.md) entity.

### <a name="BKMK_leadtoopportunitysalesprocess_AsyncOperations"></a> leadtoopportunitysalesprocess_AsyncOperations

**Added by**: Sales Solution

See the [leadtoopportunitysalesprocess_AsyncOperations](leadtoopportunitysalesprocess.md#BKMK_leadtoopportunitysalesprocess_AsyncOperations) one-to-many relationship for the [leadtoopportunitysalesprocess](leadtoopportunitysalesprocess.md) entity.

### <a name="BKMK_Opportunity_AsyncOperations"></a> Opportunity_AsyncOperations

**Added by**: Sales Solution

See the [Opportunity_AsyncOperations](opportunity.md#BKMK_Opportunity_AsyncOperations) one-to-many relationship for the [opportunity](opportunity.md) entity.

### <a name="BKMK_OpportunityClose_AsyncOperations"></a> OpportunityClose_AsyncOperations

**Added by**: Sales Solution

See the [OpportunityClose_AsyncOperations](opportunityclose.md#BKMK_OpportunityClose_AsyncOperations) one-to-many relationship for the [opportunityclose](opportunityclose.md) entity.

### <a name="BKMK_OpportunityProduct_AsyncOperations"></a> OpportunityProduct_AsyncOperations

**Added by**: Sales Solution

See the [OpportunityProduct_AsyncOperations](opportunityproduct.md#BKMK_OpportunityProduct_AsyncOperations) one-to-many relationship for the [opportunityproduct](opportunityproduct.md) entity.

### <a name="BKMK_opportunitysalesprocess_AsyncOperations"></a> opportunitysalesprocess_AsyncOperations

**Added by**: Sales Solution

See the [opportunitysalesprocess_AsyncOperations](opportunitysalesprocess.md#BKMK_opportunitysalesprocess_AsyncOperations) one-to-many relationship for the [opportunitysalesprocess](opportunitysalesprocess.md) entity.

### <a name="BKMK_OrderClose_AsyncOperations"></a> OrderClose_AsyncOperations

**Added by**: Sales Solution

See the [OrderClose_AsyncOperations](orderclose.md#BKMK_OrderClose_AsyncOperations) one-to-many relationship for the [orderclose](orderclose.md) entity.

### <a name="BKMK_Quote_AsyncOperations"></a> Quote_AsyncOperations

**Added by**: Sales Solution

See the [Quote_AsyncOperations](quote.md#BKMK_Quote_AsyncOperations) one-to-many relationship for the [quote](quote.md) entity.

### <a name="BKMK_QuoteClose_AsyncOperations"></a> QuoteClose_AsyncOperations

**Added by**: Sales Solution

See the [QuoteClose_AsyncOperations](quoteclose.md#BKMK_QuoteClose_AsyncOperations) one-to-many relationship for the [quoteclose](quoteclose.md) entity.

### <a name="BKMK_QuoteDetail_AsyncOperations"></a> QuoteDetail_AsyncOperations

**Added by**: Sales Solution

See the [QuoteDetail_AsyncOperations](quotedetail.md#BKMK_QuoteDetail_AsyncOperations) one-to-many relationship for the [quotedetail](quotedetail.md) entity.

### <a name="BKMK_SalesLiterature_AsyncOperations"></a> SalesLiterature_AsyncOperations

**Added by**: Sales Solution

See the [SalesLiterature_AsyncOperations](salesliterature.md#BKMK_SalesLiterature_AsyncOperations) one-to-many relationship for the [salesliterature](salesliterature.md) entity.

### <a name="BKMK_SalesLiteratureItem_AsyncOperations"></a> SalesLiteratureItem_AsyncOperations

**Added by**: Sales Solution

See the [SalesLiteratureItem_AsyncOperations](salesliteratureitem.md#BKMK_SalesLiteratureItem_AsyncOperations) one-to-many relationship for the [salesliteratureitem](salesliteratureitem.md) entity.

### <a name="BKMK_SalesOrder_AsyncOperations"></a> SalesOrder_AsyncOperations

**Added by**: Sales Solution

See the [SalesOrder_AsyncOperations](salesorder.md#BKMK_SalesOrder_AsyncOperations) one-to-many relationship for the [salesorder](salesorder.md) entity.

### <a name="BKMK_SalesOrderDetail_AsyncOperations"></a> SalesOrderDetail_AsyncOperations

**Added by**: Sales Solution

See the [SalesOrderDetail_AsyncOperations](salesorderdetail.md#BKMK_SalesOrderDetail_AsyncOperations) one-to-many relationship for the [salesorderdetail](salesorderdetail.md) entity.

### <a name="BKMK_Competitor_AsyncOperations"></a> Competitor_AsyncOperations

**Added by**: Sales Solution

See the [Competitor_AsyncOperations](competitor.md#BKMK_Competitor_AsyncOperations) one-to-many relationship for the [competitor](competitor.md) entity.

### <a name="BKMK_msdyn_relationshipinsightsunifiedconfig_AsyncOperations"></a> msdyn_relationshipinsightsunifiedconfig_AsyncOperations

**Added by**: SI Common Solution

See the [msdyn_relationshipinsightsunifiedconfig_AsyncOperations](msdyn_relationshipinsightsunifiedconfig.md#BKMK_msdyn_relationshipinsightsunifiedconfig_AsyncOperations) one-to-many relationship for the [msdyn_relationshipinsightsunifiedconfig](msdyn_relationshipinsightsunifiedconfig.md) entity.

### <a name="BKMK_msdyn_siconfig_AsyncOperations"></a> msdyn_siconfig_AsyncOperations

**Added by**: SI Common Solution

See the [msdyn_siconfig_AsyncOperations](msdyn_siconfig.md#BKMK_msdyn_siconfig_AsyncOperations) one-to-many relationship for the [msdyn_siconfig](msdyn_siconfig.md) entity.

### <a name="BKMK_msdyn_postalbum_AsyncOperations"></a> msdyn_postalbum_AsyncOperations

**Added by**: Activity Feeds Solution

See the [msdyn_postalbum_AsyncOperations](msdyn_postalbum.md#BKMK_msdyn_postalbum_AsyncOperations) one-to-many relationship for the [msdyn_postalbum](msdyn_postalbum.md) entity.

### <a name="BKMK_msdyn_postconfig_AsyncOperations"></a> msdyn_postconfig_AsyncOperations

**Added by**: Activity Feeds Solution

See the [msdyn_postconfig_AsyncOperations](msdyn_postconfig.md#BKMK_msdyn_postconfig_AsyncOperations) one-to-many relationship for the [msdyn_postconfig](msdyn_postconfig.md) entity.

### <a name="BKMK_msdyn_postruleconfig_AsyncOperations"></a> msdyn_postruleconfig_AsyncOperations

**Added by**: Activity Feeds Solution

See the [msdyn_postruleconfig_AsyncOperations](msdyn_postruleconfig.md#BKMK_msdyn_postruleconfig_AsyncOperations) one-to-many relationship for the [msdyn_postruleconfig](msdyn_postruleconfig.md) entity.

### <a name="BKMK_msdyn_wallsavedquery_AsyncOperations"></a> msdyn_wallsavedquery_AsyncOperations

**Added by**: Activity Feeds Solution

See the [msdyn_wallsavedquery_AsyncOperations](msdyn_wallsavedquery.md#BKMK_msdyn_wallsavedquery_AsyncOperations) one-to-many relationship for the [msdyn_wallsavedquery](msdyn_wallsavedquery.md) entity.

### <a name="BKMK_msdyn_wallsavedqueryusersettings_AsyncOperations"></a> msdyn_wallsavedqueryusersettings_AsyncOperations

**Added by**: Activity Feeds Solution

See the [msdyn_wallsavedqueryusersettings_AsyncOperations](msdyn_wallsavedqueryusersettings.md#BKMK_msdyn_wallsavedqueryusersettings_AsyncOperations) one-to-many relationship for the [msdyn_wallsavedqueryusersettings](msdyn_wallsavedqueryusersettings.md) entity.

### <a name="BKMK_KnowledgeBaseRecord_AsyncOperations"></a> KnowledgeBaseRecord_AsyncOperations

See the [KnowledgeBaseRecord_AsyncOperations](knowledgebaserecord.md#BKMK_KnowledgeBaseRecord_AsyncOperations) one-to-many relationship for the [knowledgebaserecord](knowledgebaserecord.md) entity.

### <a name="BKMK_lk_asyncoperation_createdby"></a> lk_asyncoperation_createdby

See the [lk_asyncoperation_createdby](systemuser.md#BKMK_lk_asyncoperation_createdby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_MonthlyFiscalCalendar_AsyncOperations"></a> MonthlyFiscalCalendar_AsyncOperations

See the [MonthlyFiscalCalendar_AsyncOperations](monthlyfiscalcalendar.md#BKMK_MonthlyFiscalCalendar_AsyncOperations) one-to-many relationship for the [monthlyfiscalcalendar](monthlyfiscalcalendar.md) entity.

### <a name="BKMK_lk_asyncoperation_workflowactivationid"></a> lk_asyncoperation_workflowactivationid

See the [lk_asyncoperation_workflowactivationid](workflow.md#BKMK_lk_asyncoperation_workflowactivationid) one-to-many relationship for the [workflow](workflow.md) entity.

### <a name="BKMK_Report_AsyncOperations"></a> Report_AsyncOperations

See the [Report_AsyncOperations](report.md#BKMK_Report_AsyncOperations) one-to-many relationship for the [report](report.md) entity.

### <a name="BKMK_SocialActivity_AsyncOperations"></a> SocialActivity_AsyncOperations

See the [SocialActivity_AsyncOperations](socialactivity.md#BKMK_SocialActivity_AsyncOperations) one-to-many relationship for the [socialactivity](socialactivity.md) entity.

### <a name="BKMK_Connection_Role_AsyncOperations"></a> Connection_Role_AsyncOperations

See the [Connection_Role_AsyncOperations](connectionrole.md#BKMK_Connection_Role_AsyncOperations) one-to-many relationship for the [connectionrole](connectionrole.md) entity.

### <a name="BKMK_Team_AsyncOperations"></a> Team_AsyncOperations

See the [Team_AsyncOperations](team.md#BKMK_Team_AsyncOperations) one-to-many relationship for the [team](team.md) entity.

### <a name="BKMK_AnnualFiscalCalendar_AsyncOperations"></a> AnnualFiscalCalendar_AsyncOperations

See the [AnnualFiscalCalendar_AsyncOperations](annualfiscalcalendar.md#BKMK_AnnualFiscalCalendar_AsyncOperations) one-to-many relationship for the [annualfiscalcalendar](annualfiscalcalendar.md) entity.

### <a name="BKMK_SharePointDocumentLocation_AsyncOperations"></a> SharePointDocumentLocation_AsyncOperations

See the [SharePointDocumentLocation_AsyncOperations](sharepointdocumentlocation.md#BKMK_SharePointDocumentLocation_AsyncOperations) one-to-many relationship for the [sharepointdocumentlocation](sharepointdocumentlocation.md) entity.

### <a name="BKMK_PhoneCall_AsyncOperations"></a> PhoneCall_AsyncOperations

See the [PhoneCall_AsyncOperations](phonecall.md#BKMK_PhoneCall_AsyncOperations) one-to-many relationship for the [phonecall](phonecall.md) entity.

### <a name="BKMK_mailbox_asyncoperations"></a> mailbox_asyncoperations

See the [mailbox_asyncoperations](mailbox.md#BKMK_mailbox_asyncoperations) one-to-many relationship for the [mailbox](mailbox.md) entity.

### <a name="BKMK_PostFollow_AsyncOperations"></a> PostFollow_AsyncOperations

See the [PostFollow_AsyncOperations](postfollow.md#BKMK_PostFollow_AsyncOperations) one-to-many relationship for the [postfollow](postfollow.md) entity.

### <a name="BKMK_Appointment_AsyncOperations"></a> Appointment_AsyncOperations

See the [Appointment_AsyncOperations](appointment.md#BKMK_Appointment_AsyncOperations) one-to-many relationship for the [appointment](appointment.md) entity.

### <a name="BKMK_slabase_AsyncOperations"></a> slabase_AsyncOperations

See the [slabase_AsyncOperations](sla.md#BKMK_slabase_AsyncOperations) one-to-many relationship for the [sla](sla.md) entity.

### <a name="BKMK_SavedQuery_AsyncOperations"></a> SavedQuery_AsyncOperations

See the [SavedQuery_AsyncOperations](savedquery.md#BKMK_SavedQuery_AsyncOperations) one-to-many relationship for the [savedquery](savedquery.md) entity.

### <a name="BKMK_DisplayString_AsyncOperations"></a> DisplayString_AsyncOperations

See the [DisplayString_AsyncOperations](displaystring.md#BKMK_DisplayString_AsyncOperations) one-to-many relationship for the [displaystring](displaystring.md) entity.

### <a name="BKMK_KbArticleComment_AsyncOperations"></a> KbArticleComment_AsyncOperations

See the [KbArticleComment_AsyncOperations](kbarticlecomment.md#BKMK_KbArticleComment_AsyncOperations) one-to-many relationship for the [kbarticlecomment](kbarticlecomment.md) entity.

### <a name="BKMK_ActivityPointer_AsyncOperations"></a> ActivityPointer_AsyncOperations

See the [ActivityPointer_AsyncOperations](activitypointer.md#BKMK_ActivityPointer_AsyncOperations) one-to-many relationship for the [activitypointer](activitypointer.md) entity.

### <a name="BKMK_Subject_AsyncOperations"></a> Subject_AsyncOperations

See the [Subject_AsyncOperations](subject.md#BKMK_Subject_AsyncOperations) one-to-many relationship for the [subject](subject.md) entity.

### <a name="BKMK_goalrollupquery_AsyncOperations"></a> goalrollupquery_AsyncOperations

See the [goalrollupquery_AsyncOperations](goalrollupquery.md#BKMK_goalrollupquery_AsyncOperations) one-to-many relationship for the [goalrollupquery](goalrollupquery.md) entity.

### <a name="BKMK_Role_AsyncOperations"></a> Role_AsyncOperations

See the [Role_AsyncOperations](role.md#BKMK_Role_AsyncOperations) one-to-many relationship for the [role](role.md) entity.

### <a name="BKMK_SystemForm_AsyncOperations"></a> SystemForm_AsyncOperations

See the [SystemForm_AsyncOperations](systemform.md#BKMK_SystemForm_AsyncOperations) one-to-many relationship for the [systemform](systemform.md) entity.

### <a name="BKMK_Annotation_AsyncOperations"></a> Annotation_AsyncOperations

See the [Annotation_AsyncOperations](annotation.md#BKMK_Annotation_AsyncOperations) one-to-many relationship for the [annotation](annotation.md) entity.

### <a name="BKMK_Privilege_AsyncOperations"></a> Privilege_AsyncOperations

See the [Privilege_AsyncOperations](privilege.md#BKMK_Privilege_AsyncOperations) one-to-many relationship for the [privilege](privilege.md) entity.

### <a name="BKMK_ActivityMimeAttachment_AsyncOperations"></a> ActivityMimeAttachment_AsyncOperations

See the [ActivityMimeAttachment_AsyncOperations](activitymimeattachment.md#BKMK_ActivityMimeAttachment_AsyncOperations) one-to-many relationship for the [activitymimeattachment](activitymimeattachment.md) entity.

### <a name="BKMK_Goal_AsyncOperations"></a> Goal_AsyncOperations

See the [Goal_AsyncOperations](goal.md#BKMK_Goal_AsyncOperations) one-to-many relationship for the [goal](goal.md) entity.

### <a name="BKMK_Fax_AsyncOperations"></a> Fax_AsyncOperations

See the [Fax_AsyncOperations](fax.md#BKMK_Fax_AsyncOperations) one-to-many relationship for the [fax](fax.md) entity.

### <a name="BKMK_QuarterlyFiscalCalendar_AsyncOperations"></a> QuarterlyFiscalCalendar_AsyncOperations

See the [QuarterlyFiscalCalendar_AsyncOperations](quarterlyfiscalcalendar.md#BKMK_QuarterlyFiscalCalendar_AsyncOperations) one-to-many relationship for the [quarterlyfiscalcalendar](quarterlyfiscalcalendar.md) entity.

### <a name="BKMK_SharePointSite_AsyncOperations"></a> SharePointSite_AsyncOperations

See the [SharePointSite_AsyncOperations](sharepointsite.md#BKMK_SharePointSite_AsyncOperations) one-to-many relationship for the [sharepointsite](sharepointsite.md) entity.

### <a name="BKMK_UserQuery_AsyncOperations"></a> UserQuery_AsyncOperations

See the [UserQuery_AsyncOperations](userquery.md#BKMK_UserQuery_AsyncOperations) one-to-many relationship for the [userquery](userquery.md) entity.

### <a name="BKMK_ImportMap_AsyncOperations"></a> ImportMap_AsyncOperations

See the [ImportMap_AsyncOperations](importmap.md#BKMK_ImportMap_AsyncOperations) one-to-many relationship for the [importmap](importmap.md) entity.

### <a name="BKMK_BusinessUnit_AsyncOperations"></a> BusinessUnit_AsyncOperations

See the [BusinessUnit_AsyncOperations](businessunit.md#BKMK_BusinessUnit_AsyncOperations) one-to-many relationship for the [businessunit](businessunit.md) entity.

### <a name="BKMK_Queue_AsyncOperations"></a> Queue_AsyncOperations

See the [Queue_AsyncOperations](queue.md#BKMK_Queue_AsyncOperations) one-to-many relationship for the [queue](queue.md) entity.

### <a name="BKMK_QueueItem_AsyncOperations"></a> QueueItem_AsyncOperations

See the [QueueItem_AsyncOperations](queueitem.md#BKMK_QueueItem_AsyncOperations) one-to-many relationship for the [queueitem](queueitem.md) entity.

### <a name="BKMK_team_asyncoperation"></a> team_asyncoperation

See the [team_asyncoperation](team.md#BKMK_team_asyncoperation) one-to-many relationship for the [team](team.md) entity.

### <a name="BKMK_lk_asyncoperation_modifiedby"></a> lk_asyncoperation_modifiedby

See the [lk_asyncoperation_modifiedby](systemuser.md#BKMK_lk_asyncoperation_modifiedby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_UserForm_AsyncOperations"></a> UserForm_AsyncOperations

See the [UserForm_AsyncOperations](userform.md#BKMK_UserForm_AsyncOperations) one-to-many relationship for the [userform](userform.md) entity.

### <a name="BKMK_TransactionCurrency_AsyncOperations"></a> TransactionCurrency_AsyncOperations

See the [TransactionCurrency_AsyncOperations](transactioncurrency.md#BKMK_TransactionCurrency_AsyncOperations) one-to-many relationship for the [transactioncurrency](transactioncurrency.md) entity.

### <a name="BKMK_rollupfield_AsyncOperations"></a> rollupfield_AsyncOperations

See the [rollupfield_AsyncOperations](rollupfield.md#BKMK_rollupfield_AsyncOperations) one-to-many relationship for the [rollupfield](rollupfield.md) entity.

### <a name="BKMK_Letter_AsyncOperations"></a> Letter_AsyncOperations

See the [Letter_AsyncOperations](letter.md#BKMK_Letter_AsyncOperations) one-to-many relationship for the [letter](letter.md) entity.

### <a name="BKMK_KbArticle_AsyncOperations"></a> KbArticle_AsyncOperations

See the [KbArticle_AsyncOperations](kbarticle.md#BKMK_KbArticle_AsyncOperations) one-to-many relationship for the [kbarticle](kbarticle.md) entity.

### <a name="BKMK_RecurringAppointmentMaster_AsyncOperations"></a> RecurringAppointmentMaster_AsyncOperations

See the [RecurringAppointmentMaster_AsyncOperations](recurringappointmentmaster.md#BKMK_RecurringAppointmentMaster_AsyncOperations) one-to-many relationship for the [recurringappointmentmaster](recurringappointmentmaster.md) entity.

### <a name="BKMK_Task_AsyncOperations"></a> Task_AsyncOperations

See the [Task_AsyncOperations](task.md#BKMK_Task_AsyncOperations) one-to-many relationship for the [task](task.md) entity.

### <a name="BKMK_BusinessUnitNewsArticle_AsyncOperations"></a> BusinessUnitNewsArticle_AsyncOperations

See the [BusinessUnitNewsArticle_AsyncOperations](businessunitnewsarticle.md#BKMK_BusinessUnitNewsArticle_AsyncOperations) one-to-many relationship for the [businessunitnewsarticle](businessunitnewsarticle.md) entity.

### <a name="BKMK_Connection_AsyncOperations"></a> Connection_AsyncOperations

See the [Connection_AsyncOperations](connection.md#BKMK_Connection_AsyncOperations) one-to-many relationship for the [connection](connection.md) entity.

### <a name="BKMK_SystemUser_AsyncOperations"></a> SystemUser_AsyncOperations

See the [SystemUser_AsyncOperations](systemuser.md#BKMK_SystemUser_AsyncOperations) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_KbArticleTemplate_AsyncOperations"></a> KbArticleTemplate_AsyncOperations

See the [KbArticleTemplate_AsyncOperations](kbarticletemplate.md#BKMK_KbArticleTemplate_AsyncOperations) one-to-many relationship for the [kbarticletemplate](kbarticletemplate.md) entity.

### <a name="BKMK_SdkMessageProcessingStep_AsyncOperations"></a> SdkMessageProcessingStep_AsyncOperations

See the [SdkMessageProcessingStep_AsyncOperations](sdkmessageprocessingstep.md#BKMK_SdkMessageProcessingStep_AsyncOperations) one-to-many relationship for the [sdkmessageprocessingstep](sdkmessageprocessingstep.md) entity.

### <a name="BKMK_Template_AsyncOperations"></a> Template_AsyncOperations

See the [Template_AsyncOperations](template.md#BKMK_Template_AsyncOperations) one-to-many relationship for the [template](template.md) entity.

### <a name="BKMK_CustomerAddress_AsyncOperations"></a> CustomerAddress_AsyncOperations

See the [CustomerAddress_AsyncOperations](customeraddress.md#BKMK_CustomerAddress_AsyncOperations) one-to-many relationship for the [customeraddress](customeraddress.md) entity.

### <a name="BKMK_Contact_AsyncOperations"></a> Contact_AsyncOperations

See the [Contact_AsyncOperations](contact.md#BKMK_Contact_AsyncOperations) one-to-many relationship for the [contact](contact.md) entity.

### <a name="BKMK_emailserverprofile_asyncoperations"></a> emailserverprofile_asyncoperations

See the [emailserverprofile_asyncoperations](emailserverprofile.md#BKMK_emailserverprofile_asyncoperations) one-to-many relationship for the [emailserverprofile](emailserverprofile.md) entity.

### <a name="BKMK_lk_asyncoperation_createdonbehalfby"></a> lk_asyncoperation_createdonbehalfby

See the [lk_asyncoperation_createdonbehalfby](systemuser.md#BKMK_lk_asyncoperation_createdonbehalfby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_Import_AsyncOperations"></a> Import_AsyncOperations

See the [Import_AsyncOperations](import.md#BKMK_Import_AsyncOperations) one-to-many relationship for the [import](import.md) entity.

### <a name="BKMK_system_user_asyncoperation"></a> system_user_asyncoperation

See the [system_user_asyncoperation](systemuser.md#BKMK_system_user_asyncoperation) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_business_unit_asyncoperation"></a> business_unit_asyncoperation

See the [business_unit_asyncoperation](businessunit.md#BKMK_business_unit_asyncoperation) one-to-many relationship for the [businessunit](businessunit.md) entity.

### <a name="BKMK_ImportLog_AsyncOperations"></a> ImportLog_AsyncOperations

See the [ImportLog_AsyncOperations](importlog.md#BKMK_ImportLog_AsyncOperations) one-to-many relationship for the [importlog](importlog.md) entity.

### <a name="BKMK_metric_AsyncOperations"></a> metric_AsyncOperations

See the [metric_AsyncOperations](metric.md#BKMK_metric_AsyncOperations) one-to-many relationship for the [metric](metric.md) entity.

### <a name="BKMK_SocialProfile_AsyncOperations"></a> SocialProfile_AsyncOperations

See the [SocialProfile_AsyncOperations](socialprofile.md#BKMK_SocialProfile_AsyncOperations) one-to-many relationship for the [socialprofile](socialprofile.md) entity.

### <a name="BKMK_lk_asyncoperation_modifiedonbehalfby"></a> lk_asyncoperation_modifiedonbehalfby

See the [lk_asyncoperation_modifiedonbehalfby](systemuser.md#BKMK_lk_asyncoperation_modifiedonbehalfby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_Account_AsyncOperations"></a> Account_AsyncOperations

See the [Account_AsyncOperations](account.md#BKMK_Account_AsyncOperations) one-to-many relationship for the [account](account.md) entity.

### <a name="BKMK_Email_AsyncOperations"></a> Email_AsyncOperations

See the [Email_AsyncOperations](email.md#BKMK_Email_AsyncOperations) one-to-many relationship for the [email](email.md) entity.

### <a name="BKMK_FixedMonthlyFiscalCalendar_AsyncOperations"></a> FixedMonthlyFiscalCalendar_AsyncOperations

See the [FixedMonthlyFiscalCalendar_AsyncOperations](fixedmonthlyfiscalcalendar.md#BKMK_FixedMonthlyFiscalCalendar_AsyncOperations) one-to-many relationship for the [fixedmonthlyfiscalcalendar](fixedmonthlyfiscalcalendar.md) entity.

### <a name="BKMK_SemiAnnualFiscalCalendar_AsyncOperations"></a> SemiAnnualFiscalCalendar_AsyncOperations

See the [SemiAnnualFiscalCalendar_AsyncOperations](semiannualfiscalcalendar.md#BKMK_SemiAnnualFiscalCalendar_AsyncOperations) one-to-many relationship for the [semiannualfiscalcalendar](semiannualfiscalcalendar.md) entity.

### <a name="BKMK_MailMergeTemplate_AsyncOperations"></a> MailMergeTemplate_AsyncOperations

See the [MailMergeTemplate_AsyncOperations](mailmergetemplate.md#BKMK_MailMergeTemplate_AsyncOperations) one-to-many relationship for the [mailmergetemplate](mailmergetemplate.md) entity.

### <a name="BKMK_Organization_AsyncOperations"></a> Organization_AsyncOperations

See the [Organization_AsyncOperations](organization.md#BKMK_Organization_AsyncOperations) one-to-many relationship for the [organization](organization.md) entity.

### <a name="BKMK_Calendar_AsyncOperations"></a> Calendar_AsyncOperations

See the [Calendar_AsyncOperations](calendar.md#BKMK_Calendar_AsyncOperations) one-to-many relationship for the [calendar](calendar.md) entity.

### <a name="BKMK_ImportFile_AsyncOperations"></a> ImportFile_AsyncOperations

See the [ImportFile_AsyncOperations](importfile.md#BKMK_ImportFile_AsyncOperations) one-to-many relationship for the [importfile](importfile.md) entity.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Web API EntityType Reference](/power-apps/developer/data-platform/webapi/reference/entitytypes)
