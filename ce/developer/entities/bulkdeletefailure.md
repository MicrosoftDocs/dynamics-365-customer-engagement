---
title: "BulkDeleteFailure Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the BulkDeleteFailure entity."
ms.date: 12/05/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# BulkDeleteFailure Entity Reference

Record that was not deleted during a bulk deletion job.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Retrieve|GET [*org URI*]/api/data/v9.0/bulkdeletefailures(*bulkdeletefailureid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/bulkdeletefailures<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|

## Entity Properties

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
|Targets|account,accountleads,activitymimeattachment,activitypointer,annotation,annualfiscalcalendar,appointment,attributemap,bookableresource,bookableresourcebooking,bookableresourcebookingexchangesyncidmapping,bookableresourcebookingheader,bookableresourcecategory,bookableresourcecategoryassn,bookableresourcecharacteristic,bookableresourcegroup,bookingstatus,bulkoperation,bulkoperationlog,businessunit,businessunitnewsarticle,calendar,campaign,campaignactivity,campaignactivityitem,campaignitem,campaignresponse,channelaccessprofile,channelaccessprofilerule,characteristic,childincidentcount,commitment,competitor,competitoraddress,competitorproduct,competitorsalesliterature,constraintbasedgroup,contact,contactinvoices,contactleads,contactorders,contactquotes,contract,contractdetail,contracttemplate,customeraddress,customeropportunityrole,customerrelationship,discount,discounttype,displaystring,dynamicproperty,dynamicpropertyassociation,dynamicpropertyinstance,dynamicpropertyoptionsetitem,email,emailserverprofile,entitlement,entitlementchannel,entitlementcontacts,entitlementproducts,entitlementtemplate,entitlementtemplatechannel,entitlementtemplateproducts,entitymap,equipment,externalparty,externalpartyitem,fax,fixedmonthlyfiscalcalendar,import,importdata,importfile,importlog,importmap,incident,incidentknowledgebaserecord,incidentresolution,invoice,invoicedetail,isvconfig,kbarticle,kbarticlecomment,kbarticletemplate,knowledgearticle,knowledgearticleincident,knowledgebaserecord,lead,leadaddress,leadcompetitors,leadproduct,leadtoopportunitysalesprocess,letter,list,listmember,monthlyfiscalcalendar,msdyn_accountpricelist,msdyn_actual,msdyn_agreement,msdyn_agreementbookingdate,msdyn_agreementbookingincident,msdyn_agreementbookingproduct,msdyn_agreementbookingservice,msdyn_agreementbookingservicetask,msdyn_agreementbookingsetup,msdyn_agreementinvoicedate,msdyn_agreementinvoiceproduct,msdyn_agreementinvoicesetup,msdyn_agreementsubstatus,msdyn_approval,msdyn_batchjob,msdyn_bookingalert,msdyn_bookingalertstatus,msdyn_bookingchange,msdyn_bookingjournal,msdyn_bookingrule,msdyn_bookingsetupmetadata,msdyn_bookingtimestamp,msdyn_bpf_2c5fe86acc8b414b8322ae571000c799,msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b,msdyn_bpf_665e73aa18c247d886bfc50499c73b82,msdyn_bpf_989e9b1857e24af18787d5143b67523b,msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3,msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39,msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d,msdyn_characteristicreqforteammember,msdyn_clientextension,msdyn_configuration,msdyn_contactpricelist,msdyn_contractlineinvoiceschedule,msdyn_contractlinescheduleofvalue,msdyn_customerasset,msdyn_dataexport,msdyn_delegation,msdyn_estimate,msdyn_estimateline,msdyn_expense,msdyn_expensecategory,msdyn_expensereceipt,msdyn_fact,msdyn_fieldcomputation,msdyn_fieldservicepricelistitem,msdyn_fieldservicesetting,msdyn_fieldservicesystemjob,msdyn_findworkevent,msdyn_incidenttype,msdyn_incidenttypecharacteristic,msdyn_incidenttypeproduct,msdyn_incidenttypeservice,msdyn_incidenttypeservicetask,msdyn_integrationjob,msdyn_integrationjobdetail,msdyn_inventoryadjustment,msdyn_inventoryadjustmentproduct,msdyn_inventoryjournal,msdyn_inventorytransfer,msdyn_invoicefrequency,msdyn_invoicefrequencydetail,msdyn_invoicelinetransaction,msdyn_iotalert,msdyn_iotdevice,msdyn_iotdevicecategory,msdyn_iotdevicecommand,msdyn_iotdeviceregistrationhistory,msdyn_journal,msdyn_journalline,msdyn_mlresultcache,msdyn_opportunitylineresourcecategory,msdyn_opportunitylinetransaction,msdyn_opportunitylinetransactioncategory,msdyn_opportunitylinetransactionclassificatio,msdyn_opportunitypricelist,msdyn_orderinvoicingdate,msdyn_orderinvoicingproduct,msdyn_orderinvoicingsetup,msdyn_orderinvoicingsetupdate,msdyn_orderlineresourcecategory,msdyn_orderlinetransaction,msdyn_orderlinetransactioncategory,msdyn_orderlinetransactionclassification,msdyn_orderpricelist,msdyn_organizationalunit,msdyn_payment,msdyn_paymentdetail,msdyn_paymentmethod,msdyn_paymentterm,msdyn_postalbum,msdyn_postalcode,msdyn_postconfig,msdyn_postruleconfig,msdyn_priority,msdyn_processnotes,msdyn_productinventory,msdyn_project,msdyn_projectapproval,msdyn_projectparameter,msdyn_projectparameterpricelist,msdyn_projectpricelist,msdyn_projecttask,msdyn_projecttaskdependency,msdyn_projecttaskstatususer,msdyn_projectteam,msdyn_projectteammembersignup,msdyn_projecttransactioncategory,msdyn_purchaseorder,msdyn_purchaseorderbill,msdyn_purchaseorderproduct,msdyn_purchaseorderreceipt,msdyn_purchaseorderreceiptproduct,msdyn_purchaseordersubstatus,msdyn_quotebookingincident,msdyn_quotebookingproduct,msdyn_quotebookingservice,msdyn_quotebookingservicetask,msdyn_quotebookingsetup,msdyn_quoteinvoicingproduct,msdyn_quoteinvoicingsetup,msdyn_quotelineanalyticsbreakdown,msdyn_quotelineinvoiceschedule,msdyn_quotelineresourcecategory,msdyn_quotelinescheduleofvalue,msdyn_quotelinetransaction,msdyn_quotelinetransactioncategory,msdyn_quotelinetransactionclassification,msdyn_quotepricelist,msdyn_requirementcharacteristic,msdyn_requirementorganizationunit,msdyn_requirementresourcecategory,msdyn_requirementresourcepreference,msdyn_requirementstatus,msdyn_resourceassignment,msdyn_resourceassignmentdetail,msdyn_resourcecategorypricelevel,msdyn_resourcepaytype,msdyn_resourcerequest,msdyn_resourcerequirement,msdyn_resourcerequirementdetail,msdyn_resourceterritory,msdyn_rma,msdyn_rmaproduct,msdyn_rmareceipt,msdyn_rmareceiptproduct,msdyn_rmasubstatus,msdyn_rolecompetencyrequirement,msdyn_roleutilization,msdyn_rtv,msdyn_rtvproduct,msdyn_rtvsubstatus,msdyn_scheduleboardsetting,msdyn_schedulingparameter,msdyn_servicetasktype,msdyn_shipvia,msdyn_systemuserschedulersetting,msdyn_taxcode,msdyn_taxcodedetail,msdyn_timeentry,msdyn_timegroup,msdyn_timegroupdetail,msdyn_timeoffcalendar,msdyn_timeoffrequest,msdyn_transactioncategory,msdyn_transactioncategoryclassification,msdyn_transactioncategoryhierarchyelement,msdyn_transactioncategorypricelevel,msdyn_transactionconnection,msdyn_transactionorigin,msdyn_transactiontype,msdyn_uniquenumber,msdyn_userworkhistory,msdyn_wallsavedquery,msdyn_wallsavedqueryusersettings,msdyn_warehouse,msdyn_workhourtemplate,msdyn_workorder,msdyn_workordercharacteristic,msdyn_workorderdetailsgenerationqueue,msdyn_workorderincident,msdyn_workorderproduct,msdyn_workorderresourcerestriction,msdyn_workorderservice,msdyn_workorderservicetask,msdyn_workordersubstatus,msdyn_workordertype,opportunity,opportunityclose,opportunitycompetitors,opportunityproduct,opportunitysalesprocess,orderclose,organization,phonecall,phonetocaseprocess,post,pricelevel,privilege,product,productassociation,productpricelevel,productsalesliterature,productsubstitute,quarterlyfiscalcalendar,queue,queueitem,quote,quoteclose,quotedetail,ratingmodel,ratingvalue,recurringappointmentmaster,relationshiprole,relationshiprolemap,resource,resourcegroup,resourcegroupexpansion,resourcespec,role,routingrule,routingruleitem,salesliterature,salesliteratureitem,salesorder,salesorderdetail,salesprocessinstance,savedquery,semiannualfiscalcalendar,service,serviceappointment,servicecontractcontacts,site,sla,socialactivity,subject,systemform,systemuser,task,team,template,territory,theme,topic,topichistory,topicmodel,topicmodelconfiguration,topicmodelexecutionhistory,uom,uomschedule,userform,usermapping,userquery|
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

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.


### <a name="BKMK_userentityinstancedata_bulkdeletefailure"></a> userentityinstancedata_bulkdeletefailure

Same as userentityinstancedata entity [userentityinstancedata_bulkdeletefailure](userentityinstancedata.md#BKMK_userentityinstancedata_bulkdeletefailure) Many-To-One relationship.
|Property|Value|
|--------|-----|
|ReferencingEntity|userentityinstancedata|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|userentityinstancedata_bulkdeletefailure|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: Cascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [Territory_BulkDeleteFailures](#BKMK_Territory_BulkDeleteFailures)
- [accountleads_BulkDeleteFailures](#BKMK_accountleads_BulkDeleteFailures)
- [contactleads_BulkDeleteFailures](#BKMK_contactleads_BulkDeleteFailures)
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
- [bookableresourcebookingexchangesyncidmapping_BulkDeleteFailures](#BKMK_bookableresourcebookingexchangesyncidmapping_BulkDeleteFailures)
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
- [campaignactivityitem_BulkDeleteFailures](#BKMK_campaignactivityitem_BulkDeleteFailures)
- [campaignitem_BulkDeleteFailures](#BKMK_campaignitem_BulkDeleteFailures)
- [CampaignResponse_BulkDeleteFailures](#BKMK_CampaignResponse_BulkDeleteFailures)
- [List_BulkDeleteFailures](#BKMK_List_BulkDeleteFailures)
- [listmember_BulkDeleteFailures](#BKMK_listmember_BulkDeleteFailures)
- [commitment_BulkDeleteFailures](#BKMK_commitment_BulkDeleteFailures)
- [ConstraintBasedGroup_BulkDeleteFailures](#BKMK_ConstraintBasedGroup_BulkDeleteFailures)
- [Contract_BulkDeleteFailures](#BKMK_Contract_BulkDeleteFailures)
- [ContractDetail_BulkDeleteFailures](#BKMK_ContractDetail_BulkDeleteFailures)
- [ContractTemplate_BulkDeleteFailures](#BKMK_ContractTemplate_BulkDeleteFailures)
- [entitlement_BulkDeleteFailures](#BKMK_entitlement_BulkDeleteFailures)
- [entitlementchannel_BulkDeleteFailures](#BKMK_entitlementchannel_BulkDeleteFailures)
- [entitlementcontacts_BulkDeleteFailures](#BKMK_entitlementcontacts_BulkDeleteFailures)
- [entitlementproducts_BulkDeleteFailures](#BKMK_entitlementproducts_BulkDeleteFailures)
- [entitlementtemplate_BulkDeleteFailures](#BKMK_entitlementtemplate_BulkDeleteFailures)
- [entitlementtemplatechannel_BulkDeleteFailures](#BKMK_entitlementtemplatechannel_BulkDeleteFailures)
- [entitlementtemplateproducts_BulkDeleteFailures](#BKMK_entitlementtemplateproducts_BulkDeleteFailures)
- [Equipment_BulkDeleteFailures](#BKMK_Equipment_BulkDeleteFailures)
- [Incident_BulkDeleteFailures](#BKMK_Incident_BulkDeleteFailures)
- [incidentknowledgebaserecord_BulkDeleteFailures](#BKMK_incidentknowledgebaserecord_BulkDeleteFailures)
- [IncidentResolution_BulkDeleteFailures](#BKMK_IncidentResolution_BulkDeleteFailures)
- [knowledgearticleincident_BulkDeleteFailures](#BKMK_knowledgearticleincident_BulkDeleteFailures)
- [phonetocaseprocess_BulkDeleteFailures](#BKMK_phonetocaseprocess_BulkDeleteFailures)
- [Resource_BulkDeleteFailures](#BKMK_Resource_BulkDeleteFailures)
- [ResourceGroup_BulkDeleteFailures](#BKMK_ResourceGroup_BulkDeleteFailures)
- [ResourceSpec_BulkDeleteFailures](#BKMK_ResourceSpec_BulkDeleteFailures)
- [Service_BulkDeleteFailures](#BKMK_Service_BulkDeleteFailures)
- [ServiceAppointment_BulkDeleteFailures](#BKMK_ServiceAppointment_BulkDeleteFailures)
- [servicecontractcontacts_BulkDeleteFailures](#BKMK_servicecontractcontacts_BulkDeleteFailures)
- [topic_BulkDeleteFailures](#BKMK_topic_BulkDeleteFailures)
- [topichistory_BulkDeleteFailures](#BKMK_topichistory_BulkDeleteFailures)
- [topicmodel_BulkDeleteFailures](#BKMK_topicmodel_BulkDeleteFailures)
- [topicmodelconfiguration_BulkDeleteFailures](#BKMK_topicmodelconfiguration_BulkDeleteFailures)
- [topicmodelexecutionhistory_BulkDeleteFailures](#BKMK_topicmodelexecutionhistory_BulkDeleteFailures)
- [Site_BulkDeleteFailures](#BKMK_Site_BulkDeleteFailures)
- [competitorproduct_BulkDeleteFailures](#BKMK_competitorproduct_BulkDeleteFailures)
- [competitorsalesliterature_BulkDeleteFailures](#BKMK_competitorsalesliterature_BulkDeleteFailures)
- [contactinvoices_BulkDeleteFailures](#BKMK_contactinvoices_BulkDeleteFailures)
- [contactorders_BulkDeleteFailures](#BKMK_contactorders_BulkDeleteFailures)
- [contactquotes_BulkDeleteFailures](#BKMK_contactquotes_BulkDeleteFailures)
- [CustomerOpportunityRole_BulkDeleteFailures](#BKMK_CustomerOpportunityRole_BulkDeleteFailures)
- [Discount_BulkDeleteFailures](#BKMK_Discount_BulkDeleteFailures)
- [DiscountType_BulkDeleteFailures](#BKMK_DiscountType_BulkDeleteFailures)
- [Invoice_BulkDeleteFailures](#BKMK_Invoice_BulkDeleteFailures)
- [InvoiceDetail_BulkDeleteFailures](#BKMK_InvoiceDetail_BulkDeleteFailures)
- [leadcompetitors_BulkDeleteFailures](#BKMK_leadcompetitors_BulkDeleteFailures)
- [leadproduct_BulkDeleteFailures](#BKMK_leadproduct_BulkDeleteFailures)
- [leadtoopportunitysalesprocess_BulkDeleteFailures](#BKMK_leadtoopportunitysalesprocess_BulkDeleteFailures)
- [Opportunity_BulkDeleteFailures](#BKMK_Opportunity_BulkDeleteFailures)
- [OpportunityClose_BulkDeleteFailures](#BKMK_OpportunityClose_BulkDeleteFailures)
- [opportunitycompetitors_BulkDeleteFailures](#BKMK_opportunitycompetitors_BulkDeleteFailures)
- [OpportunityProduct_BulkDeleteFailures](#BKMK_OpportunityProduct_BulkDeleteFailures)
- [opportunitysalesprocess_BulkDeleteFailures](#BKMK_opportunitysalesprocess_BulkDeleteFailures)
- [OrderClose_BulkDeleteFailures](#BKMK_OrderClose_BulkDeleteFailures)
- [productsalesliterature_BulkDeleteFailures](#BKMK_productsalesliterature_BulkDeleteFailures)
- [Quote_BulkDeleteFailures](#BKMK_Quote_BulkDeleteFailures)
- [QuoteClose_BulkDeleteFailures](#BKMK_QuoteClose_BulkDeleteFailures)
- [QuoteDetail_BulkDeleteFailures](#BKMK_QuoteDetail_BulkDeleteFailures)
- [SalesLiterature_BulkDeleteFailures](#BKMK_SalesLiterature_BulkDeleteFailures)
- [SalesLiteratureItem_BulkDeleteFailures](#BKMK_SalesLiteratureItem_BulkDeleteFailures)
- [SalesOrder_BulkDeleteFailures](#BKMK_SalesOrder_BulkDeleteFailures)
- [SalesOrderDetail_BulkDeleteFailures](#BKMK_SalesOrderDetail_BulkDeleteFailures)
- [Competitor_BulkDeleteFailures](#BKMK_Competitor_BulkDeleteFailures)
- [msdyn_postalbum_BulkDeleteFailures](#BKMK_msdyn_postalbum_BulkDeleteFailures)
- [msdyn_postconfig_BulkDeleteFailures](#BKMK_msdyn_postconfig_BulkDeleteFailures)
- [msdyn_postruleconfig_BulkDeleteFailures](#BKMK_msdyn_postruleconfig_BulkDeleteFailures)
- [msdyn_wallsavedquery_BulkDeleteFailures](#BKMK_msdyn_wallsavedquery_BulkDeleteFailures)
- [msdyn_wallsavedqueryusersettings_BulkDeleteFailures](#BKMK_msdyn_wallsavedqueryusersettings_BulkDeleteFailures)
- [msdyn_actual_BulkDeleteFailures](#BKMK_msdyn_actual_BulkDeleteFailures)
- [msdyn_bookingalert_BulkDeleteFailures](#BKMK_msdyn_bookingalert_BulkDeleteFailures)
- [msdyn_bookingalertstatus_BulkDeleteFailures](#BKMK_msdyn_bookingalertstatus_BulkDeleteFailures)
- [msdyn_bookingchange_BulkDeleteFailures](#BKMK_msdyn_bookingchange_BulkDeleteFailures)
- [msdyn_bookingrule_BulkDeleteFailures](#BKMK_msdyn_bookingrule_BulkDeleteFailures)
- [msdyn_bookingsetupmetadata_BulkDeleteFailures](#BKMK_msdyn_bookingsetupmetadata_BulkDeleteFailures)
- [msdyn_clientextension_BulkDeleteFailures](#BKMK_msdyn_clientextension_BulkDeleteFailures)
- [msdyn_configuration_BulkDeleteFailures](#BKMK_msdyn_configuration_BulkDeleteFailures)
- [msdyn_organizationalunit_BulkDeleteFailures](#BKMK_msdyn_organizationalunit_BulkDeleteFailures)
- [msdyn_priority_BulkDeleteFailures](#BKMK_msdyn_priority_BulkDeleteFailures)
- [msdyn_requirementcharacteristic_BulkDeleteFailures](#BKMK_msdyn_requirementcharacteristic_BulkDeleteFailures)
- [msdyn_requirementorganizationunit_BulkDeleteFailures](#BKMK_msdyn_requirementorganizationunit_BulkDeleteFailures)
- [msdyn_requirementresourcecategory_BulkDeleteFailures](#BKMK_msdyn_requirementresourcecategory_BulkDeleteFailures)
- [msdyn_requirementresourcepreference_BulkDeleteFailures](#BKMK_msdyn_requirementresourcepreference_BulkDeleteFailures)
- [msdyn_requirementstatus_BulkDeleteFailures](#BKMK_msdyn_requirementstatus_BulkDeleteFailures)
- [msdyn_resourcerequirement_BulkDeleteFailures](#BKMK_msdyn_resourcerequirement_BulkDeleteFailures)
- [msdyn_resourcerequirementdetail_BulkDeleteFailures](#BKMK_msdyn_resourcerequirementdetail_BulkDeleteFailures)
- [msdyn_resourceterritory_BulkDeleteFailures](#BKMK_msdyn_resourceterritory_BulkDeleteFailures)
- [msdyn_scheduleboardsetting_BulkDeleteFailures](#BKMK_msdyn_scheduleboardsetting_BulkDeleteFailures)
- [msdyn_schedulingparameter_BulkDeleteFailures](#BKMK_msdyn_schedulingparameter_BulkDeleteFailures)
- [msdyn_systemuserschedulersetting_BulkDeleteFailures](#BKMK_msdyn_systemuserschedulersetting_BulkDeleteFailures)
- [msdyn_timegroup_BulkDeleteFailures](#BKMK_msdyn_timegroup_BulkDeleteFailures)
- [msdyn_timegroupdetail_BulkDeleteFailures](#BKMK_msdyn_timegroupdetail_BulkDeleteFailures)
- [msdyn_transactionorigin_BulkDeleteFailures](#BKMK_msdyn_transactionorigin_BulkDeleteFailures)
- [msdyn_workhourtemplate_BulkDeleteFailures](#BKMK_msdyn_workhourtemplate_BulkDeleteFailures)
- [msdyn_accountpricelist_BulkDeleteFailures](#BKMK_msdyn_accountpricelist_BulkDeleteFailures)
- [msdyn_approval_BulkDeleteFailures](#BKMK_msdyn_approval_BulkDeleteFailures)
- [msdyn_batchjob_BulkDeleteFailures](#BKMK_msdyn_batchjob_BulkDeleteFailures)
- [msdyn_bpf_665e73aa18c247d886bfc50499c73b82_BulkDeleteFailures](#BKMK_msdyn_bpf_665e73aa18c247d886bfc50499c73b82_BulkDeleteFailures)
- [msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_BulkDeleteFailures](#BKMK_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_BulkDeleteFailures)
- [msdyn_characteristicreqforteammember_BulkDeleteFailures](#BKMK_msdyn_characteristicreqforteammember_BulkDeleteFailures)
- [msdyn_contactpricelist_BulkDeleteFailures](#BKMK_msdyn_contactpricelist_BulkDeleteFailures)
- [msdyn_contractlineinvoiceschedule_BulkDeleteFailures](#BKMK_msdyn_contractlineinvoiceschedule_BulkDeleteFailures)
- [msdyn_contractlinescheduleofvalue_BulkDeleteFailures](#BKMK_msdyn_contractlinescheduleofvalue_BulkDeleteFailures)
- [msdyn_dataexport_BulkDeleteFailures](#BKMK_msdyn_dataexport_BulkDeleteFailures)
- [msdyn_delegation_BulkDeleteFailures](#BKMK_msdyn_delegation_BulkDeleteFailures)
- [msdyn_estimate_BulkDeleteFailures](#BKMK_msdyn_estimate_BulkDeleteFailures)
- [msdyn_estimateline_BulkDeleteFailures](#BKMK_msdyn_estimateline_BulkDeleteFailures)
- [msdyn_expense_BulkDeleteFailures](#BKMK_msdyn_expense_BulkDeleteFailures)
- [msdyn_expensecategory_BulkDeleteFailures](#BKMK_msdyn_expensecategory_BulkDeleteFailures)
- [msdyn_expensereceipt_BulkDeleteFailures](#BKMK_msdyn_expensereceipt_BulkDeleteFailures)
- [msdyn_fact_BulkDeleteFailures](#BKMK_msdyn_fact_BulkDeleteFailures)
- [msdyn_fieldcomputation_BulkDeleteFailures](#BKMK_msdyn_fieldcomputation_BulkDeleteFailures)
- [msdyn_findworkevent_BulkDeleteFailures](#BKMK_msdyn_findworkevent_BulkDeleteFailures)
- [msdyn_integrationjob_BulkDeleteFailures](#BKMK_msdyn_integrationjob_BulkDeleteFailures)
- [msdyn_integrationjobdetail_BulkDeleteFailures](#BKMK_msdyn_integrationjobdetail_BulkDeleteFailures)
- [msdyn_invoicefrequency_BulkDeleteFailures](#BKMK_msdyn_invoicefrequency_BulkDeleteFailures)
- [msdyn_invoicefrequencydetail_BulkDeleteFailures](#BKMK_msdyn_invoicefrequencydetail_BulkDeleteFailures)
- [msdyn_invoicelinetransaction_BulkDeleteFailures](#BKMK_msdyn_invoicelinetransaction_BulkDeleteFailures)
- [msdyn_journal_BulkDeleteFailures](#BKMK_msdyn_journal_BulkDeleteFailures)
- [msdyn_journalline_BulkDeleteFailures](#BKMK_msdyn_journalline_BulkDeleteFailures)
- [msdyn_mlresultcache_BulkDeleteFailures](#BKMK_msdyn_mlresultcache_BulkDeleteFailures)
- [msdyn_opportunitylineresourcecategory_BulkDeleteFailures](#BKMK_msdyn_opportunitylineresourcecategory_BulkDeleteFailures)
- [msdyn_opportunitylinetransaction_BulkDeleteFailures](#BKMK_msdyn_opportunitylinetransaction_BulkDeleteFailures)
- [msdyn_opportunitylinetransactioncategory_BulkDeleteFailures](#BKMK_msdyn_opportunitylinetransactioncategory_BulkDeleteFailures)
- [msdyn_opportunitylinetransactionclassificatio_BulkDeleteFailures](#BKMK_msdyn_opportunitylinetransactionclassificatio_BulkDeleteFailures)
- [msdyn_opportunitypricelist_BulkDeleteFailures](#BKMK_msdyn_opportunitypricelist_BulkDeleteFailures)
- [msdyn_orderlineresourcecategory_BulkDeleteFailures](#BKMK_msdyn_orderlineresourcecategory_BulkDeleteFailures)
- [msdyn_orderlinetransaction_BulkDeleteFailures](#BKMK_msdyn_orderlinetransaction_BulkDeleteFailures)
- [msdyn_orderlinetransactioncategory_BulkDeleteFailures](#BKMK_msdyn_orderlinetransactioncategory_BulkDeleteFailures)
- [msdyn_orderlinetransactionclassification_BulkDeleteFailures](#BKMK_msdyn_orderlinetransactionclassification_BulkDeleteFailures)
- [msdyn_orderpricelist_BulkDeleteFailures](#BKMK_msdyn_orderpricelist_BulkDeleteFailures)
- [msdyn_processnotes_BulkDeleteFailures](#BKMK_msdyn_processnotes_BulkDeleteFailures)
- [msdyn_project_BulkDeleteFailures](#BKMK_msdyn_project_BulkDeleteFailures)
- [msdyn_projectapproval_BulkDeleteFailures](#BKMK_msdyn_projectapproval_BulkDeleteFailures)
- [msdyn_projectparameter_BulkDeleteFailures](#BKMK_msdyn_projectparameter_BulkDeleteFailures)
- [msdyn_projectparameterpricelist_BulkDeleteFailures](#BKMK_msdyn_projectparameterpricelist_BulkDeleteFailures)
- [msdyn_projectpricelist_BulkDeleteFailures](#BKMK_msdyn_projectpricelist_BulkDeleteFailures)
- [msdyn_projecttask_BulkDeleteFailures](#BKMK_msdyn_projecttask_BulkDeleteFailures)
- [msdyn_projecttaskdependency_BulkDeleteFailures](#BKMK_msdyn_projecttaskdependency_BulkDeleteFailures)
- [msdyn_projecttaskstatususer_BulkDeleteFailures](#BKMK_msdyn_projecttaskstatususer_BulkDeleteFailures)
- [msdyn_projectteam_BulkDeleteFailures](#BKMK_msdyn_projectteam_BulkDeleteFailures)
- [msdyn_projectteammembersignup_BulkDeleteFailures](#BKMK_msdyn_projectteammembersignup_BulkDeleteFailures)
- [msdyn_projecttransactioncategory_BulkDeleteFailures](#BKMK_msdyn_projecttransactioncategory_BulkDeleteFailures)
- [msdyn_quotelineanalyticsbreakdown_BulkDeleteFailures](#BKMK_msdyn_quotelineanalyticsbreakdown_BulkDeleteFailures)
- [msdyn_quotelineinvoiceschedule_BulkDeleteFailures](#BKMK_msdyn_quotelineinvoiceschedule_BulkDeleteFailures)
- [msdyn_quotelineresourcecategory_BulkDeleteFailures](#BKMK_msdyn_quotelineresourcecategory_BulkDeleteFailures)
- [msdyn_quotelinescheduleofvalue_BulkDeleteFailures](#BKMK_msdyn_quotelinescheduleofvalue_BulkDeleteFailures)
- [msdyn_quotelinetransaction_BulkDeleteFailures](#BKMK_msdyn_quotelinetransaction_BulkDeleteFailures)
- [msdyn_quotelinetransactioncategory_BulkDeleteFailures](#BKMK_msdyn_quotelinetransactioncategory_BulkDeleteFailures)
- [msdyn_quotelinetransactionclassification_BulkDeleteFailures](#BKMK_msdyn_quotelinetransactionclassification_BulkDeleteFailures)
- [msdyn_quotepricelist_BulkDeleteFailures](#BKMK_msdyn_quotepricelist_BulkDeleteFailures)
- [msdyn_resourceassignment_BulkDeleteFailures](#BKMK_msdyn_resourceassignment_BulkDeleteFailures)
- [msdyn_resourceassignmentdetail_BulkDeleteFailures](#BKMK_msdyn_resourceassignmentdetail_BulkDeleteFailures)
- [msdyn_resourcecategorypricelevel_BulkDeleteFailures](#BKMK_msdyn_resourcecategorypricelevel_BulkDeleteFailures)
- [msdyn_resourcerequest_BulkDeleteFailures](#BKMK_msdyn_resourcerequest_BulkDeleteFailures)
- [msdyn_rolecompetencyrequirement_BulkDeleteFailures](#BKMK_msdyn_rolecompetencyrequirement_BulkDeleteFailures)
- [msdyn_roleutilization_BulkDeleteFailures](#BKMK_msdyn_roleutilization_BulkDeleteFailures)
- [msdyn_timeentry_BulkDeleteFailures](#BKMK_msdyn_timeentry_BulkDeleteFailures)
- [msdyn_timeoffcalendar_BulkDeleteFailures](#BKMK_msdyn_timeoffcalendar_BulkDeleteFailures)
- [msdyn_transactioncategory_BulkDeleteFailures](#BKMK_msdyn_transactioncategory_BulkDeleteFailures)
- [msdyn_transactioncategoryclassification_BulkDeleteFailures](#BKMK_msdyn_transactioncategoryclassification_BulkDeleteFailures)
- [msdyn_transactioncategoryhierarchyelement_BulkDeleteFailures](#BKMK_msdyn_transactioncategoryhierarchyelement_BulkDeleteFailures)
- [msdyn_transactioncategorypricelevel_BulkDeleteFailures](#BKMK_msdyn_transactioncategorypricelevel_BulkDeleteFailures)
- [msdyn_transactionconnection_BulkDeleteFailures](#BKMK_msdyn_transactionconnection_BulkDeleteFailures)
- [msdyn_transactiontype_BulkDeleteFailures](#BKMK_msdyn_transactiontype_BulkDeleteFailures)
- [msdyn_userworkhistory_BulkDeleteFailures](#BKMK_msdyn_userworkhistory_BulkDeleteFailures)
- [msdyn_agreement_BulkDeleteFailures](#BKMK_msdyn_agreement_BulkDeleteFailures)
- [msdyn_agreementbookingdate_BulkDeleteFailures](#BKMK_msdyn_agreementbookingdate_BulkDeleteFailures)
- [msdyn_agreementbookingincident_BulkDeleteFailures](#BKMK_msdyn_agreementbookingincident_BulkDeleteFailures)
- [msdyn_agreementbookingproduct_BulkDeleteFailures](#BKMK_msdyn_agreementbookingproduct_BulkDeleteFailures)
- [msdyn_agreementbookingservice_BulkDeleteFailures](#BKMK_msdyn_agreementbookingservice_BulkDeleteFailures)
- [msdyn_agreementbookingservicetask_BulkDeleteFailures](#BKMK_msdyn_agreementbookingservicetask_BulkDeleteFailures)
- [msdyn_agreementbookingsetup_BulkDeleteFailures](#BKMK_msdyn_agreementbookingsetup_BulkDeleteFailures)
- [msdyn_agreementinvoicedate_BulkDeleteFailures](#BKMK_msdyn_agreementinvoicedate_BulkDeleteFailures)
- [msdyn_agreementinvoiceproduct_BulkDeleteFailures](#BKMK_msdyn_agreementinvoiceproduct_BulkDeleteFailures)
- [msdyn_agreementinvoicesetup_BulkDeleteFailures](#BKMK_msdyn_agreementinvoicesetup_BulkDeleteFailures)
- [msdyn_agreementsubstatus_BulkDeleteFailures](#BKMK_msdyn_agreementsubstatus_BulkDeleteFailures)
- [msdyn_bookingjournal_BulkDeleteFailures](#BKMK_msdyn_bookingjournal_BulkDeleteFailures)
- [msdyn_bookingtimestamp_BulkDeleteFailures](#BKMK_msdyn_bookingtimestamp_BulkDeleteFailures)
- [msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_BulkDeleteFailures](#BKMK_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_BulkDeleteFailures)
- [msdyn_bpf_989e9b1857e24af18787d5143b67523b_BulkDeleteFailures](#BKMK_msdyn_bpf_989e9b1857e24af18787d5143b67523b_BulkDeleteFailures)
- [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_BulkDeleteFailures](#BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_BulkDeleteFailures)
- [msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_BulkDeleteFailures](#BKMK_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_BulkDeleteFailures)
- [msdyn_customerasset_BulkDeleteFailures](#BKMK_msdyn_customerasset_BulkDeleteFailures)
- [msdyn_fieldservicepricelistitem_BulkDeleteFailures](#BKMK_msdyn_fieldservicepricelistitem_BulkDeleteFailures)
- [msdyn_fieldservicesetting_BulkDeleteFailures](#BKMK_msdyn_fieldservicesetting_BulkDeleteFailures)
- [msdyn_fieldservicesystemjob_BulkDeleteFailures](#BKMK_msdyn_fieldservicesystemjob_BulkDeleteFailures)
- [msdyn_incidenttype_BulkDeleteFailures](#BKMK_msdyn_incidenttype_BulkDeleteFailures)
- [msdyn_incidenttypecharacteristic_BulkDeleteFailures](#BKMK_msdyn_incidenttypecharacteristic_BulkDeleteFailures)
- [msdyn_incidenttypeproduct_BulkDeleteFailures](#BKMK_msdyn_incidenttypeproduct_BulkDeleteFailures)
- [msdyn_incidenttypeservice_BulkDeleteFailures](#BKMK_msdyn_incidenttypeservice_BulkDeleteFailures)
- [msdyn_incidenttypeservicetask_BulkDeleteFailures](#BKMK_msdyn_incidenttypeservicetask_BulkDeleteFailures)
- [msdyn_inventoryadjustment_BulkDeleteFailures](#BKMK_msdyn_inventoryadjustment_BulkDeleteFailures)
- [msdyn_inventoryadjustmentproduct_BulkDeleteFailures](#BKMK_msdyn_inventoryadjustmentproduct_BulkDeleteFailures)
- [msdyn_inventoryjournal_BulkDeleteFailures](#BKMK_msdyn_inventoryjournal_BulkDeleteFailures)
- [msdyn_inventorytransfer_BulkDeleteFailures](#BKMK_msdyn_inventorytransfer_BulkDeleteFailures)
- [msdyn_orderinvoicingdate_BulkDeleteFailures](#BKMK_msdyn_orderinvoicingdate_BulkDeleteFailures)
- [msdyn_orderinvoicingproduct_BulkDeleteFailures](#BKMK_msdyn_orderinvoicingproduct_BulkDeleteFailures)
- [msdyn_orderinvoicingsetup_BulkDeleteFailures](#BKMK_msdyn_orderinvoicingsetup_BulkDeleteFailures)
- [msdyn_orderinvoicingsetupdate_BulkDeleteFailures](#BKMK_msdyn_orderinvoicingsetupdate_BulkDeleteFailures)
- [msdyn_payment_BulkDeleteFailures](#BKMK_msdyn_payment_BulkDeleteFailures)
- [msdyn_paymentdetail_BulkDeleteFailures](#BKMK_msdyn_paymentdetail_BulkDeleteFailures)
- [msdyn_paymentmethod_BulkDeleteFailures](#BKMK_msdyn_paymentmethod_BulkDeleteFailures)
- [msdyn_paymentterm_BulkDeleteFailures](#BKMK_msdyn_paymentterm_BulkDeleteFailures)
- [msdyn_postalcode_BulkDeleteFailures](#BKMK_msdyn_postalcode_BulkDeleteFailures)
- [msdyn_productinventory_BulkDeleteFailures](#BKMK_msdyn_productinventory_BulkDeleteFailures)
- [msdyn_purchaseorder_BulkDeleteFailures](#BKMK_msdyn_purchaseorder_BulkDeleteFailures)
- [msdyn_purchaseorderbill_BulkDeleteFailures](#BKMK_msdyn_purchaseorderbill_BulkDeleteFailures)
- [msdyn_purchaseorderproduct_BulkDeleteFailures](#BKMK_msdyn_purchaseorderproduct_BulkDeleteFailures)
- [msdyn_purchaseorderreceipt_BulkDeleteFailures](#BKMK_msdyn_purchaseorderreceipt_BulkDeleteFailures)
- [msdyn_purchaseorderreceiptproduct_BulkDeleteFailures](#BKMK_msdyn_purchaseorderreceiptproduct_BulkDeleteFailures)
- [msdyn_purchaseordersubstatus_BulkDeleteFailures](#BKMK_msdyn_purchaseordersubstatus_BulkDeleteFailures)
- [msdyn_quotebookingincident_BulkDeleteFailures](#BKMK_msdyn_quotebookingincident_BulkDeleteFailures)
- [msdyn_quotebookingproduct_BulkDeleteFailures](#BKMK_msdyn_quotebookingproduct_BulkDeleteFailures)
- [msdyn_quotebookingservice_BulkDeleteFailures](#BKMK_msdyn_quotebookingservice_BulkDeleteFailures)
- [msdyn_quotebookingservicetask_BulkDeleteFailures](#BKMK_msdyn_quotebookingservicetask_BulkDeleteFailures)
- [msdyn_quotebookingsetup_BulkDeleteFailures](#BKMK_msdyn_quotebookingsetup_BulkDeleteFailures)
- [msdyn_quoteinvoicingproduct_BulkDeleteFailures](#BKMK_msdyn_quoteinvoicingproduct_BulkDeleteFailures)
- [msdyn_quoteinvoicingsetup_BulkDeleteFailures](#BKMK_msdyn_quoteinvoicingsetup_BulkDeleteFailures)
- [msdyn_resourcepaytype_BulkDeleteFailures](#BKMK_msdyn_resourcepaytype_BulkDeleteFailures)
- [msdyn_rma_BulkDeleteFailures](#BKMK_msdyn_rma_BulkDeleteFailures)
- [msdyn_rmaproduct_BulkDeleteFailures](#BKMK_msdyn_rmaproduct_BulkDeleteFailures)
- [msdyn_rmareceipt_BulkDeleteFailures](#BKMK_msdyn_rmareceipt_BulkDeleteFailures)
- [msdyn_rmareceiptproduct_BulkDeleteFailures](#BKMK_msdyn_rmareceiptproduct_BulkDeleteFailures)
- [msdyn_rmasubstatus_BulkDeleteFailures](#BKMK_msdyn_rmasubstatus_BulkDeleteFailures)
- [msdyn_rtv_BulkDeleteFailures](#BKMK_msdyn_rtv_BulkDeleteFailures)
- [msdyn_rtvproduct_BulkDeleteFailures](#BKMK_msdyn_rtvproduct_BulkDeleteFailures)
- [msdyn_rtvsubstatus_BulkDeleteFailures](#BKMK_msdyn_rtvsubstatus_BulkDeleteFailures)
- [msdyn_servicetasktype_BulkDeleteFailures](#BKMK_msdyn_servicetasktype_BulkDeleteFailures)
- [msdyn_shipvia_BulkDeleteFailures](#BKMK_msdyn_shipvia_BulkDeleteFailures)
- [msdyn_taxcode_BulkDeleteFailures](#BKMK_msdyn_taxcode_BulkDeleteFailures)
- [msdyn_taxcodedetail_BulkDeleteFailures](#BKMK_msdyn_taxcodedetail_BulkDeleteFailures)
- [msdyn_timeoffrequest_BulkDeleteFailures](#BKMK_msdyn_timeoffrequest_BulkDeleteFailures)
- [msdyn_uniquenumber_BulkDeleteFailures](#BKMK_msdyn_uniquenumber_BulkDeleteFailures)
- [msdyn_warehouse_BulkDeleteFailures](#BKMK_msdyn_warehouse_BulkDeleteFailures)
- [msdyn_workorder_BulkDeleteFailures](#BKMK_msdyn_workorder_BulkDeleteFailures)
- [msdyn_workordercharacteristic_BulkDeleteFailures](#BKMK_msdyn_workordercharacteristic_BulkDeleteFailures)
- [msdyn_workorderdetailsgenerationqueue_BulkDeleteFailures](#BKMK_msdyn_workorderdetailsgenerationqueue_BulkDeleteFailures)
- [msdyn_workorderincident_BulkDeleteFailures](#BKMK_msdyn_workorderincident_BulkDeleteFailures)
- [msdyn_workorderproduct_BulkDeleteFailures](#BKMK_msdyn_workorderproduct_BulkDeleteFailures)
- [msdyn_workorderresourcerestriction_BulkDeleteFailures](#BKMK_msdyn_workorderresourcerestriction_BulkDeleteFailures)
- [msdyn_workorderservice_BulkDeleteFailures](#BKMK_msdyn_workorderservice_BulkDeleteFailures)
- [msdyn_workorderservicetask_BulkDeleteFailures](#BKMK_msdyn_workorderservicetask_BulkDeleteFailures)
- [msdyn_workordersubstatus_BulkDeleteFailures](#BKMK_msdyn_workordersubstatus_BulkDeleteFailures)
- [msdyn_workordertype_BulkDeleteFailures](#BKMK_msdyn_workordertype_BulkDeleteFailures)
- [msdyn_iotalert_BulkDeleteFailures](#BKMK_msdyn_iotalert_BulkDeleteFailures)
- [msdyn_iotdevice_BulkDeleteFailures](#BKMK_msdyn_iotdevice_BulkDeleteFailures)
- [msdyn_iotdevicecategory_BulkDeleteFailures](#BKMK_msdyn_iotdevicecategory_BulkDeleteFailures)
- [msdyn_iotdevicecommand_BulkDeleteFailures](#BKMK_msdyn_iotdevicecommand_BulkDeleteFailures)
- [msdyn_iotdeviceregistrationhistory_BulkDeleteFailures](#BKMK_msdyn_iotdeviceregistrationhistory_BulkDeleteFailures)
- [msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_BulkDeleteFailures](#BKMK_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_BulkDeleteFailures)
- [theme_BulkDeleteFailures](#BKMK_theme_BulkDeleteFailures)
- [usermapping_BulkDeleteFailures](#BKMK_usermapping_BulkDeleteFailures)
- [knowledgearticle_BulkDeleteFailures](#BKMK_knowledgearticle_BulkDeleteFailures)
- [post_BulkDeleteFailures](#BKMK_post_BulkDeleteFailures)
- [channelaccessprofile_BulkDeleteFailures](#BKMK_channelaccessprofile_BulkDeleteFailures)
- [externalparty_BulkDeleteFailures](#BKMK_externalparty_BulkDeleteFailures)
- [profilerule_BulkDeleteFailures](#BKMK_profilerule_BulkDeleteFailures)
- [KnowledgeBaseRecord_BulkDeleteFailures](#BKMK_KnowledgeBaseRecord_BulkDeleteFailures)
- [RelationshipRole_BulkDeleteFailures](#BKMK_RelationshipRole_BulkDeleteFailures)
- [Role_BulkDeleteFailures](#BKMK_Role_BulkDeleteFailures)
- [Subject_BulkDeleteFailures](#BKMK_Subject_BulkDeleteFailures)
- [Fax_BulkDeleteFailures](#BKMK_Fax_BulkDeleteFailures)
- [Privilege_BulkDeleteFailures](#BKMK_Privilege_BulkDeleteFailures)
- [KbArticle_BulkDeleteFailures](#BKMK_KbArticle_BulkDeleteFailures)
- [KbArticleComment_BulkDeleteFailures](#BKMK_KbArticleComment_BulkDeleteFailures)
- [RelationshipRoleMap_BulkDeleteFailures](#BKMK_RelationshipRoleMap_BulkDeleteFailures)
- [AnnualFiscalCalendar_BulkDeleteFailures](#BKMK_AnnualFiscalCalendar_BulkDeleteFailures)
- [UserForm_BulkDeleteFailures](#BKMK_UserForm_BulkDeleteFailures)
- [IsvConfig_BulkDeleteFailures](#BKMK_IsvConfig_BulkDeleteFailures)
- [routingruleitem_BulkDeleteFailures](#BKMK_routingruleitem_BulkDeleteFailures)
- [Queue_BulkDeleteFailures](#BKMK_Queue_BulkDeleteFailures)
- [Contact_BulkDeleteFailures](#BKMK_Contact_BulkDeleteFailures)
- [emailserverprofile_bulkdeletefailures](#BKMK_emailserverprofile_bulkdeletefailures)
- [SavedQuery_BulkDeleteFailures](#BKMK_SavedQuery_BulkDeleteFailures)
- [externalpartyitem_BulkDeleteFailures](#BKMK_externalpartyitem_BulkDeleteFailures)
- [Appointment_BulkDeleteFailures](#BKMK_Appointment_BulkDeleteFailures)
- [Template_BulkDeleteFailures](#BKMK_Template_BulkDeleteFailures)
- [Account_BulkDeleteFailures](#BKMK_Account_BulkDeleteFailures)
- [CustomerRelationship_BulkDeleteFailures](#BKMK_CustomerRelationship_BulkDeleteFailures)
- [SystemUser_BulkDeleteFailures](#BKMK_SystemUser_BulkDeleteFailures)
- [QuarterlyFiscalCalendar_BulkDeleteFailures](#BKMK_QuarterlyFiscalCalendar_BulkDeleteFailures)
- [QueueItem_BulkDeleteFailures](#BKMK_QueueItem_BulkDeleteFailures)
- [AttributeMap_BulkDeleteFailures](#BKMK_AttributeMap_BulkDeleteFailures)
- [DisplayString_BulkDeleteFailures](#BKMK_DisplayString_BulkDeleteFailures)
- [Calendar_BulkDeleteFailures](#BKMK_Calendar_BulkDeleteFailures)
- [Organization_BulkDeleteFailures](#BKMK_Organization_BulkDeleteFailures)
- [BusinessUnit_BulkDeleteFailures](#BKMK_BusinessUnit_BulkDeleteFailures)
- [Annotation_BulkDeleteFailures](#BKMK_Annotation_BulkDeleteFailures)
- [ImportLog_BulkDeleteFailures](#BKMK_ImportLog_BulkDeleteFailures)
- [routingrule_BulkDeleteFailures](#BKMK_routingrule_BulkDeleteFailures)
- [Import_BulkDeleteFailures](#BKMK_Import_BulkDeleteFailures)
- [Letter_BulkDeleteFailures](#BKMK_Letter_BulkDeleteFailures)
- [UserQuery_BulkDeleteFailures](#BKMK_UserQuery_BulkDeleteFailures)
- [PhoneCall_BulkDeleteFailures](#BKMK_PhoneCall_BulkDeleteFailures)
- [Team_BulkDeleteFailures](#BKMK_Team_BulkDeleteFailures)
- [EntityMap_BulkDeleteFailures](#BKMK_EntityMap_BulkDeleteFailures)
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


### <a name="BKMK_Territory_BulkDeleteFailures"></a> Territory_BulkDeleteFailures

See territory Entity [Territory_BulkDeleteFailures](territory.md#BKMK_Territory_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_accountleads_BulkDeleteFailures"></a> accountleads_BulkDeleteFailures

See accountleads Entity [accountleads_BulkDeleteFailures](accountleads.md#BKMK_accountleads_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_contactleads_BulkDeleteFailures"></a> contactleads_BulkDeleteFailures

See contactleads Entity [contactleads_BulkDeleteFailures](contactleads.md#BKMK_contactleads_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_leadaddress_BulkDeleteFailures"></a> leadaddress_BulkDeleteFailures

See leadaddress Entity [leadaddress_BulkDeleteFailures](leadaddress.md#BKMK_leadaddress_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_Lead_BulkDeleteFailures"></a> Lead_BulkDeleteFailures

See lead Entity [Lead_BulkDeleteFailures](lead.md#BKMK_Lead_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_dynamicproperty_BulkDeleteFailures"></a> dynamicproperty_BulkDeleteFailures

See dynamicproperty Entity [dynamicproperty_BulkDeleteFailures](dynamicproperty.md#BKMK_dynamicproperty_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_dynamicpropertyassociation_BulkDeleteFailures"></a> dynamicpropertyassociation_BulkDeleteFailures

See dynamicpropertyassociation Entity [dynamicpropertyassociation_BulkDeleteFailures](dynamicpropertyassociation.md#BKMK_dynamicpropertyassociation_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_dynamicpropertyinstance_BulkDeleteFailures"></a> dynamicpropertyinstance_BulkDeleteFailures

See dynamicpropertyinstance Entity [dynamicpropertyinstance_BulkDeleteFailures](dynamicpropertyinstance.md#BKMK_dynamicpropertyinstance_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_dynamicpropertyoptionsetitem_BulkDeleteFailures"></a> dynamicpropertyoptionsetitem_BulkDeleteFailures

See dynamicpropertyoptionsetitem Entity [dynamicpropertyoptionsetitem_BulkDeleteFailures](dynamicpropertyoptionsetitem.md#BKMK_dynamicpropertyoptionsetitem_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_PriceLevel_BulkDeleteFailures"></a> PriceLevel_BulkDeleteFailures

See pricelevel Entity [PriceLevel_BulkDeleteFailures](pricelevel.md#BKMK_PriceLevel_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_Product_BulkDeleteFailures"></a> Product_BulkDeleteFailures

See product Entity [Product_BulkDeleteFailures](product.md#BKMK_Product_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_productassociation_BulkDeleteFailures"></a> productassociation_BulkDeleteFailures

See productassociation Entity [productassociation_BulkDeleteFailures](productassociation.md#BKMK_productassociation_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_ProductPriceLevel_BulkDeleteFailures"></a> ProductPriceLevel_BulkDeleteFailures

See productpricelevel Entity [ProductPriceLevel_BulkDeleteFailures](productpricelevel.md#BKMK_ProductPriceLevel_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_ProductSubstitute_BulkDeleteFailures"></a> ProductSubstitute_BulkDeleteFailures

See productsubstitute Entity [ProductSubstitute_BulkDeleteFailures](productsubstitute.md#BKMK_ProductSubstitute_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_UoM_BulkDeleteFailures"></a> UoM_BulkDeleteFailures

See uom Entity [UoM_BulkDeleteFailures](uom.md#BKMK_UoM_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_UoMSchedule_BulkDeleteFailures"></a> UoMSchedule_BulkDeleteFailures

See uomschedule Entity [UoMSchedule_BulkDeleteFailures](uomschedule.md#BKMK_UoMSchedule_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_bookableresource_BulkDeleteFailures"></a> bookableresource_BulkDeleteFailures

See bookableresource Entity [bookableresource_BulkDeleteFailures](bookableresource.md#BKMK_bookableresource_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_bookableresourcebooking_BulkDeleteFailures"></a> bookableresourcebooking_BulkDeleteFailures

See bookableresourcebooking Entity [bookableresourcebooking_BulkDeleteFailures](bookableresourcebooking.md#BKMK_bookableresourcebooking_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_bookableresourcebookingexchangesyncidmapping_BulkDeleteFailures"></a> bookableresourcebookingexchangesyncidmapping_BulkDeleteFailures

See bookableresourcebookingexchangesyncidmapping Entity [bookableresourcebookingexchangesyncidmapping_BulkDeleteFailures](bookableresourcebookingexchangesyncidmapping.md#BKMK_bookableresourcebookingexchangesyncidmapping_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_bookableresourcebookingheader_BulkDeleteFailures"></a> bookableresourcebookingheader_BulkDeleteFailures

See bookableresourcebookingheader Entity [bookableresourcebookingheader_BulkDeleteFailures](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_bookableresourcecategory_BulkDeleteFailures"></a> bookableresourcecategory_BulkDeleteFailures

See bookableresourcecategory Entity [bookableresourcecategory_BulkDeleteFailures](bookableresourcecategory.md#BKMK_bookableresourcecategory_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_bookableresourcecategoryassn_BulkDeleteFailures"></a> bookableresourcecategoryassn_BulkDeleteFailures

See bookableresourcecategoryassn Entity [bookableresourcecategoryassn_BulkDeleteFailures](bookableresourcecategoryassn.md#BKMK_bookableresourcecategoryassn_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_bookableresourcecharacteristic_BulkDeleteFailures"></a> bookableresourcecharacteristic_BulkDeleteFailures

See bookableresourcecharacteristic Entity [bookableresourcecharacteristic_BulkDeleteFailures](bookableresourcecharacteristic.md#BKMK_bookableresourcecharacteristic_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_bookableresourcegroup_BulkDeleteFailures"></a> bookableresourcegroup_BulkDeleteFailures

See bookableresourcegroup Entity [bookableresourcegroup_BulkDeleteFailures](bookableresourcegroup.md#BKMK_bookableresourcegroup_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_bookingstatus_BulkDeleteFailures"></a> bookingstatus_BulkDeleteFailures

See bookingstatus Entity [bookingstatus_BulkDeleteFailures](bookingstatus.md#BKMK_bookingstatus_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_characteristic_BulkDeleteFailures"></a> characteristic_BulkDeleteFailures

See characteristic Entity [characteristic_BulkDeleteFailures](characteristic.md#BKMK_characteristic_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_ratingmodel_BulkDeleteFailures"></a> ratingmodel_BulkDeleteFailures

See ratingmodel Entity [ratingmodel_BulkDeleteFailures](ratingmodel.md#BKMK_ratingmodel_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_ratingvalue_BulkDeleteFailures"></a> ratingvalue_BulkDeleteFailures

See ratingvalue Entity [ratingvalue_BulkDeleteFailures](ratingvalue.md#BKMK_ratingvalue_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_BulkOperation_BulkDeleteFailures"></a> BulkOperation_BulkDeleteFailures

See bulkoperation Entity [BulkOperation_BulkDeleteFailures](bulkoperation.md#BKMK_BulkOperation_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_BulkOperationLog_BulkDeleteFailures"></a> BulkOperationLog_BulkDeleteFailures

See bulkoperationlog Entity [BulkOperationLog_BulkDeleteFailures](bulkoperationlog.md#BKMK_BulkOperationLog_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_Campaign_BulkDeleteFailures"></a> Campaign_BulkDeleteFailures

See campaign Entity [Campaign_BulkDeleteFailures](campaign.md#BKMK_Campaign_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_CampaignActivity_BulkDeleteFailures"></a> CampaignActivity_BulkDeleteFailures

See campaignactivity Entity [CampaignActivity_BulkDeleteFailures](campaignactivity.md#BKMK_CampaignActivity_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_campaignactivityitem_BulkDeleteFailures"></a> campaignactivityitem_BulkDeleteFailures

See campaignactivityitem Entity [campaignactivityitem_BulkDeleteFailures](campaignactivityitem.md#BKMK_campaignactivityitem_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_campaignitem_BulkDeleteFailures"></a> campaignitem_BulkDeleteFailures

See campaignitem Entity [campaignitem_BulkDeleteFailures](campaignitem.md#BKMK_campaignitem_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_CampaignResponse_BulkDeleteFailures"></a> CampaignResponse_BulkDeleteFailures

See campaignresponse Entity [CampaignResponse_BulkDeleteFailures](campaignresponse.md#BKMK_CampaignResponse_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_List_BulkDeleteFailures"></a> List_BulkDeleteFailures

See list Entity [List_BulkDeleteFailures](list.md#BKMK_List_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_listmember_BulkDeleteFailures"></a> listmember_BulkDeleteFailures

See listmember Entity [listmember_BulkDeleteFailures](listmember.md#BKMK_listmember_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_commitment_BulkDeleteFailures"></a> commitment_BulkDeleteFailures

See commitment Entity [commitment_BulkDeleteFailures](commitment.md#BKMK_commitment_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_ConstraintBasedGroup_BulkDeleteFailures"></a> ConstraintBasedGroup_BulkDeleteFailures

See constraintbasedgroup Entity [ConstraintBasedGroup_BulkDeleteFailures](constraintbasedgroup.md#BKMK_ConstraintBasedGroup_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_Contract_BulkDeleteFailures"></a> Contract_BulkDeleteFailures

See contract Entity [Contract_BulkDeleteFailures](contract.md#BKMK_Contract_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_ContractDetail_BulkDeleteFailures"></a> ContractDetail_BulkDeleteFailures

See contractdetail Entity [ContractDetail_BulkDeleteFailures](contractdetail.md#BKMK_ContractDetail_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_ContractTemplate_BulkDeleteFailures"></a> ContractTemplate_BulkDeleteFailures

See contracttemplate Entity [ContractTemplate_BulkDeleteFailures](contracttemplate.md#BKMK_ContractTemplate_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_entitlement_BulkDeleteFailures"></a> entitlement_BulkDeleteFailures

See entitlement Entity [entitlement_BulkDeleteFailures](entitlement.md#BKMK_entitlement_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_entitlementchannel_BulkDeleteFailures"></a> entitlementchannel_BulkDeleteFailures

See entitlementchannel Entity [entitlementchannel_BulkDeleteFailures](entitlementchannel.md#BKMK_entitlementchannel_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_entitlementcontacts_BulkDeleteFailures"></a> entitlementcontacts_BulkDeleteFailures

See entitlementcontacts Entity [entitlementcontacts_BulkDeleteFailures](entitlementcontacts.md#BKMK_entitlementcontacts_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_entitlementproducts_BulkDeleteFailures"></a> entitlementproducts_BulkDeleteFailures

See entitlementproducts Entity [entitlementproducts_BulkDeleteFailures](entitlementproducts.md#BKMK_entitlementproducts_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_entitlementtemplate_BulkDeleteFailures"></a> entitlementtemplate_BulkDeleteFailures

See entitlementtemplate Entity [entitlementtemplate_BulkDeleteFailures](entitlementtemplate.md#BKMK_entitlementtemplate_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_entitlementtemplatechannel_BulkDeleteFailures"></a> entitlementtemplatechannel_BulkDeleteFailures

See entitlementtemplatechannel Entity [entitlementtemplatechannel_BulkDeleteFailures](entitlementtemplatechannel.md#BKMK_entitlementtemplatechannel_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_entitlementtemplateproducts_BulkDeleteFailures"></a> entitlementtemplateproducts_BulkDeleteFailures

See entitlementtemplateproducts Entity [entitlementtemplateproducts_BulkDeleteFailures](entitlementtemplateproducts.md#BKMK_entitlementtemplateproducts_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_Equipment_BulkDeleteFailures"></a> Equipment_BulkDeleteFailures

See equipment Entity [Equipment_BulkDeleteFailures](equipment.md#BKMK_Equipment_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_Incident_BulkDeleteFailures"></a> Incident_BulkDeleteFailures

See incident Entity [Incident_BulkDeleteFailures](incident.md#BKMK_Incident_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_incidentknowledgebaserecord_BulkDeleteFailures"></a> incidentknowledgebaserecord_BulkDeleteFailures

See incidentknowledgebaserecord Entity [incidentknowledgebaserecord_BulkDeleteFailures](incidentknowledgebaserecord.md#BKMK_incidentknowledgebaserecord_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_IncidentResolution_BulkDeleteFailures"></a> IncidentResolution_BulkDeleteFailures

See incidentresolution Entity [IncidentResolution_BulkDeleteFailures](incidentresolution.md#BKMK_IncidentResolution_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_knowledgearticleincident_BulkDeleteFailures"></a> knowledgearticleincident_BulkDeleteFailures

See knowledgearticleincident Entity [knowledgearticleincident_BulkDeleteFailures](knowledgearticleincident.md#BKMK_knowledgearticleincident_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_phonetocaseprocess_BulkDeleteFailures"></a> phonetocaseprocess_BulkDeleteFailures

See phonetocaseprocess Entity [phonetocaseprocess_BulkDeleteFailures](phonetocaseprocess.md#BKMK_phonetocaseprocess_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_Resource_BulkDeleteFailures"></a> Resource_BulkDeleteFailures

See resource Entity [Resource_BulkDeleteFailures](resource.md#BKMK_Resource_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_ResourceGroup_BulkDeleteFailures"></a> ResourceGroup_BulkDeleteFailures

See resourcegroup Entity [ResourceGroup_BulkDeleteFailures](resourcegroup.md#BKMK_ResourceGroup_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_ResourceSpec_BulkDeleteFailures"></a> ResourceSpec_BulkDeleteFailures

See resourcespec Entity [ResourceSpec_BulkDeleteFailures](resourcespec.md#BKMK_ResourceSpec_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_Service_BulkDeleteFailures"></a> Service_BulkDeleteFailures

See service Entity [Service_BulkDeleteFailures](service.md#BKMK_Service_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_ServiceAppointment_BulkDeleteFailures"></a> ServiceAppointment_BulkDeleteFailures

See serviceappointment Entity [ServiceAppointment_BulkDeleteFailures](serviceappointment.md#BKMK_ServiceAppointment_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_servicecontractcontacts_BulkDeleteFailures"></a> servicecontractcontacts_BulkDeleteFailures

See servicecontractcontacts Entity [servicecontractcontacts_BulkDeleteFailures](servicecontractcontacts.md#BKMK_servicecontractcontacts_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_topic_BulkDeleteFailures"></a> topic_BulkDeleteFailures

See topic Entity [topic_BulkDeleteFailures](topic.md#BKMK_topic_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_topichistory_BulkDeleteFailures"></a> topichistory_BulkDeleteFailures

See topichistory Entity [topichistory_BulkDeleteFailures](topichistory.md#BKMK_topichistory_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_topicmodel_BulkDeleteFailures"></a> topicmodel_BulkDeleteFailures

See topicmodel Entity [topicmodel_BulkDeleteFailures](topicmodel.md#BKMK_topicmodel_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_topicmodelconfiguration_BulkDeleteFailures"></a> topicmodelconfiguration_BulkDeleteFailures

See topicmodelconfiguration Entity [topicmodelconfiguration_BulkDeleteFailures](topicmodelconfiguration.md#BKMK_topicmodelconfiguration_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_topicmodelexecutionhistory_BulkDeleteFailures"></a> topicmodelexecutionhistory_BulkDeleteFailures

See topicmodelexecutionhistory Entity [topicmodelexecutionhistory_BulkDeleteFailures](topicmodelexecutionhistory.md#BKMK_topicmodelexecutionhistory_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_Site_BulkDeleteFailures"></a> Site_BulkDeleteFailures

See site Entity [Site_BulkDeleteFailures](site.md#BKMK_Site_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_competitorproduct_BulkDeleteFailures"></a> competitorproduct_BulkDeleteFailures

See competitorproduct Entity [competitorproduct_BulkDeleteFailures](competitorproduct.md#BKMK_competitorproduct_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_competitorsalesliterature_BulkDeleteFailures"></a> competitorsalesliterature_BulkDeleteFailures

See competitorsalesliterature Entity [competitorsalesliterature_BulkDeleteFailures](competitorsalesliterature.md#BKMK_competitorsalesliterature_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_contactinvoices_BulkDeleteFailures"></a> contactinvoices_BulkDeleteFailures

See contactinvoices Entity [contactinvoices_BulkDeleteFailures](contactinvoices.md#BKMK_contactinvoices_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_contactorders_BulkDeleteFailures"></a> contactorders_BulkDeleteFailures

See contactorders Entity [contactorders_BulkDeleteFailures](contactorders.md#BKMK_contactorders_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_contactquotes_BulkDeleteFailures"></a> contactquotes_BulkDeleteFailures

See contactquotes Entity [contactquotes_BulkDeleteFailures](contactquotes.md#BKMK_contactquotes_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_CustomerOpportunityRole_BulkDeleteFailures"></a> CustomerOpportunityRole_BulkDeleteFailures

See customeropportunityrole Entity [CustomerOpportunityRole_BulkDeleteFailures](customeropportunityrole.md#BKMK_CustomerOpportunityRole_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_Discount_BulkDeleteFailures"></a> Discount_BulkDeleteFailures

See discount Entity [Discount_BulkDeleteFailures](discount.md#BKMK_Discount_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_DiscountType_BulkDeleteFailures"></a> DiscountType_BulkDeleteFailures

See discounttype Entity [DiscountType_BulkDeleteFailures](discounttype.md#BKMK_DiscountType_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_Invoice_BulkDeleteFailures"></a> Invoice_BulkDeleteFailures

See invoice Entity [Invoice_BulkDeleteFailures](invoice.md#BKMK_Invoice_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_InvoiceDetail_BulkDeleteFailures"></a> InvoiceDetail_BulkDeleteFailures

See invoicedetail Entity [InvoiceDetail_BulkDeleteFailures](invoicedetail.md#BKMK_InvoiceDetail_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_leadcompetitors_BulkDeleteFailures"></a> leadcompetitors_BulkDeleteFailures

See leadcompetitors Entity [leadcompetitors_BulkDeleteFailures](leadcompetitors.md#BKMK_leadcompetitors_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_leadproduct_BulkDeleteFailures"></a> leadproduct_BulkDeleteFailures

See leadproduct Entity [leadproduct_BulkDeleteFailures](leadproduct.md#BKMK_leadproduct_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_leadtoopportunitysalesprocess_BulkDeleteFailures"></a> leadtoopportunitysalesprocess_BulkDeleteFailures

See leadtoopportunitysalesprocess Entity [leadtoopportunitysalesprocess_BulkDeleteFailures](leadtoopportunitysalesprocess.md#BKMK_leadtoopportunitysalesprocess_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_Opportunity_BulkDeleteFailures"></a> Opportunity_BulkDeleteFailures

See opportunity Entity [Opportunity_BulkDeleteFailures](opportunity.md#BKMK_Opportunity_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_OpportunityClose_BulkDeleteFailures"></a> OpportunityClose_BulkDeleteFailures

See opportunityclose Entity [OpportunityClose_BulkDeleteFailures](opportunityclose.md#BKMK_OpportunityClose_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_opportunitycompetitors_BulkDeleteFailures"></a> opportunitycompetitors_BulkDeleteFailures

See opportunitycompetitors Entity [opportunitycompetitors_BulkDeleteFailures](opportunitycompetitors.md#BKMK_opportunitycompetitors_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_OpportunityProduct_BulkDeleteFailures"></a> OpportunityProduct_BulkDeleteFailures

See opportunityproduct Entity [OpportunityProduct_BulkDeleteFailures](opportunityproduct.md#BKMK_OpportunityProduct_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_opportunitysalesprocess_BulkDeleteFailures"></a> opportunitysalesprocess_BulkDeleteFailures

See opportunitysalesprocess Entity [opportunitysalesprocess_BulkDeleteFailures](opportunitysalesprocess.md#BKMK_opportunitysalesprocess_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_OrderClose_BulkDeleteFailures"></a> OrderClose_BulkDeleteFailures

See orderclose Entity [OrderClose_BulkDeleteFailures](orderclose.md#BKMK_OrderClose_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_productsalesliterature_BulkDeleteFailures"></a> productsalesliterature_BulkDeleteFailures

See productsalesliterature Entity [productsalesliterature_BulkDeleteFailures](productsalesliterature.md#BKMK_productsalesliterature_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_Quote_BulkDeleteFailures"></a> Quote_BulkDeleteFailures

See quote Entity [Quote_BulkDeleteFailures](quote.md#BKMK_Quote_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_QuoteClose_BulkDeleteFailures"></a> QuoteClose_BulkDeleteFailures

See quoteclose Entity [QuoteClose_BulkDeleteFailures](quoteclose.md#BKMK_QuoteClose_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_QuoteDetail_BulkDeleteFailures"></a> QuoteDetail_BulkDeleteFailures

See quotedetail Entity [QuoteDetail_BulkDeleteFailures](quotedetail.md#BKMK_QuoteDetail_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_SalesLiterature_BulkDeleteFailures"></a> SalesLiterature_BulkDeleteFailures

See salesliterature Entity [SalesLiterature_BulkDeleteFailures](salesliterature.md#BKMK_SalesLiterature_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_SalesLiteratureItem_BulkDeleteFailures"></a> SalesLiteratureItem_BulkDeleteFailures

See salesliteratureitem Entity [SalesLiteratureItem_BulkDeleteFailures](salesliteratureitem.md#BKMK_SalesLiteratureItem_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_SalesOrder_BulkDeleteFailures"></a> SalesOrder_BulkDeleteFailures

See salesorder Entity [SalesOrder_BulkDeleteFailures](salesorder.md#BKMK_SalesOrder_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_SalesOrderDetail_BulkDeleteFailures"></a> SalesOrderDetail_BulkDeleteFailures

See salesorderdetail Entity [SalesOrderDetail_BulkDeleteFailures](salesorderdetail.md#BKMK_SalesOrderDetail_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_Competitor_BulkDeleteFailures"></a> Competitor_BulkDeleteFailures

See competitor Entity [Competitor_BulkDeleteFailures](competitor.md#BKMK_Competitor_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_postalbum_BulkDeleteFailures"></a> msdyn_postalbum_BulkDeleteFailures

See msdyn_postalbum Entity [msdyn_postalbum_BulkDeleteFailures](msdyn_postalbum.md#BKMK_msdyn_postalbum_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_postconfig_BulkDeleteFailures"></a> msdyn_postconfig_BulkDeleteFailures

See msdyn_postconfig Entity [msdyn_postconfig_BulkDeleteFailures](msdyn_postconfig.md#BKMK_msdyn_postconfig_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_postruleconfig_BulkDeleteFailures"></a> msdyn_postruleconfig_BulkDeleteFailures

See msdyn_postruleconfig Entity [msdyn_postruleconfig_BulkDeleteFailures](msdyn_postruleconfig.md#BKMK_msdyn_postruleconfig_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_wallsavedquery_BulkDeleteFailures"></a> msdyn_wallsavedquery_BulkDeleteFailures

See msdyn_wallsavedquery Entity [msdyn_wallsavedquery_BulkDeleteFailures](msdyn_wallsavedquery.md#BKMK_msdyn_wallsavedquery_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_wallsavedqueryusersettings_BulkDeleteFailures"></a> msdyn_wallsavedqueryusersettings_BulkDeleteFailures

See msdyn_wallsavedqueryusersettings Entity [msdyn_wallsavedqueryusersettings_BulkDeleteFailures](msdyn_wallsavedqueryusersettings.md#BKMK_msdyn_wallsavedqueryusersettings_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_actual_BulkDeleteFailures"></a> msdyn_actual_BulkDeleteFailures

See msdyn_actual Entity [msdyn_actual_BulkDeleteFailures](msdyn_actual.md#BKMK_msdyn_actual_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalert_BulkDeleteFailures"></a> msdyn_bookingalert_BulkDeleteFailures

See msdyn_bookingalert Entity [msdyn_bookingalert_BulkDeleteFailures](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalertstatus_BulkDeleteFailures"></a> msdyn_bookingalertstatus_BulkDeleteFailures

See msdyn_bookingalertstatus Entity [msdyn_bookingalertstatus_BulkDeleteFailures](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingchange_BulkDeleteFailures"></a> msdyn_bookingchange_BulkDeleteFailures

See msdyn_bookingchange Entity [msdyn_bookingchange_BulkDeleteFailures](msdyn_bookingchange.md#BKMK_msdyn_bookingchange_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingrule_BulkDeleteFailures"></a> msdyn_bookingrule_BulkDeleteFailures

See msdyn_bookingrule Entity [msdyn_bookingrule_BulkDeleteFailures](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingsetupmetadata_BulkDeleteFailures"></a> msdyn_bookingsetupmetadata_BulkDeleteFailures

See msdyn_bookingsetupmetadata Entity [msdyn_bookingsetupmetadata_BulkDeleteFailures](msdyn_bookingsetupmetadata.md#BKMK_msdyn_bookingsetupmetadata_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_clientextension_BulkDeleteFailures"></a> msdyn_clientextension_BulkDeleteFailures

See msdyn_clientextension Entity [msdyn_clientextension_BulkDeleteFailures](msdyn_clientextension.md#BKMK_msdyn_clientextension_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_configuration_BulkDeleteFailures"></a> msdyn_configuration_BulkDeleteFailures

See msdyn_configuration Entity [msdyn_configuration_BulkDeleteFailures](msdyn_configuration.md#BKMK_msdyn_configuration_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_organizationalunit_BulkDeleteFailures"></a> msdyn_organizationalunit_BulkDeleteFailures

See msdyn_organizationalunit Entity [msdyn_organizationalunit_BulkDeleteFailures](msdyn_organizationalunit.md#BKMK_msdyn_organizationalunit_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_priority_BulkDeleteFailures"></a> msdyn_priority_BulkDeleteFailures

See msdyn_priority Entity [msdyn_priority_BulkDeleteFailures](msdyn_priority.md#BKMK_msdyn_priority_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementcharacteristic_BulkDeleteFailures"></a> msdyn_requirementcharacteristic_BulkDeleteFailures

See msdyn_requirementcharacteristic Entity [msdyn_requirementcharacteristic_BulkDeleteFailures](msdyn_requirementcharacteristic.md#BKMK_msdyn_requirementcharacteristic_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementorganizationunit_BulkDeleteFailures"></a> msdyn_requirementorganizationunit_BulkDeleteFailures

See msdyn_requirementorganizationunit Entity [msdyn_requirementorganizationunit_BulkDeleteFailures](msdyn_requirementorganizationunit.md#BKMK_msdyn_requirementorganizationunit_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementresourcecategory_BulkDeleteFailures"></a> msdyn_requirementresourcecategory_BulkDeleteFailures

See msdyn_requirementresourcecategory Entity [msdyn_requirementresourcecategory_BulkDeleteFailures](msdyn_requirementresourcecategory.md#BKMK_msdyn_requirementresourcecategory_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementresourcepreference_BulkDeleteFailures"></a> msdyn_requirementresourcepreference_BulkDeleteFailures

See msdyn_requirementresourcepreference Entity [msdyn_requirementresourcepreference_BulkDeleteFailures](msdyn_requirementresourcepreference.md#BKMK_msdyn_requirementresourcepreference_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementstatus_BulkDeleteFailures"></a> msdyn_requirementstatus_BulkDeleteFailures

See msdyn_requirementstatus Entity [msdyn_requirementstatus_BulkDeleteFailures](msdyn_requirementstatus.md#BKMK_msdyn_requirementstatus_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcerequirement_BulkDeleteFailures"></a> msdyn_resourcerequirement_BulkDeleteFailures

See msdyn_resourcerequirement Entity [msdyn_resourcerequirement_BulkDeleteFailures](msdyn_resourcerequirement.md#BKMK_msdyn_resourcerequirement_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcerequirementdetail_BulkDeleteFailures"></a> msdyn_resourcerequirementdetail_BulkDeleteFailures

See msdyn_resourcerequirementdetail Entity [msdyn_resourcerequirementdetail_BulkDeleteFailures](msdyn_resourcerequirementdetail.md#BKMK_msdyn_resourcerequirementdetail_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_resourceterritory_BulkDeleteFailures"></a> msdyn_resourceterritory_BulkDeleteFailures

See msdyn_resourceterritory Entity [msdyn_resourceterritory_BulkDeleteFailures](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_scheduleboardsetting_BulkDeleteFailures"></a> msdyn_scheduleboardsetting_BulkDeleteFailures

See msdyn_scheduleboardsetting Entity [msdyn_scheduleboardsetting_BulkDeleteFailures](msdyn_scheduleboardsetting.md#BKMK_msdyn_scheduleboardsetting_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_schedulingparameter_BulkDeleteFailures"></a> msdyn_schedulingparameter_BulkDeleteFailures

See msdyn_schedulingparameter Entity [msdyn_schedulingparameter_BulkDeleteFailures](msdyn_schedulingparameter.md#BKMK_msdyn_schedulingparameter_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_systemuserschedulersetting_BulkDeleteFailures"></a> msdyn_systemuserschedulersetting_BulkDeleteFailures

See msdyn_systemuserschedulersetting Entity [msdyn_systemuserschedulersetting_BulkDeleteFailures](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroup_BulkDeleteFailures"></a> msdyn_timegroup_BulkDeleteFailures

See msdyn_timegroup Entity [msdyn_timegroup_BulkDeleteFailures](msdyn_timegroup.md#BKMK_msdyn_timegroup_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroupdetail_BulkDeleteFailures"></a> msdyn_timegroupdetail_BulkDeleteFailures

See msdyn_timegroupdetail Entity [msdyn_timegroupdetail_BulkDeleteFailures](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_transactionorigin_BulkDeleteFailures"></a> msdyn_transactionorigin_BulkDeleteFailures

See msdyn_transactionorigin Entity [msdyn_transactionorigin_BulkDeleteFailures](msdyn_transactionorigin.md#BKMK_msdyn_transactionorigin_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_workhourtemplate_BulkDeleteFailures"></a> msdyn_workhourtemplate_BulkDeleteFailures

See msdyn_workhourtemplate Entity [msdyn_workhourtemplate_BulkDeleteFailures](msdyn_workhourtemplate.md#BKMK_msdyn_workhourtemplate_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_accountpricelist_BulkDeleteFailures"></a> msdyn_accountpricelist_BulkDeleteFailures

See msdyn_accountpricelist Entity [msdyn_accountpricelist_BulkDeleteFailures](msdyn_accountpricelist.md#BKMK_msdyn_accountpricelist_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_approval_BulkDeleteFailures"></a> msdyn_approval_BulkDeleteFailures

See msdyn_approval Entity [msdyn_approval_BulkDeleteFailures](msdyn_approval.md#BKMK_msdyn_approval_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_batchjob_BulkDeleteFailures"></a> msdyn_batchjob_BulkDeleteFailures

See msdyn_batchjob Entity [msdyn_batchjob_BulkDeleteFailures](msdyn_batchjob.md#BKMK_msdyn_batchjob_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_665e73aa18c247d886bfc50499c73b82_BulkDeleteFailures"></a> msdyn_bpf_665e73aa18c247d886bfc50499c73b82_BulkDeleteFailures

See msdyn_bpf_665e73aa18c247d886bfc50499c73b82 Entity [msdyn_bpf_665e73aa18c247d886bfc50499c73b82_BulkDeleteFailures](msdyn_bpf_665e73aa18c247d886bfc50499c73b82.md#BKMK_msdyn_bpf_665e73aa18c247d886bfc50499c73b82_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_BulkDeleteFailures"></a> msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_BulkDeleteFailures

See msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d Entity [msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_BulkDeleteFailures](msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d.md#BKMK_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_characteristicreqforteammember_BulkDeleteFailures"></a> msdyn_characteristicreqforteammember_BulkDeleteFailures

See msdyn_characteristicreqforteammember Entity [msdyn_characteristicreqforteammember_BulkDeleteFailures](msdyn_characteristicreqforteammember.md#BKMK_msdyn_characteristicreqforteammember_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_contactpricelist_BulkDeleteFailures"></a> msdyn_contactpricelist_BulkDeleteFailures

See msdyn_contactpricelist Entity [msdyn_contactpricelist_BulkDeleteFailures](msdyn_contactpricelist.md#BKMK_msdyn_contactpricelist_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_contractlineinvoiceschedule_BulkDeleteFailures"></a> msdyn_contractlineinvoiceschedule_BulkDeleteFailures

See msdyn_contractlineinvoiceschedule Entity [msdyn_contractlineinvoiceschedule_BulkDeleteFailures](msdyn_contractlineinvoiceschedule.md#BKMK_msdyn_contractlineinvoiceschedule_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_contractlinescheduleofvalue_BulkDeleteFailures"></a> msdyn_contractlinescheduleofvalue_BulkDeleteFailures

See msdyn_contractlinescheduleofvalue Entity [msdyn_contractlinescheduleofvalue_BulkDeleteFailures](msdyn_contractlinescheduleofvalue.md#BKMK_msdyn_contractlinescheduleofvalue_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_dataexport_BulkDeleteFailures"></a> msdyn_dataexport_BulkDeleteFailures

See msdyn_dataexport Entity [msdyn_dataexport_BulkDeleteFailures](msdyn_dataexport.md#BKMK_msdyn_dataexport_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_delegation_BulkDeleteFailures"></a> msdyn_delegation_BulkDeleteFailures

See msdyn_delegation Entity [msdyn_delegation_BulkDeleteFailures](msdyn_delegation.md#BKMK_msdyn_delegation_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_estimate_BulkDeleteFailures"></a> msdyn_estimate_BulkDeleteFailures

See msdyn_estimate Entity [msdyn_estimate_BulkDeleteFailures](msdyn_estimate.md#BKMK_msdyn_estimate_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_estimateline_BulkDeleteFailures"></a> msdyn_estimateline_BulkDeleteFailures

See msdyn_estimateline Entity [msdyn_estimateline_BulkDeleteFailures](msdyn_estimateline.md#BKMK_msdyn_estimateline_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_expense_BulkDeleteFailures"></a> msdyn_expense_BulkDeleteFailures

See msdyn_expense Entity [msdyn_expense_BulkDeleteFailures](msdyn_expense.md#BKMK_msdyn_expense_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_expensecategory_BulkDeleteFailures"></a> msdyn_expensecategory_BulkDeleteFailures

See msdyn_expensecategory Entity [msdyn_expensecategory_BulkDeleteFailures](msdyn_expensecategory.md#BKMK_msdyn_expensecategory_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_expensereceipt_BulkDeleteFailures"></a> msdyn_expensereceipt_BulkDeleteFailures

See msdyn_expensereceipt Entity [msdyn_expensereceipt_BulkDeleteFailures](msdyn_expensereceipt.md#BKMK_msdyn_expensereceipt_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_fact_BulkDeleteFailures"></a> msdyn_fact_BulkDeleteFailures

See msdyn_fact Entity [msdyn_fact_BulkDeleteFailures](msdyn_fact.md#BKMK_msdyn_fact_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldcomputation_BulkDeleteFailures"></a> msdyn_fieldcomputation_BulkDeleteFailures

See msdyn_fieldcomputation Entity [msdyn_fieldcomputation_BulkDeleteFailures](msdyn_fieldcomputation.md#BKMK_msdyn_fieldcomputation_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_findworkevent_BulkDeleteFailures"></a> msdyn_findworkevent_BulkDeleteFailures

See msdyn_findworkevent Entity [msdyn_findworkevent_BulkDeleteFailures](msdyn_findworkevent.md#BKMK_msdyn_findworkevent_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_integrationjob_BulkDeleteFailures"></a> msdyn_integrationjob_BulkDeleteFailures

See msdyn_integrationjob Entity [msdyn_integrationjob_BulkDeleteFailures](msdyn_integrationjob.md#BKMK_msdyn_integrationjob_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_integrationjobdetail_BulkDeleteFailures"></a> msdyn_integrationjobdetail_BulkDeleteFailures

See msdyn_integrationjobdetail Entity [msdyn_integrationjobdetail_BulkDeleteFailures](msdyn_integrationjobdetail.md#BKMK_msdyn_integrationjobdetail_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_invoicefrequency_BulkDeleteFailures"></a> msdyn_invoicefrequency_BulkDeleteFailures

See msdyn_invoicefrequency Entity [msdyn_invoicefrequency_BulkDeleteFailures](msdyn_invoicefrequency.md#BKMK_msdyn_invoicefrequency_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_invoicefrequencydetail_BulkDeleteFailures"></a> msdyn_invoicefrequencydetail_BulkDeleteFailures

See msdyn_invoicefrequencydetail Entity [msdyn_invoicefrequencydetail_BulkDeleteFailures](msdyn_invoicefrequencydetail.md#BKMK_msdyn_invoicefrequencydetail_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_invoicelinetransaction_BulkDeleteFailures"></a> msdyn_invoicelinetransaction_BulkDeleteFailures

See msdyn_invoicelinetransaction Entity [msdyn_invoicelinetransaction_BulkDeleteFailures](msdyn_invoicelinetransaction.md#BKMK_msdyn_invoicelinetransaction_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_journal_BulkDeleteFailures"></a> msdyn_journal_BulkDeleteFailures

See msdyn_journal Entity [msdyn_journal_BulkDeleteFailures](msdyn_journal.md#BKMK_msdyn_journal_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_journalline_BulkDeleteFailures"></a> msdyn_journalline_BulkDeleteFailures

See msdyn_journalline Entity [msdyn_journalline_BulkDeleteFailures](msdyn_journalline.md#BKMK_msdyn_journalline_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_mlresultcache_BulkDeleteFailures"></a> msdyn_mlresultcache_BulkDeleteFailures

See msdyn_mlresultcache Entity [msdyn_mlresultcache_BulkDeleteFailures](msdyn_mlresultcache.md#BKMK_msdyn_mlresultcache_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitylineresourcecategory_BulkDeleteFailures"></a> msdyn_opportunitylineresourcecategory_BulkDeleteFailures

See msdyn_opportunitylineresourcecategory Entity [msdyn_opportunitylineresourcecategory_BulkDeleteFailures](msdyn_opportunitylineresourcecategory.md#BKMK_msdyn_opportunitylineresourcecategory_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitylinetransaction_BulkDeleteFailures"></a> msdyn_opportunitylinetransaction_BulkDeleteFailures

See msdyn_opportunitylinetransaction Entity [msdyn_opportunitylinetransaction_BulkDeleteFailures](msdyn_opportunitylinetransaction.md#BKMK_msdyn_opportunitylinetransaction_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitylinetransactioncategory_BulkDeleteFailures"></a> msdyn_opportunitylinetransactioncategory_BulkDeleteFailures

See msdyn_opportunitylinetransactioncategory Entity [msdyn_opportunitylinetransactioncategory_BulkDeleteFailures](msdyn_opportunitylinetransactioncategory.md#BKMK_msdyn_opportunitylinetransactioncategory_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitylinetransactionclassificatio_BulkDeleteFailures"></a> msdyn_opportunitylinetransactionclassificatio_BulkDeleteFailures

See msdyn_opportunitylinetransactionclassificatio Entity [msdyn_opportunitylinetransactionclassificatio_BulkDeleteFailures](msdyn_opportunitylinetransactionclassificatio.md#BKMK_msdyn_opportunitylinetransactionclassificatio_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitypricelist_BulkDeleteFailures"></a> msdyn_opportunitypricelist_BulkDeleteFailures

See msdyn_opportunitypricelist Entity [msdyn_opportunitypricelist_BulkDeleteFailures](msdyn_opportunitypricelist.md#BKMK_msdyn_opportunitypricelist_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_orderlineresourcecategory_BulkDeleteFailures"></a> msdyn_orderlineresourcecategory_BulkDeleteFailures

See msdyn_orderlineresourcecategory Entity [msdyn_orderlineresourcecategory_BulkDeleteFailures](msdyn_orderlineresourcecategory.md#BKMK_msdyn_orderlineresourcecategory_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_orderlinetransaction_BulkDeleteFailures"></a> msdyn_orderlinetransaction_BulkDeleteFailures

See msdyn_orderlinetransaction Entity [msdyn_orderlinetransaction_BulkDeleteFailures](msdyn_orderlinetransaction.md#BKMK_msdyn_orderlinetransaction_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_orderlinetransactioncategory_BulkDeleteFailures"></a> msdyn_orderlinetransactioncategory_BulkDeleteFailures

See msdyn_orderlinetransactioncategory Entity [msdyn_orderlinetransactioncategory_BulkDeleteFailures](msdyn_orderlinetransactioncategory.md#BKMK_msdyn_orderlinetransactioncategory_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_orderlinetransactionclassification_BulkDeleteFailures"></a> msdyn_orderlinetransactionclassification_BulkDeleteFailures

See msdyn_orderlinetransactionclassification Entity [msdyn_orderlinetransactionclassification_BulkDeleteFailures](msdyn_orderlinetransactionclassification.md#BKMK_msdyn_orderlinetransactionclassification_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_orderpricelist_BulkDeleteFailures"></a> msdyn_orderpricelist_BulkDeleteFailures

See msdyn_orderpricelist Entity [msdyn_orderpricelist_BulkDeleteFailures](msdyn_orderpricelist.md#BKMK_msdyn_orderpricelist_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_processnotes_BulkDeleteFailures"></a> msdyn_processnotes_BulkDeleteFailures

See msdyn_processnotes Entity [msdyn_processnotes_BulkDeleteFailures](msdyn_processnotes.md#BKMK_msdyn_processnotes_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_project_BulkDeleteFailures"></a> msdyn_project_BulkDeleteFailures

See msdyn_project Entity [msdyn_project_BulkDeleteFailures](msdyn_project.md#BKMK_msdyn_project_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_projectapproval_BulkDeleteFailures"></a> msdyn_projectapproval_BulkDeleteFailures

See msdyn_projectapproval Entity [msdyn_projectapproval_BulkDeleteFailures](msdyn_projectapproval.md#BKMK_msdyn_projectapproval_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_projectparameter_BulkDeleteFailures"></a> msdyn_projectparameter_BulkDeleteFailures

See msdyn_projectparameter Entity [msdyn_projectparameter_BulkDeleteFailures](msdyn_projectparameter.md#BKMK_msdyn_projectparameter_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_projectparameterpricelist_BulkDeleteFailures"></a> msdyn_projectparameterpricelist_BulkDeleteFailures

See msdyn_projectparameterpricelist Entity [msdyn_projectparameterpricelist_BulkDeleteFailures](msdyn_projectparameterpricelist.md#BKMK_msdyn_projectparameterpricelist_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_projectpricelist_BulkDeleteFailures"></a> msdyn_projectpricelist_BulkDeleteFailures

See msdyn_projectpricelist Entity [msdyn_projectpricelist_BulkDeleteFailures](msdyn_projectpricelist.md#BKMK_msdyn_projectpricelist_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_projecttask_BulkDeleteFailures"></a> msdyn_projecttask_BulkDeleteFailures

See msdyn_projecttask Entity [msdyn_projecttask_BulkDeleteFailures](msdyn_projecttask.md#BKMK_msdyn_projecttask_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_projecttaskdependency_BulkDeleteFailures"></a> msdyn_projecttaskdependency_BulkDeleteFailures

See msdyn_projecttaskdependency Entity [msdyn_projecttaskdependency_BulkDeleteFailures](msdyn_projecttaskdependency.md#BKMK_msdyn_projecttaskdependency_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_projecttaskstatususer_BulkDeleteFailures"></a> msdyn_projecttaskstatususer_BulkDeleteFailures

See msdyn_projecttaskstatususer Entity [msdyn_projecttaskstatususer_BulkDeleteFailures](msdyn_projecttaskstatususer.md#BKMK_msdyn_projecttaskstatususer_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_projectteam_BulkDeleteFailures"></a> msdyn_projectteam_BulkDeleteFailures

See msdyn_projectteam Entity [msdyn_projectteam_BulkDeleteFailures](msdyn_projectteam.md#BKMK_msdyn_projectteam_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_projectteammembersignup_BulkDeleteFailures"></a> msdyn_projectteammembersignup_BulkDeleteFailures

See msdyn_projectteammembersignup Entity [msdyn_projectteammembersignup_BulkDeleteFailures](msdyn_projectteammembersignup.md#BKMK_msdyn_projectteammembersignup_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_projecttransactioncategory_BulkDeleteFailures"></a> msdyn_projecttransactioncategory_BulkDeleteFailures

See msdyn_projecttransactioncategory Entity [msdyn_projecttransactioncategory_BulkDeleteFailures](msdyn_projecttransactioncategory.md#BKMK_msdyn_projecttransactioncategory_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelineanalyticsbreakdown_BulkDeleteFailures"></a> msdyn_quotelineanalyticsbreakdown_BulkDeleteFailures

See msdyn_quotelineanalyticsbreakdown Entity [msdyn_quotelineanalyticsbreakdown_BulkDeleteFailures](msdyn_quotelineanalyticsbreakdown.md#BKMK_msdyn_quotelineanalyticsbreakdown_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelineinvoiceschedule_BulkDeleteFailures"></a> msdyn_quotelineinvoiceschedule_BulkDeleteFailures

See msdyn_quotelineinvoiceschedule Entity [msdyn_quotelineinvoiceschedule_BulkDeleteFailures](msdyn_quotelineinvoiceschedule.md#BKMK_msdyn_quotelineinvoiceschedule_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelineresourcecategory_BulkDeleteFailures"></a> msdyn_quotelineresourcecategory_BulkDeleteFailures

See msdyn_quotelineresourcecategory Entity [msdyn_quotelineresourcecategory_BulkDeleteFailures](msdyn_quotelineresourcecategory.md#BKMK_msdyn_quotelineresourcecategory_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelinescheduleofvalue_BulkDeleteFailures"></a> msdyn_quotelinescheduleofvalue_BulkDeleteFailures

See msdyn_quotelinescheduleofvalue Entity [msdyn_quotelinescheduleofvalue_BulkDeleteFailures](msdyn_quotelinescheduleofvalue.md#BKMK_msdyn_quotelinescheduleofvalue_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelinetransaction_BulkDeleteFailures"></a> msdyn_quotelinetransaction_BulkDeleteFailures

See msdyn_quotelinetransaction Entity [msdyn_quotelinetransaction_BulkDeleteFailures](msdyn_quotelinetransaction.md#BKMK_msdyn_quotelinetransaction_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelinetransactioncategory_BulkDeleteFailures"></a> msdyn_quotelinetransactioncategory_BulkDeleteFailures

See msdyn_quotelinetransactioncategory Entity [msdyn_quotelinetransactioncategory_BulkDeleteFailures](msdyn_quotelinetransactioncategory.md#BKMK_msdyn_quotelinetransactioncategory_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelinetransactionclassification_BulkDeleteFailures"></a> msdyn_quotelinetransactionclassification_BulkDeleteFailures

See msdyn_quotelinetransactionclassification Entity [msdyn_quotelinetransactionclassification_BulkDeleteFailures](msdyn_quotelinetransactionclassification.md#BKMK_msdyn_quotelinetransactionclassification_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_quotepricelist_BulkDeleteFailures"></a> msdyn_quotepricelist_BulkDeleteFailures

See msdyn_quotepricelist Entity [msdyn_quotepricelist_BulkDeleteFailures](msdyn_quotepricelist.md#BKMK_msdyn_quotepricelist_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_resourceassignment_BulkDeleteFailures"></a> msdyn_resourceassignment_BulkDeleteFailures

See msdyn_resourceassignment Entity [msdyn_resourceassignment_BulkDeleteFailures](msdyn_resourceassignment.md#BKMK_msdyn_resourceassignment_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_resourceassignmentdetail_BulkDeleteFailures"></a> msdyn_resourceassignmentdetail_BulkDeleteFailures

See msdyn_resourceassignmentdetail Entity [msdyn_resourceassignmentdetail_BulkDeleteFailures](msdyn_resourceassignmentdetail.md#BKMK_msdyn_resourceassignmentdetail_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcecategorypricelevel_BulkDeleteFailures"></a> msdyn_resourcecategorypricelevel_BulkDeleteFailures

See msdyn_resourcecategorypricelevel Entity [msdyn_resourcecategorypricelevel_BulkDeleteFailures](msdyn_resourcecategorypricelevel.md#BKMK_msdyn_resourcecategorypricelevel_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcerequest_BulkDeleteFailures"></a> msdyn_resourcerequest_BulkDeleteFailures

See msdyn_resourcerequest Entity [msdyn_resourcerequest_BulkDeleteFailures](msdyn_resourcerequest.md#BKMK_msdyn_resourcerequest_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_rolecompetencyrequirement_BulkDeleteFailures"></a> msdyn_rolecompetencyrequirement_BulkDeleteFailures

See msdyn_rolecompetencyrequirement Entity [msdyn_rolecompetencyrequirement_BulkDeleteFailures](msdyn_rolecompetencyrequirement.md#BKMK_msdyn_rolecompetencyrequirement_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_roleutilization_BulkDeleteFailures"></a> msdyn_roleutilization_BulkDeleteFailures

See msdyn_roleutilization Entity [msdyn_roleutilization_BulkDeleteFailures](msdyn_roleutilization.md#BKMK_msdyn_roleutilization_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_timeentry_BulkDeleteFailures"></a> msdyn_timeentry_BulkDeleteFailures

See msdyn_timeentry Entity [msdyn_timeentry_BulkDeleteFailures](msdyn_timeentry.md#BKMK_msdyn_timeentry_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_timeoffcalendar_BulkDeleteFailures"></a> msdyn_timeoffcalendar_BulkDeleteFailures

See msdyn_timeoffcalendar Entity [msdyn_timeoffcalendar_BulkDeleteFailures](msdyn_timeoffcalendar.md#BKMK_msdyn_timeoffcalendar_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_transactioncategory_BulkDeleteFailures"></a> msdyn_transactioncategory_BulkDeleteFailures

See msdyn_transactioncategory Entity [msdyn_transactioncategory_BulkDeleteFailures](msdyn_transactioncategory.md#BKMK_msdyn_transactioncategory_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_transactioncategoryclassification_BulkDeleteFailures"></a> msdyn_transactioncategoryclassification_BulkDeleteFailures

See msdyn_transactioncategoryclassification Entity [msdyn_transactioncategoryclassification_BulkDeleteFailures](msdyn_transactioncategoryclassification.md#BKMK_msdyn_transactioncategoryclassification_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_transactioncategoryhierarchyelement_BulkDeleteFailures"></a> msdyn_transactioncategoryhierarchyelement_BulkDeleteFailures

See msdyn_transactioncategoryhierarchyelement Entity [msdyn_transactioncategoryhierarchyelement_BulkDeleteFailures](msdyn_transactioncategoryhierarchyelement.md#BKMK_msdyn_transactioncategoryhierarchyelement_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_transactioncategorypricelevel_BulkDeleteFailures"></a> msdyn_transactioncategorypricelevel_BulkDeleteFailures

See msdyn_transactioncategorypricelevel Entity [msdyn_transactioncategorypricelevel_BulkDeleteFailures](msdyn_transactioncategorypricelevel.md#BKMK_msdyn_transactioncategorypricelevel_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_transactionconnection_BulkDeleteFailures"></a> msdyn_transactionconnection_BulkDeleteFailures

See msdyn_transactionconnection Entity [msdyn_transactionconnection_BulkDeleteFailures](msdyn_transactionconnection.md#BKMK_msdyn_transactionconnection_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_transactiontype_BulkDeleteFailures"></a> msdyn_transactiontype_BulkDeleteFailures

See msdyn_transactiontype Entity [msdyn_transactiontype_BulkDeleteFailures](msdyn_transactiontype.md#BKMK_msdyn_transactiontype_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_userworkhistory_BulkDeleteFailures"></a> msdyn_userworkhistory_BulkDeleteFailures

See msdyn_userworkhistory Entity [msdyn_userworkhistory_BulkDeleteFailures](msdyn_userworkhistory.md#BKMK_msdyn_userworkhistory_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_agreement_BulkDeleteFailures"></a> msdyn_agreement_BulkDeleteFailures

See msdyn_agreement Entity [msdyn_agreement_BulkDeleteFailures](msdyn_agreement.md#BKMK_msdyn_agreement_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingdate_BulkDeleteFailures"></a> msdyn_agreementbookingdate_BulkDeleteFailures

See msdyn_agreementbookingdate Entity [msdyn_agreementbookingdate_BulkDeleteFailures](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingincident_BulkDeleteFailures"></a> msdyn_agreementbookingincident_BulkDeleteFailures

See msdyn_agreementbookingincident Entity [msdyn_agreementbookingincident_BulkDeleteFailures](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingproduct_BulkDeleteFailures"></a> msdyn_agreementbookingproduct_BulkDeleteFailures

See msdyn_agreementbookingproduct Entity [msdyn_agreementbookingproduct_BulkDeleteFailures](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservice_BulkDeleteFailures"></a> msdyn_agreementbookingservice_BulkDeleteFailures

See msdyn_agreementbookingservice Entity [msdyn_agreementbookingservice_BulkDeleteFailures](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservicetask_BulkDeleteFailures"></a> msdyn_agreementbookingservicetask_BulkDeleteFailures

See msdyn_agreementbookingservicetask Entity [msdyn_agreementbookingservicetask_BulkDeleteFailures](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingsetup_BulkDeleteFailures"></a> msdyn_agreementbookingsetup_BulkDeleteFailures

See msdyn_agreementbookingsetup Entity [msdyn_agreementbookingsetup_BulkDeleteFailures](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicedate_BulkDeleteFailures"></a> msdyn_agreementinvoicedate_BulkDeleteFailures

See msdyn_agreementinvoicedate Entity [msdyn_agreementinvoicedate_BulkDeleteFailures](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoiceproduct_BulkDeleteFailures"></a> msdyn_agreementinvoiceproduct_BulkDeleteFailures

See msdyn_agreementinvoiceproduct Entity [msdyn_agreementinvoiceproduct_BulkDeleteFailures](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicesetup_BulkDeleteFailures"></a> msdyn_agreementinvoicesetup_BulkDeleteFailures

See msdyn_agreementinvoicesetup Entity [msdyn_agreementinvoicesetup_BulkDeleteFailures](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementsubstatus_BulkDeleteFailures"></a> msdyn_agreementsubstatus_BulkDeleteFailures

See msdyn_agreementsubstatus Entity [msdyn_agreementsubstatus_BulkDeleteFailures](msdyn_agreementsubstatus.md#BKMK_msdyn_agreementsubstatus_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingjournal_BulkDeleteFailures"></a> msdyn_bookingjournal_BulkDeleteFailures

See msdyn_bookingjournal Entity [msdyn_bookingjournal_BulkDeleteFailures](msdyn_bookingjournal.md#BKMK_msdyn_bookingjournal_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingtimestamp_BulkDeleteFailures"></a> msdyn_bookingtimestamp_BulkDeleteFailures

See msdyn_bookingtimestamp Entity [msdyn_bookingtimestamp_BulkDeleteFailures](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_BulkDeleteFailures"></a> msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_BulkDeleteFailures

See msdyn_bpf_2c5fe86acc8b414b8322ae571000c799 Entity [msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_BulkDeleteFailures](msdyn_bpf_2c5fe86acc8b414b8322ae571000c799.md#BKMK_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_989e9b1857e24af18787d5143b67523b_BulkDeleteFailures"></a> msdyn_bpf_989e9b1857e24af18787d5143b67523b_BulkDeleteFailures

See msdyn_bpf_989e9b1857e24af18787d5143b67523b Entity [msdyn_bpf_989e9b1857e24af18787d5143b67523b_BulkDeleteFailures](msdyn_bpf_989e9b1857e24af18787d5143b67523b.md#BKMK_msdyn_bpf_989e9b1857e24af18787d5143b67523b_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_BulkDeleteFailures"></a> msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_BulkDeleteFailures

See msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3 Entity [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_BulkDeleteFailures](msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3.md#BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_BulkDeleteFailures"></a> msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_BulkDeleteFailures

See msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39 Entity [msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_BulkDeleteFailures](msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39.md#BKMK_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_customerasset_BulkDeleteFailures"></a> msdyn_customerasset_BulkDeleteFailures

See msdyn_customerasset Entity [msdyn_customerasset_BulkDeleteFailures](msdyn_customerasset.md#BKMK_msdyn_customerasset_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldservicepricelistitem_BulkDeleteFailures"></a> msdyn_fieldservicepricelistitem_BulkDeleteFailures

See msdyn_fieldservicepricelistitem Entity [msdyn_fieldservicepricelistitem_BulkDeleteFailures](msdyn_fieldservicepricelistitem.md#BKMK_msdyn_fieldservicepricelistitem_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldservicesetting_BulkDeleteFailures"></a> msdyn_fieldservicesetting_BulkDeleteFailures

See msdyn_fieldservicesetting Entity [msdyn_fieldservicesetting_BulkDeleteFailures](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldservicesystemjob_BulkDeleteFailures"></a> msdyn_fieldservicesystemjob_BulkDeleteFailures

See msdyn_fieldservicesystemjob Entity [msdyn_fieldservicesystemjob_BulkDeleteFailures](msdyn_fieldservicesystemjob.md#BKMK_msdyn_fieldservicesystemjob_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttype_BulkDeleteFailures"></a> msdyn_incidenttype_BulkDeleteFailures

See msdyn_incidenttype Entity [msdyn_incidenttype_BulkDeleteFailures](msdyn_incidenttype.md#BKMK_msdyn_incidenttype_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypecharacteristic_BulkDeleteFailures"></a> msdyn_incidenttypecharacteristic_BulkDeleteFailures

See msdyn_incidenttypecharacteristic Entity [msdyn_incidenttypecharacteristic_BulkDeleteFailures](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeproduct_BulkDeleteFailures"></a> msdyn_incidenttypeproduct_BulkDeleteFailures

See msdyn_incidenttypeproduct Entity [msdyn_incidenttypeproduct_BulkDeleteFailures](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeservice_BulkDeleteFailures"></a> msdyn_incidenttypeservice_BulkDeleteFailures

See msdyn_incidenttypeservice Entity [msdyn_incidenttypeservice_BulkDeleteFailures](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeservicetask_BulkDeleteFailures"></a> msdyn_incidenttypeservicetask_BulkDeleteFailures

See msdyn_incidenttypeservicetask Entity [msdyn_incidenttypeservicetask_BulkDeleteFailures](msdyn_incidenttypeservicetask.md#BKMK_msdyn_incidenttypeservicetask_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustment_BulkDeleteFailures"></a> msdyn_inventoryadjustment_BulkDeleteFailures

See msdyn_inventoryadjustment Entity [msdyn_inventoryadjustment_BulkDeleteFailures](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustmentproduct_BulkDeleteFailures"></a> msdyn_inventoryadjustmentproduct_BulkDeleteFailures

See msdyn_inventoryadjustmentproduct Entity [msdyn_inventoryadjustmentproduct_BulkDeleteFailures](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryjournal_BulkDeleteFailures"></a> msdyn_inventoryjournal_BulkDeleteFailures

See msdyn_inventoryjournal Entity [msdyn_inventoryjournal_BulkDeleteFailures](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_inventorytransfer_BulkDeleteFailures"></a> msdyn_inventorytransfer_BulkDeleteFailures

See msdyn_inventorytransfer Entity [msdyn_inventorytransfer_BulkDeleteFailures](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_orderinvoicingdate_BulkDeleteFailures"></a> msdyn_orderinvoicingdate_BulkDeleteFailures

See msdyn_orderinvoicingdate Entity [msdyn_orderinvoicingdate_BulkDeleteFailures](msdyn_orderinvoicingdate.md#BKMK_msdyn_orderinvoicingdate_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_orderinvoicingproduct_BulkDeleteFailures"></a> msdyn_orderinvoicingproduct_BulkDeleteFailures

See msdyn_orderinvoicingproduct Entity [msdyn_orderinvoicingproduct_BulkDeleteFailures](msdyn_orderinvoicingproduct.md#BKMK_msdyn_orderinvoicingproduct_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_orderinvoicingsetup_BulkDeleteFailures"></a> msdyn_orderinvoicingsetup_BulkDeleteFailures

See msdyn_orderinvoicingsetup Entity [msdyn_orderinvoicingsetup_BulkDeleteFailures](msdyn_orderinvoicingsetup.md#BKMK_msdyn_orderinvoicingsetup_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_orderinvoicingsetupdate_BulkDeleteFailures"></a> msdyn_orderinvoicingsetupdate_BulkDeleteFailures

See msdyn_orderinvoicingsetupdate Entity [msdyn_orderinvoicingsetupdate_BulkDeleteFailures](msdyn_orderinvoicingsetupdate.md#BKMK_msdyn_orderinvoicingsetupdate_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_payment_BulkDeleteFailures"></a> msdyn_payment_BulkDeleteFailures

See msdyn_payment Entity [msdyn_payment_BulkDeleteFailures](msdyn_payment.md#BKMK_msdyn_payment_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentdetail_BulkDeleteFailures"></a> msdyn_paymentdetail_BulkDeleteFailures

See msdyn_paymentdetail Entity [msdyn_paymentdetail_BulkDeleteFailures](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentmethod_BulkDeleteFailures"></a> msdyn_paymentmethod_BulkDeleteFailures

See msdyn_paymentmethod Entity [msdyn_paymentmethod_BulkDeleteFailures](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentterm_BulkDeleteFailures"></a> msdyn_paymentterm_BulkDeleteFailures

See msdyn_paymentterm Entity [msdyn_paymentterm_BulkDeleteFailures](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_postalcode_BulkDeleteFailures"></a> msdyn_postalcode_BulkDeleteFailures

See msdyn_postalcode Entity [msdyn_postalcode_BulkDeleteFailures](msdyn_postalcode.md#BKMK_msdyn_postalcode_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_productinventory_BulkDeleteFailures"></a> msdyn_productinventory_BulkDeleteFailures

See msdyn_productinventory Entity [msdyn_productinventory_BulkDeleteFailures](msdyn_productinventory.md#BKMK_msdyn_productinventory_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorder_BulkDeleteFailures"></a> msdyn_purchaseorder_BulkDeleteFailures

See msdyn_purchaseorder Entity [msdyn_purchaseorder_BulkDeleteFailures](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderbill_BulkDeleteFailures"></a> msdyn_purchaseorderbill_BulkDeleteFailures

See msdyn_purchaseorderbill Entity [msdyn_purchaseorderbill_BulkDeleteFailures](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderproduct_BulkDeleteFailures"></a> msdyn_purchaseorderproduct_BulkDeleteFailures

See msdyn_purchaseorderproduct Entity [msdyn_purchaseorderproduct_BulkDeleteFailures](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceipt_BulkDeleteFailures"></a> msdyn_purchaseorderreceipt_BulkDeleteFailures

See msdyn_purchaseorderreceipt Entity [msdyn_purchaseorderreceipt_BulkDeleteFailures](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_BulkDeleteFailures"></a> msdyn_purchaseorderreceiptproduct_BulkDeleteFailures

See msdyn_purchaseorderreceiptproduct Entity [msdyn_purchaseorderreceiptproduct_BulkDeleteFailures](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseordersubstatus_BulkDeleteFailures"></a> msdyn_purchaseordersubstatus_BulkDeleteFailures

See msdyn_purchaseordersubstatus Entity [msdyn_purchaseordersubstatus_BulkDeleteFailures](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingincident_BulkDeleteFailures"></a> msdyn_quotebookingincident_BulkDeleteFailures

See msdyn_quotebookingincident Entity [msdyn_quotebookingincident_BulkDeleteFailures](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingproduct_BulkDeleteFailures"></a> msdyn_quotebookingproduct_BulkDeleteFailures

See msdyn_quotebookingproduct Entity [msdyn_quotebookingproduct_BulkDeleteFailures](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservice_BulkDeleteFailures"></a> msdyn_quotebookingservice_BulkDeleteFailures

See msdyn_quotebookingservice Entity [msdyn_quotebookingservice_BulkDeleteFailures](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservicetask_BulkDeleteFailures"></a> msdyn_quotebookingservicetask_BulkDeleteFailures

See msdyn_quotebookingservicetask Entity [msdyn_quotebookingservicetask_BulkDeleteFailures](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingsetup_BulkDeleteFailures"></a> msdyn_quotebookingsetup_BulkDeleteFailures

See msdyn_quotebookingsetup Entity [msdyn_quotebookingsetup_BulkDeleteFailures](msdyn_quotebookingsetup.md#BKMK_msdyn_quotebookingsetup_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_quoteinvoicingproduct_BulkDeleteFailures"></a> msdyn_quoteinvoicingproduct_BulkDeleteFailures

See msdyn_quoteinvoicingproduct Entity [msdyn_quoteinvoicingproduct_BulkDeleteFailures](msdyn_quoteinvoicingproduct.md#BKMK_msdyn_quoteinvoicingproduct_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_quoteinvoicingsetup_BulkDeleteFailures"></a> msdyn_quoteinvoicingsetup_BulkDeleteFailures

See msdyn_quoteinvoicingsetup Entity [msdyn_quoteinvoicingsetup_BulkDeleteFailures](msdyn_quoteinvoicingsetup.md#BKMK_msdyn_quoteinvoicingsetup_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcepaytype_BulkDeleteFailures"></a> msdyn_resourcepaytype_BulkDeleteFailures

See msdyn_resourcepaytype Entity [msdyn_resourcepaytype_BulkDeleteFailures](msdyn_resourcepaytype.md#BKMK_msdyn_resourcepaytype_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_rma_BulkDeleteFailures"></a> msdyn_rma_BulkDeleteFailures

See msdyn_rma Entity [msdyn_rma_BulkDeleteFailures](msdyn_rma.md#BKMK_msdyn_rma_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_rmaproduct_BulkDeleteFailures"></a> msdyn_rmaproduct_BulkDeleteFailures

See msdyn_rmaproduct Entity [msdyn_rmaproduct_BulkDeleteFailures](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceipt_BulkDeleteFailures"></a> msdyn_rmareceipt_BulkDeleteFailures

See msdyn_rmareceipt Entity [msdyn_rmareceipt_BulkDeleteFailures](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceiptproduct_BulkDeleteFailures"></a> msdyn_rmareceiptproduct_BulkDeleteFailures

See msdyn_rmareceiptproduct Entity [msdyn_rmareceiptproduct_BulkDeleteFailures](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_rmasubstatus_BulkDeleteFailures"></a> msdyn_rmasubstatus_BulkDeleteFailures

See msdyn_rmasubstatus Entity [msdyn_rmasubstatus_BulkDeleteFailures](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_rtv_BulkDeleteFailures"></a> msdyn_rtv_BulkDeleteFailures

See msdyn_rtv Entity [msdyn_rtv_BulkDeleteFailures](msdyn_rtv.md#BKMK_msdyn_rtv_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvproduct_BulkDeleteFailures"></a> msdyn_rtvproduct_BulkDeleteFailures

See msdyn_rtvproduct Entity [msdyn_rtvproduct_BulkDeleteFailures](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvsubstatus_BulkDeleteFailures"></a> msdyn_rtvsubstatus_BulkDeleteFailures

See msdyn_rtvsubstatus Entity [msdyn_rtvsubstatus_BulkDeleteFailures](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_servicetasktype_BulkDeleteFailures"></a> msdyn_servicetasktype_BulkDeleteFailures

See msdyn_servicetasktype Entity [msdyn_servicetasktype_BulkDeleteFailures](msdyn_servicetasktype.md#BKMK_msdyn_servicetasktype_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_shipvia_BulkDeleteFailures"></a> msdyn_shipvia_BulkDeleteFailures

See msdyn_shipvia Entity [msdyn_shipvia_BulkDeleteFailures](msdyn_shipvia.md#BKMK_msdyn_shipvia_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_taxcode_BulkDeleteFailures"></a> msdyn_taxcode_BulkDeleteFailures

See msdyn_taxcode Entity [msdyn_taxcode_BulkDeleteFailures](msdyn_taxcode.md#BKMK_msdyn_taxcode_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_taxcodedetail_BulkDeleteFailures"></a> msdyn_taxcodedetail_BulkDeleteFailures

See msdyn_taxcodedetail Entity [msdyn_taxcodedetail_BulkDeleteFailures](msdyn_taxcodedetail.md#BKMK_msdyn_taxcodedetail_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_timeoffrequest_BulkDeleteFailures"></a> msdyn_timeoffrequest_BulkDeleteFailures

See msdyn_timeoffrequest Entity [msdyn_timeoffrequest_BulkDeleteFailures](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_uniquenumber_BulkDeleteFailures"></a> msdyn_uniquenumber_BulkDeleteFailures

See msdyn_uniquenumber Entity [msdyn_uniquenumber_BulkDeleteFailures](msdyn_uniquenumber.md#BKMK_msdyn_uniquenumber_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_warehouse_BulkDeleteFailures"></a> msdyn_warehouse_BulkDeleteFailures

See msdyn_warehouse Entity [msdyn_warehouse_BulkDeleteFailures](msdyn_warehouse.md#BKMK_msdyn_warehouse_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_workorder_BulkDeleteFailures"></a> msdyn_workorder_BulkDeleteFailures

See msdyn_workorder Entity [msdyn_workorder_BulkDeleteFailures](msdyn_workorder.md#BKMK_msdyn_workorder_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_workordercharacteristic_BulkDeleteFailures"></a> msdyn_workordercharacteristic_BulkDeleteFailures

See msdyn_workordercharacteristic Entity [msdyn_workordercharacteristic_BulkDeleteFailures](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderdetailsgenerationqueue_BulkDeleteFailures"></a> msdyn_workorderdetailsgenerationqueue_BulkDeleteFailures

See msdyn_workorderdetailsgenerationqueue Entity [msdyn_workorderdetailsgenerationqueue_BulkDeleteFailures](msdyn_workorderdetailsgenerationqueue.md#BKMK_msdyn_workorderdetailsgenerationqueue_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderincident_BulkDeleteFailures"></a> msdyn_workorderincident_BulkDeleteFailures

See msdyn_workorderincident Entity [msdyn_workorderincident_BulkDeleteFailures](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderproduct_BulkDeleteFailures"></a> msdyn_workorderproduct_BulkDeleteFailures

See msdyn_workorderproduct Entity [msdyn_workorderproduct_BulkDeleteFailures](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderresourcerestriction_BulkDeleteFailures"></a> msdyn_workorderresourcerestriction_BulkDeleteFailures

See msdyn_workorderresourcerestriction Entity [msdyn_workorderresourcerestriction_BulkDeleteFailures](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservice_BulkDeleteFailures"></a> msdyn_workorderservice_BulkDeleteFailures

See msdyn_workorderservice Entity [msdyn_workorderservice_BulkDeleteFailures](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservicetask_BulkDeleteFailures"></a> msdyn_workorderservicetask_BulkDeleteFailures

See msdyn_workorderservicetask Entity [msdyn_workorderservicetask_BulkDeleteFailures](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_workordersubstatus_BulkDeleteFailures"></a> msdyn_workordersubstatus_BulkDeleteFailures

See msdyn_workordersubstatus Entity [msdyn_workordersubstatus_BulkDeleteFailures](msdyn_workordersubstatus.md#BKMK_msdyn_workordersubstatus_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_workordertype_BulkDeleteFailures"></a> msdyn_workordertype_BulkDeleteFailures

See msdyn_workordertype Entity [msdyn_workordertype_BulkDeleteFailures](msdyn_workordertype.md#BKMK_msdyn_workordertype_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_iotalert_BulkDeleteFailures"></a> msdyn_iotalert_BulkDeleteFailures

See msdyn_iotalert Entity [msdyn_iotalert_BulkDeleteFailures](msdyn_iotalert.md#BKMK_msdyn_iotalert_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdevice_BulkDeleteFailures"></a> msdyn_iotdevice_BulkDeleteFailures

See msdyn_iotdevice Entity [msdyn_iotdevice_BulkDeleteFailures](msdyn_iotdevice.md#BKMK_msdyn_iotdevice_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdevicecategory_BulkDeleteFailures"></a> msdyn_iotdevicecategory_BulkDeleteFailures

See msdyn_iotdevicecategory Entity [msdyn_iotdevicecategory_BulkDeleteFailures](msdyn_iotdevicecategory.md#BKMK_msdyn_iotdevicecategory_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdevicecommand_BulkDeleteFailures"></a> msdyn_iotdevicecommand_BulkDeleteFailures

See msdyn_iotdevicecommand Entity [msdyn_iotdevicecommand_BulkDeleteFailures](msdyn_iotdevicecommand.md#BKMK_msdyn_iotdevicecommand_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdeviceregistrationhistory_BulkDeleteFailures"></a> msdyn_iotdeviceregistrationhistory_BulkDeleteFailures

See msdyn_iotdeviceregistrationhistory Entity [msdyn_iotdeviceregistrationhistory_BulkDeleteFailures](msdyn_iotdeviceregistrationhistory.md#BKMK_msdyn_iotdeviceregistrationhistory_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_BulkDeleteFailures"></a> msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_BulkDeleteFailures

See msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b Entity [msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_BulkDeleteFailures](msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b.md#BKMK_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_theme_BulkDeleteFailures"></a> theme_BulkDeleteFailures

See theme Entity [theme_BulkDeleteFailures](theme.md#BKMK_theme_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_usermapping_BulkDeleteFailures"></a> usermapping_BulkDeleteFailures

See usermapping Entity [usermapping_BulkDeleteFailures](usermapping.md#BKMK_usermapping_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_knowledgearticle_BulkDeleteFailures"></a> knowledgearticle_BulkDeleteFailures

See knowledgearticle Entity [knowledgearticle_BulkDeleteFailures](knowledgearticle.md#BKMK_knowledgearticle_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_post_BulkDeleteFailures"></a> post_BulkDeleteFailures

See post Entity [post_BulkDeleteFailures](post.md#BKMK_post_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_channelaccessprofile_BulkDeleteFailures"></a> channelaccessprofile_BulkDeleteFailures

See channelaccessprofile Entity [channelaccessprofile_BulkDeleteFailures](channelaccessprofile.md#BKMK_channelaccessprofile_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_externalparty_BulkDeleteFailures"></a> externalparty_BulkDeleteFailures

See externalparty Entity [externalparty_BulkDeleteFailures](externalparty.md#BKMK_externalparty_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_profilerule_BulkDeleteFailures"></a> profilerule_BulkDeleteFailures

See channelaccessprofilerule Entity [profilerule_BulkDeleteFailures](channelaccessprofilerule.md#BKMK_profilerule_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_KnowledgeBaseRecord_BulkDeleteFailures"></a> KnowledgeBaseRecord_BulkDeleteFailures

See knowledgebaserecord Entity [KnowledgeBaseRecord_BulkDeleteFailures](knowledgebaserecord.md#BKMK_KnowledgeBaseRecord_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_RelationshipRole_BulkDeleteFailures"></a> RelationshipRole_BulkDeleteFailures

See relationshiprole Entity [RelationshipRole_BulkDeleteFailures](relationshiprole.md#BKMK_RelationshipRole_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_Role_BulkDeleteFailures"></a> Role_BulkDeleteFailures

See role Entity [Role_BulkDeleteFailures](role.md#BKMK_Role_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_Subject_BulkDeleteFailures"></a> Subject_BulkDeleteFailures

See subject Entity [Subject_BulkDeleteFailures](subject.md#BKMK_Subject_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_Fax_BulkDeleteFailures"></a> Fax_BulkDeleteFailures

See fax Entity [Fax_BulkDeleteFailures](fax.md#BKMK_Fax_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_Privilege_BulkDeleteFailures"></a> Privilege_BulkDeleteFailures

See privilege Entity [Privilege_BulkDeleteFailures](privilege.md#BKMK_Privilege_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_KbArticle_BulkDeleteFailures"></a> KbArticle_BulkDeleteFailures

See kbarticle Entity [KbArticle_BulkDeleteFailures](kbarticle.md#BKMK_KbArticle_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_KbArticleComment_BulkDeleteFailures"></a> KbArticleComment_BulkDeleteFailures

See kbarticlecomment Entity [KbArticleComment_BulkDeleteFailures](kbarticlecomment.md#BKMK_KbArticleComment_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_RelationshipRoleMap_BulkDeleteFailures"></a> RelationshipRoleMap_BulkDeleteFailures

See relationshiprolemap Entity [RelationshipRoleMap_BulkDeleteFailures](relationshiprolemap.md#BKMK_RelationshipRoleMap_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_AnnualFiscalCalendar_BulkDeleteFailures"></a> AnnualFiscalCalendar_BulkDeleteFailures

See annualfiscalcalendar Entity [AnnualFiscalCalendar_BulkDeleteFailures](annualfiscalcalendar.md#BKMK_AnnualFiscalCalendar_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_UserForm_BulkDeleteFailures"></a> UserForm_BulkDeleteFailures

See userform Entity [UserForm_BulkDeleteFailures](userform.md#BKMK_UserForm_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_IsvConfig_BulkDeleteFailures"></a> IsvConfig_BulkDeleteFailures

See isvconfig Entity [IsvConfig_BulkDeleteFailures](isvconfig.md#BKMK_IsvConfig_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_routingruleitem_BulkDeleteFailures"></a> routingruleitem_BulkDeleteFailures

See routingruleitem Entity [routingruleitem_BulkDeleteFailures](routingruleitem.md#BKMK_routingruleitem_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_Queue_BulkDeleteFailures"></a> Queue_BulkDeleteFailures

See queue Entity [Queue_BulkDeleteFailures](queue.md#BKMK_Queue_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_Contact_BulkDeleteFailures"></a> Contact_BulkDeleteFailures

See contact Entity [Contact_BulkDeleteFailures](contact.md#BKMK_Contact_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_emailserverprofile_bulkdeletefailures"></a> emailserverprofile_bulkdeletefailures

See emailserverprofile Entity [emailserverprofile_bulkdeletefailures](emailserverprofile.md#BKMK_emailserverprofile_bulkdeletefailures) One-To-Many relationship.

### <a name="BKMK_SavedQuery_BulkDeleteFailures"></a> SavedQuery_BulkDeleteFailures

See savedquery Entity [SavedQuery_BulkDeleteFailures](savedquery.md#BKMK_SavedQuery_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_externalpartyitem_BulkDeleteFailures"></a> externalpartyitem_BulkDeleteFailures

See externalpartyitem Entity [externalpartyitem_BulkDeleteFailures](externalpartyitem.md#BKMK_externalpartyitem_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_Appointment_BulkDeleteFailures"></a> Appointment_BulkDeleteFailures

See appointment Entity [Appointment_BulkDeleteFailures](appointment.md#BKMK_Appointment_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_Template_BulkDeleteFailures"></a> Template_BulkDeleteFailures

See template Entity [Template_BulkDeleteFailures](template.md#BKMK_Template_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_Account_BulkDeleteFailures"></a> Account_BulkDeleteFailures

See account Entity [Account_BulkDeleteFailures](account.md#BKMK_Account_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_CustomerRelationship_BulkDeleteFailures"></a> CustomerRelationship_BulkDeleteFailures

See customerrelationship Entity [CustomerRelationship_BulkDeleteFailures](customerrelationship.md#BKMK_CustomerRelationship_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_SystemUser_BulkDeleteFailures"></a> SystemUser_BulkDeleteFailures

See systemuser Entity [SystemUser_BulkDeleteFailures](systemuser.md#BKMK_SystemUser_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_QuarterlyFiscalCalendar_BulkDeleteFailures"></a> QuarterlyFiscalCalendar_BulkDeleteFailures

See quarterlyfiscalcalendar Entity [QuarterlyFiscalCalendar_BulkDeleteFailures](quarterlyfiscalcalendar.md#BKMK_QuarterlyFiscalCalendar_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_QueueItem_BulkDeleteFailures"></a> QueueItem_BulkDeleteFailures

See queueitem Entity [QueueItem_BulkDeleteFailures](queueitem.md#BKMK_QueueItem_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_AttributeMap_BulkDeleteFailures"></a> AttributeMap_BulkDeleteFailures

See attributemap Entity [AttributeMap_BulkDeleteFailures](attributemap.md#BKMK_AttributeMap_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_DisplayString_BulkDeleteFailures"></a> DisplayString_BulkDeleteFailures

See displaystring Entity [DisplayString_BulkDeleteFailures](displaystring.md#BKMK_DisplayString_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_Calendar_BulkDeleteFailures"></a> Calendar_BulkDeleteFailures

See calendar Entity [Calendar_BulkDeleteFailures](calendar.md#BKMK_Calendar_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_Organization_BulkDeleteFailures"></a> Organization_BulkDeleteFailures

See organization Entity [Organization_BulkDeleteFailures](organization.md#BKMK_Organization_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_BusinessUnit_BulkDeleteFailures"></a> BusinessUnit_BulkDeleteFailures

See businessunit Entity [BusinessUnit_BulkDeleteFailures](businessunit.md#BKMK_BusinessUnit_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_Annotation_BulkDeleteFailures"></a> Annotation_BulkDeleteFailures

See annotation Entity [Annotation_BulkDeleteFailures](annotation.md#BKMK_Annotation_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_ImportLog_BulkDeleteFailures"></a> ImportLog_BulkDeleteFailures

See importlog Entity [ImportLog_BulkDeleteFailures](importlog.md#BKMK_ImportLog_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_routingrule_BulkDeleteFailures"></a> routingrule_BulkDeleteFailures

See routingrule Entity [routingrule_BulkDeleteFailures](routingrule.md#BKMK_routingrule_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_Import_BulkDeleteFailures"></a> Import_BulkDeleteFailures

See import Entity [Import_BulkDeleteFailures](import.md#BKMK_Import_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_Letter_BulkDeleteFailures"></a> Letter_BulkDeleteFailures

See letter Entity [Letter_BulkDeleteFailures](letter.md#BKMK_Letter_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_UserQuery_BulkDeleteFailures"></a> UserQuery_BulkDeleteFailures

See userquery Entity [UserQuery_BulkDeleteFailures](userquery.md#BKMK_UserQuery_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_PhoneCall_BulkDeleteFailures"></a> PhoneCall_BulkDeleteFailures

See phonecall Entity [PhoneCall_BulkDeleteFailures](phonecall.md#BKMK_PhoneCall_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_Team_BulkDeleteFailures"></a> Team_BulkDeleteFailures

See team Entity [Team_BulkDeleteFailures](team.md#BKMK_Team_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_EntityMap_BulkDeleteFailures"></a> EntityMap_BulkDeleteFailures

See entitymap Entity [EntityMap_BulkDeleteFailures](entitymap.md#BKMK_EntityMap_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_CustomerAddress_BulkDeleteFailures"></a> CustomerAddress_BulkDeleteFailures

See customeraddress Entity [CustomerAddress_BulkDeleteFailures](customeraddress.md#BKMK_CustomerAddress_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_SocialActivity_BulkDeleteFailures"></a> SocialActivity_BulkDeleteFailures

See socialactivity Entity [SocialActivity_BulkDeleteFailures](socialactivity.md#BKMK_SocialActivity_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_ImportFile_BulkDeleteFailures"></a> ImportFile_BulkDeleteFailures

See importfile Entity [ImportFile_BulkDeleteFailures](importfile.md#BKMK_ImportFile_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_SystemForm_BulkDeleteFailures"></a> SystemForm_BulkDeleteFailures

See systemform Entity [SystemForm_BulkDeleteFailures](systemform.md#BKMK_SystemForm_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_BusinessUnitNewsArticle_BulkDeleteFailures"></a> BusinessUnitNewsArticle_BulkDeleteFailures

See businessunitnewsarticle Entity [BusinessUnitNewsArticle_BulkDeleteFailures](businessunitnewsarticle.md#BKMK_BusinessUnitNewsArticle_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_ImportMap_BulkDeleteFailures"></a> ImportMap_BulkDeleteFailures

See importmap Entity [ImportMap_BulkDeleteFailures](importmap.md#BKMK_ImportMap_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_RecurringAppointmentMaster_BulkDeleteFailures"></a> RecurringAppointmentMaster_BulkDeleteFailures

See recurringappointmentmaster Entity [RecurringAppointmentMaster_BulkDeleteFailures](recurringappointmentmaster.md#BKMK_RecurringAppointmentMaster_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_Email_BulkDeleteFailures"></a> Email_BulkDeleteFailures

See email Entity [Email_BulkDeleteFailures](email.md#BKMK_Email_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_MonthlyFiscalCalendar_BulkDeleteFailures"></a> MonthlyFiscalCalendar_BulkDeleteFailures

See monthlyfiscalcalendar Entity [MonthlyFiscalCalendar_BulkDeleteFailures](monthlyfiscalcalendar.md#BKMK_MonthlyFiscalCalendar_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_KbArticleTemplate_BulkDeleteFailures"></a> KbArticleTemplate_BulkDeleteFailures

See kbarticletemplate Entity [KbArticleTemplate_BulkDeleteFailures](kbarticletemplate.md#BKMK_KbArticleTemplate_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_ActivityPointer_BulkDeleteFailures"></a> ActivityPointer_BulkDeleteFailures

See activitypointer Entity [ActivityPointer_BulkDeleteFailures](activitypointer.md#BKMK_ActivityPointer_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_slabase_BulkDeleteFailures"></a> slabase_BulkDeleteFailures

See sla Entity [slabase_BulkDeleteFailures](sla.md#BKMK_slabase_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_FixedMonthlyFiscalCalendar_BulkDeleteFailures"></a> FixedMonthlyFiscalCalendar_BulkDeleteFailures

See fixedmonthlyfiscalcalendar Entity [FixedMonthlyFiscalCalendar_BulkDeleteFailures](fixedmonthlyfiscalcalendar.md#BKMK_FixedMonthlyFiscalCalendar_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_Task_BulkDeleteFailures"></a> Task_BulkDeleteFailures

See task Entity [Task_BulkDeleteFailures](task.md#BKMK_Task_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_BulkDeleteOperation_BulkDeleteFailure"></a> BulkDeleteOperation_BulkDeleteFailure

See bulkdeleteoperation Entity [BulkDeleteOperation_BulkDeleteFailure](bulkdeleteoperation.md#BKMK_BulkDeleteOperation_BulkDeleteFailure) One-To-Many relationship.

### <a name="BKMK_ActivityMimeAttachment_BulkDeleteFailures"></a> ActivityMimeAttachment_BulkDeleteFailures

See activitymimeattachment Entity [ActivityMimeAttachment_BulkDeleteFailures](activitymimeattachment.md#BKMK_ActivityMimeAttachment_BulkDeleteFailures) One-To-Many relationship.

### <a name="BKMK_SemiAnnualFiscalCalendar_BulkDeleteFailures"></a> SemiAnnualFiscalCalendar_BulkDeleteFailures

See semiannualfiscalcalendar Entity [SemiAnnualFiscalCalendar_BulkDeleteFailures](semiannualfiscalcalendar.md#BKMK_SemiAnnualFiscalCalendar_BulkDeleteFailures) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.bulkdeletefailure?text=bulkdeletefailure EntityType" />