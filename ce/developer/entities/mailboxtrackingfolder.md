---
title: "MailboxTrackingFolder Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the MailboxTrackingFolder entity."
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
# MailboxTrackingFolder Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Stores data about what folders for a mailbox are auto tracked


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/mailboxtrackingfolders<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/mailboxtrackingfolders(*mailboxtrackingfolderid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Update|PATCH [*org URI*]/api/data/v9.0/mailboxtrackingfolders(*mailboxtrackingfolderid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

**DisplayName**: Mailbox Auto Tracking Folder<br />
**DisplayCollectionName**: Mailbox Auto Tracking Folders<br />
**SchemaName**: MailboxTrackingFolder<br />
**CollectionSchemaName**: MailboxTrackingFolders<br />
**LogicalName**: mailboxtrackingfolder<br />
**LogicalCollectionName**: mailboxtrackingfolders<br />
**EntitySetName**: mailboxtrackingfolders<br />
**PrimaryIdAttribute**: mailboxtrackingfolderid<br />
**PrimaryNameAttribute**: <br />
**OwnershipType**: UserOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ExchangeFolderId](#BKMK_ExchangeFolderId)
- [ExchangeFolderName](#BKMK_ExchangeFolderName)
- [FolderOnboardingStatus](#BKMK_FolderOnboardingStatus)
- [MailboxId](#BKMK_MailboxId)
- [OwnerId](#BKMK_OwnerId)
- [OwnerIdType](#BKMK_OwnerIdType)
- [RegardingObjectId](#BKMK_RegardingObjectId)
- [RegardingObjectIdName](#BKMK_RegardingObjectIdName)
- [RegardingObjectTypeCode](#BKMK_RegardingObjectTypeCode)


### <a name="BKMK_ExchangeFolderId"></a> ExchangeFolderId

**Description**: Folder Id for a folder in Exchange<br />
**DisplayName**: Exchange Folder Id<br />
**LogicalName**: exchangefolderid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 120


### <a name="BKMK_ExchangeFolderName"></a> ExchangeFolderName

**Description**: Exchange Folder Name<br />
**DisplayName**: Exchange Folder Name<br />
**LogicalName**: exchangefoldername<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 256


### <a name="BKMK_FolderOnboardingStatus"></a> FolderOnboardingStatus

**Description**: Information to indicate whether the folder has been on boarded for auto tracking<br />
**DisplayName**: Folder on boarding Status<br />
**LogicalName**: folderonboardingstatus<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Integer<br />
**Format**: None<br />
**MaxValue**: 2147483647<br />
**MinValue**: 0


### <a name="BKMK_MailboxId"></a> MailboxId

**Description**: Mailbox id associated with this record.<br />
**DisplayName**: MailboxId<br />
**LogicalName**: mailboxid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Lookup<br />
**Targets**: mailbox


### <a name="BKMK_OwnerId"></a> OwnerId

**Description**: Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.<br />
**DisplayName**: Owner<br />
**LogicalName**: ownerid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
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


### <a name="BKMK_RegardingObjectId"></a> RegardingObjectId

**Description**: The regarding object such as Account, Contact, Lead etc. that the folder relates to.<br />
**DisplayName**: Regarding Object Id<br />
**LogicalName**: regardingobjectid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: account,accountleads,asyncoperation,bookableresource,bookableresourcebooking,bookableresourcebookingexchangesyncidmapping,bookableresourcebookingheader,bookableresourcecategory,bookableresourcecategoryassn,bookableresourcecharacteristic,bookableresourcegroup,bookingstatus,bulkoperation,bulkoperationlog,campaign,campaignactivity,campaignactivityitem,campaignitem,campaignresponse,characteristic,childincidentcount,commitment,competitor,competitoraddress,competitorproduct,competitorsalesliterature,constraintbasedgroup,contact,contactinvoices,contactleads,contactorders,contactquotes,contract,contractdetail,contracttemplate,customeropportunityrole,discount,discounttype,dynamicproperty,dynamicpropertyassociation,dynamicpropertyinstance,dynamicpropertyoptionsetitem,entitlement,entitlementchannel,entitlementcontacts,entitlementproducts,entitlementtemplate,entitlementtemplatechannel,entitlementtemplateproducts,equipment,incident,incidentknowledgebaserecord,incidentresolution,invoice,invoicedetail,knowledgearticleincident,lead,leadaddress,leadcompetitors,leadproduct,leadtoopportunitysalesprocess,list,listmember,msdyn_accountpricelist,msdyn_actual,msdyn_agreement,msdyn_agreementbookingdate,msdyn_agreementbookingincident,msdyn_agreementbookingproduct,msdyn_agreementbookingservice,msdyn_agreementbookingservicetask,msdyn_agreementbookingsetup,msdyn_agreementinvoicedate,msdyn_agreementinvoiceproduct,msdyn_agreementinvoicesetup,msdyn_agreementsubstatus,msdyn_approval,msdyn_batchjob,msdyn_bookingalert,msdyn_bookingalertstatus,msdyn_bookingchange,msdyn_bookingjournal,msdyn_bookingrule,msdyn_bookingsetupmetadata,msdyn_bookingtimestamp,msdyn_bpf_2c5fe86acc8b414b8322ae571000c799,msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b,msdyn_bpf_665e73aa18c247d886bfc50499c73b82,msdyn_bpf_989e9b1857e24af18787d5143b67523b,msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3,msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39,msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d,msdyn_characteristicreqforteammember,msdyn_clientextension,msdyn_configuration,msdyn_contactpricelist,msdyn_contractlineinvoiceschedule,msdyn_contractlinescheduleofvalue,msdyn_customerasset,msdyn_dataexport,msdyn_delegation,msdyn_estimate,msdyn_estimateline,msdyn_expense,msdyn_expensecategory,msdyn_expensereceipt,msdyn_fact,msdyn_fieldcomputation,msdyn_fieldservicepricelistitem,msdyn_fieldservicesetting,msdyn_fieldservicesystemjob,msdyn_findworkevent,msdyn_incidenttype,msdyn_incidenttypecharacteristic,msdyn_incidenttypeproduct,msdyn_incidenttypeservice,msdyn_incidenttypeservicetask,msdyn_integrationjob,msdyn_integrationjobdetail,msdyn_inventoryadjustment,msdyn_inventoryadjustmentproduct,msdyn_inventoryjournal,msdyn_inventorytransfer,msdyn_invoicefrequency,msdyn_invoicefrequencydetail,msdyn_invoicelinetransaction,msdyn_iotalert,msdyn_iotdevice,msdyn_iotdevicecategory,msdyn_iotdevicecommand,msdyn_iotdeviceregistrationhistory,msdyn_journal,msdyn_journalline,msdyn_mlresultcache,msdyn_opportunitylineresourcecategory,msdyn_opportunitylinetransaction,msdyn_opportunitylinetransactioncategory,msdyn_opportunitylinetransactionclassificatio,msdyn_opportunitypricelist,msdyn_orderinvoicingdate,msdyn_orderinvoicingproduct,msdyn_orderinvoicingsetup,msdyn_orderinvoicingsetupdate,msdyn_orderlineresourcecategory,msdyn_orderlinetransaction,msdyn_orderlinetransactioncategory,msdyn_orderlinetransactionclassification,msdyn_orderpricelist,msdyn_organizationalunit,msdyn_payment,msdyn_paymentdetail,msdyn_paymentmethod,msdyn_paymentterm,msdyn_postalbum,msdyn_postalcode,msdyn_postconfig,msdyn_postruleconfig,msdyn_priority,msdyn_processnotes,msdyn_productinventory,msdyn_project,msdyn_projectapproval,msdyn_projectparameter,msdyn_projectparameterpricelist,msdyn_projectpricelist,msdyn_projecttask,msdyn_projecttaskdependency,msdyn_projecttaskstatususer,msdyn_projectteam,msdyn_projectteammembersignup,msdyn_projecttransactioncategory,msdyn_purchaseorder,msdyn_purchaseorderbill,msdyn_purchaseorderproduct,msdyn_purchaseorderreceipt,msdyn_purchaseorderreceiptproduct,msdyn_purchaseordersubstatus,msdyn_quotebookingincident,msdyn_quotebookingproduct,msdyn_quotebookingservice,msdyn_quotebookingservicetask,msdyn_quotebookingsetup,msdyn_quoteinvoicingproduct,msdyn_quoteinvoicingsetup,msdyn_quotelineanalyticsbreakdown,msdyn_quotelineinvoiceschedule,msdyn_quotelineresourcecategory,msdyn_quotelinescheduleofvalue,msdyn_quotelinetransaction,msdyn_quotelinetransactioncategory,msdyn_quotelinetransactionclassification,msdyn_quotepricelist,msdyn_requirementcharacteristic,msdyn_requirementorganizationunit,msdyn_requirementresourcecategory,msdyn_requirementresourcepreference,msdyn_requirementstatus,msdyn_resourceassignment,msdyn_resourceassignmentdetail,msdyn_resourcecategorypricelevel,msdyn_resourcepaytype,msdyn_resourcerequest,msdyn_resourcerequirement,msdyn_resourcerequirementdetail,msdyn_resourceterritory,msdyn_rma,msdyn_rmaproduct,msdyn_rmareceipt,msdyn_rmareceiptproduct,msdyn_rmasubstatus,msdyn_rolecompetencyrequirement,msdyn_roleutilization,msdyn_rtv,msdyn_rtvproduct,msdyn_rtvsubstatus,msdyn_scheduleboardsetting,msdyn_schedulingparameter,msdyn_servicetasktype,msdyn_shipvia,msdyn_systemuserschedulersetting,msdyn_taxcode,msdyn_taxcodedetail,msdyn_timeentry,msdyn_timegroup,msdyn_timegroupdetail,msdyn_timeoffcalendar,msdyn_timeoffrequest,msdyn_transactioncategory,msdyn_transactioncategoryclassification,msdyn_transactioncategoryhierarchyelement,msdyn_transactioncategorypricelevel,msdyn_transactionconnection,msdyn_transactionorigin,msdyn_transactiontype,msdyn_uniquenumber,msdyn_userworkhistory,msdyn_wallsavedquery,msdyn_wallsavedqueryusersettings,msdyn_warehouse,msdyn_workhourtemplate,msdyn_workorder,msdyn_workordercharacteristic,msdyn_workorderdetailsgenerationqueue,msdyn_workorderincident,msdyn_workorderproduct,msdyn_workorderresourcerestriction,msdyn_workorderservice,msdyn_workorderservicetask,msdyn_workordersubstatus,msdyn_workordertype,opportunity,opportunityclose,opportunitycompetitors,opportunityproduct,opportunitysalesprocess,orderclose,phonetocaseprocess,pricelevel,product,productassociation,productpricelevel,productsalesliterature,productsubstitute,quote,quoteclose,quotedetail,ratingmodel,ratingvalue,resource,resourcegroup,resourcegroupexpansion,resourcespec,salesliterature,salesliteratureitem,salesorder,salesorderdetail,salesprocessinstance,service,serviceappointment,servicecontractcontacts,site,territory,topic,topichistory,topicmodel,topicmodelconfiguration,topicmodelexecutionhistory,uom,uomschedule


### <a name="BKMK_RegardingObjectIdName"></a> RegardingObjectIdName

**Description**: Regarding Object Name<br />
**DisplayName**: Regarding Object Name<br />
**LogicalName**: regardingobjectidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 400


### <a name="BKMK_RegardingObjectTypeCode"></a> RegardingObjectTypeCode

**Description**: Information that indicates the type of regarding object associated with the folder<br />
**DisplayName**: Regarding Object Type Code<br />
**LogicalName**: regardingobjecttypecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: EntityName<br />

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
- [MailboxTrackingFolderId](#BKMK_MailboxTrackingFolderId)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [OrganizationId](#BKMK_OrganizationId)
- [OwningBusinessUnit](#BKMK_OwningBusinessUnit)
- [OwningTeam](#BKMK_OwningTeam)
- [OwningUser](#BKMK_OwningUser)


### <a name="BKMK_CreatedBy"></a> CreatedBy

**Description**: Unique identifier of the user who created the record.<br />
**DisplayName**: Created By<br />
**LogicalName**: createdby<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
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
**MaxLength**: 100


### <a name="BKMK_CreatedByYomiName"></a> CreatedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_CreatedOn"></a> CreatedOn

**Description**: Date and time when the entry was created.<br />
**DisplayName**: Created On<br />
**LogicalName**: createdon<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

**Description**: Shows who created the record on behalf of another user.<br />
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
**MaxLength**: 160


### <a name="BKMK_CreatedOnBehalfByYomiName"></a> CreatedOnBehalfByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: createdonbehalfbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_MailboxTrackingFolderId"></a> MailboxTrackingFolderId

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: mailboxtrackingfolderid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

**Description**: Unique identifier of the user who modified the record.<br />
**DisplayName**: Modified By<br />
**LogicalName**: modifiedby<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: systemuser


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_ModifiedByYomiName"></a> ModifiedByYomiName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: modifiedbyyominame<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

**Description**: Date and time when the entry was last modified.<br />
**DisplayName**: Modified On<br />
**LogicalName**: modifiedon<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: DateTime<br />
**DateTimeBehavior**: UserLocal<br />
**Format**: DateAndTime


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

**Description**: Unique identifier of the delegate user who modified the record.<br />
**DisplayName**: Modified By (Delegate)<br />
**LogicalName**: modifiedonbehalfby<br />
**IsValidForForm**: False<br />
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
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 100


### <a name="BKMK_OrganizationId"></a> OrganizationId

**Description**: Unique identifier of the organization associated with the record.<br />
**DisplayName**: Organization<br />
**LogicalName**: organizationid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Lookup<br />
**Targets**: organization


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

**Description**: Unique identifier of the business unit that owns the folder mapping.<br />
**DisplayName**: Owning Business Unit<br />
**LogicalName**: owningbusinessunit<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: businessunit


### <a name="BKMK_OwningTeam"></a> OwningTeam

**Description**: Unique identifier of the team who owns the folder mapping.<br />
**DisplayName**: Owning Team<br />
**LogicalName**: owningteam<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: team


### <a name="BKMK_OwningUser"></a> OwningUser

**Description**: Unique identifier for the user that owns the record.<br />
**DisplayName**: Owning User<br />
**LogicalName**: owninguser<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: Lookup<br />
**Targets**: 

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [msdyn_iotalert_MailboxTrackingFolders](#BKMK_msdyn_iotalert_MailboxTrackingFolders)
- [msdyn_iotdevice_MailboxTrackingFolders](#BKMK_msdyn_iotdevice_MailboxTrackingFolders)
- [msdyn_iotdevicecategory_MailboxTrackingFolders](#BKMK_msdyn_iotdevicecategory_MailboxTrackingFolders)
- [msdyn_iotdevicecommand_MailboxTrackingFolders](#BKMK_msdyn_iotdevicecommand_MailboxTrackingFolders)
- [msdyn_iotdeviceregistrationhistory_MailboxTrackingFolders](#BKMK_msdyn_iotdeviceregistrationhistory_MailboxTrackingFolders)
- [msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_MailboxTrackingFolders](#BKMK_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_MailboxTrackingFolders)
- [territory_MailboxTrackingFolders](#BKMK_territory_MailboxTrackingFolders)
- [accountleads_MailboxTrackingFolders](#BKMK_accountleads_MailboxTrackingFolders)
- [contactleads_MailboxTrackingFolders](#BKMK_contactleads_MailboxTrackingFolders)
- [leadaddress_MailboxTrackingFolders](#BKMK_leadaddress_MailboxTrackingFolders)
- [Lead_MailboxTrackingFolder](#BKMK_Lead_MailboxTrackingFolder)
- [dynamicproperty_MailboxTrackingFolders](#BKMK_dynamicproperty_MailboxTrackingFolders)
- [dynamicpropertyassociation_MailboxTrackingFolders](#BKMK_dynamicpropertyassociation_MailboxTrackingFolders)
- [dynamicpropertyinstance_MailboxTrackingFolders](#BKMK_dynamicpropertyinstance_MailboxTrackingFolders)
- [dynamicpropertyoptionsetitem_MailboxTrackingFolders](#BKMK_dynamicpropertyoptionsetitem_MailboxTrackingFolders)
- [pricelevel_MailboxTrackingFolders](#BKMK_pricelevel_MailboxTrackingFolders)
- [product_MailboxTrackingFolders](#BKMK_product_MailboxTrackingFolders)
- [productassociation_MailboxTrackingFolders](#BKMK_productassociation_MailboxTrackingFolders)
- [productpricelevel_MailboxTrackingFolders](#BKMK_productpricelevel_MailboxTrackingFolders)
- [productsubstitute_MailboxTrackingFolders](#BKMK_productsubstitute_MailboxTrackingFolders)
- [uom_MailboxTrackingFolders](#BKMK_uom_MailboxTrackingFolders)
- [uomschedule_MailboxTrackingFolders](#BKMK_uomschedule_MailboxTrackingFolders)
- [bookableresource_MailboxTrackingFolders](#BKMK_bookableresource_MailboxTrackingFolders)
- [bookableresourcebooking_MailboxTrackingFolders](#BKMK_bookableresourcebooking_MailboxTrackingFolders)
- [bookableresourcebookingexchangesyncidmapping_MailboxTrackingFolders](#BKMK_bookableresourcebookingexchangesyncidmapping_MailboxTrackingFolders)
- [bookableresourcebookingheader_MailboxTrackingFolders](#BKMK_bookableresourcebookingheader_MailboxTrackingFolders)
- [bookableresourcecategory_MailboxTrackingFolders](#BKMK_bookableresourcecategory_MailboxTrackingFolders)
- [bookableresourcecategoryassn_MailboxTrackingFolders](#BKMK_bookableresourcecategoryassn_MailboxTrackingFolders)
- [bookableresourcecharacteristic_MailboxTrackingFolders](#BKMK_bookableresourcecharacteristic_MailboxTrackingFolders)
- [bookableresourcegroup_MailboxTrackingFolders](#BKMK_bookableresourcegroup_MailboxTrackingFolders)
- [bookingstatus_MailboxTrackingFolders](#BKMK_bookingstatus_MailboxTrackingFolders)
- [characteristic_MailboxTrackingFolders](#BKMK_characteristic_MailboxTrackingFolders)
- [ratingmodel_MailboxTrackingFolders](#BKMK_ratingmodel_MailboxTrackingFolders)
- [ratingvalue_MailboxTrackingFolders](#BKMK_ratingvalue_MailboxTrackingFolders)
- [BulkOperation_MailboxTrackingFolder](#BKMK_BulkOperation_MailboxTrackingFolder)
- [bulkoperationlog_MailboxTrackingFolders](#BKMK_bulkoperationlog_MailboxTrackingFolders)
- [Campaign_MailboxTrackingFolder](#BKMK_Campaign_MailboxTrackingFolder)
- [CampaignActivity_MailboxTrackingFolder](#BKMK_CampaignActivity_MailboxTrackingFolder)
- [campaignactivityitem_MailboxTrackingFolders](#BKMK_campaignactivityitem_MailboxTrackingFolders)
- [campaignitem_MailboxTrackingFolders](#BKMK_campaignitem_MailboxTrackingFolders)
- [campaignresponse_MailboxTrackingFolders](#BKMK_campaignresponse_MailboxTrackingFolders)
- [list_MailboxTrackingFolders](#BKMK_list_MailboxTrackingFolders)
- [listmember_MailboxTrackingFolders](#BKMK_listmember_MailboxTrackingFolders)
- [commitment_MailboxTrackingFolders](#BKMK_commitment_MailboxTrackingFolders)
- [constraintbasedgroup_MailboxTrackingFolders](#BKMK_constraintbasedgroup_MailboxTrackingFolders)
- [Contract_MailboxTrackingFolder](#BKMK_Contract_MailboxTrackingFolder)
- [contractdetail_MailboxTrackingFolders](#BKMK_contractdetail_MailboxTrackingFolders)
- [contracttemplate_MailboxTrackingFolders](#BKMK_contracttemplate_MailboxTrackingFolders)
- [Entitlement_MailboxTrackingFolder](#BKMK_Entitlement_MailboxTrackingFolder)
- [entitlementchannel_MailboxTrackingFolders](#BKMK_entitlementchannel_MailboxTrackingFolders)
- [entitlementcontacts_MailboxTrackingFolders](#BKMK_entitlementcontacts_MailboxTrackingFolders)
- [entitlementproducts_MailboxTrackingFolders](#BKMK_entitlementproducts_MailboxTrackingFolders)
- [EntitlementTemplate_MailboxTrackingFolder](#BKMK_EntitlementTemplate_MailboxTrackingFolder)
- [entitlementtemplatechannel_MailboxTrackingFolders](#BKMK_entitlementtemplatechannel_MailboxTrackingFolders)
- [entitlementtemplateproducts_MailboxTrackingFolders](#BKMK_entitlementtemplateproducts_MailboxTrackingFolders)
- [equipment_MailboxTrackingFolders](#BKMK_equipment_MailboxTrackingFolders)
- [Incident_MailboxTrackingFolder](#BKMK_Incident_MailboxTrackingFolder)
- [incidentknowledgebaserecord_MailboxTrackingFolders](#BKMK_incidentknowledgebaserecord_MailboxTrackingFolders)
- [incidentresolution_MailboxTrackingFolders](#BKMK_incidentresolution_MailboxTrackingFolders)
- [knowledgearticleincident_MailboxTrackingFolders](#BKMK_knowledgearticleincident_MailboxTrackingFolders)
- [phonetocaseprocess_MailboxTrackingFolders](#BKMK_phonetocaseprocess_MailboxTrackingFolders)
- [resource_MailboxTrackingFolders](#BKMK_resource_MailboxTrackingFolders)
- [resourcegroup_MailboxTrackingFolders](#BKMK_resourcegroup_MailboxTrackingFolders)
- [resourcespec_MailboxTrackingFolders](#BKMK_resourcespec_MailboxTrackingFolders)
- [service_MailboxTrackingFolders](#BKMK_service_MailboxTrackingFolders)
- [serviceappointment_MailboxTrackingFolders](#BKMK_serviceappointment_MailboxTrackingFolders)
- [servicecontractcontacts_MailboxTrackingFolders](#BKMK_servicecontractcontacts_MailboxTrackingFolders)
- [topic_MailboxTrackingFolders](#BKMK_topic_MailboxTrackingFolders)
- [topichistory_MailboxTrackingFolders](#BKMK_topichistory_MailboxTrackingFolders)
- [topicmodel_MailboxTrackingFolders](#BKMK_topicmodel_MailboxTrackingFolders)
- [topicmodelconfiguration_MailboxTrackingFolders](#BKMK_topicmodelconfiguration_MailboxTrackingFolders)
- [topicmodelexecutionhistory_MailboxTrackingFolders](#BKMK_topicmodelexecutionhistory_MailboxTrackingFolders)
- [site_MailboxTrackingFolders](#BKMK_site_MailboxTrackingFolders)
- [competitorproduct_MailboxTrackingFolders](#BKMK_competitorproduct_MailboxTrackingFolders)
- [competitorsalesliterature_MailboxTrackingFolders](#BKMK_competitorsalesliterature_MailboxTrackingFolders)
- [contactinvoices_MailboxTrackingFolders](#BKMK_contactinvoices_MailboxTrackingFolders)
- [contactorders_MailboxTrackingFolders](#BKMK_contactorders_MailboxTrackingFolders)
- [contactquotes_MailboxTrackingFolders](#BKMK_contactquotes_MailboxTrackingFolders)
- [customeropportunityrole_MailboxTrackingFolders](#BKMK_customeropportunityrole_MailboxTrackingFolders)
- [discount_MailboxTrackingFolders](#BKMK_discount_MailboxTrackingFolders)
- [discounttype_MailboxTrackingFolders](#BKMK_discounttype_MailboxTrackingFolders)
- [Invoice_MailboxTrackingFolder](#BKMK_Invoice_MailboxTrackingFolder)
- [invoicedetail_MailboxTrackingFolders](#BKMK_invoicedetail_MailboxTrackingFolders)
- [leadcompetitors_MailboxTrackingFolders](#BKMK_leadcompetitors_MailboxTrackingFolders)
- [leadproduct_MailboxTrackingFolders](#BKMK_leadproduct_MailboxTrackingFolders)
- [leadtoopportunitysalesprocess_MailboxTrackingFolders](#BKMK_leadtoopportunitysalesprocess_MailboxTrackingFolders)
- [Opportunity_MailboxTrackingFolder](#BKMK_Opportunity_MailboxTrackingFolder)
- [opportunityclose_MailboxTrackingFolders](#BKMK_opportunityclose_MailboxTrackingFolders)
- [opportunitycompetitors_MailboxTrackingFolders](#BKMK_opportunitycompetitors_MailboxTrackingFolders)
- [opportunityproduct_MailboxTrackingFolders](#BKMK_opportunityproduct_MailboxTrackingFolders)
- [opportunitysalesprocess_MailboxTrackingFolders](#BKMK_opportunitysalesprocess_MailboxTrackingFolders)
- [orderclose_MailboxTrackingFolders](#BKMK_orderclose_MailboxTrackingFolders)
- [productsalesliterature_MailboxTrackingFolders](#BKMK_productsalesliterature_MailboxTrackingFolders)
- [Quote_MailboxTrackingFolder](#BKMK_Quote_MailboxTrackingFolder)
- [quoteclose_MailboxTrackingFolders](#BKMK_quoteclose_MailboxTrackingFolders)
- [quotedetail_MailboxTrackingFolders](#BKMK_quotedetail_MailboxTrackingFolders)
- [salesliterature_MailboxTrackingFolders](#BKMK_salesliterature_MailboxTrackingFolders)
- [salesliteratureitem_MailboxTrackingFolders](#BKMK_salesliteratureitem_MailboxTrackingFolders)
- [SalesOrder_MailboxTrackingFolder](#BKMK_SalesOrder_MailboxTrackingFolder)
- [salesorderdetail_MailboxTrackingFolders](#BKMK_salesorderdetail_MailboxTrackingFolders)
- [competitor_MailboxTrackingFolders](#BKMK_competitor_MailboxTrackingFolders)
- [msdyn_postalbum_MailboxTrackingFolders](#BKMK_msdyn_postalbum_MailboxTrackingFolders)
- [msdyn_postconfig_MailboxTrackingFolders](#BKMK_msdyn_postconfig_MailboxTrackingFolders)
- [msdyn_postruleconfig_MailboxTrackingFolders](#BKMK_msdyn_postruleconfig_MailboxTrackingFolders)
- [msdyn_wallsavedquery_MailboxTrackingFolders](#BKMK_msdyn_wallsavedquery_MailboxTrackingFolders)
- [msdyn_wallsavedqueryusersettings_MailboxTrackingFolders](#BKMK_msdyn_wallsavedqueryusersettings_MailboxTrackingFolders)
- [msdyn_actual_MailboxTrackingFolders](#BKMK_msdyn_actual_MailboxTrackingFolders)
- [msdyn_bookingalert_MailboxTrackingFolders](#BKMK_msdyn_bookingalert_MailboxTrackingFolders)
- [msdyn_bookingalertstatus_MailboxTrackingFolders](#BKMK_msdyn_bookingalertstatus_MailboxTrackingFolders)
- [msdyn_bookingchange_MailboxTrackingFolders](#BKMK_msdyn_bookingchange_MailboxTrackingFolders)
- [msdyn_bookingrule_MailboxTrackingFolders](#BKMK_msdyn_bookingrule_MailboxTrackingFolders)
- [msdyn_bookingsetupmetadata_MailboxTrackingFolders](#BKMK_msdyn_bookingsetupmetadata_MailboxTrackingFolders)
- [msdyn_clientextension_MailboxTrackingFolders](#BKMK_msdyn_clientextension_MailboxTrackingFolders)
- [msdyn_configuration_MailboxTrackingFolders](#BKMK_msdyn_configuration_MailboxTrackingFolders)
- [msdyn_organizationalunit_MailboxTrackingFolders](#BKMK_msdyn_organizationalunit_MailboxTrackingFolders)
- [msdyn_priority_MailboxTrackingFolders](#BKMK_msdyn_priority_MailboxTrackingFolders)
- [msdyn_requirementcharacteristic_MailboxTrackingFolders](#BKMK_msdyn_requirementcharacteristic_MailboxTrackingFolders)
- [msdyn_requirementorganizationunit_MailboxTrackingFolders](#BKMK_msdyn_requirementorganizationunit_MailboxTrackingFolders)
- [msdyn_requirementresourcecategory_MailboxTrackingFolders](#BKMK_msdyn_requirementresourcecategory_MailboxTrackingFolders)
- [msdyn_requirementresourcepreference_MailboxTrackingFolders](#BKMK_msdyn_requirementresourcepreference_MailboxTrackingFolders)
- [msdyn_requirementstatus_MailboxTrackingFolders](#BKMK_msdyn_requirementstatus_MailboxTrackingFolders)
- [msdyn_resourcerequirement_MailboxTrackingFolders](#BKMK_msdyn_resourcerequirement_MailboxTrackingFolders)
- [msdyn_resourcerequirementdetail_MailboxTrackingFolders](#BKMK_msdyn_resourcerequirementdetail_MailboxTrackingFolders)
- [msdyn_resourceterritory_MailboxTrackingFolders](#BKMK_msdyn_resourceterritory_MailboxTrackingFolders)
- [msdyn_scheduleboardsetting_MailboxTrackingFolders](#BKMK_msdyn_scheduleboardsetting_MailboxTrackingFolders)
- [msdyn_schedulingparameter_MailboxTrackingFolders](#BKMK_msdyn_schedulingparameter_MailboxTrackingFolders)
- [msdyn_systemuserschedulersetting_MailboxTrackingFolders](#BKMK_msdyn_systemuserschedulersetting_MailboxTrackingFolders)
- [msdyn_timegroup_MailboxTrackingFolders](#BKMK_msdyn_timegroup_MailboxTrackingFolders)
- [msdyn_timegroupdetail_MailboxTrackingFolders](#BKMK_msdyn_timegroupdetail_MailboxTrackingFolders)
- [msdyn_transactionorigin_MailboxTrackingFolders](#BKMK_msdyn_transactionorigin_MailboxTrackingFolders)
- [msdyn_workhourtemplate_MailboxTrackingFolders](#BKMK_msdyn_workhourtemplate_MailboxTrackingFolders)
- [msdyn_accountpricelist_MailboxTrackingFolders](#BKMK_msdyn_accountpricelist_MailboxTrackingFolders)
- [msdyn_approval_MailboxTrackingFolders](#BKMK_msdyn_approval_MailboxTrackingFolders)
- [msdyn_batchjob_MailboxTrackingFolders](#BKMK_msdyn_batchjob_MailboxTrackingFolders)
- [msdyn_bpf_665e73aa18c247d886bfc50499c73b82_MailboxTrackingFolders](#BKMK_msdyn_bpf_665e73aa18c247d886bfc50499c73b82_MailboxTrackingFolders)
- [msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_MailboxTrackingFolders](#BKMK_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_MailboxTrackingFolders)
- [msdyn_characteristicreqforteammember_MailboxTrackingFolders](#BKMK_msdyn_characteristicreqforteammember_MailboxTrackingFolders)
- [msdyn_contactpricelist_MailboxTrackingFolders](#BKMK_msdyn_contactpricelist_MailboxTrackingFolders)
- [msdyn_contractlineinvoiceschedule_MailboxTrackingFolders](#BKMK_msdyn_contractlineinvoiceschedule_MailboxTrackingFolders)
- [msdyn_contractlinescheduleofvalue_MailboxTrackingFolders](#BKMK_msdyn_contractlinescheduleofvalue_MailboxTrackingFolders)
- [msdyn_dataexport_MailboxTrackingFolders](#BKMK_msdyn_dataexport_MailboxTrackingFolders)
- [msdyn_delegation_MailboxTrackingFolders](#BKMK_msdyn_delegation_MailboxTrackingFolders)
- [msdyn_estimate_MailboxTrackingFolders](#BKMK_msdyn_estimate_MailboxTrackingFolders)
- [msdyn_estimateline_MailboxTrackingFolders](#BKMK_msdyn_estimateline_MailboxTrackingFolders)
- [msdyn_expense_MailboxTrackingFolders](#BKMK_msdyn_expense_MailboxTrackingFolders)
- [msdyn_expensecategory_MailboxTrackingFolders](#BKMK_msdyn_expensecategory_MailboxTrackingFolders)
- [msdyn_expensereceipt_MailboxTrackingFolders](#BKMK_msdyn_expensereceipt_MailboxTrackingFolders)
- [msdyn_fact_MailboxTrackingFolders](#BKMK_msdyn_fact_MailboxTrackingFolders)
- [msdyn_fieldcomputation_MailboxTrackingFolders](#BKMK_msdyn_fieldcomputation_MailboxTrackingFolders)
- [msdyn_findworkevent_MailboxTrackingFolders](#BKMK_msdyn_findworkevent_MailboxTrackingFolders)
- [msdyn_integrationjob_MailboxTrackingFolders](#BKMK_msdyn_integrationjob_MailboxTrackingFolders)
- [msdyn_integrationjobdetail_MailboxTrackingFolders](#BKMK_msdyn_integrationjobdetail_MailboxTrackingFolders)
- [msdyn_invoicefrequency_MailboxTrackingFolders](#BKMK_msdyn_invoicefrequency_MailboxTrackingFolders)
- [msdyn_invoicefrequencydetail_MailboxTrackingFolders](#BKMK_msdyn_invoicefrequencydetail_MailboxTrackingFolders)
- [msdyn_invoicelinetransaction_MailboxTrackingFolders](#BKMK_msdyn_invoicelinetransaction_MailboxTrackingFolders)
- [msdyn_journal_MailboxTrackingFolders](#BKMK_msdyn_journal_MailboxTrackingFolders)
- [msdyn_journalline_MailboxTrackingFolders](#BKMK_msdyn_journalline_MailboxTrackingFolders)
- [msdyn_mlresultcache_MailboxTrackingFolders](#BKMK_msdyn_mlresultcache_MailboxTrackingFolders)
- [msdyn_opportunitylineresourcecategory_MailboxTrackingFolders](#BKMK_msdyn_opportunitylineresourcecategory_MailboxTrackingFolders)
- [msdyn_opportunitylinetransaction_MailboxTrackingFolders](#BKMK_msdyn_opportunitylinetransaction_MailboxTrackingFolders)
- [msdyn_opportunitylinetransactioncategory_MailboxTrackingFolders](#BKMK_msdyn_opportunitylinetransactioncategory_MailboxTrackingFolders)
- [msdyn_opportunitylinetransactionclassificatio_MailboxTrackingFolders](#BKMK_msdyn_opportunitylinetransactionclassificatio_MailboxTrackingFolders)
- [msdyn_opportunitypricelist_MailboxTrackingFolders](#BKMK_msdyn_opportunitypricelist_MailboxTrackingFolders)
- [msdyn_orderlineresourcecategory_MailboxTrackingFolders](#BKMK_msdyn_orderlineresourcecategory_MailboxTrackingFolders)
- [msdyn_orderlinetransaction_MailboxTrackingFolders](#BKMK_msdyn_orderlinetransaction_MailboxTrackingFolders)
- [msdyn_orderlinetransactioncategory_MailboxTrackingFolders](#BKMK_msdyn_orderlinetransactioncategory_MailboxTrackingFolders)
- [msdyn_orderlinetransactionclassification_MailboxTrackingFolders](#BKMK_msdyn_orderlinetransactionclassification_MailboxTrackingFolders)
- [msdyn_orderpricelist_MailboxTrackingFolders](#BKMK_msdyn_orderpricelist_MailboxTrackingFolders)
- [msdyn_processnotes_MailboxTrackingFolders](#BKMK_msdyn_processnotes_MailboxTrackingFolders)
- [msdyn_project_MailboxTrackingFolders](#BKMK_msdyn_project_MailboxTrackingFolders)
- [msdyn_projectapproval_MailboxTrackingFolders](#BKMK_msdyn_projectapproval_MailboxTrackingFolders)
- [msdyn_projectparameter_MailboxTrackingFolders](#BKMK_msdyn_projectparameter_MailboxTrackingFolders)
- [msdyn_projectparameterpricelist_MailboxTrackingFolders](#BKMK_msdyn_projectparameterpricelist_MailboxTrackingFolders)
- [msdyn_projectpricelist_MailboxTrackingFolders](#BKMK_msdyn_projectpricelist_MailboxTrackingFolders)
- [msdyn_projecttask_MailboxTrackingFolders](#BKMK_msdyn_projecttask_MailboxTrackingFolders)
- [msdyn_projecttaskdependency_MailboxTrackingFolders](#BKMK_msdyn_projecttaskdependency_MailboxTrackingFolders)
- [msdyn_projecttaskstatususer_MailboxTrackingFolders](#BKMK_msdyn_projecttaskstatususer_MailboxTrackingFolders)
- [msdyn_projectteam_MailboxTrackingFolders](#BKMK_msdyn_projectteam_MailboxTrackingFolders)
- [msdyn_projectteammembersignup_MailboxTrackingFolders](#BKMK_msdyn_projectteammembersignup_MailboxTrackingFolders)
- [msdyn_projecttransactioncategory_MailboxTrackingFolders](#BKMK_msdyn_projecttransactioncategory_MailboxTrackingFolders)
- [msdyn_quotelineanalyticsbreakdown_MailboxTrackingFolders](#BKMK_msdyn_quotelineanalyticsbreakdown_MailboxTrackingFolders)
- [msdyn_quotelineinvoiceschedule_MailboxTrackingFolders](#BKMK_msdyn_quotelineinvoiceschedule_MailboxTrackingFolders)
- [msdyn_quotelineresourcecategory_MailboxTrackingFolders](#BKMK_msdyn_quotelineresourcecategory_MailboxTrackingFolders)
- [msdyn_quotelinescheduleofvalue_MailboxTrackingFolders](#BKMK_msdyn_quotelinescheduleofvalue_MailboxTrackingFolders)
- [msdyn_quotelinetransaction_MailboxTrackingFolders](#BKMK_msdyn_quotelinetransaction_MailboxTrackingFolders)
- [msdyn_quotelinetransactioncategory_MailboxTrackingFolders](#BKMK_msdyn_quotelinetransactioncategory_MailboxTrackingFolders)
- [msdyn_quotelinetransactionclassification_MailboxTrackingFolders](#BKMK_msdyn_quotelinetransactionclassification_MailboxTrackingFolders)
- [msdyn_quotepricelist_MailboxTrackingFolders](#BKMK_msdyn_quotepricelist_MailboxTrackingFolders)
- [msdyn_resourceassignment_MailboxTrackingFolders](#BKMK_msdyn_resourceassignment_MailboxTrackingFolders)
- [msdyn_resourceassignmentdetail_MailboxTrackingFolders](#BKMK_msdyn_resourceassignmentdetail_MailboxTrackingFolders)
- [msdyn_resourcecategorypricelevel_MailboxTrackingFolders](#BKMK_msdyn_resourcecategorypricelevel_MailboxTrackingFolders)
- [msdyn_resourcerequest_MailboxTrackingFolders](#BKMK_msdyn_resourcerequest_MailboxTrackingFolders)
- [msdyn_rolecompetencyrequirement_MailboxTrackingFolders](#BKMK_msdyn_rolecompetencyrequirement_MailboxTrackingFolders)
- [msdyn_roleutilization_MailboxTrackingFolders](#BKMK_msdyn_roleutilization_MailboxTrackingFolders)
- [msdyn_timeentry_MailboxTrackingFolders](#BKMK_msdyn_timeentry_MailboxTrackingFolders)
- [msdyn_timeoffcalendar_MailboxTrackingFolders](#BKMK_msdyn_timeoffcalendar_MailboxTrackingFolders)
- [msdyn_transactioncategory_MailboxTrackingFolders](#BKMK_msdyn_transactioncategory_MailboxTrackingFolders)
- [msdyn_transactioncategoryclassification_MailboxTrackingFolders](#BKMK_msdyn_transactioncategoryclassification_MailboxTrackingFolders)
- [msdyn_transactioncategoryhierarchyelement_MailboxTrackingFolders](#BKMK_msdyn_transactioncategoryhierarchyelement_MailboxTrackingFolders)
- [msdyn_transactioncategorypricelevel_MailboxTrackingFolders](#BKMK_msdyn_transactioncategorypricelevel_MailboxTrackingFolders)
- [msdyn_transactionconnection_MailboxTrackingFolders](#BKMK_msdyn_transactionconnection_MailboxTrackingFolders)
- [msdyn_transactiontype_MailboxTrackingFolders](#BKMK_msdyn_transactiontype_MailboxTrackingFolders)
- [msdyn_userworkhistory_MailboxTrackingFolders](#BKMK_msdyn_userworkhistory_MailboxTrackingFolders)
- [msdyn_agreement_MailboxTrackingFolders](#BKMK_msdyn_agreement_MailboxTrackingFolders)
- [msdyn_agreementbookingdate_MailboxTrackingFolders](#BKMK_msdyn_agreementbookingdate_MailboxTrackingFolders)
- [msdyn_agreementbookingincident_MailboxTrackingFolders](#BKMK_msdyn_agreementbookingincident_MailboxTrackingFolders)
- [msdyn_agreementbookingproduct_MailboxTrackingFolders](#BKMK_msdyn_agreementbookingproduct_MailboxTrackingFolders)
- [msdyn_agreementbookingservice_MailboxTrackingFolders](#BKMK_msdyn_agreementbookingservice_MailboxTrackingFolders)
- [msdyn_agreementbookingservicetask_MailboxTrackingFolders](#BKMK_msdyn_agreementbookingservicetask_MailboxTrackingFolders)
- [msdyn_agreementbookingsetup_MailboxTrackingFolders](#BKMK_msdyn_agreementbookingsetup_MailboxTrackingFolders)
- [msdyn_agreementinvoicedate_MailboxTrackingFolders](#BKMK_msdyn_agreementinvoicedate_MailboxTrackingFolders)
- [msdyn_agreementinvoiceproduct_MailboxTrackingFolders](#BKMK_msdyn_agreementinvoiceproduct_MailboxTrackingFolders)
- [msdyn_agreementinvoicesetup_MailboxTrackingFolders](#BKMK_msdyn_agreementinvoicesetup_MailboxTrackingFolders)
- [msdyn_agreementsubstatus_MailboxTrackingFolders](#BKMK_msdyn_agreementsubstatus_MailboxTrackingFolders)
- [msdyn_bookingjournal_MailboxTrackingFolders](#BKMK_msdyn_bookingjournal_MailboxTrackingFolders)
- [msdyn_bookingtimestamp_MailboxTrackingFolders](#BKMK_msdyn_bookingtimestamp_MailboxTrackingFolders)
- [msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_MailboxTrackingFolders](#BKMK_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_MailboxTrackingFolders)
- [msdyn_bpf_989e9b1857e24af18787d5143b67523b_MailboxTrackingFolders](#BKMK_msdyn_bpf_989e9b1857e24af18787d5143b67523b_MailboxTrackingFolders)
- [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_MailboxTrackingFolders](#BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_MailboxTrackingFolders)
- [msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_MailboxTrackingFolders](#BKMK_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_MailboxTrackingFolders)
- [msdyn_customerasset_MailboxTrackingFolders](#BKMK_msdyn_customerasset_MailboxTrackingFolders)
- [msdyn_fieldservicepricelistitem_MailboxTrackingFolders](#BKMK_msdyn_fieldservicepricelistitem_MailboxTrackingFolders)
- [msdyn_fieldservicesetting_MailboxTrackingFolders](#BKMK_msdyn_fieldservicesetting_MailboxTrackingFolders)
- [msdyn_fieldservicesystemjob_MailboxTrackingFolders](#BKMK_msdyn_fieldservicesystemjob_MailboxTrackingFolders)
- [msdyn_incidenttype_MailboxTrackingFolders](#BKMK_msdyn_incidenttype_MailboxTrackingFolders)
- [msdyn_incidenttypecharacteristic_MailboxTrackingFolders](#BKMK_msdyn_incidenttypecharacteristic_MailboxTrackingFolders)
- [msdyn_incidenttypeproduct_MailboxTrackingFolders](#BKMK_msdyn_incidenttypeproduct_MailboxTrackingFolders)
- [msdyn_incidenttypeservice_MailboxTrackingFolders](#BKMK_msdyn_incidenttypeservice_MailboxTrackingFolders)
- [msdyn_incidenttypeservicetask_MailboxTrackingFolders](#BKMK_msdyn_incidenttypeservicetask_MailboxTrackingFolders)
- [msdyn_inventoryadjustment_MailboxTrackingFolders](#BKMK_msdyn_inventoryadjustment_MailboxTrackingFolders)
- [msdyn_inventoryadjustmentproduct_MailboxTrackingFolders](#BKMK_msdyn_inventoryadjustmentproduct_MailboxTrackingFolders)
- [msdyn_inventoryjournal_MailboxTrackingFolders](#BKMK_msdyn_inventoryjournal_MailboxTrackingFolders)
- [msdyn_inventorytransfer_MailboxTrackingFolders](#BKMK_msdyn_inventorytransfer_MailboxTrackingFolders)
- [msdyn_orderinvoicingdate_MailboxTrackingFolders](#BKMK_msdyn_orderinvoicingdate_MailboxTrackingFolders)
- [msdyn_orderinvoicingproduct_MailboxTrackingFolders](#BKMK_msdyn_orderinvoicingproduct_MailboxTrackingFolders)
- [msdyn_orderinvoicingsetup_MailboxTrackingFolders](#BKMK_msdyn_orderinvoicingsetup_MailboxTrackingFolders)
- [msdyn_orderinvoicingsetupdate_MailboxTrackingFolders](#BKMK_msdyn_orderinvoicingsetupdate_MailboxTrackingFolders)
- [msdyn_payment_MailboxTrackingFolders](#BKMK_msdyn_payment_MailboxTrackingFolders)
- [msdyn_paymentdetail_MailboxTrackingFolders](#BKMK_msdyn_paymentdetail_MailboxTrackingFolders)
- [msdyn_paymentmethod_MailboxTrackingFolders](#BKMK_msdyn_paymentmethod_MailboxTrackingFolders)
- [msdyn_paymentterm_MailboxTrackingFolders](#BKMK_msdyn_paymentterm_MailboxTrackingFolders)
- [msdyn_postalcode_MailboxTrackingFolders](#BKMK_msdyn_postalcode_MailboxTrackingFolders)
- [msdyn_productinventory_MailboxTrackingFolders](#BKMK_msdyn_productinventory_MailboxTrackingFolders)
- [msdyn_purchaseorder_MailboxTrackingFolders](#BKMK_msdyn_purchaseorder_MailboxTrackingFolders)
- [msdyn_purchaseorderbill_MailboxTrackingFolders](#BKMK_msdyn_purchaseorderbill_MailboxTrackingFolders)
- [msdyn_purchaseorderproduct_MailboxTrackingFolders](#BKMK_msdyn_purchaseorderproduct_MailboxTrackingFolders)
- [msdyn_purchaseorderreceipt_MailboxTrackingFolders](#BKMK_msdyn_purchaseorderreceipt_MailboxTrackingFolders)
- [msdyn_purchaseorderreceiptproduct_MailboxTrackingFolders](#BKMK_msdyn_purchaseorderreceiptproduct_MailboxTrackingFolders)
- [msdyn_purchaseordersubstatus_MailboxTrackingFolders](#BKMK_msdyn_purchaseordersubstatus_MailboxTrackingFolders)
- [msdyn_quotebookingincident_MailboxTrackingFolders](#BKMK_msdyn_quotebookingincident_MailboxTrackingFolders)
- [msdyn_quotebookingproduct_MailboxTrackingFolders](#BKMK_msdyn_quotebookingproduct_MailboxTrackingFolders)
- [msdyn_quotebookingservice_MailboxTrackingFolders](#BKMK_msdyn_quotebookingservice_MailboxTrackingFolders)
- [msdyn_quotebookingservicetask_MailboxTrackingFolders](#BKMK_msdyn_quotebookingservicetask_MailboxTrackingFolders)
- [msdyn_quotebookingsetup_MailboxTrackingFolders](#BKMK_msdyn_quotebookingsetup_MailboxTrackingFolders)
- [msdyn_quoteinvoicingproduct_MailboxTrackingFolders](#BKMK_msdyn_quoteinvoicingproduct_MailboxTrackingFolders)
- [msdyn_quoteinvoicingsetup_MailboxTrackingFolders](#BKMK_msdyn_quoteinvoicingsetup_MailboxTrackingFolders)
- [msdyn_resourcepaytype_MailboxTrackingFolders](#BKMK_msdyn_resourcepaytype_MailboxTrackingFolders)
- [msdyn_rma_MailboxTrackingFolders](#BKMK_msdyn_rma_MailboxTrackingFolders)
- [msdyn_rmaproduct_MailboxTrackingFolders](#BKMK_msdyn_rmaproduct_MailboxTrackingFolders)
- [msdyn_rmareceipt_MailboxTrackingFolders](#BKMK_msdyn_rmareceipt_MailboxTrackingFolders)
- [msdyn_rmareceiptproduct_MailboxTrackingFolders](#BKMK_msdyn_rmareceiptproduct_MailboxTrackingFolders)
- [msdyn_rmasubstatus_MailboxTrackingFolders](#BKMK_msdyn_rmasubstatus_MailboxTrackingFolders)
- [msdyn_rtv_MailboxTrackingFolders](#BKMK_msdyn_rtv_MailboxTrackingFolders)
- [msdyn_rtvproduct_MailboxTrackingFolders](#BKMK_msdyn_rtvproduct_MailboxTrackingFolders)
- [msdyn_rtvsubstatus_MailboxTrackingFolders](#BKMK_msdyn_rtvsubstatus_MailboxTrackingFolders)
- [msdyn_servicetasktype_MailboxTrackingFolders](#BKMK_msdyn_servicetasktype_MailboxTrackingFolders)
- [msdyn_shipvia_MailboxTrackingFolders](#BKMK_msdyn_shipvia_MailboxTrackingFolders)
- [msdyn_taxcode_MailboxTrackingFolders](#BKMK_msdyn_taxcode_MailboxTrackingFolders)
- [msdyn_taxcodedetail_MailboxTrackingFolders](#BKMK_msdyn_taxcodedetail_MailboxTrackingFolders)
- [msdyn_timeoffrequest_MailboxTrackingFolders](#BKMK_msdyn_timeoffrequest_MailboxTrackingFolders)
- [msdyn_uniquenumber_MailboxTrackingFolders](#BKMK_msdyn_uniquenumber_MailboxTrackingFolders)
- [msdyn_warehouse_MailboxTrackingFolders](#BKMK_msdyn_warehouse_MailboxTrackingFolders)
- [msdyn_workorder_MailboxTrackingFolders](#BKMK_msdyn_workorder_MailboxTrackingFolders)
- [msdyn_workordercharacteristic_MailboxTrackingFolders](#BKMK_msdyn_workordercharacteristic_MailboxTrackingFolders)
- [msdyn_workorderdetailsgenerationqueue_MailboxTrackingFolders](#BKMK_msdyn_workorderdetailsgenerationqueue_MailboxTrackingFolders)
- [msdyn_workorderincident_MailboxTrackingFolders](#BKMK_msdyn_workorderincident_MailboxTrackingFolders)
- [msdyn_workorderproduct_MailboxTrackingFolders](#BKMK_msdyn_workorderproduct_MailboxTrackingFolders)
- [msdyn_workorderresourcerestriction_MailboxTrackingFolders](#BKMK_msdyn_workorderresourcerestriction_MailboxTrackingFolders)
- [msdyn_workorderservice_MailboxTrackingFolders](#BKMK_msdyn_workorderservice_MailboxTrackingFolders)
- [msdyn_workorderservicetask_MailboxTrackingFolders](#BKMK_msdyn_workorderservicetask_MailboxTrackingFolders)
- [msdyn_workordersubstatus_MailboxTrackingFolders](#BKMK_msdyn_workordersubstatus_MailboxTrackingFolders)
- [msdyn_workordertype_MailboxTrackingFolders](#BKMK_msdyn_workordertype_MailboxTrackingFolders)
- [lk_mailboxtrackingfolder_modifiedby](#BKMK_lk_mailboxtrackingfolder_modifiedby)
- [lk_mailboxtrackingfolder_createdby](#BKMK_lk_mailboxtrackingfolder_createdby)
- [Account_MailboxTrackingFolder](#BKMK_Account_MailboxTrackingFolder)
- [team_mailboxtrackingfolder](#BKMK_team_mailboxtrackingfolder)
- [Contact_MailboxTrackingFolder](#BKMK_Contact_MailboxTrackingFolder)
- [lk_mailboxtrackingfolder_createdonbehalfby](#BKMK_lk_mailboxtrackingfolder_createdonbehalfby)
- [lk_mailboxtrackingfolder_modifiedonbehalfby](#BKMK_lk_mailboxtrackingfolder_modifiedonbehalfby)
- [Organization_MailboxTrackingFolder](#BKMK_Organization_MailboxTrackingFolder)
- [Mailbox_MailboxTrackingFolder](#BKMK_Mailbox_MailboxTrackingFolder)
- [businessunit_mailboxtrackingfolder](#BKMK_businessunit_mailboxtrackingfolder)
- [AsyncOperation_MailboxTrackingFolder](#BKMK_AsyncOperation_MailboxTrackingFolder)


### <a name="BKMK_msdyn_iotalert_MailboxTrackingFolders"></a> msdyn_iotalert_MailboxTrackingFolders

See msdyn_iotalert Entity [msdyn_iotalert_MailboxTrackingFolders](msdyn_iotalert.md#BKMK_msdyn_iotalert_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdevice_MailboxTrackingFolders"></a> msdyn_iotdevice_MailboxTrackingFolders

See msdyn_iotdevice Entity [msdyn_iotdevice_MailboxTrackingFolders](msdyn_iotdevice.md#BKMK_msdyn_iotdevice_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdevicecategory_MailboxTrackingFolders"></a> msdyn_iotdevicecategory_MailboxTrackingFolders

See msdyn_iotdevicecategory Entity [msdyn_iotdevicecategory_MailboxTrackingFolders](msdyn_iotdevicecategory.md#BKMK_msdyn_iotdevicecategory_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdevicecommand_MailboxTrackingFolders"></a> msdyn_iotdevicecommand_MailboxTrackingFolders

See msdyn_iotdevicecommand Entity [msdyn_iotdevicecommand_MailboxTrackingFolders](msdyn_iotdevicecommand.md#BKMK_msdyn_iotdevicecommand_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdeviceregistrationhistory_MailboxTrackingFolders"></a> msdyn_iotdeviceregistrationhistory_MailboxTrackingFolders

See msdyn_iotdeviceregistrationhistory Entity [msdyn_iotdeviceregistrationhistory_MailboxTrackingFolders](msdyn_iotdeviceregistrationhistory.md#BKMK_msdyn_iotdeviceregistrationhistory_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_MailboxTrackingFolders"></a> msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_MailboxTrackingFolders

See msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b Entity [msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_MailboxTrackingFolders](msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b.md#BKMK_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_territory_MailboxTrackingFolders"></a> territory_MailboxTrackingFolders

See territory Entity [territory_MailboxTrackingFolders](territory.md#BKMK_territory_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_accountleads_MailboxTrackingFolders"></a> accountleads_MailboxTrackingFolders

See accountleads Entity [accountleads_MailboxTrackingFolders](accountleads.md#BKMK_accountleads_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_contactleads_MailboxTrackingFolders"></a> contactleads_MailboxTrackingFolders

See contactleads Entity [contactleads_MailboxTrackingFolders](contactleads.md#BKMK_contactleads_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_leadaddress_MailboxTrackingFolders"></a> leadaddress_MailboxTrackingFolders

See leadaddress Entity [leadaddress_MailboxTrackingFolders](leadaddress.md#BKMK_leadaddress_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_Lead_MailboxTrackingFolder"></a> Lead_MailboxTrackingFolder

See lead Entity [Lead_MailboxTrackingFolder](lead.md#BKMK_Lead_MailboxTrackingFolder) One-To-Many relationship.

### <a name="BKMK_dynamicproperty_MailboxTrackingFolders"></a> dynamicproperty_MailboxTrackingFolders

See dynamicproperty Entity [dynamicproperty_MailboxTrackingFolders](dynamicproperty.md#BKMK_dynamicproperty_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_dynamicpropertyassociation_MailboxTrackingFolders"></a> dynamicpropertyassociation_MailboxTrackingFolders

See dynamicpropertyassociation Entity [dynamicpropertyassociation_MailboxTrackingFolders](dynamicpropertyassociation.md#BKMK_dynamicpropertyassociation_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_dynamicpropertyinstance_MailboxTrackingFolders"></a> dynamicpropertyinstance_MailboxTrackingFolders

See dynamicpropertyinstance Entity [dynamicpropertyinstance_MailboxTrackingFolders](dynamicpropertyinstance.md#BKMK_dynamicpropertyinstance_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_dynamicpropertyoptionsetitem_MailboxTrackingFolders"></a> dynamicpropertyoptionsetitem_MailboxTrackingFolders

See dynamicpropertyoptionsetitem Entity [dynamicpropertyoptionsetitem_MailboxTrackingFolders](dynamicpropertyoptionsetitem.md#BKMK_dynamicpropertyoptionsetitem_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_pricelevel_MailboxTrackingFolders"></a> pricelevel_MailboxTrackingFolders

See pricelevel Entity [pricelevel_MailboxTrackingFolders](pricelevel.md#BKMK_pricelevel_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_product_MailboxTrackingFolders"></a> product_MailboxTrackingFolders

See product Entity [product_MailboxTrackingFolders](product.md#BKMK_product_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_productassociation_MailboxTrackingFolders"></a> productassociation_MailboxTrackingFolders

See productassociation Entity [productassociation_MailboxTrackingFolders](productassociation.md#BKMK_productassociation_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_productpricelevel_MailboxTrackingFolders"></a> productpricelevel_MailboxTrackingFolders

See productpricelevel Entity [productpricelevel_MailboxTrackingFolders](productpricelevel.md#BKMK_productpricelevel_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_productsubstitute_MailboxTrackingFolders"></a> productsubstitute_MailboxTrackingFolders

See productsubstitute Entity [productsubstitute_MailboxTrackingFolders](productsubstitute.md#BKMK_productsubstitute_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_uom_MailboxTrackingFolders"></a> uom_MailboxTrackingFolders

See uom Entity [uom_MailboxTrackingFolders](uom.md#BKMK_uom_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_uomschedule_MailboxTrackingFolders"></a> uomschedule_MailboxTrackingFolders

See uomschedule Entity [uomschedule_MailboxTrackingFolders](uomschedule.md#BKMK_uomschedule_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_bookableresource_MailboxTrackingFolders"></a> bookableresource_MailboxTrackingFolders

See bookableresource Entity [bookableresource_MailboxTrackingFolders](bookableresource.md#BKMK_bookableresource_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_bookableresourcebooking_MailboxTrackingFolders"></a> bookableresourcebooking_MailboxTrackingFolders

See bookableresourcebooking Entity [bookableresourcebooking_MailboxTrackingFolders](bookableresourcebooking.md#BKMK_bookableresourcebooking_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_bookableresourcebookingexchangesyncidmapping_MailboxTrackingFolders"></a> bookableresourcebookingexchangesyncidmapping_MailboxTrackingFolders

See bookableresourcebookingexchangesyncidmapping Entity [bookableresourcebookingexchangesyncidmapping_MailboxTrackingFolders](bookableresourcebookingexchangesyncidmapping.md#BKMK_bookableresourcebookingexchangesyncidmapping_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_bookableresourcebookingheader_MailboxTrackingFolders"></a> bookableresourcebookingheader_MailboxTrackingFolders

See bookableresourcebookingheader Entity [bookableresourcebookingheader_MailboxTrackingFolders](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_bookableresourcecategory_MailboxTrackingFolders"></a> bookableresourcecategory_MailboxTrackingFolders

See bookableresourcecategory Entity [bookableresourcecategory_MailboxTrackingFolders](bookableresourcecategory.md#BKMK_bookableresourcecategory_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_bookableresourcecategoryassn_MailboxTrackingFolders"></a> bookableresourcecategoryassn_MailboxTrackingFolders

See bookableresourcecategoryassn Entity [bookableresourcecategoryassn_MailboxTrackingFolders](bookableresourcecategoryassn.md#BKMK_bookableresourcecategoryassn_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_bookableresourcecharacteristic_MailboxTrackingFolders"></a> bookableresourcecharacteristic_MailboxTrackingFolders

See bookableresourcecharacteristic Entity [bookableresourcecharacteristic_MailboxTrackingFolders](bookableresourcecharacteristic.md#BKMK_bookableresourcecharacteristic_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_bookableresourcegroup_MailboxTrackingFolders"></a> bookableresourcegroup_MailboxTrackingFolders

See bookableresourcegroup Entity [bookableresourcegroup_MailboxTrackingFolders](bookableresourcegroup.md#BKMK_bookableresourcegroup_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_bookingstatus_MailboxTrackingFolders"></a> bookingstatus_MailboxTrackingFolders

See bookingstatus Entity [bookingstatus_MailboxTrackingFolders](bookingstatus.md#BKMK_bookingstatus_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_characteristic_MailboxTrackingFolders"></a> characteristic_MailboxTrackingFolders

See characteristic Entity [characteristic_MailboxTrackingFolders](characteristic.md#BKMK_characteristic_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_ratingmodel_MailboxTrackingFolders"></a> ratingmodel_MailboxTrackingFolders

See ratingmodel Entity [ratingmodel_MailboxTrackingFolders](ratingmodel.md#BKMK_ratingmodel_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_ratingvalue_MailboxTrackingFolders"></a> ratingvalue_MailboxTrackingFolders

See ratingvalue Entity [ratingvalue_MailboxTrackingFolders](ratingvalue.md#BKMK_ratingvalue_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_BulkOperation_MailboxTrackingFolder"></a> BulkOperation_MailboxTrackingFolder

See bulkoperation Entity [BulkOperation_MailboxTrackingFolder](bulkoperation.md#BKMK_BulkOperation_MailboxTrackingFolder) One-To-Many relationship.

### <a name="BKMK_bulkoperationlog_MailboxTrackingFolders"></a> bulkoperationlog_MailboxTrackingFolders

See bulkoperationlog Entity [bulkoperationlog_MailboxTrackingFolders](bulkoperationlog.md#BKMK_bulkoperationlog_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_Campaign_MailboxTrackingFolder"></a> Campaign_MailboxTrackingFolder

See campaign Entity [Campaign_MailboxTrackingFolder](campaign.md#BKMK_Campaign_MailboxTrackingFolder) One-To-Many relationship.

### <a name="BKMK_CampaignActivity_MailboxTrackingFolder"></a> CampaignActivity_MailboxTrackingFolder

See campaignactivity Entity [CampaignActivity_MailboxTrackingFolder](campaignactivity.md#BKMK_CampaignActivity_MailboxTrackingFolder) One-To-Many relationship.

### <a name="BKMK_campaignactivityitem_MailboxTrackingFolders"></a> campaignactivityitem_MailboxTrackingFolders

See campaignactivityitem Entity [campaignactivityitem_MailboxTrackingFolders](campaignactivityitem.md#BKMK_campaignactivityitem_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_campaignitem_MailboxTrackingFolders"></a> campaignitem_MailboxTrackingFolders

See campaignitem Entity [campaignitem_MailboxTrackingFolders](campaignitem.md#BKMK_campaignitem_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_campaignresponse_MailboxTrackingFolders"></a> campaignresponse_MailboxTrackingFolders

See campaignresponse Entity [campaignresponse_MailboxTrackingFolders](campaignresponse.md#BKMK_campaignresponse_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_list_MailboxTrackingFolders"></a> list_MailboxTrackingFolders

See list Entity [list_MailboxTrackingFolders](list.md#BKMK_list_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_listmember_MailboxTrackingFolders"></a> listmember_MailboxTrackingFolders

See listmember Entity [listmember_MailboxTrackingFolders](listmember.md#BKMK_listmember_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_commitment_MailboxTrackingFolders"></a> commitment_MailboxTrackingFolders

See commitment Entity [commitment_MailboxTrackingFolders](commitment.md#BKMK_commitment_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_constraintbasedgroup_MailboxTrackingFolders"></a> constraintbasedgroup_MailboxTrackingFolders

See constraintbasedgroup Entity [constraintbasedgroup_MailboxTrackingFolders](constraintbasedgroup.md#BKMK_constraintbasedgroup_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_Contract_MailboxTrackingFolder"></a> Contract_MailboxTrackingFolder

See contract Entity [Contract_MailboxTrackingFolder](contract.md#BKMK_Contract_MailboxTrackingFolder) One-To-Many relationship.

### <a name="BKMK_contractdetail_MailboxTrackingFolders"></a> contractdetail_MailboxTrackingFolders

See contractdetail Entity [contractdetail_MailboxTrackingFolders](contractdetail.md#BKMK_contractdetail_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_contracttemplate_MailboxTrackingFolders"></a> contracttemplate_MailboxTrackingFolders

See contracttemplate Entity [contracttemplate_MailboxTrackingFolders](contracttemplate.md#BKMK_contracttemplate_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_Entitlement_MailboxTrackingFolder"></a> Entitlement_MailboxTrackingFolder

See entitlement Entity [Entitlement_MailboxTrackingFolder](entitlement.md#BKMK_Entitlement_MailboxTrackingFolder) One-To-Many relationship.

### <a name="BKMK_entitlementchannel_MailboxTrackingFolders"></a> entitlementchannel_MailboxTrackingFolders

See entitlementchannel Entity [entitlementchannel_MailboxTrackingFolders](entitlementchannel.md#BKMK_entitlementchannel_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_entitlementcontacts_MailboxTrackingFolders"></a> entitlementcontacts_MailboxTrackingFolders

See entitlementcontacts Entity [entitlementcontacts_MailboxTrackingFolders](entitlementcontacts.md#BKMK_entitlementcontacts_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_entitlementproducts_MailboxTrackingFolders"></a> entitlementproducts_MailboxTrackingFolders

See entitlementproducts Entity [entitlementproducts_MailboxTrackingFolders](entitlementproducts.md#BKMK_entitlementproducts_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_EntitlementTemplate_MailboxTrackingFolder"></a> EntitlementTemplate_MailboxTrackingFolder

See entitlementtemplate Entity [EntitlementTemplate_MailboxTrackingFolder](entitlementtemplate.md#BKMK_EntitlementTemplate_MailboxTrackingFolder) One-To-Many relationship.

### <a name="BKMK_entitlementtemplatechannel_MailboxTrackingFolders"></a> entitlementtemplatechannel_MailboxTrackingFolders

See entitlementtemplatechannel Entity [entitlementtemplatechannel_MailboxTrackingFolders](entitlementtemplatechannel.md#BKMK_entitlementtemplatechannel_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_entitlementtemplateproducts_MailboxTrackingFolders"></a> entitlementtemplateproducts_MailboxTrackingFolders

See entitlementtemplateproducts Entity [entitlementtemplateproducts_MailboxTrackingFolders](entitlementtemplateproducts.md#BKMK_entitlementtemplateproducts_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_equipment_MailboxTrackingFolders"></a> equipment_MailboxTrackingFolders

See equipment Entity [equipment_MailboxTrackingFolders](equipment.md#BKMK_equipment_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_Incident_MailboxTrackingFolder"></a> Incident_MailboxTrackingFolder

See incident Entity [Incident_MailboxTrackingFolder](incident.md#BKMK_Incident_MailboxTrackingFolder) One-To-Many relationship.

### <a name="BKMK_incidentknowledgebaserecord_MailboxTrackingFolders"></a> incidentknowledgebaserecord_MailboxTrackingFolders

See incidentknowledgebaserecord Entity [incidentknowledgebaserecord_MailboxTrackingFolders](incidentknowledgebaserecord.md#BKMK_incidentknowledgebaserecord_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_incidentresolution_MailboxTrackingFolders"></a> incidentresolution_MailboxTrackingFolders

See incidentresolution Entity [incidentresolution_MailboxTrackingFolders](incidentresolution.md#BKMK_incidentresolution_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_knowledgearticleincident_MailboxTrackingFolders"></a> knowledgearticleincident_MailboxTrackingFolders

See knowledgearticleincident Entity [knowledgearticleincident_MailboxTrackingFolders](knowledgearticleincident.md#BKMK_knowledgearticleincident_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_phonetocaseprocess_MailboxTrackingFolders"></a> phonetocaseprocess_MailboxTrackingFolders

See phonetocaseprocess Entity [phonetocaseprocess_MailboxTrackingFolders](phonetocaseprocess.md#BKMK_phonetocaseprocess_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_resource_MailboxTrackingFolders"></a> resource_MailboxTrackingFolders

See resource Entity [resource_MailboxTrackingFolders](resource.md#BKMK_resource_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_resourcegroup_MailboxTrackingFolders"></a> resourcegroup_MailboxTrackingFolders

See resourcegroup Entity [resourcegroup_MailboxTrackingFolders](resourcegroup.md#BKMK_resourcegroup_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_resourcespec_MailboxTrackingFolders"></a> resourcespec_MailboxTrackingFolders

See resourcespec Entity [resourcespec_MailboxTrackingFolders](resourcespec.md#BKMK_resourcespec_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_service_MailboxTrackingFolders"></a> service_MailboxTrackingFolders

See service Entity [service_MailboxTrackingFolders](service.md#BKMK_service_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_serviceappointment_MailboxTrackingFolders"></a> serviceappointment_MailboxTrackingFolders

See serviceappointment Entity [serviceappointment_MailboxTrackingFolders](serviceappointment.md#BKMK_serviceappointment_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_servicecontractcontacts_MailboxTrackingFolders"></a> servicecontractcontacts_MailboxTrackingFolders

See servicecontractcontacts Entity [servicecontractcontacts_MailboxTrackingFolders](servicecontractcontacts.md#BKMK_servicecontractcontacts_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_topic_MailboxTrackingFolders"></a> topic_MailboxTrackingFolders

See topic Entity [topic_MailboxTrackingFolders](topic.md#BKMK_topic_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_topichistory_MailboxTrackingFolders"></a> topichistory_MailboxTrackingFolders

See topichistory Entity [topichistory_MailboxTrackingFolders](topichistory.md#BKMK_topichistory_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_topicmodel_MailboxTrackingFolders"></a> topicmodel_MailboxTrackingFolders

See topicmodel Entity [topicmodel_MailboxTrackingFolders](topicmodel.md#BKMK_topicmodel_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_topicmodelconfiguration_MailboxTrackingFolders"></a> topicmodelconfiguration_MailboxTrackingFolders

See topicmodelconfiguration Entity [topicmodelconfiguration_MailboxTrackingFolders](topicmodelconfiguration.md#BKMK_topicmodelconfiguration_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_topicmodelexecutionhistory_MailboxTrackingFolders"></a> topicmodelexecutionhistory_MailboxTrackingFolders

See topicmodelexecutionhistory Entity [topicmodelexecutionhistory_MailboxTrackingFolders](topicmodelexecutionhistory.md#BKMK_topicmodelexecutionhistory_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_site_MailboxTrackingFolders"></a> site_MailboxTrackingFolders

See site Entity [site_MailboxTrackingFolders](site.md#BKMK_site_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_competitorproduct_MailboxTrackingFolders"></a> competitorproduct_MailboxTrackingFolders

See competitorproduct Entity [competitorproduct_MailboxTrackingFolders](competitorproduct.md#BKMK_competitorproduct_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_competitorsalesliterature_MailboxTrackingFolders"></a> competitorsalesliterature_MailboxTrackingFolders

See competitorsalesliterature Entity [competitorsalesliterature_MailboxTrackingFolders](competitorsalesliterature.md#BKMK_competitorsalesliterature_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_contactinvoices_MailboxTrackingFolders"></a> contactinvoices_MailboxTrackingFolders

See contactinvoices Entity [contactinvoices_MailboxTrackingFolders](contactinvoices.md#BKMK_contactinvoices_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_contactorders_MailboxTrackingFolders"></a> contactorders_MailboxTrackingFolders

See contactorders Entity [contactorders_MailboxTrackingFolders](contactorders.md#BKMK_contactorders_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_contactquotes_MailboxTrackingFolders"></a> contactquotes_MailboxTrackingFolders

See contactquotes Entity [contactquotes_MailboxTrackingFolders](contactquotes.md#BKMK_contactquotes_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_customeropportunityrole_MailboxTrackingFolders"></a> customeropportunityrole_MailboxTrackingFolders

See customeropportunityrole Entity [customeropportunityrole_MailboxTrackingFolders](customeropportunityrole.md#BKMK_customeropportunityrole_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_discount_MailboxTrackingFolders"></a> discount_MailboxTrackingFolders

See discount Entity [discount_MailboxTrackingFolders](discount.md#BKMK_discount_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_discounttype_MailboxTrackingFolders"></a> discounttype_MailboxTrackingFolders

See discounttype Entity [discounttype_MailboxTrackingFolders](discounttype.md#BKMK_discounttype_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_Invoice_MailboxTrackingFolder"></a> Invoice_MailboxTrackingFolder

See invoice Entity [Invoice_MailboxTrackingFolder](invoice.md#BKMK_Invoice_MailboxTrackingFolder) One-To-Many relationship.

### <a name="BKMK_invoicedetail_MailboxTrackingFolders"></a> invoicedetail_MailboxTrackingFolders

See invoicedetail Entity [invoicedetail_MailboxTrackingFolders](invoicedetail.md#BKMK_invoicedetail_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_leadcompetitors_MailboxTrackingFolders"></a> leadcompetitors_MailboxTrackingFolders

See leadcompetitors Entity [leadcompetitors_MailboxTrackingFolders](leadcompetitors.md#BKMK_leadcompetitors_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_leadproduct_MailboxTrackingFolders"></a> leadproduct_MailboxTrackingFolders

See leadproduct Entity [leadproduct_MailboxTrackingFolders](leadproduct.md#BKMK_leadproduct_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_leadtoopportunitysalesprocess_MailboxTrackingFolders"></a> leadtoopportunitysalesprocess_MailboxTrackingFolders

See leadtoopportunitysalesprocess Entity [leadtoopportunitysalesprocess_MailboxTrackingFolders](leadtoopportunitysalesprocess.md#BKMK_leadtoopportunitysalesprocess_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_Opportunity_MailboxTrackingFolder"></a> Opportunity_MailboxTrackingFolder

See opportunity Entity [Opportunity_MailboxTrackingFolder](opportunity.md#BKMK_Opportunity_MailboxTrackingFolder) One-To-Many relationship.

### <a name="BKMK_opportunityclose_MailboxTrackingFolders"></a> opportunityclose_MailboxTrackingFolders

See opportunityclose Entity [opportunityclose_MailboxTrackingFolders](opportunityclose.md#BKMK_opportunityclose_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_opportunitycompetitors_MailboxTrackingFolders"></a> opportunitycompetitors_MailboxTrackingFolders

See opportunitycompetitors Entity [opportunitycompetitors_MailboxTrackingFolders](opportunitycompetitors.md#BKMK_opportunitycompetitors_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_opportunityproduct_MailboxTrackingFolders"></a> opportunityproduct_MailboxTrackingFolders

See opportunityproduct Entity [opportunityproduct_MailboxTrackingFolders](opportunityproduct.md#BKMK_opportunityproduct_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_opportunitysalesprocess_MailboxTrackingFolders"></a> opportunitysalesprocess_MailboxTrackingFolders

See opportunitysalesprocess Entity [opportunitysalesprocess_MailboxTrackingFolders](opportunitysalesprocess.md#BKMK_opportunitysalesprocess_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_orderclose_MailboxTrackingFolders"></a> orderclose_MailboxTrackingFolders

See orderclose Entity [orderclose_MailboxTrackingFolders](orderclose.md#BKMK_orderclose_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_productsalesliterature_MailboxTrackingFolders"></a> productsalesliterature_MailboxTrackingFolders

See productsalesliterature Entity [productsalesliterature_MailboxTrackingFolders](productsalesliterature.md#BKMK_productsalesliterature_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_Quote_MailboxTrackingFolder"></a> Quote_MailboxTrackingFolder

See quote Entity [Quote_MailboxTrackingFolder](quote.md#BKMK_Quote_MailboxTrackingFolder) One-To-Many relationship.

### <a name="BKMK_quoteclose_MailboxTrackingFolders"></a> quoteclose_MailboxTrackingFolders

See quoteclose Entity [quoteclose_MailboxTrackingFolders](quoteclose.md#BKMK_quoteclose_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_quotedetail_MailboxTrackingFolders"></a> quotedetail_MailboxTrackingFolders

See quotedetail Entity [quotedetail_MailboxTrackingFolders](quotedetail.md#BKMK_quotedetail_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_salesliterature_MailboxTrackingFolders"></a> salesliterature_MailboxTrackingFolders

See salesliterature Entity [salesliterature_MailboxTrackingFolders](salesliterature.md#BKMK_salesliterature_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_salesliteratureitem_MailboxTrackingFolders"></a> salesliteratureitem_MailboxTrackingFolders

See salesliteratureitem Entity [salesliteratureitem_MailboxTrackingFolders](salesliteratureitem.md#BKMK_salesliteratureitem_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_SalesOrder_MailboxTrackingFolder"></a> SalesOrder_MailboxTrackingFolder

See salesorder Entity [SalesOrder_MailboxTrackingFolder](salesorder.md#BKMK_SalesOrder_MailboxTrackingFolder) One-To-Many relationship.

### <a name="BKMK_salesorderdetail_MailboxTrackingFolders"></a> salesorderdetail_MailboxTrackingFolders

See salesorderdetail Entity [salesorderdetail_MailboxTrackingFolders](salesorderdetail.md#BKMK_salesorderdetail_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_competitor_MailboxTrackingFolders"></a> competitor_MailboxTrackingFolders

See competitor Entity [competitor_MailboxTrackingFolders](competitor.md#BKMK_competitor_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_postalbum_MailboxTrackingFolders"></a> msdyn_postalbum_MailboxTrackingFolders

See msdyn_postalbum Entity [msdyn_postalbum_MailboxTrackingFolders](msdyn_postalbum.md#BKMK_msdyn_postalbum_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_postconfig_MailboxTrackingFolders"></a> msdyn_postconfig_MailboxTrackingFolders

See msdyn_postconfig Entity [msdyn_postconfig_MailboxTrackingFolders](msdyn_postconfig.md#BKMK_msdyn_postconfig_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_postruleconfig_MailboxTrackingFolders"></a> msdyn_postruleconfig_MailboxTrackingFolders

See msdyn_postruleconfig Entity [msdyn_postruleconfig_MailboxTrackingFolders](msdyn_postruleconfig.md#BKMK_msdyn_postruleconfig_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_wallsavedquery_MailboxTrackingFolders"></a> msdyn_wallsavedquery_MailboxTrackingFolders

See msdyn_wallsavedquery Entity [msdyn_wallsavedquery_MailboxTrackingFolders](msdyn_wallsavedquery.md#BKMK_msdyn_wallsavedquery_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_wallsavedqueryusersettings_MailboxTrackingFolders"></a> msdyn_wallsavedqueryusersettings_MailboxTrackingFolders

See msdyn_wallsavedqueryusersettings Entity [msdyn_wallsavedqueryusersettings_MailboxTrackingFolders](msdyn_wallsavedqueryusersettings.md#BKMK_msdyn_wallsavedqueryusersettings_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_actual_MailboxTrackingFolders"></a> msdyn_actual_MailboxTrackingFolders

See msdyn_actual Entity [msdyn_actual_MailboxTrackingFolders](msdyn_actual.md#BKMK_msdyn_actual_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalert_MailboxTrackingFolders"></a> msdyn_bookingalert_MailboxTrackingFolders

See msdyn_bookingalert Entity [msdyn_bookingalert_MailboxTrackingFolders](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalertstatus_MailboxTrackingFolders"></a> msdyn_bookingalertstatus_MailboxTrackingFolders

See msdyn_bookingalertstatus Entity [msdyn_bookingalertstatus_MailboxTrackingFolders](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingchange_MailboxTrackingFolders"></a> msdyn_bookingchange_MailboxTrackingFolders

See msdyn_bookingchange Entity [msdyn_bookingchange_MailboxTrackingFolders](msdyn_bookingchange.md#BKMK_msdyn_bookingchange_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingrule_MailboxTrackingFolders"></a> msdyn_bookingrule_MailboxTrackingFolders

See msdyn_bookingrule Entity [msdyn_bookingrule_MailboxTrackingFolders](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingsetupmetadata_MailboxTrackingFolders"></a> msdyn_bookingsetupmetadata_MailboxTrackingFolders

See msdyn_bookingsetupmetadata Entity [msdyn_bookingsetupmetadata_MailboxTrackingFolders](msdyn_bookingsetupmetadata.md#BKMK_msdyn_bookingsetupmetadata_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_clientextension_MailboxTrackingFolders"></a> msdyn_clientextension_MailboxTrackingFolders

See msdyn_clientextension Entity [msdyn_clientextension_MailboxTrackingFolders](msdyn_clientextension.md#BKMK_msdyn_clientextension_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_configuration_MailboxTrackingFolders"></a> msdyn_configuration_MailboxTrackingFolders

See msdyn_configuration Entity [msdyn_configuration_MailboxTrackingFolders](msdyn_configuration.md#BKMK_msdyn_configuration_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_organizationalunit_MailboxTrackingFolders"></a> msdyn_organizationalunit_MailboxTrackingFolders

See msdyn_organizationalunit Entity [msdyn_organizationalunit_MailboxTrackingFolders](msdyn_organizationalunit.md#BKMK_msdyn_organizationalunit_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_priority_MailboxTrackingFolders"></a> msdyn_priority_MailboxTrackingFolders

See msdyn_priority Entity [msdyn_priority_MailboxTrackingFolders](msdyn_priority.md#BKMK_msdyn_priority_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementcharacteristic_MailboxTrackingFolders"></a> msdyn_requirementcharacteristic_MailboxTrackingFolders

See msdyn_requirementcharacteristic Entity [msdyn_requirementcharacteristic_MailboxTrackingFolders](msdyn_requirementcharacteristic.md#BKMK_msdyn_requirementcharacteristic_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementorganizationunit_MailboxTrackingFolders"></a> msdyn_requirementorganizationunit_MailboxTrackingFolders

See msdyn_requirementorganizationunit Entity [msdyn_requirementorganizationunit_MailboxTrackingFolders](msdyn_requirementorganizationunit.md#BKMK_msdyn_requirementorganizationunit_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementresourcecategory_MailboxTrackingFolders"></a> msdyn_requirementresourcecategory_MailboxTrackingFolders

See msdyn_requirementresourcecategory Entity [msdyn_requirementresourcecategory_MailboxTrackingFolders](msdyn_requirementresourcecategory.md#BKMK_msdyn_requirementresourcecategory_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementresourcepreference_MailboxTrackingFolders"></a> msdyn_requirementresourcepreference_MailboxTrackingFolders

See msdyn_requirementresourcepreference Entity [msdyn_requirementresourcepreference_MailboxTrackingFolders](msdyn_requirementresourcepreference.md#BKMK_msdyn_requirementresourcepreference_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementstatus_MailboxTrackingFolders"></a> msdyn_requirementstatus_MailboxTrackingFolders

See msdyn_requirementstatus Entity [msdyn_requirementstatus_MailboxTrackingFolders](msdyn_requirementstatus.md#BKMK_msdyn_requirementstatus_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcerequirement_MailboxTrackingFolders"></a> msdyn_resourcerequirement_MailboxTrackingFolders

See msdyn_resourcerequirement Entity [msdyn_resourcerequirement_MailboxTrackingFolders](msdyn_resourcerequirement.md#BKMK_msdyn_resourcerequirement_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcerequirementdetail_MailboxTrackingFolders"></a> msdyn_resourcerequirementdetail_MailboxTrackingFolders

See msdyn_resourcerequirementdetail Entity [msdyn_resourcerequirementdetail_MailboxTrackingFolders](msdyn_resourcerequirementdetail.md#BKMK_msdyn_resourcerequirementdetail_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_resourceterritory_MailboxTrackingFolders"></a> msdyn_resourceterritory_MailboxTrackingFolders

See msdyn_resourceterritory Entity [msdyn_resourceterritory_MailboxTrackingFolders](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_scheduleboardsetting_MailboxTrackingFolders"></a> msdyn_scheduleboardsetting_MailboxTrackingFolders

See msdyn_scheduleboardsetting Entity [msdyn_scheduleboardsetting_MailboxTrackingFolders](msdyn_scheduleboardsetting.md#BKMK_msdyn_scheduleboardsetting_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_schedulingparameter_MailboxTrackingFolders"></a> msdyn_schedulingparameter_MailboxTrackingFolders

See msdyn_schedulingparameter Entity [msdyn_schedulingparameter_MailboxTrackingFolders](msdyn_schedulingparameter.md#BKMK_msdyn_schedulingparameter_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_systemuserschedulersetting_MailboxTrackingFolders"></a> msdyn_systemuserschedulersetting_MailboxTrackingFolders

See msdyn_systemuserschedulersetting Entity [msdyn_systemuserschedulersetting_MailboxTrackingFolders](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroup_MailboxTrackingFolders"></a> msdyn_timegroup_MailboxTrackingFolders

See msdyn_timegroup Entity [msdyn_timegroup_MailboxTrackingFolders](msdyn_timegroup.md#BKMK_msdyn_timegroup_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroupdetail_MailboxTrackingFolders"></a> msdyn_timegroupdetail_MailboxTrackingFolders

See msdyn_timegroupdetail Entity [msdyn_timegroupdetail_MailboxTrackingFolders](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_transactionorigin_MailboxTrackingFolders"></a> msdyn_transactionorigin_MailboxTrackingFolders

See msdyn_transactionorigin Entity [msdyn_transactionorigin_MailboxTrackingFolders](msdyn_transactionorigin.md#BKMK_msdyn_transactionorigin_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_workhourtemplate_MailboxTrackingFolders"></a> msdyn_workhourtemplate_MailboxTrackingFolders

See msdyn_workhourtemplate Entity [msdyn_workhourtemplate_MailboxTrackingFolders](msdyn_workhourtemplate.md#BKMK_msdyn_workhourtemplate_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_accountpricelist_MailboxTrackingFolders"></a> msdyn_accountpricelist_MailboxTrackingFolders

See msdyn_accountpricelist Entity [msdyn_accountpricelist_MailboxTrackingFolders](msdyn_accountpricelist.md#BKMK_msdyn_accountpricelist_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_approval_MailboxTrackingFolders"></a> msdyn_approval_MailboxTrackingFolders

See msdyn_approval Entity [msdyn_approval_MailboxTrackingFolders](msdyn_approval.md#BKMK_msdyn_approval_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_batchjob_MailboxTrackingFolders"></a> msdyn_batchjob_MailboxTrackingFolders

See msdyn_batchjob Entity [msdyn_batchjob_MailboxTrackingFolders](msdyn_batchjob.md#BKMK_msdyn_batchjob_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_665e73aa18c247d886bfc50499c73b82_MailboxTrackingFolders"></a> msdyn_bpf_665e73aa18c247d886bfc50499c73b82_MailboxTrackingFolders

See msdyn_bpf_665e73aa18c247d886bfc50499c73b82 Entity [msdyn_bpf_665e73aa18c247d886bfc50499c73b82_MailboxTrackingFolders](msdyn_bpf_665e73aa18c247d886bfc50499c73b82.md#BKMK_msdyn_bpf_665e73aa18c247d886bfc50499c73b82_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_MailboxTrackingFolders"></a> msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_MailboxTrackingFolders

See msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d Entity [msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_MailboxTrackingFolders](msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d.md#BKMK_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_characteristicreqforteammember_MailboxTrackingFolders"></a> msdyn_characteristicreqforteammember_MailboxTrackingFolders

See msdyn_characteristicreqforteammember Entity [msdyn_characteristicreqforteammember_MailboxTrackingFolders](msdyn_characteristicreqforteammember.md#BKMK_msdyn_characteristicreqforteammember_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_contactpricelist_MailboxTrackingFolders"></a> msdyn_contactpricelist_MailboxTrackingFolders

See msdyn_contactpricelist Entity [msdyn_contactpricelist_MailboxTrackingFolders](msdyn_contactpricelist.md#BKMK_msdyn_contactpricelist_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_contractlineinvoiceschedule_MailboxTrackingFolders"></a> msdyn_contractlineinvoiceschedule_MailboxTrackingFolders

See msdyn_contractlineinvoiceschedule Entity [msdyn_contractlineinvoiceschedule_MailboxTrackingFolders](msdyn_contractlineinvoiceschedule.md#BKMK_msdyn_contractlineinvoiceschedule_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_contractlinescheduleofvalue_MailboxTrackingFolders"></a> msdyn_contractlinescheduleofvalue_MailboxTrackingFolders

See msdyn_contractlinescheduleofvalue Entity [msdyn_contractlinescheduleofvalue_MailboxTrackingFolders](msdyn_contractlinescheduleofvalue.md#BKMK_msdyn_contractlinescheduleofvalue_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_dataexport_MailboxTrackingFolders"></a> msdyn_dataexport_MailboxTrackingFolders

See msdyn_dataexport Entity [msdyn_dataexport_MailboxTrackingFolders](msdyn_dataexport.md#BKMK_msdyn_dataexport_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_delegation_MailboxTrackingFolders"></a> msdyn_delegation_MailboxTrackingFolders

See msdyn_delegation Entity [msdyn_delegation_MailboxTrackingFolders](msdyn_delegation.md#BKMK_msdyn_delegation_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_estimate_MailboxTrackingFolders"></a> msdyn_estimate_MailboxTrackingFolders

See msdyn_estimate Entity [msdyn_estimate_MailboxTrackingFolders](msdyn_estimate.md#BKMK_msdyn_estimate_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_estimateline_MailboxTrackingFolders"></a> msdyn_estimateline_MailboxTrackingFolders

See msdyn_estimateline Entity [msdyn_estimateline_MailboxTrackingFolders](msdyn_estimateline.md#BKMK_msdyn_estimateline_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_expense_MailboxTrackingFolders"></a> msdyn_expense_MailboxTrackingFolders

See msdyn_expense Entity [msdyn_expense_MailboxTrackingFolders](msdyn_expense.md#BKMK_msdyn_expense_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_expensecategory_MailboxTrackingFolders"></a> msdyn_expensecategory_MailboxTrackingFolders

See msdyn_expensecategory Entity [msdyn_expensecategory_MailboxTrackingFolders](msdyn_expensecategory.md#BKMK_msdyn_expensecategory_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_expensereceipt_MailboxTrackingFolders"></a> msdyn_expensereceipt_MailboxTrackingFolders

See msdyn_expensereceipt Entity [msdyn_expensereceipt_MailboxTrackingFolders](msdyn_expensereceipt.md#BKMK_msdyn_expensereceipt_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_fact_MailboxTrackingFolders"></a> msdyn_fact_MailboxTrackingFolders

See msdyn_fact Entity [msdyn_fact_MailboxTrackingFolders](msdyn_fact.md#BKMK_msdyn_fact_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldcomputation_MailboxTrackingFolders"></a> msdyn_fieldcomputation_MailboxTrackingFolders

See msdyn_fieldcomputation Entity [msdyn_fieldcomputation_MailboxTrackingFolders](msdyn_fieldcomputation.md#BKMK_msdyn_fieldcomputation_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_findworkevent_MailboxTrackingFolders"></a> msdyn_findworkevent_MailboxTrackingFolders

See msdyn_findworkevent Entity [msdyn_findworkevent_MailboxTrackingFolders](msdyn_findworkevent.md#BKMK_msdyn_findworkevent_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_integrationjob_MailboxTrackingFolders"></a> msdyn_integrationjob_MailboxTrackingFolders

See msdyn_integrationjob Entity [msdyn_integrationjob_MailboxTrackingFolders](msdyn_integrationjob.md#BKMK_msdyn_integrationjob_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_integrationjobdetail_MailboxTrackingFolders"></a> msdyn_integrationjobdetail_MailboxTrackingFolders

See msdyn_integrationjobdetail Entity [msdyn_integrationjobdetail_MailboxTrackingFolders](msdyn_integrationjobdetail.md#BKMK_msdyn_integrationjobdetail_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_invoicefrequency_MailboxTrackingFolders"></a> msdyn_invoicefrequency_MailboxTrackingFolders

See msdyn_invoicefrequency Entity [msdyn_invoicefrequency_MailboxTrackingFolders](msdyn_invoicefrequency.md#BKMK_msdyn_invoicefrequency_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_invoicefrequencydetail_MailboxTrackingFolders"></a> msdyn_invoicefrequencydetail_MailboxTrackingFolders

See msdyn_invoicefrequencydetail Entity [msdyn_invoicefrequencydetail_MailboxTrackingFolders](msdyn_invoicefrequencydetail.md#BKMK_msdyn_invoicefrequencydetail_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_invoicelinetransaction_MailboxTrackingFolders"></a> msdyn_invoicelinetransaction_MailboxTrackingFolders

See msdyn_invoicelinetransaction Entity [msdyn_invoicelinetransaction_MailboxTrackingFolders](msdyn_invoicelinetransaction.md#BKMK_msdyn_invoicelinetransaction_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_journal_MailboxTrackingFolders"></a> msdyn_journal_MailboxTrackingFolders

See msdyn_journal Entity [msdyn_journal_MailboxTrackingFolders](msdyn_journal.md#BKMK_msdyn_journal_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_journalline_MailboxTrackingFolders"></a> msdyn_journalline_MailboxTrackingFolders

See msdyn_journalline Entity [msdyn_journalline_MailboxTrackingFolders](msdyn_journalline.md#BKMK_msdyn_journalline_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_mlresultcache_MailboxTrackingFolders"></a> msdyn_mlresultcache_MailboxTrackingFolders

See msdyn_mlresultcache Entity [msdyn_mlresultcache_MailboxTrackingFolders](msdyn_mlresultcache.md#BKMK_msdyn_mlresultcache_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitylineresourcecategory_MailboxTrackingFolders"></a> msdyn_opportunitylineresourcecategory_MailboxTrackingFolders

See msdyn_opportunitylineresourcecategory Entity [msdyn_opportunitylineresourcecategory_MailboxTrackingFolders](msdyn_opportunitylineresourcecategory.md#BKMK_msdyn_opportunitylineresourcecategory_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitylinetransaction_MailboxTrackingFolders"></a> msdyn_opportunitylinetransaction_MailboxTrackingFolders

See msdyn_opportunitylinetransaction Entity [msdyn_opportunitylinetransaction_MailboxTrackingFolders](msdyn_opportunitylinetransaction.md#BKMK_msdyn_opportunitylinetransaction_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitylinetransactioncategory_MailboxTrackingFolders"></a> msdyn_opportunitylinetransactioncategory_MailboxTrackingFolders

See msdyn_opportunitylinetransactioncategory Entity [msdyn_opportunitylinetransactioncategory_MailboxTrackingFolders](msdyn_opportunitylinetransactioncategory.md#BKMK_msdyn_opportunitylinetransactioncategory_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitylinetransactionclassificatio_MailboxTrackingFolders"></a> msdyn_opportunitylinetransactionclassificatio_MailboxTrackingFolders

See msdyn_opportunitylinetransactionclassificatio Entity [msdyn_opportunitylinetransactionclassificatio_MailboxTrackingFolders](msdyn_opportunitylinetransactionclassificatio.md#BKMK_msdyn_opportunitylinetransactionclassificatio_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitypricelist_MailboxTrackingFolders"></a> msdyn_opportunitypricelist_MailboxTrackingFolders

See msdyn_opportunitypricelist Entity [msdyn_opportunitypricelist_MailboxTrackingFolders](msdyn_opportunitypricelist.md#BKMK_msdyn_opportunitypricelist_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_orderlineresourcecategory_MailboxTrackingFolders"></a> msdyn_orderlineresourcecategory_MailboxTrackingFolders

See msdyn_orderlineresourcecategory Entity [msdyn_orderlineresourcecategory_MailboxTrackingFolders](msdyn_orderlineresourcecategory.md#BKMK_msdyn_orderlineresourcecategory_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_orderlinetransaction_MailboxTrackingFolders"></a> msdyn_orderlinetransaction_MailboxTrackingFolders

See msdyn_orderlinetransaction Entity [msdyn_orderlinetransaction_MailboxTrackingFolders](msdyn_orderlinetransaction.md#BKMK_msdyn_orderlinetransaction_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_orderlinetransactioncategory_MailboxTrackingFolders"></a> msdyn_orderlinetransactioncategory_MailboxTrackingFolders

See msdyn_orderlinetransactioncategory Entity [msdyn_orderlinetransactioncategory_MailboxTrackingFolders](msdyn_orderlinetransactioncategory.md#BKMK_msdyn_orderlinetransactioncategory_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_orderlinetransactionclassification_MailboxTrackingFolders"></a> msdyn_orderlinetransactionclassification_MailboxTrackingFolders

See msdyn_orderlinetransactionclassification Entity [msdyn_orderlinetransactionclassification_MailboxTrackingFolders](msdyn_orderlinetransactionclassification.md#BKMK_msdyn_orderlinetransactionclassification_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_orderpricelist_MailboxTrackingFolders"></a> msdyn_orderpricelist_MailboxTrackingFolders

See msdyn_orderpricelist Entity [msdyn_orderpricelist_MailboxTrackingFolders](msdyn_orderpricelist.md#BKMK_msdyn_orderpricelist_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_processnotes_MailboxTrackingFolders"></a> msdyn_processnotes_MailboxTrackingFolders

See msdyn_processnotes Entity [msdyn_processnotes_MailboxTrackingFolders](msdyn_processnotes.md#BKMK_msdyn_processnotes_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_project_MailboxTrackingFolders"></a> msdyn_project_MailboxTrackingFolders

See msdyn_project Entity [msdyn_project_MailboxTrackingFolders](msdyn_project.md#BKMK_msdyn_project_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_projectapproval_MailboxTrackingFolders"></a> msdyn_projectapproval_MailboxTrackingFolders

See msdyn_projectapproval Entity [msdyn_projectapproval_MailboxTrackingFolders](msdyn_projectapproval.md#BKMK_msdyn_projectapproval_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_projectparameter_MailboxTrackingFolders"></a> msdyn_projectparameter_MailboxTrackingFolders

See msdyn_projectparameter Entity [msdyn_projectparameter_MailboxTrackingFolders](msdyn_projectparameter.md#BKMK_msdyn_projectparameter_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_projectparameterpricelist_MailboxTrackingFolders"></a> msdyn_projectparameterpricelist_MailboxTrackingFolders

See msdyn_projectparameterpricelist Entity [msdyn_projectparameterpricelist_MailboxTrackingFolders](msdyn_projectparameterpricelist.md#BKMK_msdyn_projectparameterpricelist_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_projectpricelist_MailboxTrackingFolders"></a> msdyn_projectpricelist_MailboxTrackingFolders

See msdyn_projectpricelist Entity [msdyn_projectpricelist_MailboxTrackingFolders](msdyn_projectpricelist.md#BKMK_msdyn_projectpricelist_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_projecttask_MailboxTrackingFolders"></a> msdyn_projecttask_MailboxTrackingFolders

See msdyn_projecttask Entity [msdyn_projecttask_MailboxTrackingFolders](msdyn_projecttask.md#BKMK_msdyn_projecttask_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_projecttaskdependency_MailboxTrackingFolders"></a> msdyn_projecttaskdependency_MailboxTrackingFolders

See msdyn_projecttaskdependency Entity [msdyn_projecttaskdependency_MailboxTrackingFolders](msdyn_projecttaskdependency.md#BKMK_msdyn_projecttaskdependency_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_projecttaskstatususer_MailboxTrackingFolders"></a> msdyn_projecttaskstatususer_MailboxTrackingFolders

See msdyn_projecttaskstatususer Entity [msdyn_projecttaskstatususer_MailboxTrackingFolders](msdyn_projecttaskstatususer.md#BKMK_msdyn_projecttaskstatususer_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_projectteam_MailboxTrackingFolders"></a> msdyn_projectteam_MailboxTrackingFolders

See msdyn_projectteam Entity [msdyn_projectteam_MailboxTrackingFolders](msdyn_projectteam.md#BKMK_msdyn_projectteam_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_projectteammembersignup_MailboxTrackingFolders"></a> msdyn_projectteammembersignup_MailboxTrackingFolders

See msdyn_projectteammembersignup Entity [msdyn_projectteammembersignup_MailboxTrackingFolders](msdyn_projectteammembersignup.md#BKMK_msdyn_projectteammembersignup_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_projecttransactioncategory_MailboxTrackingFolders"></a> msdyn_projecttransactioncategory_MailboxTrackingFolders

See msdyn_projecttransactioncategory Entity [msdyn_projecttransactioncategory_MailboxTrackingFolders](msdyn_projecttransactioncategory.md#BKMK_msdyn_projecttransactioncategory_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelineanalyticsbreakdown_MailboxTrackingFolders"></a> msdyn_quotelineanalyticsbreakdown_MailboxTrackingFolders

See msdyn_quotelineanalyticsbreakdown Entity [msdyn_quotelineanalyticsbreakdown_MailboxTrackingFolders](msdyn_quotelineanalyticsbreakdown.md#BKMK_msdyn_quotelineanalyticsbreakdown_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelineinvoiceschedule_MailboxTrackingFolders"></a> msdyn_quotelineinvoiceschedule_MailboxTrackingFolders

See msdyn_quotelineinvoiceschedule Entity [msdyn_quotelineinvoiceschedule_MailboxTrackingFolders](msdyn_quotelineinvoiceschedule.md#BKMK_msdyn_quotelineinvoiceschedule_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelineresourcecategory_MailboxTrackingFolders"></a> msdyn_quotelineresourcecategory_MailboxTrackingFolders

See msdyn_quotelineresourcecategory Entity [msdyn_quotelineresourcecategory_MailboxTrackingFolders](msdyn_quotelineresourcecategory.md#BKMK_msdyn_quotelineresourcecategory_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelinescheduleofvalue_MailboxTrackingFolders"></a> msdyn_quotelinescheduleofvalue_MailboxTrackingFolders

See msdyn_quotelinescheduleofvalue Entity [msdyn_quotelinescheduleofvalue_MailboxTrackingFolders](msdyn_quotelinescheduleofvalue.md#BKMK_msdyn_quotelinescheduleofvalue_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelinetransaction_MailboxTrackingFolders"></a> msdyn_quotelinetransaction_MailboxTrackingFolders

See msdyn_quotelinetransaction Entity [msdyn_quotelinetransaction_MailboxTrackingFolders](msdyn_quotelinetransaction.md#BKMK_msdyn_quotelinetransaction_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelinetransactioncategory_MailboxTrackingFolders"></a> msdyn_quotelinetransactioncategory_MailboxTrackingFolders

See msdyn_quotelinetransactioncategory Entity [msdyn_quotelinetransactioncategory_MailboxTrackingFolders](msdyn_quotelinetransactioncategory.md#BKMK_msdyn_quotelinetransactioncategory_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelinetransactionclassification_MailboxTrackingFolders"></a> msdyn_quotelinetransactionclassification_MailboxTrackingFolders

See msdyn_quotelinetransactionclassification Entity [msdyn_quotelinetransactionclassification_MailboxTrackingFolders](msdyn_quotelinetransactionclassification.md#BKMK_msdyn_quotelinetransactionclassification_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_quotepricelist_MailboxTrackingFolders"></a> msdyn_quotepricelist_MailboxTrackingFolders

See msdyn_quotepricelist Entity [msdyn_quotepricelist_MailboxTrackingFolders](msdyn_quotepricelist.md#BKMK_msdyn_quotepricelist_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_resourceassignment_MailboxTrackingFolders"></a> msdyn_resourceassignment_MailboxTrackingFolders

See msdyn_resourceassignment Entity [msdyn_resourceassignment_MailboxTrackingFolders](msdyn_resourceassignment.md#BKMK_msdyn_resourceassignment_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_resourceassignmentdetail_MailboxTrackingFolders"></a> msdyn_resourceassignmentdetail_MailboxTrackingFolders

See msdyn_resourceassignmentdetail Entity [msdyn_resourceassignmentdetail_MailboxTrackingFolders](msdyn_resourceassignmentdetail.md#BKMK_msdyn_resourceassignmentdetail_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcecategorypricelevel_MailboxTrackingFolders"></a> msdyn_resourcecategorypricelevel_MailboxTrackingFolders

See msdyn_resourcecategorypricelevel Entity [msdyn_resourcecategorypricelevel_MailboxTrackingFolders](msdyn_resourcecategorypricelevel.md#BKMK_msdyn_resourcecategorypricelevel_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcerequest_MailboxTrackingFolders"></a> msdyn_resourcerequest_MailboxTrackingFolders

See msdyn_resourcerequest Entity [msdyn_resourcerequest_MailboxTrackingFolders](msdyn_resourcerequest.md#BKMK_msdyn_resourcerequest_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_rolecompetencyrequirement_MailboxTrackingFolders"></a> msdyn_rolecompetencyrequirement_MailboxTrackingFolders

See msdyn_rolecompetencyrequirement Entity [msdyn_rolecompetencyrequirement_MailboxTrackingFolders](msdyn_rolecompetencyrequirement.md#BKMK_msdyn_rolecompetencyrequirement_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_roleutilization_MailboxTrackingFolders"></a> msdyn_roleutilization_MailboxTrackingFolders

See msdyn_roleutilization Entity [msdyn_roleutilization_MailboxTrackingFolders](msdyn_roleutilization.md#BKMK_msdyn_roleutilization_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_timeentry_MailboxTrackingFolders"></a> msdyn_timeentry_MailboxTrackingFolders

See msdyn_timeentry Entity [msdyn_timeentry_MailboxTrackingFolders](msdyn_timeentry.md#BKMK_msdyn_timeentry_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_timeoffcalendar_MailboxTrackingFolders"></a> msdyn_timeoffcalendar_MailboxTrackingFolders

See msdyn_timeoffcalendar Entity [msdyn_timeoffcalendar_MailboxTrackingFolders](msdyn_timeoffcalendar.md#BKMK_msdyn_timeoffcalendar_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_transactioncategory_MailboxTrackingFolders"></a> msdyn_transactioncategory_MailboxTrackingFolders

See msdyn_transactioncategory Entity [msdyn_transactioncategory_MailboxTrackingFolders](msdyn_transactioncategory.md#BKMK_msdyn_transactioncategory_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_transactioncategoryclassification_MailboxTrackingFolders"></a> msdyn_transactioncategoryclassification_MailboxTrackingFolders

See msdyn_transactioncategoryclassification Entity [msdyn_transactioncategoryclassification_MailboxTrackingFolders](msdyn_transactioncategoryclassification.md#BKMK_msdyn_transactioncategoryclassification_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_transactioncategoryhierarchyelement_MailboxTrackingFolders"></a> msdyn_transactioncategoryhierarchyelement_MailboxTrackingFolders

See msdyn_transactioncategoryhierarchyelement Entity [msdyn_transactioncategoryhierarchyelement_MailboxTrackingFolders](msdyn_transactioncategoryhierarchyelement.md#BKMK_msdyn_transactioncategoryhierarchyelement_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_transactioncategorypricelevel_MailboxTrackingFolders"></a> msdyn_transactioncategorypricelevel_MailboxTrackingFolders

See msdyn_transactioncategorypricelevel Entity [msdyn_transactioncategorypricelevel_MailboxTrackingFolders](msdyn_transactioncategorypricelevel.md#BKMK_msdyn_transactioncategorypricelevel_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_transactionconnection_MailboxTrackingFolders"></a> msdyn_transactionconnection_MailboxTrackingFolders

See msdyn_transactionconnection Entity [msdyn_transactionconnection_MailboxTrackingFolders](msdyn_transactionconnection.md#BKMK_msdyn_transactionconnection_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_transactiontype_MailboxTrackingFolders"></a> msdyn_transactiontype_MailboxTrackingFolders

See msdyn_transactiontype Entity [msdyn_transactiontype_MailboxTrackingFolders](msdyn_transactiontype.md#BKMK_msdyn_transactiontype_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_userworkhistory_MailboxTrackingFolders"></a> msdyn_userworkhistory_MailboxTrackingFolders

See msdyn_userworkhistory Entity [msdyn_userworkhistory_MailboxTrackingFolders](msdyn_userworkhistory.md#BKMK_msdyn_userworkhistory_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_agreement_MailboxTrackingFolders"></a> msdyn_agreement_MailboxTrackingFolders

See msdyn_agreement Entity [msdyn_agreement_MailboxTrackingFolders](msdyn_agreement.md#BKMK_msdyn_agreement_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingdate_MailboxTrackingFolders"></a> msdyn_agreementbookingdate_MailboxTrackingFolders

See msdyn_agreementbookingdate Entity [msdyn_agreementbookingdate_MailboxTrackingFolders](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingincident_MailboxTrackingFolders"></a> msdyn_agreementbookingincident_MailboxTrackingFolders

See msdyn_agreementbookingincident Entity [msdyn_agreementbookingincident_MailboxTrackingFolders](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingproduct_MailboxTrackingFolders"></a> msdyn_agreementbookingproduct_MailboxTrackingFolders

See msdyn_agreementbookingproduct Entity [msdyn_agreementbookingproduct_MailboxTrackingFolders](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservice_MailboxTrackingFolders"></a> msdyn_agreementbookingservice_MailboxTrackingFolders

See msdyn_agreementbookingservice Entity [msdyn_agreementbookingservice_MailboxTrackingFolders](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservicetask_MailboxTrackingFolders"></a> msdyn_agreementbookingservicetask_MailboxTrackingFolders

See msdyn_agreementbookingservicetask Entity [msdyn_agreementbookingservicetask_MailboxTrackingFolders](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingsetup_MailboxTrackingFolders"></a> msdyn_agreementbookingsetup_MailboxTrackingFolders

See msdyn_agreementbookingsetup Entity [msdyn_agreementbookingsetup_MailboxTrackingFolders](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicedate_MailboxTrackingFolders"></a> msdyn_agreementinvoicedate_MailboxTrackingFolders

See msdyn_agreementinvoicedate Entity [msdyn_agreementinvoicedate_MailboxTrackingFolders](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoiceproduct_MailboxTrackingFolders"></a> msdyn_agreementinvoiceproduct_MailboxTrackingFolders

See msdyn_agreementinvoiceproduct Entity [msdyn_agreementinvoiceproduct_MailboxTrackingFolders](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicesetup_MailboxTrackingFolders"></a> msdyn_agreementinvoicesetup_MailboxTrackingFolders

See msdyn_agreementinvoicesetup Entity [msdyn_agreementinvoicesetup_MailboxTrackingFolders](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementsubstatus_MailboxTrackingFolders"></a> msdyn_agreementsubstatus_MailboxTrackingFolders

See msdyn_agreementsubstatus Entity [msdyn_agreementsubstatus_MailboxTrackingFolders](msdyn_agreementsubstatus.md#BKMK_msdyn_agreementsubstatus_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingjournal_MailboxTrackingFolders"></a> msdyn_bookingjournal_MailboxTrackingFolders

See msdyn_bookingjournal Entity [msdyn_bookingjournal_MailboxTrackingFolders](msdyn_bookingjournal.md#BKMK_msdyn_bookingjournal_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingtimestamp_MailboxTrackingFolders"></a> msdyn_bookingtimestamp_MailboxTrackingFolders

See msdyn_bookingtimestamp Entity [msdyn_bookingtimestamp_MailboxTrackingFolders](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_MailboxTrackingFolders"></a> msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_MailboxTrackingFolders

See msdyn_bpf_2c5fe86acc8b414b8322ae571000c799 Entity [msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_MailboxTrackingFolders](msdyn_bpf_2c5fe86acc8b414b8322ae571000c799.md#BKMK_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_989e9b1857e24af18787d5143b67523b_MailboxTrackingFolders"></a> msdyn_bpf_989e9b1857e24af18787d5143b67523b_MailboxTrackingFolders

See msdyn_bpf_989e9b1857e24af18787d5143b67523b Entity [msdyn_bpf_989e9b1857e24af18787d5143b67523b_MailboxTrackingFolders](msdyn_bpf_989e9b1857e24af18787d5143b67523b.md#BKMK_msdyn_bpf_989e9b1857e24af18787d5143b67523b_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_MailboxTrackingFolders"></a> msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_MailboxTrackingFolders

See msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3 Entity [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_MailboxTrackingFolders](msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3.md#BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_MailboxTrackingFolders"></a> msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_MailboxTrackingFolders

See msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39 Entity [msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_MailboxTrackingFolders](msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39.md#BKMK_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_customerasset_MailboxTrackingFolders"></a> msdyn_customerasset_MailboxTrackingFolders

See msdyn_customerasset Entity [msdyn_customerasset_MailboxTrackingFolders](msdyn_customerasset.md#BKMK_msdyn_customerasset_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldservicepricelistitem_MailboxTrackingFolders"></a> msdyn_fieldservicepricelistitem_MailboxTrackingFolders

See msdyn_fieldservicepricelistitem Entity [msdyn_fieldservicepricelistitem_MailboxTrackingFolders](msdyn_fieldservicepricelistitem.md#BKMK_msdyn_fieldservicepricelistitem_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldservicesetting_MailboxTrackingFolders"></a> msdyn_fieldservicesetting_MailboxTrackingFolders

See msdyn_fieldservicesetting Entity [msdyn_fieldservicesetting_MailboxTrackingFolders](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldservicesystemjob_MailboxTrackingFolders"></a> msdyn_fieldservicesystemjob_MailboxTrackingFolders

See msdyn_fieldservicesystemjob Entity [msdyn_fieldservicesystemjob_MailboxTrackingFolders](msdyn_fieldservicesystemjob.md#BKMK_msdyn_fieldservicesystemjob_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttype_MailboxTrackingFolders"></a> msdyn_incidenttype_MailboxTrackingFolders

See msdyn_incidenttype Entity [msdyn_incidenttype_MailboxTrackingFolders](msdyn_incidenttype.md#BKMK_msdyn_incidenttype_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypecharacteristic_MailboxTrackingFolders"></a> msdyn_incidenttypecharacteristic_MailboxTrackingFolders

See msdyn_incidenttypecharacteristic Entity [msdyn_incidenttypecharacteristic_MailboxTrackingFolders](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeproduct_MailboxTrackingFolders"></a> msdyn_incidenttypeproduct_MailboxTrackingFolders

See msdyn_incidenttypeproduct Entity [msdyn_incidenttypeproduct_MailboxTrackingFolders](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeservice_MailboxTrackingFolders"></a> msdyn_incidenttypeservice_MailboxTrackingFolders

See msdyn_incidenttypeservice Entity [msdyn_incidenttypeservice_MailboxTrackingFolders](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeservicetask_MailboxTrackingFolders"></a> msdyn_incidenttypeservicetask_MailboxTrackingFolders

See msdyn_incidenttypeservicetask Entity [msdyn_incidenttypeservicetask_MailboxTrackingFolders](msdyn_incidenttypeservicetask.md#BKMK_msdyn_incidenttypeservicetask_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustment_MailboxTrackingFolders"></a> msdyn_inventoryadjustment_MailboxTrackingFolders

See msdyn_inventoryadjustment Entity [msdyn_inventoryadjustment_MailboxTrackingFolders](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustmentproduct_MailboxTrackingFolders"></a> msdyn_inventoryadjustmentproduct_MailboxTrackingFolders

See msdyn_inventoryadjustmentproduct Entity [msdyn_inventoryadjustmentproduct_MailboxTrackingFolders](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryjournal_MailboxTrackingFolders"></a> msdyn_inventoryjournal_MailboxTrackingFolders

See msdyn_inventoryjournal Entity [msdyn_inventoryjournal_MailboxTrackingFolders](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_inventorytransfer_MailboxTrackingFolders"></a> msdyn_inventorytransfer_MailboxTrackingFolders

See msdyn_inventorytransfer Entity [msdyn_inventorytransfer_MailboxTrackingFolders](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_orderinvoicingdate_MailboxTrackingFolders"></a> msdyn_orderinvoicingdate_MailboxTrackingFolders

See msdyn_orderinvoicingdate Entity [msdyn_orderinvoicingdate_MailboxTrackingFolders](msdyn_orderinvoicingdate.md#BKMK_msdyn_orderinvoicingdate_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_orderinvoicingproduct_MailboxTrackingFolders"></a> msdyn_orderinvoicingproduct_MailboxTrackingFolders

See msdyn_orderinvoicingproduct Entity [msdyn_orderinvoicingproduct_MailboxTrackingFolders](msdyn_orderinvoicingproduct.md#BKMK_msdyn_orderinvoicingproduct_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_orderinvoicingsetup_MailboxTrackingFolders"></a> msdyn_orderinvoicingsetup_MailboxTrackingFolders

See msdyn_orderinvoicingsetup Entity [msdyn_orderinvoicingsetup_MailboxTrackingFolders](msdyn_orderinvoicingsetup.md#BKMK_msdyn_orderinvoicingsetup_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_orderinvoicingsetupdate_MailboxTrackingFolders"></a> msdyn_orderinvoicingsetupdate_MailboxTrackingFolders

See msdyn_orderinvoicingsetupdate Entity [msdyn_orderinvoicingsetupdate_MailboxTrackingFolders](msdyn_orderinvoicingsetupdate.md#BKMK_msdyn_orderinvoicingsetupdate_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_payment_MailboxTrackingFolders"></a> msdyn_payment_MailboxTrackingFolders

See msdyn_payment Entity [msdyn_payment_MailboxTrackingFolders](msdyn_payment.md#BKMK_msdyn_payment_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentdetail_MailboxTrackingFolders"></a> msdyn_paymentdetail_MailboxTrackingFolders

See msdyn_paymentdetail Entity [msdyn_paymentdetail_MailboxTrackingFolders](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentmethod_MailboxTrackingFolders"></a> msdyn_paymentmethod_MailboxTrackingFolders

See msdyn_paymentmethod Entity [msdyn_paymentmethod_MailboxTrackingFolders](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentterm_MailboxTrackingFolders"></a> msdyn_paymentterm_MailboxTrackingFolders

See msdyn_paymentterm Entity [msdyn_paymentterm_MailboxTrackingFolders](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_postalcode_MailboxTrackingFolders"></a> msdyn_postalcode_MailboxTrackingFolders

See msdyn_postalcode Entity [msdyn_postalcode_MailboxTrackingFolders](msdyn_postalcode.md#BKMK_msdyn_postalcode_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_productinventory_MailboxTrackingFolders"></a> msdyn_productinventory_MailboxTrackingFolders

See msdyn_productinventory Entity [msdyn_productinventory_MailboxTrackingFolders](msdyn_productinventory.md#BKMK_msdyn_productinventory_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorder_MailboxTrackingFolders"></a> msdyn_purchaseorder_MailboxTrackingFolders

See msdyn_purchaseorder Entity [msdyn_purchaseorder_MailboxTrackingFolders](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderbill_MailboxTrackingFolders"></a> msdyn_purchaseorderbill_MailboxTrackingFolders

See msdyn_purchaseorderbill Entity [msdyn_purchaseorderbill_MailboxTrackingFolders](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderproduct_MailboxTrackingFolders"></a> msdyn_purchaseorderproduct_MailboxTrackingFolders

See msdyn_purchaseorderproduct Entity [msdyn_purchaseorderproduct_MailboxTrackingFolders](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceipt_MailboxTrackingFolders"></a> msdyn_purchaseorderreceipt_MailboxTrackingFolders

See msdyn_purchaseorderreceipt Entity [msdyn_purchaseorderreceipt_MailboxTrackingFolders](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_MailboxTrackingFolders"></a> msdyn_purchaseorderreceiptproduct_MailboxTrackingFolders

See msdyn_purchaseorderreceiptproduct Entity [msdyn_purchaseorderreceiptproduct_MailboxTrackingFolders](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseordersubstatus_MailboxTrackingFolders"></a> msdyn_purchaseordersubstatus_MailboxTrackingFolders

See msdyn_purchaseordersubstatus Entity [msdyn_purchaseordersubstatus_MailboxTrackingFolders](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingincident_MailboxTrackingFolders"></a> msdyn_quotebookingincident_MailboxTrackingFolders

See msdyn_quotebookingincident Entity [msdyn_quotebookingincident_MailboxTrackingFolders](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingproduct_MailboxTrackingFolders"></a> msdyn_quotebookingproduct_MailboxTrackingFolders

See msdyn_quotebookingproduct Entity [msdyn_quotebookingproduct_MailboxTrackingFolders](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservice_MailboxTrackingFolders"></a> msdyn_quotebookingservice_MailboxTrackingFolders

See msdyn_quotebookingservice Entity [msdyn_quotebookingservice_MailboxTrackingFolders](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservicetask_MailboxTrackingFolders"></a> msdyn_quotebookingservicetask_MailboxTrackingFolders

See msdyn_quotebookingservicetask Entity [msdyn_quotebookingservicetask_MailboxTrackingFolders](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingsetup_MailboxTrackingFolders"></a> msdyn_quotebookingsetup_MailboxTrackingFolders

See msdyn_quotebookingsetup Entity [msdyn_quotebookingsetup_MailboxTrackingFolders](msdyn_quotebookingsetup.md#BKMK_msdyn_quotebookingsetup_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_quoteinvoicingproduct_MailboxTrackingFolders"></a> msdyn_quoteinvoicingproduct_MailboxTrackingFolders

See msdyn_quoteinvoicingproduct Entity [msdyn_quoteinvoicingproduct_MailboxTrackingFolders](msdyn_quoteinvoicingproduct.md#BKMK_msdyn_quoteinvoicingproduct_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_quoteinvoicingsetup_MailboxTrackingFolders"></a> msdyn_quoteinvoicingsetup_MailboxTrackingFolders

See msdyn_quoteinvoicingsetup Entity [msdyn_quoteinvoicingsetup_MailboxTrackingFolders](msdyn_quoteinvoicingsetup.md#BKMK_msdyn_quoteinvoicingsetup_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcepaytype_MailboxTrackingFolders"></a> msdyn_resourcepaytype_MailboxTrackingFolders

See msdyn_resourcepaytype Entity [msdyn_resourcepaytype_MailboxTrackingFolders](msdyn_resourcepaytype.md#BKMK_msdyn_resourcepaytype_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_rma_MailboxTrackingFolders"></a> msdyn_rma_MailboxTrackingFolders

See msdyn_rma Entity [msdyn_rma_MailboxTrackingFolders](msdyn_rma.md#BKMK_msdyn_rma_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_rmaproduct_MailboxTrackingFolders"></a> msdyn_rmaproduct_MailboxTrackingFolders

See msdyn_rmaproduct Entity [msdyn_rmaproduct_MailboxTrackingFolders](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceipt_MailboxTrackingFolders"></a> msdyn_rmareceipt_MailboxTrackingFolders

See msdyn_rmareceipt Entity [msdyn_rmareceipt_MailboxTrackingFolders](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceiptproduct_MailboxTrackingFolders"></a> msdyn_rmareceiptproduct_MailboxTrackingFolders

See msdyn_rmareceiptproduct Entity [msdyn_rmareceiptproduct_MailboxTrackingFolders](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_rmasubstatus_MailboxTrackingFolders"></a> msdyn_rmasubstatus_MailboxTrackingFolders

See msdyn_rmasubstatus Entity [msdyn_rmasubstatus_MailboxTrackingFolders](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_rtv_MailboxTrackingFolders"></a> msdyn_rtv_MailboxTrackingFolders

See msdyn_rtv Entity [msdyn_rtv_MailboxTrackingFolders](msdyn_rtv.md#BKMK_msdyn_rtv_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvproduct_MailboxTrackingFolders"></a> msdyn_rtvproduct_MailboxTrackingFolders

See msdyn_rtvproduct Entity [msdyn_rtvproduct_MailboxTrackingFolders](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvsubstatus_MailboxTrackingFolders"></a> msdyn_rtvsubstatus_MailboxTrackingFolders

See msdyn_rtvsubstatus Entity [msdyn_rtvsubstatus_MailboxTrackingFolders](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_servicetasktype_MailboxTrackingFolders"></a> msdyn_servicetasktype_MailboxTrackingFolders

See msdyn_servicetasktype Entity [msdyn_servicetasktype_MailboxTrackingFolders](msdyn_servicetasktype.md#BKMK_msdyn_servicetasktype_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_shipvia_MailboxTrackingFolders"></a> msdyn_shipvia_MailboxTrackingFolders

See msdyn_shipvia Entity [msdyn_shipvia_MailboxTrackingFolders](msdyn_shipvia.md#BKMK_msdyn_shipvia_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_taxcode_MailboxTrackingFolders"></a> msdyn_taxcode_MailboxTrackingFolders

See msdyn_taxcode Entity [msdyn_taxcode_MailboxTrackingFolders](msdyn_taxcode.md#BKMK_msdyn_taxcode_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_taxcodedetail_MailboxTrackingFolders"></a> msdyn_taxcodedetail_MailboxTrackingFolders

See msdyn_taxcodedetail Entity [msdyn_taxcodedetail_MailboxTrackingFolders](msdyn_taxcodedetail.md#BKMK_msdyn_taxcodedetail_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_timeoffrequest_MailboxTrackingFolders"></a> msdyn_timeoffrequest_MailboxTrackingFolders

See msdyn_timeoffrequest Entity [msdyn_timeoffrequest_MailboxTrackingFolders](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_uniquenumber_MailboxTrackingFolders"></a> msdyn_uniquenumber_MailboxTrackingFolders

See msdyn_uniquenumber Entity [msdyn_uniquenumber_MailboxTrackingFolders](msdyn_uniquenumber.md#BKMK_msdyn_uniquenumber_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_warehouse_MailboxTrackingFolders"></a> msdyn_warehouse_MailboxTrackingFolders

See msdyn_warehouse Entity [msdyn_warehouse_MailboxTrackingFolders](msdyn_warehouse.md#BKMK_msdyn_warehouse_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_workorder_MailboxTrackingFolders"></a> msdyn_workorder_MailboxTrackingFolders

See msdyn_workorder Entity [msdyn_workorder_MailboxTrackingFolders](msdyn_workorder.md#BKMK_msdyn_workorder_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_workordercharacteristic_MailboxTrackingFolders"></a> msdyn_workordercharacteristic_MailboxTrackingFolders

See msdyn_workordercharacteristic Entity [msdyn_workordercharacteristic_MailboxTrackingFolders](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderdetailsgenerationqueue_MailboxTrackingFolders"></a> msdyn_workorderdetailsgenerationqueue_MailboxTrackingFolders

See msdyn_workorderdetailsgenerationqueue Entity [msdyn_workorderdetailsgenerationqueue_MailboxTrackingFolders](msdyn_workorderdetailsgenerationqueue.md#BKMK_msdyn_workorderdetailsgenerationqueue_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderincident_MailboxTrackingFolders"></a> msdyn_workorderincident_MailboxTrackingFolders

See msdyn_workorderincident Entity [msdyn_workorderincident_MailboxTrackingFolders](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderproduct_MailboxTrackingFolders"></a> msdyn_workorderproduct_MailboxTrackingFolders

See msdyn_workorderproduct Entity [msdyn_workorderproduct_MailboxTrackingFolders](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderresourcerestriction_MailboxTrackingFolders"></a> msdyn_workorderresourcerestriction_MailboxTrackingFolders

See msdyn_workorderresourcerestriction Entity [msdyn_workorderresourcerestriction_MailboxTrackingFolders](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservice_MailboxTrackingFolders"></a> msdyn_workorderservice_MailboxTrackingFolders

See msdyn_workorderservice Entity [msdyn_workorderservice_MailboxTrackingFolders](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservicetask_MailboxTrackingFolders"></a> msdyn_workorderservicetask_MailboxTrackingFolders

See msdyn_workorderservicetask Entity [msdyn_workorderservicetask_MailboxTrackingFolders](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_workordersubstatus_MailboxTrackingFolders"></a> msdyn_workordersubstatus_MailboxTrackingFolders

See msdyn_workordersubstatus Entity [msdyn_workordersubstatus_MailboxTrackingFolders](msdyn_workordersubstatus.md#BKMK_msdyn_workordersubstatus_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_msdyn_workordertype_MailboxTrackingFolders"></a> msdyn_workordertype_MailboxTrackingFolders

See msdyn_workordertype Entity [msdyn_workordertype_MailboxTrackingFolders](msdyn_workordertype.md#BKMK_msdyn_workordertype_MailboxTrackingFolders) One-To-Many relationship.

### <a name="BKMK_lk_mailboxtrackingfolder_modifiedby"></a> lk_mailboxtrackingfolder_modifiedby

See systemuser Entity [lk_mailboxtrackingfolder_modifiedby](systemuser.md#BKMK_lk_mailboxtrackingfolder_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_mailboxtrackingfolder_createdby"></a> lk_mailboxtrackingfolder_createdby

See systemuser Entity [lk_mailboxtrackingfolder_createdby](systemuser.md#BKMK_lk_mailboxtrackingfolder_createdby) One-To-Many relationship.

### <a name="BKMK_Account_MailboxTrackingFolder"></a> Account_MailboxTrackingFolder

See account Entity [Account_MailboxTrackingFolder](account.md#BKMK_Account_MailboxTrackingFolder) One-To-Many relationship.

### <a name="BKMK_team_mailboxtrackingfolder"></a> team_mailboxtrackingfolder

See team Entity [team_mailboxtrackingfolder](team.md#BKMK_team_mailboxtrackingfolder) One-To-Many relationship.

### <a name="BKMK_Contact_MailboxTrackingFolder"></a> Contact_MailboxTrackingFolder

See contact Entity [Contact_MailboxTrackingFolder](contact.md#BKMK_Contact_MailboxTrackingFolder) One-To-Many relationship.

### <a name="BKMK_lk_mailboxtrackingfolder_createdonbehalfby"></a> lk_mailboxtrackingfolder_createdonbehalfby

See systemuser Entity [lk_mailboxtrackingfolder_createdonbehalfby](systemuser.md#BKMK_lk_mailboxtrackingfolder_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_lk_mailboxtrackingfolder_modifiedonbehalfby"></a> lk_mailboxtrackingfolder_modifiedonbehalfby

See systemuser Entity [lk_mailboxtrackingfolder_modifiedonbehalfby](systemuser.md#BKMK_lk_mailboxtrackingfolder_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_Organization_MailboxTrackingFolder"></a> Organization_MailboxTrackingFolder

See organization Entity [Organization_MailboxTrackingFolder](organization.md#BKMK_Organization_MailboxTrackingFolder) One-To-Many relationship.

### <a name="BKMK_Mailbox_MailboxTrackingFolder"></a> Mailbox_MailboxTrackingFolder

See mailbox Entity [Mailbox_MailboxTrackingFolder](mailbox.md#BKMK_Mailbox_MailboxTrackingFolder) One-To-Many relationship.

### <a name="BKMK_businessunit_mailboxtrackingfolder"></a> businessunit_mailboxtrackingfolder

See businessunit Entity [businessunit_mailboxtrackingfolder](businessunit.md#BKMK_businessunit_mailboxtrackingfolder) One-To-Many relationship.

### <a name="BKMK_AsyncOperation_MailboxTrackingFolder"></a> AsyncOperation_MailboxTrackingFolder

See asyncoperation Entity [AsyncOperation_MailboxTrackingFolder](asyncoperation.md#BKMK_AsyncOperation_MailboxTrackingFolder) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.mailboxtrackingfolder?text=mailboxtrackingfolder EntityType" />