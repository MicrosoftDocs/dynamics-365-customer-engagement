---
title: "SyncError entity reference (Dynamics 365 Customer Engagement) | Microsoft Docs"
description: "Includes schema information and supported messages for the SyncError entity."
ms.date: 08/30/2022
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "KumarVivek"
ms.author: "kvivek"
search.audienceType: 
  - developer
---

# SyncError entity reference

Failure reason and other detailed information for a record that failed to sync.


## Messages

|Message|SDK class or method|
|-|-|
|Assign|<xref:Microsoft.Crm.Sdk.Messages.AssignRequest>|
|Create|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|RetrievePrincipalAccess|<xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>|
|SetState|<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>|
|Update|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

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

#### ErrorType Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|0|Conflict||
|1|Record not found||
|2|Record already exists||
|3|Others||



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
|Targets|account,activitymimeattachment,activityparty,annotation,appointment,attachment,bookableresource,bookableresourcebooking,bookableresourcebookingexchangesyncidmapping,bookableresourcebookingheader,bookableresourcecategory,bookableresourcecategoryassn,bookableresourcecharacteristic,bookableresourcegroup,bookingstatus,bulkoperation,bulkoperationlog,businessdatalocalizedlabel,businessunit,campaign,campaignactivity,campaignresponse,category,channelaccessprofile,channelaccessprofilerule,channelaccessprofileruleitem,characteristic,childincidentcount,commitment,competitor,competitoraddress,connection,connectionrole,constraintbasedgroup,contact,contract,contractdetail,contracttemplate,customeraddress,customeropportunityrole,discount,discounttype,duplicaterule,duplicaterulecondition,dynamicproperty,dynamicpropertyassociation,dynamicpropertyinstance,dynamicpropertyoptionsetitem,email,emailserverprofile,entitlement,entitlementchannel,entitlementtemplate,entitlementtemplatechannel,equipment,expiredprocess,externalparty,externalpartyitem,fax,feedback,fieldpermission,fieldsecurityprofile,goal,goalrollupquery,importmap,incident,incidentresolution,internaladdress,invoice,invoicedetail,kbarticle,kbarticletemplate,knowledgearticle,knowledgearticleincident,knowledgearticleviews,knowledgebaserecord,lead,leadaddress,leadtoopportunitysalesprocess,letter,list,mailbox,mailmergetemplate,metric,msdyn_postalbum,msdyn_postconfig,msdyn_postruleconfig,msdyn_relationshipinsightsunifiedconfig,msdyn_siconfig,msdyn_wallsavedquery,msdyn_wallsavedqueryusersettings,newprocess,offlinecommanddefinition,opportunity,opportunityclose,opportunityproduct,opportunitysalesprocess,orderclose,organization,phonecall,phonetocaseprocess,position,postfollow,pricelevel,processsession,processstage,processtrigger,product,productassociation,productpricelevel,productsubstitute,publisher,queue,queueitem,quote,quoteclose,quotedetail,ratingmodel,ratingvalue,recurringappointmentmaster,report,reportcategory,resource,resourcegroup,resourcegroupexpansion,resourcespec,role,rollupfield,salesliterature,salesliteratureitem,salesorder,salesorderdetail,salesprocessinstance,savedquery,savedqueryvisualization,service,serviceappointment,sharepointdocumentlocation,sharepointsite,site,sla,slaitem,slakpiinstance,socialactivity,socialprofile,solution,subject,syncerror,systemuser,task,team,teamtemplate,template,territory,topic,topichistory,topicmodel,topicmodelconfiguration,topicmodelexecutionhistory,transactioncurrency,translationprocess,uom,uomschedule,userquery,userqueryvisualization,workflow|
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

#### StateCode Choices/Options

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

#### StatusCode Choices/Options

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

