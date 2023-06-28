---
title: "ProcessSession entity reference (Dynamics 365 Customer Engagement) | Microsoft Docs"
description: "Includes schema information and supported messages for the ProcessSession entity."
ms.date: 08/30/2022
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "KumarVivek"
ms.author: "kvivek"
search.audienceType: 
  - developer
---

# ProcessSession entity reference

Information that is generated when a dialog is run. Every time that you run a dialog, a dialog session is created.


## Messages

|Message|SDK class or method|
|-|-|
|Assign|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|GrantAccess|<xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>|
|ModifyAccess|<xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>|
|Retrieve|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|RetrieveSharedPrincipalsAndAccess|<xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>|
|RevokeAccess|<xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>|
|SetState|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

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
|Targets|account,annotation,appointment,bookableresource,bookableresourcebooking,bookableresourcebookingheader,bookableresourcecategory,bookableresourcecategoryassn,bookableresourcecharacteristic,bookableresourcegroup,bookingstatus,businessunit,businessunitnewsarticle,campaign,campaignactivity,campaignresponse,channelaccessprofile,channelaccessprofilerule,characteristic,competitor,connection,connectionrole,constraintbasedgroup,contact,contract,contractdetail,contracttemplate,convertrule,customeraddress,customeropportunityrole,customerrelationship,discount,discounttype,email,entitlement,entitlementchannel,entitlementtemplate,equipment,expiredprocess,externalparty,externalpartyitem,fax,goal,goalrollupquery,incident,invoice,invoicedetail,kbarticle,kbarticlecomment,kbarticletemplate,knowledgearticle,knowledgearticleincident,knowledgebaserecord,lead,leadtoopportunitysalesprocess,letter,list,mailbox,mailmergetemplate,metric,msdyn_postalbum,msdyn_postconfig,msdyn_postruleconfig,msdyn_relationshipinsightsunifiedconfig,msdyn_siconfig,msdyn_wallsavedquery,msdyn_wallsavedqueryusersettings,newprocess,opportunity,opportunityproduct,opportunitysalesprocess,phonecall,phonetocaseprocess,position,pricelevel,product,productassociation,productpricelevel,productsubstitute,queue,queueitem,quote,quotedetail,ratingmodel,ratingvalue,recurringappointmentmaster,relationshiprole,report,rollupfield,routingrule,routingruleitem,salesliterature,salesliteratureitem,salesorder,salesorderdetail,service,serviceappointment,sharepointdocumentlocation,sharepointsite,site,sla,socialactivity,socialprofile,subject,systemuser,task,team,template,territory,theme,transactioncurrency,translationprocess,usermapping|
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

#### StateCode Choices/Options

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

#### StatusCode Choices/Options

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

