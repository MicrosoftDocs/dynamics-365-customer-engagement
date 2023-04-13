---
title: "BulkDeleteFailure entity reference (Dynamics 365 Customer Engagement) | Microsoft Docs"
description: "Includes schema information and supported messages for the BulkDeleteFailure entity."
ms.date: 08/30/2022
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "KumarVivek"
ms.author: "kvivek"
search.audienceType: 
  - developer
---

# BulkDeleteFailure entity reference

Record that was not deleted during a bulk deletion job.


## Messages

|Message|SDK class or method|
|-|-|
|Retrieve|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|

## Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|BulkDeleteFailures|
|DisplayCollectionName|Bulk Delete Failures|
|DisplayName|Bulk Delete Failure|
|EntitySetName|bulkdeletefailures|
|IsBPFEntity|False|
|LogicalCollectionName|bulkdeletefailures|
|LogicalName|bulkdeletefailure|
|OwnershipType|None|
|PrimaryIdAttribute|bulkdeletefailureid|
|PrimaryNameAttribute||
|SchemaName|BulkDeleteFailure|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.


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

<a name="read-only-attributes"></a>

## Read-only attributes

These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [AsyncOperationId](#BKMK_AsyncOperationId)
- [BulkDeleteFailureId](#BKMK_BulkDeleteFailureId)
- [BulkDeleteOperationId](#BKMK_BulkDeleteOperationId)
- [ErrorDescription](#BKMK_ErrorDescription)
- [ErrorNumber](#BKMK_ErrorNumber)
- [OrderedQueryIndex](#BKMK_OrderedQueryIndex)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningUser](#BKMK_OwningUser)
- [RegardingObjectId](#BKMK_RegardingObjectId)
- [RegardingObjectIdName](#BKMK_RegardingObjectIdName)
- [RegardingObjectTypeCode](#BKMK_RegardingObjectTypeCode)


### <a name="BKMK_AsyncOperationId"></a> AsyncOperationId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the system job that created this record.|
|DisplayName|System Job|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|asyncoperationid|
|RequiredLevel|ApplicationRequired|
|Targets|asyncoperation|
|Type|Lookup|


### <a name="BKMK_BulkDeleteFailureId"></a> BulkDeleteFailureId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the bulk deletion failure record.|
|DisplayName|Bulk Deletion Failure|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|bulkdeletefailureid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_BulkDeleteOperationId"></a> BulkDeleteOperationId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the bulk operation job which created this record|
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|bulkdeleteoperationid|
|RequiredLevel|None|
|Targets|bulkdeleteoperation|
|Type|Lookup|


### <a name="BKMK_ErrorDescription"></a> ErrorDescription

|Property|Value|
|--------|-----|
|Description|Description of the error.|
|DisplayName|Error Description|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|errordescription|
|MaxLength|512|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ErrorNumber"></a> ErrorNumber

|Property|Value|
|--------|-----|
|Description|Error code for the failed bulk deletion.|
|DisplayName|Error Code|
|Format|None|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|errornumber|
|MaxValue|1000000000|
|MinValue|-1000000000|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_OrderedQueryIndex"></a> OrderedQueryIndex

|Property|Value|
|--------|-----|
|Description|Index of the ordered query expression that retrieved this record.|
|DisplayName|Index|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|orderedqueryindex|
|MaxValue|1000000000|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user or team who owns the bulk operation log.|
|DisplayName|Owner|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|ownerid|
|RequiredLevel|ApplicationRequired|
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


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

|Property|Value|
|--------|-----|
|Description|Unique identifier of the business unit that owns the bulk deletion failure.|
|DisplayName|Owning Business Unit|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owningbusinessunit|
|RequiredLevel|ApplicationRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_OwningUser"></a> OwningUser

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who owns the bulk deletion failure record.
|
|DisplayName|Owning User|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owninguser|
|RequiredLevel|ApplicationRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the record that can not be deleted.|
|DisplayName|Name|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|regardingobjectid|
|RequiredLevel|None|
|Targets|account,accountleads,activitymimeattachment,activitypointer,annotation,annualfiscalcalendar,appointment,attributemap,bookableresource,bookableresourcebooking,bookableresourcebookingexchangesyncidmapping,bookableresourcebookingheader,bookableresourcecategory,bookableresourcecategoryassn,bookableresourcecharacteristic,bookableresourcegroup,bookingstatus,bulkoperation,bulkoperationlog,businessunit,businessunitnewsarticle,calendar,campaign,campaignactivity,campaignactivityitem,campaignitem,campaignresponse,channelaccessprofile,channelaccessprofilerule,characteristic,childincidentcount,commitment,competitor,competitoraddress,competitorproduct,competitorsalesliterature,constraintbasedgroup,contact,contactinvoices,contactleads,contactorders,contactquotes,contract,contractdetail,contracttemplate,customeraddress,customeropportunityrole,customerrelationship,discount,discounttype,displaystring,dynamicproperty,dynamicpropertyassociation,dynamicpropertyinstance,dynamicpropertyoptionsetitem,email,emailserverprofile,entitlement,entitlementchannel,entitlementcontacts,entitlementproducts,entitlementtemplate,entitlementtemplatechannel,entitlementtemplateproducts,entitymap,equipment,externalparty,externalpartyitem,fax,fixedmonthlyfiscalcalendar,import,importdata,importfile,importlog,importmap,incident,incidentknowledgebaserecord,incidentresolution,invoice,invoicedetail,isvconfig,kbarticle,kbarticlecomment,kbarticletemplate,knowledgearticle,knowledgearticleincident,knowledgebaserecord,lead,leadaddress,leadcompetitors,leadproduct,leadtoopportunitysalesprocess,letter,list,listmember,monthlyfiscalcalendar,msdyn_postalbum,msdyn_postconfig,msdyn_postruleconfig,msdyn_relationshipinsightsunifiedconfig,msdyn_siconfig,msdyn_wallsavedquery,msdyn_wallsavedqueryusersettings,opportunity,opportunityclose,opportunitycompetitors,opportunityproduct,opportunitysalesprocess,orderclose,organization,phonecall,phonetocaseprocess,post,pricelevel,privilege,product,productassociation,productpricelevel,productsalesliterature,productsubstitute,quarterlyfiscalcalendar,queue,queueitem,quote,quoteclose,quotedetail,ratingmodel,ratingvalue,recurringappointmentmaster,relationshiprole,relationshiprolemap,resource,resourcegroup,resourcegroupexpansion,resourcespec,role,routingrule,routingruleitem,salesliterature,salesliteratureitem,salesorder,salesorderdetail,salesprocessinstance,savedquery,semiannualfiscalcalendar,service,serviceappointment,servicecontractcontacts,site,sla,socialactivity,subject,systemform,systemuser,task,team,template,territory,theme,topic,topichistory,topicmodel,topicmodelconfiguration,topicmodelexecutionhistory,uom,uomschedule,userform,usermapping,userquery|
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
|MaxLength|256|
|RequiredLevel|None|
|Type|String|


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

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [theme_BulkDeleteFailures](#BKMK_theme_BulkDeleteFailures)
- [usermapping_BulkDeleteFailures](#BKMK_usermapping_BulkDeleteFailures)
- [knowledgearticle_BulkDeleteFailures](#BKMK_knowledgearticle_BulkDeleteFailures)
- [post_BulkDeleteFailures](#BKMK_post_BulkDeleteFailures)
- [Territory_BulkDeleteFailures](#BKMK_Territory_BulkDeleteFailures)
- [leadaddress_BulkDeleteFailures](#BKMK_leadaddress_BulkDeleteFailures)
- [Lead_BulkDeleteFailures](#BKMK_Lead_BulkDeleteFailures)
- [dynamicproperty_BulkDeleteFailures](#BKMK_dynamicproperty_BulkDeleteFailures)
- [dynamicpropertyassociation_BulkDeleteFailures](#BKMK_dynamicpropertyassociation_BulkDeleteFailures)
- [dynamicpropertyinstance_BulkDeleteFailures](#BKMK_dynamicpropertyinstance_BulkDeleteFailures)
- [dynamicpropertyoptionsetitem_BulkDeleteFailures](#BKMK_dynamicpropertyoptionsetitem_BulkDeleteFailures)
- [PriceLevel_BulkDeleteFailures](#BKMK_PriceLevel_BulkDeleteFailures)
- [Product_BulkDeleteFailures](#BKMK_Product_BulkDeleteFailures)
- [productassociation_BulkDeleteFailures](#BKMK_productassociation_BulkDeleteFailures)
- [ProductPriceLevel_BulkDeleteFailures](#BKMK_ProductPriceLevel_BulkDeleteFailures)
- [ProductSubstitute_BulkDeleteFailures](#BKMK_ProductSubstitute_BulkDeleteFailures)
- [UoM_BulkDeleteFailures](#BKMK_UoM_BulkDeleteFailures)
- [UoMSchedule_BulkDeleteFailures](#BKMK_UoMSchedule_BulkDeleteFailures)
- [bookableresource_BulkDeleteFailures](#BKMK_bookableresource_BulkDeleteFailures)
- [bookableresourcebooking_BulkDeleteFailures](#BKMK_bookableresourcebooking_BulkDeleteFailures)
- [bookableresourcebookingheader_BulkDeleteFailures](#BKMK_bookableresourcebookingheader_BulkDeleteFailures)
- [bookableresourcecategory_BulkDeleteFailures](#BKMK_bookableresourcecategory_BulkDeleteFailures)
- [bookableresourcecategoryassn_BulkDeleteFailures](#BKMK_bookableresourcecategoryassn_BulkDeleteFailures)
- [bookableresourcecharacteristic_BulkDeleteFailures](#BKMK_bookableresourcecharacteristic_BulkDeleteFailures)
- [bookableresourcegroup_BulkDeleteFailures](#BKMK_bookableresourcegroup_BulkDeleteFailures)
- [bookingstatus_BulkDeleteFailures](#BKMK_bookingstatus_BulkDeleteFailures)
- [characteristic_BulkDeleteFailures](#BKMK_characteristic_BulkDeleteFailures)
- [ratingmodel_BulkDeleteFailures](#BKMK_ratingmodel_BulkDeleteFailures)
- [ratingvalue_BulkDeleteFailures](#BKMK_ratingvalue_BulkDeleteFailures)
- [BulkOperation_BulkDeleteFailures](#BKMK_BulkOperation_BulkDeleteFailures)
- [BulkOperationLog_BulkDeleteFailures](#BKMK_BulkOperationLog_BulkDeleteFailures)
- [Campaign_BulkDeleteFailures](#BKMK_Campaign_BulkDeleteFailures)
- [CampaignActivity_BulkDeleteFailures](#BKMK_CampaignActivity_BulkDeleteFailures)
- [CampaignResponse_BulkDeleteFailures](#BKMK_CampaignResponse_BulkDeleteFailures)
- [List_BulkDeleteFailures](#BKMK_List_BulkDeleteFailures)
- [ConstraintBasedGroup_BulkDeleteFailures](#BKMK_ConstraintBasedGroup_BulkDeleteFailures)
- [Contract_BulkDeleteFailures](#BKMK_Contract_BulkDeleteFailures)
- [ContractDetail_BulkDeleteFailures](#BKMK_ContractDetail_BulkDeleteFailures)
- [ContractTemplate_BulkDeleteFailures](#BKMK_ContractTemplate_BulkDeleteFailures)
- [entitlement_BulkDeleteFailures](#BKMK_entitlement_BulkDeleteFailures)
- [entitlementchannel_BulkDeleteFailures](#BKMK_entitlementchannel_BulkDeleteFailures)
- [entitlementtemplate_BulkDeleteFailures](#BKMK_entitlementtemplate_BulkDeleteFailures)
- [entitlementtemplatechannel_BulkDeleteFailures](#BKMK_entitlementtemplatechannel_BulkDeleteFailures)
- [Equipment_BulkDeleteFailures](#BKMK_Equipment_BulkDeleteFailures)
- [Incident_BulkDeleteFailures](#BKMK_Incident_BulkDeleteFailures)
- [IncidentResolution_BulkDeleteFailures](#BKMK_IncidentResolution_BulkDeleteFailures)
- [knowledgearticleincident_BulkDeleteFailures](#BKMK_knowledgearticleincident_BulkDeleteFailures)
- [phonetocaseprocess_BulkDeleteFailures](#BKMK_phonetocaseprocess_BulkDeleteFailures)
- [Resource_BulkDeleteFailures](#BKMK_Resource_BulkDeleteFailures)
- [ResourceGroup_BulkDeleteFailures](#BKMK_ResourceGroup_BulkDeleteFailures)
- [ResourceSpec_BulkDeleteFailures](#BKMK_ResourceSpec_BulkDeleteFailures)
- [Service_BulkDeleteFailures](#BKMK_Service_BulkDeleteFailures)
- [ServiceAppointment_BulkDeleteFailures](#BKMK_ServiceAppointment_BulkDeleteFailures)
- [Site_BulkDeleteFailures](#BKMK_Site_BulkDeleteFailures)
- [Discount_BulkDeleteFailures](#BKMK_Discount_BulkDeleteFailures)
- [DiscountType_BulkDeleteFailures](#BKMK_DiscountType_BulkDeleteFailures)
- [Invoice_BulkDeleteFailures](#BKMK_Invoice_BulkDeleteFailures)
- [InvoiceDetail_BulkDeleteFailures](#BKMK_InvoiceDetail_BulkDeleteFailures)
- [leadtoopportunitysalesprocess_BulkDeleteFailures](#BKMK_leadtoopportunitysalesprocess_BulkDeleteFailures)
- [Opportunity_BulkDeleteFailures](#BKMK_Opportunity_BulkDeleteFailures)
- [OpportunityClose_BulkDeleteFailures](#BKMK_OpportunityClose_BulkDeleteFailures)
- [OpportunityProduct_BulkDeleteFailures](#BKMK_OpportunityProduct_BulkDeleteFailures)
- [opportunitysalesprocess_BulkDeleteFailures](#BKMK_opportunitysalesprocess_BulkDeleteFailures)
- [OrderClose_BulkDeleteFailures](#BKMK_OrderClose_BulkDeleteFailures)
- [Quote_BulkDeleteFailures](#BKMK_Quote_BulkDeleteFailures)
- [QuoteClose_BulkDeleteFailures](#BKMK_QuoteClose_BulkDeleteFailures)
- [QuoteDetail_BulkDeleteFailures](#BKMK_QuoteDetail_BulkDeleteFailures)
- [SalesLiterature_BulkDeleteFailures](#BKMK_SalesLiterature_BulkDeleteFailures)
- [SalesLiteratureItem_BulkDeleteFailures](#BKMK_SalesLiteratureItem_BulkDeleteFailures)
- [SalesOrder_BulkDeleteFailures](#BKMK_SalesOrder_BulkDeleteFailures)
- [SalesOrderDetail_BulkDeleteFailures](#BKMK_SalesOrderDetail_BulkDeleteFailures)
- [Competitor_BulkDeleteFailures](#BKMK_Competitor_BulkDeleteFailures)
- [msdyn_relationshipinsightsunifiedconfig_BulkDeleteFailures](#BKMK_msdyn_relationshipinsightsunifiedconfig_BulkDeleteFailures)
- [msdyn_siconfig_BulkDeleteFailures](#BKMK_msdyn_siconfig_BulkDeleteFailures)
- [msdyn_postalbum_BulkDeleteFailures](#BKMK_msdyn_postalbum_BulkDeleteFailures)
- [msdyn_postconfig_BulkDeleteFailures](#BKMK_msdyn_postconfig_BulkDeleteFailures)
- [msdyn_postruleconfig_BulkDeleteFailures](#BKMK_msdyn_postruleconfig_BulkDeleteFailures)
- [msdyn_wallsavedquery_BulkDeleteFailures](#BKMK_msdyn_wallsavedquery_BulkDeleteFailures)
- [msdyn_wallsavedqueryusersettings_BulkDeleteFailures](#BKMK_msdyn_wallsavedqueryusersettings_BulkDeleteFailures)
- [KnowledgeBaseRecord_BulkDeleteFailures](#BKMK_KnowledgeBaseRecord_BulkDeleteFailures)
- [Role_BulkDeleteFailures](#BKMK_Role_BulkDeleteFailures)
- [Subject_BulkDeleteFailures](#BKMK_Subject_BulkDeleteFailures)
- [Fax_BulkDeleteFailures](#BKMK_Fax_BulkDeleteFailures)
- [Privilege_BulkDeleteFailures](#BKMK_Privilege_BulkDeleteFailures)
- [KbArticle_BulkDeleteFailures](#BKMK_KbArticle_BulkDeleteFailures)
- [KbArticleComment_BulkDeleteFailures](#BKMK_KbArticleComment_BulkDeleteFailures)
- [AnnualFiscalCalendar_BulkDeleteFailures](#BKMK_AnnualFiscalCalendar_BulkDeleteFailures)
- [UserForm_BulkDeleteFailures](#BKMK_UserForm_BulkDeleteFailures)
- [Queue_BulkDeleteFailures](#BKMK_Queue_BulkDeleteFailures)
- [Contact_BulkDeleteFailures](#BKMK_Contact_BulkDeleteFailures)
- [emailserverprofile_bulkdeletefailures](#BKMK_emailserverprofile_bulkdeletefailures)
- [SavedQuery_BulkDeleteFailures](#BKMK_SavedQuery_BulkDeleteFailures)
- [Appointment_BulkDeleteFailures](#BKMK_Appointment_BulkDeleteFailures)
- [Template_BulkDeleteFailures](#BKMK_Template_BulkDeleteFailures)
- [Account_BulkDeleteFailures](#BKMK_Account_BulkDeleteFailures)
- [SystemUser_BulkDeleteFailures](#BKMK_SystemUser_BulkDeleteFailures)
- [QuarterlyFiscalCalendar_BulkDeleteFailures](#BKMK_QuarterlyFiscalCalendar_BulkDeleteFailures)
- [QueueItem_BulkDeleteFailures](#BKMK_QueueItem_BulkDeleteFailures)
- [DisplayString_BulkDeleteFailures](#BKMK_DisplayString_BulkDeleteFailures)
- [Calendar_BulkDeleteFailures](#BKMK_Calendar_BulkDeleteFailures)
- [Organization_BulkDeleteFailures](#BKMK_Organization_BulkDeleteFailures)
- [BusinessUnit_BulkDeleteFailures](#BKMK_BusinessUnit_BulkDeleteFailures)
- [Annotation_BulkDeleteFailures](#BKMK_Annotation_BulkDeleteFailures)
- [ImportLog_BulkDeleteFailures](#BKMK_ImportLog_BulkDeleteFailures)
- [Import_BulkDeleteFailures](#BKMK_Import_BulkDeleteFailures)
- [Letter_BulkDeleteFailures](#BKMK_Letter_BulkDeleteFailures)
- [UserQuery_BulkDeleteFailures](#BKMK_UserQuery_BulkDeleteFailures)
- [PhoneCall_BulkDeleteFailures](#BKMK_PhoneCall_BulkDeleteFailures)
- [Team_BulkDeleteFailures](#BKMK_Team_BulkDeleteFailures)
- [CustomerAddress_BulkDeleteFailures](#BKMK_CustomerAddress_BulkDeleteFailures)
- [SocialActivity_BulkDeleteFailures](#BKMK_SocialActivity_BulkDeleteFailures)
- [ImportFile_BulkDeleteFailures](#BKMK_ImportFile_BulkDeleteFailures)
- [SystemForm_BulkDeleteFailures](#BKMK_SystemForm_BulkDeleteFailures)
- [BusinessUnitNewsArticle_BulkDeleteFailures](#BKMK_BusinessUnitNewsArticle_BulkDeleteFailures)
- [ImportMap_BulkDeleteFailures](#BKMK_ImportMap_BulkDeleteFailures)
- [RecurringAppointmentMaster_BulkDeleteFailures](#BKMK_RecurringAppointmentMaster_BulkDeleteFailures)
- [Email_BulkDeleteFailures](#BKMK_Email_BulkDeleteFailures)
- [MonthlyFiscalCalendar_BulkDeleteFailures](#BKMK_MonthlyFiscalCalendar_BulkDeleteFailures)
- [KbArticleTemplate_BulkDeleteFailures](#BKMK_KbArticleTemplate_BulkDeleteFailures)
- [ActivityPointer_BulkDeleteFailures](#BKMK_ActivityPointer_BulkDeleteFailures)
- [slabase_BulkDeleteFailures](#BKMK_slabase_BulkDeleteFailures)
- [FixedMonthlyFiscalCalendar_BulkDeleteFailures](#BKMK_FixedMonthlyFiscalCalendar_BulkDeleteFailures)
- [Task_BulkDeleteFailures](#BKMK_Task_BulkDeleteFailures)
- [BulkDeleteOperation_BulkDeleteFailure](#BKMK_BulkDeleteOperation_BulkDeleteFailure)
- [ActivityMimeAttachment_BulkDeleteFailures](#BKMK_ActivityMimeAttachment_BulkDeleteFailures)
- [SemiAnnualFiscalCalendar_BulkDeleteFailures](#BKMK_SemiAnnualFiscalCalendar_BulkDeleteFailures)


### <a name="BKMK_theme_BulkDeleteFailures"></a> theme_BulkDeleteFailures

See the [theme_BulkDeleteFailures](theme.md#BKMK_theme_BulkDeleteFailures) one-to-many relationship for the [theme](theme.md) entity.

### <a name="BKMK_usermapping_BulkDeleteFailures"></a> usermapping_BulkDeleteFailures

See the [usermapping_BulkDeleteFailures](usermapping.md#BKMK_usermapping_BulkDeleteFailures) one-to-many relationship for the [usermapping](usermapping.md) entity.

### <a name="BKMK_knowledgearticle_BulkDeleteFailures"></a> knowledgearticle_BulkDeleteFailures

See the [knowledgearticle_BulkDeleteFailures](knowledgearticle.md#BKMK_knowledgearticle_BulkDeleteFailures) one-to-many relationship for the [knowledgearticle](knowledgearticle.md) entity.

### <a name="BKMK_post_BulkDeleteFailures"></a> post_BulkDeleteFailures

See the [post_BulkDeleteFailures](post.md#BKMK_post_BulkDeleteFailures) one-to-many relationship for the [post](post.md) entity.

### <a name="BKMK_Territory_BulkDeleteFailures"></a> Territory_BulkDeleteFailures

**Added by**: Application Common Solution

See the [Territory_BulkDeleteFailures](territory.md#BKMK_Territory_BulkDeleteFailures) one-to-many relationship for the [territory](territory.md) entity.

### <a name="BKMK_leadaddress_BulkDeleteFailures"></a> leadaddress_BulkDeleteFailures

**Added by**: Lead Management Solution

See the [leadaddress_BulkDeleteFailures](leadaddress.md#BKMK_leadaddress_BulkDeleteFailures) one-to-many relationship for the [leadaddress](leadaddress.md) entity.

### <a name="BKMK_Lead_BulkDeleteFailures"></a> Lead_BulkDeleteFailures

**Added by**: Lead Management Solution

See the [Lead_BulkDeleteFailures](lead.md#BKMK_Lead_BulkDeleteFailures) one-to-many relationship for the [lead](lead.md) entity.

### <a name="BKMK_dynamicproperty_BulkDeleteFailures"></a> dynamicproperty_BulkDeleteFailures

**Added by**: Product Management Solution

See the [dynamicproperty_BulkDeleteFailures](dynamicproperty.md#BKMK_dynamicproperty_BulkDeleteFailures) one-to-many relationship for the [dynamicproperty](dynamicproperty.md) entity.

### <a name="BKMK_dynamicpropertyassociation_BulkDeleteFailures"></a> dynamicpropertyassociation_BulkDeleteFailures

**Added by**: Product Management Solution

See the [dynamicpropertyassociation_BulkDeleteFailures](dynamicpropertyassociation.md#BKMK_dynamicpropertyassociation_BulkDeleteFailures) one-to-many relationship for the [dynamicpropertyassociation](dynamicpropertyassociation.md) entity.

### <a name="BKMK_dynamicpropertyinstance_BulkDeleteFailures"></a> dynamicpropertyinstance_BulkDeleteFailures

**Added by**: Product Management Solution

See the [dynamicpropertyinstance_BulkDeleteFailures](dynamicpropertyinstance.md#BKMK_dynamicpropertyinstance_BulkDeleteFailures) one-to-many relationship for the [dynamicpropertyinstance](dynamicpropertyinstance.md) entity.

### <a name="BKMK_dynamicpropertyoptionsetitem_BulkDeleteFailures"></a> dynamicpropertyoptionsetitem_BulkDeleteFailures

**Added by**: Product Management Solution

See the [dynamicpropertyoptionsetitem_BulkDeleteFailures](dynamicpropertyoptionsetitem.md#BKMK_dynamicpropertyoptionsetitem_BulkDeleteFailures) one-to-many relationship for the [dynamicpropertyoptionsetitem](dynamicpropertyoptionsetitem.md) entity.

### <a name="BKMK_PriceLevel_BulkDeleteFailures"></a> PriceLevel_BulkDeleteFailures

**Added by**: Product Management Solution

See the [PriceLevel_BulkDeleteFailures](pricelevel.md#BKMK_PriceLevel_BulkDeleteFailures) one-to-many relationship for the [pricelevel](pricelevel.md) entity.

### <a name="BKMK_Product_BulkDeleteFailures"></a> Product_BulkDeleteFailures

**Added by**: Product Management Solution

See the [Product_BulkDeleteFailures](product.md#BKMK_Product_BulkDeleteFailures) one-to-many relationship for the [product](product.md) entity.

### <a name="BKMK_productassociation_BulkDeleteFailures"></a> productassociation_BulkDeleteFailures

**Added by**: Product Management Solution

See the [productassociation_BulkDeleteFailures](productassociation.md#BKMK_productassociation_BulkDeleteFailures) one-to-many relationship for the [productassociation](productassociation.md) entity.

### <a name="BKMK_ProductPriceLevel_BulkDeleteFailures"></a> ProductPriceLevel_BulkDeleteFailures

**Added by**: Product Management Solution

See the [ProductPriceLevel_BulkDeleteFailures](productpricelevel.md#BKMK_ProductPriceLevel_BulkDeleteFailures) one-to-many relationship for the [productpricelevel](productpricelevel.md) entity.

### <a name="BKMK_ProductSubstitute_BulkDeleteFailures"></a> ProductSubstitute_BulkDeleteFailures

**Added by**: Product Management Solution

See the [ProductSubstitute_BulkDeleteFailures](productsubstitute.md#BKMK_ProductSubstitute_BulkDeleteFailures) one-to-many relationship for the [productsubstitute](productsubstitute.md) entity.

### <a name="BKMK_UoM_BulkDeleteFailures"></a> UoM_BulkDeleteFailures

**Added by**: Product Management Solution

See the [UoM_BulkDeleteFailures](uom.md#BKMK_UoM_BulkDeleteFailures) one-to-many relationship for the [uom](uom.md) entity.

### <a name="BKMK_UoMSchedule_BulkDeleteFailures"></a> UoMSchedule_BulkDeleteFailures

**Added by**: Product Management Solution

See the [UoMSchedule_BulkDeleteFailures](uomschedule.md#BKMK_UoMSchedule_BulkDeleteFailures) one-to-many relationship for the [uomschedule](uomschedule.md) entity.

### <a name="BKMK_bookableresource_BulkDeleteFailures"></a> bookableresource_BulkDeleteFailures

**Added by**: Scheduling Solution

See the [bookableresource_BulkDeleteFailures](bookableresource.md#BKMK_bookableresource_BulkDeleteFailures) one-to-many relationship for the [bookableresource](bookableresource.md) entity.

### <a name="BKMK_bookableresourcebooking_BulkDeleteFailures"></a> bookableresourcebooking_BulkDeleteFailures

**Added by**: Scheduling Solution

See the [bookableresourcebooking_BulkDeleteFailures](bookableresourcebooking.md#BKMK_bookableresourcebooking_BulkDeleteFailures) one-to-many relationship for the [bookableresourcebooking](bookableresourcebooking.md) entity.

### <a name="BKMK_bookableresourcebookingheader_BulkDeleteFailures"></a> bookableresourcebookingheader_BulkDeleteFailures

**Added by**: Scheduling Solution

See the [bookableresourcebookingheader_BulkDeleteFailures](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_BulkDeleteFailures) one-to-many relationship for the [bookableresourcebookingheader](bookableresourcebookingheader.md) entity.

### <a name="BKMK_bookableresourcecategory_BulkDeleteFailures"></a> bookableresourcecategory_BulkDeleteFailures

**Added by**: Scheduling Solution

See the [bookableresourcecategory_BulkDeleteFailures](bookableresourcecategory.md#BKMK_bookableresourcecategory_BulkDeleteFailures) one-to-many relationship for the [bookableresourcecategory](bookableresourcecategory.md) entity.

### <a name="BKMK_bookableresourcecategoryassn_BulkDeleteFailures"></a> bookableresourcecategoryassn_BulkDeleteFailures

**Added by**: Scheduling Solution

See the [bookableresourcecategoryassn_BulkDeleteFailures](bookableresourcecategoryassn.md#BKMK_bookableresourcecategoryassn_BulkDeleteFailures) one-to-many relationship for the [bookableresourcecategoryassn](bookableresourcecategoryassn.md) entity.

### <a name="BKMK_bookableresourcecharacteristic_BulkDeleteFailures"></a> bookableresourcecharacteristic_BulkDeleteFailures

**Added by**: Scheduling Solution

See the [bookableresourcecharacteristic_BulkDeleteFailures](bookableresourcecharacteristic.md#BKMK_bookableresourcecharacteristic_BulkDeleteFailures) one-to-many relationship for the [bookableresourcecharacteristic](bookableresourcecharacteristic.md) entity.

### <a name="BKMK_bookableresourcegroup_BulkDeleteFailures"></a> bookableresourcegroup_BulkDeleteFailures

**Added by**: Scheduling Solution

See the [bookableresourcegroup_BulkDeleteFailures](bookableresourcegroup.md#BKMK_bookableresourcegroup_BulkDeleteFailures) one-to-many relationship for the [bookableresourcegroup](bookableresourcegroup.md) entity.

### <a name="BKMK_bookingstatus_BulkDeleteFailures"></a> bookingstatus_BulkDeleteFailures

**Added by**: Scheduling Solution

See the [bookingstatus_BulkDeleteFailures](bookingstatus.md#BKMK_bookingstatus_BulkDeleteFailures) one-to-many relationship for the [bookingstatus](bookingstatus.md) entity.

### <a name="BKMK_characteristic_BulkDeleteFailures"></a> characteristic_BulkDeleteFailures

**Added by**: Scheduling Solution

See the [characteristic_BulkDeleteFailures](characteristic.md#BKMK_characteristic_BulkDeleteFailures) one-to-many relationship for the [characteristic](characteristic.md) entity.

### <a name="BKMK_ratingmodel_BulkDeleteFailures"></a> ratingmodel_BulkDeleteFailures

**Added by**: Scheduling Solution

See the [ratingmodel_BulkDeleteFailures](ratingmodel.md#BKMK_ratingmodel_BulkDeleteFailures) one-to-many relationship for the [ratingmodel](ratingmodel.md) entity.

### <a name="BKMK_ratingvalue_BulkDeleteFailures"></a> ratingvalue_BulkDeleteFailures

**Added by**: Scheduling Solution

See the [ratingvalue_BulkDeleteFailures](ratingvalue.md#BKMK_ratingvalue_BulkDeleteFailures) one-to-many relationship for the [ratingvalue](ratingvalue.md) entity.

### <a name="BKMK_BulkOperation_BulkDeleteFailures"></a> BulkOperation_BulkDeleteFailures

**Added by**: Marketing Solution

See the [BulkOperation_BulkDeleteFailures](bulkoperation.md#BKMK_BulkOperation_BulkDeleteFailures) one-to-many relationship for the [bulkoperation](bulkoperation.md) entity.

### <a name="BKMK_BulkOperationLog_BulkDeleteFailures"></a> BulkOperationLog_BulkDeleteFailures

**Added by**: Marketing Solution

See the [BulkOperationLog_BulkDeleteFailures](bulkoperationlog.md#BKMK_BulkOperationLog_BulkDeleteFailures) one-to-many relationship for the [bulkoperationlog](bulkoperationlog.md) entity.

### <a name="BKMK_Campaign_BulkDeleteFailures"></a> Campaign_BulkDeleteFailures

**Added by**: Marketing Solution

See the [Campaign_BulkDeleteFailures](campaign.md#BKMK_Campaign_BulkDeleteFailures) one-to-many relationship for the [campaign](campaign.md) entity.

### <a name="BKMK_CampaignActivity_BulkDeleteFailures"></a> CampaignActivity_BulkDeleteFailures

**Added by**: Marketing Solution

See the [CampaignActivity_BulkDeleteFailures](campaignactivity.md#BKMK_CampaignActivity_BulkDeleteFailures) one-to-many relationship for the [campaignactivity](campaignactivity.md) entity.

### <a name="BKMK_CampaignResponse_BulkDeleteFailures"></a> CampaignResponse_BulkDeleteFailures

**Added by**: Marketing Solution

See the [CampaignResponse_BulkDeleteFailures](campaignresponse.md#BKMK_CampaignResponse_BulkDeleteFailures) one-to-many relationship for the [campaignresponse](campaignresponse.md) entity.

### <a name="BKMK_List_BulkDeleteFailures"></a> List_BulkDeleteFailures

**Added by**: Marketing Solution

See the [List_BulkDeleteFailures](list.md#BKMK_List_BulkDeleteFailures) one-to-many relationship for the [list](list.md) entity.

### <a name="BKMK_ConstraintBasedGroup_BulkDeleteFailures"></a> ConstraintBasedGroup_BulkDeleteFailures

**Added by**: Service Solution

See the [ConstraintBasedGroup_BulkDeleteFailures](constraintbasedgroup.md#BKMK_ConstraintBasedGroup_BulkDeleteFailures) one-to-many relationship for the [constraintbasedgroup](constraintbasedgroup.md) entity.

### <a name="BKMK_Contract_BulkDeleteFailures"></a> Contract_BulkDeleteFailures

**Added by**: Service Solution

See the [Contract_BulkDeleteFailures](contract.md#BKMK_Contract_BulkDeleteFailures) one-to-many relationship for the [contract](contract.md) entity.

### <a name="BKMK_ContractDetail_BulkDeleteFailures"></a> ContractDetail_BulkDeleteFailures

**Added by**: Service Solution

See the [ContractDetail_BulkDeleteFailures](contractdetail.md#BKMK_ContractDetail_BulkDeleteFailures) one-to-many relationship for the [contractdetail](contractdetail.md) entity.

### <a name="BKMK_ContractTemplate_BulkDeleteFailures"></a> ContractTemplate_BulkDeleteFailures

**Added by**: Service Solution

See the [ContractTemplate_BulkDeleteFailures](contracttemplate.md#BKMK_ContractTemplate_BulkDeleteFailures) one-to-many relationship for the [contracttemplate](contracttemplate.md) entity.

### <a name="BKMK_entitlement_BulkDeleteFailures"></a> entitlement_BulkDeleteFailures

**Added by**: Service Solution

See the [entitlement_BulkDeleteFailures](entitlement.md#BKMK_entitlement_BulkDeleteFailures) one-to-many relationship for the [entitlement](entitlement.md) entity.

### <a name="BKMK_entitlementchannel_BulkDeleteFailures"></a> entitlementchannel_BulkDeleteFailures

**Added by**: Service Solution

See the [entitlementchannel_BulkDeleteFailures](entitlementchannel.md#BKMK_entitlementchannel_BulkDeleteFailures) one-to-many relationship for the [entitlementchannel](entitlementchannel.md) entity.

### <a name="BKMK_entitlementtemplate_BulkDeleteFailures"></a> entitlementtemplate_BulkDeleteFailures

**Added by**: Service Solution

See the [entitlementtemplate_BulkDeleteFailures](entitlementtemplate.md#BKMK_entitlementtemplate_BulkDeleteFailures) one-to-many relationship for the [entitlementtemplate](entitlementtemplate.md) entity.

### <a name="BKMK_entitlementtemplatechannel_BulkDeleteFailures"></a> entitlementtemplatechannel_BulkDeleteFailures

**Added by**: Service Solution

See the [entitlementtemplatechannel_BulkDeleteFailures](entitlementtemplatechannel.md#BKMK_entitlementtemplatechannel_BulkDeleteFailures) one-to-many relationship for the [entitlementtemplatechannel](entitlementtemplatechannel.md) entity.

### <a name="BKMK_Equipment_BulkDeleteFailures"></a> Equipment_BulkDeleteFailures

**Added by**: Service Solution

See the [Equipment_BulkDeleteFailures](equipment.md#BKMK_Equipment_BulkDeleteFailures) one-to-many relationship for the [equipment](equipment.md) entity.

### <a name="BKMK_Incident_BulkDeleteFailures"></a> Incident_BulkDeleteFailures

**Added by**: Service Solution

See the [Incident_BulkDeleteFailures](incident.md#BKMK_Incident_BulkDeleteFailures) one-to-many relationship for the [incident](incident.md) entity.

### <a name="BKMK_IncidentResolution_BulkDeleteFailures"></a> IncidentResolution_BulkDeleteFailures

**Added by**: Service Solution

See the [IncidentResolution_BulkDeleteFailures](incidentresolution.md#BKMK_IncidentResolution_BulkDeleteFailures) one-to-many relationship for the [incidentresolution](incidentresolution.md) entity.

### <a name="BKMK_knowledgearticleincident_BulkDeleteFailures"></a> knowledgearticleincident_BulkDeleteFailures

**Added by**: Service Solution

See the [knowledgearticleincident_BulkDeleteFailures](knowledgearticleincident.md#BKMK_knowledgearticleincident_BulkDeleteFailures) one-to-many relationship for the [knowledgearticleincident](knowledgearticleincident.md) entity.

### <a name="BKMK_phonetocaseprocess_BulkDeleteFailures"></a> phonetocaseprocess_BulkDeleteFailures

**Added by**: Service Solution

See the [phonetocaseprocess_BulkDeleteFailures](phonetocaseprocess.md#BKMK_phonetocaseprocess_BulkDeleteFailures) one-to-many relationship for the [phonetocaseprocess](phonetocaseprocess.md) entity.

### <a name="BKMK_Resource_BulkDeleteFailures"></a> Resource_BulkDeleteFailures

**Added by**: Service Solution

See the [Resource_BulkDeleteFailures](resource.md#BKMK_Resource_BulkDeleteFailures) one-to-many relationship for the [resource](resource.md) entity.

### <a name="BKMK_ResourceGroup_BulkDeleteFailures"></a> ResourceGroup_BulkDeleteFailures

**Added by**: Service Solution

See the [ResourceGroup_BulkDeleteFailures](resourcegroup.md#BKMK_ResourceGroup_BulkDeleteFailures) one-to-many relationship for the [resourcegroup](resourcegroup.md) entity.

### <a name="BKMK_ResourceSpec_BulkDeleteFailures"></a> ResourceSpec_BulkDeleteFailures

**Added by**: Service Solution

See the [ResourceSpec_BulkDeleteFailures](resourcespec.md#BKMK_ResourceSpec_BulkDeleteFailures) one-to-many relationship for the [resourcespec](resourcespec.md) entity.

### <a name="BKMK_Service_BulkDeleteFailures"></a> Service_BulkDeleteFailures

**Added by**: Service Solution

See the [Service_BulkDeleteFailures](service.md#BKMK_Service_BulkDeleteFailures) one-to-many relationship for the [service](service.md) entity.

### <a name="BKMK_ServiceAppointment_BulkDeleteFailures"></a> ServiceAppointment_BulkDeleteFailures

**Added by**: Service Solution

See the [ServiceAppointment_BulkDeleteFailures](serviceappointment.md#BKMK_ServiceAppointment_BulkDeleteFailures) one-to-many relationship for the [serviceappointment](serviceappointment.md) entity.

### <a name="BKMK_Site_BulkDeleteFailures"></a> Site_BulkDeleteFailures

**Added by**: Service Solution

See the [Site_BulkDeleteFailures](site.md#BKMK_Site_BulkDeleteFailures) one-to-many relationship for the [site](site.md) entity.

### <a name="BKMK_Discount_BulkDeleteFailures"></a> Discount_BulkDeleteFailures

**Added by**: Sales Solution

See the [Discount_BulkDeleteFailures](discount.md#BKMK_Discount_BulkDeleteFailures) one-to-many relationship for the [discount](discount.md) entity.

### <a name="BKMK_DiscountType_BulkDeleteFailures"></a> DiscountType_BulkDeleteFailures

**Added by**: Sales Solution

See the [DiscountType_BulkDeleteFailures](discounttype.md#BKMK_DiscountType_BulkDeleteFailures) one-to-many relationship for the [discounttype](discounttype.md) entity.

### <a name="BKMK_Invoice_BulkDeleteFailures"></a> Invoice_BulkDeleteFailures

**Added by**: Sales Solution

See the [Invoice_BulkDeleteFailures](invoice.md#BKMK_Invoice_BulkDeleteFailures) one-to-many relationship for the [invoice](invoice.md) entity.

### <a name="BKMK_InvoiceDetail_BulkDeleteFailures"></a> InvoiceDetail_BulkDeleteFailures

**Added by**: Sales Solution

See the [InvoiceDetail_BulkDeleteFailures](invoicedetail.md#BKMK_InvoiceDetail_BulkDeleteFailures) one-to-many relationship for the [invoicedetail](invoicedetail.md) entity.

### <a name="BKMK_leadtoopportunitysalesprocess_BulkDeleteFailures"></a> leadtoopportunitysalesprocess_BulkDeleteFailures

**Added by**: Sales Solution

See the [leadtoopportunitysalesprocess_BulkDeleteFailures](leadtoopportunitysalesprocess.md#BKMK_leadtoopportunitysalesprocess_BulkDeleteFailures) one-to-many relationship for the [leadtoopportunitysalesprocess](leadtoopportunitysalesprocess.md) entity.

### <a name="BKMK_Opportunity_BulkDeleteFailures"></a> Opportunity_BulkDeleteFailures

**Added by**: Sales Solution

See the [Opportunity_BulkDeleteFailures](opportunity.md#BKMK_Opportunity_BulkDeleteFailures) one-to-many relationship for the [opportunity](opportunity.md) entity.

### <a name="BKMK_OpportunityClose_BulkDeleteFailures"></a> OpportunityClose_BulkDeleteFailures

**Added by**: Sales Solution

See the [OpportunityClose_BulkDeleteFailures](opportunityclose.md#BKMK_OpportunityClose_BulkDeleteFailures) one-to-many relationship for the [opportunityclose](opportunityclose.md) entity.

### <a name="BKMK_OpportunityProduct_BulkDeleteFailures"></a> OpportunityProduct_BulkDeleteFailures

**Added by**: Sales Solution

See the [OpportunityProduct_BulkDeleteFailures](opportunityproduct.md#BKMK_OpportunityProduct_BulkDeleteFailures) one-to-many relationship for the [opportunityproduct](opportunityproduct.md) entity.

### <a name="BKMK_opportunitysalesprocess_BulkDeleteFailures"></a> opportunitysalesprocess_BulkDeleteFailures

**Added by**: Sales Solution

See the [opportunitysalesprocess_BulkDeleteFailures](opportunitysalesprocess.md#BKMK_opportunitysalesprocess_BulkDeleteFailures) one-to-many relationship for the [opportunitysalesprocess](opportunitysalesprocess.md) entity.

### <a name="BKMK_OrderClose_BulkDeleteFailures"></a> OrderClose_BulkDeleteFailures

**Added by**: Sales Solution

See the [OrderClose_BulkDeleteFailures](orderclose.md#BKMK_OrderClose_BulkDeleteFailures) one-to-many relationship for the [orderclose](orderclose.md) entity.

### <a name="BKMK_Quote_BulkDeleteFailures"></a> Quote_BulkDeleteFailures

**Added by**: Sales Solution

See the [Quote_BulkDeleteFailures](quote.md#BKMK_Quote_BulkDeleteFailures) one-to-many relationship for the [quote](quote.md) entity.

### <a name="BKMK_QuoteClose_BulkDeleteFailures"></a> QuoteClose_BulkDeleteFailures

**Added by**: Sales Solution

See the [QuoteClose_BulkDeleteFailures](quoteclose.md#BKMK_QuoteClose_BulkDeleteFailures) one-to-many relationship for the [quoteclose](quoteclose.md) entity.

### <a name="BKMK_QuoteDetail_BulkDeleteFailures"></a> QuoteDetail_BulkDeleteFailures

**Added by**: Sales Solution

See the [QuoteDetail_BulkDeleteFailures](quotedetail.md#BKMK_QuoteDetail_BulkDeleteFailures) one-to-many relationship for the [quotedetail](quotedetail.md) entity.

### <a name="BKMK_SalesLiterature_BulkDeleteFailures"></a> SalesLiterature_BulkDeleteFailures

**Added by**: Sales Solution

See the [SalesLiterature_BulkDeleteFailures](salesliterature.md#BKMK_SalesLiterature_BulkDeleteFailures) one-to-many relationship for the [salesliterature](salesliterature.md) entity.

### <a name="BKMK_SalesLiteratureItem_BulkDeleteFailures"></a> SalesLiteratureItem_BulkDeleteFailures

**Added by**: Sales Solution

See the [SalesLiteratureItem_BulkDeleteFailures](salesliteratureitem.md#BKMK_SalesLiteratureItem_BulkDeleteFailures) one-to-many relationship for the [salesliteratureitem](salesliteratureitem.md) entity.

### <a name="BKMK_SalesOrder_BulkDeleteFailures"></a> SalesOrder_BulkDeleteFailures

**Added by**: Sales Solution

See the [SalesOrder_BulkDeleteFailures](salesorder.md#BKMK_SalesOrder_BulkDeleteFailures) one-to-many relationship for the [salesorder](salesorder.md) entity.

### <a name="BKMK_SalesOrderDetail_BulkDeleteFailures"></a> SalesOrderDetail_BulkDeleteFailures

**Added by**: Sales Solution

See the [SalesOrderDetail_BulkDeleteFailures](salesorderdetail.md#BKMK_SalesOrderDetail_BulkDeleteFailures) one-to-many relationship for the [salesorderdetail](salesorderdetail.md) entity.

### <a name="BKMK_Competitor_BulkDeleteFailures"></a> Competitor_BulkDeleteFailures

**Added by**: Sales Solution

See the [Competitor_BulkDeleteFailures](competitor.md#BKMK_Competitor_BulkDeleteFailures) one-to-many relationship for the [competitor](competitor.md) entity.

### <a name="BKMK_msdyn_relationshipinsightsunifiedconfig_BulkDeleteFailures"></a> msdyn_relationshipinsightsunifiedconfig_BulkDeleteFailures

**Added by**: SI Common Solution

See the [msdyn_relationshipinsightsunifiedconfig_BulkDeleteFailures](msdyn_relationshipinsightsunifiedconfig.md#BKMK_msdyn_relationshipinsightsunifiedconfig_BulkDeleteFailures) one-to-many relationship for the [msdyn_relationshipinsightsunifiedconfig](msdyn_relationshipinsightsunifiedconfig.md) entity.

### <a name="BKMK_msdyn_siconfig_BulkDeleteFailures"></a> msdyn_siconfig_BulkDeleteFailures

**Added by**: SI Common Solution

See the [msdyn_siconfig_BulkDeleteFailures](msdyn_siconfig.md#BKMK_msdyn_siconfig_BulkDeleteFailures) one-to-many relationship for the [msdyn_siconfig](msdyn_siconfig.md) entity.

### <a name="BKMK_msdyn_postalbum_BulkDeleteFailures"></a> msdyn_postalbum_BulkDeleteFailures

**Added by**: Activity Feeds Solution

See the [msdyn_postalbum_BulkDeleteFailures](msdyn_postalbum.md#BKMK_msdyn_postalbum_BulkDeleteFailures) one-to-many relationship for the [msdyn_postalbum](msdyn_postalbum.md) entity.

### <a name="BKMK_msdyn_postconfig_BulkDeleteFailures"></a> msdyn_postconfig_BulkDeleteFailures

**Added by**: Activity Feeds Solution

See the [msdyn_postconfig_BulkDeleteFailures](msdyn_postconfig.md#BKMK_msdyn_postconfig_BulkDeleteFailures) one-to-many relationship for the [msdyn_postconfig](msdyn_postconfig.md) entity.

### <a name="BKMK_msdyn_postruleconfig_BulkDeleteFailures"></a> msdyn_postruleconfig_BulkDeleteFailures

**Added by**: Activity Feeds Solution

See the [msdyn_postruleconfig_BulkDeleteFailures](msdyn_postruleconfig.md#BKMK_msdyn_postruleconfig_BulkDeleteFailures) one-to-many relationship for the [msdyn_postruleconfig](msdyn_postruleconfig.md) entity.

### <a name="BKMK_msdyn_wallsavedquery_BulkDeleteFailures"></a> msdyn_wallsavedquery_BulkDeleteFailures

**Added by**: Activity Feeds Solution

See the [msdyn_wallsavedquery_BulkDeleteFailures](msdyn_wallsavedquery.md#BKMK_msdyn_wallsavedquery_BulkDeleteFailures) one-to-many relationship for the [msdyn_wallsavedquery](msdyn_wallsavedquery.md) entity.

### <a name="BKMK_msdyn_wallsavedqueryusersettings_BulkDeleteFailures"></a> msdyn_wallsavedqueryusersettings_BulkDeleteFailures

**Added by**: Activity Feeds Solution

See the [msdyn_wallsavedqueryusersettings_BulkDeleteFailures](msdyn_wallsavedqueryusersettings.md#BKMK_msdyn_wallsavedqueryusersettings_BulkDeleteFailures) one-to-many relationship for the [msdyn_wallsavedqueryusersettings](msdyn_wallsavedqueryusersettings.md) entity.

### <a name="BKMK_KnowledgeBaseRecord_BulkDeleteFailures"></a> KnowledgeBaseRecord_BulkDeleteFailures

See the [KnowledgeBaseRecord_BulkDeleteFailures](knowledgebaserecord.md#BKMK_KnowledgeBaseRecord_BulkDeleteFailures) one-to-many relationship for the [knowledgebaserecord](knowledgebaserecord.md) entity.

### <a name="BKMK_Role_BulkDeleteFailures"></a> Role_BulkDeleteFailures

See the [Role_BulkDeleteFailures](role.md#BKMK_Role_BulkDeleteFailures) one-to-many relationship for the [role](role.md) entity.

### <a name="BKMK_Subject_BulkDeleteFailures"></a> Subject_BulkDeleteFailures

See the [Subject_BulkDeleteFailures](subject.md#BKMK_Subject_BulkDeleteFailures) one-to-many relationship for the [subject](subject.md) entity.

### <a name="BKMK_Fax_BulkDeleteFailures"></a> Fax_BulkDeleteFailures

See the [Fax_BulkDeleteFailures](fax.md#BKMK_Fax_BulkDeleteFailures) one-to-many relationship for the [fax](fax.md) entity.

### <a name="BKMK_Privilege_BulkDeleteFailures"></a> Privilege_BulkDeleteFailures

See the [Privilege_BulkDeleteFailures](privilege.md#BKMK_Privilege_BulkDeleteFailures) one-to-many relationship for the [privilege](privilege.md) entity.

### <a name="BKMK_KbArticle_BulkDeleteFailures"></a> KbArticle_BulkDeleteFailures

See the [KbArticle_BulkDeleteFailures](kbarticle.md#BKMK_KbArticle_BulkDeleteFailures) one-to-many relationship for the [kbarticle](kbarticle.md) entity.

### <a name="BKMK_KbArticleComment_BulkDeleteFailures"></a> KbArticleComment_BulkDeleteFailures

See the [KbArticleComment_BulkDeleteFailures](kbarticlecomment.md#BKMK_KbArticleComment_BulkDeleteFailures) one-to-many relationship for the [kbarticlecomment](kbarticlecomment.md) entity.

### <a name="BKMK_AnnualFiscalCalendar_BulkDeleteFailures"></a> AnnualFiscalCalendar_BulkDeleteFailures

See the [AnnualFiscalCalendar_BulkDeleteFailures](annualfiscalcalendar.md#BKMK_AnnualFiscalCalendar_BulkDeleteFailures) one-to-many relationship for the [annualfiscalcalendar](annualfiscalcalendar.md) entity.

### <a name="BKMK_UserForm_BulkDeleteFailures"></a> UserForm_BulkDeleteFailures

See the [UserForm_BulkDeleteFailures](userform.md#BKMK_UserForm_BulkDeleteFailures) one-to-many relationship for the [userform](userform.md) entity.

### <a name="BKMK_Queue_BulkDeleteFailures"></a> Queue_BulkDeleteFailures

See the [Queue_BulkDeleteFailures](queue.md#BKMK_Queue_BulkDeleteFailures) one-to-many relationship for the [queue](queue.md) entity.

### <a name="BKMK_Contact_BulkDeleteFailures"></a> Contact_BulkDeleteFailures

See the [Contact_BulkDeleteFailures](contact.md#BKMK_Contact_BulkDeleteFailures) one-to-many relationship for the [contact](contact.md) entity.

### <a name="BKMK_emailserverprofile_bulkdeletefailures"></a> emailserverprofile_bulkdeletefailures

See the [emailserverprofile_bulkdeletefailures](emailserverprofile.md#BKMK_emailserverprofile_bulkdeletefailures) one-to-many relationship for the [emailserverprofile](emailserverprofile.md) entity.

### <a name="BKMK_SavedQuery_BulkDeleteFailures"></a> SavedQuery_BulkDeleteFailures

See the [SavedQuery_BulkDeleteFailures](savedquery.md#BKMK_SavedQuery_BulkDeleteFailures) one-to-many relationship for the [savedquery](savedquery.md) entity.

### <a name="BKMK_Appointment_BulkDeleteFailures"></a> Appointment_BulkDeleteFailures

See the [Appointment_BulkDeleteFailures](appointment.md#BKMK_Appointment_BulkDeleteFailures) one-to-many relationship for the [appointment](appointment.md) entity.

### <a name="BKMK_Template_BulkDeleteFailures"></a> Template_BulkDeleteFailures

See the [Template_BulkDeleteFailures](template.md#BKMK_Template_BulkDeleteFailures) one-to-many relationship for the [template](template.md) entity.

### <a name="BKMK_Account_BulkDeleteFailures"></a> Account_BulkDeleteFailures

See the [Account_BulkDeleteFailures](account.md#BKMK_Account_BulkDeleteFailures) one-to-many relationship for the [account](account.md) entity.

### <a name="BKMK_SystemUser_BulkDeleteFailures"></a> SystemUser_BulkDeleteFailures

See the [SystemUser_BulkDeleteFailures](systemuser.md#BKMK_SystemUser_BulkDeleteFailures) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_QuarterlyFiscalCalendar_BulkDeleteFailures"></a> QuarterlyFiscalCalendar_BulkDeleteFailures

See the [QuarterlyFiscalCalendar_BulkDeleteFailures](quarterlyfiscalcalendar.md#BKMK_QuarterlyFiscalCalendar_BulkDeleteFailures) one-to-many relationship for the [quarterlyfiscalcalendar](quarterlyfiscalcalendar.md) entity.

### <a name="BKMK_QueueItem_BulkDeleteFailures"></a> QueueItem_BulkDeleteFailures

See the [QueueItem_BulkDeleteFailures](queueitem.md#BKMK_QueueItem_BulkDeleteFailures) one-to-many relationship for the [queueitem](queueitem.md) entity.

### <a name="BKMK_DisplayString_BulkDeleteFailures"></a> DisplayString_BulkDeleteFailures

See the [DisplayString_BulkDeleteFailures](displaystring.md#BKMK_DisplayString_BulkDeleteFailures) one-to-many relationship for the [displaystring](displaystring.md) entity.

### <a name="BKMK_Calendar_BulkDeleteFailures"></a> Calendar_BulkDeleteFailures

See the [Calendar_BulkDeleteFailures](calendar.md#BKMK_Calendar_BulkDeleteFailures) one-to-many relationship for the [calendar](calendar.md) entity.

### <a name="BKMK_Organization_BulkDeleteFailures"></a> Organization_BulkDeleteFailures

See the [Organization_BulkDeleteFailures](organization.md#BKMK_Organization_BulkDeleteFailures) one-to-many relationship for the [organization](organization.md) entity.

### <a name="BKMK_BusinessUnit_BulkDeleteFailures"></a> BusinessUnit_BulkDeleteFailures

See the [BusinessUnit_BulkDeleteFailures](businessunit.md#BKMK_BusinessUnit_BulkDeleteFailures) one-to-many relationship for the [businessunit](businessunit.md) entity.

### <a name="BKMK_Annotation_BulkDeleteFailures"></a> Annotation_BulkDeleteFailures

See the [Annotation_BulkDeleteFailures](annotation.md#BKMK_Annotation_BulkDeleteFailures) one-to-many relationship for the [annotation](annotation.md) entity.

### <a name="BKMK_ImportLog_BulkDeleteFailures"></a> ImportLog_BulkDeleteFailures

See the [ImportLog_BulkDeleteFailures](importlog.md#BKMK_ImportLog_BulkDeleteFailures) one-to-many relationship for the [importlog](importlog.md) entity.

### <a name="BKMK_Import_BulkDeleteFailures"></a> Import_BulkDeleteFailures

See the [Import_BulkDeleteFailures](import.md#BKMK_Import_BulkDeleteFailures) one-to-many relationship for the [import](import.md) entity.

### <a name="BKMK_Letter_BulkDeleteFailures"></a> Letter_BulkDeleteFailures

See the [Letter_BulkDeleteFailures](letter.md#BKMK_Letter_BulkDeleteFailures) one-to-many relationship for the [letter](letter.md) entity.

### <a name="BKMK_UserQuery_BulkDeleteFailures"></a> UserQuery_BulkDeleteFailures

See the [UserQuery_BulkDeleteFailures](userquery.md#BKMK_UserQuery_BulkDeleteFailures) one-to-many relationship for the [userquery](userquery.md) entity.

### <a name="BKMK_PhoneCall_BulkDeleteFailures"></a> PhoneCall_BulkDeleteFailures

See the [PhoneCall_BulkDeleteFailures](phonecall.md#BKMK_PhoneCall_BulkDeleteFailures) one-to-many relationship for the [phonecall](phonecall.md) entity.

### <a name="BKMK_Team_BulkDeleteFailures"></a> Team_BulkDeleteFailures

See the [Team_BulkDeleteFailures](team.md#BKMK_Team_BulkDeleteFailures) one-to-many relationship for the [team](team.md) entity.

### <a name="BKMK_CustomerAddress_BulkDeleteFailures"></a> CustomerAddress_BulkDeleteFailures

See the [CustomerAddress_BulkDeleteFailures](customeraddress.md#BKMK_CustomerAddress_BulkDeleteFailures) one-to-many relationship for the [customeraddress](customeraddress.md) entity.

### <a name="BKMK_SocialActivity_BulkDeleteFailures"></a> SocialActivity_BulkDeleteFailures

See the [SocialActivity_BulkDeleteFailures](socialactivity.md#BKMK_SocialActivity_BulkDeleteFailures) one-to-many relationship for the [socialactivity](socialactivity.md) entity.

### <a name="BKMK_ImportFile_BulkDeleteFailures"></a> ImportFile_BulkDeleteFailures

See the [ImportFile_BulkDeleteFailures](importfile.md#BKMK_ImportFile_BulkDeleteFailures) one-to-many relationship for the [importfile](importfile.md) entity.

### <a name="BKMK_SystemForm_BulkDeleteFailures"></a> SystemForm_BulkDeleteFailures

See the [SystemForm_BulkDeleteFailures](systemform.md#BKMK_SystemForm_BulkDeleteFailures) one-to-many relationship for the [systemform](systemform.md) entity.

### <a name="BKMK_BusinessUnitNewsArticle_BulkDeleteFailures"></a> BusinessUnitNewsArticle_BulkDeleteFailures

See the [BusinessUnitNewsArticle_BulkDeleteFailures](businessunitnewsarticle.md#BKMK_BusinessUnitNewsArticle_BulkDeleteFailures) one-to-many relationship for the [businessunitnewsarticle](businessunitnewsarticle.md) entity.

### <a name="BKMK_ImportMap_BulkDeleteFailures"></a> ImportMap_BulkDeleteFailures

See the [ImportMap_BulkDeleteFailures](importmap.md#BKMK_ImportMap_BulkDeleteFailures) one-to-many relationship for the [importmap](importmap.md) entity.

### <a name="BKMK_RecurringAppointmentMaster_BulkDeleteFailures"></a> RecurringAppointmentMaster_BulkDeleteFailures

See the [RecurringAppointmentMaster_BulkDeleteFailures](recurringappointmentmaster.md#BKMK_RecurringAppointmentMaster_BulkDeleteFailures) one-to-many relationship for the [recurringappointmentmaster](recurringappointmentmaster.md) entity.

### <a name="BKMK_Email_BulkDeleteFailures"></a> Email_BulkDeleteFailures

See the [Email_BulkDeleteFailures](email.md#BKMK_Email_BulkDeleteFailures) one-to-many relationship for the [email](email.md) entity.

### <a name="BKMK_MonthlyFiscalCalendar_BulkDeleteFailures"></a> MonthlyFiscalCalendar_BulkDeleteFailures

See the [MonthlyFiscalCalendar_BulkDeleteFailures](monthlyfiscalcalendar.md#BKMK_MonthlyFiscalCalendar_BulkDeleteFailures) one-to-many relationship for the [monthlyfiscalcalendar](monthlyfiscalcalendar.md) entity.

### <a name="BKMK_KbArticleTemplate_BulkDeleteFailures"></a> KbArticleTemplate_BulkDeleteFailures

See the [KbArticleTemplate_BulkDeleteFailures](kbarticletemplate.md#BKMK_KbArticleTemplate_BulkDeleteFailures) one-to-many relationship for the [kbarticletemplate](kbarticletemplate.md) entity.

### <a name="BKMK_ActivityPointer_BulkDeleteFailures"></a> ActivityPointer_BulkDeleteFailures

See the [ActivityPointer_BulkDeleteFailures](activitypointer.md#BKMK_ActivityPointer_BulkDeleteFailures) one-to-many relationship for the [activitypointer](activitypointer.md) entity.

### <a name="BKMK_slabase_BulkDeleteFailures"></a> slabase_BulkDeleteFailures

See the [slabase_BulkDeleteFailures](sla.md#BKMK_slabase_BulkDeleteFailures) one-to-many relationship for the [sla](sla.md) entity.

### <a name="BKMK_FixedMonthlyFiscalCalendar_BulkDeleteFailures"></a> FixedMonthlyFiscalCalendar_BulkDeleteFailures

See the [FixedMonthlyFiscalCalendar_BulkDeleteFailures](fixedmonthlyfiscalcalendar.md#BKMK_FixedMonthlyFiscalCalendar_BulkDeleteFailures) one-to-many relationship for the [fixedmonthlyfiscalcalendar](fixedmonthlyfiscalcalendar.md) entity.

### <a name="BKMK_Task_BulkDeleteFailures"></a> Task_BulkDeleteFailures

See the [Task_BulkDeleteFailures](task.md#BKMK_Task_BulkDeleteFailures) one-to-many relationship for the [task](task.md) entity.

### <a name="BKMK_BulkDeleteOperation_BulkDeleteFailure"></a> BulkDeleteOperation_BulkDeleteFailure

See the [BulkDeleteOperation_BulkDeleteFailure](bulkdeleteoperation.md#BKMK_BulkDeleteOperation_BulkDeleteFailure) one-to-many relationship for the [bulkdeleteoperation](bulkdeleteoperation.md) entity.

### <a name="BKMK_ActivityMimeAttachment_BulkDeleteFailures"></a> ActivityMimeAttachment_BulkDeleteFailures

See the [ActivityMimeAttachment_BulkDeleteFailures](activitymimeattachment.md#BKMK_ActivityMimeAttachment_BulkDeleteFailures) one-to-many relationship for the [activitymimeattachment](activitymimeattachment.md) entity.

### <a name="BKMK_SemiAnnualFiscalCalendar_BulkDeleteFailures"></a> SemiAnnualFiscalCalendar_BulkDeleteFailures

See the [SemiAnnualFiscalCalendar_BulkDeleteFailures](semiannualfiscalcalendar.md#BKMK_SemiAnnualFiscalCalendar_BulkDeleteFailures) one-to-many relationship for the [semiannualfiscalcalendar](semiannualfiscalcalendar.md) entity.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Web API EntityType Reference](/power-apps/developer/data-platform/webapi/reference/entitytypes)
