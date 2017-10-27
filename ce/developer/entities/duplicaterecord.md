---
title: "DuplicateRecord Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the DuplicateRecord entity."
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
# DuplicateRecord Entity Reference

Potential duplicate record.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Retrieve|GET [*org URI*]/api/data/v9.0/duplicaterecords(*duplicateid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/duplicaterecords<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|

## Properties

**DisplayName**: Duplicate Record<br />
**DisplayCollectionName**: Duplicate Records<br />
**SchemaName**: DuplicateRecord<br />
**CollectionSchemaName**: DuplicateRecords<br />
**LogicalName**: duplicaterecord<br />
**LogicalCollectionName**: duplicaterecords<br />
**EntitySetName**: duplicaterecords<br />
**PrimaryIdAttribute**: duplicateid<br />
**PrimaryNameAttribute**: <br />
**OwnershipType**: None<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.


### <a name="BKMK_DuplicateId"></a> DuplicateId

**Description**: Unique identifier of the duplicate record.<br />
**DisplayName**: <br />
**LogicalName**: duplicateid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [AsyncOperationId](#BKMK_AsyncOperationId)
- [BaseRecordId](#BKMK_BaseRecordId)
- [BaseRecordIdName](#BKMK_BaseRecordIdName)
- [BaseRecordIdTypeCode](#BKMK_BaseRecordIdTypeCode)
- [BaseRecordIdYomiName](#BKMK_BaseRecordIdYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [DuplicateRecordId](#BKMK_DuplicateRecordId)
- [DuplicateRecordIdName](#BKMK_DuplicateRecordIdName)
- [DuplicateRecordIdTypeCode](#BKMK_DuplicateRecordIdTypeCode)
- [DuplicateRecordIdYomiName](#BKMK_DuplicateRecordIdYomiName)
- [DuplicateRuleId](#BKMK_DuplicateRuleId)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningUser](#BKMK_OwningUser)


### <a name="BKMK_AsyncOperationId"></a> AsyncOperationId

**Description**: Unique identifier of the system job that created this record.<br />
**DisplayName**: System Job<br />
**LogicalName**: asyncoperationid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: asyncoperation


### <a name="BKMK_BaseRecordId"></a> BaseRecordId

**Description**: Unique identifier of the base record.<br />
**DisplayName**: Base Record ID<br />
**LogicalName**: baserecordid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: account,appointment,bookableresource,bookableresourcebooking,bookableresourcebookingheader,bookableresourcecategory,bookableresourcecategoryassn,bookableresourcecharacteristic,bookableresourcegroup,bookingstatus,campaign,campaignresponse,channelaccessprofile,characteristic,competitor,contact,contract,email,emailserverprofile,entitlement,entitlementchannel,entitlementtemplate,equipment,fax,goal,goalrollupquery,incident,kbarticle,knowledgearticle,knowledgebaserecord,lead,letter,list,msdyn_accountpricelist,msdyn_actual,msdyn_agreement,msdyn_agreementbookingdate,msdyn_agreementbookingincident,msdyn_agreementbookingproduct,msdyn_agreementbookingservice,msdyn_agreementbookingservicetask,msdyn_agreementbookingsetup,msdyn_agreementinvoicedate,msdyn_agreementinvoiceproduct,msdyn_agreementinvoicesetup,msdyn_agreementsubstatus,msdyn_approval,msdyn_batchjob,msdyn_bookingalert,msdyn_bookingalertstatus,msdyn_bookingrule,msdyn_bookingtimestamp,msdyn_characteristicreqforteammember,msdyn_clientextension,msdyn_contactpricelist,msdyn_contractlineinvoiceschedule,msdyn_contractlinescheduleofvalue,msdyn_customerasset,msdyn_dataexport,msdyn_delegation,msdyn_estimate,msdyn_estimateline,msdyn_expense,msdyn_expensecategory,msdyn_fact,msdyn_fieldcomputation,msdyn_fieldservicepricelistitem,msdyn_findworkevent,msdyn_incidenttype,msdyn_incidenttypecharacteristic,msdyn_incidenttypeproduct,msdyn_incidenttypeservice,msdyn_incidenttypeservicetask,msdyn_inventoryadjustment,msdyn_inventoryadjustmentproduct,msdyn_inventoryjournal,msdyn_inventorytransfer,msdyn_invoicefrequency,msdyn_invoicefrequencydetail,msdyn_invoicelinetransaction,msdyn_iotdevice,msdyn_iotdevicecategory,msdyn_iotdevicecommand,msdyn_iotdeviceregistrationhistory,msdyn_journal,msdyn_journalline,msdyn_opportunitylineresourcecategory,msdyn_opportunitylinetransaction,msdyn_opportunitylinetransactioncategory,msdyn_opportunitylinetransactionclassificatio,msdyn_opportunitypricelist,msdyn_orderinvoicingdate,msdyn_orderinvoicingproduct,msdyn_orderinvoicingsetup,msdyn_orderinvoicingsetupdate,msdyn_orderlineresourcecategory,msdyn_orderlinetransaction,msdyn_orderlinetransactioncategory,msdyn_orderlinetransactionclassification,msdyn_orderpricelist,msdyn_organizationalunit,msdyn_payment,msdyn_paymentdetail,msdyn_paymentmethod,msdyn_paymentterm,msdyn_postalbum,msdyn_postalcode,msdyn_priority,msdyn_processnotes,msdyn_productinventory,msdyn_project,msdyn_projectapproval,msdyn_projectparameter,msdyn_projectparameterpricelist,msdyn_projectpricelist,msdyn_projecttask,msdyn_projecttaskdependency,msdyn_projecttaskstatususer,msdyn_projectteam,msdyn_projectteammembersignup,msdyn_projecttransactioncategory,msdyn_purchaseorder,msdyn_purchaseorderbill,msdyn_purchaseorderreceipt,msdyn_purchaseorderreceiptproduct,msdyn_purchaseordersubstatus,msdyn_quotebookingincident,msdyn_quotebookingproduct,msdyn_quotebookingservice,msdyn_quotebookingservicetask,msdyn_quotebookingsetup,msdyn_quoteinvoicingproduct,msdyn_quoteinvoicingsetup,msdyn_quotelineanalyticsbreakdown,msdyn_quotelineinvoiceschedule,msdyn_quotelineresourcecategory,msdyn_quotelinescheduleofvalue,msdyn_quotelinetransaction,msdyn_quotelinetransactioncategory,msdyn_quotelinetransactionclassification,msdyn_quotepricelist,msdyn_requirementcharacteristic,msdyn_requirementorganizationunit,msdyn_requirementresourcecategory,msdyn_requirementresourcepreference,msdyn_requirementstatus,msdyn_resourceassignmentdetail,msdyn_resourcecategorypricelevel,msdyn_resourcerequest,msdyn_resourcerequirement,msdyn_resourcerequirementdetail,msdyn_resourceterritory,msdyn_rma,msdyn_rmareceipt,msdyn_rmareceiptproduct,msdyn_rmasubstatus,msdyn_rolecompetencyrequirement,msdyn_roleutilization,msdyn_rtv,msdyn_rtvproduct,msdyn_rtvsubstatus,msdyn_scheduleboardsetting,msdyn_servicetasktype,msdyn_shipvia,msdyn_systemuserschedulersetting,msdyn_taxcode,msdyn_taxcodedetail,msdyn_timegroup,msdyn_timegroupdetail,msdyn_timeoffcalendar,msdyn_timeoffrequest,msdyn_transactioncategory,msdyn_transactioncategoryclassification,msdyn_transactioncategoryhierarchyelement,msdyn_transactioncategorypricelevel,msdyn_transactionconnection,msdyn_transactionorigin,msdyn_transactiontype,msdyn_userworkhistory,msdyn_warehouse,msdyn_workhourtemplate,msdyn_workorder,msdyn_workordercharacteristic,msdyn_workorderdetailsgenerationqueue,msdyn_workorderincident,msdyn_workorderresourcerestriction,msdyn_workorderservice,msdyn_workorderservicetask,msdyn_workordersubstatus,msdyn_workordertype,opportunity,phonecall,publisher,queue,quote,ratingmodel,ratingvalue,recurringappointmentmaster,resourcegroup,service,sharepointdocumentlocation,sharepointsite,socialactivity,socialprofile,systemuser,task,team,territory,transactioncurrency


### <a name="BKMK_BaseRecordIdName"></a> BaseRecordIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: baserecordidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 400


### <a name="BKMK_BaseRecordIdTypeCode"></a> BaseRecordIdTypeCode

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: baserecordidtypecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: EntityName<br />


### <a name="BKMK_BaseRecordIdYomiName"></a> BaseRecordIdYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: baserecordidyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 400


### <a name="BKMK_CreatedOn"></a> CreatedOn

**Description**: Date and time when the duplicate record was created.<br />
**DisplayName**: <br />
**LogicalName**: createdon<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_DuplicateRecordId"></a> DuplicateRecordId

**Description**: Unique identifier of the potential duplicate record.<br />
**DisplayName**: Duplicate Record ID<br />
**LogicalName**: duplicaterecordid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: account,appointment,bookableresource,bookableresourcebooking,bookableresourcebookingheader,bookableresourcecategory,bookableresourcecategoryassn,bookableresourcecharacteristic,bookableresourcegroup,bookingstatus,campaign,campaignresponse,channelaccessprofile,characteristic,competitor,contact,contract,email,emailserverprofile,entitlement,entitlementchannel,entitlementtemplate,equipment,fax,goal,goalrollupquery,incident,kbarticle,knowledgearticle,knowledgebaserecord,lead,letter,list,msdyn_accountpricelist,msdyn_actual,msdyn_agreement,msdyn_agreementbookingdate,msdyn_agreementbookingincident,msdyn_agreementbookingproduct,msdyn_agreementbookingservice,msdyn_agreementbookingservicetask,msdyn_agreementbookingsetup,msdyn_agreementinvoicedate,msdyn_agreementinvoiceproduct,msdyn_agreementinvoicesetup,msdyn_agreementsubstatus,msdyn_approval,msdyn_batchjob,msdyn_bookingalert,msdyn_bookingalertstatus,msdyn_bookingrule,msdyn_bookingtimestamp,msdyn_characteristicreqforteammember,msdyn_clientextension,msdyn_contactpricelist,msdyn_contractlineinvoiceschedule,msdyn_contractlinescheduleofvalue,msdyn_customerasset,msdyn_dataexport,msdyn_delegation,msdyn_estimate,msdyn_estimateline,msdyn_expense,msdyn_expensecategory,msdyn_fact,msdyn_fieldcomputation,msdyn_fieldservicepricelistitem,msdyn_findworkevent,msdyn_incidenttype,msdyn_incidenttypecharacteristic,msdyn_incidenttypeproduct,msdyn_incidenttypeservice,msdyn_incidenttypeservicetask,msdyn_inventoryadjustment,msdyn_inventoryadjustmentproduct,msdyn_inventoryjournal,msdyn_inventorytransfer,msdyn_invoicefrequency,msdyn_invoicefrequencydetail,msdyn_invoicelinetransaction,msdyn_iotdevice,msdyn_iotdevicecategory,msdyn_iotdevicecommand,msdyn_iotdeviceregistrationhistory,msdyn_journal,msdyn_journalline,msdyn_opportunitylineresourcecategory,msdyn_opportunitylinetransaction,msdyn_opportunitylinetransactioncategory,msdyn_opportunitylinetransactionclassificatio,msdyn_opportunitypricelist,msdyn_orderinvoicingdate,msdyn_orderinvoicingproduct,msdyn_orderinvoicingsetup,msdyn_orderinvoicingsetupdate,msdyn_orderlineresourcecategory,msdyn_orderlinetransaction,msdyn_orderlinetransactioncategory,msdyn_orderlinetransactionclassification,msdyn_orderpricelist,msdyn_organizationalunit,msdyn_payment,msdyn_paymentdetail,msdyn_paymentmethod,msdyn_paymentterm,msdyn_postalbum,msdyn_postalcode,msdyn_priority,msdyn_processnotes,msdyn_productinventory,msdyn_project,msdyn_projectapproval,msdyn_projectparameter,msdyn_projectparameterpricelist,msdyn_projectpricelist,msdyn_projecttask,msdyn_projecttaskdependency,msdyn_projecttaskstatususer,msdyn_projectteam,msdyn_projectteammembersignup,msdyn_projecttransactioncategory,msdyn_purchaseorder,msdyn_purchaseorderbill,msdyn_purchaseorderreceipt,msdyn_purchaseorderreceiptproduct,msdyn_purchaseordersubstatus,msdyn_quotebookingincident,msdyn_quotebookingproduct,msdyn_quotebookingservice,msdyn_quotebookingservicetask,msdyn_quotebookingsetup,msdyn_quoteinvoicingproduct,msdyn_quoteinvoicingsetup,msdyn_quotelineanalyticsbreakdown,msdyn_quotelineinvoiceschedule,msdyn_quotelineresourcecategory,msdyn_quotelinescheduleofvalue,msdyn_quotelinetransaction,msdyn_quotelinetransactioncategory,msdyn_quotelinetransactionclassification,msdyn_quotepricelist,msdyn_requirementcharacteristic,msdyn_requirementorganizationunit,msdyn_requirementresourcecategory,msdyn_requirementresourcepreference,msdyn_requirementstatus,msdyn_resourceassignmentdetail,msdyn_resourcecategorypricelevel,msdyn_resourcerequest,msdyn_resourcerequirement,msdyn_resourcerequirementdetail,msdyn_resourceterritory,msdyn_rma,msdyn_rmareceipt,msdyn_rmareceiptproduct,msdyn_rmasubstatus,msdyn_rolecompetencyrequirement,msdyn_roleutilization,msdyn_rtv,msdyn_rtvproduct,msdyn_rtvsubstatus,msdyn_scheduleboardsetting,msdyn_servicetasktype,msdyn_shipvia,msdyn_systemuserschedulersetting,msdyn_taxcode,msdyn_taxcodedetail,msdyn_timegroup,msdyn_timegroupdetail,msdyn_timeoffcalendar,msdyn_timeoffrequest,msdyn_transactioncategory,msdyn_transactioncategoryclassification,msdyn_transactioncategoryhierarchyelement,msdyn_transactioncategorypricelevel,msdyn_transactionconnection,msdyn_transactionorigin,msdyn_transactiontype,msdyn_userworkhistory,msdyn_warehouse,msdyn_workhourtemplate,msdyn_workorder,msdyn_workordercharacteristic,msdyn_workorderdetailsgenerationqueue,msdyn_workorderincident,msdyn_workorderresourcerestriction,msdyn_workorderservice,msdyn_workorderservicetask,msdyn_workordersubstatus,msdyn_workordertype,opportunity,phonecall,publisher,queue,quote,ratingmodel,ratingvalue,recurringappointmentmaster,resourcegroup,service,sharepointdocumentlocation,sharepointsite,socialactivity,socialprofile,systemuser,task,team,territory,transactioncurrency


### <a name="BKMK_DuplicateRecordIdName"></a> DuplicateRecordIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: duplicaterecordidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 400


### <a name="BKMK_DuplicateRecordIdTypeCode"></a> DuplicateRecordIdTypeCode

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: duplicaterecordidtypecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: EntityName<br />


### <a name="BKMK_DuplicateRecordIdYomiName"></a> DuplicateRecordIdYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: duplicaterecordidyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 400


### <a name="BKMK_DuplicateRuleId"></a> DuplicateRuleId

**Description**: Unique identifier of the duplicate rule against which this duplicate was found.<br />
**DisplayName**: <br />
**LogicalName**: duplicateruleid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: duplicaterule


### <a name="BKMK_OwnerId"></a> OwnerId

**Description**: Unique identifier of the user or team who owns the duplicate record.<br />
**DisplayName**: Owner<br />
**LogicalName**: ownerid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
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


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

**Description**: Unique identifier of the business unit that owns the duplicate record.<br />
**DisplayName**: Owning Business Unit<br />
**LogicalName**: owningbusinessunit<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_OwningUser"></a> OwningUser

**Description**: Unique identifier of the user who owns the duplicate record.<br />
**DisplayName**: Owning User<br />
**LogicalName**: owninguser<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: ApplicationRequired<br />
**Type**: Uniqueidentifier<br />

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.


### <a name="BKMK_userentityinstancedata_duplicaterecord"></a> userentityinstancedata_duplicaterecord

Same as userentityinstancedata entity [userentityinstancedata_duplicaterecord](userentityinstancedata.md#BKMK_userentityinstancedata_duplicaterecord) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: userentityinstancedata_duplicaterecord<br />
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

- [msdyn_iotdevice_DuplicateMatchingRecord](#BKMK_msdyn_iotdevice_DuplicateMatchingRecord)
- [msdyn_iotdevice_DuplicateBaseRecord](#BKMK_msdyn_iotdevice_DuplicateBaseRecord)
- [msdyn_iotdevicecategory_DuplicateMatchingRecord](#BKMK_msdyn_iotdevicecategory_DuplicateMatchingRecord)
- [msdyn_iotdevicecategory_DuplicateBaseRecord](#BKMK_msdyn_iotdevicecategory_DuplicateBaseRecord)
- [msdyn_iotdevicecommand_DuplicateMatchingRecord](#BKMK_msdyn_iotdevicecommand_DuplicateMatchingRecord)
- [msdyn_iotdevicecommand_DuplicateBaseRecord](#BKMK_msdyn_iotdevicecommand_DuplicateBaseRecord)
- [msdyn_iotdeviceregistrationhistory_DuplicateMatchingRecord](#BKMK_msdyn_iotdeviceregistrationhistory_DuplicateMatchingRecord)
- [msdyn_iotdeviceregistrationhistory_DuplicateBaseRecord](#BKMK_msdyn_iotdeviceregistrationhistory_DuplicateBaseRecord)
- [Lead_DuplicateMatchingRecord](#BKMK_Lead_DuplicateMatchingRecord)
- [Lead_DuplicateBaseRecord](#BKMK_Lead_DuplicateBaseRecord)
- [bookableresource_DuplicateMatchingRecord](#BKMK_bookableresource_DuplicateMatchingRecord)
- [bookableresource_DuplicateBaseRecord](#BKMK_bookableresource_DuplicateBaseRecord)
- [bookableresourcebooking_DuplicateMatchingRecord](#BKMK_bookableresourcebooking_DuplicateMatchingRecord)
- [bookableresourcebooking_DuplicateBaseRecord](#BKMK_bookableresourcebooking_DuplicateBaseRecord)
- [bookableresourcebookingheader_DuplicateMatchingRecord](#BKMK_bookableresourcebookingheader_DuplicateMatchingRecord)
- [bookableresourcebookingheader_DuplicateBaseRecord](#BKMK_bookableresourcebookingheader_DuplicateBaseRecord)
- [bookableresourcecategory_DuplicateMatchingRecord](#BKMK_bookableresourcecategory_DuplicateMatchingRecord)
- [bookableresourcecategory_DuplicateBaseRecord](#BKMK_bookableresourcecategory_DuplicateBaseRecord)
- [bookableresourcecategoryassn_DuplicateMatchingRecord](#BKMK_bookableresourcecategoryassn_DuplicateMatchingRecord)
- [bookableresourcecategoryassn_DuplicateBaseRecord](#BKMK_bookableresourcecategoryassn_DuplicateBaseRecord)
- [bookableresourcecharacteristic_DuplicateMatchingRecord](#BKMK_bookableresourcecharacteristic_DuplicateMatchingRecord)
- [bookableresourcecharacteristic_DuplicateBaseRecord](#BKMK_bookableresourcecharacteristic_DuplicateBaseRecord)
- [bookableresourcegroup_DuplicateMatchingRecord](#BKMK_bookableresourcegroup_DuplicateMatchingRecord)
- [bookableresourcegroup_DuplicateBaseRecord](#BKMK_bookableresourcegroup_DuplicateBaseRecord)
- [bookingstatus_DuplicateMatchingRecord](#BKMK_bookingstatus_DuplicateMatchingRecord)
- [bookingstatus_DuplicateBaseRecord](#BKMK_bookingstatus_DuplicateBaseRecord)
- [characteristic_DuplicateMatchingRecord](#BKMK_characteristic_DuplicateMatchingRecord)
- [characteristic_DuplicateBaseRecord](#BKMK_characteristic_DuplicateBaseRecord)
- [ratingmodel_DuplicateMatchingRecord](#BKMK_ratingmodel_DuplicateMatchingRecord)
- [ratingmodel_DuplicateBaseRecord](#BKMK_ratingmodel_DuplicateBaseRecord)
- [ratingvalue_DuplicateMatchingRecord](#BKMK_ratingvalue_DuplicateMatchingRecord)
- [ratingvalue_DuplicateBaseRecord](#BKMK_ratingvalue_DuplicateBaseRecord)
- [Campaign_DuplicateMatchingRecord](#BKMK_Campaign_DuplicateMatchingRecord)
- [Campaign_DuplicateBaseRecord](#BKMK_Campaign_DuplicateBaseRecord)
- [CampaignResponse_DuplicateMatchingRecord](#BKMK_CampaignResponse_DuplicateMatchingRecord)
- [CampaignResponse_DuplicateBaseRecord](#BKMK_CampaignResponse_DuplicateBaseRecord)
- [List_DuplicateMatchingRecord](#BKMK_List_DuplicateMatchingRecord)
- [List_DuplicateBaseRecord](#BKMK_List_DuplicateBaseRecord)
- [Contract_DuplicateMatchingRecord](#BKMK_Contract_DuplicateMatchingRecord)
- [Contract_DuplicateBaseRecord](#BKMK_Contract_DuplicateBaseRecord)
- [Equipment_DuplicateMatchingRecord](#BKMK_Equipment_DuplicateMatchingRecord)
- [Equipment_DuplicateBaseRecord](#BKMK_Equipment_DuplicateBaseRecord)
- [Incident_DuplicateMatchingRecord](#BKMK_Incident_DuplicateMatchingRecord)
- [Incident_DuplicateBaseRecord](#BKMK_Incident_DuplicateBaseRecord)
- [entitlement_DuplicateBaseRecord](#BKMK_entitlement_DuplicateBaseRecord)
- [entitlement_DuplicateMatchingRecord](#BKMK_entitlement_DuplicateMatchingRecord)
- [entitlementchannel_DuplicateBaseRecord](#BKMK_entitlementchannel_DuplicateBaseRecord)
- [entitlementchannel_DuplicateMatchingRecord](#BKMK_entitlementchannel_DuplicateMatchingRecord)
- [entitlementtemplate_DuplicateMatchingRecord](#BKMK_entitlementtemplate_DuplicateMatchingRecord)
- [entitlementtemplate_DuplicateBaseRecord](#BKMK_entitlementtemplate_DuplicateBaseRecord)
- [ResourceGroup_DuplicateBaseRecord](#BKMK_ResourceGroup_DuplicateBaseRecord)
- [ResourceGroup_DuplicateMatchingRecord](#BKMK_ResourceGroup_DuplicateMatchingRecord)
- [Service_DuplicateBaseRecord](#BKMK_Service_DuplicateBaseRecord)
- [Service_DuplicateMatchingRecord](#BKMK_Service_DuplicateMatchingRecord)
- [Opportunity_DuplicateMatchingRecord](#BKMK_Opportunity_DuplicateMatchingRecord)
- [Opportunity_DuplicateBaseRecord](#BKMK_Opportunity_DuplicateBaseRecord)
- [Quote_DuplicateMatchingRecord](#BKMK_Quote_DuplicateMatchingRecord)
- [Quote_DuplicateBaseRecord](#BKMK_Quote_DuplicateBaseRecord)
- [Competitor_DuplicateMatchingRecord](#BKMK_Competitor_DuplicateMatchingRecord)
- [Competitor_DuplicateBaseRecord](#BKMK_Competitor_DuplicateBaseRecord)
- [Territory_DuplicateBaseRecord](#BKMK_Territory_DuplicateBaseRecord)
- [Territory_DuplicateMatchingRecord](#BKMK_Territory_DuplicateMatchingRecord)
- [msdyn_postalbum_DuplicateMatchingRecord](#BKMK_msdyn_postalbum_DuplicateMatchingRecord)
- [msdyn_postalbum_DuplicateBaseRecord](#BKMK_msdyn_postalbum_DuplicateBaseRecord)
- [msdyn_actual_DuplicateMatchingRecord](#BKMK_msdyn_actual_DuplicateMatchingRecord)
- [msdyn_actual_DuplicateBaseRecord](#BKMK_msdyn_actual_DuplicateBaseRecord)
- [msdyn_bookingalert_DuplicateMatchingRecord](#BKMK_msdyn_bookingalert_DuplicateMatchingRecord)
- [msdyn_bookingalert_DuplicateBaseRecord](#BKMK_msdyn_bookingalert_DuplicateBaseRecord)
- [msdyn_bookingalertstatus_DuplicateMatchingRecord](#BKMK_msdyn_bookingalertstatus_DuplicateMatchingRecord)
- [msdyn_bookingalertstatus_DuplicateBaseRecord](#BKMK_msdyn_bookingalertstatus_DuplicateBaseRecord)
- [msdyn_bookingrule_DuplicateMatchingRecord](#BKMK_msdyn_bookingrule_DuplicateMatchingRecord)
- [msdyn_bookingrule_DuplicateBaseRecord](#BKMK_msdyn_bookingrule_DuplicateBaseRecord)
- [msdyn_clientextension_DuplicateMatchingRecord](#BKMK_msdyn_clientextension_DuplicateMatchingRecord)
- [msdyn_clientextension_DuplicateBaseRecord](#BKMK_msdyn_clientextension_DuplicateBaseRecord)
- [msdyn_organizationalunit_DuplicateMatchingRecord](#BKMK_msdyn_organizationalunit_DuplicateMatchingRecord)
- [msdyn_organizationalunit_DuplicateBaseRecord](#BKMK_msdyn_organizationalunit_DuplicateBaseRecord)
- [msdyn_priority_DuplicateMatchingRecord](#BKMK_msdyn_priority_DuplicateMatchingRecord)
- [msdyn_priority_DuplicateBaseRecord](#BKMK_msdyn_priority_DuplicateBaseRecord)
- [msdyn_requirementcharacteristic_DuplicateMatchingRecord](#BKMK_msdyn_requirementcharacteristic_DuplicateMatchingRecord)
- [msdyn_requirementcharacteristic_DuplicateBaseRecord](#BKMK_msdyn_requirementcharacteristic_DuplicateBaseRecord)
- [msdyn_requirementorganizationunit_DuplicateMatchingRecord](#BKMK_msdyn_requirementorganizationunit_DuplicateMatchingRecord)
- [msdyn_requirementorganizationunit_DuplicateBaseRecord](#BKMK_msdyn_requirementorganizationunit_DuplicateBaseRecord)
- [msdyn_requirementresourcecategory_DuplicateMatchingRecord](#BKMK_msdyn_requirementresourcecategory_DuplicateMatchingRecord)
- [msdyn_requirementresourcecategory_DuplicateBaseRecord](#BKMK_msdyn_requirementresourcecategory_DuplicateBaseRecord)
- [msdyn_requirementresourcepreference_DuplicateMatchingRecord](#BKMK_msdyn_requirementresourcepreference_DuplicateMatchingRecord)
- [msdyn_requirementresourcepreference_DuplicateBaseRecord](#BKMK_msdyn_requirementresourcepreference_DuplicateBaseRecord)
- [msdyn_requirementstatus_DuplicateMatchingRecord](#BKMK_msdyn_requirementstatus_DuplicateMatchingRecord)
- [msdyn_requirementstatus_DuplicateBaseRecord](#BKMK_msdyn_requirementstatus_DuplicateBaseRecord)
- [msdyn_resourcerequirement_DuplicateMatchingRecord](#BKMK_msdyn_resourcerequirement_DuplicateMatchingRecord)
- [msdyn_resourcerequirement_DuplicateBaseRecord](#BKMK_msdyn_resourcerequirement_DuplicateBaseRecord)
- [msdyn_resourcerequirementdetail_DuplicateMatchingRecord](#BKMK_msdyn_resourcerequirementdetail_DuplicateMatchingRecord)
- [msdyn_resourcerequirementdetail_DuplicateBaseRecord](#BKMK_msdyn_resourcerequirementdetail_DuplicateBaseRecord)
- [msdyn_resourceterritory_DuplicateMatchingRecord](#BKMK_msdyn_resourceterritory_DuplicateMatchingRecord)
- [msdyn_resourceterritory_DuplicateBaseRecord](#BKMK_msdyn_resourceterritory_DuplicateBaseRecord)
- [msdyn_scheduleboardsetting_DuplicateMatchingRecord](#BKMK_msdyn_scheduleboardsetting_DuplicateMatchingRecord)
- [msdyn_scheduleboardsetting_DuplicateBaseRecord](#BKMK_msdyn_scheduleboardsetting_DuplicateBaseRecord)
- [msdyn_systemuserschedulersetting_DuplicateMatchingRecord](#BKMK_msdyn_systemuserschedulersetting_DuplicateMatchingRecord)
- [msdyn_systemuserschedulersetting_DuplicateBaseRecord](#BKMK_msdyn_systemuserschedulersetting_DuplicateBaseRecord)
- [msdyn_timegroup_DuplicateMatchingRecord](#BKMK_msdyn_timegroup_DuplicateMatchingRecord)
- [msdyn_timegroup_DuplicateBaseRecord](#BKMK_msdyn_timegroup_DuplicateBaseRecord)
- [msdyn_timegroupdetail_DuplicateMatchingRecord](#BKMK_msdyn_timegroupdetail_DuplicateMatchingRecord)
- [msdyn_timegroupdetail_DuplicateBaseRecord](#BKMK_msdyn_timegroupdetail_DuplicateBaseRecord)
- [msdyn_transactionorigin_DuplicateMatchingRecord](#BKMK_msdyn_transactionorigin_DuplicateMatchingRecord)
- [msdyn_transactionorigin_DuplicateBaseRecord](#BKMK_msdyn_transactionorigin_DuplicateBaseRecord)
- [msdyn_workhourtemplate_DuplicateMatchingRecord](#BKMK_msdyn_workhourtemplate_DuplicateMatchingRecord)
- [msdyn_workhourtemplate_DuplicateBaseRecord](#BKMK_msdyn_workhourtemplate_DuplicateBaseRecord)
- [msdyn_accountpricelist_DuplicateMatchingRecord](#BKMK_msdyn_accountpricelist_DuplicateMatchingRecord)
- [msdyn_accountpricelist_DuplicateBaseRecord](#BKMK_msdyn_accountpricelist_DuplicateBaseRecord)
- [msdyn_approval_DuplicateMatchingRecord](#BKMK_msdyn_approval_DuplicateMatchingRecord)
- [msdyn_approval_DuplicateBaseRecord](#BKMK_msdyn_approval_DuplicateBaseRecord)
- [msdyn_batchjob_DuplicateMatchingRecord](#BKMK_msdyn_batchjob_DuplicateMatchingRecord)
- [msdyn_batchjob_DuplicateBaseRecord](#BKMK_msdyn_batchjob_DuplicateBaseRecord)
- [msdyn_characteristicreqforteammember_DuplicateMatchingRecord](#BKMK_msdyn_characteristicreqforteammember_DuplicateMatchingRecord)
- [msdyn_characteristicreqforteammember_DuplicateBaseRecord](#BKMK_msdyn_characteristicreqforteammember_DuplicateBaseRecord)
- [msdyn_contactpricelist_DuplicateMatchingRecord](#BKMK_msdyn_contactpricelist_DuplicateMatchingRecord)
- [msdyn_contactpricelist_DuplicateBaseRecord](#BKMK_msdyn_contactpricelist_DuplicateBaseRecord)
- [msdyn_contractlineinvoiceschedule_DuplicateMatchingRecord](#BKMK_msdyn_contractlineinvoiceschedule_DuplicateMatchingRecord)
- [msdyn_contractlineinvoiceschedule_DuplicateBaseRecord](#BKMK_msdyn_contractlineinvoiceschedule_DuplicateBaseRecord)
- [msdyn_contractlinescheduleofvalue_DuplicateMatchingRecord](#BKMK_msdyn_contractlinescheduleofvalue_DuplicateMatchingRecord)
- [msdyn_contractlinescheduleofvalue_DuplicateBaseRecord](#BKMK_msdyn_contractlinescheduleofvalue_DuplicateBaseRecord)
- [msdyn_dataexport_DuplicateMatchingRecord](#BKMK_msdyn_dataexport_DuplicateMatchingRecord)
- [msdyn_dataexport_DuplicateBaseRecord](#BKMK_msdyn_dataexport_DuplicateBaseRecord)
- [msdyn_delegation_DuplicateMatchingRecord](#BKMK_msdyn_delegation_DuplicateMatchingRecord)
- [msdyn_delegation_DuplicateBaseRecord](#BKMK_msdyn_delegation_DuplicateBaseRecord)
- [msdyn_estimate_DuplicateMatchingRecord](#BKMK_msdyn_estimate_DuplicateMatchingRecord)
- [msdyn_estimate_DuplicateBaseRecord](#BKMK_msdyn_estimate_DuplicateBaseRecord)
- [msdyn_estimateline_DuplicateMatchingRecord](#BKMK_msdyn_estimateline_DuplicateMatchingRecord)
- [msdyn_estimateline_DuplicateBaseRecord](#BKMK_msdyn_estimateline_DuplicateBaseRecord)
- [msdyn_expense_DuplicateMatchingRecord](#BKMK_msdyn_expense_DuplicateMatchingRecord)
- [msdyn_expense_DuplicateBaseRecord](#BKMK_msdyn_expense_DuplicateBaseRecord)
- [msdyn_expensecategory_DuplicateMatchingRecord](#BKMK_msdyn_expensecategory_DuplicateMatchingRecord)
- [msdyn_expensecategory_DuplicateBaseRecord](#BKMK_msdyn_expensecategory_DuplicateBaseRecord)
- [msdyn_fact_DuplicateMatchingRecord](#BKMK_msdyn_fact_DuplicateMatchingRecord)
- [msdyn_fact_DuplicateBaseRecord](#BKMK_msdyn_fact_DuplicateBaseRecord)
- [msdyn_fieldcomputation_DuplicateMatchingRecord](#BKMK_msdyn_fieldcomputation_DuplicateMatchingRecord)
- [msdyn_fieldcomputation_DuplicateBaseRecord](#BKMK_msdyn_fieldcomputation_DuplicateBaseRecord)
- [msdyn_findworkevent_DuplicateMatchingRecord](#BKMK_msdyn_findworkevent_DuplicateMatchingRecord)
- [msdyn_findworkevent_DuplicateBaseRecord](#BKMK_msdyn_findworkevent_DuplicateBaseRecord)
- [msdyn_invoicefrequency_DuplicateMatchingRecord](#BKMK_msdyn_invoicefrequency_DuplicateMatchingRecord)
- [msdyn_invoicefrequency_DuplicateBaseRecord](#BKMK_msdyn_invoicefrequency_DuplicateBaseRecord)
- [msdyn_invoicefrequencydetail_DuplicateMatchingRecord](#BKMK_msdyn_invoicefrequencydetail_DuplicateMatchingRecord)
- [msdyn_invoicefrequencydetail_DuplicateBaseRecord](#BKMK_msdyn_invoicefrequencydetail_DuplicateBaseRecord)
- [msdyn_invoicelinetransaction_DuplicateMatchingRecord](#BKMK_msdyn_invoicelinetransaction_DuplicateMatchingRecord)
- [msdyn_invoicelinetransaction_DuplicateBaseRecord](#BKMK_msdyn_invoicelinetransaction_DuplicateBaseRecord)
- [msdyn_journal_DuplicateMatchingRecord](#BKMK_msdyn_journal_DuplicateMatchingRecord)
- [msdyn_journal_DuplicateBaseRecord](#BKMK_msdyn_journal_DuplicateBaseRecord)
- [msdyn_journalline_DuplicateMatchingRecord](#BKMK_msdyn_journalline_DuplicateMatchingRecord)
- [msdyn_journalline_DuplicateBaseRecord](#BKMK_msdyn_journalline_DuplicateBaseRecord)
- [msdyn_opportunitylineresourcecategory_DuplicateMatchingRecord](#BKMK_msdyn_opportunitylineresourcecategory_DuplicateMatchingRecord)
- [msdyn_opportunitylineresourcecategory_DuplicateBaseRecord](#BKMK_msdyn_opportunitylineresourcecategory_DuplicateBaseRecord)
- [msdyn_opportunitylinetransaction_DuplicateMatchingRecord](#BKMK_msdyn_opportunitylinetransaction_DuplicateMatchingRecord)
- [msdyn_opportunitylinetransaction_DuplicateBaseRecord](#BKMK_msdyn_opportunitylinetransaction_DuplicateBaseRecord)
- [msdyn_opportunitylinetransactioncategory_DuplicateMatchingRecord](#BKMK_msdyn_opportunitylinetransactioncategory_DuplicateMatchingRecord)
- [msdyn_opportunitylinetransactioncategory_DuplicateBaseRecord](#BKMK_msdyn_opportunitylinetransactioncategory_DuplicateBaseRecord)
- [msdyn_opportunitylinetransactionclassificatio_DuplicateMatchingRecord](#BKMK_msdyn_opportunitylinetransactionclassificatio_DuplicateMatchingRecord)
- [msdyn_opportunitylinetransactionclassificatio_DuplicateBaseRecord](#BKMK_msdyn_opportunitylinetransactionclassificatio_DuplicateBaseRecord)
- [msdyn_opportunitypricelist_DuplicateMatchingRecord](#BKMK_msdyn_opportunitypricelist_DuplicateMatchingRecord)
- [msdyn_opportunitypricelist_DuplicateBaseRecord](#BKMK_msdyn_opportunitypricelist_DuplicateBaseRecord)
- [msdyn_orderlineresourcecategory_DuplicateMatchingRecord](#BKMK_msdyn_orderlineresourcecategory_DuplicateMatchingRecord)
- [msdyn_orderlineresourcecategory_DuplicateBaseRecord](#BKMK_msdyn_orderlineresourcecategory_DuplicateBaseRecord)
- [msdyn_orderlinetransaction_DuplicateMatchingRecord](#BKMK_msdyn_orderlinetransaction_DuplicateMatchingRecord)
- [msdyn_orderlinetransaction_DuplicateBaseRecord](#BKMK_msdyn_orderlinetransaction_DuplicateBaseRecord)
- [msdyn_orderlinetransactioncategory_DuplicateMatchingRecord](#BKMK_msdyn_orderlinetransactioncategory_DuplicateMatchingRecord)
- [msdyn_orderlinetransactioncategory_DuplicateBaseRecord](#BKMK_msdyn_orderlinetransactioncategory_DuplicateBaseRecord)
- [msdyn_orderlinetransactionclassification_DuplicateMatchingRecord](#BKMK_msdyn_orderlinetransactionclassification_DuplicateMatchingRecord)
- [msdyn_orderlinetransactionclassification_DuplicateBaseRecord](#BKMK_msdyn_orderlinetransactionclassification_DuplicateBaseRecord)
- [msdyn_orderpricelist_DuplicateMatchingRecord](#BKMK_msdyn_orderpricelist_DuplicateMatchingRecord)
- [msdyn_orderpricelist_DuplicateBaseRecord](#BKMK_msdyn_orderpricelist_DuplicateBaseRecord)
- [msdyn_processnotes_DuplicateMatchingRecord](#BKMK_msdyn_processnotes_DuplicateMatchingRecord)
- [msdyn_processnotes_DuplicateBaseRecord](#BKMK_msdyn_processnotes_DuplicateBaseRecord)
- [msdyn_project_DuplicateMatchingRecord](#BKMK_msdyn_project_DuplicateMatchingRecord)
- [msdyn_project_DuplicateBaseRecord](#BKMK_msdyn_project_DuplicateBaseRecord)
- [msdyn_projectapproval_DuplicateMatchingRecord](#BKMK_msdyn_projectapproval_DuplicateMatchingRecord)
- [msdyn_projectapproval_DuplicateBaseRecord](#BKMK_msdyn_projectapproval_DuplicateBaseRecord)
- [msdyn_projectparameter_DuplicateMatchingRecord](#BKMK_msdyn_projectparameter_DuplicateMatchingRecord)
- [msdyn_projectparameter_DuplicateBaseRecord](#BKMK_msdyn_projectparameter_DuplicateBaseRecord)
- [msdyn_projectparameterpricelist_DuplicateMatchingRecord](#BKMK_msdyn_projectparameterpricelist_DuplicateMatchingRecord)
- [msdyn_projectparameterpricelist_DuplicateBaseRecord](#BKMK_msdyn_projectparameterpricelist_DuplicateBaseRecord)
- [msdyn_projectpricelist_DuplicateMatchingRecord](#BKMK_msdyn_projectpricelist_DuplicateMatchingRecord)
- [msdyn_projectpricelist_DuplicateBaseRecord](#BKMK_msdyn_projectpricelist_DuplicateBaseRecord)
- [msdyn_projecttask_DuplicateMatchingRecord](#BKMK_msdyn_projecttask_DuplicateMatchingRecord)
- [msdyn_projecttask_DuplicateBaseRecord](#BKMK_msdyn_projecttask_DuplicateBaseRecord)
- [msdyn_projecttaskdependency_DuplicateMatchingRecord](#BKMK_msdyn_projecttaskdependency_DuplicateMatchingRecord)
- [msdyn_projecttaskdependency_DuplicateBaseRecord](#BKMK_msdyn_projecttaskdependency_DuplicateBaseRecord)
- [msdyn_projecttaskstatususer_DuplicateMatchingRecord](#BKMK_msdyn_projecttaskstatususer_DuplicateMatchingRecord)
- [msdyn_projecttaskstatususer_DuplicateBaseRecord](#BKMK_msdyn_projecttaskstatususer_DuplicateBaseRecord)
- [msdyn_projectteam_DuplicateMatchingRecord](#BKMK_msdyn_projectteam_DuplicateMatchingRecord)
- [msdyn_projectteam_DuplicateBaseRecord](#BKMK_msdyn_projectteam_DuplicateBaseRecord)
- [msdyn_projectteammembersignup_DuplicateMatchingRecord](#BKMK_msdyn_projectteammembersignup_DuplicateMatchingRecord)
- [msdyn_projectteammembersignup_DuplicateBaseRecord](#BKMK_msdyn_projectteammembersignup_DuplicateBaseRecord)
- [msdyn_projecttransactioncategory_DuplicateMatchingRecord](#BKMK_msdyn_projecttransactioncategory_DuplicateMatchingRecord)
- [msdyn_projecttransactioncategory_DuplicateBaseRecord](#BKMK_msdyn_projecttransactioncategory_DuplicateBaseRecord)
- [msdyn_quotelineanalyticsbreakdown_DuplicateMatchingRecord](#BKMK_msdyn_quotelineanalyticsbreakdown_DuplicateMatchingRecord)
- [msdyn_quotelineanalyticsbreakdown_DuplicateBaseRecord](#BKMK_msdyn_quotelineanalyticsbreakdown_DuplicateBaseRecord)
- [msdyn_quotelineinvoiceschedule_DuplicateMatchingRecord](#BKMK_msdyn_quotelineinvoiceschedule_DuplicateMatchingRecord)
- [msdyn_quotelineinvoiceschedule_DuplicateBaseRecord](#BKMK_msdyn_quotelineinvoiceschedule_DuplicateBaseRecord)
- [msdyn_quotelineresourcecategory_DuplicateMatchingRecord](#BKMK_msdyn_quotelineresourcecategory_DuplicateMatchingRecord)
- [msdyn_quotelineresourcecategory_DuplicateBaseRecord](#BKMK_msdyn_quotelineresourcecategory_DuplicateBaseRecord)
- [msdyn_quotelinescheduleofvalue_DuplicateMatchingRecord](#BKMK_msdyn_quotelinescheduleofvalue_DuplicateMatchingRecord)
- [msdyn_quotelinescheduleofvalue_DuplicateBaseRecord](#BKMK_msdyn_quotelinescheduleofvalue_DuplicateBaseRecord)
- [msdyn_quotelinetransaction_DuplicateMatchingRecord](#BKMK_msdyn_quotelinetransaction_DuplicateMatchingRecord)
- [msdyn_quotelinetransaction_DuplicateBaseRecord](#BKMK_msdyn_quotelinetransaction_DuplicateBaseRecord)
- [msdyn_quotelinetransactioncategory_DuplicateMatchingRecord](#BKMK_msdyn_quotelinetransactioncategory_DuplicateMatchingRecord)
- [msdyn_quotelinetransactioncategory_DuplicateBaseRecord](#BKMK_msdyn_quotelinetransactioncategory_DuplicateBaseRecord)
- [msdyn_quotelinetransactionclassification_DuplicateMatchingRecord](#BKMK_msdyn_quotelinetransactionclassification_DuplicateMatchingRecord)
- [msdyn_quotelinetransactionclassification_DuplicateBaseRecord](#BKMK_msdyn_quotelinetransactionclassification_DuplicateBaseRecord)
- [msdyn_quotepricelist_DuplicateMatchingRecord](#BKMK_msdyn_quotepricelist_DuplicateMatchingRecord)
- [msdyn_quotepricelist_DuplicateBaseRecord](#BKMK_msdyn_quotepricelist_DuplicateBaseRecord)
- [msdyn_resourceassignmentdetail_DuplicateMatchingRecord](#BKMK_msdyn_resourceassignmentdetail_DuplicateMatchingRecord)
- [msdyn_resourceassignmentdetail_DuplicateBaseRecord](#BKMK_msdyn_resourceassignmentdetail_DuplicateBaseRecord)
- [msdyn_resourcecategorypricelevel_DuplicateMatchingRecord](#BKMK_msdyn_resourcecategorypricelevel_DuplicateMatchingRecord)
- [msdyn_resourcecategorypricelevel_DuplicateBaseRecord](#BKMK_msdyn_resourcecategorypricelevel_DuplicateBaseRecord)
- [msdyn_resourcerequest_DuplicateMatchingRecord](#BKMK_msdyn_resourcerequest_DuplicateMatchingRecord)
- [msdyn_resourcerequest_DuplicateBaseRecord](#BKMK_msdyn_resourcerequest_DuplicateBaseRecord)
- [msdyn_rolecompetencyrequirement_DuplicateMatchingRecord](#BKMK_msdyn_rolecompetencyrequirement_DuplicateMatchingRecord)
- [msdyn_rolecompetencyrequirement_DuplicateBaseRecord](#BKMK_msdyn_rolecompetencyrequirement_DuplicateBaseRecord)
- [msdyn_roleutilization_DuplicateMatchingRecord](#BKMK_msdyn_roleutilization_DuplicateMatchingRecord)
- [msdyn_roleutilization_DuplicateBaseRecord](#BKMK_msdyn_roleutilization_DuplicateBaseRecord)
- [msdyn_timeoffcalendar_DuplicateMatchingRecord](#BKMK_msdyn_timeoffcalendar_DuplicateMatchingRecord)
- [msdyn_timeoffcalendar_DuplicateBaseRecord](#BKMK_msdyn_timeoffcalendar_DuplicateBaseRecord)
- [msdyn_transactioncategory_DuplicateMatchingRecord](#BKMK_msdyn_transactioncategory_DuplicateMatchingRecord)
- [msdyn_transactioncategory_DuplicateBaseRecord](#BKMK_msdyn_transactioncategory_DuplicateBaseRecord)
- [msdyn_transactioncategoryclassification_DuplicateMatchingRecord](#BKMK_msdyn_transactioncategoryclassification_DuplicateMatchingRecord)
- [msdyn_transactioncategoryclassification_DuplicateBaseRecord](#BKMK_msdyn_transactioncategoryclassification_DuplicateBaseRecord)
- [msdyn_transactioncategoryhierarchyelement_DuplicateMatchingRecord](#BKMK_msdyn_transactioncategoryhierarchyelement_DuplicateMatchingRecord)
- [msdyn_transactioncategoryhierarchyelement_DuplicateBaseRecord](#BKMK_msdyn_transactioncategoryhierarchyelement_DuplicateBaseRecord)
- [msdyn_transactioncategorypricelevel_DuplicateMatchingRecord](#BKMK_msdyn_transactioncategorypricelevel_DuplicateMatchingRecord)
- [msdyn_transactioncategorypricelevel_DuplicateBaseRecord](#BKMK_msdyn_transactioncategorypricelevel_DuplicateBaseRecord)
- [msdyn_transactionconnection_DuplicateMatchingRecord](#BKMK_msdyn_transactionconnection_DuplicateMatchingRecord)
- [msdyn_transactionconnection_DuplicateBaseRecord](#BKMK_msdyn_transactionconnection_DuplicateBaseRecord)
- [msdyn_transactiontype_DuplicateMatchingRecord](#BKMK_msdyn_transactiontype_DuplicateMatchingRecord)
- [msdyn_transactiontype_DuplicateBaseRecord](#BKMK_msdyn_transactiontype_DuplicateBaseRecord)
- [msdyn_userworkhistory_DuplicateMatchingRecord](#BKMK_msdyn_userworkhistory_DuplicateMatchingRecord)
- [msdyn_userworkhistory_DuplicateBaseRecord](#BKMK_msdyn_userworkhistory_DuplicateBaseRecord)
- [msdyn_agreement_DuplicateMatchingRecord](#BKMK_msdyn_agreement_DuplicateMatchingRecord)
- [msdyn_agreement_DuplicateBaseRecord](#BKMK_msdyn_agreement_DuplicateBaseRecord)
- [msdyn_agreementbookingdate_DuplicateMatchingRecord](#BKMK_msdyn_agreementbookingdate_DuplicateMatchingRecord)
- [msdyn_agreementbookingdate_DuplicateBaseRecord](#BKMK_msdyn_agreementbookingdate_DuplicateBaseRecord)
- [msdyn_agreementbookingincident_DuplicateMatchingRecord](#BKMK_msdyn_agreementbookingincident_DuplicateMatchingRecord)
- [msdyn_agreementbookingincident_DuplicateBaseRecord](#BKMK_msdyn_agreementbookingincident_DuplicateBaseRecord)
- [msdyn_agreementbookingproduct_DuplicateMatchingRecord](#BKMK_msdyn_agreementbookingproduct_DuplicateMatchingRecord)
- [msdyn_agreementbookingproduct_DuplicateBaseRecord](#BKMK_msdyn_agreementbookingproduct_DuplicateBaseRecord)
- [msdyn_agreementbookingservice_DuplicateMatchingRecord](#BKMK_msdyn_agreementbookingservice_DuplicateMatchingRecord)
- [msdyn_agreementbookingservice_DuplicateBaseRecord](#BKMK_msdyn_agreementbookingservice_DuplicateBaseRecord)
- [msdyn_agreementbookingservicetask_DuplicateMatchingRecord](#BKMK_msdyn_agreementbookingservicetask_DuplicateMatchingRecord)
- [msdyn_agreementbookingservicetask_DuplicateBaseRecord](#BKMK_msdyn_agreementbookingservicetask_DuplicateBaseRecord)
- [msdyn_agreementbookingsetup_DuplicateMatchingRecord](#BKMK_msdyn_agreementbookingsetup_DuplicateMatchingRecord)
- [msdyn_agreementbookingsetup_DuplicateBaseRecord](#BKMK_msdyn_agreementbookingsetup_DuplicateBaseRecord)
- [msdyn_agreementinvoicedate_DuplicateMatchingRecord](#BKMK_msdyn_agreementinvoicedate_DuplicateMatchingRecord)
- [msdyn_agreementinvoicedate_DuplicateBaseRecord](#BKMK_msdyn_agreementinvoicedate_DuplicateBaseRecord)
- [msdyn_agreementinvoiceproduct_DuplicateMatchingRecord](#BKMK_msdyn_agreementinvoiceproduct_DuplicateMatchingRecord)
- [msdyn_agreementinvoiceproduct_DuplicateBaseRecord](#BKMK_msdyn_agreementinvoiceproduct_DuplicateBaseRecord)
- [msdyn_agreementinvoicesetup_DuplicateMatchingRecord](#BKMK_msdyn_agreementinvoicesetup_DuplicateMatchingRecord)
- [msdyn_agreementinvoicesetup_DuplicateBaseRecord](#BKMK_msdyn_agreementinvoicesetup_DuplicateBaseRecord)
- [msdyn_agreementsubstatus_DuplicateMatchingRecord](#BKMK_msdyn_agreementsubstatus_DuplicateMatchingRecord)
- [msdyn_agreementsubstatus_DuplicateBaseRecord](#BKMK_msdyn_agreementsubstatus_DuplicateBaseRecord)
- [msdyn_bookingtimestamp_DuplicateMatchingRecord](#BKMK_msdyn_bookingtimestamp_DuplicateMatchingRecord)
- [msdyn_bookingtimestamp_DuplicateBaseRecord](#BKMK_msdyn_bookingtimestamp_DuplicateBaseRecord)
- [msdyn_customerasset_DuplicateMatchingRecord](#BKMK_msdyn_customerasset_DuplicateMatchingRecord)
- [msdyn_customerasset_DuplicateBaseRecord](#BKMK_msdyn_customerasset_DuplicateBaseRecord)
- [msdyn_fieldservicepricelistitem_DuplicateMatchingRecord](#BKMK_msdyn_fieldservicepricelistitem_DuplicateMatchingRecord)
- [msdyn_fieldservicepricelistitem_DuplicateBaseRecord](#BKMK_msdyn_fieldservicepricelistitem_DuplicateBaseRecord)
- [msdyn_incidenttype_DuplicateMatchingRecord](#BKMK_msdyn_incidenttype_DuplicateMatchingRecord)
- [msdyn_incidenttype_DuplicateBaseRecord](#BKMK_msdyn_incidenttype_DuplicateBaseRecord)
- [msdyn_incidenttypecharacteristic_DuplicateMatchingRecord](#BKMK_msdyn_incidenttypecharacteristic_DuplicateMatchingRecord)
- [msdyn_incidenttypecharacteristic_DuplicateBaseRecord](#BKMK_msdyn_incidenttypecharacteristic_DuplicateBaseRecord)
- [msdyn_incidenttypeproduct_DuplicateMatchingRecord](#BKMK_msdyn_incidenttypeproduct_DuplicateMatchingRecord)
- [msdyn_incidenttypeproduct_DuplicateBaseRecord](#BKMK_msdyn_incidenttypeproduct_DuplicateBaseRecord)
- [msdyn_incidenttypeservice_DuplicateMatchingRecord](#BKMK_msdyn_incidenttypeservice_DuplicateMatchingRecord)
- [msdyn_incidenttypeservice_DuplicateBaseRecord](#BKMK_msdyn_incidenttypeservice_DuplicateBaseRecord)
- [msdyn_incidenttypeservicetask_DuplicateMatchingRecord](#BKMK_msdyn_incidenttypeservicetask_DuplicateMatchingRecord)
- [msdyn_incidenttypeservicetask_DuplicateBaseRecord](#BKMK_msdyn_incidenttypeservicetask_DuplicateBaseRecord)
- [msdyn_inventoryadjustment_DuplicateMatchingRecord](#BKMK_msdyn_inventoryadjustment_DuplicateMatchingRecord)
- [msdyn_inventoryadjustment_DuplicateBaseRecord](#BKMK_msdyn_inventoryadjustment_DuplicateBaseRecord)
- [msdyn_inventoryadjustmentproduct_DuplicateMatchingRecord](#BKMK_msdyn_inventoryadjustmentproduct_DuplicateMatchingRecord)
- [msdyn_inventoryadjustmentproduct_DuplicateBaseRecord](#BKMK_msdyn_inventoryadjustmentproduct_DuplicateBaseRecord)
- [msdyn_inventoryjournal_DuplicateMatchingRecord](#BKMK_msdyn_inventoryjournal_DuplicateMatchingRecord)
- [msdyn_inventoryjournal_DuplicateBaseRecord](#BKMK_msdyn_inventoryjournal_DuplicateBaseRecord)
- [msdyn_inventorytransfer_DuplicateMatchingRecord](#BKMK_msdyn_inventorytransfer_DuplicateMatchingRecord)
- [msdyn_inventorytransfer_DuplicateBaseRecord](#BKMK_msdyn_inventorytransfer_DuplicateBaseRecord)
- [msdyn_orderinvoicingdate_DuplicateMatchingRecord](#BKMK_msdyn_orderinvoicingdate_DuplicateMatchingRecord)
- [msdyn_orderinvoicingdate_DuplicateBaseRecord](#BKMK_msdyn_orderinvoicingdate_DuplicateBaseRecord)
- [msdyn_orderinvoicingproduct_DuplicateMatchingRecord](#BKMK_msdyn_orderinvoicingproduct_DuplicateMatchingRecord)
- [msdyn_orderinvoicingproduct_DuplicateBaseRecord](#BKMK_msdyn_orderinvoicingproduct_DuplicateBaseRecord)
- [msdyn_orderinvoicingsetup_DuplicateMatchingRecord](#BKMK_msdyn_orderinvoicingsetup_DuplicateMatchingRecord)
- [msdyn_orderinvoicingsetup_DuplicateBaseRecord](#BKMK_msdyn_orderinvoicingsetup_DuplicateBaseRecord)
- [msdyn_orderinvoicingsetupdate_DuplicateMatchingRecord](#BKMK_msdyn_orderinvoicingsetupdate_DuplicateMatchingRecord)
- [msdyn_orderinvoicingsetupdate_DuplicateBaseRecord](#BKMK_msdyn_orderinvoicingsetupdate_DuplicateBaseRecord)
- [msdyn_payment_DuplicateMatchingRecord](#BKMK_msdyn_payment_DuplicateMatchingRecord)
- [msdyn_payment_DuplicateBaseRecord](#BKMK_msdyn_payment_DuplicateBaseRecord)
- [msdyn_paymentdetail_DuplicateMatchingRecord](#BKMK_msdyn_paymentdetail_DuplicateMatchingRecord)
- [msdyn_paymentdetail_DuplicateBaseRecord](#BKMK_msdyn_paymentdetail_DuplicateBaseRecord)
- [msdyn_paymentmethod_DuplicateMatchingRecord](#BKMK_msdyn_paymentmethod_DuplicateMatchingRecord)
- [msdyn_paymentmethod_DuplicateBaseRecord](#BKMK_msdyn_paymentmethod_DuplicateBaseRecord)
- [msdyn_paymentterm_DuplicateMatchingRecord](#BKMK_msdyn_paymentterm_DuplicateMatchingRecord)
- [msdyn_paymentterm_DuplicateBaseRecord](#BKMK_msdyn_paymentterm_DuplicateBaseRecord)
- [msdyn_postalcode_DuplicateMatchingRecord](#BKMK_msdyn_postalcode_DuplicateMatchingRecord)
- [msdyn_postalcode_DuplicateBaseRecord](#BKMK_msdyn_postalcode_DuplicateBaseRecord)
- [msdyn_productinventory_DuplicateMatchingRecord](#BKMK_msdyn_productinventory_DuplicateMatchingRecord)
- [msdyn_productinventory_DuplicateBaseRecord](#BKMK_msdyn_productinventory_DuplicateBaseRecord)
- [msdyn_purchaseorder_DuplicateMatchingRecord](#BKMK_msdyn_purchaseorder_DuplicateMatchingRecord)
- [msdyn_purchaseorder_DuplicateBaseRecord](#BKMK_msdyn_purchaseorder_DuplicateBaseRecord)
- [msdyn_purchaseorderbill_DuplicateMatchingRecord](#BKMK_msdyn_purchaseorderbill_DuplicateMatchingRecord)
- [msdyn_purchaseorderbill_DuplicateBaseRecord](#BKMK_msdyn_purchaseorderbill_DuplicateBaseRecord)
- [msdyn_purchaseorderreceipt_DuplicateMatchingRecord](#BKMK_msdyn_purchaseorderreceipt_DuplicateMatchingRecord)
- [msdyn_purchaseorderreceipt_DuplicateBaseRecord](#BKMK_msdyn_purchaseorderreceipt_DuplicateBaseRecord)
- [msdyn_purchaseorderreceiptproduct_DuplicateMatchingRecord](#BKMK_msdyn_purchaseorderreceiptproduct_DuplicateMatchingRecord)
- [msdyn_purchaseorderreceiptproduct_DuplicateBaseRecord](#BKMK_msdyn_purchaseorderreceiptproduct_DuplicateBaseRecord)
- [msdyn_purchaseordersubstatus_DuplicateMatchingRecord](#BKMK_msdyn_purchaseordersubstatus_DuplicateMatchingRecord)
- [msdyn_purchaseordersubstatus_DuplicateBaseRecord](#BKMK_msdyn_purchaseordersubstatus_DuplicateBaseRecord)
- [msdyn_quotebookingincident_DuplicateMatchingRecord](#BKMK_msdyn_quotebookingincident_DuplicateMatchingRecord)
- [msdyn_quotebookingincident_DuplicateBaseRecord](#BKMK_msdyn_quotebookingincident_DuplicateBaseRecord)
- [msdyn_quotebookingproduct_DuplicateMatchingRecord](#BKMK_msdyn_quotebookingproduct_DuplicateMatchingRecord)
- [msdyn_quotebookingproduct_DuplicateBaseRecord](#BKMK_msdyn_quotebookingproduct_DuplicateBaseRecord)
- [msdyn_quotebookingservice_DuplicateMatchingRecord](#BKMK_msdyn_quotebookingservice_DuplicateMatchingRecord)
- [msdyn_quotebookingservice_DuplicateBaseRecord](#BKMK_msdyn_quotebookingservice_DuplicateBaseRecord)
- [msdyn_quotebookingservicetask_DuplicateMatchingRecord](#BKMK_msdyn_quotebookingservicetask_DuplicateMatchingRecord)
- [msdyn_quotebookingservicetask_DuplicateBaseRecord](#BKMK_msdyn_quotebookingservicetask_DuplicateBaseRecord)
- [msdyn_quotebookingsetup_DuplicateMatchingRecord](#BKMK_msdyn_quotebookingsetup_DuplicateMatchingRecord)
- [msdyn_quotebookingsetup_DuplicateBaseRecord](#BKMK_msdyn_quotebookingsetup_DuplicateBaseRecord)
- [msdyn_quoteinvoicingproduct_DuplicateMatchingRecord](#BKMK_msdyn_quoteinvoicingproduct_DuplicateMatchingRecord)
- [msdyn_quoteinvoicingproduct_DuplicateBaseRecord](#BKMK_msdyn_quoteinvoicingproduct_DuplicateBaseRecord)
- [msdyn_quoteinvoicingsetup_DuplicateMatchingRecord](#BKMK_msdyn_quoteinvoicingsetup_DuplicateMatchingRecord)
- [msdyn_quoteinvoicingsetup_DuplicateBaseRecord](#BKMK_msdyn_quoteinvoicingsetup_DuplicateBaseRecord)
- [msdyn_rma_DuplicateMatchingRecord](#BKMK_msdyn_rma_DuplicateMatchingRecord)
- [msdyn_rma_DuplicateBaseRecord](#BKMK_msdyn_rma_DuplicateBaseRecord)
- [msdyn_rmareceipt_DuplicateMatchingRecord](#BKMK_msdyn_rmareceipt_DuplicateMatchingRecord)
- [msdyn_rmareceipt_DuplicateBaseRecord](#BKMK_msdyn_rmareceipt_DuplicateBaseRecord)
- [msdyn_rmareceiptproduct_DuplicateMatchingRecord](#BKMK_msdyn_rmareceiptproduct_DuplicateMatchingRecord)
- [msdyn_rmareceiptproduct_DuplicateBaseRecord](#BKMK_msdyn_rmareceiptproduct_DuplicateBaseRecord)
- [msdyn_rmasubstatus_DuplicateMatchingRecord](#BKMK_msdyn_rmasubstatus_DuplicateMatchingRecord)
- [msdyn_rmasubstatus_DuplicateBaseRecord](#BKMK_msdyn_rmasubstatus_DuplicateBaseRecord)
- [msdyn_rtv_DuplicateMatchingRecord](#BKMK_msdyn_rtv_DuplicateMatchingRecord)
- [msdyn_rtv_DuplicateBaseRecord](#BKMK_msdyn_rtv_DuplicateBaseRecord)
- [msdyn_rtvproduct_DuplicateMatchingRecord](#BKMK_msdyn_rtvproduct_DuplicateMatchingRecord)
- [msdyn_rtvproduct_DuplicateBaseRecord](#BKMK_msdyn_rtvproduct_DuplicateBaseRecord)
- [msdyn_rtvsubstatus_DuplicateMatchingRecord](#BKMK_msdyn_rtvsubstatus_DuplicateMatchingRecord)
- [msdyn_rtvsubstatus_DuplicateBaseRecord](#BKMK_msdyn_rtvsubstatus_DuplicateBaseRecord)
- [msdyn_servicetasktype_DuplicateMatchingRecord](#BKMK_msdyn_servicetasktype_DuplicateMatchingRecord)
- [msdyn_servicetasktype_DuplicateBaseRecord](#BKMK_msdyn_servicetasktype_DuplicateBaseRecord)
- [msdyn_shipvia_DuplicateMatchingRecord](#BKMK_msdyn_shipvia_DuplicateMatchingRecord)
- [msdyn_shipvia_DuplicateBaseRecord](#BKMK_msdyn_shipvia_DuplicateBaseRecord)
- [msdyn_taxcode_DuplicateMatchingRecord](#BKMK_msdyn_taxcode_DuplicateMatchingRecord)
- [msdyn_taxcode_DuplicateBaseRecord](#BKMK_msdyn_taxcode_DuplicateBaseRecord)
- [msdyn_taxcodedetail_DuplicateMatchingRecord](#BKMK_msdyn_taxcodedetail_DuplicateMatchingRecord)
- [msdyn_taxcodedetail_DuplicateBaseRecord](#BKMK_msdyn_taxcodedetail_DuplicateBaseRecord)
- [msdyn_timeoffrequest_DuplicateMatchingRecord](#BKMK_msdyn_timeoffrequest_DuplicateMatchingRecord)
- [msdyn_timeoffrequest_DuplicateBaseRecord](#BKMK_msdyn_timeoffrequest_DuplicateBaseRecord)
- [msdyn_warehouse_DuplicateMatchingRecord](#BKMK_msdyn_warehouse_DuplicateMatchingRecord)
- [msdyn_warehouse_DuplicateBaseRecord](#BKMK_msdyn_warehouse_DuplicateBaseRecord)
- [msdyn_workorder_DuplicateMatchingRecord](#BKMK_msdyn_workorder_DuplicateMatchingRecord)
- [msdyn_workorder_DuplicateBaseRecord](#BKMK_msdyn_workorder_DuplicateBaseRecord)
- [msdyn_workordercharacteristic_DuplicateMatchingRecord](#BKMK_msdyn_workordercharacteristic_DuplicateMatchingRecord)
- [msdyn_workordercharacteristic_DuplicateBaseRecord](#BKMK_msdyn_workordercharacteristic_DuplicateBaseRecord)
- [msdyn_workorderdetailsgenerationqueue_DuplicateMatchingRecord](#BKMK_msdyn_workorderdetailsgenerationqueue_DuplicateMatchingRecord)
- [msdyn_workorderdetailsgenerationqueue_DuplicateBaseRecord](#BKMK_msdyn_workorderdetailsgenerationqueue_DuplicateBaseRecord)
- [msdyn_workorderincident_DuplicateMatchingRecord](#BKMK_msdyn_workorderincident_DuplicateMatchingRecord)
- [msdyn_workorderincident_DuplicateBaseRecord](#BKMK_msdyn_workorderincident_DuplicateBaseRecord)
- [msdyn_workorderresourcerestriction_DuplicateMatchingRecord](#BKMK_msdyn_workorderresourcerestriction_DuplicateMatchingRecord)
- [msdyn_workorderresourcerestriction_DuplicateBaseRecord](#BKMK_msdyn_workorderresourcerestriction_DuplicateBaseRecord)
- [msdyn_workorderservice_DuplicateMatchingRecord](#BKMK_msdyn_workorderservice_DuplicateMatchingRecord)
- [msdyn_workorderservice_DuplicateBaseRecord](#BKMK_msdyn_workorderservice_DuplicateBaseRecord)
- [msdyn_workorderservicetask_DuplicateMatchingRecord](#BKMK_msdyn_workorderservicetask_DuplicateMatchingRecord)
- [msdyn_workorderservicetask_DuplicateBaseRecord](#BKMK_msdyn_workorderservicetask_DuplicateBaseRecord)
- [msdyn_workordersubstatus_DuplicateMatchingRecord](#BKMK_msdyn_workordersubstatus_DuplicateMatchingRecord)
- [msdyn_workordersubstatus_DuplicateBaseRecord](#BKMK_msdyn_workordersubstatus_DuplicateBaseRecord)
- [msdyn_workordertype_DuplicateMatchingRecord](#BKMK_msdyn_workordertype_DuplicateMatchingRecord)
- [msdyn_workordertype_DuplicateBaseRecord](#BKMK_msdyn_workordertype_DuplicateBaseRecord)
- [knowledgearticle_DuplicateMatchingRecord](#BKMK_knowledgearticle_DuplicateMatchingRecord)
- [knowledgearticle_DuplicateBaseRecord](#BKMK_knowledgearticle_DuplicateBaseRecord)
- [channelaccessprofile_DuplicateMatchingRecord](#BKMK_channelaccessprofile_DuplicateMatchingRecord)
- [channelaccessprofile_DuplicateBaseRecord](#BKMK_channelaccessprofile_DuplicateBaseRecord)
- [KnowledgeBaseRecord_DuplicateMatchingRecord](#BKMK_KnowledgeBaseRecord_DuplicateMatchingRecord)
- [KnowledgeBaseRecord_DuplicateBaseRecord](#BKMK_KnowledgeBaseRecord_DuplicateBaseRecord)
- [Email_DuplicateMatchingRecord](#BKMK_Email_DuplicateMatchingRecord)
- [Publisher_DuplicateMatchingRecord](#BKMK_Publisher_DuplicateMatchingRecord)
- [Queue_DuplicateBaseRecord](#BKMK_Queue_DuplicateBaseRecord)
- [Letter_DuplicateBaseRecord](#BKMK_Letter_DuplicateBaseRecord)
- [Team_DuplicateBaseRecord](#BKMK_Team_DuplicateBaseRecord)
- [KbArticle_DuplicateMatchingRecord](#BKMK_KbArticle_DuplicateMatchingRecord)
- [Appointment_DuplicateBaseRecord](#BKMK_Appointment_DuplicateBaseRecord)
- [Account_DuplicateBaseRecord](#BKMK_Account_DuplicateBaseRecord)
- [DuplicateRule_DuplicateBaseRecord](#BKMK_DuplicateRule_DuplicateBaseRecord)
- [SharePointSite_DuplicateBaseRecord](#BKMK_SharePointSite_DuplicateBaseRecord)
- [KbArticle_DuplicateBaseRecord](#BKMK_KbArticle_DuplicateBaseRecord)
- [Task_DuplicateMatchingRecord](#BKMK_Task_DuplicateMatchingRecord)
- [SocialProfile_DuplicateMatchingRecord](#BKMK_SocialProfile_DuplicateMatchingRecord)
- [PhoneCall_DuplicateBaseRecord](#BKMK_PhoneCall_DuplicateBaseRecord)
- [TransactionCurrency_DuplicateMatchingRecord](#BKMK_TransactionCurrency_DuplicateMatchingRecord)
- [Goal_DuplicateMatchingRecord](#BKMK_Goal_DuplicateMatchingRecord)
- [SharePointSite_DuplicateMatchingRecord](#BKMK_SharePointSite_DuplicateMatchingRecord)
- [emailserverprofile_duplicatebaserecord](#BKMK_emailserverprofile_duplicatebaserecord)
- [Publisher_DuplicateBaseRecord](#BKMK_Publisher_DuplicateBaseRecord)
- [SystemUser_DuplicateBaseRecord](#BKMK_SystemUser_DuplicateBaseRecord)
- [SocialActivity_DuplicateBaseRecord](#BKMK_SocialActivity_DuplicateBaseRecord)
- [Contact_DuplicateMatchingRecord](#BKMK_Contact_DuplicateMatchingRecord)
- [GoalRollupQuery_DuplicateMatchingRecord](#BKMK_GoalRollupQuery_DuplicateMatchingRecord)
- [Contact_DuplicateBaseRecord](#BKMK_Contact_DuplicateBaseRecord)
- [TransactionCurrency_DuplicateBaseRecord](#BKMK_TransactionCurrency_DuplicateBaseRecord)
- [Email_DuplicateBaseRecord](#BKMK_Email_DuplicateBaseRecord)
- [PhoneCall_DuplicateMatchingRecord](#BKMK_PhoneCall_DuplicateMatchingRecord)
- [Team_DuplicateMatchingRecord](#BKMK_Team_DuplicateMatchingRecord)
- [SystemUser_DuplicateMatchingRecord](#BKMK_SystemUser_DuplicateMatchingRecord)
- [Appointment_DuplicateMatchingRecord](#BKMK_Appointment_DuplicateMatchingRecord)
- [Account_DuplicateMatchingRecord](#BKMK_Account_DuplicateMatchingRecord)
- [Fax_DuplicateBaseRecord](#BKMK_Fax_DuplicateBaseRecord)
- [Letter_DuplicateMatchingRecord](#BKMK_Letter_DuplicateMatchingRecord)
- [emailserverprofile_duplicatematchingrecord](#BKMK_emailserverprofile_duplicatematchingrecord)
- [SharePointDocumentLocation_DuplicateBaseRecord](#BKMK_SharePointDocumentLocation_DuplicateBaseRecord)
- [Goal_DuplicateBaseRecord](#BKMK_Goal_DuplicateBaseRecord)
- [RecurringAppointmentMaster_DuplicateMatchingRecord](#BKMK_RecurringAppointmentMaster_DuplicateMatchingRecord)
- [Task_DuplicateBaseRecord](#BKMK_Task_DuplicateBaseRecord)
- [RecurringAppointmentMaster_DuplicateBaseRecord](#BKMK_RecurringAppointmentMaster_DuplicateBaseRecord)
- [Queue_DuplicateMatchingRecord](#BKMK_Queue_DuplicateMatchingRecord)
- [SocialProfile_DuplicateBaseRecord](#BKMK_SocialProfile_DuplicateBaseRecord)
- [SharePointDocumentLocation_DuplicateMatchingRecord](#BKMK_SharePointDocumentLocation_DuplicateMatchingRecord)
- [GoalRollupQuery_DuplicateBaseRecord](#BKMK_GoalRollupQuery_DuplicateBaseRecord)
- [AsyncOperation_DuplicateBaseRecord](#BKMK_AsyncOperation_DuplicateBaseRecord)
- [Fax_DuplicateMatchingRecord](#BKMK_Fax_DuplicateMatchingRecord)
- [SocialActivity_DuplicateMatchingRecord](#BKMK_SocialActivity_DuplicateMatchingRecord)


### <a name="BKMK_msdyn_iotdevice_DuplicateMatchingRecord"></a> msdyn_iotdevice_DuplicateMatchingRecord

See msdyn_iotdevice Entity [msdyn_iotdevice_DuplicateMatchingRecord](msdyn_iotdevice.md#BKMK_msdyn_iotdevice_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdevice_DuplicateBaseRecord"></a> msdyn_iotdevice_DuplicateBaseRecord

See msdyn_iotdevice Entity [msdyn_iotdevice_DuplicateBaseRecord](msdyn_iotdevice.md#BKMK_msdyn_iotdevice_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdevicecategory_DuplicateMatchingRecord"></a> msdyn_iotdevicecategory_DuplicateMatchingRecord

See msdyn_iotdevicecategory Entity [msdyn_iotdevicecategory_DuplicateMatchingRecord](msdyn_iotdevicecategory.md#BKMK_msdyn_iotdevicecategory_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdevicecategory_DuplicateBaseRecord"></a> msdyn_iotdevicecategory_DuplicateBaseRecord

See msdyn_iotdevicecategory Entity [msdyn_iotdevicecategory_DuplicateBaseRecord](msdyn_iotdevicecategory.md#BKMK_msdyn_iotdevicecategory_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdevicecommand_DuplicateMatchingRecord"></a> msdyn_iotdevicecommand_DuplicateMatchingRecord

See msdyn_iotdevicecommand Entity [msdyn_iotdevicecommand_DuplicateMatchingRecord](msdyn_iotdevicecommand.md#BKMK_msdyn_iotdevicecommand_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdevicecommand_DuplicateBaseRecord"></a> msdyn_iotdevicecommand_DuplicateBaseRecord

See msdyn_iotdevicecommand Entity [msdyn_iotdevicecommand_DuplicateBaseRecord](msdyn_iotdevicecommand.md#BKMK_msdyn_iotdevicecommand_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdeviceregistrationhistory_DuplicateMatchingRecord"></a> msdyn_iotdeviceregistrationhistory_DuplicateMatchingRecord

See msdyn_iotdeviceregistrationhistory Entity [msdyn_iotdeviceregistrationhistory_DuplicateMatchingRecord](msdyn_iotdeviceregistrationhistory.md#BKMK_msdyn_iotdeviceregistrationhistory_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdeviceregistrationhistory_DuplicateBaseRecord"></a> msdyn_iotdeviceregistrationhistory_DuplicateBaseRecord

See msdyn_iotdeviceregistrationhistory Entity [msdyn_iotdeviceregistrationhistory_DuplicateBaseRecord](msdyn_iotdeviceregistrationhistory.md#BKMK_msdyn_iotdeviceregistrationhistory_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_Lead_DuplicateMatchingRecord"></a> Lead_DuplicateMatchingRecord

See lead Entity [Lead_DuplicateMatchingRecord](lead.md#BKMK_Lead_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_Lead_DuplicateBaseRecord"></a> Lead_DuplicateBaseRecord

See lead Entity [Lead_DuplicateBaseRecord](lead.md#BKMK_Lead_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_bookableresource_DuplicateMatchingRecord"></a> bookableresource_DuplicateMatchingRecord

See bookableresource Entity [bookableresource_DuplicateMatchingRecord](bookableresource.md#BKMK_bookableresource_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_bookableresource_DuplicateBaseRecord"></a> bookableresource_DuplicateBaseRecord

See bookableresource Entity [bookableresource_DuplicateBaseRecord](bookableresource.md#BKMK_bookableresource_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_bookableresourcebooking_DuplicateMatchingRecord"></a> bookableresourcebooking_DuplicateMatchingRecord

See bookableresourcebooking Entity [bookableresourcebooking_DuplicateMatchingRecord](bookableresourcebooking.md#BKMK_bookableresourcebooking_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_bookableresourcebooking_DuplicateBaseRecord"></a> bookableresourcebooking_DuplicateBaseRecord

See bookableresourcebooking Entity [bookableresourcebooking_DuplicateBaseRecord](bookableresourcebooking.md#BKMK_bookableresourcebooking_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_bookableresourcebookingheader_DuplicateMatchingRecord"></a> bookableresourcebookingheader_DuplicateMatchingRecord

See bookableresourcebookingheader Entity [bookableresourcebookingheader_DuplicateMatchingRecord](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_bookableresourcebookingheader_DuplicateBaseRecord"></a> bookableresourcebookingheader_DuplicateBaseRecord

See bookableresourcebookingheader Entity [bookableresourcebookingheader_DuplicateBaseRecord](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_bookableresourcecategory_DuplicateMatchingRecord"></a> bookableresourcecategory_DuplicateMatchingRecord

See bookableresourcecategory Entity [bookableresourcecategory_DuplicateMatchingRecord](bookableresourcecategory.md#BKMK_bookableresourcecategory_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_bookableresourcecategory_DuplicateBaseRecord"></a> bookableresourcecategory_DuplicateBaseRecord

See bookableresourcecategory Entity [bookableresourcecategory_DuplicateBaseRecord](bookableresourcecategory.md#BKMK_bookableresourcecategory_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_bookableresourcecategoryassn_DuplicateMatchingRecord"></a> bookableresourcecategoryassn_DuplicateMatchingRecord

See bookableresourcecategoryassn Entity [bookableresourcecategoryassn_DuplicateMatchingRecord](bookableresourcecategoryassn.md#BKMK_bookableresourcecategoryassn_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_bookableresourcecategoryassn_DuplicateBaseRecord"></a> bookableresourcecategoryassn_DuplicateBaseRecord

See bookableresourcecategoryassn Entity [bookableresourcecategoryassn_DuplicateBaseRecord](bookableresourcecategoryassn.md#BKMK_bookableresourcecategoryassn_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_bookableresourcecharacteristic_DuplicateMatchingRecord"></a> bookableresourcecharacteristic_DuplicateMatchingRecord

See bookableresourcecharacteristic Entity [bookableresourcecharacteristic_DuplicateMatchingRecord](bookableresourcecharacteristic.md#BKMK_bookableresourcecharacteristic_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_bookableresourcecharacteristic_DuplicateBaseRecord"></a> bookableresourcecharacteristic_DuplicateBaseRecord

See bookableresourcecharacteristic Entity [bookableresourcecharacteristic_DuplicateBaseRecord](bookableresourcecharacteristic.md#BKMK_bookableresourcecharacteristic_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_bookableresourcegroup_DuplicateMatchingRecord"></a> bookableresourcegroup_DuplicateMatchingRecord

See bookableresourcegroup Entity [bookableresourcegroup_DuplicateMatchingRecord](bookableresourcegroup.md#BKMK_bookableresourcegroup_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_bookableresourcegroup_DuplicateBaseRecord"></a> bookableresourcegroup_DuplicateBaseRecord

See bookableresourcegroup Entity [bookableresourcegroup_DuplicateBaseRecord](bookableresourcegroup.md#BKMK_bookableresourcegroup_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_bookingstatus_DuplicateMatchingRecord"></a> bookingstatus_DuplicateMatchingRecord

See bookingstatus Entity [bookingstatus_DuplicateMatchingRecord](bookingstatus.md#BKMK_bookingstatus_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_bookingstatus_DuplicateBaseRecord"></a> bookingstatus_DuplicateBaseRecord

See bookingstatus Entity [bookingstatus_DuplicateBaseRecord](bookingstatus.md#BKMK_bookingstatus_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_characteristic_DuplicateMatchingRecord"></a> characteristic_DuplicateMatchingRecord

See characteristic Entity [characteristic_DuplicateMatchingRecord](characteristic.md#BKMK_characteristic_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_characteristic_DuplicateBaseRecord"></a> characteristic_DuplicateBaseRecord

See characteristic Entity [characteristic_DuplicateBaseRecord](characteristic.md#BKMK_characteristic_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_ratingmodel_DuplicateMatchingRecord"></a> ratingmodel_DuplicateMatchingRecord

See ratingmodel Entity [ratingmodel_DuplicateMatchingRecord](ratingmodel.md#BKMK_ratingmodel_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_ratingmodel_DuplicateBaseRecord"></a> ratingmodel_DuplicateBaseRecord

See ratingmodel Entity [ratingmodel_DuplicateBaseRecord](ratingmodel.md#BKMK_ratingmodel_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_ratingvalue_DuplicateMatchingRecord"></a> ratingvalue_DuplicateMatchingRecord

See ratingvalue Entity [ratingvalue_DuplicateMatchingRecord](ratingvalue.md#BKMK_ratingvalue_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_ratingvalue_DuplicateBaseRecord"></a> ratingvalue_DuplicateBaseRecord

See ratingvalue Entity [ratingvalue_DuplicateBaseRecord](ratingvalue.md#BKMK_ratingvalue_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_Campaign_DuplicateMatchingRecord"></a> Campaign_DuplicateMatchingRecord

See campaign Entity [Campaign_DuplicateMatchingRecord](campaign.md#BKMK_Campaign_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_Campaign_DuplicateBaseRecord"></a> Campaign_DuplicateBaseRecord

See campaign Entity [Campaign_DuplicateBaseRecord](campaign.md#BKMK_Campaign_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_CampaignResponse_DuplicateMatchingRecord"></a> CampaignResponse_DuplicateMatchingRecord

See campaignresponse Entity [CampaignResponse_DuplicateMatchingRecord](campaignresponse.md#BKMK_CampaignResponse_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_CampaignResponse_DuplicateBaseRecord"></a> CampaignResponse_DuplicateBaseRecord

See campaignresponse Entity [CampaignResponse_DuplicateBaseRecord](campaignresponse.md#BKMK_CampaignResponse_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_List_DuplicateMatchingRecord"></a> List_DuplicateMatchingRecord

See list Entity [List_DuplicateMatchingRecord](list.md#BKMK_List_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_List_DuplicateBaseRecord"></a> List_DuplicateBaseRecord

See list Entity [List_DuplicateBaseRecord](list.md#BKMK_List_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_Contract_DuplicateMatchingRecord"></a> Contract_DuplicateMatchingRecord

See contract Entity [Contract_DuplicateMatchingRecord](contract.md#BKMK_Contract_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_Contract_DuplicateBaseRecord"></a> Contract_DuplicateBaseRecord

See contract Entity [Contract_DuplicateBaseRecord](contract.md#BKMK_Contract_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_Equipment_DuplicateMatchingRecord"></a> Equipment_DuplicateMatchingRecord

See equipment Entity [Equipment_DuplicateMatchingRecord](equipment.md#BKMK_Equipment_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_Equipment_DuplicateBaseRecord"></a> Equipment_DuplicateBaseRecord

See equipment Entity [Equipment_DuplicateBaseRecord](equipment.md#BKMK_Equipment_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_Incident_DuplicateMatchingRecord"></a> Incident_DuplicateMatchingRecord

See incident Entity [Incident_DuplicateMatchingRecord](incident.md#BKMK_Incident_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_Incident_DuplicateBaseRecord"></a> Incident_DuplicateBaseRecord

See incident Entity [Incident_DuplicateBaseRecord](incident.md#BKMK_Incident_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_entitlement_DuplicateBaseRecord"></a> entitlement_DuplicateBaseRecord

See entitlement Entity [entitlement_DuplicateBaseRecord](entitlement.md#BKMK_entitlement_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_entitlement_DuplicateMatchingRecord"></a> entitlement_DuplicateMatchingRecord

See entitlement Entity [entitlement_DuplicateMatchingRecord](entitlement.md#BKMK_entitlement_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_entitlementchannel_DuplicateBaseRecord"></a> entitlementchannel_DuplicateBaseRecord

See entitlementchannel Entity [entitlementchannel_DuplicateBaseRecord](entitlementchannel.md#BKMK_entitlementchannel_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_entitlementchannel_DuplicateMatchingRecord"></a> entitlementchannel_DuplicateMatchingRecord

See entitlementchannel Entity [entitlementchannel_DuplicateMatchingRecord](entitlementchannel.md#BKMK_entitlementchannel_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_entitlementtemplate_DuplicateMatchingRecord"></a> entitlementtemplate_DuplicateMatchingRecord

See entitlementtemplate Entity [entitlementtemplate_DuplicateMatchingRecord](entitlementtemplate.md#BKMK_entitlementtemplate_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_entitlementtemplate_DuplicateBaseRecord"></a> entitlementtemplate_DuplicateBaseRecord

See entitlementtemplate Entity [entitlementtemplate_DuplicateBaseRecord](entitlementtemplate.md#BKMK_entitlementtemplate_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_ResourceGroup_DuplicateBaseRecord"></a> ResourceGroup_DuplicateBaseRecord

See resourcegroup Entity [ResourceGroup_DuplicateBaseRecord](resourcegroup.md#BKMK_ResourceGroup_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_ResourceGroup_DuplicateMatchingRecord"></a> ResourceGroup_DuplicateMatchingRecord

See resourcegroup Entity [ResourceGroup_DuplicateMatchingRecord](resourcegroup.md#BKMK_ResourceGroup_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_Service_DuplicateBaseRecord"></a> Service_DuplicateBaseRecord

See service Entity [Service_DuplicateBaseRecord](service.md#BKMK_Service_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_Service_DuplicateMatchingRecord"></a> Service_DuplicateMatchingRecord

See service Entity [Service_DuplicateMatchingRecord](service.md#BKMK_Service_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_Opportunity_DuplicateMatchingRecord"></a> Opportunity_DuplicateMatchingRecord

See opportunity Entity [Opportunity_DuplicateMatchingRecord](opportunity.md#BKMK_Opportunity_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_Opportunity_DuplicateBaseRecord"></a> Opportunity_DuplicateBaseRecord

See opportunity Entity [Opportunity_DuplicateBaseRecord](opportunity.md#BKMK_Opportunity_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_Quote_DuplicateMatchingRecord"></a> Quote_DuplicateMatchingRecord

See quote Entity [Quote_DuplicateMatchingRecord](quote.md#BKMK_Quote_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_Quote_DuplicateBaseRecord"></a> Quote_DuplicateBaseRecord

See quote Entity [Quote_DuplicateBaseRecord](quote.md#BKMK_Quote_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_Competitor_DuplicateMatchingRecord"></a> Competitor_DuplicateMatchingRecord

See competitor Entity [Competitor_DuplicateMatchingRecord](competitor.md#BKMK_Competitor_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_Competitor_DuplicateBaseRecord"></a> Competitor_DuplicateBaseRecord

See competitor Entity [Competitor_DuplicateBaseRecord](competitor.md#BKMK_Competitor_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_Territory_DuplicateBaseRecord"></a> Territory_DuplicateBaseRecord

See territory Entity [Territory_DuplicateBaseRecord](territory.md#BKMK_Territory_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_Territory_DuplicateMatchingRecord"></a> Territory_DuplicateMatchingRecord

See territory Entity [Territory_DuplicateMatchingRecord](territory.md#BKMK_Territory_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_postalbum_DuplicateMatchingRecord"></a> msdyn_postalbum_DuplicateMatchingRecord

See msdyn_postalbum Entity [msdyn_postalbum_DuplicateMatchingRecord](msdyn_postalbum.md#BKMK_msdyn_postalbum_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_postalbum_DuplicateBaseRecord"></a> msdyn_postalbum_DuplicateBaseRecord

See msdyn_postalbum Entity [msdyn_postalbum_DuplicateBaseRecord](msdyn_postalbum.md#BKMK_msdyn_postalbum_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_actual_DuplicateMatchingRecord"></a> msdyn_actual_DuplicateMatchingRecord

See msdyn_actual Entity [msdyn_actual_DuplicateMatchingRecord](msdyn_actual.md#BKMK_msdyn_actual_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_actual_DuplicateBaseRecord"></a> msdyn_actual_DuplicateBaseRecord

See msdyn_actual Entity [msdyn_actual_DuplicateBaseRecord](msdyn_actual.md#BKMK_msdyn_actual_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalert_DuplicateMatchingRecord"></a> msdyn_bookingalert_DuplicateMatchingRecord

See msdyn_bookingalert Entity [msdyn_bookingalert_DuplicateMatchingRecord](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalert_DuplicateBaseRecord"></a> msdyn_bookingalert_DuplicateBaseRecord

See msdyn_bookingalert Entity [msdyn_bookingalert_DuplicateBaseRecord](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalertstatus_DuplicateMatchingRecord"></a> msdyn_bookingalertstatus_DuplicateMatchingRecord

See msdyn_bookingalertstatus Entity [msdyn_bookingalertstatus_DuplicateMatchingRecord](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalertstatus_DuplicateBaseRecord"></a> msdyn_bookingalertstatus_DuplicateBaseRecord

See msdyn_bookingalertstatus Entity [msdyn_bookingalertstatus_DuplicateBaseRecord](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingrule_DuplicateMatchingRecord"></a> msdyn_bookingrule_DuplicateMatchingRecord

See msdyn_bookingrule Entity [msdyn_bookingrule_DuplicateMatchingRecord](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingrule_DuplicateBaseRecord"></a> msdyn_bookingrule_DuplicateBaseRecord

See msdyn_bookingrule Entity [msdyn_bookingrule_DuplicateBaseRecord](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_clientextension_DuplicateMatchingRecord"></a> msdyn_clientextension_DuplicateMatchingRecord

See msdyn_clientextension Entity [msdyn_clientextension_DuplicateMatchingRecord](msdyn_clientextension.md#BKMK_msdyn_clientextension_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_clientextension_DuplicateBaseRecord"></a> msdyn_clientextension_DuplicateBaseRecord

See msdyn_clientextension Entity [msdyn_clientextension_DuplicateBaseRecord](msdyn_clientextension.md#BKMK_msdyn_clientextension_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_organizationalunit_DuplicateMatchingRecord"></a> msdyn_organizationalunit_DuplicateMatchingRecord

See msdyn_organizationalunit Entity [msdyn_organizationalunit_DuplicateMatchingRecord](msdyn_organizationalunit.md#BKMK_msdyn_organizationalunit_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_organizationalunit_DuplicateBaseRecord"></a> msdyn_organizationalunit_DuplicateBaseRecord

See msdyn_organizationalunit Entity [msdyn_organizationalunit_DuplicateBaseRecord](msdyn_organizationalunit.md#BKMK_msdyn_organizationalunit_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_priority_DuplicateMatchingRecord"></a> msdyn_priority_DuplicateMatchingRecord

See msdyn_priority Entity [msdyn_priority_DuplicateMatchingRecord](msdyn_priority.md#BKMK_msdyn_priority_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_priority_DuplicateBaseRecord"></a> msdyn_priority_DuplicateBaseRecord

See msdyn_priority Entity [msdyn_priority_DuplicateBaseRecord](msdyn_priority.md#BKMK_msdyn_priority_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementcharacteristic_DuplicateMatchingRecord"></a> msdyn_requirementcharacteristic_DuplicateMatchingRecord

See msdyn_requirementcharacteristic Entity [msdyn_requirementcharacteristic_DuplicateMatchingRecord](msdyn_requirementcharacteristic.md#BKMK_msdyn_requirementcharacteristic_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementcharacteristic_DuplicateBaseRecord"></a> msdyn_requirementcharacteristic_DuplicateBaseRecord

See msdyn_requirementcharacteristic Entity [msdyn_requirementcharacteristic_DuplicateBaseRecord](msdyn_requirementcharacteristic.md#BKMK_msdyn_requirementcharacteristic_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementorganizationunit_DuplicateMatchingRecord"></a> msdyn_requirementorganizationunit_DuplicateMatchingRecord

See msdyn_requirementorganizationunit Entity [msdyn_requirementorganizationunit_DuplicateMatchingRecord](msdyn_requirementorganizationunit.md#BKMK_msdyn_requirementorganizationunit_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementorganizationunit_DuplicateBaseRecord"></a> msdyn_requirementorganizationunit_DuplicateBaseRecord

See msdyn_requirementorganizationunit Entity [msdyn_requirementorganizationunit_DuplicateBaseRecord](msdyn_requirementorganizationunit.md#BKMK_msdyn_requirementorganizationunit_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementresourcecategory_DuplicateMatchingRecord"></a> msdyn_requirementresourcecategory_DuplicateMatchingRecord

See msdyn_requirementresourcecategory Entity [msdyn_requirementresourcecategory_DuplicateMatchingRecord](msdyn_requirementresourcecategory.md#BKMK_msdyn_requirementresourcecategory_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementresourcecategory_DuplicateBaseRecord"></a> msdyn_requirementresourcecategory_DuplicateBaseRecord

See msdyn_requirementresourcecategory Entity [msdyn_requirementresourcecategory_DuplicateBaseRecord](msdyn_requirementresourcecategory.md#BKMK_msdyn_requirementresourcecategory_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementresourcepreference_DuplicateMatchingRecord"></a> msdyn_requirementresourcepreference_DuplicateMatchingRecord

See msdyn_requirementresourcepreference Entity [msdyn_requirementresourcepreference_DuplicateMatchingRecord](msdyn_requirementresourcepreference.md#BKMK_msdyn_requirementresourcepreference_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementresourcepreference_DuplicateBaseRecord"></a> msdyn_requirementresourcepreference_DuplicateBaseRecord

See msdyn_requirementresourcepreference Entity [msdyn_requirementresourcepreference_DuplicateBaseRecord](msdyn_requirementresourcepreference.md#BKMK_msdyn_requirementresourcepreference_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementstatus_DuplicateMatchingRecord"></a> msdyn_requirementstatus_DuplicateMatchingRecord

See msdyn_requirementstatus Entity [msdyn_requirementstatus_DuplicateMatchingRecord](msdyn_requirementstatus.md#BKMK_msdyn_requirementstatus_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementstatus_DuplicateBaseRecord"></a> msdyn_requirementstatus_DuplicateBaseRecord

See msdyn_requirementstatus Entity [msdyn_requirementstatus_DuplicateBaseRecord](msdyn_requirementstatus.md#BKMK_msdyn_requirementstatus_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcerequirement_DuplicateMatchingRecord"></a> msdyn_resourcerequirement_DuplicateMatchingRecord

See msdyn_resourcerequirement Entity [msdyn_resourcerequirement_DuplicateMatchingRecord](msdyn_resourcerequirement.md#BKMK_msdyn_resourcerequirement_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcerequirement_DuplicateBaseRecord"></a> msdyn_resourcerequirement_DuplicateBaseRecord

See msdyn_resourcerequirement Entity [msdyn_resourcerequirement_DuplicateBaseRecord](msdyn_resourcerequirement.md#BKMK_msdyn_resourcerequirement_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcerequirementdetail_DuplicateMatchingRecord"></a> msdyn_resourcerequirementdetail_DuplicateMatchingRecord

See msdyn_resourcerequirementdetail Entity [msdyn_resourcerequirementdetail_DuplicateMatchingRecord](msdyn_resourcerequirementdetail.md#BKMK_msdyn_resourcerequirementdetail_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcerequirementdetail_DuplicateBaseRecord"></a> msdyn_resourcerequirementdetail_DuplicateBaseRecord

See msdyn_resourcerequirementdetail Entity [msdyn_resourcerequirementdetail_DuplicateBaseRecord](msdyn_resourcerequirementdetail.md#BKMK_msdyn_resourcerequirementdetail_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_resourceterritory_DuplicateMatchingRecord"></a> msdyn_resourceterritory_DuplicateMatchingRecord

See msdyn_resourceterritory Entity [msdyn_resourceterritory_DuplicateMatchingRecord](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_resourceterritory_DuplicateBaseRecord"></a> msdyn_resourceterritory_DuplicateBaseRecord

See msdyn_resourceterritory Entity [msdyn_resourceterritory_DuplicateBaseRecord](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_scheduleboardsetting_DuplicateMatchingRecord"></a> msdyn_scheduleboardsetting_DuplicateMatchingRecord

See msdyn_scheduleboardsetting Entity [msdyn_scheduleboardsetting_DuplicateMatchingRecord](msdyn_scheduleboardsetting.md#BKMK_msdyn_scheduleboardsetting_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_scheduleboardsetting_DuplicateBaseRecord"></a> msdyn_scheduleboardsetting_DuplicateBaseRecord

See msdyn_scheduleboardsetting Entity [msdyn_scheduleboardsetting_DuplicateBaseRecord](msdyn_scheduleboardsetting.md#BKMK_msdyn_scheduleboardsetting_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_systemuserschedulersetting_DuplicateMatchingRecord"></a> msdyn_systemuserschedulersetting_DuplicateMatchingRecord

See msdyn_systemuserschedulersetting Entity [msdyn_systemuserschedulersetting_DuplicateMatchingRecord](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_systemuserschedulersetting_DuplicateBaseRecord"></a> msdyn_systemuserschedulersetting_DuplicateBaseRecord

See msdyn_systemuserschedulersetting Entity [msdyn_systemuserschedulersetting_DuplicateBaseRecord](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroup_DuplicateMatchingRecord"></a> msdyn_timegroup_DuplicateMatchingRecord

See msdyn_timegroup Entity [msdyn_timegroup_DuplicateMatchingRecord](msdyn_timegroup.md#BKMK_msdyn_timegroup_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroup_DuplicateBaseRecord"></a> msdyn_timegroup_DuplicateBaseRecord

See msdyn_timegroup Entity [msdyn_timegroup_DuplicateBaseRecord](msdyn_timegroup.md#BKMK_msdyn_timegroup_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroupdetail_DuplicateMatchingRecord"></a> msdyn_timegroupdetail_DuplicateMatchingRecord

See msdyn_timegroupdetail Entity [msdyn_timegroupdetail_DuplicateMatchingRecord](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroupdetail_DuplicateBaseRecord"></a> msdyn_timegroupdetail_DuplicateBaseRecord

See msdyn_timegroupdetail Entity [msdyn_timegroupdetail_DuplicateBaseRecord](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_transactionorigin_DuplicateMatchingRecord"></a> msdyn_transactionorigin_DuplicateMatchingRecord

See msdyn_transactionorigin Entity [msdyn_transactionorigin_DuplicateMatchingRecord](msdyn_transactionorigin.md#BKMK_msdyn_transactionorigin_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_transactionorigin_DuplicateBaseRecord"></a> msdyn_transactionorigin_DuplicateBaseRecord

See msdyn_transactionorigin Entity [msdyn_transactionorigin_DuplicateBaseRecord](msdyn_transactionorigin.md#BKMK_msdyn_transactionorigin_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_workhourtemplate_DuplicateMatchingRecord"></a> msdyn_workhourtemplate_DuplicateMatchingRecord

See msdyn_workhourtemplate Entity [msdyn_workhourtemplate_DuplicateMatchingRecord](msdyn_workhourtemplate.md#BKMK_msdyn_workhourtemplate_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_workhourtemplate_DuplicateBaseRecord"></a> msdyn_workhourtemplate_DuplicateBaseRecord

See msdyn_workhourtemplate Entity [msdyn_workhourtemplate_DuplicateBaseRecord](msdyn_workhourtemplate.md#BKMK_msdyn_workhourtemplate_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_accountpricelist_DuplicateMatchingRecord"></a> msdyn_accountpricelist_DuplicateMatchingRecord

See msdyn_accountpricelist Entity [msdyn_accountpricelist_DuplicateMatchingRecord](msdyn_accountpricelist.md#BKMK_msdyn_accountpricelist_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_accountpricelist_DuplicateBaseRecord"></a> msdyn_accountpricelist_DuplicateBaseRecord

See msdyn_accountpricelist Entity [msdyn_accountpricelist_DuplicateBaseRecord](msdyn_accountpricelist.md#BKMK_msdyn_accountpricelist_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_approval_DuplicateMatchingRecord"></a> msdyn_approval_DuplicateMatchingRecord

See msdyn_approval Entity [msdyn_approval_DuplicateMatchingRecord](msdyn_approval.md#BKMK_msdyn_approval_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_approval_DuplicateBaseRecord"></a> msdyn_approval_DuplicateBaseRecord

See msdyn_approval Entity [msdyn_approval_DuplicateBaseRecord](msdyn_approval.md#BKMK_msdyn_approval_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_batchjob_DuplicateMatchingRecord"></a> msdyn_batchjob_DuplicateMatchingRecord

See msdyn_batchjob Entity [msdyn_batchjob_DuplicateMatchingRecord](msdyn_batchjob.md#BKMK_msdyn_batchjob_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_batchjob_DuplicateBaseRecord"></a> msdyn_batchjob_DuplicateBaseRecord

See msdyn_batchjob Entity [msdyn_batchjob_DuplicateBaseRecord](msdyn_batchjob.md#BKMK_msdyn_batchjob_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_characteristicreqforteammember_DuplicateMatchingRecord"></a> msdyn_characteristicreqforteammember_DuplicateMatchingRecord

See msdyn_characteristicreqforteammember Entity [msdyn_characteristicreqforteammember_DuplicateMatchingRecord](msdyn_characteristicreqforteammember.md#BKMK_msdyn_characteristicreqforteammember_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_characteristicreqforteammember_DuplicateBaseRecord"></a> msdyn_characteristicreqforteammember_DuplicateBaseRecord

See msdyn_characteristicreqforteammember Entity [msdyn_characteristicreqforteammember_DuplicateBaseRecord](msdyn_characteristicreqforteammember.md#BKMK_msdyn_characteristicreqforteammember_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_contactpricelist_DuplicateMatchingRecord"></a> msdyn_contactpricelist_DuplicateMatchingRecord

See msdyn_contactpricelist Entity [msdyn_contactpricelist_DuplicateMatchingRecord](msdyn_contactpricelist.md#BKMK_msdyn_contactpricelist_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_contactpricelist_DuplicateBaseRecord"></a> msdyn_contactpricelist_DuplicateBaseRecord

See msdyn_contactpricelist Entity [msdyn_contactpricelist_DuplicateBaseRecord](msdyn_contactpricelist.md#BKMK_msdyn_contactpricelist_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_contractlineinvoiceschedule_DuplicateMatchingRecord"></a> msdyn_contractlineinvoiceschedule_DuplicateMatchingRecord

See msdyn_contractlineinvoiceschedule Entity [msdyn_contractlineinvoiceschedule_DuplicateMatchingRecord](msdyn_contractlineinvoiceschedule.md#BKMK_msdyn_contractlineinvoiceschedule_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_contractlineinvoiceschedule_DuplicateBaseRecord"></a> msdyn_contractlineinvoiceschedule_DuplicateBaseRecord

See msdyn_contractlineinvoiceschedule Entity [msdyn_contractlineinvoiceschedule_DuplicateBaseRecord](msdyn_contractlineinvoiceschedule.md#BKMK_msdyn_contractlineinvoiceschedule_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_contractlinescheduleofvalue_DuplicateMatchingRecord"></a> msdyn_contractlinescheduleofvalue_DuplicateMatchingRecord

See msdyn_contractlinescheduleofvalue Entity [msdyn_contractlinescheduleofvalue_DuplicateMatchingRecord](msdyn_contractlinescheduleofvalue.md#BKMK_msdyn_contractlinescheduleofvalue_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_contractlinescheduleofvalue_DuplicateBaseRecord"></a> msdyn_contractlinescheduleofvalue_DuplicateBaseRecord

See msdyn_contractlinescheduleofvalue Entity [msdyn_contractlinescheduleofvalue_DuplicateBaseRecord](msdyn_contractlinescheduleofvalue.md#BKMK_msdyn_contractlinescheduleofvalue_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_dataexport_DuplicateMatchingRecord"></a> msdyn_dataexport_DuplicateMatchingRecord

See msdyn_dataexport Entity [msdyn_dataexport_DuplicateMatchingRecord](msdyn_dataexport.md#BKMK_msdyn_dataexport_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_dataexport_DuplicateBaseRecord"></a> msdyn_dataexport_DuplicateBaseRecord

See msdyn_dataexport Entity [msdyn_dataexport_DuplicateBaseRecord](msdyn_dataexport.md#BKMK_msdyn_dataexport_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_delegation_DuplicateMatchingRecord"></a> msdyn_delegation_DuplicateMatchingRecord

See msdyn_delegation Entity [msdyn_delegation_DuplicateMatchingRecord](msdyn_delegation.md#BKMK_msdyn_delegation_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_delegation_DuplicateBaseRecord"></a> msdyn_delegation_DuplicateBaseRecord

See msdyn_delegation Entity [msdyn_delegation_DuplicateBaseRecord](msdyn_delegation.md#BKMK_msdyn_delegation_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_estimate_DuplicateMatchingRecord"></a> msdyn_estimate_DuplicateMatchingRecord

See msdyn_estimate Entity [msdyn_estimate_DuplicateMatchingRecord](msdyn_estimate.md#BKMK_msdyn_estimate_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_estimate_DuplicateBaseRecord"></a> msdyn_estimate_DuplicateBaseRecord

See msdyn_estimate Entity [msdyn_estimate_DuplicateBaseRecord](msdyn_estimate.md#BKMK_msdyn_estimate_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_estimateline_DuplicateMatchingRecord"></a> msdyn_estimateline_DuplicateMatchingRecord

See msdyn_estimateline Entity [msdyn_estimateline_DuplicateMatchingRecord](msdyn_estimateline.md#BKMK_msdyn_estimateline_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_estimateline_DuplicateBaseRecord"></a> msdyn_estimateline_DuplicateBaseRecord

See msdyn_estimateline Entity [msdyn_estimateline_DuplicateBaseRecord](msdyn_estimateline.md#BKMK_msdyn_estimateline_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_expense_DuplicateMatchingRecord"></a> msdyn_expense_DuplicateMatchingRecord

See msdyn_expense Entity [msdyn_expense_DuplicateMatchingRecord](msdyn_expense.md#BKMK_msdyn_expense_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_expense_DuplicateBaseRecord"></a> msdyn_expense_DuplicateBaseRecord

See msdyn_expense Entity [msdyn_expense_DuplicateBaseRecord](msdyn_expense.md#BKMK_msdyn_expense_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_expensecategory_DuplicateMatchingRecord"></a> msdyn_expensecategory_DuplicateMatchingRecord

See msdyn_expensecategory Entity [msdyn_expensecategory_DuplicateMatchingRecord](msdyn_expensecategory.md#BKMK_msdyn_expensecategory_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_expensecategory_DuplicateBaseRecord"></a> msdyn_expensecategory_DuplicateBaseRecord

See msdyn_expensecategory Entity [msdyn_expensecategory_DuplicateBaseRecord](msdyn_expensecategory.md#BKMK_msdyn_expensecategory_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_fact_DuplicateMatchingRecord"></a> msdyn_fact_DuplicateMatchingRecord

See msdyn_fact Entity [msdyn_fact_DuplicateMatchingRecord](msdyn_fact.md#BKMK_msdyn_fact_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_fact_DuplicateBaseRecord"></a> msdyn_fact_DuplicateBaseRecord

See msdyn_fact Entity [msdyn_fact_DuplicateBaseRecord](msdyn_fact.md#BKMK_msdyn_fact_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldcomputation_DuplicateMatchingRecord"></a> msdyn_fieldcomputation_DuplicateMatchingRecord

See msdyn_fieldcomputation Entity [msdyn_fieldcomputation_DuplicateMatchingRecord](msdyn_fieldcomputation.md#BKMK_msdyn_fieldcomputation_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldcomputation_DuplicateBaseRecord"></a> msdyn_fieldcomputation_DuplicateBaseRecord

See msdyn_fieldcomputation Entity [msdyn_fieldcomputation_DuplicateBaseRecord](msdyn_fieldcomputation.md#BKMK_msdyn_fieldcomputation_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_findworkevent_DuplicateMatchingRecord"></a> msdyn_findworkevent_DuplicateMatchingRecord

See msdyn_findworkevent Entity [msdyn_findworkevent_DuplicateMatchingRecord](msdyn_findworkevent.md#BKMK_msdyn_findworkevent_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_findworkevent_DuplicateBaseRecord"></a> msdyn_findworkevent_DuplicateBaseRecord

See msdyn_findworkevent Entity [msdyn_findworkevent_DuplicateBaseRecord](msdyn_findworkevent.md#BKMK_msdyn_findworkevent_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_invoicefrequency_DuplicateMatchingRecord"></a> msdyn_invoicefrequency_DuplicateMatchingRecord

See msdyn_invoicefrequency Entity [msdyn_invoicefrequency_DuplicateMatchingRecord](msdyn_invoicefrequency.md#BKMK_msdyn_invoicefrequency_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_invoicefrequency_DuplicateBaseRecord"></a> msdyn_invoicefrequency_DuplicateBaseRecord

See msdyn_invoicefrequency Entity [msdyn_invoicefrequency_DuplicateBaseRecord](msdyn_invoicefrequency.md#BKMK_msdyn_invoicefrequency_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_invoicefrequencydetail_DuplicateMatchingRecord"></a> msdyn_invoicefrequencydetail_DuplicateMatchingRecord

See msdyn_invoicefrequencydetail Entity [msdyn_invoicefrequencydetail_DuplicateMatchingRecord](msdyn_invoicefrequencydetail.md#BKMK_msdyn_invoicefrequencydetail_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_invoicefrequencydetail_DuplicateBaseRecord"></a> msdyn_invoicefrequencydetail_DuplicateBaseRecord

See msdyn_invoicefrequencydetail Entity [msdyn_invoicefrequencydetail_DuplicateBaseRecord](msdyn_invoicefrequencydetail.md#BKMK_msdyn_invoicefrequencydetail_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_invoicelinetransaction_DuplicateMatchingRecord"></a> msdyn_invoicelinetransaction_DuplicateMatchingRecord

See msdyn_invoicelinetransaction Entity [msdyn_invoicelinetransaction_DuplicateMatchingRecord](msdyn_invoicelinetransaction.md#BKMK_msdyn_invoicelinetransaction_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_invoicelinetransaction_DuplicateBaseRecord"></a> msdyn_invoicelinetransaction_DuplicateBaseRecord

See msdyn_invoicelinetransaction Entity [msdyn_invoicelinetransaction_DuplicateBaseRecord](msdyn_invoicelinetransaction.md#BKMK_msdyn_invoicelinetransaction_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_journal_DuplicateMatchingRecord"></a> msdyn_journal_DuplicateMatchingRecord

See msdyn_journal Entity [msdyn_journal_DuplicateMatchingRecord](msdyn_journal.md#BKMK_msdyn_journal_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_journal_DuplicateBaseRecord"></a> msdyn_journal_DuplicateBaseRecord

See msdyn_journal Entity [msdyn_journal_DuplicateBaseRecord](msdyn_journal.md#BKMK_msdyn_journal_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_journalline_DuplicateMatchingRecord"></a> msdyn_journalline_DuplicateMatchingRecord

See msdyn_journalline Entity [msdyn_journalline_DuplicateMatchingRecord](msdyn_journalline.md#BKMK_msdyn_journalline_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_journalline_DuplicateBaseRecord"></a> msdyn_journalline_DuplicateBaseRecord

See msdyn_journalline Entity [msdyn_journalline_DuplicateBaseRecord](msdyn_journalline.md#BKMK_msdyn_journalline_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitylineresourcecategory_DuplicateMatchingRecord"></a> msdyn_opportunitylineresourcecategory_DuplicateMatchingRecord

See msdyn_opportunitylineresourcecategory Entity [msdyn_opportunitylineresourcecategory_DuplicateMatchingRecord](msdyn_opportunitylineresourcecategory.md#BKMK_msdyn_opportunitylineresourcecategory_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitylineresourcecategory_DuplicateBaseRecord"></a> msdyn_opportunitylineresourcecategory_DuplicateBaseRecord

See msdyn_opportunitylineresourcecategory Entity [msdyn_opportunitylineresourcecategory_DuplicateBaseRecord](msdyn_opportunitylineresourcecategory.md#BKMK_msdyn_opportunitylineresourcecategory_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitylinetransaction_DuplicateMatchingRecord"></a> msdyn_opportunitylinetransaction_DuplicateMatchingRecord

See msdyn_opportunitylinetransaction Entity [msdyn_opportunitylinetransaction_DuplicateMatchingRecord](msdyn_opportunitylinetransaction.md#BKMK_msdyn_opportunitylinetransaction_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitylinetransaction_DuplicateBaseRecord"></a> msdyn_opportunitylinetransaction_DuplicateBaseRecord

See msdyn_opportunitylinetransaction Entity [msdyn_opportunitylinetransaction_DuplicateBaseRecord](msdyn_opportunitylinetransaction.md#BKMK_msdyn_opportunitylinetransaction_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitylinetransactioncategory_DuplicateMatchingRecord"></a> msdyn_opportunitylinetransactioncategory_DuplicateMatchingRecord

See msdyn_opportunitylinetransactioncategory Entity [msdyn_opportunitylinetransactioncategory_DuplicateMatchingRecord](msdyn_opportunitylinetransactioncategory.md#BKMK_msdyn_opportunitylinetransactioncategory_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitylinetransactioncategory_DuplicateBaseRecord"></a> msdyn_opportunitylinetransactioncategory_DuplicateBaseRecord

See msdyn_opportunitylinetransactioncategory Entity [msdyn_opportunitylinetransactioncategory_DuplicateBaseRecord](msdyn_opportunitylinetransactioncategory.md#BKMK_msdyn_opportunitylinetransactioncategory_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitylinetransactionclassificatio_DuplicateMatchingRecord"></a> msdyn_opportunitylinetransactionclassificatio_DuplicateMatchingRecord

See msdyn_opportunitylinetransactionclassificatio Entity [msdyn_opportunitylinetransactionclassificatio_DuplicateMatchingRecord](msdyn_opportunitylinetransactionclassificatio.md#BKMK_msdyn_opportunitylinetransactionclassificatio_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitylinetransactionclassificatio_DuplicateBaseRecord"></a> msdyn_opportunitylinetransactionclassificatio_DuplicateBaseRecord

See msdyn_opportunitylinetransactionclassificatio Entity [msdyn_opportunitylinetransactionclassificatio_DuplicateBaseRecord](msdyn_opportunitylinetransactionclassificatio.md#BKMK_msdyn_opportunitylinetransactionclassificatio_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitypricelist_DuplicateMatchingRecord"></a> msdyn_opportunitypricelist_DuplicateMatchingRecord

See msdyn_opportunitypricelist Entity [msdyn_opportunitypricelist_DuplicateMatchingRecord](msdyn_opportunitypricelist.md#BKMK_msdyn_opportunitypricelist_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitypricelist_DuplicateBaseRecord"></a> msdyn_opportunitypricelist_DuplicateBaseRecord

See msdyn_opportunitypricelist Entity [msdyn_opportunitypricelist_DuplicateBaseRecord](msdyn_opportunitypricelist.md#BKMK_msdyn_opportunitypricelist_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_orderlineresourcecategory_DuplicateMatchingRecord"></a> msdyn_orderlineresourcecategory_DuplicateMatchingRecord

See msdyn_orderlineresourcecategory Entity [msdyn_orderlineresourcecategory_DuplicateMatchingRecord](msdyn_orderlineresourcecategory.md#BKMK_msdyn_orderlineresourcecategory_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_orderlineresourcecategory_DuplicateBaseRecord"></a> msdyn_orderlineresourcecategory_DuplicateBaseRecord

See msdyn_orderlineresourcecategory Entity [msdyn_orderlineresourcecategory_DuplicateBaseRecord](msdyn_orderlineresourcecategory.md#BKMK_msdyn_orderlineresourcecategory_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_orderlinetransaction_DuplicateMatchingRecord"></a> msdyn_orderlinetransaction_DuplicateMatchingRecord

See msdyn_orderlinetransaction Entity [msdyn_orderlinetransaction_DuplicateMatchingRecord](msdyn_orderlinetransaction.md#BKMK_msdyn_orderlinetransaction_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_orderlinetransaction_DuplicateBaseRecord"></a> msdyn_orderlinetransaction_DuplicateBaseRecord

See msdyn_orderlinetransaction Entity [msdyn_orderlinetransaction_DuplicateBaseRecord](msdyn_orderlinetransaction.md#BKMK_msdyn_orderlinetransaction_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_orderlinetransactioncategory_DuplicateMatchingRecord"></a> msdyn_orderlinetransactioncategory_DuplicateMatchingRecord

See msdyn_orderlinetransactioncategory Entity [msdyn_orderlinetransactioncategory_DuplicateMatchingRecord](msdyn_orderlinetransactioncategory.md#BKMK_msdyn_orderlinetransactioncategory_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_orderlinetransactioncategory_DuplicateBaseRecord"></a> msdyn_orderlinetransactioncategory_DuplicateBaseRecord

See msdyn_orderlinetransactioncategory Entity [msdyn_orderlinetransactioncategory_DuplicateBaseRecord](msdyn_orderlinetransactioncategory.md#BKMK_msdyn_orderlinetransactioncategory_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_orderlinetransactionclassification_DuplicateMatchingRecord"></a> msdyn_orderlinetransactionclassification_DuplicateMatchingRecord

See msdyn_orderlinetransactionclassification Entity [msdyn_orderlinetransactionclassification_DuplicateMatchingRecord](msdyn_orderlinetransactionclassification.md#BKMK_msdyn_orderlinetransactionclassification_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_orderlinetransactionclassification_DuplicateBaseRecord"></a> msdyn_orderlinetransactionclassification_DuplicateBaseRecord

See msdyn_orderlinetransactionclassification Entity [msdyn_orderlinetransactionclassification_DuplicateBaseRecord](msdyn_orderlinetransactionclassification.md#BKMK_msdyn_orderlinetransactionclassification_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_orderpricelist_DuplicateMatchingRecord"></a> msdyn_orderpricelist_DuplicateMatchingRecord

See msdyn_orderpricelist Entity [msdyn_orderpricelist_DuplicateMatchingRecord](msdyn_orderpricelist.md#BKMK_msdyn_orderpricelist_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_orderpricelist_DuplicateBaseRecord"></a> msdyn_orderpricelist_DuplicateBaseRecord

See msdyn_orderpricelist Entity [msdyn_orderpricelist_DuplicateBaseRecord](msdyn_orderpricelist.md#BKMK_msdyn_orderpricelist_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_processnotes_DuplicateMatchingRecord"></a> msdyn_processnotes_DuplicateMatchingRecord

See msdyn_processnotes Entity [msdyn_processnotes_DuplicateMatchingRecord](msdyn_processnotes.md#BKMK_msdyn_processnotes_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_processnotes_DuplicateBaseRecord"></a> msdyn_processnotes_DuplicateBaseRecord

See msdyn_processnotes Entity [msdyn_processnotes_DuplicateBaseRecord](msdyn_processnotes.md#BKMK_msdyn_processnotes_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_project_DuplicateMatchingRecord"></a> msdyn_project_DuplicateMatchingRecord

See msdyn_project Entity [msdyn_project_DuplicateMatchingRecord](msdyn_project.md#BKMK_msdyn_project_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_project_DuplicateBaseRecord"></a> msdyn_project_DuplicateBaseRecord

See msdyn_project Entity [msdyn_project_DuplicateBaseRecord](msdyn_project.md#BKMK_msdyn_project_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_projectapproval_DuplicateMatchingRecord"></a> msdyn_projectapproval_DuplicateMatchingRecord

See msdyn_projectapproval Entity [msdyn_projectapproval_DuplicateMatchingRecord](msdyn_projectapproval.md#BKMK_msdyn_projectapproval_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_projectapproval_DuplicateBaseRecord"></a> msdyn_projectapproval_DuplicateBaseRecord

See msdyn_projectapproval Entity [msdyn_projectapproval_DuplicateBaseRecord](msdyn_projectapproval.md#BKMK_msdyn_projectapproval_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_projectparameter_DuplicateMatchingRecord"></a> msdyn_projectparameter_DuplicateMatchingRecord

See msdyn_projectparameter Entity [msdyn_projectparameter_DuplicateMatchingRecord](msdyn_projectparameter.md#BKMK_msdyn_projectparameter_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_projectparameter_DuplicateBaseRecord"></a> msdyn_projectparameter_DuplicateBaseRecord

See msdyn_projectparameter Entity [msdyn_projectparameter_DuplicateBaseRecord](msdyn_projectparameter.md#BKMK_msdyn_projectparameter_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_projectparameterpricelist_DuplicateMatchingRecord"></a> msdyn_projectparameterpricelist_DuplicateMatchingRecord

See msdyn_projectparameterpricelist Entity [msdyn_projectparameterpricelist_DuplicateMatchingRecord](msdyn_projectparameterpricelist.md#BKMK_msdyn_projectparameterpricelist_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_projectparameterpricelist_DuplicateBaseRecord"></a> msdyn_projectparameterpricelist_DuplicateBaseRecord

See msdyn_projectparameterpricelist Entity [msdyn_projectparameterpricelist_DuplicateBaseRecord](msdyn_projectparameterpricelist.md#BKMK_msdyn_projectparameterpricelist_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_projectpricelist_DuplicateMatchingRecord"></a> msdyn_projectpricelist_DuplicateMatchingRecord

See msdyn_projectpricelist Entity [msdyn_projectpricelist_DuplicateMatchingRecord](msdyn_projectpricelist.md#BKMK_msdyn_projectpricelist_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_projectpricelist_DuplicateBaseRecord"></a> msdyn_projectpricelist_DuplicateBaseRecord

See msdyn_projectpricelist Entity [msdyn_projectpricelist_DuplicateBaseRecord](msdyn_projectpricelist.md#BKMK_msdyn_projectpricelist_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_projecttask_DuplicateMatchingRecord"></a> msdyn_projecttask_DuplicateMatchingRecord

See msdyn_projecttask Entity [msdyn_projecttask_DuplicateMatchingRecord](msdyn_projecttask.md#BKMK_msdyn_projecttask_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_projecttask_DuplicateBaseRecord"></a> msdyn_projecttask_DuplicateBaseRecord

See msdyn_projecttask Entity [msdyn_projecttask_DuplicateBaseRecord](msdyn_projecttask.md#BKMK_msdyn_projecttask_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_projecttaskdependency_DuplicateMatchingRecord"></a> msdyn_projecttaskdependency_DuplicateMatchingRecord

See msdyn_projecttaskdependency Entity [msdyn_projecttaskdependency_DuplicateMatchingRecord](msdyn_projecttaskdependency.md#BKMK_msdyn_projecttaskdependency_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_projecttaskdependency_DuplicateBaseRecord"></a> msdyn_projecttaskdependency_DuplicateBaseRecord

See msdyn_projecttaskdependency Entity [msdyn_projecttaskdependency_DuplicateBaseRecord](msdyn_projecttaskdependency.md#BKMK_msdyn_projecttaskdependency_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_projecttaskstatususer_DuplicateMatchingRecord"></a> msdyn_projecttaskstatususer_DuplicateMatchingRecord

See msdyn_projecttaskstatususer Entity [msdyn_projecttaskstatususer_DuplicateMatchingRecord](msdyn_projecttaskstatususer.md#BKMK_msdyn_projecttaskstatususer_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_projecttaskstatususer_DuplicateBaseRecord"></a> msdyn_projecttaskstatususer_DuplicateBaseRecord

See msdyn_projecttaskstatususer Entity [msdyn_projecttaskstatususer_DuplicateBaseRecord](msdyn_projecttaskstatususer.md#BKMK_msdyn_projecttaskstatususer_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_projectteam_DuplicateMatchingRecord"></a> msdyn_projectteam_DuplicateMatchingRecord

See msdyn_projectteam Entity [msdyn_projectteam_DuplicateMatchingRecord](msdyn_projectteam.md#BKMK_msdyn_projectteam_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_projectteam_DuplicateBaseRecord"></a> msdyn_projectteam_DuplicateBaseRecord

See msdyn_projectteam Entity [msdyn_projectteam_DuplicateBaseRecord](msdyn_projectteam.md#BKMK_msdyn_projectteam_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_projectteammembersignup_DuplicateMatchingRecord"></a> msdyn_projectteammembersignup_DuplicateMatchingRecord

See msdyn_projectteammembersignup Entity [msdyn_projectteammembersignup_DuplicateMatchingRecord](msdyn_projectteammembersignup.md#BKMK_msdyn_projectteammembersignup_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_projectteammembersignup_DuplicateBaseRecord"></a> msdyn_projectteammembersignup_DuplicateBaseRecord

See msdyn_projectteammembersignup Entity [msdyn_projectteammembersignup_DuplicateBaseRecord](msdyn_projectteammembersignup.md#BKMK_msdyn_projectteammembersignup_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_projecttransactioncategory_DuplicateMatchingRecord"></a> msdyn_projecttransactioncategory_DuplicateMatchingRecord

See msdyn_projecttransactioncategory Entity [msdyn_projecttransactioncategory_DuplicateMatchingRecord](msdyn_projecttransactioncategory.md#BKMK_msdyn_projecttransactioncategory_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_projecttransactioncategory_DuplicateBaseRecord"></a> msdyn_projecttransactioncategory_DuplicateBaseRecord

See msdyn_projecttransactioncategory Entity [msdyn_projecttransactioncategory_DuplicateBaseRecord](msdyn_projecttransactioncategory.md#BKMK_msdyn_projecttransactioncategory_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelineanalyticsbreakdown_DuplicateMatchingRecord"></a> msdyn_quotelineanalyticsbreakdown_DuplicateMatchingRecord

See msdyn_quotelineanalyticsbreakdown Entity [msdyn_quotelineanalyticsbreakdown_DuplicateMatchingRecord](msdyn_quotelineanalyticsbreakdown.md#BKMK_msdyn_quotelineanalyticsbreakdown_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelineanalyticsbreakdown_DuplicateBaseRecord"></a> msdyn_quotelineanalyticsbreakdown_DuplicateBaseRecord

See msdyn_quotelineanalyticsbreakdown Entity [msdyn_quotelineanalyticsbreakdown_DuplicateBaseRecord](msdyn_quotelineanalyticsbreakdown.md#BKMK_msdyn_quotelineanalyticsbreakdown_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelineinvoiceschedule_DuplicateMatchingRecord"></a> msdyn_quotelineinvoiceschedule_DuplicateMatchingRecord

See msdyn_quotelineinvoiceschedule Entity [msdyn_quotelineinvoiceschedule_DuplicateMatchingRecord](msdyn_quotelineinvoiceschedule.md#BKMK_msdyn_quotelineinvoiceschedule_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelineinvoiceschedule_DuplicateBaseRecord"></a> msdyn_quotelineinvoiceschedule_DuplicateBaseRecord

See msdyn_quotelineinvoiceschedule Entity [msdyn_quotelineinvoiceschedule_DuplicateBaseRecord](msdyn_quotelineinvoiceschedule.md#BKMK_msdyn_quotelineinvoiceschedule_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelineresourcecategory_DuplicateMatchingRecord"></a> msdyn_quotelineresourcecategory_DuplicateMatchingRecord

See msdyn_quotelineresourcecategory Entity [msdyn_quotelineresourcecategory_DuplicateMatchingRecord](msdyn_quotelineresourcecategory.md#BKMK_msdyn_quotelineresourcecategory_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelineresourcecategory_DuplicateBaseRecord"></a> msdyn_quotelineresourcecategory_DuplicateBaseRecord

See msdyn_quotelineresourcecategory Entity [msdyn_quotelineresourcecategory_DuplicateBaseRecord](msdyn_quotelineresourcecategory.md#BKMK_msdyn_quotelineresourcecategory_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelinescheduleofvalue_DuplicateMatchingRecord"></a> msdyn_quotelinescheduleofvalue_DuplicateMatchingRecord

See msdyn_quotelinescheduleofvalue Entity [msdyn_quotelinescheduleofvalue_DuplicateMatchingRecord](msdyn_quotelinescheduleofvalue.md#BKMK_msdyn_quotelinescheduleofvalue_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelinescheduleofvalue_DuplicateBaseRecord"></a> msdyn_quotelinescheduleofvalue_DuplicateBaseRecord

See msdyn_quotelinescheduleofvalue Entity [msdyn_quotelinescheduleofvalue_DuplicateBaseRecord](msdyn_quotelinescheduleofvalue.md#BKMK_msdyn_quotelinescheduleofvalue_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelinetransaction_DuplicateMatchingRecord"></a> msdyn_quotelinetransaction_DuplicateMatchingRecord

See msdyn_quotelinetransaction Entity [msdyn_quotelinetransaction_DuplicateMatchingRecord](msdyn_quotelinetransaction.md#BKMK_msdyn_quotelinetransaction_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelinetransaction_DuplicateBaseRecord"></a> msdyn_quotelinetransaction_DuplicateBaseRecord

See msdyn_quotelinetransaction Entity [msdyn_quotelinetransaction_DuplicateBaseRecord](msdyn_quotelinetransaction.md#BKMK_msdyn_quotelinetransaction_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelinetransactioncategory_DuplicateMatchingRecord"></a> msdyn_quotelinetransactioncategory_DuplicateMatchingRecord

See msdyn_quotelinetransactioncategory Entity [msdyn_quotelinetransactioncategory_DuplicateMatchingRecord](msdyn_quotelinetransactioncategory.md#BKMK_msdyn_quotelinetransactioncategory_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelinetransactioncategory_DuplicateBaseRecord"></a> msdyn_quotelinetransactioncategory_DuplicateBaseRecord

See msdyn_quotelinetransactioncategory Entity [msdyn_quotelinetransactioncategory_DuplicateBaseRecord](msdyn_quotelinetransactioncategory.md#BKMK_msdyn_quotelinetransactioncategory_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelinetransactionclassification_DuplicateMatchingRecord"></a> msdyn_quotelinetransactionclassification_DuplicateMatchingRecord

See msdyn_quotelinetransactionclassification Entity [msdyn_quotelinetransactionclassification_DuplicateMatchingRecord](msdyn_quotelinetransactionclassification.md#BKMK_msdyn_quotelinetransactionclassification_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelinetransactionclassification_DuplicateBaseRecord"></a> msdyn_quotelinetransactionclassification_DuplicateBaseRecord

See msdyn_quotelinetransactionclassification Entity [msdyn_quotelinetransactionclassification_DuplicateBaseRecord](msdyn_quotelinetransactionclassification.md#BKMK_msdyn_quotelinetransactionclassification_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_quotepricelist_DuplicateMatchingRecord"></a> msdyn_quotepricelist_DuplicateMatchingRecord

See msdyn_quotepricelist Entity [msdyn_quotepricelist_DuplicateMatchingRecord](msdyn_quotepricelist.md#BKMK_msdyn_quotepricelist_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_quotepricelist_DuplicateBaseRecord"></a> msdyn_quotepricelist_DuplicateBaseRecord

See msdyn_quotepricelist Entity [msdyn_quotepricelist_DuplicateBaseRecord](msdyn_quotepricelist.md#BKMK_msdyn_quotepricelist_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_resourceassignmentdetail_DuplicateMatchingRecord"></a> msdyn_resourceassignmentdetail_DuplicateMatchingRecord

See msdyn_resourceassignmentdetail Entity [msdyn_resourceassignmentdetail_DuplicateMatchingRecord](msdyn_resourceassignmentdetail.md#BKMK_msdyn_resourceassignmentdetail_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_resourceassignmentdetail_DuplicateBaseRecord"></a> msdyn_resourceassignmentdetail_DuplicateBaseRecord

See msdyn_resourceassignmentdetail Entity [msdyn_resourceassignmentdetail_DuplicateBaseRecord](msdyn_resourceassignmentdetail.md#BKMK_msdyn_resourceassignmentdetail_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcecategorypricelevel_DuplicateMatchingRecord"></a> msdyn_resourcecategorypricelevel_DuplicateMatchingRecord

See msdyn_resourcecategorypricelevel Entity [msdyn_resourcecategorypricelevel_DuplicateMatchingRecord](msdyn_resourcecategorypricelevel.md#BKMK_msdyn_resourcecategorypricelevel_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcecategorypricelevel_DuplicateBaseRecord"></a> msdyn_resourcecategorypricelevel_DuplicateBaseRecord

See msdyn_resourcecategorypricelevel Entity [msdyn_resourcecategorypricelevel_DuplicateBaseRecord](msdyn_resourcecategorypricelevel.md#BKMK_msdyn_resourcecategorypricelevel_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcerequest_DuplicateMatchingRecord"></a> msdyn_resourcerequest_DuplicateMatchingRecord

See msdyn_resourcerequest Entity [msdyn_resourcerequest_DuplicateMatchingRecord](msdyn_resourcerequest.md#BKMK_msdyn_resourcerequest_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcerequest_DuplicateBaseRecord"></a> msdyn_resourcerequest_DuplicateBaseRecord

See msdyn_resourcerequest Entity [msdyn_resourcerequest_DuplicateBaseRecord](msdyn_resourcerequest.md#BKMK_msdyn_resourcerequest_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_rolecompetencyrequirement_DuplicateMatchingRecord"></a> msdyn_rolecompetencyrequirement_DuplicateMatchingRecord

See msdyn_rolecompetencyrequirement Entity [msdyn_rolecompetencyrequirement_DuplicateMatchingRecord](msdyn_rolecompetencyrequirement.md#BKMK_msdyn_rolecompetencyrequirement_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_rolecompetencyrequirement_DuplicateBaseRecord"></a> msdyn_rolecompetencyrequirement_DuplicateBaseRecord

See msdyn_rolecompetencyrequirement Entity [msdyn_rolecompetencyrequirement_DuplicateBaseRecord](msdyn_rolecompetencyrequirement.md#BKMK_msdyn_rolecompetencyrequirement_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_roleutilization_DuplicateMatchingRecord"></a> msdyn_roleutilization_DuplicateMatchingRecord

See msdyn_roleutilization Entity [msdyn_roleutilization_DuplicateMatchingRecord](msdyn_roleutilization.md#BKMK_msdyn_roleutilization_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_roleutilization_DuplicateBaseRecord"></a> msdyn_roleutilization_DuplicateBaseRecord

See msdyn_roleutilization Entity [msdyn_roleutilization_DuplicateBaseRecord](msdyn_roleutilization.md#BKMK_msdyn_roleutilization_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_timeoffcalendar_DuplicateMatchingRecord"></a> msdyn_timeoffcalendar_DuplicateMatchingRecord

See msdyn_timeoffcalendar Entity [msdyn_timeoffcalendar_DuplicateMatchingRecord](msdyn_timeoffcalendar.md#BKMK_msdyn_timeoffcalendar_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_timeoffcalendar_DuplicateBaseRecord"></a> msdyn_timeoffcalendar_DuplicateBaseRecord

See msdyn_timeoffcalendar Entity [msdyn_timeoffcalendar_DuplicateBaseRecord](msdyn_timeoffcalendar.md#BKMK_msdyn_timeoffcalendar_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_transactioncategory_DuplicateMatchingRecord"></a> msdyn_transactioncategory_DuplicateMatchingRecord

See msdyn_transactioncategory Entity [msdyn_transactioncategory_DuplicateMatchingRecord](msdyn_transactioncategory.md#BKMK_msdyn_transactioncategory_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_transactioncategory_DuplicateBaseRecord"></a> msdyn_transactioncategory_DuplicateBaseRecord

See msdyn_transactioncategory Entity [msdyn_transactioncategory_DuplicateBaseRecord](msdyn_transactioncategory.md#BKMK_msdyn_transactioncategory_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_transactioncategoryclassification_DuplicateMatchingRecord"></a> msdyn_transactioncategoryclassification_DuplicateMatchingRecord

See msdyn_transactioncategoryclassification Entity [msdyn_transactioncategoryclassification_DuplicateMatchingRecord](msdyn_transactioncategoryclassification.md#BKMK_msdyn_transactioncategoryclassification_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_transactioncategoryclassification_DuplicateBaseRecord"></a> msdyn_transactioncategoryclassification_DuplicateBaseRecord

See msdyn_transactioncategoryclassification Entity [msdyn_transactioncategoryclassification_DuplicateBaseRecord](msdyn_transactioncategoryclassification.md#BKMK_msdyn_transactioncategoryclassification_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_transactioncategoryhierarchyelement_DuplicateMatchingRecord"></a> msdyn_transactioncategoryhierarchyelement_DuplicateMatchingRecord

See msdyn_transactioncategoryhierarchyelement Entity [msdyn_transactioncategoryhierarchyelement_DuplicateMatchingRecord](msdyn_transactioncategoryhierarchyelement.md#BKMK_msdyn_transactioncategoryhierarchyelement_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_transactioncategoryhierarchyelement_DuplicateBaseRecord"></a> msdyn_transactioncategoryhierarchyelement_DuplicateBaseRecord

See msdyn_transactioncategoryhierarchyelement Entity [msdyn_transactioncategoryhierarchyelement_DuplicateBaseRecord](msdyn_transactioncategoryhierarchyelement.md#BKMK_msdyn_transactioncategoryhierarchyelement_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_transactioncategorypricelevel_DuplicateMatchingRecord"></a> msdyn_transactioncategorypricelevel_DuplicateMatchingRecord

See msdyn_transactioncategorypricelevel Entity [msdyn_transactioncategorypricelevel_DuplicateMatchingRecord](msdyn_transactioncategorypricelevel.md#BKMK_msdyn_transactioncategorypricelevel_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_transactioncategorypricelevel_DuplicateBaseRecord"></a> msdyn_transactioncategorypricelevel_DuplicateBaseRecord

See msdyn_transactioncategorypricelevel Entity [msdyn_transactioncategorypricelevel_DuplicateBaseRecord](msdyn_transactioncategorypricelevel.md#BKMK_msdyn_transactioncategorypricelevel_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_transactionconnection_DuplicateMatchingRecord"></a> msdyn_transactionconnection_DuplicateMatchingRecord

See msdyn_transactionconnection Entity [msdyn_transactionconnection_DuplicateMatchingRecord](msdyn_transactionconnection.md#BKMK_msdyn_transactionconnection_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_transactionconnection_DuplicateBaseRecord"></a> msdyn_transactionconnection_DuplicateBaseRecord

See msdyn_transactionconnection Entity [msdyn_transactionconnection_DuplicateBaseRecord](msdyn_transactionconnection.md#BKMK_msdyn_transactionconnection_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_transactiontype_DuplicateMatchingRecord"></a> msdyn_transactiontype_DuplicateMatchingRecord

See msdyn_transactiontype Entity [msdyn_transactiontype_DuplicateMatchingRecord](msdyn_transactiontype.md#BKMK_msdyn_transactiontype_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_transactiontype_DuplicateBaseRecord"></a> msdyn_transactiontype_DuplicateBaseRecord

See msdyn_transactiontype Entity [msdyn_transactiontype_DuplicateBaseRecord](msdyn_transactiontype.md#BKMK_msdyn_transactiontype_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_userworkhistory_DuplicateMatchingRecord"></a> msdyn_userworkhistory_DuplicateMatchingRecord

See msdyn_userworkhistory Entity [msdyn_userworkhistory_DuplicateMatchingRecord](msdyn_userworkhistory.md#BKMK_msdyn_userworkhistory_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_userworkhistory_DuplicateBaseRecord"></a> msdyn_userworkhistory_DuplicateBaseRecord

See msdyn_userworkhistory Entity [msdyn_userworkhistory_DuplicateBaseRecord](msdyn_userworkhistory.md#BKMK_msdyn_userworkhistory_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_agreement_DuplicateMatchingRecord"></a> msdyn_agreement_DuplicateMatchingRecord

See msdyn_agreement Entity [msdyn_agreement_DuplicateMatchingRecord](msdyn_agreement.md#BKMK_msdyn_agreement_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_agreement_DuplicateBaseRecord"></a> msdyn_agreement_DuplicateBaseRecord

See msdyn_agreement Entity [msdyn_agreement_DuplicateBaseRecord](msdyn_agreement.md#BKMK_msdyn_agreement_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingdate_DuplicateMatchingRecord"></a> msdyn_agreementbookingdate_DuplicateMatchingRecord

See msdyn_agreementbookingdate Entity [msdyn_agreementbookingdate_DuplicateMatchingRecord](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingdate_DuplicateBaseRecord"></a> msdyn_agreementbookingdate_DuplicateBaseRecord

See msdyn_agreementbookingdate Entity [msdyn_agreementbookingdate_DuplicateBaseRecord](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingincident_DuplicateMatchingRecord"></a> msdyn_agreementbookingincident_DuplicateMatchingRecord

See msdyn_agreementbookingincident Entity [msdyn_agreementbookingincident_DuplicateMatchingRecord](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingincident_DuplicateBaseRecord"></a> msdyn_agreementbookingincident_DuplicateBaseRecord

See msdyn_agreementbookingincident Entity [msdyn_agreementbookingincident_DuplicateBaseRecord](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingproduct_DuplicateMatchingRecord"></a> msdyn_agreementbookingproduct_DuplicateMatchingRecord

See msdyn_agreementbookingproduct Entity [msdyn_agreementbookingproduct_DuplicateMatchingRecord](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingproduct_DuplicateBaseRecord"></a> msdyn_agreementbookingproduct_DuplicateBaseRecord

See msdyn_agreementbookingproduct Entity [msdyn_agreementbookingproduct_DuplicateBaseRecord](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservice_DuplicateMatchingRecord"></a> msdyn_agreementbookingservice_DuplicateMatchingRecord

See msdyn_agreementbookingservice Entity [msdyn_agreementbookingservice_DuplicateMatchingRecord](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservice_DuplicateBaseRecord"></a> msdyn_agreementbookingservice_DuplicateBaseRecord

See msdyn_agreementbookingservice Entity [msdyn_agreementbookingservice_DuplicateBaseRecord](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservicetask_DuplicateMatchingRecord"></a> msdyn_agreementbookingservicetask_DuplicateMatchingRecord

See msdyn_agreementbookingservicetask Entity [msdyn_agreementbookingservicetask_DuplicateMatchingRecord](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservicetask_DuplicateBaseRecord"></a> msdyn_agreementbookingservicetask_DuplicateBaseRecord

See msdyn_agreementbookingservicetask Entity [msdyn_agreementbookingservicetask_DuplicateBaseRecord](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingsetup_DuplicateMatchingRecord"></a> msdyn_agreementbookingsetup_DuplicateMatchingRecord

See msdyn_agreementbookingsetup Entity [msdyn_agreementbookingsetup_DuplicateMatchingRecord](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingsetup_DuplicateBaseRecord"></a> msdyn_agreementbookingsetup_DuplicateBaseRecord

See msdyn_agreementbookingsetup Entity [msdyn_agreementbookingsetup_DuplicateBaseRecord](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicedate_DuplicateMatchingRecord"></a> msdyn_agreementinvoicedate_DuplicateMatchingRecord

See msdyn_agreementinvoicedate Entity [msdyn_agreementinvoicedate_DuplicateMatchingRecord](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicedate_DuplicateBaseRecord"></a> msdyn_agreementinvoicedate_DuplicateBaseRecord

See msdyn_agreementinvoicedate Entity [msdyn_agreementinvoicedate_DuplicateBaseRecord](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoiceproduct_DuplicateMatchingRecord"></a> msdyn_agreementinvoiceproduct_DuplicateMatchingRecord

See msdyn_agreementinvoiceproduct Entity [msdyn_agreementinvoiceproduct_DuplicateMatchingRecord](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoiceproduct_DuplicateBaseRecord"></a> msdyn_agreementinvoiceproduct_DuplicateBaseRecord

See msdyn_agreementinvoiceproduct Entity [msdyn_agreementinvoiceproduct_DuplicateBaseRecord](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicesetup_DuplicateMatchingRecord"></a> msdyn_agreementinvoicesetup_DuplicateMatchingRecord

See msdyn_agreementinvoicesetup Entity [msdyn_agreementinvoicesetup_DuplicateMatchingRecord](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicesetup_DuplicateBaseRecord"></a> msdyn_agreementinvoicesetup_DuplicateBaseRecord

See msdyn_agreementinvoicesetup Entity [msdyn_agreementinvoicesetup_DuplicateBaseRecord](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementsubstatus_DuplicateMatchingRecord"></a> msdyn_agreementsubstatus_DuplicateMatchingRecord

See msdyn_agreementsubstatus Entity [msdyn_agreementsubstatus_DuplicateMatchingRecord](msdyn_agreementsubstatus.md#BKMK_msdyn_agreementsubstatus_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementsubstatus_DuplicateBaseRecord"></a> msdyn_agreementsubstatus_DuplicateBaseRecord

See msdyn_agreementsubstatus Entity [msdyn_agreementsubstatus_DuplicateBaseRecord](msdyn_agreementsubstatus.md#BKMK_msdyn_agreementsubstatus_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingtimestamp_DuplicateMatchingRecord"></a> msdyn_bookingtimestamp_DuplicateMatchingRecord

See msdyn_bookingtimestamp Entity [msdyn_bookingtimestamp_DuplicateMatchingRecord](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingtimestamp_DuplicateBaseRecord"></a> msdyn_bookingtimestamp_DuplicateBaseRecord

See msdyn_bookingtimestamp Entity [msdyn_bookingtimestamp_DuplicateBaseRecord](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_customerasset_DuplicateMatchingRecord"></a> msdyn_customerasset_DuplicateMatchingRecord

See msdyn_customerasset Entity [msdyn_customerasset_DuplicateMatchingRecord](msdyn_customerasset.md#BKMK_msdyn_customerasset_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_customerasset_DuplicateBaseRecord"></a> msdyn_customerasset_DuplicateBaseRecord

See msdyn_customerasset Entity [msdyn_customerasset_DuplicateBaseRecord](msdyn_customerasset.md#BKMK_msdyn_customerasset_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldservicepricelistitem_DuplicateMatchingRecord"></a> msdyn_fieldservicepricelistitem_DuplicateMatchingRecord

See msdyn_fieldservicepricelistitem Entity [msdyn_fieldservicepricelistitem_DuplicateMatchingRecord](msdyn_fieldservicepricelistitem.md#BKMK_msdyn_fieldservicepricelistitem_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldservicepricelistitem_DuplicateBaseRecord"></a> msdyn_fieldservicepricelistitem_DuplicateBaseRecord

See msdyn_fieldservicepricelistitem Entity [msdyn_fieldservicepricelistitem_DuplicateBaseRecord](msdyn_fieldservicepricelistitem.md#BKMK_msdyn_fieldservicepricelistitem_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttype_DuplicateMatchingRecord"></a> msdyn_incidenttype_DuplicateMatchingRecord

See msdyn_incidenttype Entity [msdyn_incidenttype_DuplicateMatchingRecord](msdyn_incidenttype.md#BKMK_msdyn_incidenttype_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttype_DuplicateBaseRecord"></a> msdyn_incidenttype_DuplicateBaseRecord

See msdyn_incidenttype Entity [msdyn_incidenttype_DuplicateBaseRecord](msdyn_incidenttype.md#BKMK_msdyn_incidenttype_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypecharacteristic_DuplicateMatchingRecord"></a> msdyn_incidenttypecharacteristic_DuplicateMatchingRecord

See msdyn_incidenttypecharacteristic Entity [msdyn_incidenttypecharacteristic_DuplicateMatchingRecord](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypecharacteristic_DuplicateBaseRecord"></a> msdyn_incidenttypecharacteristic_DuplicateBaseRecord

See msdyn_incidenttypecharacteristic Entity [msdyn_incidenttypecharacteristic_DuplicateBaseRecord](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeproduct_DuplicateMatchingRecord"></a> msdyn_incidenttypeproduct_DuplicateMatchingRecord

See msdyn_incidenttypeproduct Entity [msdyn_incidenttypeproduct_DuplicateMatchingRecord](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeproduct_DuplicateBaseRecord"></a> msdyn_incidenttypeproduct_DuplicateBaseRecord

See msdyn_incidenttypeproduct Entity [msdyn_incidenttypeproduct_DuplicateBaseRecord](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeservice_DuplicateMatchingRecord"></a> msdyn_incidenttypeservice_DuplicateMatchingRecord

See msdyn_incidenttypeservice Entity [msdyn_incidenttypeservice_DuplicateMatchingRecord](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeservice_DuplicateBaseRecord"></a> msdyn_incidenttypeservice_DuplicateBaseRecord

See msdyn_incidenttypeservice Entity [msdyn_incidenttypeservice_DuplicateBaseRecord](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeservicetask_DuplicateMatchingRecord"></a> msdyn_incidenttypeservicetask_DuplicateMatchingRecord

See msdyn_incidenttypeservicetask Entity [msdyn_incidenttypeservicetask_DuplicateMatchingRecord](msdyn_incidenttypeservicetask.md#BKMK_msdyn_incidenttypeservicetask_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeservicetask_DuplicateBaseRecord"></a> msdyn_incidenttypeservicetask_DuplicateBaseRecord

See msdyn_incidenttypeservicetask Entity [msdyn_incidenttypeservicetask_DuplicateBaseRecord](msdyn_incidenttypeservicetask.md#BKMK_msdyn_incidenttypeservicetask_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustment_DuplicateMatchingRecord"></a> msdyn_inventoryadjustment_DuplicateMatchingRecord

See msdyn_inventoryadjustment Entity [msdyn_inventoryadjustment_DuplicateMatchingRecord](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustment_DuplicateBaseRecord"></a> msdyn_inventoryadjustment_DuplicateBaseRecord

See msdyn_inventoryadjustment Entity [msdyn_inventoryadjustment_DuplicateBaseRecord](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustmentproduct_DuplicateMatchingRecord"></a> msdyn_inventoryadjustmentproduct_DuplicateMatchingRecord

See msdyn_inventoryadjustmentproduct Entity [msdyn_inventoryadjustmentproduct_DuplicateMatchingRecord](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustmentproduct_DuplicateBaseRecord"></a> msdyn_inventoryadjustmentproduct_DuplicateBaseRecord

See msdyn_inventoryadjustmentproduct Entity [msdyn_inventoryadjustmentproduct_DuplicateBaseRecord](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryjournal_DuplicateMatchingRecord"></a> msdyn_inventoryjournal_DuplicateMatchingRecord

See msdyn_inventoryjournal Entity [msdyn_inventoryjournal_DuplicateMatchingRecord](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryjournal_DuplicateBaseRecord"></a> msdyn_inventoryjournal_DuplicateBaseRecord

See msdyn_inventoryjournal Entity [msdyn_inventoryjournal_DuplicateBaseRecord](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_inventorytransfer_DuplicateMatchingRecord"></a> msdyn_inventorytransfer_DuplicateMatchingRecord

See msdyn_inventorytransfer Entity [msdyn_inventorytransfer_DuplicateMatchingRecord](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_inventorytransfer_DuplicateBaseRecord"></a> msdyn_inventorytransfer_DuplicateBaseRecord

See msdyn_inventorytransfer Entity [msdyn_inventorytransfer_DuplicateBaseRecord](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_orderinvoicingdate_DuplicateMatchingRecord"></a> msdyn_orderinvoicingdate_DuplicateMatchingRecord

See msdyn_orderinvoicingdate Entity [msdyn_orderinvoicingdate_DuplicateMatchingRecord](msdyn_orderinvoicingdate.md#BKMK_msdyn_orderinvoicingdate_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_orderinvoicingdate_DuplicateBaseRecord"></a> msdyn_orderinvoicingdate_DuplicateBaseRecord

See msdyn_orderinvoicingdate Entity [msdyn_orderinvoicingdate_DuplicateBaseRecord](msdyn_orderinvoicingdate.md#BKMK_msdyn_orderinvoicingdate_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_orderinvoicingproduct_DuplicateMatchingRecord"></a> msdyn_orderinvoicingproduct_DuplicateMatchingRecord

See msdyn_orderinvoicingproduct Entity [msdyn_orderinvoicingproduct_DuplicateMatchingRecord](msdyn_orderinvoicingproduct.md#BKMK_msdyn_orderinvoicingproduct_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_orderinvoicingproduct_DuplicateBaseRecord"></a> msdyn_orderinvoicingproduct_DuplicateBaseRecord

See msdyn_orderinvoicingproduct Entity [msdyn_orderinvoicingproduct_DuplicateBaseRecord](msdyn_orderinvoicingproduct.md#BKMK_msdyn_orderinvoicingproduct_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_orderinvoicingsetup_DuplicateMatchingRecord"></a> msdyn_orderinvoicingsetup_DuplicateMatchingRecord

See msdyn_orderinvoicingsetup Entity [msdyn_orderinvoicingsetup_DuplicateMatchingRecord](msdyn_orderinvoicingsetup.md#BKMK_msdyn_orderinvoicingsetup_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_orderinvoicingsetup_DuplicateBaseRecord"></a> msdyn_orderinvoicingsetup_DuplicateBaseRecord

See msdyn_orderinvoicingsetup Entity [msdyn_orderinvoicingsetup_DuplicateBaseRecord](msdyn_orderinvoicingsetup.md#BKMK_msdyn_orderinvoicingsetup_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_orderinvoicingsetupdate_DuplicateMatchingRecord"></a> msdyn_orderinvoicingsetupdate_DuplicateMatchingRecord

See msdyn_orderinvoicingsetupdate Entity [msdyn_orderinvoicingsetupdate_DuplicateMatchingRecord](msdyn_orderinvoicingsetupdate.md#BKMK_msdyn_orderinvoicingsetupdate_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_orderinvoicingsetupdate_DuplicateBaseRecord"></a> msdyn_orderinvoicingsetupdate_DuplicateBaseRecord

See msdyn_orderinvoicingsetupdate Entity [msdyn_orderinvoicingsetupdate_DuplicateBaseRecord](msdyn_orderinvoicingsetupdate.md#BKMK_msdyn_orderinvoicingsetupdate_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_payment_DuplicateMatchingRecord"></a> msdyn_payment_DuplicateMatchingRecord

See msdyn_payment Entity [msdyn_payment_DuplicateMatchingRecord](msdyn_payment.md#BKMK_msdyn_payment_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_payment_DuplicateBaseRecord"></a> msdyn_payment_DuplicateBaseRecord

See msdyn_payment Entity [msdyn_payment_DuplicateBaseRecord](msdyn_payment.md#BKMK_msdyn_payment_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentdetail_DuplicateMatchingRecord"></a> msdyn_paymentdetail_DuplicateMatchingRecord

See msdyn_paymentdetail Entity [msdyn_paymentdetail_DuplicateMatchingRecord](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentdetail_DuplicateBaseRecord"></a> msdyn_paymentdetail_DuplicateBaseRecord

See msdyn_paymentdetail Entity [msdyn_paymentdetail_DuplicateBaseRecord](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentmethod_DuplicateMatchingRecord"></a> msdyn_paymentmethod_DuplicateMatchingRecord

See msdyn_paymentmethod Entity [msdyn_paymentmethod_DuplicateMatchingRecord](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentmethod_DuplicateBaseRecord"></a> msdyn_paymentmethod_DuplicateBaseRecord

See msdyn_paymentmethod Entity [msdyn_paymentmethod_DuplicateBaseRecord](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentterm_DuplicateMatchingRecord"></a> msdyn_paymentterm_DuplicateMatchingRecord

See msdyn_paymentterm Entity [msdyn_paymentterm_DuplicateMatchingRecord](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentterm_DuplicateBaseRecord"></a> msdyn_paymentterm_DuplicateBaseRecord

See msdyn_paymentterm Entity [msdyn_paymentterm_DuplicateBaseRecord](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_postalcode_DuplicateMatchingRecord"></a> msdyn_postalcode_DuplicateMatchingRecord

See msdyn_postalcode Entity [msdyn_postalcode_DuplicateMatchingRecord](msdyn_postalcode.md#BKMK_msdyn_postalcode_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_postalcode_DuplicateBaseRecord"></a> msdyn_postalcode_DuplicateBaseRecord

See msdyn_postalcode Entity [msdyn_postalcode_DuplicateBaseRecord](msdyn_postalcode.md#BKMK_msdyn_postalcode_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_productinventory_DuplicateMatchingRecord"></a> msdyn_productinventory_DuplicateMatchingRecord

See msdyn_productinventory Entity [msdyn_productinventory_DuplicateMatchingRecord](msdyn_productinventory.md#BKMK_msdyn_productinventory_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_productinventory_DuplicateBaseRecord"></a> msdyn_productinventory_DuplicateBaseRecord

See msdyn_productinventory Entity [msdyn_productinventory_DuplicateBaseRecord](msdyn_productinventory.md#BKMK_msdyn_productinventory_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorder_DuplicateMatchingRecord"></a> msdyn_purchaseorder_DuplicateMatchingRecord

See msdyn_purchaseorder Entity [msdyn_purchaseorder_DuplicateMatchingRecord](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorder_DuplicateBaseRecord"></a> msdyn_purchaseorder_DuplicateBaseRecord

See msdyn_purchaseorder Entity [msdyn_purchaseorder_DuplicateBaseRecord](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderbill_DuplicateMatchingRecord"></a> msdyn_purchaseorderbill_DuplicateMatchingRecord

See msdyn_purchaseorderbill Entity [msdyn_purchaseorderbill_DuplicateMatchingRecord](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderbill_DuplicateBaseRecord"></a> msdyn_purchaseorderbill_DuplicateBaseRecord

See msdyn_purchaseorderbill Entity [msdyn_purchaseorderbill_DuplicateBaseRecord](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceipt_DuplicateMatchingRecord"></a> msdyn_purchaseorderreceipt_DuplicateMatchingRecord

See msdyn_purchaseorderreceipt Entity [msdyn_purchaseorderreceipt_DuplicateMatchingRecord](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceipt_DuplicateBaseRecord"></a> msdyn_purchaseorderreceipt_DuplicateBaseRecord

See msdyn_purchaseorderreceipt Entity [msdyn_purchaseorderreceipt_DuplicateBaseRecord](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_DuplicateMatchingRecord"></a> msdyn_purchaseorderreceiptproduct_DuplicateMatchingRecord

See msdyn_purchaseorderreceiptproduct Entity [msdyn_purchaseorderreceiptproduct_DuplicateMatchingRecord](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_DuplicateBaseRecord"></a> msdyn_purchaseorderreceiptproduct_DuplicateBaseRecord

See msdyn_purchaseorderreceiptproduct Entity [msdyn_purchaseorderreceiptproduct_DuplicateBaseRecord](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseordersubstatus_DuplicateMatchingRecord"></a> msdyn_purchaseordersubstatus_DuplicateMatchingRecord

See msdyn_purchaseordersubstatus Entity [msdyn_purchaseordersubstatus_DuplicateMatchingRecord](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseordersubstatus_DuplicateBaseRecord"></a> msdyn_purchaseordersubstatus_DuplicateBaseRecord

See msdyn_purchaseordersubstatus Entity [msdyn_purchaseordersubstatus_DuplicateBaseRecord](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingincident_DuplicateMatchingRecord"></a> msdyn_quotebookingincident_DuplicateMatchingRecord

See msdyn_quotebookingincident Entity [msdyn_quotebookingincident_DuplicateMatchingRecord](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingincident_DuplicateBaseRecord"></a> msdyn_quotebookingincident_DuplicateBaseRecord

See msdyn_quotebookingincident Entity [msdyn_quotebookingincident_DuplicateBaseRecord](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingproduct_DuplicateMatchingRecord"></a> msdyn_quotebookingproduct_DuplicateMatchingRecord

See msdyn_quotebookingproduct Entity [msdyn_quotebookingproduct_DuplicateMatchingRecord](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingproduct_DuplicateBaseRecord"></a> msdyn_quotebookingproduct_DuplicateBaseRecord

See msdyn_quotebookingproduct Entity [msdyn_quotebookingproduct_DuplicateBaseRecord](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservice_DuplicateMatchingRecord"></a> msdyn_quotebookingservice_DuplicateMatchingRecord

See msdyn_quotebookingservice Entity [msdyn_quotebookingservice_DuplicateMatchingRecord](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservice_DuplicateBaseRecord"></a> msdyn_quotebookingservice_DuplicateBaseRecord

See msdyn_quotebookingservice Entity [msdyn_quotebookingservice_DuplicateBaseRecord](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservicetask_DuplicateMatchingRecord"></a> msdyn_quotebookingservicetask_DuplicateMatchingRecord

See msdyn_quotebookingservicetask Entity [msdyn_quotebookingservicetask_DuplicateMatchingRecord](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservicetask_DuplicateBaseRecord"></a> msdyn_quotebookingservicetask_DuplicateBaseRecord

See msdyn_quotebookingservicetask Entity [msdyn_quotebookingservicetask_DuplicateBaseRecord](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingsetup_DuplicateMatchingRecord"></a> msdyn_quotebookingsetup_DuplicateMatchingRecord

See msdyn_quotebookingsetup Entity [msdyn_quotebookingsetup_DuplicateMatchingRecord](msdyn_quotebookingsetup.md#BKMK_msdyn_quotebookingsetup_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingsetup_DuplicateBaseRecord"></a> msdyn_quotebookingsetup_DuplicateBaseRecord

See msdyn_quotebookingsetup Entity [msdyn_quotebookingsetup_DuplicateBaseRecord](msdyn_quotebookingsetup.md#BKMK_msdyn_quotebookingsetup_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_quoteinvoicingproduct_DuplicateMatchingRecord"></a> msdyn_quoteinvoicingproduct_DuplicateMatchingRecord

See msdyn_quoteinvoicingproduct Entity [msdyn_quoteinvoicingproduct_DuplicateMatchingRecord](msdyn_quoteinvoicingproduct.md#BKMK_msdyn_quoteinvoicingproduct_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_quoteinvoicingproduct_DuplicateBaseRecord"></a> msdyn_quoteinvoicingproduct_DuplicateBaseRecord

See msdyn_quoteinvoicingproduct Entity [msdyn_quoteinvoicingproduct_DuplicateBaseRecord](msdyn_quoteinvoicingproduct.md#BKMK_msdyn_quoteinvoicingproduct_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_quoteinvoicingsetup_DuplicateMatchingRecord"></a> msdyn_quoteinvoicingsetup_DuplicateMatchingRecord

See msdyn_quoteinvoicingsetup Entity [msdyn_quoteinvoicingsetup_DuplicateMatchingRecord](msdyn_quoteinvoicingsetup.md#BKMK_msdyn_quoteinvoicingsetup_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_quoteinvoicingsetup_DuplicateBaseRecord"></a> msdyn_quoteinvoicingsetup_DuplicateBaseRecord

See msdyn_quoteinvoicingsetup Entity [msdyn_quoteinvoicingsetup_DuplicateBaseRecord](msdyn_quoteinvoicingsetup.md#BKMK_msdyn_quoteinvoicingsetup_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_rma_DuplicateMatchingRecord"></a> msdyn_rma_DuplicateMatchingRecord

See msdyn_rma Entity [msdyn_rma_DuplicateMatchingRecord](msdyn_rma.md#BKMK_msdyn_rma_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_rma_DuplicateBaseRecord"></a> msdyn_rma_DuplicateBaseRecord

See msdyn_rma Entity [msdyn_rma_DuplicateBaseRecord](msdyn_rma.md#BKMK_msdyn_rma_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceipt_DuplicateMatchingRecord"></a> msdyn_rmareceipt_DuplicateMatchingRecord

See msdyn_rmareceipt Entity [msdyn_rmareceipt_DuplicateMatchingRecord](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceipt_DuplicateBaseRecord"></a> msdyn_rmareceipt_DuplicateBaseRecord

See msdyn_rmareceipt Entity [msdyn_rmareceipt_DuplicateBaseRecord](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceiptproduct_DuplicateMatchingRecord"></a> msdyn_rmareceiptproduct_DuplicateMatchingRecord

See msdyn_rmareceiptproduct Entity [msdyn_rmareceiptproduct_DuplicateMatchingRecord](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceiptproduct_DuplicateBaseRecord"></a> msdyn_rmareceiptproduct_DuplicateBaseRecord

See msdyn_rmareceiptproduct Entity [msdyn_rmareceiptproduct_DuplicateBaseRecord](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_rmasubstatus_DuplicateMatchingRecord"></a> msdyn_rmasubstatus_DuplicateMatchingRecord

See msdyn_rmasubstatus Entity [msdyn_rmasubstatus_DuplicateMatchingRecord](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_rmasubstatus_DuplicateBaseRecord"></a> msdyn_rmasubstatus_DuplicateBaseRecord

See msdyn_rmasubstatus Entity [msdyn_rmasubstatus_DuplicateBaseRecord](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_rtv_DuplicateMatchingRecord"></a> msdyn_rtv_DuplicateMatchingRecord

See msdyn_rtv Entity [msdyn_rtv_DuplicateMatchingRecord](msdyn_rtv.md#BKMK_msdyn_rtv_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_rtv_DuplicateBaseRecord"></a> msdyn_rtv_DuplicateBaseRecord

See msdyn_rtv Entity [msdyn_rtv_DuplicateBaseRecord](msdyn_rtv.md#BKMK_msdyn_rtv_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvproduct_DuplicateMatchingRecord"></a> msdyn_rtvproduct_DuplicateMatchingRecord

See msdyn_rtvproduct Entity [msdyn_rtvproduct_DuplicateMatchingRecord](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvproduct_DuplicateBaseRecord"></a> msdyn_rtvproduct_DuplicateBaseRecord

See msdyn_rtvproduct Entity [msdyn_rtvproduct_DuplicateBaseRecord](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvsubstatus_DuplicateMatchingRecord"></a> msdyn_rtvsubstatus_DuplicateMatchingRecord

See msdyn_rtvsubstatus Entity [msdyn_rtvsubstatus_DuplicateMatchingRecord](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvsubstatus_DuplicateBaseRecord"></a> msdyn_rtvsubstatus_DuplicateBaseRecord

See msdyn_rtvsubstatus Entity [msdyn_rtvsubstatus_DuplicateBaseRecord](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_servicetasktype_DuplicateMatchingRecord"></a> msdyn_servicetasktype_DuplicateMatchingRecord

See msdyn_servicetasktype Entity [msdyn_servicetasktype_DuplicateMatchingRecord](msdyn_servicetasktype.md#BKMK_msdyn_servicetasktype_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_servicetasktype_DuplicateBaseRecord"></a> msdyn_servicetasktype_DuplicateBaseRecord

See msdyn_servicetasktype Entity [msdyn_servicetasktype_DuplicateBaseRecord](msdyn_servicetasktype.md#BKMK_msdyn_servicetasktype_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_shipvia_DuplicateMatchingRecord"></a> msdyn_shipvia_DuplicateMatchingRecord

See msdyn_shipvia Entity [msdyn_shipvia_DuplicateMatchingRecord](msdyn_shipvia.md#BKMK_msdyn_shipvia_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_shipvia_DuplicateBaseRecord"></a> msdyn_shipvia_DuplicateBaseRecord

See msdyn_shipvia Entity [msdyn_shipvia_DuplicateBaseRecord](msdyn_shipvia.md#BKMK_msdyn_shipvia_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_taxcode_DuplicateMatchingRecord"></a> msdyn_taxcode_DuplicateMatchingRecord

See msdyn_taxcode Entity [msdyn_taxcode_DuplicateMatchingRecord](msdyn_taxcode.md#BKMK_msdyn_taxcode_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_taxcode_DuplicateBaseRecord"></a> msdyn_taxcode_DuplicateBaseRecord

See msdyn_taxcode Entity [msdyn_taxcode_DuplicateBaseRecord](msdyn_taxcode.md#BKMK_msdyn_taxcode_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_taxcodedetail_DuplicateMatchingRecord"></a> msdyn_taxcodedetail_DuplicateMatchingRecord

See msdyn_taxcodedetail Entity [msdyn_taxcodedetail_DuplicateMatchingRecord](msdyn_taxcodedetail.md#BKMK_msdyn_taxcodedetail_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_taxcodedetail_DuplicateBaseRecord"></a> msdyn_taxcodedetail_DuplicateBaseRecord

See msdyn_taxcodedetail Entity [msdyn_taxcodedetail_DuplicateBaseRecord](msdyn_taxcodedetail.md#BKMK_msdyn_taxcodedetail_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_timeoffrequest_DuplicateMatchingRecord"></a> msdyn_timeoffrequest_DuplicateMatchingRecord

See msdyn_timeoffrequest Entity [msdyn_timeoffrequest_DuplicateMatchingRecord](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_timeoffrequest_DuplicateBaseRecord"></a> msdyn_timeoffrequest_DuplicateBaseRecord

See msdyn_timeoffrequest Entity [msdyn_timeoffrequest_DuplicateBaseRecord](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_warehouse_DuplicateMatchingRecord"></a> msdyn_warehouse_DuplicateMatchingRecord

See msdyn_warehouse Entity [msdyn_warehouse_DuplicateMatchingRecord](msdyn_warehouse.md#BKMK_msdyn_warehouse_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_warehouse_DuplicateBaseRecord"></a> msdyn_warehouse_DuplicateBaseRecord

See msdyn_warehouse Entity [msdyn_warehouse_DuplicateBaseRecord](msdyn_warehouse.md#BKMK_msdyn_warehouse_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_workorder_DuplicateMatchingRecord"></a> msdyn_workorder_DuplicateMatchingRecord

See msdyn_workorder Entity [msdyn_workorder_DuplicateMatchingRecord](msdyn_workorder.md#BKMK_msdyn_workorder_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_workorder_DuplicateBaseRecord"></a> msdyn_workorder_DuplicateBaseRecord

See msdyn_workorder Entity [msdyn_workorder_DuplicateBaseRecord](msdyn_workorder.md#BKMK_msdyn_workorder_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_workordercharacteristic_DuplicateMatchingRecord"></a> msdyn_workordercharacteristic_DuplicateMatchingRecord

See msdyn_workordercharacteristic Entity [msdyn_workordercharacteristic_DuplicateMatchingRecord](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_workordercharacteristic_DuplicateBaseRecord"></a> msdyn_workordercharacteristic_DuplicateBaseRecord

See msdyn_workordercharacteristic Entity [msdyn_workordercharacteristic_DuplicateBaseRecord](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderdetailsgenerationqueue_DuplicateMatchingRecord"></a> msdyn_workorderdetailsgenerationqueue_DuplicateMatchingRecord

See msdyn_workorderdetailsgenerationqueue Entity [msdyn_workorderdetailsgenerationqueue_DuplicateMatchingRecord](msdyn_workorderdetailsgenerationqueue.md#BKMK_msdyn_workorderdetailsgenerationqueue_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderdetailsgenerationqueue_DuplicateBaseRecord"></a> msdyn_workorderdetailsgenerationqueue_DuplicateBaseRecord

See msdyn_workorderdetailsgenerationqueue Entity [msdyn_workorderdetailsgenerationqueue_DuplicateBaseRecord](msdyn_workorderdetailsgenerationqueue.md#BKMK_msdyn_workorderdetailsgenerationqueue_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderincident_DuplicateMatchingRecord"></a> msdyn_workorderincident_DuplicateMatchingRecord

See msdyn_workorderincident Entity [msdyn_workorderincident_DuplicateMatchingRecord](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderincident_DuplicateBaseRecord"></a> msdyn_workorderincident_DuplicateBaseRecord

See msdyn_workorderincident Entity [msdyn_workorderincident_DuplicateBaseRecord](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderresourcerestriction_DuplicateMatchingRecord"></a> msdyn_workorderresourcerestriction_DuplicateMatchingRecord

See msdyn_workorderresourcerestriction Entity [msdyn_workorderresourcerestriction_DuplicateMatchingRecord](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderresourcerestriction_DuplicateBaseRecord"></a> msdyn_workorderresourcerestriction_DuplicateBaseRecord

See msdyn_workorderresourcerestriction Entity [msdyn_workorderresourcerestriction_DuplicateBaseRecord](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservice_DuplicateMatchingRecord"></a> msdyn_workorderservice_DuplicateMatchingRecord

See msdyn_workorderservice Entity [msdyn_workorderservice_DuplicateMatchingRecord](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservice_DuplicateBaseRecord"></a> msdyn_workorderservice_DuplicateBaseRecord

See msdyn_workorderservice Entity [msdyn_workorderservice_DuplicateBaseRecord](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservicetask_DuplicateMatchingRecord"></a> msdyn_workorderservicetask_DuplicateMatchingRecord

See msdyn_workorderservicetask Entity [msdyn_workorderservicetask_DuplicateMatchingRecord](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservicetask_DuplicateBaseRecord"></a> msdyn_workorderservicetask_DuplicateBaseRecord

See msdyn_workorderservicetask Entity [msdyn_workorderservicetask_DuplicateBaseRecord](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_workordersubstatus_DuplicateMatchingRecord"></a> msdyn_workordersubstatus_DuplicateMatchingRecord

See msdyn_workordersubstatus Entity [msdyn_workordersubstatus_DuplicateMatchingRecord](msdyn_workordersubstatus.md#BKMK_msdyn_workordersubstatus_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_workordersubstatus_DuplicateBaseRecord"></a> msdyn_workordersubstatus_DuplicateBaseRecord

See msdyn_workordersubstatus Entity [msdyn_workordersubstatus_DuplicateBaseRecord](msdyn_workordersubstatus.md#BKMK_msdyn_workordersubstatus_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_workordertype_DuplicateMatchingRecord"></a> msdyn_workordertype_DuplicateMatchingRecord

See msdyn_workordertype Entity [msdyn_workordertype_DuplicateMatchingRecord](msdyn_workordertype.md#BKMK_msdyn_workordertype_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_msdyn_workordertype_DuplicateBaseRecord"></a> msdyn_workordertype_DuplicateBaseRecord

See msdyn_workordertype Entity [msdyn_workordertype_DuplicateBaseRecord](msdyn_workordertype.md#BKMK_msdyn_workordertype_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_knowledgearticle_DuplicateMatchingRecord"></a> knowledgearticle_DuplicateMatchingRecord

See knowledgearticle Entity [knowledgearticle_DuplicateMatchingRecord](knowledgearticle.md#BKMK_knowledgearticle_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_knowledgearticle_DuplicateBaseRecord"></a> knowledgearticle_DuplicateBaseRecord

See knowledgearticle Entity [knowledgearticle_DuplicateBaseRecord](knowledgearticle.md#BKMK_knowledgearticle_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_channelaccessprofile_DuplicateMatchingRecord"></a> channelaccessprofile_DuplicateMatchingRecord

See channelaccessprofile Entity [channelaccessprofile_DuplicateMatchingRecord](channelaccessprofile.md#BKMK_channelaccessprofile_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_channelaccessprofile_DuplicateBaseRecord"></a> channelaccessprofile_DuplicateBaseRecord

See channelaccessprofile Entity [channelaccessprofile_DuplicateBaseRecord](channelaccessprofile.md#BKMK_channelaccessprofile_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_KnowledgeBaseRecord_DuplicateMatchingRecord"></a> KnowledgeBaseRecord_DuplicateMatchingRecord

See knowledgebaserecord Entity [KnowledgeBaseRecord_DuplicateMatchingRecord](knowledgebaserecord.md#BKMK_KnowledgeBaseRecord_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_KnowledgeBaseRecord_DuplicateBaseRecord"></a> KnowledgeBaseRecord_DuplicateBaseRecord

See knowledgebaserecord Entity [KnowledgeBaseRecord_DuplicateBaseRecord](knowledgebaserecord.md#BKMK_KnowledgeBaseRecord_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_Email_DuplicateMatchingRecord"></a> Email_DuplicateMatchingRecord

See email Entity [Email_DuplicateMatchingRecord](email.md#BKMK_Email_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_Publisher_DuplicateMatchingRecord"></a> Publisher_DuplicateMatchingRecord

See publisher Entity [Publisher_DuplicateMatchingRecord](publisher.md#BKMK_Publisher_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_Queue_DuplicateBaseRecord"></a> Queue_DuplicateBaseRecord

See queue Entity [Queue_DuplicateBaseRecord](queue.md#BKMK_Queue_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_Letter_DuplicateBaseRecord"></a> Letter_DuplicateBaseRecord

See letter Entity [Letter_DuplicateBaseRecord](letter.md#BKMK_Letter_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_Team_DuplicateBaseRecord"></a> Team_DuplicateBaseRecord

See team Entity [Team_DuplicateBaseRecord](team.md#BKMK_Team_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_KbArticle_DuplicateMatchingRecord"></a> KbArticle_DuplicateMatchingRecord

See kbarticle Entity [KbArticle_DuplicateMatchingRecord](kbarticle.md#BKMK_KbArticle_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_Appointment_DuplicateBaseRecord"></a> Appointment_DuplicateBaseRecord

See appointment Entity [Appointment_DuplicateBaseRecord](appointment.md#BKMK_Appointment_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_Account_DuplicateBaseRecord"></a> Account_DuplicateBaseRecord

See account Entity [Account_DuplicateBaseRecord](account.md#BKMK_Account_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_DuplicateRule_DuplicateBaseRecord"></a> DuplicateRule_DuplicateBaseRecord

See duplicaterule Entity [DuplicateRule_DuplicateBaseRecord](duplicaterule.md#BKMK_DuplicateRule_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_SharePointSite_DuplicateBaseRecord"></a> SharePointSite_DuplicateBaseRecord

See sharepointsite Entity [SharePointSite_DuplicateBaseRecord](sharepointsite.md#BKMK_SharePointSite_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_KbArticle_DuplicateBaseRecord"></a> KbArticle_DuplicateBaseRecord

See kbarticle Entity [KbArticle_DuplicateBaseRecord](kbarticle.md#BKMK_KbArticle_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_Task_DuplicateMatchingRecord"></a> Task_DuplicateMatchingRecord

See task Entity [Task_DuplicateMatchingRecord](task.md#BKMK_Task_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_SocialProfile_DuplicateMatchingRecord"></a> SocialProfile_DuplicateMatchingRecord

See socialprofile Entity [SocialProfile_DuplicateMatchingRecord](socialprofile.md#BKMK_SocialProfile_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_PhoneCall_DuplicateBaseRecord"></a> PhoneCall_DuplicateBaseRecord

See phonecall Entity [PhoneCall_DuplicateBaseRecord](phonecall.md#BKMK_PhoneCall_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_DuplicateMatchingRecord"></a> TransactionCurrency_DuplicateMatchingRecord

See transactioncurrency Entity [TransactionCurrency_DuplicateMatchingRecord](transactioncurrency.md#BKMK_TransactionCurrency_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_Goal_DuplicateMatchingRecord"></a> Goal_DuplicateMatchingRecord

See goal Entity [Goal_DuplicateMatchingRecord](goal.md#BKMK_Goal_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_SharePointSite_DuplicateMatchingRecord"></a> SharePointSite_DuplicateMatchingRecord

See sharepointsite Entity [SharePointSite_DuplicateMatchingRecord](sharepointsite.md#BKMK_SharePointSite_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_emailserverprofile_duplicatebaserecord"></a> emailserverprofile_duplicatebaserecord

See emailserverprofile Entity [emailserverprofile_duplicatebaserecord](emailserverprofile.md#BKMK_emailserverprofile_duplicatebaserecord) One-To-Many relationship.

### <a name="BKMK_Publisher_DuplicateBaseRecord"></a> Publisher_DuplicateBaseRecord

See publisher Entity [Publisher_DuplicateBaseRecord](publisher.md#BKMK_Publisher_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_SystemUser_DuplicateBaseRecord"></a> SystemUser_DuplicateBaseRecord

See systemuser Entity [SystemUser_DuplicateBaseRecord](systemuser.md#BKMK_SystemUser_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_SocialActivity_DuplicateBaseRecord"></a> SocialActivity_DuplicateBaseRecord

See socialactivity Entity [SocialActivity_DuplicateBaseRecord](socialactivity.md#BKMK_SocialActivity_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_Contact_DuplicateMatchingRecord"></a> Contact_DuplicateMatchingRecord

See contact Entity [Contact_DuplicateMatchingRecord](contact.md#BKMK_Contact_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_GoalRollupQuery_DuplicateMatchingRecord"></a> GoalRollupQuery_DuplicateMatchingRecord

See goalrollupquery Entity [GoalRollupQuery_DuplicateMatchingRecord](goalrollupquery.md#BKMK_GoalRollupQuery_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_Contact_DuplicateBaseRecord"></a> Contact_DuplicateBaseRecord

See contact Entity [Contact_DuplicateBaseRecord](contact.md#BKMK_Contact_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_TransactionCurrency_DuplicateBaseRecord"></a> TransactionCurrency_DuplicateBaseRecord

See transactioncurrency Entity [TransactionCurrency_DuplicateBaseRecord](transactioncurrency.md#BKMK_TransactionCurrency_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_Email_DuplicateBaseRecord"></a> Email_DuplicateBaseRecord

See email Entity [Email_DuplicateBaseRecord](email.md#BKMK_Email_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_PhoneCall_DuplicateMatchingRecord"></a> PhoneCall_DuplicateMatchingRecord

See phonecall Entity [PhoneCall_DuplicateMatchingRecord](phonecall.md#BKMK_PhoneCall_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_Team_DuplicateMatchingRecord"></a> Team_DuplicateMatchingRecord

See team Entity [Team_DuplicateMatchingRecord](team.md#BKMK_Team_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_SystemUser_DuplicateMatchingRecord"></a> SystemUser_DuplicateMatchingRecord

See systemuser Entity [SystemUser_DuplicateMatchingRecord](systemuser.md#BKMK_SystemUser_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_Appointment_DuplicateMatchingRecord"></a> Appointment_DuplicateMatchingRecord

See appointment Entity [Appointment_DuplicateMatchingRecord](appointment.md#BKMK_Appointment_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_Account_DuplicateMatchingRecord"></a> Account_DuplicateMatchingRecord

See account Entity [Account_DuplicateMatchingRecord](account.md#BKMK_Account_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_Fax_DuplicateBaseRecord"></a> Fax_DuplicateBaseRecord

See fax Entity [Fax_DuplicateBaseRecord](fax.md#BKMK_Fax_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_Letter_DuplicateMatchingRecord"></a> Letter_DuplicateMatchingRecord

See letter Entity [Letter_DuplicateMatchingRecord](letter.md#BKMK_Letter_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_emailserverprofile_duplicatematchingrecord"></a> emailserverprofile_duplicatematchingrecord

See emailserverprofile Entity [emailserverprofile_duplicatematchingrecord](emailserverprofile.md#BKMK_emailserverprofile_duplicatematchingrecord) One-To-Many relationship.

### <a name="BKMK_SharePointDocumentLocation_DuplicateBaseRecord"></a> SharePointDocumentLocation_DuplicateBaseRecord

See sharepointdocumentlocation Entity [SharePointDocumentLocation_DuplicateBaseRecord](sharepointdocumentlocation.md#BKMK_SharePointDocumentLocation_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_Goal_DuplicateBaseRecord"></a> Goal_DuplicateBaseRecord

See goal Entity [Goal_DuplicateBaseRecord](goal.md#BKMK_Goal_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_RecurringAppointmentMaster_DuplicateMatchingRecord"></a> RecurringAppointmentMaster_DuplicateMatchingRecord

See recurringappointmentmaster Entity [RecurringAppointmentMaster_DuplicateMatchingRecord](recurringappointmentmaster.md#BKMK_RecurringAppointmentMaster_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_Task_DuplicateBaseRecord"></a> Task_DuplicateBaseRecord

See task Entity [Task_DuplicateBaseRecord](task.md#BKMK_Task_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_RecurringAppointmentMaster_DuplicateBaseRecord"></a> RecurringAppointmentMaster_DuplicateBaseRecord

See recurringappointmentmaster Entity [RecurringAppointmentMaster_DuplicateBaseRecord](recurringappointmentmaster.md#BKMK_RecurringAppointmentMaster_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_Queue_DuplicateMatchingRecord"></a> Queue_DuplicateMatchingRecord

See queue Entity [Queue_DuplicateMatchingRecord](queue.md#BKMK_Queue_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_SocialProfile_DuplicateBaseRecord"></a> SocialProfile_DuplicateBaseRecord

See socialprofile Entity [SocialProfile_DuplicateBaseRecord](socialprofile.md#BKMK_SocialProfile_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_SharePointDocumentLocation_DuplicateMatchingRecord"></a> SharePointDocumentLocation_DuplicateMatchingRecord

See sharepointdocumentlocation Entity [SharePointDocumentLocation_DuplicateMatchingRecord](sharepointdocumentlocation.md#BKMK_SharePointDocumentLocation_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_GoalRollupQuery_DuplicateBaseRecord"></a> GoalRollupQuery_DuplicateBaseRecord

See goalrollupquery Entity [GoalRollupQuery_DuplicateBaseRecord](goalrollupquery.md#BKMK_GoalRollupQuery_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_AsyncOperation_DuplicateBaseRecord"></a> AsyncOperation_DuplicateBaseRecord

See asyncoperation Entity [AsyncOperation_DuplicateBaseRecord](asyncoperation.md#BKMK_AsyncOperation_DuplicateBaseRecord) One-To-Many relationship.

### <a name="BKMK_Fax_DuplicateMatchingRecord"></a> Fax_DuplicateMatchingRecord

See fax Entity [Fax_DuplicateMatchingRecord](fax.md#BKMK_Fax_DuplicateMatchingRecord) One-To-Many relationship.

### <a name="BKMK_SocialActivity_DuplicateMatchingRecord"></a> SocialActivity_DuplicateMatchingRecord

See socialactivity Entity [SocialActivity_DuplicateMatchingRecord](socialactivity.md#BKMK_SocialActivity_DuplicateMatchingRecord) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.duplicaterecord?text=duplicaterecord EntityType" />