Same as the [lk_workflowlog_processsession](workflowlog.md#BKMK_lk_workflowlog_processsession) many-to-one relationship for the [workflowlog](workflowlog.md) entity.

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

Same as the [lk_workflowlog_processsession_childworkflow](workflowlog.md#BKMK_lk_workflowlog_processsession_childworkflow) many-to-one relationship for the [workflowlog](workflowlog.md) entity.

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

Same as the [lk_processsession_previouslinkedsessionid](processsession.md#BKMK_lk_processsession_previouslinkedsessionid) many-to-one relationship for the [processsession](processsession.md) entity.

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

Same as the [lk_processsession_nextlinkedsessionid](processsession.md#BKMK_lk_processsession_nextlinkedsessionid) many-to-one relationship for the [processsession](processsession.md) entity.

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

Same as the [lk_processsession_originatingsessionid](processsession.md#BKMK_lk_processsession_originatingsessionid) many-to-one relationship for the [processsession](processsession.md) entity.

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

Same as the [processsession_connections2](connection.md#BKMK_processsession_connections2) many-to-one relationship for the [connection](connection.md) entity.

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

Same as the [ProcessSession_SyncErrors](syncerror.md#BKMK_ProcessSession_SyncErrors) many-to-one relationship for the [syncerror](syncerror.md) entity.

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

Same as the [processsession_connections1](connection.md#BKMK_processsession_connections1) many-to-one relationship for the [connection](connection.md) entity.

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

Same as the [processsession_PostFollows](postfollow.md#BKMK_processsession_PostFollows) many-to-one relationship for the [postfollow](postfollow.md) entity.

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

- [theme_ProcessSession](#BKMK_theme_ProcessSession)
- [usermapping_ProcessSession](#BKMK_usermapping_ProcessSession)
- [knowledgearticle_ProcessSession](#BKMK_knowledgearticle_ProcessSession)
- [position_ProcessSession](#BKMK_position_ProcessSession)
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
- [msdyn_relationshipinsightsunifiedconfig_ProcessSession](#BKMK_msdyn_relationshipinsightsunifiedconfig_ProcessSession)
- [msdyn_siconfig_ProcessSession](#BKMK_msdyn_siconfig_ProcessSession)
- [msdyn_postalbum_ProcessSession](#BKMK_msdyn_postalbum_ProcessSession)
- [msdyn_postconfig_ProcessSession](#BKMK_msdyn_postconfig_ProcessSession)
- [msdyn_postruleconfig_ProcessSession](#BKMK_msdyn_postruleconfig_ProcessSession)
- [msdyn_wallsavedquery_ProcessSession](#BKMK_msdyn_wallsavedquery_ProcessSession)
- [msdyn_wallsavedqueryusersettings_ProcessSession](#BKMK_msdyn_wallsavedqueryusersettings_ProcessSession)
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


### <a name="BKMK_theme_ProcessSession"></a> theme_ProcessSession

See the [theme_ProcessSession](theme.md#BKMK_theme_ProcessSession) one-to-many relationship for the [theme](theme.md) entity.

### <a name="BKMK_usermapping_ProcessSession"></a> usermapping_ProcessSession

See the [usermapping_ProcessSession](usermapping.md#BKMK_usermapping_ProcessSession) one-to-many relationship for the [usermapping](usermapping.md) entity.

### <a name="BKMK_knowledgearticle_ProcessSession"></a> knowledgearticle_ProcessSession

See the [knowledgearticle_ProcessSession](knowledgearticle.md#BKMK_knowledgearticle_ProcessSession) one-to-many relationship for the [knowledgearticle](knowledgearticle.md) entity.

### <a name="BKMK_position_ProcessSession"></a> position_ProcessSession

See the [position_ProcessSession](position.md#BKMK_position_ProcessSession) one-to-many relationship for the [position](position.md) entity.

### <a name="BKMK_Territory_ProcessSessions"></a> Territory_ProcessSessions

**Added by**: Application Common Solution

See the [Territory_ProcessSessions](territory.md#BKMK_Territory_ProcessSessions) one-to-many relationship for the [territory](territory.md) entity.

### <a name="BKMK_Lead_ProcessSessions"></a> Lead_ProcessSessions

**Added by**: Lead Management Solution

See the [Lead_ProcessSessions](lead.md#BKMK_Lead_ProcessSessions) one-to-many relationship for the [lead](lead.md) entity.

### <a name="BKMK_PriceLevel_ProcessSessions"></a> PriceLevel_ProcessSessions

**Added by**: Product Management Solution

See the [PriceLevel_ProcessSessions](pricelevel.md#BKMK_PriceLevel_ProcessSessions) one-to-many relationship for the [pricelevel](pricelevel.md) entity.

### <a name="BKMK_Product_ProcessSessions"></a> Product_ProcessSessions

**Added by**: Product Management Solution

See the [Product_ProcessSessions](product.md#BKMK_Product_ProcessSessions) one-to-many relationship for the [product](product.md) entity.

### <a name="BKMK_ProductAssociation_ProcessSessions"></a> ProductAssociation_ProcessSessions

**Added by**: Product Management Solution

See the [ProductAssociation_ProcessSessions](productassociation.md#BKMK_ProductAssociation_ProcessSessions) one-to-many relationship for the [productassociation](productassociation.md) entity.

### <a name="BKMK_ProductPriceLevel_ProcessSessions"></a> ProductPriceLevel_ProcessSessions

**Added by**: Product Management Solution

See the [ProductPriceLevel_ProcessSessions](productpricelevel.md#BKMK_ProductPriceLevel_ProcessSessions) one-to-many relationship for the [productpricelevel](productpricelevel.md) entity.

### <a name="BKMK_ProductSubstitute_ProcessSession"></a> ProductSubstitute_ProcessSession

**Added by**: Product Management Solution

See the [ProductSubstitute_ProcessSession](productsubstitute.md#BKMK_ProductSubstitute_ProcessSession) one-to-many relationship for the [productsubstitute](productsubstitute.md) entity.

### <a name="BKMK_bookableresource_ProcessSession"></a> bookableresource_ProcessSession

**Added by**: Scheduling Solution

See the [bookableresource_ProcessSession](bookableresource.md#BKMK_bookableresource_ProcessSession) one-to-many relationship for the [bookableresource](bookableresource.md) entity.

### <a name="BKMK_bookableresourcebooking_ProcessSession"></a> bookableresourcebooking_ProcessSession

**Added by**: Scheduling Solution

See the [bookableresourcebooking_ProcessSession](bookableresourcebooking.md#BKMK_bookableresourcebooking_ProcessSession) one-to-many relationship for the [bookableresourcebooking](bookableresourcebooking.md) entity.

### <a name="BKMK_bookableresourcebookingheader_ProcessSession"></a> bookableresourcebookingheader_ProcessSession

**Added by**: Scheduling Solution

See the [bookableresourcebookingheader_ProcessSession](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_ProcessSession) one-to-many relationship for the [bookableresourcebookingheader](bookableresourcebookingheader.md) entity.

### <a name="BKMK_bookableresourcecategory_ProcessSession"></a> bookableresourcecategory_ProcessSession

**Added by**: Scheduling Solution

See the [bookableresourcecategory_ProcessSession](bookableresourcecategory.md#BKMK_bookableresourcecategory_ProcessSession) one-to-many relationship for the [bookableresourcecategory](bookableresourcecategory.md) entity.

### <a name="BKMK_bookableresourcecategoryassn_ProcessSession"></a> bookableresourcecategoryassn_ProcessSession

**Added by**: Scheduling Solution

See the [bookableresourcecategoryassn_ProcessSession](bookableresourcecategoryassn.md#BKMK_bookableresourcecategoryassn_ProcessSession) one-to-many relationship for the [bookableresourcecategoryassn](bookableresourcecategoryassn.md) entity.

### <a name="BKMK_bookableresourcecharacteristic_ProcessSession"></a> bookableresourcecharacteristic_ProcessSession

**Added by**: Scheduling Solution

See the [bookableresourcecharacteristic_ProcessSession](bookableresourcecharacteristic.md#BKMK_bookableresourcecharacteristic_ProcessSession) one-to-many relationship for the [bookableresourcecharacteristic](bookableresourcecharacteristic.md) entity.

### <a name="BKMK_bookableresourcegroup_ProcessSession"></a> bookableresourcegroup_ProcessSession

**Added by**: Scheduling Solution

See the [bookableresourcegroup_ProcessSession](bookableresourcegroup.md#BKMK_bookableresourcegroup_ProcessSession) one-to-many relationship for the [bookableresourcegroup](bookableresourcegroup.md) entity.

### <a name="BKMK_bookingstatus_ProcessSession"></a> bookingstatus_ProcessSession

**Added by**: Scheduling Solution

See the [bookingstatus_ProcessSession](bookingstatus.md#BKMK_bookingstatus_ProcessSession) one-to-many relationship for the [bookingstatus](bookingstatus.md) entity.

### <a name="BKMK_characteristic_ProcessSession"></a> characteristic_ProcessSession

**Added by**: Scheduling Solution

See the [characteristic_ProcessSession](characteristic.md#BKMK_characteristic_ProcessSession) one-to-many relationship for the [characteristic](characteristic.md) entity.

### <a name="BKMK_ratingmodel_ProcessSession"></a> ratingmodel_ProcessSession

**Added by**: Scheduling Solution

See the [ratingmodel_ProcessSession](ratingmodel.md#BKMK_ratingmodel_ProcessSession) one-to-many relationship for the [ratingmodel](ratingmodel.md) entity.

### <a name="BKMK_ratingvalue_ProcessSession"></a> ratingvalue_ProcessSession

**Added by**: Scheduling Solution

See the [ratingvalue_ProcessSession](ratingvalue.md#BKMK_ratingvalue_ProcessSession) one-to-many relationship for the [ratingvalue](ratingvalue.md) entity.

### <a name="BKMK_Campaign_ProcessSessions"></a> Campaign_ProcessSessions

**Added by**: Marketing Solution

See the [Campaign_ProcessSessions](campaign.md#BKMK_Campaign_ProcessSessions) one-to-many relationship for the [campaign](campaign.md) entity.

### <a name="BKMK_CampaignActivity_ProcessSessions"></a> CampaignActivity_ProcessSessions

**Added by**: Marketing Solution

See the [CampaignActivity_ProcessSessions](campaignactivity.md#BKMK_CampaignActivity_ProcessSessions) one-to-many relationship for the [campaignactivity](campaignactivity.md) entity.

### <a name="BKMK_CampaignResponse_ProcessSessions"></a> CampaignResponse_ProcessSessions

**Added by**: Marketing Solution

See the [CampaignResponse_ProcessSessions](campaignresponse.md#BKMK_CampaignResponse_ProcessSessions) one-to-many relationship for the [campaignresponse](campaignresponse.md) entity.

### <a name="BKMK_List_ProcessSessions"></a> List_ProcessSessions

**Added by**: Marketing Solution

See the [List_ProcessSessions](list.md#BKMK_List_ProcessSessions) one-to-many relationship for the [list](list.md) entity.

### <a name="BKMK_ConstraintBasedGroup_ProcessSessions"></a> ConstraintBasedGroup_ProcessSessions

**Added by**: Service Solution

See the [ConstraintBasedGroup_ProcessSessions](constraintbasedgroup.md#BKMK_ConstraintBasedGroup_ProcessSessions) one-to-many relationship for the [constraintbasedgroup](constraintbasedgroup.md) entity.

### <a name="BKMK_Contract_ProcessSessions"></a> Contract_ProcessSessions

**Added by**: Service Solution

See the [Contract_ProcessSessions](contract.md#BKMK_Contract_ProcessSessions) one-to-many relationship for the [contract](contract.md) entity.

### <a name="BKMK_ContractDetail_ProcessSessions"></a> ContractDetail_ProcessSessions

**Added by**: Service Solution

See the [ContractDetail_ProcessSessions](contractdetail.md#BKMK_ContractDetail_ProcessSessions) one-to-many relationship for the [contractdetail](contractdetail.md) entity.

### <a name="BKMK_ContractTemplate_ProcessSessions"></a> ContractTemplate_ProcessSessions

**Added by**: Service Solution

See the [ContractTemplate_ProcessSessions](contracttemplate.md#BKMK_ContractTemplate_ProcessSessions) one-to-many relationship for the [contracttemplate](contracttemplate.md) entity.

### <a name="BKMK_entitlement_ProcessSession"></a> entitlement_ProcessSession

**Added by**: Service Solution

See the [entitlement_ProcessSession](entitlement.md#BKMK_entitlement_ProcessSession) one-to-many relationship for the [entitlement](entitlement.md) entity.

### <a name="BKMK_entitlementtemplate_ProcessSession"></a> entitlementtemplate_ProcessSession

**Added by**: Service Solution

See the [entitlementtemplate_ProcessSession](entitlementtemplate.md#BKMK_entitlementtemplate_ProcessSession) one-to-many relationship for the [entitlementtemplate](entitlementtemplate.md) entity.

### <a name="BKMK_Equipment_ProcessSessions"></a> Equipment_ProcessSessions

**Added by**: Service Solution

See the [Equipment_ProcessSessions](equipment.md#BKMK_Equipment_ProcessSessions) one-to-many relationship for the [equipment](equipment.md) entity.

### <a name="BKMK_Incident_ProcessSessions"></a> Incident_ProcessSessions

**Added by**: Service Solution

See the [Incident_ProcessSessions](incident.md#BKMK_Incident_ProcessSessions) one-to-many relationship for the [incident](incident.md) entity.

### <a name="BKMK_knowledgearticleincident_ProcessSession"></a> knowledgearticleincident_ProcessSession

**Added by**: Service Solution

See the [knowledgearticleincident_ProcessSession](knowledgearticleincident.md#BKMK_knowledgearticleincident_ProcessSession) one-to-many relationship for the [knowledgearticleincident](knowledgearticleincident.md) entity.

### <a name="BKMK_phonetocaseprocess_ProcessSession"></a> phonetocaseprocess_ProcessSession

**Added by**: Service Solution

See the [phonetocaseprocess_ProcessSession](phonetocaseprocess.md#BKMK_phonetocaseprocess_ProcessSession) one-to-many relationship for the [phonetocaseprocess](phonetocaseprocess.md) entity.

### <a name="BKMK_Service_ProcessSessions"></a> Service_ProcessSessions

**Added by**: Service Solution

See the [Service_ProcessSessions](service.md#BKMK_Service_ProcessSessions) one-to-many relationship for the [service](service.md) entity.

### <a name="BKMK_ServiceAppointment_ProcessSessions"></a> ServiceAppointment_ProcessSessions

**Added by**: Service Solution

See the [ServiceAppointment_ProcessSessions](serviceappointment.md#BKMK_ServiceAppointment_ProcessSessions) one-to-many relationship for the [serviceappointment](serviceappointment.md) entity.

### <a name="BKMK_Site_ProcessSessions"></a> Site_ProcessSessions

**Added by**: Service Solution

See the [Site_ProcessSessions](site.md#BKMK_Site_ProcessSessions) one-to-many relationship for the [site](site.md) entity.

### <a name="BKMK_entitlementchannel_ProcessSession"></a> entitlementchannel_ProcessSession

**Added by**: Service Solution

See the [entitlementchannel_ProcessSession](entitlementchannel.md#BKMK_entitlementchannel_ProcessSession) one-to-many relationship for the [entitlementchannel](entitlementchannel.md) entity.

### <a name="BKMK_Discount_ProcessSessions"></a> Discount_ProcessSessions

**Added by**: Sales Solution

See the [Discount_ProcessSessions](discount.md#BKMK_Discount_ProcessSessions) one-to-many relationship for the [discount](discount.md) entity.

### <a name="BKMK_DiscountType_ProcessSessions"></a> DiscountType_ProcessSessions

**Added by**: Sales Solution

See the [DiscountType_ProcessSessions](discounttype.md#BKMK_DiscountType_ProcessSessions) one-to-many relationship for the [discounttype](discounttype.md) entity.

### <a name="BKMK_Invoice_ProcessSessions"></a> Invoice_ProcessSessions

**Added by**: Sales Solution

See the [Invoice_ProcessSessions](invoice.md#BKMK_Invoice_ProcessSessions) one-to-many relationship for the [invoice](invoice.md) entity.

### <a name="BKMK_InvoiceDetail_ProcessSessions"></a> InvoiceDetail_ProcessSessions

**Added by**: Sales Solution

See the [InvoiceDetail_ProcessSessions](invoicedetail.md#BKMK_InvoiceDetail_ProcessSessions) one-to-many relationship for the [invoicedetail](invoicedetail.md) entity.

### <a name="BKMK_leadtoopportunitysalesprocess_ProcessSession"></a> leadtoopportunitysalesprocess_ProcessSession

**Added by**: Sales Solution

See the [leadtoopportunitysalesprocess_ProcessSession](leadtoopportunitysalesprocess.md#BKMK_leadtoopportunitysalesprocess_ProcessSession) one-to-many relationship for the [leadtoopportunitysalesprocess](leadtoopportunitysalesprocess.md) entity.

### <a name="BKMK_Opportunity_ProcessSessions"></a> Opportunity_ProcessSessions

**Added by**: Sales Solution

See the [Opportunity_ProcessSessions](opportunity.md#BKMK_Opportunity_ProcessSessions) one-to-many relationship for the [opportunity](opportunity.md) entity.

### <a name="BKMK_OpportunityProduct_ProcessSessions"></a> OpportunityProduct_ProcessSessions

**Added by**: Sales Solution

See the [OpportunityProduct_ProcessSessions](opportunityproduct.md#BKMK_OpportunityProduct_ProcessSessions) one-to-many relationship for the [opportunityproduct](opportunityproduct.md) entity.

### <a name="BKMK_opportunitysalesprocess_ProcessSession"></a> opportunitysalesprocess_ProcessSession

**Added by**: Sales Solution

See the [opportunitysalesprocess_ProcessSession](opportunitysalesprocess.md#BKMK_opportunitysalesprocess_ProcessSession) one-to-many relationship for the [opportunitysalesprocess](opportunitysalesprocess.md) entity.

### <a name="BKMK_Quote_ProcessSessions"></a> Quote_ProcessSessions

**Added by**: Sales Solution

See the [Quote_ProcessSessions](quote.md#BKMK_Quote_ProcessSessions) one-to-many relationship for the [quote](quote.md) entity.

### <a name="BKMK_QuoteDetail_ProcessSessions"></a> QuoteDetail_ProcessSessions

**Added by**: Sales Solution

See the [QuoteDetail_ProcessSessions](quotedetail.md#BKMK_QuoteDetail_ProcessSessions) one-to-many relationship for the [quotedetail](quotedetail.md) entity.

### <a name="BKMK_SalesLiterature_ProcessSessions"></a> SalesLiterature_ProcessSessions

**Added by**: Sales Solution

See the [SalesLiterature_ProcessSessions](salesliterature.md#BKMK_SalesLiterature_ProcessSessions) one-to-many relationship for the [salesliterature](salesliterature.md) entity.

### <a name="BKMK_SalesLiteratureItem_ProcessSessions"></a> SalesLiteratureItem_ProcessSessions

**Added by**: Sales Solution

See the [SalesLiteratureItem_ProcessSessions](salesliteratureitem.md#BKMK_SalesLiteratureItem_ProcessSessions) one-to-many relationship for the [salesliteratureitem](salesliteratureitem.md) entity.

### <a name="BKMK_SalesOrder_ProcessSessions"></a> SalesOrder_ProcessSessions

**Added by**: Sales Solution

See the [SalesOrder_ProcessSessions](salesorder.md#BKMK_SalesOrder_ProcessSessions) one-to-many relationship for the [salesorder](salesorder.md) entity.

### <a name="BKMK_SalesOrderDetail_ProcessSessions"></a> SalesOrderDetail_ProcessSessions

**Added by**: Sales Solution

See the [SalesOrderDetail_ProcessSessions](salesorderdetail.md#BKMK_SalesOrderDetail_ProcessSessions) one-to-many relationship for the [salesorderdetail](salesorderdetail.md) entity.

### <a name="BKMK_Competitor_ProcessSessions"></a> Competitor_ProcessSessions

**Added by**: Sales Solution

See the [Competitor_ProcessSessions](competitor.md#BKMK_Competitor_ProcessSessions) one-to-many relationship for the [competitor](competitor.md) entity.

### <a name="BKMK_msdyn_relationshipinsightsunifiedconfig_ProcessSession"></a> msdyn_relationshipinsightsunifiedconfig_ProcessSession

**Added by**: SI Common Solution

See the [msdyn_relationshipinsightsunifiedconfig_ProcessSession](msdyn_relationshipinsightsunifiedconfig.md#BKMK_msdyn_relationshipinsightsunifiedconfig_ProcessSession) one-to-many relationship for the [msdyn_relationshipinsightsunifiedconfig](msdyn_relationshipinsightsunifiedconfig.md) entity.

### <a name="BKMK_msdyn_siconfig_ProcessSession"></a> msdyn_siconfig_ProcessSession

**Added by**: SI Common Solution

See the [msdyn_siconfig_ProcessSession](msdyn_siconfig.md#BKMK_msdyn_siconfig_ProcessSession) one-to-many relationship for the [msdyn_siconfig](msdyn_siconfig.md) entity.

### <a name="BKMK_msdyn_postalbum_ProcessSession"></a> msdyn_postalbum_ProcessSession

**Added by**: Activity Feeds Solution

See the [msdyn_postalbum_ProcessSession](msdyn_postalbum.md#BKMK_msdyn_postalbum_ProcessSession) one-to-many relationship for the [msdyn_postalbum](msdyn_postalbum.md) entity.

### <a name="BKMK_msdyn_postconfig_ProcessSession"></a> msdyn_postconfig_ProcessSession

**Added by**: Activity Feeds Solution

See the [msdyn_postconfig_ProcessSession](msdyn_postconfig.md#BKMK_msdyn_postconfig_ProcessSession) one-to-many relationship for the [msdyn_postconfig](msdyn_postconfig.md) entity.

### <a name="BKMK_msdyn_postruleconfig_ProcessSession"></a> msdyn_postruleconfig_ProcessSession

**Added by**: Activity Feeds Solution

See the [msdyn_postruleconfig_ProcessSession](msdyn_postruleconfig.md#BKMK_msdyn_postruleconfig_ProcessSession) one-to-many relationship for the [msdyn_postruleconfig](msdyn_postruleconfig.md) entity.

### <a name="BKMK_msdyn_wallsavedquery_ProcessSession"></a> msdyn_wallsavedquery_ProcessSession

**Added by**: Activity Feeds Solution

See the [msdyn_wallsavedquery_ProcessSession](msdyn_wallsavedquery.md#BKMK_msdyn_wallsavedquery_ProcessSession) one-to-many relationship for the [msdyn_wallsavedquery](msdyn_wallsavedquery.md) entity.

### <a name="BKMK_msdyn_wallsavedqueryusersettings_ProcessSession"></a> msdyn_wallsavedqueryusersettings_ProcessSession

**Added by**: Activity Feeds Solution

See the [msdyn_wallsavedqueryusersettings_ProcessSession](msdyn_wallsavedqueryusersettings.md#BKMK_msdyn_wallsavedqueryusersettings_ProcessSession) one-to-many relationship for the [msdyn_wallsavedqueryusersettings](msdyn_wallsavedqueryusersettings.md) entity.

### <a name="BKMK_KnowledgeBaseRecord_ProcessSession"></a> KnowledgeBaseRecord_ProcessSession

See the [KnowledgeBaseRecord_ProcessSession](knowledgebaserecord.md#BKMK_KnowledgeBaseRecord_ProcessSession) one-to-many relationship for the [knowledgebaserecord](knowledgebaserecord.md) entity.

### <a name="BKMK_SharePointSite_ProcessSessions"></a> SharePointSite_ProcessSessions

See the [SharePointSite_ProcessSessions](sharepointsite.md#BKMK_SharePointSite_ProcessSessions) one-to-many relationship for the [sharepointsite](sharepointsite.md) entity.

### <a name="BKMK_MailMergeTemplate_ProcessSessions"></a> MailMergeTemplate_ProcessSessions

See the [MailMergeTemplate_ProcessSessions](mailmergetemplate.md#BKMK_MailMergeTemplate_ProcessSessions) one-to-many relationship for the [mailmergetemplate](mailmergetemplate.md) entity.

### <a name="BKMK_Annotation_ProcessSessions"></a> Annotation_ProcessSessions

See the [Annotation_ProcessSessions](annotation.md#BKMK_Annotation_ProcessSessions) one-to-many relationship for the [annotation](annotation.md) entity.

### <a name="BKMK_BusinessUnitNewsArticle_ProcessSessions"></a> BusinessUnitNewsArticle_ProcessSessions

See the [BusinessUnitNewsArticle_ProcessSessions](businessunitnewsarticle.md#BKMK_BusinessUnitNewsArticle_ProcessSessions) one-to-many relationship for the [businessunitnewsarticle](businessunitnewsarticle.md) entity.

### <a name="BKMK_Appointment_ProcessSessions"></a> Appointment_ProcessSessions

See the [Appointment_ProcessSessions](appointment.md#BKMK_Appointment_ProcessSessions) one-to-many relationship for the [appointment](appointment.md) entity.

### <a name="BKMK_QueueItem_ProcessSessions"></a> QueueItem_ProcessSessions

See the [QueueItem_ProcessSessions](queueitem.md#BKMK_QueueItem_ProcessSessions) one-to-many relationship for the [queueitem](queueitem.md) entity.

### <a name="BKMK_lk_processsession_previouslinkedsessionid"></a> lk_processsession_previouslinkedsessionid

See the [lk_processsession_previouslinkedsessionid](processsession.md#BKMK_lk_processsession_previouslinkedsessionid) one-to-many relationship for the [processsession](processsession.md) entity.

### <a name="BKMK_lk_processsession_nextlinkedsessionid"></a> lk_processsession_nextlinkedsessionid

See the [lk_processsession_nextlinkedsessionid](processsession.md#BKMK_lk_processsession_nextlinkedsessionid) one-to-many relationship for the [processsession](processsession.md) entity.

### <a name="BKMK_lk_processsession_originatingsessionid"></a> lk_processsession_originatingsessionid

See the [lk_processsession_originatingsessionid](processsession.md#BKMK_lk_processsession_originatingsessionid) one-to-many relationship for the [processsession](processsession.md) entity.

### <a name="BKMK_Team_ProcessSessions"></a> Team_ProcessSessions

See the [Team_ProcessSessions](team.md#BKMK_Team_ProcessSessions) one-to-many relationship for the [team](team.md) entity.

### <a name="BKMK_Goal_ProcessSessions"></a> Goal_ProcessSessions

See the [Goal_ProcessSessions](goal.md#BKMK_Goal_ProcessSessions) one-to-many relationship for the [goal](goal.md) entity.

### <a name="BKMK_mailbox_processsessions"></a> mailbox_processsessions

See the [mailbox_processsessions](mailbox.md#BKMK_mailbox_processsessions) one-to-many relationship for the [mailbox](mailbox.md) entity.

### <a name="BKMK_TranslationProcess_ProcessSessions"></a> TranslationProcess_ProcessSessions

See the [TranslationProcess_ProcessSessions](translationprocess.md#BKMK_TranslationProcess_ProcessSessions) one-to-many relationship for the [translationprocess](translationprocess.md) entity.

### <a name="BKMK_SystemUser_ProcessSessions"></a> SystemUser_ProcessSessions

See the [SystemUser_ProcessSessions](systemuser.md#BKMK_SystemUser_ProcessSessions) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_BusinessUnit_ProcessSessions"></a> BusinessUnit_ProcessSessions

See the [BusinessUnit_ProcessSessions](businessunit.md#BKMK_BusinessUnit_ProcessSessions) one-to-many relationship for the [businessunit](businessunit.md) entity.

### <a name="BKMK_KbArticleComment_ProcessSessions"></a> KbArticleComment_ProcessSessions

See the [KbArticleComment_ProcessSessions](kbarticlecomment.md#BKMK_KbArticleComment_ProcessSessions) one-to-many relationship for the [kbarticlecomment](kbarticlecomment.md) entity.

### <a name="BKMK_lk_processsession_canceledby"></a> lk_processsession_canceledby

See the [lk_processsession_canceledby](systemuser.md#BKMK_lk_processsession_canceledby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_goalrollupquery_ProcessSessions"></a> goalrollupquery_ProcessSessions

See the [goalrollupquery_ProcessSessions](goalrollupquery.md#BKMK_goalrollupquery_ProcessSessions) one-to-many relationship for the [goalrollupquery](goalrollupquery.md) entity.

### <a name="BKMK_rollupfield_ProcessSessions"></a> rollupfield_ProcessSessions

See the [rollupfield_ProcessSessions](rollupfield.md#BKMK_rollupfield_ProcessSessions) one-to-many relationship for the [rollupfield](rollupfield.md) entity.

### <a name="BKMK_SharePointDocumentLocation_ProcessSessions"></a> SharePointDocumentLocation_ProcessSessions

See the [SharePointDocumentLocation_ProcessSessions](sharepointdocumentlocation.md#BKMK_SharePointDocumentLocation_ProcessSessions) one-to-many relationship for the [sharepointdocumentlocation](sharepointdocumentlocation.md) entity.

### <a name="BKMK_lk_processsession_startedby"></a> lk_processsession_startedby

See the [lk_processsession_startedby](systemuser.md#BKMK_lk_processsession_startedby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_Account_ProcessSessions"></a> Account_ProcessSessions

See the [Account_ProcessSessions](account.md#BKMK_Account_ProcessSessions) one-to-many relationship for the [account](account.md) entity.

### <a name="BKMK_PhoneCall_ProcessSessions"></a> PhoneCall_ProcessSessions

See the [PhoneCall_ProcessSessions](phonecall.md#BKMK_PhoneCall_ProcessSessions) one-to-many relationship for the [phonecall](phonecall.md) entity.

### <a name="BKMK_slabase_ProcessSessions"></a> slabase_ProcessSessions

See the [slabase_ProcessSessions](sla.md#BKMK_slabase_ProcessSessions) one-to-many relationship for the [sla](sla.md) entity.

### <a name="BKMK_lk_processsession_createdby"></a> lk_processsession_createdby

See the [lk_processsession_createdby](systemuser.md#BKMK_lk_processsession_createdby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_lk_processsessionbase_modifiedonbehalfby"></a> lk_processsessionbase_modifiedonbehalfby

See the [lk_processsessionbase_modifiedonbehalfby](systemuser.md#BKMK_lk_processsessionbase_modifiedonbehalfby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_Template_ProcessSessions"></a> Template_ProcessSessions

See the [Template_ProcessSessions](template.md#BKMK_Template_ProcessSessions) one-to-many relationship for the [template](template.md) entity.

### <a name="BKMK_NewProcess_ProcessSessions"></a> NewProcess_ProcessSessions

See the [NewProcess_ProcessSessions](newprocess.md#BKMK_NewProcess_ProcessSessions) one-to-many relationship for the [newprocess](newprocess.md) entity.

### <a name="BKMK_Report_ProcessSessions"></a> Report_ProcessSessions

See the [Report_ProcessSessions](report.md#BKMK_Report_ProcessSessions) one-to-many relationship for the [report](report.md) entity.

### <a name="BKMK_Owning_businessunit_processsessions"></a> Owning_businessunit_processsessions

See the [Owning_businessunit_processsessions](businessunit.md#BKMK_Owning_businessunit_processsessions) one-to-many relationship for the [businessunit](businessunit.md) entity.

### <a name="BKMK_CustomerAddress_ProcessSessions"></a> CustomerAddress_ProcessSessions

See the [CustomerAddress_ProcessSessions](customeraddress.md#BKMK_CustomerAddress_ProcessSessions) one-to-many relationship for the [customeraddress](customeraddress.md) entity.

### <a name="BKMK_Connection_ProcessSessions"></a> Connection_ProcessSessions

See the [Connection_ProcessSessions](connection.md#BKMK_Connection_ProcessSessions) one-to-many relationship for the [connection](connection.md) entity.

### <a name="BKMK_lk_processsession_executedby"></a> lk_processsession_executedby

See the [lk_processsession_executedby](systemuser.md#BKMK_lk_processsession_executedby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_team_processsession"></a> team_processsession

See the [team_processsession](team.md#BKMK_team_processsession) one-to-many relationship for the [team](team.md) entity.

### <a name="BKMK_metric_ProcessSessions"></a> metric_ProcessSessions

See the [metric_ProcessSessions](metric.md#BKMK_metric_ProcessSessions) one-to-many relationship for the [metric](metric.md) entity.

### <a name="BKMK_ExpiredProcess_ProcessSessions"></a> ExpiredProcess_ProcessSessions

See the [ExpiredProcess_ProcessSessions](expiredprocess.md#BKMK_ExpiredProcess_ProcessSessions) one-to-many relationship for the [expiredprocess](expiredprocess.md) entity.

### <a name="BKMK_KbArticle_ProcessSessions"></a> KbArticle_ProcessSessions

See the [KbArticle_ProcessSessions](kbarticle.md#BKMK_KbArticle_ProcessSessions) one-to-many relationship for the [kbarticle](kbarticle.md) entity.

### <a name="BKMK_SocialActivity_ProcessSessions"></a> SocialActivity_ProcessSessions

See the [SocialActivity_ProcessSessions](socialactivity.md#BKMK_SocialActivity_ProcessSessions) one-to-many relationship for the [socialactivity](socialactivity.md) entity.

### <a name="BKMK_Task_ProcessSessions"></a> Task_ProcessSessions

See the [Task_ProcessSessions](task.md#BKMK_Task_ProcessSessions) one-to-many relationship for the [task](task.md) entity.

### <a name="BKMK_lk_processsession_processid"></a> lk_processsession_processid

See the [lk_processsession_processid](workflow.md#BKMK_lk_processsession_processid) one-to-many relationship for the [workflow](workflow.md) entity.

### <a name="BKMK_lk_processsession_modifiedby"></a> lk_processsession_modifiedby

See the [lk_processsession_modifiedby](systemuser.md#BKMK_lk_processsession_modifiedby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_ConnectionRole_ProcessSessions"></a> ConnectionRole_ProcessSessions

See the [ConnectionRole_ProcessSessions](connectionrole.md#BKMK_ConnectionRole_ProcessSessions) one-to-many relationship for the [connectionrole](connectionrole.md) entity.

### <a name="BKMK_TransactionCurrency_ProcessSessions"></a> TransactionCurrency_ProcessSessions

See the [TransactionCurrency_ProcessSessions](transactioncurrency.md#BKMK_TransactionCurrency_ProcessSessions) one-to-many relationship for the [transactioncurrency](transactioncurrency.md) entity.

### <a name="BKMK_Fax_ProcessSessions"></a> Fax_ProcessSessions

See the [Fax_ProcessSessions](fax.md#BKMK_Fax_ProcessSessions) one-to-many relationship for the [fax](fax.md) entity.

### <a name="BKMK_KbArticleTemplate_ProcessSessions"></a> KbArticleTemplate_ProcessSessions

See the [KbArticleTemplate_ProcessSessions](kbarticletemplate.md#BKMK_KbArticleTemplate_ProcessSessions) one-to-many relationship for the [kbarticletemplate](kbarticletemplate.md) entity.

### <a name="BKMK_Letter_ProcessSessions"></a> Letter_ProcessSessions

See the [Letter_ProcessSessions](letter.md#BKMK_Letter_ProcessSessions) one-to-many relationship for the [letter](letter.md) entity.

### <a name="BKMK_RecurringAppointmentMaster_ProcessSessions"></a> RecurringAppointmentMaster_ProcessSessions

See the [RecurringAppointmentMaster_ProcessSessions](recurringappointmentmaster.md#BKMK_RecurringAppointmentMaster_ProcessSessions) one-to-many relationship for the [recurringappointmentmaster](recurringappointmentmaster.md) entity.

### <a name="BKMK_Email_ProcessSessions"></a> Email_ProcessSessions

See the [Email_ProcessSessions](email.md#BKMK_Email_ProcessSessions) one-to-many relationship for the [email](email.md) entity.

### <a name="BKMK_lk_processsession_completedby"></a> lk_processsession_completedby

See the [lk_processsession_completedby](systemuser.md#BKMK_lk_processsession_completedby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_Contact_ProcessSessions"></a> Contact_ProcessSessions

See the [Contact_ProcessSessions](contact.md#BKMK_Contact_ProcessSessions) one-to-many relationship for the [contact](contact.md) entity.

### <a name="BKMK_Queue_ProcessSessions"></a> Queue_ProcessSessions

See the [Queue_ProcessSessions](queue.md#BKMK_Queue_ProcessSessions) one-to-many relationship for the [queue](queue.md) entity.

### <a name="BKMK_lk_processsessionbase_createdonbehalfby"></a> lk_processsessionbase_createdonbehalfby

See the [lk_processsessionbase_createdonbehalfby](systemuser.md#BKMK_lk_processsessionbase_createdonbehalfby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_Subject_ProcessSessions"></a> Subject_ProcessSessions

See the [Subject_ProcessSessions](subject.md#BKMK_Subject_ProcessSessions) one-to-many relationship for the [subject](subject.md) entity.

### <a name="BKMK_SocialProfile_ProcessSessions"></a> SocialProfile_ProcessSessions

See the [SocialProfile_ProcessSessions](socialprofile.md#BKMK_SocialProfile_ProcessSessions) one-to-many relationship for the [socialprofile](socialprofile.md) entity.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Web API EntityType Reference](/power-apps/developer/data-platform/webapi/reference/entitytypes)