Same as the [SyncError_SyncErrors](syncerror.md#BKMK_SyncError_SyncErrors) many-to-one relationship for the [syncerror](syncerror.md) entity.

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
- [msdyn_relationshipinsightsunifiedconfig_SyncErrors](#BKMK_msdyn_relationshipinsightsunifiedconfig_SyncErrors)
- [msdyn_siconfig_SyncErrors](#BKMK_msdyn_siconfig_SyncErrors)
- [msdyn_postalbum_SyncErrors](#BKMK_msdyn_postalbum_SyncErrors)
- [msdyn_postconfig_SyncErrors](#BKMK_msdyn_postconfig_SyncErrors)
- [msdyn_postruleconfig_SyncErrors](#BKMK_msdyn_postruleconfig_SyncErrors)
- [msdyn_wallsavedquery_SyncErrors](#BKMK_msdyn_wallsavedquery_SyncErrors)
- [msdyn_wallsavedqueryusersettings_SyncErrors](#BKMK_msdyn_wallsavedqueryusersettings_SyncErrors)
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

See the [Territory_SyncErrors](territory.md#BKMK_Territory_SyncErrors) one-to-many relationship for the [territory](territory.md) entity.

### <a name="BKMK_LeadAddress_SyncErrors"></a> LeadAddress_SyncErrors

**Added by**: Lead Management Solution

See the [LeadAddress_SyncErrors](leadaddress.md#BKMK_LeadAddress_SyncErrors) one-to-many relationship for the [leadaddress](leadaddress.md) entity.

### <a name="BKMK_Lead_SyncErrors"></a> Lead_SyncErrors

**Added by**: Lead Management Solution

See the [Lead_SyncErrors](lead.md#BKMK_Lead_SyncErrors) one-to-many relationship for the [lead](lead.md) entity.

### <a name="BKMK_dynamicproperty_SyncErrors"></a> dynamicproperty_SyncErrors

**Added by**: Product Management Solution

See the [dynamicproperty_SyncErrors](dynamicproperty.md#BKMK_dynamicproperty_SyncErrors) one-to-many relationship for the [dynamicproperty](dynamicproperty.md) entity.

### <a name="BKMK_dynamicpropertyassociation_SyncErrors"></a> dynamicpropertyassociation_SyncErrors

**Added by**: Product Management Solution

See the [dynamicpropertyassociation_SyncErrors](dynamicpropertyassociation.md#BKMK_dynamicpropertyassociation_SyncErrors) one-to-many relationship for the [dynamicpropertyassociation](dynamicpropertyassociation.md) entity.

### <a name="BKMK_dynamicpropertyinstance_SyncErrors"></a> dynamicpropertyinstance_SyncErrors

**Added by**: Product Management Solution

See the [dynamicpropertyinstance_SyncErrors](dynamicpropertyinstance.md#BKMK_dynamicpropertyinstance_SyncErrors) one-to-many relationship for the [dynamicpropertyinstance](dynamicpropertyinstance.md) entity.

### <a name="BKMK_dynamicpropertyoptionsetitem_SyncErrors"></a> dynamicpropertyoptionsetitem_SyncErrors

**Added by**: Product Management Solution

See the [dynamicpropertyoptionsetitem_SyncErrors](dynamicpropertyoptionsetitem.md#BKMK_dynamicpropertyoptionsetitem_SyncErrors) one-to-many relationship for the [dynamicpropertyoptionsetitem](dynamicpropertyoptionsetitem.md) entity.

### <a name="BKMK_PriceLevel_SyncErrors"></a> PriceLevel_SyncErrors

**Added by**: Product Management Solution

See the [PriceLevel_SyncErrors](pricelevel.md#BKMK_PriceLevel_SyncErrors) one-to-many relationship for the [pricelevel](pricelevel.md) entity.

### <a name="BKMK_Product_SyncErrors"></a> Product_SyncErrors

**Added by**: Product Management Solution

See the [Product_SyncErrors](product.md#BKMK_Product_SyncErrors) one-to-many relationship for the [product](product.md) entity.

### <a name="BKMK_ProductAssociation_SyncErrors"></a> ProductAssociation_SyncErrors

**Added by**: Product Management Solution

See the [ProductAssociation_SyncErrors](productassociation.md#BKMK_ProductAssociation_SyncErrors) one-to-many relationship for the [productassociation](productassociation.md) entity.

### <a name="BKMK_ProductPriceLevel_SyncErrors"></a> ProductPriceLevel_SyncErrors

**Added by**: Product Management Solution

See the [ProductPriceLevel_SyncErrors](productpricelevel.md#BKMK_ProductPriceLevel_SyncErrors) one-to-many relationship for the [productpricelevel](productpricelevel.md) entity.

### <a name="BKMK_ProductSubstitute_SyncErrors"></a> ProductSubstitute_SyncErrors

**Added by**: Product Management Solution

See the [ProductSubstitute_SyncErrors](productsubstitute.md#BKMK_ProductSubstitute_SyncErrors) one-to-many relationship for the [productsubstitute](productsubstitute.md) entity.

### <a name="BKMK_UoM_SyncErrors"></a> UoM_SyncErrors

**Added by**: Product Management Solution

See the [UoM_SyncErrors](uom.md#BKMK_UoM_SyncErrors) one-to-many relationship for the [uom](uom.md) entity.

### <a name="BKMK_UoMSchedule_SyncErrors"></a> UoMSchedule_SyncErrors

**Added by**: Product Management Solution

See the [UoMSchedule_SyncErrors](uomschedule.md#BKMK_UoMSchedule_SyncErrors) one-to-many relationship for the [uomschedule](uomschedule.md) entity.

### <a name="BKMK_BookableResource_SyncErrors"></a> BookableResource_SyncErrors

**Added by**: Scheduling Solution

See the [BookableResource_SyncErrors](bookableresource.md#BKMK_BookableResource_SyncErrors) one-to-many relationship for the [bookableresource](bookableresource.md) entity.

### <a name="BKMK_BookableResourceBooking_SyncErrors"></a> BookableResourceBooking_SyncErrors

**Added by**: Scheduling Solution

See the [BookableResourceBooking_SyncErrors](bookableresourcebooking.md#BKMK_BookableResourceBooking_SyncErrors) one-to-many relationship for the [bookableresourcebooking](bookableresourcebooking.md) entity.

### <a name="BKMK_BookableResourceBookingHeader_SyncErrors"></a> BookableResourceBookingHeader_SyncErrors

**Added by**: Scheduling Solution

See the [BookableResourceBookingHeader_SyncErrors](bookableresourcebookingheader.md#BKMK_BookableResourceBookingHeader_SyncErrors) one-to-many relationship for the [bookableresourcebookingheader](bookableresourcebookingheader.md) entity.

### <a name="BKMK_BookableResourceCategory_SyncErrors"></a> BookableResourceCategory_SyncErrors

**Added by**: Scheduling Solution

See the [BookableResourceCategory_SyncErrors](bookableresourcecategory.md#BKMK_BookableResourceCategory_SyncErrors) one-to-many relationship for the [bookableresourcecategory](bookableresourcecategory.md) entity.

### <a name="BKMK_BookableResourceCategoryAssn_SyncErrors"></a> BookableResourceCategoryAssn_SyncErrors

**Added by**: Scheduling Solution

See the [BookableResourceCategoryAssn_SyncErrors](bookableresourcecategoryassn.md#BKMK_BookableResourceCategoryAssn_SyncErrors) one-to-many relationship for the [bookableresourcecategoryassn](bookableresourcecategoryassn.md) entity.

### <a name="BKMK_BookableResourceCharacteristic_SyncErrors"></a> BookableResourceCharacteristic_SyncErrors

**Added by**: Scheduling Solution

See the [BookableResourceCharacteristic_SyncErrors](bookableresourcecharacteristic.md#BKMK_BookableResourceCharacteristic_SyncErrors) one-to-many relationship for the [bookableresourcecharacteristic](bookableresourcecharacteristic.md) entity.

### <a name="BKMK_BookableResourceGroup_SyncErrors"></a> BookableResourceGroup_SyncErrors

**Added by**: Scheduling Solution

See the [BookableResourceGroup_SyncErrors](bookableresourcegroup.md#BKMK_BookableResourceGroup_SyncErrors) one-to-many relationship for the [bookableresourcegroup](bookableresourcegroup.md) entity.

### <a name="BKMK_BookingStatus_SyncErrors"></a> BookingStatus_SyncErrors

**Added by**: Scheduling Solution

See the [BookingStatus_SyncErrors](bookingstatus.md#BKMK_BookingStatus_SyncErrors) one-to-many relationship for the [bookingstatus](bookingstatus.md) entity.

### <a name="BKMK_Characteristic_SyncErrors"></a> Characteristic_SyncErrors

**Added by**: Scheduling Solution

See the [Characteristic_SyncErrors](characteristic.md#BKMK_Characteristic_SyncErrors) one-to-many relationship for the [characteristic](characteristic.md) entity.

### <a name="BKMK_RatingModel_SyncErrors"></a> RatingModel_SyncErrors

**Added by**: Scheduling Solution

See the [RatingModel_SyncErrors](ratingmodel.md#BKMK_RatingModel_SyncErrors) one-to-many relationship for the [ratingmodel](ratingmodel.md) entity.

### <a name="BKMK_RatingValue_SyncErrors"></a> RatingValue_SyncErrors

**Added by**: Scheduling Solution

See the [RatingValue_SyncErrors](ratingvalue.md#BKMK_RatingValue_SyncErrors) one-to-many relationship for the [ratingvalue](ratingvalue.md) entity.

### <a name="BKMK_BulkOperation_SyncErrors"></a> BulkOperation_SyncErrors

**Added by**: Marketing Solution

See the [BulkOperation_SyncErrors](bulkoperation.md#BKMK_BulkOperation_SyncErrors) one-to-many relationship for the [bulkoperation](bulkoperation.md) entity.

### <a name="BKMK_bulkoperationlog_SyncErrors"></a> bulkoperationlog_SyncErrors

**Added by**: Marketing Solution

See the [bulkoperationlog_SyncErrors](bulkoperationlog.md#BKMK_bulkoperationlog_SyncErrors) one-to-many relationship for the [bulkoperationlog](bulkoperationlog.md) entity.

### <a name="BKMK_Campaign_SyncErrors"></a> Campaign_SyncErrors

**Added by**: Marketing Solution

See the [Campaign_SyncErrors](campaign.md#BKMK_Campaign_SyncErrors) one-to-many relationship for the [campaign](campaign.md) entity.

### <a name="BKMK_CampaignActivity_SyncErrors"></a> CampaignActivity_SyncErrors

**Added by**: Marketing Solution

See the [CampaignActivity_SyncErrors](campaignactivity.md#BKMK_CampaignActivity_SyncErrors) one-to-many relationship for the [campaignactivity](campaignactivity.md) entity.

### <a name="BKMK_CampaignResponse_SyncErrors"></a> CampaignResponse_SyncErrors

**Added by**: Marketing Solution

See the [CampaignResponse_SyncErrors](campaignresponse.md#BKMK_CampaignResponse_SyncErrors) one-to-many relationship for the [campaignresponse](campaignresponse.md) entity.

### <a name="BKMK_List_SyncErrors"></a> List_SyncErrors

**Added by**: Marketing Solution

See the [List_SyncErrors](list.md#BKMK_List_SyncErrors) one-to-many relationship for the [list](list.md) entity.

### <a name="BKMK_constraintbasedgroup_SyncErrors"></a> constraintbasedgroup_SyncErrors

**Added by**: Service Solution

See the [constraintbasedgroup_SyncErrors](constraintbasedgroup.md#BKMK_constraintbasedgroup_SyncErrors) one-to-many relationship for the [constraintbasedgroup](constraintbasedgroup.md) entity.

### <a name="BKMK_Contract_SyncErrors"></a> Contract_SyncErrors

**Added by**: Service Solution

See the [Contract_SyncErrors](contract.md#BKMK_Contract_SyncErrors) one-to-many relationship for the [contract](contract.md) entity.

### <a name="BKMK_ContractDetail_SyncErrors"></a> ContractDetail_SyncErrors

**Added by**: Service Solution

See the [ContractDetail_SyncErrors](contractdetail.md#BKMK_ContractDetail_SyncErrors) one-to-many relationship for the [contractdetail](contractdetail.md) entity.

### <a name="BKMK_ContractTemplate_SyncErrors"></a> ContractTemplate_SyncErrors

**Added by**: Service Solution

See the [ContractTemplate_SyncErrors](contracttemplate.md#BKMK_ContractTemplate_SyncErrors) one-to-many relationship for the [contracttemplate](contracttemplate.md) entity.

### <a name="BKMK_Entitlement_SyncErrors"></a> Entitlement_SyncErrors

**Added by**: Service Solution

See the [Entitlement_SyncErrors](entitlement.md#BKMK_Entitlement_SyncErrors) one-to-many relationship for the [entitlement](entitlement.md) entity.

### <a name="BKMK_entitlementchannel_SyncErrors"></a> entitlementchannel_SyncErrors

**Added by**: Service Solution

See the [entitlementchannel_SyncErrors](entitlementchannel.md#BKMK_entitlementchannel_SyncErrors) one-to-many relationship for the [entitlementchannel](entitlementchannel.md) entity.

### <a name="BKMK_EntitlementTemplate_SyncErrors"></a> EntitlementTemplate_SyncErrors

**Added by**: Service Solution

See the [EntitlementTemplate_SyncErrors](entitlementtemplate.md#BKMK_EntitlementTemplate_SyncErrors) one-to-many relationship for the [entitlementtemplate](entitlementtemplate.md) entity.

### <a name="BKMK_entitlementtemplatechannel_SyncErrors"></a> entitlementtemplatechannel_SyncErrors

**Added by**: Service Solution

See the [entitlementtemplatechannel_SyncErrors](entitlementtemplatechannel.md#BKMK_entitlementtemplatechannel_SyncErrors) one-to-many relationship for the [entitlementtemplatechannel](entitlementtemplatechannel.md) entity.

### <a name="BKMK_Equipment_SyncErrors"></a> Equipment_SyncErrors

**Added by**: Service Solution

See the [Equipment_SyncErrors](equipment.md#BKMK_Equipment_SyncErrors) one-to-many relationship for the [equipment](equipment.md) entity.

### <a name="BKMK_Incident_SyncErrors"></a> Incident_SyncErrors

**Added by**: Service Solution

See the [Incident_SyncErrors](incident.md#BKMK_Incident_SyncErrors) one-to-many relationship for the [incident](incident.md) entity.

### <a name="BKMK_IncidentResolution_SyncErrors"></a> IncidentResolution_SyncErrors

**Added by**: Service Solution

See the [IncidentResolution_SyncErrors](incidentresolution.md#BKMK_IncidentResolution_SyncErrors) one-to-many relationship for the [incidentresolution](incidentresolution.md) entity.

### <a name="BKMK_KnowledgeArticleIncident_SyncErrors"></a> KnowledgeArticleIncident_SyncErrors

**Added by**: Service Solution

See the [KnowledgeArticleIncident_SyncErrors](knowledgearticleincident.md#BKMK_KnowledgeArticleIncident_SyncErrors) one-to-many relationship for the [knowledgearticleincident](knowledgearticleincident.md) entity.

### <a name="BKMK_PhoneToCaseProcess_SyncErrors"></a> PhoneToCaseProcess_SyncErrors

**Added by**: Service Solution

See the [PhoneToCaseProcess_SyncErrors](phonetocaseprocess.md#BKMK_PhoneToCaseProcess_SyncErrors) one-to-many relationship for the [phonetocaseprocess](phonetocaseprocess.md) entity.

### <a name="BKMK_Resource_SyncErrors"></a> Resource_SyncErrors

**Added by**: Service Solution

See the [Resource_SyncErrors](resource.md#BKMK_Resource_SyncErrors) one-to-many relationship for the [resource](resource.md) entity.

### <a name="BKMK_ResourceGroup_SyncErrors"></a> ResourceGroup_SyncErrors

**Added by**: Service Solution

See the [ResourceGroup_SyncErrors](resourcegroup.md#BKMK_ResourceGroup_SyncErrors) one-to-many relationship for the [resourcegroup](resourcegroup.md) entity.

### <a name="BKMK_resourcespec_SyncErrors"></a> resourcespec_SyncErrors

**Added by**: Service Solution

See the [resourcespec_SyncErrors](resourcespec.md#BKMK_resourcespec_SyncErrors) one-to-many relationship for the [resourcespec](resourcespec.md) entity.

### <a name="BKMK_Service_SyncErrors"></a> Service_SyncErrors

**Added by**: Service Solution

See the [Service_SyncErrors](service.md#BKMK_Service_SyncErrors) one-to-many relationship for the [service](service.md) entity.

### <a name="BKMK_ServiceAppointment_SyncErrors"></a> ServiceAppointment_SyncErrors

**Added by**: Service Solution

See the [ServiceAppointment_SyncErrors](serviceappointment.md#BKMK_ServiceAppointment_SyncErrors) one-to-many relationship for the [serviceappointment](serviceappointment.md) entity.

### <a name="BKMK_Site_SyncErrors"></a> Site_SyncErrors

**Added by**: Service Solution

See the [Site_SyncErrors](site.md#BKMK_Site_SyncErrors) one-to-many relationship for the [site](site.md) entity.

### <a name="BKMK_Discount_SyncErrors"></a> Discount_SyncErrors

**Added by**: Sales Solution

See the [Discount_SyncErrors](discount.md#BKMK_Discount_SyncErrors) one-to-many relationship for the [discount](discount.md) entity.

### <a name="BKMK_DiscountType_SyncErrors"></a> DiscountType_SyncErrors

**Added by**: Sales Solution

See the [DiscountType_SyncErrors](discounttype.md#BKMK_DiscountType_SyncErrors) one-to-many relationship for the [discounttype](discounttype.md) entity.

### <a name="BKMK_Invoice_SyncErrors"></a> Invoice_SyncErrors

**Added by**: Sales Solution

See the [Invoice_SyncErrors](invoice.md#BKMK_Invoice_SyncErrors) one-to-many relationship for the [invoice](invoice.md) entity.

### <a name="BKMK_InvoiceDetail_SyncErrors"></a> InvoiceDetail_SyncErrors

**Added by**: Sales Solution

See the [InvoiceDetail_SyncErrors](invoicedetail.md#BKMK_InvoiceDetail_SyncErrors) one-to-many relationship for the [invoicedetail](invoicedetail.md) entity.

### <a name="BKMK_LeadToOpportunitySalesProcess_SyncErrors"></a> LeadToOpportunitySalesProcess_SyncErrors

**Added by**: Sales Solution

See the [LeadToOpportunitySalesProcess_SyncErrors](leadtoopportunitysalesprocess.md#BKMK_LeadToOpportunitySalesProcess_SyncErrors) one-to-many relationship for the [leadtoopportunitysalesprocess](leadtoopportunitysalesprocess.md) entity.

### <a name="BKMK_Opportunity_SyncErrors"></a> Opportunity_SyncErrors

**Added by**: Sales Solution

See the [Opportunity_SyncErrors](opportunity.md#BKMK_Opportunity_SyncErrors) one-to-many relationship for the [opportunity](opportunity.md) entity.

### <a name="BKMK_OpportunityClose_SyncErrors"></a> OpportunityClose_SyncErrors

**Added by**: Sales Solution

See the [OpportunityClose_SyncErrors](opportunityclose.md#BKMK_OpportunityClose_SyncErrors) one-to-many relationship for the [opportunityclose](opportunityclose.md) entity.

### <a name="BKMK_OpportunityProduct_SyncErrors"></a> OpportunityProduct_SyncErrors

**Added by**: Sales Solution

See the [OpportunityProduct_SyncErrors](opportunityproduct.md#BKMK_OpportunityProduct_SyncErrors) one-to-many relationship for the [opportunityproduct](opportunityproduct.md) entity.

### <a name="BKMK_OpportunitySalesProcess_SyncErrors"></a> OpportunitySalesProcess_SyncErrors

**Added by**: Sales Solution

See the [OpportunitySalesProcess_SyncErrors](opportunitysalesprocess.md#BKMK_OpportunitySalesProcess_SyncErrors) one-to-many relationship for the [opportunitysalesprocess](opportunitysalesprocess.md) entity.

### <a name="BKMK_OrderClose_SyncErrors"></a> OrderClose_SyncErrors

**Added by**: Sales Solution

See the [OrderClose_SyncErrors](orderclose.md#BKMK_OrderClose_SyncErrors) one-to-many relationship for the [orderclose](orderclose.md) entity.

### <a name="BKMK_Quote_SyncErrors"></a> Quote_SyncErrors

**Added by**: Sales Solution

See the [Quote_SyncErrors](quote.md#BKMK_Quote_SyncErrors) one-to-many relationship for the [quote](quote.md) entity.

### <a name="BKMK_QuoteClose_SyncErrors"></a> QuoteClose_SyncErrors

**Added by**: Sales Solution

See the [QuoteClose_SyncErrors](quoteclose.md#BKMK_QuoteClose_SyncErrors) one-to-many relationship for the [quoteclose](quoteclose.md) entity.

### <a name="BKMK_QuoteDetail_SyncErrors"></a> QuoteDetail_SyncErrors

**Added by**: Sales Solution

See the [QuoteDetail_SyncErrors](quotedetail.md#BKMK_QuoteDetail_SyncErrors) one-to-many relationship for the [quotedetail](quotedetail.md) entity.

### <a name="BKMK_SalesLiterature_SyncErrors"></a> SalesLiterature_SyncErrors

**Added by**: Sales Solution

See the [SalesLiterature_SyncErrors](salesliterature.md#BKMK_SalesLiterature_SyncErrors) one-to-many relationship for the [salesliterature](salesliterature.md) entity.

### <a name="BKMK_salesliteratureitem_SyncErrors"></a> salesliteratureitem_SyncErrors

**Added by**: Sales Solution

See the [salesliteratureitem_SyncErrors](salesliteratureitem.md#BKMK_salesliteratureitem_SyncErrors) one-to-many relationship for the [salesliteratureitem](salesliteratureitem.md) entity.

### <a name="BKMK_SalesOrder_SyncErrors"></a> SalesOrder_SyncErrors

**Added by**: Sales Solution

See the [SalesOrder_SyncErrors](salesorder.md#BKMK_SalesOrder_SyncErrors) one-to-many relationship for the [salesorder](salesorder.md) entity.

### <a name="BKMK_SalesOrderDetail_SyncErrors"></a> SalesOrderDetail_SyncErrors

**Added by**: Sales Solution

See the [SalesOrderDetail_SyncErrors](salesorderdetail.md#BKMK_SalesOrderDetail_SyncErrors) one-to-many relationship for the [salesorderdetail](salesorderdetail.md) entity.

### <a name="BKMK_Competitor_SyncErrors"></a> Competitor_SyncErrors

**Added by**: Sales Solution

See the [Competitor_SyncErrors](competitor.md#BKMK_Competitor_SyncErrors) one-to-many relationship for the [competitor](competitor.md) entity.

### <a name="BKMK_msdyn_relationshipinsightsunifiedconfig_SyncErrors"></a> msdyn_relationshipinsightsunifiedconfig_SyncErrors

**Added by**: SI Common Solution

See the [msdyn_relationshipinsightsunifiedconfig_SyncErrors](msdyn_relationshipinsightsunifiedconfig.md#BKMK_msdyn_relationshipinsightsunifiedconfig_SyncErrors) one-to-many relationship for the [msdyn_relationshipinsightsunifiedconfig](msdyn_relationshipinsightsunifiedconfig.md) entity.

### <a name="BKMK_msdyn_siconfig_SyncErrors"></a> msdyn_siconfig_SyncErrors

**Added by**: SI Common Solution

See the [msdyn_siconfig_SyncErrors](msdyn_siconfig.md#BKMK_msdyn_siconfig_SyncErrors) one-to-many relationship for the [msdyn_siconfig](msdyn_siconfig.md) entity.

### <a name="BKMK_msdyn_postalbum_SyncErrors"></a> msdyn_postalbum_SyncErrors

**Added by**: Activity Feeds Solution

See the [msdyn_postalbum_SyncErrors](msdyn_postalbum.md#BKMK_msdyn_postalbum_SyncErrors) one-to-many relationship for the [msdyn_postalbum](msdyn_postalbum.md) entity.

### <a name="BKMK_msdyn_postconfig_SyncErrors"></a> msdyn_postconfig_SyncErrors

**Added by**: Activity Feeds Solution

See the [msdyn_postconfig_SyncErrors](msdyn_postconfig.md#BKMK_msdyn_postconfig_SyncErrors) one-to-many relationship for the [msdyn_postconfig](msdyn_postconfig.md) entity.

### <a name="BKMK_msdyn_postruleconfig_SyncErrors"></a> msdyn_postruleconfig_SyncErrors

**Added by**: Activity Feeds Solution

See the [msdyn_postruleconfig_SyncErrors](msdyn_postruleconfig.md#BKMK_msdyn_postruleconfig_SyncErrors) one-to-many relationship for the [msdyn_postruleconfig](msdyn_postruleconfig.md) entity.

### <a name="BKMK_msdyn_wallsavedquery_SyncErrors"></a> msdyn_wallsavedquery_SyncErrors

**Added by**: Activity Feeds Solution

See the [msdyn_wallsavedquery_SyncErrors](msdyn_wallsavedquery.md#BKMK_msdyn_wallsavedquery_SyncErrors) one-to-many relationship for the [msdyn_wallsavedquery](msdyn_wallsavedquery.md) entity.

### <a name="BKMK_msdyn_wallsavedqueryusersettings_SyncErrors"></a> msdyn_wallsavedqueryusersettings_SyncErrors

**Added by**: Activity Feeds Solution

See the [msdyn_wallsavedqueryusersettings_SyncErrors](msdyn_wallsavedqueryusersettings.md#BKMK_msdyn_wallsavedqueryusersettings_SyncErrors) one-to-many relationship for the [msdyn_wallsavedqueryusersettings](msdyn_wallsavedqueryusersettings.md) entity.

### <a name="BKMK_KnowledgeBaseRecord_SyncErrors"></a> KnowledgeBaseRecord_SyncErrors

See the [KnowledgeBaseRecord_SyncErrors](knowledgebaserecord.md#BKMK_KnowledgeBaseRecord_SyncErrors) one-to-many relationship for the [knowledgebaserecord](knowledgebaserecord.md) entity.

### <a name="BKMK_SocialProfile_SyncErrors"></a> SocialProfile_SyncErrors

See the [SocialProfile_SyncErrors](socialprofile.md#BKMK_SocialProfile_SyncErrors) one-to-many relationship for the [socialprofile](socialprofile.md) entity.

### <a name="BKMK_QueueItem_SyncErrors"></a> QueueItem_SyncErrors

See the [QueueItem_SyncErrors](queueitem.md#BKMK_QueueItem_SyncErrors) one-to-many relationship for the [queueitem](queueitem.md) entity.

### <a name="BKMK_PostFollow_SyncErrors"></a> PostFollow_SyncErrors

See the [PostFollow_SyncErrors](postfollow.md#BKMK_PostFollow_SyncErrors) one-to-many relationship for the [postfollow](postfollow.md) entity.

### <a name="BKMK_SharePointSite_SyncErrors"></a> SharePointSite_SyncErrors

See the [SharePointSite_SyncErrors](sharepointsite.md#BKMK_SharePointSite_SyncErrors) one-to-many relationship for the [sharepointsite](sharepointsite.md) entity.

### <a name="BKMK_Goal_SyncErrors"></a> Goal_SyncErrors

See the [Goal_SyncErrors](goal.md#BKMK_Goal_SyncErrors) one-to-many relationship for the [goal](goal.md) entity.

### <a name="BKMK_lk_syncerrorbase_createdby"></a> lk_syncerrorbase_createdby

See the [lk_syncerrorbase_createdby](systemuser.md#BKMK_lk_syncerrorbase_createdby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_TranslationProcess_SyncErrors"></a> TranslationProcess_SyncErrors

See the [TranslationProcess_SyncErrors](translationprocess.md#BKMK_TranslationProcess_SyncErrors) one-to-many relationship for the [translationprocess](translationprocess.md) entity.

### <a name="BKMK_PhoneCall_SyncErrors"></a> PhoneCall_SyncErrors

See the [PhoneCall_SyncErrors](phonecall.md#BKMK_PhoneCall_SyncErrors) one-to-many relationship for the [phonecall](phonecall.md) entity.

### <a name="BKMK_RecurringAppointmentMaster_SyncErrors"></a> RecurringAppointmentMaster_SyncErrors

See the [RecurringAppointmentMaster_SyncErrors](recurringappointmentmaster.md#BKMK_RecurringAppointmentMaster_SyncErrors) one-to-many relationship for the [recurringappointmentmaster](recurringappointmentmaster.md) entity.

### <a name="BKMK_Publisher_SyncErrors"></a> Publisher_SyncErrors

See the [Publisher_SyncErrors](publisher.md#BKMK_Publisher_SyncErrors) one-to-many relationship for the [publisher](publisher.md) entity.

### <a name="BKMK_DuplicateRule_SyncErrors"></a> DuplicateRule_SyncErrors

See the [DuplicateRule_SyncErrors](duplicaterule.md#BKMK_DuplicateRule_SyncErrors) one-to-many relationship for the [duplicaterule](duplicaterule.md) entity.

### <a name="BKMK_Subject_SyncErrors"></a> Subject_SyncErrors

See the [Subject_SyncErrors](subject.md#BKMK_Subject_SyncErrors) one-to-many relationship for the [subject](subject.md) entity.

### <a name="BKMK_UserQuery_SyncErrors"></a> UserQuery_SyncErrors

See the [UserQuery_SyncErrors](userquery.md#BKMK_UserQuery_SyncErrors) one-to-many relationship for the [userquery](userquery.md) entity.

### <a name="BKMK_MailMergeTemplate_SyncErrors"></a> MailMergeTemplate_SyncErrors

See the [MailMergeTemplate_SyncErrors](mailmergetemplate.md#BKMK_MailMergeTemplate_SyncErrors) one-to-many relationship for the [mailmergetemplate](mailmergetemplate.md) entity.

### <a name="BKMK_SyncError_SyncErrors"></a> SyncError_SyncErrors

See the [SyncError_SyncErrors](syncerror.md#BKMK_SyncError_SyncErrors) one-to-many relationship for the [syncerror](syncerror.md) entity.

### <a name="BKMK_SavedQuery_SyncErrors"></a> SavedQuery_SyncErrors

See the [SavedQuery_SyncErrors](savedquery.md#BKMK_SavedQuery_SyncErrors) one-to-many relationship for the [savedquery](savedquery.md) entity.

### <a name="BKMK_lk_syncerrorbase_modifiedby"></a> lk_syncerrorbase_modifiedby

See the [lk_syncerrorbase_modifiedby](systemuser.md#BKMK_lk_syncerrorbase_modifiedby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_lk_syncerrorbase_modifiedonbehalfby"></a> lk_syncerrorbase_modifiedonbehalfby

See the [lk_syncerrorbase_modifiedonbehalfby](systemuser.md#BKMK_lk_syncerrorbase_modifiedonbehalfby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_TransactionCurrency_SyncErrors"></a> TransactionCurrency_SyncErrors

See the [TransactionCurrency_SyncErrors](transactioncurrency.md#BKMK_TransactionCurrency_SyncErrors) one-to-many relationship for the [transactioncurrency](transactioncurrency.md) entity.

### <a name="BKMK_SocialActivity_SyncErrors"></a> SocialActivity_SyncErrors

See the [SocialActivity_SyncErrors](socialactivity.md#BKMK_SocialActivity_SyncErrors) one-to-many relationship for the [socialactivity](socialactivity.md) entity.

### <a name="BKMK_CustomerAddress_SyncErrors"></a> CustomerAddress_SyncErrors

See the [CustomerAddress_SyncErrors](customeraddress.md#BKMK_CustomerAddress_SyncErrors) one-to-many relationship for the [customeraddress](customeraddress.md) entity.

### <a name="BKMK_Solution_SyncErrors"></a> Solution_SyncErrors

See the [Solution_SyncErrors](solution.md#BKMK_Solution_SyncErrors) one-to-many relationship for the [solution](solution.md) entity.

### <a name="BKMK_team_SyncError"></a> team_SyncError

See the [team_SyncError](team.md#BKMK_team_SyncError) one-to-many relationship for the [team](team.md) entity.

### <a name="BKMK_TeamTemplate_SyncErrors"></a> TeamTemplate_SyncErrors

See the [TeamTemplate_SyncErrors](teamtemplate.md#BKMK_TeamTemplate_SyncErrors) one-to-many relationship for the [teamtemplate](teamtemplate.md) entity.

### <a name="BKMK_ReportCategory_SyncErrors"></a> ReportCategory_SyncErrors

See the [ReportCategory_SyncErrors](reportcategory.md#BKMK_ReportCategory_SyncErrors) one-to-many relationship for the [reportcategory](reportcategory.md) entity.

### <a name="BKMK_lk_syncerrorbase_createdonbehalfby"></a> lk_syncerrorbase_createdonbehalfby

See the [lk_syncerrorbase_createdonbehalfby](systemuser.md#BKMK_lk_syncerrorbase_createdonbehalfby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_KbArticle_SyncErrors"></a> KbArticle_SyncErrors

See the [KbArticle_SyncErrors](kbarticle.md#BKMK_KbArticle_SyncErrors) one-to-many relationship for the [kbarticle](kbarticle.md) entity.

### <a name="BKMK_RollupField_SyncErrors"></a> RollupField_SyncErrors

See the [RollupField_SyncErrors](rollupfield.md#BKMK_RollupField_SyncErrors) one-to-many relationship for the [rollupfield](rollupfield.md) entity.

### <a name="BKMK_KbArticleTemplate_SyncErrors"></a> KbArticleTemplate_SyncErrors

See the [KbArticleTemplate_SyncErrors](kbarticletemplate.md#BKMK_KbArticleTemplate_SyncErrors) one-to-many relationship for the [kbarticletemplate](kbarticletemplate.md) entity.

### <a name="BKMK_Account_SyncErrors"></a> Account_SyncErrors

See the [Account_SyncErrors](account.md#BKMK_Account_SyncErrors) one-to-many relationship for the [account](account.md) entity.

### <a name="BKMK_FieldSecurityProfile_SyncErrors"></a> FieldSecurityProfile_SyncErrors

See the [FieldSecurityProfile_SyncErrors](fieldsecurityprofile.md#BKMK_FieldSecurityProfile_SyncErrors) one-to-many relationship for the [fieldsecurityprofile](fieldsecurityprofile.md) entity.

### <a name="BKMK_UserQueryVisualization_SyncErrors"></a> UserQueryVisualization_SyncErrors

See the [UserQueryVisualization_SyncErrors](userqueryvisualization.md#BKMK_UserQueryVisualization_SyncErrors) one-to-many relationship for the [userqueryvisualization](userqueryvisualization.md) entity.

### <a name="BKMK_FieldPermission_SyncErrors"></a> FieldPermission_SyncErrors

See the [FieldPermission_SyncErrors](fieldpermission.md#BKMK_FieldPermission_SyncErrors) one-to-many relationship for the [fieldpermission](fieldpermission.md) entity.

### <a name="BKMK_DuplicateRuleCondition_SyncErrors"></a> DuplicateRuleCondition_SyncErrors

See the [DuplicateRuleCondition_SyncErrors](duplicaterulecondition.md#BKMK_DuplicateRuleCondition_SyncErrors) one-to-many relationship for the [duplicaterulecondition](duplicaterulecondition.md) entity.

### <a name="BKMK_Team_SyncErrors"></a> Team_SyncErrors

See the [Team_SyncErrors](team.md#BKMK_Team_SyncErrors) one-to-many relationship for the [team](team.md) entity.

### <a name="BKMK_SLAItem_SyncErrors"></a> SLAItem_SyncErrors

See the [SLAItem_SyncErrors](slaitem.md#BKMK_SLAItem_SyncErrors) one-to-many relationship for the [slaitem](slaitem.md) entity.

### <a name="BKMK_KnowledgeArticleViews_SyncErrors"></a> KnowledgeArticleViews_SyncErrors

See the [KnowledgeArticleViews_SyncErrors](knowledgearticleviews.md#BKMK_KnowledgeArticleViews_SyncErrors) one-to-many relationship for the [knowledgearticleviews](knowledgearticleviews.md) entity.

### <a name="BKMK_Appointment_SyncErrors"></a> Appointment_SyncErrors

See the [Appointment_SyncErrors](appointment.md#BKMK_Appointment_SyncErrors) one-to-many relationship for the [appointment](appointment.md) entity.

### <a name="BKMK_SystemUser_SyncError"></a> SystemUser_SyncError

See the [SystemUser_SyncError](systemuser.md#BKMK_SystemUser_SyncError) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_Contact_SyncErrors"></a> Contact_SyncErrors

See the [Contact_SyncErrors](contact.md#BKMK_Contact_SyncErrors) one-to-many relationship for the [contact](contact.md) entity.

### <a name="BKMK_ExpiredProcess_SyncErrors"></a> ExpiredProcess_SyncErrors

See the [ExpiredProcess_SyncErrors](expiredprocess.md#BKMK_ExpiredProcess_SyncErrors) one-to-many relationship for the [expiredprocess](expiredprocess.md) entity.

### <a name="BKMK_Workflow_SyncErrors"></a> Workflow_SyncErrors

See the [Workflow_SyncErrors](workflow.md#BKMK_Workflow_SyncErrors) one-to-many relationship for the [workflow](workflow.md) entity.

### <a name="BKMK_NewProcess_SyncErrors"></a> NewProcess_SyncErrors

See the [NewProcess_SyncErrors](newprocess.md#BKMK_NewProcess_SyncErrors) one-to-many relationship for the [newprocess](newprocess.md) entity.

### <a name="BKMK_Feedback_SyncErrors"></a> Feedback_SyncErrors

See the [Feedback_SyncErrors](feedback.md#BKMK_Feedback_SyncErrors) one-to-many relationship for the [feedback](feedback.md) entity.

### <a name="BKMK_ActivityParty_SyncErrors"></a> ActivityParty_SyncErrors

See the [ActivityParty_SyncErrors](activityparty.md#BKMK_ActivityParty_SyncErrors) one-to-many relationship for the [activityparty](activityparty.md) entity.

### <a name="BKMK_Annotation_SyncErrors"></a> Annotation_SyncErrors

See the [Annotation_SyncErrors](annotation.md#BKMK_Annotation_SyncErrors) one-to-many relationship for the [annotation](annotation.md) entity.

### <a name="BKMK_Email_SyncErrors"></a> Email_SyncErrors

See the [Email_SyncErrors](email.md#BKMK_Email_SyncErrors) one-to-many relationship for the [email](email.md) entity.

### <a name="BKMK_Organization_SyncErrors"></a> Organization_SyncErrors

See the [Organization_SyncErrors](organization.md#BKMK_Organization_SyncErrors) one-to-many relationship for the [organization](organization.md) entity.

### <a name="BKMK_ActivityMimeAttachment_SyncErrors"></a> ActivityMimeAttachment_SyncErrors

See the [ActivityMimeAttachment_SyncErrors](activitymimeattachment.md#BKMK_ActivityMimeAttachment_SyncErrors) one-to-many relationship for the [activitymimeattachment](activitymimeattachment.md) entity.

### <a name="BKMK_Task_SyncErrors"></a> Task_SyncErrors

See the [Task_SyncErrors](task.md#BKMK_Task_SyncErrors) one-to-many relationship for the [task](task.md) entity.

### <a name="BKMK_Letter_SyncErrors"></a> Letter_SyncErrors

See the [Letter_SyncErrors](letter.md#BKMK_Letter_SyncErrors) one-to-many relationship for the [letter](letter.md) entity.

### <a name="BKMK_Template_SyncErrors"></a> Template_SyncErrors

See the [Template_SyncErrors](template.md#BKMK_Template_SyncErrors) one-to-many relationship for the [template](template.md) entity.

### <a name="BKMK_ProcessStage_SyncErrors"></a> ProcessStage_SyncErrors

See the [ProcessStage_SyncErrors](processstage.md#BKMK_ProcessStage_SyncErrors) one-to-many relationship for the [processstage](processstage.md) entity.

### <a name="BKMK_KnowledgeArticle_SyncErrors"></a> KnowledgeArticle_SyncErrors

See the [KnowledgeArticle_SyncErrors](knowledgearticle.md#BKMK_KnowledgeArticle_SyncErrors) one-to-many relationship for the [knowledgearticle](knowledgearticle.md) entity.

### <a name="BKMK_Position_SyncErrors"></a> Position_SyncErrors

See the [Position_SyncErrors](position.md#BKMK_Position_SyncErrors) one-to-many relationship for the [position](position.md) entity.

### <a name="BKMK_SharePointDocumentLocation_SyncErrors"></a> SharePointDocumentLocation_SyncErrors

See the [SharePointDocumentLocation_SyncErrors](sharepointdocumentlocation.md#BKMK_SharePointDocumentLocation_SyncErrors) one-to-many relationship for the [sharepointdocumentlocation](sharepointdocumentlocation.md) entity.

### <a name="BKMK_Report_SyncErrors"></a> Report_SyncErrors

See the [Report_SyncErrors](report.md#BKMK_Report_SyncErrors) one-to-many relationship for the [report](report.md) entity.

### <a name="BKMK_Connection_SyncErrors"></a> Connection_SyncErrors

See the [Connection_SyncErrors](connection.md#BKMK_Connection_SyncErrors) one-to-many relationship for the [connection](connection.md) entity.

### <a name="BKMK_ProcessSession_SyncErrors"></a> ProcessSession_SyncErrors

See the [ProcessSession_SyncErrors](processsession.md#BKMK_ProcessSession_SyncErrors) one-to-many relationship for the [processsession](processsession.md) entity.

### <a name="BKMK_Category_SyncErrors"></a> Category_SyncErrors

See the [Category_SyncErrors](category.md#BKMK_Category_SyncErrors) one-to-many relationship for the [category](category.md) entity.

### <a name="BKMK_ConnectionRole_SyncErrors"></a> ConnectionRole_SyncErrors

See the [ConnectionRole_SyncErrors](connectionrole.md#BKMK_ConnectionRole_SyncErrors) one-to-many relationship for the [connectionrole](connectionrole.md) entity.

### <a name="BKMK_ProcessTrigger_SyncErrors"></a> ProcessTrigger_SyncErrors

See the [ProcessTrigger_SyncErrors](processtrigger.md#BKMK_ProcessTrigger_SyncErrors) one-to-many relationship for the [processtrigger](processtrigger.md) entity.

### <a name="BKMK_Fax_SyncErrors"></a> Fax_SyncErrors

See the [Fax_SyncErrors](fax.md#BKMK_Fax_SyncErrors) one-to-many relationship for the [fax](fax.md) entity.

### <a name="BKMK_Mailbox_SyncErrors"></a> Mailbox_SyncErrors

See the [Mailbox_SyncErrors](mailbox.md#BKMK_Mailbox_SyncErrors) one-to-many relationship for the [mailbox](mailbox.md) entity.

### <a name="BKMK_BusinessUnit_SyncErrors"></a> BusinessUnit_SyncErrors

See the [BusinessUnit_SyncErrors](businessunit.md#BKMK_BusinessUnit_SyncErrors) one-to-many relationship for the [businessunit](businessunit.md) entity.

### <a name="BKMK_Queue_SyncErrors"></a> Queue_SyncErrors

See the [Queue_SyncErrors](queue.md#BKMK_Queue_SyncErrors) one-to-many relationship for the [queue](queue.md) entity.

### <a name="BKMK_Role_SyncErrors"></a> Role_SyncErrors

See the [Role_SyncErrors](role.md#BKMK_Role_SyncErrors) one-to-many relationship for the [role](role.md) entity.

### <a name="BKMK_BusinessUnit_SyncError"></a> BusinessUnit_SyncError

See the [BusinessUnit_SyncError](businessunit.md#BKMK_BusinessUnit_SyncError) one-to-many relationship for the [businessunit](businessunit.md) entity.

### <a name="BKMK_SystemUser_SyncErrors"></a> SystemUser_SyncErrors

See the [SystemUser_SyncErrors](systemuser.md#BKMK_SystemUser_SyncErrors) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_SLAKPIInstance_SyncErrors"></a> SLAKPIInstance_SyncErrors

See the [SLAKPIInstance_SyncErrors](slakpiinstance.md#BKMK_SLAKPIInstance_SyncErrors) one-to-many relationship for the [slakpiinstance](slakpiinstance.md) entity.

### <a name="BKMK_SLA_SyncErrors"></a> SLA_SyncErrors

See the [SLA_SyncErrors](sla.md#BKMK_SLA_SyncErrors) one-to-many relationship for the [sla](sla.md) entity.

### <a name="BKMK_SavedQueryVisualization_SyncErrors"></a> SavedQueryVisualization_SyncErrors

See the [SavedQueryVisualization_SyncErrors](savedqueryvisualization.md#BKMK_SavedQueryVisualization_SyncErrors) one-to-many relationship for the [savedqueryvisualization](savedqueryvisualization.md) entity.

### <a name="BKMK_GoalRollupQuery_SyncErrors"></a> GoalRollupQuery_SyncErrors

See the [GoalRollupQuery_SyncErrors](goalrollupquery.md#BKMK_GoalRollupQuery_SyncErrors) one-to-many relationship for the [goalrollupquery](goalrollupquery.md) entity.

### <a name="BKMK_Metric_SyncErrors"></a> Metric_SyncErrors

See the [Metric_SyncErrors](metric.md#BKMK_Metric_SyncErrors) one-to-many relationship for the [metric](metric.md) entity.

### <a name="BKMK_ImportMap_SyncErrors"></a> ImportMap_SyncErrors

See the [ImportMap_SyncErrors](importmap.md#BKMK_ImportMap_SyncErrors) one-to-many relationship for the [importmap](importmap.md) entity.

### <a name="BKMK_EmailServerProfile_SyncErrors"></a> EmailServerProfile_SyncErrors

See the [EmailServerProfile_SyncErrors](emailserverprofile.md#BKMK_EmailServerProfile_SyncErrors) one-to-many relationship for the [emailserverprofile](emailserverprofile.md) entity.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Web API EntityType Reference](/power-apps/developer/data-platform/webapi/reference/entitytypes)
