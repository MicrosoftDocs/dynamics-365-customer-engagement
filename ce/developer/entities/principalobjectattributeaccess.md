---
title: "PrincipalObjectAttributeAccess Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the PrincipalObjectAttributeAccess entity."
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
# PrincipalObjectAttributeAccess Entity Reference

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Defines CRM security principals (users and teams) access rights to secured field for an entity instance.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Create|POST [*org URI*]/api/data/v9.0/principalobjectattributeaccessset<br />See [Create](../webapi/create-entity-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|DELETE [*org URI*]/api/data/v9.0/principalobjectattributeaccessset(*principalobjectattributeaccessid*)<br />See [Delete](../webapi/update-delete-entities-using-web-api.md#basic-delete)|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|GET [*org URI*]/api/data/v9.0/principalobjectattributeaccessset(*principalobjectattributeaccessid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/principalobjectattributeaccessset<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|Update|PATCH [*org URI*]/api/data/v9.0/principalobjectattributeaccessset(*principalobjectattributeaccessid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

**DisplayName**: Field Sharing<br />
**DisplayCollectionName**: Field Sharing<br />
**SchemaName**: PrincipalObjectAttributeAccess<br />
**CollectionSchemaName**: PrincipalObjectAttributeAccesses<br />
**LogicalName**: principalobjectattributeaccess<br />
**LogicalCollectionName**: principalobjectattributeaccesses<br />
**EntitySetName**: principalobjectattributeaccessset<br />
**PrimaryIdAttribute**: principalobjectattributeaccessid<br />
**PrimaryNameAttribute**: <br />
**OwnershipType**: OrganizationOwned<br />
**IsBPFEntity**: False<br />
<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [AttributeId](#BKMK_AttributeId)
- [ObjectId](#BKMK_ObjectId)
- [ObjectTypeCode](#BKMK_ObjectTypeCode)
- [PrincipalId](#BKMK_PrincipalId)
- [PrincipalIdType](#BKMK_PrincipalIdType)
- [PrincipalObjectAttributeAccessId](#BKMK_PrincipalObjectAttributeAccessId)
- [ReadAccess](#BKMK_ReadAccess)
- [UpdateAccess](#BKMK_UpdateAccess)


### <a name="BKMK_AttributeId"></a> AttributeId

**Description**: Unique identifier of the shared secured field<br />
**DisplayName**: Secured field<br />
**LogicalName**: attributeid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_ObjectId"></a> ObjectId

**Description**: Unique identifier of the entity instance with shared secured field<br />
**DisplayName**: Entity instance<br />
**LogicalName**: objectid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Lookup<br />
**Targets**: account,accountleads,appointment,bookableresource,bookableresourcebooking,bookableresourcebookingexchangesyncidmapping,bookableresourcebookingheader,bookableresourcecategory,bookableresourcecategoryassn,bookableresourcecharacteristic,bookableresourcegroup,bookingstatus,bulkoperation,bulkoperationlog,businessunit,campaign,campaignactivity,campaignactivityitem,campaignitem,campaignresponse,channelaccessprofile,characteristic,childincidentcount,commitment,competitor,competitoraddress,competitorproduct,competitorsalesliterature,connection,constraintbasedgroup,contact,contactinvoices,contactleads,contactorders,contactquotes,contract,contractdetail,contracttemplate,customeraddress,customeropportunityrole,discount,discounttype,dynamicproperty,dynamicpropertyassociation,dynamicpropertyinstance,dynamicpropertyoptionsetitem,email,entitlement,entitlementchannel,entitlementcontacts,entitlementproducts,entitlementtemplate,entitlementtemplatechannel,entitlementtemplateproducts,equipment,fax,feedback,goal,incident,incidentknowledgebaserecord,incidentresolution,invoice,invoicedetail,kbarticle,knowledgearticle,knowledgearticleincident,knowledgearticleviews,knowledgebaserecord,lead,leadaddress,leadcompetitors,leadproduct,leadtoopportunitysalesprocess,letter,list,listmember,mailmergetemplate,msdyn_accountpricelist,msdyn_actual,msdyn_agreement,msdyn_agreementbookingdate,msdyn_agreementbookingincident,msdyn_agreementbookingproduct,msdyn_agreementbookingservice,msdyn_agreementbookingservicetask,msdyn_agreementbookingsetup,msdyn_agreementinvoicedate,msdyn_agreementinvoiceproduct,msdyn_agreementinvoicesetup,msdyn_agreementsubstatus,msdyn_approval,msdyn_batchjob,msdyn_bookingalert,msdyn_bookingalertstatus,msdyn_bookingchange,msdyn_bookingjournal,msdyn_bookingrule,msdyn_bookingsetupmetadata,msdyn_bookingtimestamp,msdyn_bpf_2c5fe86acc8b414b8322ae571000c799,msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b,msdyn_bpf_665e73aa18c247d886bfc50499c73b82,msdyn_bpf_989e9b1857e24af18787d5143b67523b,msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3,msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39,msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d,msdyn_characteristicreqforteammember,msdyn_clientextension,msdyn_configuration,msdyn_contactpricelist,msdyn_contractlineinvoiceschedule,msdyn_contractlinescheduleofvalue,msdyn_customerasset,msdyn_dataexport,msdyn_delegation,msdyn_estimate,msdyn_estimateline,msdyn_expense,msdyn_expensecategory,msdyn_expensereceipt,msdyn_fact,msdyn_fieldcomputation,msdyn_fieldservicepricelistitem,msdyn_fieldservicesetting,msdyn_fieldservicesystemjob,msdyn_findworkevent,msdyn_incidenttype,msdyn_incidenttypecharacteristic,msdyn_incidenttypeproduct,msdyn_incidenttypeservice,msdyn_incidenttypeservicetask,msdyn_integrationjob,msdyn_integrationjobdetail,msdyn_inventoryadjustment,msdyn_inventoryadjustmentproduct,msdyn_inventoryjournal,msdyn_inventorytransfer,msdyn_invoicefrequency,msdyn_invoicefrequencydetail,msdyn_invoicelinetransaction,msdyn_iotalert,msdyn_iotdevice,msdyn_iotdevicecategory,msdyn_iotdevicecommand,msdyn_iotdeviceregistrationhistory,msdyn_journal,msdyn_journalline,msdyn_mlresultcache,msdyn_opportunitylineresourcecategory,msdyn_opportunitylinetransaction,msdyn_opportunitylinetransactioncategory,msdyn_opportunitylinetransactionclassificatio,msdyn_opportunitypricelist,msdyn_orderinvoicingdate,msdyn_orderinvoicingproduct,msdyn_orderinvoicingsetup,msdyn_orderinvoicingsetupdate,msdyn_orderlineresourcecategory,msdyn_orderlinetransaction,msdyn_orderlinetransactioncategory,msdyn_orderlinetransactionclassification,msdyn_orderpricelist,msdyn_organizationalunit,msdyn_payment,msdyn_paymentdetail,msdyn_paymentmethod,msdyn_paymentterm,msdyn_postalbum,msdyn_postalcode,msdyn_postconfig,msdyn_postruleconfig,msdyn_priority,msdyn_processnotes,msdyn_productinventory,msdyn_project,msdyn_projectapproval,msdyn_projectparameter,msdyn_projectparameterpricelist,msdyn_projectpricelist,msdyn_projecttask,msdyn_projecttaskdependency,msdyn_projecttaskstatususer,msdyn_projectteam,msdyn_projectteammembersignup,msdyn_projecttransactioncategory,msdyn_purchaseorder,msdyn_purchaseorderbill,msdyn_purchaseorderproduct,msdyn_purchaseorderreceipt,msdyn_purchaseorderreceiptproduct,msdyn_purchaseordersubstatus,msdyn_quotebookingincident,msdyn_quotebookingproduct,msdyn_quotebookingservice,msdyn_quotebookingservicetask,msdyn_quotebookingsetup,msdyn_quoteinvoicingproduct,msdyn_quoteinvoicingsetup,msdyn_quotelineanalyticsbreakdown,msdyn_quotelineinvoiceschedule,msdyn_quotelineresourcecategory,msdyn_quotelinescheduleofvalue,msdyn_quotelinetransaction,msdyn_quotelinetransactioncategory,msdyn_quotelinetransactionclassification,msdyn_quotepricelist,msdyn_requirementcharacteristic,msdyn_requirementorganizationunit,msdyn_requirementresourcecategory,msdyn_requirementresourcepreference,msdyn_requirementstatus,msdyn_resourceassignment,msdyn_resourceassignmentdetail,msdyn_resourcecategorypricelevel,msdyn_resourcepaytype,msdyn_resourcerequest,msdyn_resourcerequirement,msdyn_resourcerequirementdetail,msdyn_resourceterritory,msdyn_rma,msdyn_rmaproduct,msdyn_rmareceipt,msdyn_rmareceiptproduct,msdyn_rmasubstatus,msdyn_rolecompetencyrequirement,msdyn_roleutilization,msdyn_rtv,msdyn_rtvproduct,msdyn_rtvsubstatus,msdyn_scheduleboardsetting,msdyn_schedulingparameter,msdyn_servicetasktype,msdyn_shipvia,msdyn_systemuserschedulersetting,msdyn_taxcode,msdyn_taxcodedetail,msdyn_timeentry,msdyn_timegroup,msdyn_timegroupdetail,msdyn_timeoffcalendar,msdyn_timeoffrequest,msdyn_transactioncategory,msdyn_transactioncategoryclassification,msdyn_transactioncategoryhierarchyelement,msdyn_transactioncategorypricelevel,msdyn_transactionconnection,msdyn_transactionorigin,msdyn_transactiontype,msdyn_uniquenumber,msdyn_userworkhistory,msdyn_wallsavedquery,msdyn_wallsavedqueryusersettings,msdyn_warehouse,msdyn_workhourtemplate,msdyn_workorder,msdyn_workordercharacteristic,msdyn_workorderdetailsgenerationqueue,msdyn_workorderincident,msdyn_workorderproduct,msdyn_workorderresourcerestriction,msdyn_workorderservice,msdyn_workorderservicetask,msdyn_workordersubstatus,msdyn_workordertype,opportunity,opportunityclose,opportunitycompetitors,opportunityproduct,opportunitysalesprocess,orderclose,phonecall,phonetocaseprocess,position,pricelevel,product,productassociation,productpricelevel,productsalesliterature,productsubstitute,queue,queueitem,quote,quoteclose,quotedetail,ratingmodel,ratingvalue,recurringappointmentmaster,reportcategory,resource,resourcegroup,resourcegroupexpansion,resourcespec,salesliterature,salesliteratureitem,salesorder,salesorderdetail,salesprocessinstance,service,serviceappointment,servicecontractcontacts,sharepointdocumentlocation,sharepointsite,site,socialactivity,socialprofile,systemuser,task,team,territory,topic,topichistory,topicmodel,topicmodelconfiguration,topicmodelexecutionhistory,uom,uomschedule


### <a name="BKMK_ObjectTypeCode"></a> ObjectTypeCode

**Description**: Type of the record with shared secured field<br />
**DisplayName**: Entity object type<br />
**LogicalName**: objecttypecode<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: EntityName<br />


### <a name="BKMK_PrincipalId"></a> PrincipalId

**Description**: Unique identifier of the principal to which secured field is shared<br />
**DisplayName**: Principal<br />
**LogicalName**: principalid<br />
**IsValidForForm**: True<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Lookup<br />
**Targets**: systemuser,team


### <a name="BKMK_PrincipalIdType"></a> PrincipalIdType

**Description**: Type of the principal to which secured field is shared<br />
**DisplayName**: Principal type<br />
**LogicalName**: principalidtype<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: EntityName<br />


### <a name="BKMK_PrincipalObjectAttributeAccessId"></a> PrincipalObjectAttributeAccessId

**Description**: Unique identifier of the shared secured field instance<br />
**DisplayName**: Shared secured field<br />
**LogicalName**: principalobjectattributeaccessid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**IsValidForUpdate**: False<br />
**Type**: Uniqueidentifier<br />


### <a name="BKMK_ReadAccess"></a> ReadAccess

**Description**: Read permission for secured field instance<br />
**DisplayName**: Read permission<br />
**LogicalName**: readaccess<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False


### <a name="BKMK_UpdateAccess"></a> UpdateAccess

**Description**: Update permission for secured field instance<br />
**DisplayName**: Update permission<br />
**LogicalName**: updateaccess<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Boolean<br />
**Options**:

- **TrueOption Value**: 1 **Label**: Yes
- **FalseOption Value**: 0 **Label**: No

**DefaultValue**: False

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [OrganizationId](#BKMK_OrganizationId)
- [OrganizationIdName](#BKMK_OrganizationIdName)
- [PrincipalIdName](#BKMK_PrincipalIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_OrganizationId"></a> OrganizationId

**Description**: Unique identifier of the associated organization.<br />
**DisplayName**: Organization<br />
**LogicalName**: organizationid<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: Lookup<br />
**Targets**: organization


### <a name="BKMK_OrganizationIdName"></a> OrganizationIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: organizationidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_PrincipalIdName"></a> PrincipalIdName

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: principalidname<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: SystemRequired<br />
**Type**: String<br />
**FormatName**: Text<br />
**IsLocalizable**: False<br />
**MaxLength**: 160


### <a name="BKMK_VersionNumber"></a> VersionNumber

**Description**: <br />
**DisplayName**: <br />
**LogicalName**: versionnumber<br />
**IsValidForForm**: False<br />
**IsValidForRead**: True<br />
**RequiredLevel**: None<br />
**Type**: BigInt<br />
**MaxValue**: 9223372036854775807<br />
**MinValue**: -9223372036854775808<br />

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.


### <a name="BKMK_userentityinstancedata_principalobjectattributeaccess"></a> userentityinstancedata_principalobjectattributeaccess

Same as userentityinstancedata entity [userentityinstancedata_principalobjectattributeaccess](userentityinstancedata.md#BKMK_userentityinstancedata_principalobjectattributeaccess) Many-To-One relationship.

**ReferencingEntity**: userentityinstancedata<br />
**ReferencingAttribute**: objectid<br />
**IsHierarchical**: False<br />
**IsCustomizable**: False<br />
**ReferencedEntityNavigationPropertyName**: userentityinstancedata_principalobjectattributeaccess<br />
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

- [msdyn_iotalert_PrincipalObjectAttributeAccesses](#BKMK_msdyn_iotalert_PrincipalObjectAttributeAccesses)
- [msdyn_iotdevice_PrincipalObjectAttributeAccesses](#BKMK_msdyn_iotdevice_PrincipalObjectAttributeAccesses)
- [msdyn_iotdevicecategory_PrincipalObjectAttributeAccesses](#BKMK_msdyn_iotdevicecategory_PrincipalObjectAttributeAccesses)
- [msdyn_iotdevicecommand_PrincipalObjectAttributeAccesses](#BKMK_msdyn_iotdevicecommand_PrincipalObjectAttributeAccesses)
- [msdyn_iotdeviceregistrationhistory_PrincipalObjectAttributeAccesses](#BKMK_msdyn_iotdeviceregistrationhistory_PrincipalObjectAttributeAccesses)
- [msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_PrincipalObjectAttributeAccesses](#BKMK_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_PrincipalObjectAttributeAccesses)
- [territory_principalobjectattributeaccess](#BKMK_territory_principalobjectattributeaccess)
- [accountleads_PrincipalObjectAttributeAccesses](#BKMK_accountleads_PrincipalObjectAttributeAccesses)
- [contactleads_PrincipalObjectAttributeAccesses](#BKMK_contactleads_PrincipalObjectAttributeAccesses)
- [leadaddress_PrincipalObjectAttributeAccesses](#BKMK_leadaddress_PrincipalObjectAttributeAccesses)
- [lead_principalobjectattributeaccess](#BKMK_lead_principalobjectattributeaccess)
- [dynamicproperty_PrincipalObjectAttributeAccesses](#BKMK_dynamicproperty_PrincipalObjectAttributeAccesses)
- [dynamicpropertyassociation_PrincipalObjectAttributeAccesses](#BKMK_dynamicpropertyassociation_PrincipalObjectAttributeAccesses)
- [dynamicpropertyinstance_PrincipalObjectAttributeAccesses](#BKMK_dynamicpropertyinstance_PrincipalObjectAttributeAccesses)
- [dynamicpropertyoptionsetitem_PrincipalObjectAttributeAccesses](#BKMK_dynamicpropertyoptionsetitem_PrincipalObjectAttributeAccesses)
- [pricelevel_principalobjectattributeaccess](#BKMK_pricelevel_principalobjectattributeaccess)
- [product_principalobjectattributeaccess](#BKMK_product_principalobjectattributeaccess)
- [ProductAssociation_PrincipalObjectAttributeAccess](#BKMK_ProductAssociation_PrincipalObjectAttributeAccess)
- [productpricelevel_PrincipalObjectAttributeAccesses](#BKMK_productpricelevel_PrincipalObjectAttributeAccesses)
- [ProductSubstitute_PrincipalObjectAttributeAccess](#BKMK_ProductSubstitute_PrincipalObjectAttributeAccess)
- [uom_PrincipalObjectAttributeAccesses](#BKMK_uom_PrincipalObjectAttributeAccesses)
- [uomschedule_PrincipalObjectAttributeAccesses](#BKMK_uomschedule_PrincipalObjectAttributeAccesses)
- [bookableresource_PrincipalObjectAttributeAccess](#BKMK_bookableresource_PrincipalObjectAttributeAccess)
- [bookableresourcebooking_PrincipalObjectAttributeAccess](#BKMK_bookableresourcebooking_PrincipalObjectAttributeAccess)
- [bookableresourcebookingexchangesyncidmapping_PrincipalObjectAttributeAccesses](#BKMK_bookableresourcebookingexchangesyncidmapping_PrincipalObjectAttributeAccesses)
- [bookableresourcebookingheader_PrincipalObjectAttributeAccess](#BKMK_bookableresourcebookingheader_PrincipalObjectAttributeAccess)
- [bookableresourcecategory_PrincipalObjectAttributeAccess](#BKMK_bookableresourcecategory_PrincipalObjectAttributeAccess)
- [bookableresourcecategoryassn_PrincipalObjectAttributeAccess](#BKMK_bookableresourcecategoryassn_PrincipalObjectAttributeAccess)
- [bookableresourcecharacteristic_PrincipalObjectAttributeAccess](#BKMK_bookableresourcecharacteristic_PrincipalObjectAttributeAccess)
- [bookableresourcegroup_PrincipalObjectAttributeAccess](#BKMK_bookableresourcegroup_PrincipalObjectAttributeAccess)
- [bookingstatus_PrincipalObjectAttributeAccess](#BKMK_bookingstatus_PrincipalObjectAttributeAccess)
- [characteristic_PrincipalObjectAttributeAccess](#BKMK_characteristic_PrincipalObjectAttributeAccess)
- [ratingmodel_PrincipalObjectAttributeAccess](#BKMK_ratingmodel_PrincipalObjectAttributeAccess)
- [ratingvalue_PrincipalObjectAttributeAccess](#BKMK_ratingvalue_PrincipalObjectAttributeAccess)
- [bulkoperation_PrincipalObjectAttributeAccesses](#BKMK_bulkoperation_PrincipalObjectAttributeAccesses)
- [bulkoperationlog_PrincipalObjectAttributeAccesses](#BKMK_bulkoperationlog_PrincipalObjectAttributeAccesses)
- [campaign_principalobjectattributeaccess](#BKMK_campaign_principalobjectattributeaccess)
- [campaignactivity_principalobjectattributeaccess](#BKMK_campaignactivity_principalobjectattributeaccess)
- [campaignactivityitem_PrincipalObjectAttributeAccesses](#BKMK_campaignactivityitem_PrincipalObjectAttributeAccesses)
- [campaignitem_PrincipalObjectAttributeAccesses](#BKMK_campaignitem_PrincipalObjectAttributeAccesses)
- [campaignresponse_principalobjectattributeaccess](#BKMK_campaignresponse_principalobjectattributeaccess)
- [list_principalobjectattributeaccess](#BKMK_list_principalobjectattributeaccess)
- [listmember_PrincipalObjectAttributeAccesses](#BKMK_listmember_PrincipalObjectAttributeAccesses)
- [commitment_PrincipalObjectAttributeAccesses](#BKMK_commitment_PrincipalObjectAttributeAccesses)
- [constraintbasedgroup_PrincipalObjectAttributeAccesses](#BKMK_constraintbasedgroup_PrincipalObjectAttributeAccesses)
- [contract_principalobjectattributeaccess](#BKMK_contract_principalobjectattributeaccess)
- [contractdetail_principalobjectattributeaccess](#BKMK_contractdetail_principalobjectattributeaccess)
- [contracttemplate_PrincipalObjectAttributeAccesses](#BKMK_contracttemplate_PrincipalObjectAttributeAccesses)
- [entitlement_PrincipalObjectAttributeAccesses](#BKMK_entitlement_PrincipalObjectAttributeAccesses)
- [entitlementchannel_PrincipalObjectAttributeAccesses](#BKMK_entitlementchannel_PrincipalObjectAttributeAccesses)
- [entitlementcontacts_PrincipalObjectAttributeAccesses](#BKMK_entitlementcontacts_PrincipalObjectAttributeAccesses)
- [entitlementproducts_PrincipalObjectAttributeAccesses](#BKMK_entitlementproducts_PrincipalObjectAttributeAccesses)
- [entitlementtemplate_PrincipalObjectAttributeAccesses](#BKMK_entitlementtemplate_PrincipalObjectAttributeAccesses)
- [entitlementtemplatechannel_PrincipalObjectAttributeAccesses](#BKMK_entitlementtemplatechannel_PrincipalObjectAttributeAccesses)
- [entitlementtemplateproducts_PrincipalObjectAttributeAccesses](#BKMK_entitlementtemplateproducts_PrincipalObjectAttributeAccesses)
- [equipment_principalobjectattributeaccess](#BKMK_equipment_principalobjectattributeaccess)
- [incident_principalobjectattributeaccess](#BKMK_incident_principalobjectattributeaccess)
- [incidentknowledgebaserecord_PrincipalObjectAttributeAccesses](#BKMK_incidentknowledgebaserecord_PrincipalObjectAttributeAccesses)
- [incidentresolution_PrincipalObjectAttributeAccesses](#BKMK_incidentresolution_PrincipalObjectAttributeAccesses)
- [knowledgearticleincident_principalobjectattributeaccess](#BKMK_knowledgearticleincident_principalobjectattributeaccess)
- [phonetocaseprocess_PrincipalObjectAttributeAccesses](#BKMK_phonetocaseprocess_PrincipalObjectAttributeAccesses)
- [resource_PrincipalObjectAttributeAccesses](#BKMK_resource_PrincipalObjectAttributeAccesses)
- [resourcegroup_PrincipalObjectAttributeAccesses](#BKMK_resourcegroup_PrincipalObjectAttributeAccesses)
- [resourcespec_PrincipalObjectAttributeAccesses](#BKMK_resourcespec_PrincipalObjectAttributeAccesses)
- [service_PrincipalObjectAttributeAccesses](#BKMK_service_PrincipalObjectAttributeAccesses)
- [serviceappointment_principalobjectattributeaccess](#BKMK_serviceappointment_principalobjectattributeaccess)
- [servicecontractcontacts_PrincipalObjectAttributeAccesses](#BKMK_servicecontractcontacts_PrincipalObjectAttributeAccesses)
- [topic_PrincipalObjectAttributeAccesses](#BKMK_topic_PrincipalObjectAttributeAccesses)
- [topichistory_PrincipalObjectAttributeAccesses](#BKMK_topichistory_PrincipalObjectAttributeAccesses)
- [topicmodel_PrincipalObjectAttributeAccesses](#BKMK_topicmodel_PrincipalObjectAttributeAccesses)
- [topicmodelconfiguration_PrincipalObjectAttributeAccesses](#BKMK_topicmodelconfiguration_PrincipalObjectAttributeAccesses)
- [topicmodelexecutionhistory_PrincipalObjectAttributeAccesses](#BKMK_topicmodelexecutionhistory_PrincipalObjectAttributeAccesses)
- [site_PrincipalObjectAttributeAccesses](#BKMK_site_PrincipalObjectAttributeAccesses)
- [competitorproduct_PrincipalObjectAttributeAccesses](#BKMK_competitorproduct_PrincipalObjectAttributeAccesses)
- [competitorsalesliterature_PrincipalObjectAttributeAccesses](#BKMK_competitorsalesliterature_PrincipalObjectAttributeAccesses)
- [contactinvoices_PrincipalObjectAttributeAccesses](#BKMK_contactinvoices_PrincipalObjectAttributeAccesses)
- [contactorders_PrincipalObjectAttributeAccesses](#BKMK_contactorders_PrincipalObjectAttributeAccesses)
- [contactquotes_PrincipalObjectAttributeAccesses](#BKMK_contactquotes_PrincipalObjectAttributeAccesses)
- [customeropportunityrole_PrincipalObjectAttributeAccesses](#BKMK_customeropportunityrole_PrincipalObjectAttributeAccesses)
- [discount_PrincipalObjectAttributeAccesses](#BKMK_discount_PrincipalObjectAttributeAccesses)
- [discounttype_PrincipalObjectAttributeAccesses](#BKMK_discounttype_PrincipalObjectAttributeAccesses)
- [invoice_principalobjectattributeaccess](#BKMK_invoice_principalobjectattributeaccess)
- [invoicedetail_principalobjectattributeaccess](#BKMK_invoicedetail_principalobjectattributeaccess)
- [leadcompetitors_PrincipalObjectAttributeAccesses](#BKMK_leadcompetitors_PrincipalObjectAttributeAccesses)
- [leadproduct_PrincipalObjectAttributeAccesses](#BKMK_leadproduct_PrincipalObjectAttributeAccesses)
- [leadtoopportunitysalesprocess_PrincipalObjectAttributeAccesses](#BKMK_leadtoopportunitysalesprocess_PrincipalObjectAttributeAccesses)
- [opportunity_principalobjectattributeaccess](#BKMK_opportunity_principalobjectattributeaccess)
- [opportunityclose_PrincipalObjectAttributeAccesses](#BKMK_opportunityclose_PrincipalObjectAttributeAccesses)
- [opportunitycompetitors_PrincipalObjectAttributeAccesses](#BKMK_opportunitycompetitors_PrincipalObjectAttributeAccesses)
- [opportunityproduct_principalobjectattributeaccess](#BKMK_opportunityproduct_principalobjectattributeaccess)
- [opportunitysalesprocess_PrincipalObjectAttributeAccesses](#BKMK_opportunitysalesprocess_PrincipalObjectAttributeAccesses)
- [orderclose_PrincipalObjectAttributeAccesses](#BKMK_orderclose_PrincipalObjectAttributeAccesses)
- [productsalesliterature_PrincipalObjectAttributeAccesses](#BKMK_productsalesliterature_PrincipalObjectAttributeAccesses)
- [quote_principalobjectattributeaccess](#BKMK_quote_principalobjectattributeaccess)
- [quoteclose_PrincipalObjectAttributeAccesses](#BKMK_quoteclose_PrincipalObjectAttributeAccesses)
- [quotedetail_principalobjectattributeaccess](#BKMK_quotedetail_principalobjectattributeaccess)
- [salesliterature_principalobjectattributeaccess](#BKMK_salesliterature_principalobjectattributeaccess)
- [salesliteratureitem_PrincipalObjectAttributeAccesses](#BKMK_salesliteratureitem_PrincipalObjectAttributeAccesses)
- [salesorder_principalobjectattributeaccess](#BKMK_salesorder_principalobjectattributeaccess)
- [salesorderdetail_principalobjectattributeaccess](#BKMK_salesorderdetail_principalobjectattributeaccess)
- [competitor_principalobjectattributeaccess](#BKMK_competitor_principalobjectattributeaccess)
- [msdyn_postalbum_PrincipalObjectAttributeAccesses](#BKMK_msdyn_postalbum_PrincipalObjectAttributeAccesses)
- [msdyn_postconfig_PrincipalObjectAttributeAccesses](#BKMK_msdyn_postconfig_PrincipalObjectAttributeAccesses)
- [msdyn_postruleconfig_PrincipalObjectAttributeAccesses](#BKMK_msdyn_postruleconfig_PrincipalObjectAttributeAccesses)
- [msdyn_wallsavedquery_PrincipalObjectAttributeAccesses](#BKMK_msdyn_wallsavedquery_PrincipalObjectAttributeAccesses)
- [msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses](#BKMK_msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses)
- [msdyn_actual_PrincipalObjectAttributeAccesses](#BKMK_msdyn_actual_PrincipalObjectAttributeAccesses)
- [msdyn_bookingalert_PrincipalObjectAttributeAccesses](#BKMK_msdyn_bookingalert_PrincipalObjectAttributeAccesses)
- [msdyn_bookingalertstatus_PrincipalObjectAttributeAccesses](#BKMK_msdyn_bookingalertstatus_PrincipalObjectAttributeAccesses)
- [msdyn_bookingchange_PrincipalObjectAttributeAccesses](#BKMK_msdyn_bookingchange_PrincipalObjectAttributeAccesses)
- [msdyn_bookingrule_PrincipalObjectAttributeAccesses](#BKMK_msdyn_bookingrule_PrincipalObjectAttributeAccesses)
- [msdyn_bookingsetupmetadata_PrincipalObjectAttributeAccesses](#BKMK_msdyn_bookingsetupmetadata_PrincipalObjectAttributeAccesses)
- [msdyn_clientextension_PrincipalObjectAttributeAccesses](#BKMK_msdyn_clientextension_PrincipalObjectAttributeAccesses)
- [msdyn_configuration_PrincipalObjectAttributeAccesses](#BKMK_msdyn_configuration_PrincipalObjectAttributeAccesses)
- [msdyn_organizationalunit_PrincipalObjectAttributeAccesses](#BKMK_msdyn_organizationalunit_PrincipalObjectAttributeAccesses)
- [msdyn_priority_PrincipalObjectAttributeAccesses](#BKMK_msdyn_priority_PrincipalObjectAttributeAccesses)
- [msdyn_requirementcharacteristic_PrincipalObjectAttributeAccesses](#BKMK_msdyn_requirementcharacteristic_PrincipalObjectAttributeAccesses)
- [msdyn_requirementorganizationunit_PrincipalObjectAttributeAccesses](#BKMK_msdyn_requirementorganizationunit_PrincipalObjectAttributeAccesses)
- [msdyn_requirementresourcecategory_PrincipalObjectAttributeAccesses](#BKMK_msdyn_requirementresourcecategory_PrincipalObjectAttributeAccesses)
- [msdyn_requirementresourcepreference_PrincipalObjectAttributeAccesses](#BKMK_msdyn_requirementresourcepreference_PrincipalObjectAttributeAccesses)
- [msdyn_requirementstatus_PrincipalObjectAttributeAccesses](#BKMK_msdyn_requirementstatus_PrincipalObjectAttributeAccesses)
- [msdyn_resourcerequirement_PrincipalObjectAttributeAccesses](#BKMK_msdyn_resourcerequirement_PrincipalObjectAttributeAccesses)
- [msdyn_resourcerequirementdetail_PrincipalObjectAttributeAccesses](#BKMK_msdyn_resourcerequirementdetail_PrincipalObjectAttributeAccesses)
- [msdyn_resourceterritory_PrincipalObjectAttributeAccesses](#BKMK_msdyn_resourceterritory_PrincipalObjectAttributeAccesses)
- [msdyn_scheduleboardsetting_PrincipalObjectAttributeAccesses](#BKMK_msdyn_scheduleboardsetting_PrincipalObjectAttributeAccesses)
- [msdyn_schedulingparameter_PrincipalObjectAttributeAccesses](#BKMK_msdyn_schedulingparameter_PrincipalObjectAttributeAccesses)
- [msdyn_systemuserschedulersetting_PrincipalObjectAttributeAccesses](#BKMK_msdyn_systemuserschedulersetting_PrincipalObjectAttributeAccesses)
- [msdyn_timegroup_PrincipalObjectAttributeAccesses](#BKMK_msdyn_timegroup_PrincipalObjectAttributeAccesses)
- [msdyn_timegroupdetail_PrincipalObjectAttributeAccesses](#BKMK_msdyn_timegroupdetail_PrincipalObjectAttributeAccesses)
- [msdyn_transactionorigin_PrincipalObjectAttributeAccesses](#BKMK_msdyn_transactionorigin_PrincipalObjectAttributeAccesses)
- [msdyn_workhourtemplate_PrincipalObjectAttributeAccesses](#BKMK_msdyn_workhourtemplate_PrincipalObjectAttributeAccesses)
- [msdyn_accountpricelist_PrincipalObjectAttributeAccesses](#BKMK_msdyn_accountpricelist_PrincipalObjectAttributeAccesses)
- [msdyn_approval_PrincipalObjectAttributeAccesses](#BKMK_msdyn_approval_PrincipalObjectAttributeAccesses)
- [msdyn_batchjob_PrincipalObjectAttributeAccesses](#BKMK_msdyn_batchjob_PrincipalObjectAttributeAccesses)
- [msdyn_bpf_665e73aa18c247d886bfc50499c73b82_PrincipalObjectAttributeAccesses](#BKMK_msdyn_bpf_665e73aa18c247d886bfc50499c73b82_PrincipalObjectAttributeAccesses)
- [msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_PrincipalObjectAttributeAccesses](#BKMK_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_PrincipalObjectAttributeAccesses)
- [msdyn_characteristicreqforteammember_PrincipalObjectAttributeAccesses](#BKMK_msdyn_characteristicreqforteammember_PrincipalObjectAttributeAccesses)
- [msdyn_contactpricelist_PrincipalObjectAttributeAccesses](#BKMK_msdyn_contactpricelist_PrincipalObjectAttributeAccesses)
- [msdyn_contractlineinvoiceschedule_PrincipalObjectAttributeAccesses](#BKMK_msdyn_contractlineinvoiceschedule_PrincipalObjectAttributeAccesses)
- [msdyn_contractlinescheduleofvalue_PrincipalObjectAttributeAccesses](#BKMK_msdyn_contractlinescheduleofvalue_PrincipalObjectAttributeAccesses)
- [msdyn_dataexport_PrincipalObjectAttributeAccesses](#BKMK_msdyn_dataexport_PrincipalObjectAttributeAccesses)
- [msdyn_delegation_PrincipalObjectAttributeAccesses](#BKMK_msdyn_delegation_PrincipalObjectAttributeAccesses)
- [msdyn_estimate_PrincipalObjectAttributeAccesses](#BKMK_msdyn_estimate_PrincipalObjectAttributeAccesses)
- [msdyn_estimateline_PrincipalObjectAttributeAccesses](#BKMK_msdyn_estimateline_PrincipalObjectAttributeAccesses)
- [msdyn_expense_PrincipalObjectAttributeAccesses](#BKMK_msdyn_expense_PrincipalObjectAttributeAccesses)
- [msdyn_expensecategory_PrincipalObjectAttributeAccesses](#BKMK_msdyn_expensecategory_PrincipalObjectAttributeAccesses)
- [msdyn_expensereceipt_PrincipalObjectAttributeAccesses](#BKMK_msdyn_expensereceipt_PrincipalObjectAttributeAccesses)
- [msdyn_fact_PrincipalObjectAttributeAccesses](#BKMK_msdyn_fact_PrincipalObjectAttributeAccesses)
- [msdyn_fieldcomputation_PrincipalObjectAttributeAccesses](#BKMK_msdyn_fieldcomputation_PrincipalObjectAttributeAccesses)
- [msdyn_findworkevent_PrincipalObjectAttributeAccesses](#BKMK_msdyn_findworkevent_PrincipalObjectAttributeAccesses)
- [msdyn_integrationjob_PrincipalObjectAttributeAccesses](#BKMK_msdyn_integrationjob_PrincipalObjectAttributeAccesses)
- [msdyn_integrationjobdetail_PrincipalObjectAttributeAccesses](#BKMK_msdyn_integrationjobdetail_PrincipalObjectAttributeAccesses)
- [msdyn_invoicefrequency_PrincipalObjectAttributeAccesses](#BKMK_msdyn_invoicefrequency_PrincipalObjectAttributeAccesses)
- [msdyn_invoicefrequencydetail_PrincipalObjectAttributeAccesses](#BKMK_msdyn_invoicefrequencydetail_PrincipalObjectAttributeAccesses)
- [msdyn_invoicelinetransaction_PrincipalObjectAttributeAccesses](#BKMK_msdyn_invoicelinetransaction_PrincipalObjectAttributeAccesses)
- [msdyn_journal_PrincipalObjectAttributeAccesses](#BKMK_msdyn_journal_PrincipalObjectAttributeAccesses)
- [msdyn_journalline_PrincipalObjectAttributeAccesses](#BKMK_msdyn_journalline_PrincipalObjectAttributeAccesses)
- [msdyn_mlresultcache_PrincipalObjectAttributeAccesses](#BKMK_msdyn_mlresultcache_PrincipalObjectAttributeAccesses)
- [msdyn_opportunitylineresourcecategory_PrincipalObjectAttributeAccesses](#BKMK_msdyn_opportunitylineresourcecategory_PrincipalObjectAttributeAccesses)
- [msdyn_opportunitylinetransaction_PrincipalObjectAttributeAccesses](#BKMK_msdyn_opportunitylinetransaction_PrincipalObjectAttributeAccesses)
- [msdyn_opportunitylinetransactioncategory_PrincipalObjectAttributeAccesses](#BKMK_msdyn_opportunitylinetransactioncategory_PrincipalObjectAttributeAccesses)
- [msdyn_opportunitylinetransactionclassificatio_PrincipalObjectAttributeAccesses](#BKMK_msdyn_opportunitylinetransactionclassificatio_PrincipalObjectAttributeAccesses)
- [msdyn_opportunitypricelist_PrincipalObjectAttributeAccesses](#BKMK_msdyn_opportunitypricelist_PrincipalObjectAttributeAccesses)
- [msdyn_orderlineresourcecategory_PrincipalObjectAttributeAccesses](#BKMK_msdyn_orderlineresourcecategory_PrincipalObjectAttributeAccesses)
- [msdyn_orderlinetransaction_PrincipalObjectAttributeAccesses](#BKMK_msdyn_orderlinetransaction_PrincipalObjectAttributeAccesses)
- [msdyn_orderlinetransactioncategory_PrincipalObjectAttributeAccesses](#BKMK_msdyn_orderlinetransactioncategory_PrincipalObjectAttributeAccesses)
- [msdyn_orderlinetransactionclassification_PrincipalObjectAttributeAccesses](#BKMK_msdyn_orderlinetransactionclassification_PrincipalObjectAttributeAccesses)
- [msdyn_orderpricelist_PrincipalObjectAttributeAccesses](#BKMK_msdyn_orderpricelist_PrincipalObjectAttributeAccesses)
- [msdyn_processnotes_PrincipalObjectAttributeAccesses](#BKMK_msdyn_processnotes_PrincipalObjectAttributeAccesses)
- [msdyn_project_PrincipalObjectAttributeAccesses](#BKMK_msdyn_project_PrincipalObjectAttributeAccesses)
- [msdyn_projectapproval_PrincipalObjectAttributeAccesses](#BKMK_msdyn_projectapproval_PrincipalObjectAttributeAccesses)
- [msdyn_projectparameter_PrincipalObjectAttributeAccesses](#BKMK_msdyn_projectparameter_PrincipalObjectAttributeAccesses)
- [msdyn_projectparameterpricelist_PrincipalObjectAttributeAccesses](#BKMK_msdyn_projectparameterpricelist_PrincipalObjectAttributeAccesses)
- [msdyn_projectpricelist_PrincipalObjectAttributeAccesses](#BKMK_msdyn_projectpricelist_PrincipalObjectAttributeAccesses)
- [msdyn_projecttask_PrincipalObjectAttributeAccesses](#BKMK_msdyn_projecttask_PrincipalObjectAttributeAccesses)
- [msdyn_projecttaskdependency_PrincipalObjectAttributeAccesses](#BKMK_msdyn_projecttaskdependency_PrincipalObjectAttributeAccesses)
- [msdyn_projecttaskstatususer_PrincipalObjectAttributeAccesses](#BKMK_msdyn_projecttaskstatususer_PrincipalObjectAttributeAccesses)
- [msdyn_projectteam_PrincipalObjectAttributeAccesses](#BKMK_msdyn_projectteam_PrincipalObjectAttributeAccesses)
- [msdyn_projectteammembersignup_PrincipalObjectAttributeAccesses](#BKMK_msdyn_projectteammembersignup_PrincipalObjectAttributeAccesses)
- [msdyn_projecttransactioncategory_PrincipalObjectAttributeAccesses](#BKMK_msdyn_projecttransactioncategory_PrincipalObjectAttributeAccesses)
- [msdyn_quotelineanalyticsbreakdown_PrincipalObjectAttributeAccesses](#BKMK_msdyn_quotelineanalyticsbreakdown_PrincipalObjectAttributeAccesses)
- [msdyn_quotelineinvoiceschedule_PrincipalObjectAttributeAccesses](#BKMK_msdyn_quotelineinvoiceschedule_PrincipalObjectAttributeAccesses)
- [msdyn_quotelineresourcecategory_PrincipalObjectAttributeAccesses](#BKMK_msdyn_quotelineresourcecategory_PrincipalObjectAttributeAccesses)
- [msdyn_quotelinescheduleofvalue_PrincipalObjectAttributeAccesses](#BKMK_msdyn_quotelinescheduleofvalue_PrincipalObjectAttributeAccesses)
- [msdyn_quotelinetransaction_PrincipalObjectAttributeAccesses](#BKMK_msdyn_quotelinetransaction_PrincipalObjectAttributeAccesses)
- [msdyn_quotelinetransactioncategory_PrincipalObjectAttributeAccesses](#BKMK_msdyn_quotelinetransactioncategory_PrincipalObjectAttributeAccesses)
- [msdyn_quotelinetransactionclassification_PrincipalObjectAttributeAccesses](#BKMK_msdyn_quotelinetransactionclassification_PrincipalObjectAttributeAccesses)
- [msdyn_quotepricelist_PrincipalObjectAttributeAccesses](#BKMK_msdyn_quotepricelist_PrincipalObjectAttributeAccesses)
- [msdyn_resourceassignment_PrincipalObjectAttributeAccesses](#BKMK_msdyn_resourceassignment_PrincipalObjectAttributeAccesses)
- [msdyn_resourceassignmentdetail_PrincipalObjectAttributeAccesses](#BKMK_msdyn_resourceassignmentdetail_PrincipalObjectAttributeAccesses)
- [msdyn_resourcecategorypricelevel_PrincipalObjectAttributeAccesses](#BKMK_msdyn_resourcecategorypricelevel_PrincipalObjectAttributeAccesses)
- [msdyn_resourcerequest_PrincipalObjectAttributeAccesses](#BKMK_msdyn_resourcerequest_PrincipalObjectAttributeAccesses)
- [msdyn_rolecompetencyrequirement_PrincipalObjectAttributeAccesses](#BKMK_msdyn_rolecompetencyrequirement_PrincipalObjectAttributeAccesses)
- [msdyn_roleutilization_PrincipalObjectAttributeAccesses](#BKMK_msdyn_roleutilization_PrincipalObjectAttributeAccesses)
- [msdyn_timeentry_PrincipalObjectAttributeAccesses](#BKMK_msdyn_timeentry_PrincipalObjectAttributeAccesses)
- [msdyn_timeoffcalendar_PrincipalObjectAttributeAccesses](#BKMK_msdyn_timeoffcalendar_PrincipalObjectAttributeAccesses)
- [msdyn_transactioncategory_PrincipalObjectAttributeAccesses](#BKMK_msdyn_transactioncategory_PrincipalObjectAttributeAccesses)
- [msdyn_transactioncategoryclassification_PrincipalObjectAttributeAccesses](#BKMK_msdyn_transactioncategoryclassification_PrincipalObjectAttributeAccesses)
- [msdyn_transactioncategoryhierarchyelement_PrincipalObjectAttributeAccesses](#BKMK_msdyn_transactioncategoryhierarchyelement_PrincipalObjectAttributeAccesses)
- [msdyn_transactioncategorypricelevel_PrincipalObjectAttributeAccesses](#BKMK_msdyn_transactioncategorypricelevel_PrincipalObjectAttributeAccesses)
- [msdyn_transactionconnection_PrincipalObjectAttributeAccesses](#BKMK_msdyn_transactionconnection_PrincipalObjectAttributeAccesses)
- [msdyn_transactiontype_PrincipalObjectAttributeAccesses](#BKMK_msdyn_transactiontype_PrincipalObjectAttributeAccesses)
- [msdyn_userworkhistory_PrincipalObjectAttributeAccesses](#BKMK_msdyn_userworkhistory_PrincipalObjectAttributeAccesses)
- [msdyn_agreement_PrincipalObjectAttributeAccesses](#BKMK_msdyn_agreement_PrincipalObjectAttributeAccesses)
- [msdyn_agreementbookingdate_PrincipalObjectAttributeAccesses](#BKMK_msdyn_agreementbookingdate_PrincipalObjectAttributeAccesses)
- [msdyn_agreementbookingincident_PrincipalObjectAttributeAccesses](#BKMK_msdyn_agreementbookingincident_PrincipalObjectAttributeAccesses)
- [msdyn_agreementbookingproduct_PrincipalObjectAttributeAccesses](#BKMK_msdyn_agreementbookingproduct_PrincipalObjectAttributeAccesses)
- [msdyn_agreementbookingservice_PrincipalObjectAttributeAccesses](#BKMK_msdyn_agreementbookingservice_PrincipalObjectAttributeAccesses)
- [msdyn_agreementbookingservicetask_PrincipalObjectAttributeAccesses](#BKMK_msdyn_agreementbookingservicetask_PrincipalObjectAttributeAccesses)
- [msdyn_agreementbookingsetup_PrincipalObjectAttributeAccesses](#BKMK_msdyn_agreementbookingsetup_PrincipalObjectAttributeAccesses)
- [msdyn_agreementinvoicedate_PrincipalObjectAttributeAccesses](#BKMK_msdyn_agreementinvoicedate_PrincipalObjectAttributeAccesses)
- [msdyn_agreementinvoiceproduct_PrincipalObjectAttributeAccesses](#BKMK_msdyn_agreementinvoiceproduct_PrincipalObjectAttributeAccesses)
- [msdyn_agreementinvoicesetup_PrincipalObjectAttributeAccesses](#BKMK_msdyn_agreementinvoicesetup_PrincipalObjectAttributeAccesses)
- [msdyn_agreementsubstatus_PrincipalObjectAttributeAccesses](#BKMK_msdyn_agreementsubstatus_PrincipalObjectAttributeAccesses)
- [msdyn_bookingjournal_PrincipalObjectAttributeAccesses](#BKMK_msdyn_bookingjournal_PrincipalObjectAttributeAccesses)
- [msdyn_bookingtimestamp_PrincipalObjectAttributeAccesses](#BKMK_msdyn_bookingtimestamp_PrincipalObjectAttributeAccesses)
- [msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_PrincipalObjectAttributeAccesses](#BKMK_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_PrincipalObjectAttributeAccesses)
- [msdyn_bpf_989e9b1857e24af18787d5143b67523b_PrincipalObjectAttributeAccesses](#BKMK_msdyn_bpf_989e9b1857e24af18787d5143b67523b_PrincipalObjectAttributeAccesses)
- [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_PrincipalObjectAttributeAccesses](#BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_PrincipalObjectAttributeAccesses)
- [msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_PrincipalObjectAttributeAccesses](#BKMK_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_PrincipalObjectAttributeAccesses)
- [msdyn_customerasset_PrincipalObjectAttributeAccesses](#BKMK_msdyn_customerasset_PrincipalObjectAttributeAccesses)
- [msdyn_fieldservicepricelistitem_PrincipalObjectAttributeAccesses](#BKMK_msdyn_fieldservicepricelistitem_PrincipalObjectAttributeAccesses)
- [msdyn_fieldservicesetting_PrincipalObjectAttributeAccesses](#BKMK_msdyn_fieldservicesetting_PrincipalObjectAttributeAccesses)
- [msdyn_fieldservicesystemjob_PrincipalObjectAttributeAccesses](#BKMK_msdyn_fieldservicesystemjob_PrincipalObjectAttributeAccesses)
- [msdyn_incidenttype_PrincipalObjectAttributeAccesses](#BKMK_msdyn_incidenttype_PrincipalObjectAttributeAccesses)
- [msdyn_incidenttypecharacteristic_PrincipalObjectAttributeAccesses](#BKMK_msdyn_incidenttypecharacteristic_PrincipalObjectAttributeAccesses)
- [msdyn_incidenttypeproduct_PrincipalObjectAttributeAccesses](#BKMK_msdyn_incidenttypeproduct_PrincipalObjectAttributeAccesses)
- [msdyn_incidenttypeservice_PrincipalObjectAttributeAccesses](#BKMK_msdyn_incidenttypeservice_PrincipalObjectAttributeAccesses)
- [msdyn_incidenttypeservicetask_PrincipalObjectAttributeAccesses](#BKMK_msdyn_incidenttypeservicetask_PrincipalObjectAttributeAccesses)
- [msdyn_inventoryadjustment_PrincipalObjectAttributeAccesses](#BKMK_msdyn_inventoryadjustment_PrincipalObjectAttributeAccesses)
- [msdyn_inventoryadjustmentproduct_PrincipalObjectAttributeAccesses](#BKMK_msdyn_inventoryadjustmentproduct_PrincipalObjectAttributeAccesses)
- [msdyn_inventoryjournal_PrincipalObjectAttributeAccesses](#BKMK_msdyn_inventoryjournal_PrincipalObjectAttributeAccesses)
- [msdyn_inventorytransfer_PrincipalObjectAttributeAccesses](#BKMK_msdyn_inventorytransfer_PrincipalObjectAttributeAccesses)
- [msdyn_orderinvoicingdate_PrincipalObjectAttributeAccesses](#BKMK_msdyn_orderinvoicingdate_PrincipalObjectAttributeAccesses)
- [msdyn_orderinvoicingproduct_PrincipalObjectAttributeAccesses](#BKMK_msdyn_orderinvoicingproduct_PrincipalObjectAttributeAccesses)
- [msdyn_orderinvoicingsetup_PrincipalObjectAttributeAccesses](#BKMK_msdyn_orderinvoicingsetup_PrincipalObjectAttributeAccesses)
- [msdyn_orderinvoicingsetupdate_PrincipalObjectAttributeAccesses](#BKMK_msdyn_orderinvoicingsetupdate_PrincipalObjectAttributeAccesses)
- [msdyn_payment_PrincipalObjectAttributeAccesses](#BKMK_msdyn_payment_PrincipalObjectAttributeAccesses)
- [msdyn_paymentdetail_PrincipalObjectAttributeAccesses](#BKMK_msdyn_paymentdetail_PrincipalObjectAttributeAccesses)
- [msdyn_paymentmethod_PrincipalObjectAttributeAccesses](#BKMK_msdyn_paymentmethod_PrincipalObjectAttributeAccesses)
- [msdyn_paymentterm_PrincipalObjectAttributeAccesses](#BKMK_msdyn_paymentterm_PrincipalObjectAttributeAccesses)
- [msdyn_postalcode_PrincipalObjectAttributeAccesses](#BKMK_msdyn_postalcode_PrincipalObjectAttributeAccesses)
- [msdyn_productinventory_PrincipalObjectAttributeAccesses](#BKMK_msdyn_productinventory_PrincipalObjectAttributeAccesses)
- [msdyn_purchaseorder_PrincipalObjectAttributeAccesses](#BKMK_msdyn_purchaseorder_PrincipalObjectAttributeAccesses)
- [msdyn_purchaseorderbill_PrincipalObjectAttributeAccesses](#BKMK_msdyn_purchaseorderbill_PrincipalObjectAttributeAccesses)
- [msdyn_purchaseorderproduct_PrincipalObjectAttributeAccesses](#BKMK_msdyn_purchaseorderproduct_PrincipalObjectAttributeAccesses)
- [msdyn_purchaseorderreceipt_PrincipalObjectAttributeAccesses](#BKMK_msdyn_purchaseorderreceipt_PrincipalObjectAttributeAccesses)
- [msdyn_purchaseorderreceiptproduct_PrincipalObjectAttributeAccesses](#BKMK_msdyn_purchaseorderreceiptproduct_PrincipalObjectAttributeAccesses)
- [msdyn_purchaseordersubstatus_PrincipalObjectAttributeAccesses](#BKMK_msdyn_purchaseordersubstatus_PrincipalObjectAttributeAccesses)
- [msdyn_quotebookingincident_PrincipalObjectAttributeAccesses](#BKMK_msdyn_quotebookingincident_PrincipalObjectAttributeAccesses)
- [msdyn_quotebookingproduct_PrincipalObjectAttributeAccesses](#BKMK_msdyn_quotebookingproduct_PrincipalObjectAttributeAccesses)
- [msdyn_quotebookingservice_PrincipalObjectAttributeAccesses](#BKMK_msdyn_quotebookingservice_PrincipalObjectAttributeAccesses)
- [msdyn_quotebookingservicetask_PrincipalObjectAttributeAccesses](#BKMK_msdyn_quotebookingservicetask_PrincipalObjectAttributeAccesses)
- [msdyn_quotebookingsetup_PrincipalObjectAttributeAccesses](#BKMK_msdyn_quotebookingsetup_PrincipalObjectAttributeAccesses)
- [msdyn_quoteinvoicingproduct_PrincipalObjectAttributeAccesses](#BKMK_msdyn_quoteinvoicingproduct_PrincipalObjectAttributeAccesses)
- [msdyn_quoteinvoicingsetup_PrincipalObjectAttributeAccesses](#BKMK_msdyn_quoteinvoicingsetup_PrincipalObjectAttributeAccesses)
- [msdyn_resourcepaytype_PrincipalObjectAttributeAccesses](#BKMK_msdyn_resourcepaytype_PrincipalObjectAttributeAccesses)
- [msdyn_rma_PrincipalObjectAttributeAccesses](#BKMK_msdyn_rma_PrincipalObjectAttributeAccesses)
- [msdyn_rmaproduct_PrincipalObjectAttributeAccesses](#BKMK_msdyn_rmaproduct_PrincipalObjectAttributeAccesses)
- [msdyn_rmareceipt_PrincipalObjectAttributeAccesses](#BKMK_msdyn_rmareceipt_PrincipalObjectAttributeAccesses)
- [msdyn_rmareceiptproduct_PrincipalObjectAttributeAccesses](#BKMK_msdyn_rmareceiptproduct_PrincipalObjectAttributeAccesses)
- [msdyn_rmasubstatus_PrincipalObjectAttributeAccesses](#BKMK_msdyn_rmasubstatus_PrincipalObjectAttributeAccesses)
- [msdyn_rtv_PrincipalObjectAttributeAccesses](#BKMK_msdyn_rtv_PrincipalObjectAttributeAccesses)
- [msdyn_rtvproduct_PrincipalObjectAttributeAccesses](#BKMK_msdyn_rtvproduct_PrincipalObjectAttributeAccesses)
- [msdyn_rtvsubstatus_PrincipalObjectAttributeAccesses](#BKMK_msdyn_rtvsubstatus_PrincipalObjectAttributeAccesses)
- [msdyn_servicetasktype_PrincipalObjectAttributeAccesses](#BKMK_msdyn_servicetasktype_PrincipalObjectAttributeAccesses)
- [msdyn_shipvia_PrincipalObjectAttributeAccesses](#BKMK_msdyn_shipvia_PrincipalObjectAttributeAccesses)
- [msdyn_taxcode_PrincipalObjectAttributeAccesses](#BKMK_msdyn_taxcode_PrincipalObjectAttributeAccesses)
- [msdyn_taxcodedetail_PrincipalObjectAttributeAccesses](#BKMK_msdyn_taxcodedetail_PrincipalObjectAttributeAccesses)
- [msdyn_timeoffrequest_PrincipalObjectAttributeAccesses](#BKMK_msdyn_timeoffrequest_PrincipalObjectAttributeAccesses)
- [msdyn_uniquenumber_PrincipalObjectAttributeAccesses](#BKMK_msdyn_uniquenumber_PrincipalObjectAttributeAccesses)
- [msdyn_warehouse_PrincipalObjectAttributeAccesses](#BKMK_msdyn_warehouse_PrincipalObjectAttributeAccesses)
- [msdyn_workorder_PrincipalObjectAttributeAccesses](#BKMK_msdyn_workorder_PrincipalObjectAttributeAccesses)
- [msdyn_workordercharacteristic_PrincipalObjectAttributeAccesses](#BKMK_msdyn_workordercharacteristic_PrincipalObjectAttributeAccesses)
- [msdyn_workorderdetailsgenerationqueue_PrincipalObjectAttributeAccesses](#BKMK_msdyn_workorderdetailsgenerationqueue_PrincipalObjectAttributeAccesses)
- [msdyn_workorderincident_PrincipalObjectAttributeAccesses](#BKMK_msdyn_workorderincident_PrincipalObjectAttributeAccesses)
- [msdyn_workorderproduct_PrincipalObjectAttributeAccesses](#BKMK_msdyn_workorderproduct_PrincipalObjectAttributeAccesses)
- [msdyn_workorderresourcerestriction_PrincipalObjectAttributeAccesses](#BKMK_msdyn_workorderresourcerestriction_PrincipalObjectAttributeAccesses)
- [msdyn_workorderservice_PrincipalObjectAttributeAccesses](#BKMK_msdyn_workorderservice_PrincipalObjectAttributeAccesses)
- [msdyn_workorderservicetask_PrincipalObjectAttributeAccesses](#BKMK_msdyn_workorderservicetask_PrincipalObjectAttributeAccesses)
- [msdyn_workordersubstatus_PrincipalObjectAttributeAccesses](#BKMK_msdyn_workordersubstatus_PrincipalObjectAttributeAccesses)
- [msdyn_workordertype_PrincipalObjectAttributeAccesses](#BKMK_msdyn_workordertype_PrincipalObjectAttributeAccesses)
- [account_principalobjectattributeaccess](#BKMK_account_principalobjectattributeaccess)
- [contact_principalobjectattributeaccess](#BKMK_contact_principalobjectattributeaccess)
- [lk_principalobjectattributeaccess_organizationid](#BKMK_lk_principalobjectattributeaccess_organizationid)
- [team_principalobjectattributeaccess_principalid](#BKMK_team_principalobjectattributeaccess_principalid)
- [systemuser_principalobjectattributeaccess_principalid](#BKMK_systemuser_principalobjectattributeaccess_principalid)
- [knowledgearticle_PrincipalObjectAttributeAccess](#BKMK_knowledgearticle_PrincipalObjectAttributeAccess)
- [channelaccessprofile_PrincipalObjectAttributeAccess](#BKMK_channelaccessprofile_PrincipalObjectAttributeAccess)
- [KnowledgeBaseRecord_PrincipalObjectAttributeAccess](#BKMK_KnowledgeBaseRecord_PrincipalObjectAttributeAccess)
- [team_principalobjectattributeaccess](#BKMK_team_principalobjectattributeaccess)
- [reportcategory_principalobjectattributeaccess](#BKMK_reportcategory_principalobjectattributeaccess)
- [mailmergetemplate_principalobjectattributeaccess](#BKMK_mailmergetemplate_principalobjectattributeaccess)
- [fax_principalobjectattributeaccess](#BKMK_fax_principalobjectattributeaccess)
- [socialactivity_principalobjectattributeaccess](#BKMK_socialactivity_principalobjectattributeaccess)
- [kbarticle_principalobjectattributeaccess](#BKMK_kbarticle_principalobjectattributeaccess)
- [phonecall_principalobjectattributeaccess](#BKMK_phonecall_principalobjectattributeaccess)
- [position_principalobjectattributeaccess](#BKMK_position_principalobjectattributeaccess)
- [customeraddress_principalobjectattributeaccess](#BKMK_customeraddress_principalobjectattributeaccess)
- [sharepointsite_principalobjectattributeaccess](#BKMK_sharepointsite_principalobjectattributeaccess)
- [systemuser_principalobjectattributeaccess](#BKMK_systemuser_principalobjectattributeaccess)
- [connection_principalobjectattributeaccess](#BKMK_connection_principalobjectattributeaccess)
- [appointment_principalobjectattributeaccess](#BKMK_appointment_principalobjectattributeaccess)
- [goal_principalobjectattributeaccess](#BKMK_goal_principalobjectattributeaccess)
- [email_principalobjectattributeaccess](#BKMK_email_principalobjectattributeaccess)
- [knowledgearticleview_principalobjectattributeaccess](#BKMK_knowledgearticleview_principalobjectattributeaccess)
- [feedback_principalobjectattributeaccess](#BKMK_feedback_principalobjectattributeaccess)
- [businessunit_principalobjectattributeaccess](#BKMK_businessunit_principalobjectattributeaccess)
- [sharepointdocumentlocation_principalobjectattributeaccess](#BKMK_sharepointdocumentlocation_principalobjectattributeaccess)
- [queueitem_principalobjectattributeaccess](#BKMK_queueitem_principalobjectattributeaccess)
- [queue_principalobjectattributeaccess](#BKMK_queue_principalobjectattributeaccess)
- [recurringappointmentmaster_principalobjectattributeaccess](#BKMK_recurringappointmentmaster_principalobjectattributeaccess)
- [task_principalobjectattributeaccess](#BKMK_task_principalobjectattributeaccess)
- [letter_principalobjectattributeaccess](#BKMK_letter_principalobjectattributeaccess)
- [socialprofile_principalobjectattributeaccess](#BKMK_socialprofile_principalobjectattributeaccess)


### <a name="BKMK_msdyn_iotalert_PrincipalObjectAttributeAccesses"></a> msdyn_iotalert_PrincipalObjectAttributeAccesses

See msdyn_iotalert Entity [msdyn_iotalert_PrincipalObjectAttributeAccesses](msdyn_iotalert.md#BKMK_msdyn_iotalert_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdevice_PrincipalObjectAttributeAccesses"></a> msdyn_iotdevice_PrincipalObjectAttributeAccesses

See msdyn_iotdevice Entity [msdyn_iotdevice_PrincipalObjectAttributeAccesses](msdyn_iotdevice.md#BKMK_msdyn_iotdevice_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdevicecategory_PrincipalObjectAttributeAccesses"></a> msdyn_iotdevicecategory_PrincipalObjectAttributeAccesses

See msdyn_iotdevicecategory Entity [msdyn_iotdevicecategory_PrincipalObjectAttributeAccesses](msdyn_iotdevicecategory.md#BKMK_msdyn_iotdevicecategory_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdevicecommand_PrincipalObjectAttributeAccesses"></a> msdyn_iotdevicecommand_PrincipalObjectAttributeAccesses

See msdyn_iotdevicecommand Entity [msdyn_iotdevicecommand_PrincipalObjectAttributeAccesses](msdyn_iotdevicecommand.md#BKMK_msdyn_iotdevicecommand_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_iotdeviceregistrationhistory_PrincipalObjectAttributeAccesses"></a> msdyn_iotdeviceregistrationhistory_PrincipalObjectAttributeAccesses

See msdyn_iotdeviceregistrationhistory Entity [msdyn_iotdeviceregistrationhistory_PrincipalObjectAttributeAccesses](msdyn_iotdeviceregistrationhistory.md#BKMK_msdyn_iotdeviceregistrationhistory_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_PrincipalObjectAttributeAccesses"></a> msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_PrincipalObjectAttributeAccesses

See msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b Entity [msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_PrincipalObjectAttributeAccesses](msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b.md#BKMK_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_territory_principalobjectattributeaccess"></a> territory_principalobjectattributeaccess

See territory Entity [territory_principalobjectattributeaccess](territory.md#BKMK_territory_principalobjectattributeaccess) One-To-Many relationship.

### <a name="BKMK_accountleads_PrincipalObjectAttributeAccesses"></a> accountleads_PrincipalObjectAttributeAccesses

See accountleads Entity [accountleads_PrincipalObjectAttributeAccesses](accountleads.md#BKMK_accountleads_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_contactleads_PrincipalObjectAttributeAccesses"></a> contactleads_PrincipalObjectAttributeAccesses

See contactleads Entity [contactleads_PrincipalObjectAttributeAccesses](contactleads.md#BKMK_contactleads_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_leadaddress_PrincipalObjectAttributeAccesses"></a> leadaddress_PrincipalObjectAttributeAccesses

See leadaddress Entity [leadaddress_PrincipalObjectAttributeAccesses](leadaddress.md#BKMK_leadaddress_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_lead_principalobjectattributeaccess"></a> lead_principalobjectattributeaccess

See lead Entity [lead_principalobjectattributeaccess](lead.md#BKMK_lead_principalobjectattributeaccess) One-To-Many relationship.

### <a name="BKMK_dynamicproperty_PrincipalObjectAttributeAccesses"></a> dynamicproperty_PrincipalObjectAttributeAccesses

See dynamicproperty Entity [dynamicproperty_PrincipalObjectAttributeAccesses](dynamicproperty.md#BKMK_dynamicproperty_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_dynamicpropertyassociation_PrincipalObjectAttributeAccesses"></a> dynamicpropertyassociation_PrincipalObjectAttributeAccesses

See dynamicpropertyassociation Entity [dynamicpropertyassociation_PrincipalObjectAttributeAccesses](dynamicpropertyassociation.md#BKMK_dynamicpropertyassociation_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_dynamicpropertyinstance_PrincipalObjectAttributeAccesses"></a> dynamicpropertyinstance_PrincipalObjectAttributeAccesses

See dynamicpropertyinstance Entity [dynamicpropertyinstance_PrincipalObjectAttributeAccesses](dynamicpropertyinstance.md#BKMK_dynamicpropertyinstance_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_dynamicpropertyoptionsetitem_PrincipalObjectAttributeAccesses"></a> dynamicpropertyoptionsetitem_PrincipalObjectAttributeAccesses

See dynamicpropertyoptionsetitem Entity [dynamicpropertyoptionsetitem_PrincipalObjectAttributeAccesses](dynamicpropertyoptionsetitem.md#BKMK_dynamicpropertyoptionsetitem_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_pricelevel_principalobjectattributeaccess"></a> pricelevel_principalobjectattributeaccess

See pricelevel Entity [pricelevel_principalobjectattributeaccess](pricelevel.md#BKMK_pricelevel_principalobjectattributeaccess) One-To-Many relationship.

### <a name="BKMK_product_principalobjectattributeaccess"></a> product_principalobjectattributeaccess

See product Entity [product_principalobjectattributeaccess](product.md#BKMK_product_principalobjectattributeaccess) One-To-Many relationship.

### <a name="BKMK_ProductAssociation_PrincipalObjectAttributeAccess"></a> ProductAssociation_PrincipalObjectAttributeAccess

See productassociation Entity [ProductAssociation_PrincipalObjectAttributeAccess](productassociation.md#BKMK_ProductAssociation_PrincipalObjectAttributeAccess) One-To-Many relationship.

### <a name="BKMK_productpricelevel_PrincipalObjectAttributeAccesses"></a> productpricelevel_PrincipalObjectAttributeAccesses

See productpricelevel Entity [productpricelevel_PrincipalObjectAttributeAccesses](productpricelevel.md#BKMK_productpricelevel_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_ProductSubstitute_PrincipalObjectAttributeAccess"></a> ProductSubstitute_PrincipalObjectAttributeAccess

See productsubstitute Entity [ProductSubstitute_PrincipalObjectAttributeAccess](productsubstitute.md#BKMK_ProductSubstitute_PrincipalObjectAttributeAccess) One-To-Many relationship.

### <a name="BKMK_uom_PrincipalObjectAttributeAccesses"></a> uom_PrincipalObjectAttributeAccesses

See uom Entity [uom_PrincipalObjectAttributeAccesses](uom.md#BKMK_uom_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_uomschedule_PrincipalObjectAttributeAccesses"></a> uomschedule_PrincipalObjectAttributeAccesses

See uomschedule Entity [uomschedule_PrincipalObjectAttributeAccesses](uomschedule.md#BKMK_uomschedule_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_bookableresource_PrincipalObjectAttributeAccess"></a> bookableresource_PrincipalObjectAttributeAccess

See bookableresource Entity [bookableresource_PrincipalObjectAttributeAccess](bookableresource.md#BKMK_bookableresource_PrincipalObjectAttributeAccess) One-To-Many relationship.

### <a name="BKMK_bookableresourcebooking_PrincipalObjectAttributeAccess"></a> bookableresourcebooking_PrincipalObjectAttributeAccess

See bookableresourcebooking Entity [bookableresourcebooking_PrincipalObjectAttributeAccess](bookableresourcebooking.md#BKMK_bookableresourcebooking_PrincipalObjectAttributeAccess) One-To-Many relationship.

### <a name="BKMK_bookableresourcebookingexchangesyncidmapping_PrincipalObjectAttributeAccesses"></a> bookableresourcebookingexchangesyncidmapping_PrincipalObjectAttributeAccesses

See bookableresourcebookingexchangesyncidmapping Entity [bookableresourcebookingexchangesyncidmapping_PrincipalObjectAttributeAccesses](bookableresourcebookingexchangesyncidmapping.md#BKMK_bookableresourcebookingexchangesyncidmapping_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_bookableresourcebookingheader_PrincipalObjectAttributeAccess"></a> bookableresourcebookingheader_PrincipalObjectAttributeAccess

See bookableresourcebookingheader Entity [bookableresourcebookingheader_PrincipalObjectAttributeAccess](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_PrincipalObjectAttributeAccess) One-To-Many relationship.

### <a name="BKMK_bookableresourcecategory_PrincipalObjectAttributeAccess"></a> bookableresourcecategory_PrincipalObjectAttributeAccess

See bookableresourcecategory Entity [bookableresourcecategory_PrincipalObjectAttributeAccess](bookableresourcecategory.md#BKMK_bookableresourcecategory_PrincipalObjectAttributeAccess) One-To-Many relationship.

### <a name="BKMK_bookableresourcecategoryassn_PrincipalObjectAttributeAccess"></a> bookableresourcecategoryassn_PrincipalObjectAttributeAccess

See bookableresourcecategoryassn Entity [bookableresourcecategoryassn_PrincipalObjectAttributeAccess](bookableresourcecategoryassn.md#BKMK_bookableresourcecategoryassn_PrincipalObjectAttributeAccess) One-To-Many relationship.

### <a name="BKMK_bookableresourcecharacteristic_PrincipalObjectAttributeAccess"></a> bookableresourcecharacteristic_PrincipalObjectAttributeAccess

See bookableresourcecharacteristic Entity [bookableresourcecharacteristic_PrincipalObjectAttributeAccess](bookableresourcecharacteristic.md#BKMK_bookableresourcecharacteristic_PrincipalObjectAttributeAccess) One-To-Many relationship.

### <a name="BKMK_bookableresourcegroup_PrincipalObjectAttributeAccess"></a> bookableresourcegroup_PrincipalObjectAttributeAccess

See bookableresourcegroup Entity [bookableresourcegroup_PrincipalObjectAttributeAccess](bookableresourcegroup.md#BKMK_bookableresourcegroup_PrincipalObjectAttributeAccess) One-To-Many relationship.

### <a name="BKMK_bookingstatus_PrincipalObjectAttributeAccess"></a> bookingstatus_PrincipalObjectAttributeAccess

See bookingstatus Entity [bookingstatus_PrincipalObjectAttributeAccess](bookingstatus.md#BKMK_bookingstatus_PrincipalObjectAttributeAccess) One-To-Many relationship.

### <a name="BKMK_characteristic_PrincipalObjectAttributeAccess"></a> characteristic_PrincipalObjectAttributeAccess

See characteristic Entity [characteristic_PrincipalObjectAttributeAccess](characteristic.md#BKMK_characteristic_PrincipalObjectAttributeAccess) One-To-Many relationship.

### <a name="BKMK_ratingmodel_PrincipalObjectAttributeAccess"></a> ratingmodel_PrincipalObjectAttributeAccess

See ratingmodel Entity [ratingmodel_PrincipalObjectAttributeAccess](ratingmodel.md#BKMK_ratingmodel_PrincipalObjectAttributeAccess) One-To-Many relationship.

### <a name="BKMK_ratingvalue_PrincipalObjectAttributeAccess"></a> ratingvalue_PrincipalObjectAttributeAccess

See ratingvalue Entity [ratingvalue_PrincipalObjectAttributeAccess](ratingvalue.md#BKMK_ratingvalue_PrincipalObjectAttributeAccess) One-To-Many relationship.

### <a name="BKMK_bulkoperation_PrincipalObjectAttributeAccesses"></a> bulkoperation_PrincipalObjectAttributeAccesses

See bulkoperation Entity [bulkoperation_PrincipalObjectAttributeAccesses](bulkoperation.md#BKMK_bulkoperation_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_bulkoperationlog_PrincipalObjectAttributeAccesses"></a> bulkoperationlog_PrincipalObjectAttributeAccesses

See bulkoperationlog Entity [bulkoperationlog_PrincipalObjectAttributeAccesses](bulkoperationlog.md#BKMK_bulkoperationlog_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_campaign_principalobjectattributeaccess"></a> campaign_principalobjectattributeaccess

See campaign Entity [campaign_principalobjectattributeaccess](campaign.md#BKMK_campaign_principalobjectattributeaccess) One-To-Many relationship.

### <a name="BKMK_campaignactivity_principalobjectattributeaccess"></a> campaignactivity_principalobjectattributeaccess

See campaignactivity Entity [campaignactivity_principalobjectattributeaccess](campaignactivity.md#BKMK_campaignactivity_principalobjectattributeaccess) One-To-Many relationship.

### <a name="BKMK_campaignactivityitem_PrincipalObjectAttributeAccesses"></a> campaignactivityitem_PrincipalObjectAttributeAccesses

See campaignactivityitem Entity [campaignactivityitem_PrincipalObjectAttributeAccesses](campaignactivityitem.md#BKMK_campaignactivityitem_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_campaignitem_PrincipalObjectAttributeAccesses"></a> campaignitem_PrincipalObjectAttributeAccesses

See campaignitem Entity [campaignitem_PrincipalObjectAttributeAccesses](campaignitem.md#BKMK_campaignitem_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_campaignresponse_principalobjectattributeaccess"></a> campaignresponse_principalobjectattributeaccess

See campaignresponse Entity [campaignresponse_principalobjectattributeaccess](campaignresponse.md#BKMK_campaignresponse_principalobjectattributeaccess) One-To-Many relationship.

### <a name="BKMK_list_principalobjectattributeaccess"></a> list_principalobjectattributeaccess

See list Entity [list_principalobjectattributeaccess](list.md#BKMK_list_principalobjectattributeaccess) One-To-Many relationship.

### <a name="BKMK_listmember_PrincipalObjectAttributeAccesses"></a> listmember_PrincipalObjectAttributeAccesses

See listmember Entity [listmember_PrincipalObjectAttributeAccesses](listmember.md#BKMK_listmember_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_commitment_PrincipalObjectAttributeAccesses"></a> commitment_PrincipalObjectAttributeAccesses

See commitment Entity [commitment_PrincipalObjectAttributeAccesses](commitment.md#BKMK_commitment_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_constraintbasedgroup_PrincipalObjectAttributeAccesses"></a> constraintbasedgroup_PrincipalObjectAttributeAccesses

See constraintbasedgroup Entity [constraintbasedgroup_PrincipalObjectAttributeAccesses](constraintbasedgroup.md#BKMK_constraintbasedgroup_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_contract_principalobjectattributeaccess"></a> contract_principalobjectattributeaccess

See contract Entity [contract_principalobjectattributeaccess](contract.md#BKMK_contract_principalobjectattributeaccess) One-To-Many relationship.

### <a name="BKMK_contractdetail_principalobjectattributeaccess"></a> contractdetail_principalobjectattributeaccess

See contractdetail Entity [contractdetail_principalobjectattributeaccess](contractdetail.md#BKMK_contractdetail_principalobjectattributeaccess) One-To-Many relationship.

### <a name="BKMK_contracttemplate_PrincipalObjectAttributeAccesses"></a> contracttemplate_PrincipalObjectAttributeAccesses

See contracttemplate Entity [contracttemplate_PrincipalObjectAttributeAccesses](contracttemplate.md#BKMK_contracttemplate_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_entitlement_PrincipalObjectAttributeAccesses"></a> entitlement_PrincipalObjectAttributeAccesses

See entitlement Entity [entitlement_PrincipalObjectAttributeAccesses](entitlement.md#BKMK_entitlement_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_entitlementchannel_PrincipalObjectAttributeAccesses"></a> entitlementchannel_PrincipalObjectAttributeAccesses

See entitlementchannel Entity [entitlementchannel_PrincipalObjectAttributeAccesses](entitlementchannel.md#BKMK_entitlementchannel_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_entitlementcontacts_PrincipalObjectAttributeAccesses"></a> entitlementcontacts_PrincipalObjectAttributeAccesses

See entitlementcontacts Entity [entitlementcontacts_PrincipalObjectAttributeAccesses](entitlementcontacts.md#BKMK_entitlementcontacts_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_entitlementproducts_PrincipalObjectAttributeAccesses"></a> entitlementproducts_PrincipalObjectAttributeAccesses

See entitlementproducts Entity [entitlementproducts_PrincipalObjectAttributeAccesses](entitlementproducts.md#BKMK_entitlementproducts_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_entitlementtemplate_PrincipalObjectAttributeAccesses"></a> entitlementtemplate_PrincipalObjectAttributeAccesses

See entitlementtemplate Entity [entitlementtemplate_PrincipalObjectAttributeAccesses](entitlementtemplate.md#BKMK_entitlementtemplate_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_entitlementtemplatechannel_PrincipalObjectAttributeAccesses"></a> entitlementtemplatechannel_PrincipalObjectAttributeAccesses

See entitlementtemplatechannel Entity [entitlementtemplatechannel_PrincipalObjectAttributeAccesses](entitlementtemplatechannel.md#BKMK_entitlementtemplatechannel_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_entitlementtemplateproducts_PrincipalObjectAttributeAccesses"></a> entitlementtemplateproducts_PrincipalObjectAttributeAccesses

See entitlementtemplateproducts Entity [entitlementtemplateproducts_PrincipalObjectAttributeAccesses](entitlementtemplateproducts.md#BKMK_entitlementtemplateproducts_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_equipment_principalobjectattributeaccess"></a> equipment_principalobjectattributeaccess

See equipment Entity [equipment_principalobjectattributeaccess](equipment.md#BKMK_equipment_principalobjectattributeaccess) One-To-Many relationship.

### <a name="BKMK_incident_principalobjectattributeaccess"></a> incident_principalobjectattributeaccess

See incident Entity [incident_principalobjectattributeaccess](incident.md#BKMK_incident_principalobjectattributeaccess) One-To-Many relationship.

### <a name="BKMK_incidentknowledgebaserecord_PrincipalObjectAttributeAccesses"></a> incidentknowledgebaserecord_PrincipalObjectAttributeAccesses

See incidentknowledgebaserecord Entity [incidentknowledgebaserecord_PrincipalObjectAttributeAccesses](incidentknowledgebaserecord.md#BKMK_incidentknowledgebaserecord_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_incidentresolution_PrincipalObjectAttributeAccesses"></a> incidentresolution_PrincipalObjectAttributeAccesses

See incidentresolution Entity [incidentresolution_PrincipalObjectAttributeAccesses](incidentresolution.md#BKMK_incidentresolution_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_knowledgearticleincident_principalobjectattributeaccess"></a> knowledgearticleincident_principalobjectattributeaccess

See knowledgearticleincident Entity [knowledgearticleincident_principalobjectattributeaccess](knowledgearticleincident.md#BKMK_knowledgearticleincident_principalobjectattributeaccess) One-To-Many relationship.

### <a name="BKMK_phonetocaseprocess_PrincipalObjectAttributeAccesses"></a> phonetocaseprocess_PrincipalObjectAttributeAccesses

See phonetocaseprocess Entity [phonetocaseprocess_PrincipalObjectAttributeAccesses](phonetocaseprocess.md#BKMK_phonetocaseprocess_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_resource_PrincipalObjectAttributeAccesses"></a> resource_PrincipalObjectAttributeAccesses

See resource Entity [resource_PrincipalObjectAttributeAccesses](resource.md#BKMK_resource_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_resourcegroup_PrincipalObjectAttributeAccesses"></a> resourcegroup_PrincipalObjectAttributeAccesses

See resourcegroup Entity [resourcegroup_PrincipalObjectAttributeAccesses](resourcegroup.md#BKMK_resourcegroup_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_resourcespec_PrincipalObjectAttributeAccesses"></a> resourcespec_PrincipalObjectAttributeAccesses

See resourcespec Entity [resourcespec_PrincipalObjectAttributeAccesses](resourcespec.md#BKMK_resourcespec_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_service_PrincipalObjectAttributeAccesses"></a> service_PrincipalObjectAttributeAccesses

See service Entity [service_PrincipalObjectAttributeAccesses](service.md#BKMK_service_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_serviceappointment_principalobjectattributeaccess"></a> serviceappointment_principalobjectattributeaccess

See serviceappointment Entity [serviceappointment_principalobjectattributeaccess](serviceappointment.md#BKMK_serviceappointment_principalobjectattributeaccess) One-To-Many relationship.

### <a name="BKMK_servicecontractcontacts_PrincipalObjectAttributeAccesses"></a> servicecontractcontacts_PrincipalObjectAttributeAccesses

See servicecontractcontacts Entity [servicecontractcontacts_PrincipalObjectAttributeAccesses](servicecontractcontacts.md#BKMK_servicecontractcontacts_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_topic_PrincipalObjectAttributeAccesses"></a> topic_PrincipalObjectAttributeAccesses

See topic Entity [topic_PrincipalObjectAttributeAccesses](topic.md#BKMK_topic_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_topichistory_PrincipalObjectAttributeAccesses"></a> topichistory_PrincipalObjectAttributeAccesses

See topichistory Entity [topichistory_PrincipalObjectAttributeAccesses](topichistory.md#BKMK_topichistory_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_topicmodel_PrincipalObjectAttributeAccesses"></a> topicmodel_PrincipalObjectAttributeAccesses

See topicmodel Entity [topicmodel_PrincipalObjectAttributeAccesses](topicmodel.md#BKMK_topicmodel_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_topicmodelconfiguration_PrincipalObjectAttributeAccesses"></a> topicmodelconfiguration_PrincipalObjectAttributeAccesses

See topicmodelconfiguration Entity [topicmodelconfiguration_PrincipalObjectAttributeAccesses](topicmodelconfiguration.md#BKMK_topicmodelconfiguration_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_topicmodelexecutionhistory_PrincipalObjectAttributeAccesses"></a> topicmodelexecutionhistory_PrincipalObjectAttributeAccesses

See topicmodelexecutionhistory Entity [topicmodelexecutionhistory_PrincipalObjectAttributeAccesses](topicmodelexecutionhistory.md#BKMK_topicmodelexecutionhistory_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_site_PrincipalObjectAttributeAccesses"></a> site_PrincipalObjectAttributeAccesses

See site Entity [site_PrincipalObjectAttributeAccesses](site.md#BKMK_site_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_competitorproduct_PrincipalObjectAttributeAccesses"></a> competitorproduct_PrincipalObjectAttributeAccesses

See competitorproduct Entity [competitorproduct_PrincipalObjectAttributeAccesses](competitorproduct.md#BKMK_competitorproduct_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_competitorsalesliterature_PrincipalObjectAttributeAccesses"></a> competitorsalesliterature_PrincipalObjectAttributeAccesses

See competitorsalesliterature Entity [competitorsalesliterature_PrincipalObjectAttributeAccesses](competitorsalesliterature.md#BKMK_competitorsalesliterature_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_contactinvoices_PrincipalObjectAttributeAccesses"></a> contactinvoices_PrincipalObjectAttributeAccesses

See contactinvoices Entity [contactinvoices_PrincipalObjectAttributeAccesses](contactinvoices.md#BKMK_contactinvoices_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_contactorders_PrincipalObjectAttributeAccesses"></a> contactorders_PrincipalObjectAttributeAccesses

See contactorders Entity [contactorders_PrincipalObjectAttributeAccesses](contactorders.md#BKMK_contactorders_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_contactquotes_PrincipalObjectAttributeAccesses"></a> contactquotes_PrincipalObjectAttributeAccesses

See contactquotes Entity [contactquotes_PrincipalObjectAttributeAccesses](contactquotes.md#BKMK_contactquotes_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_customeropportunityrole_PrincipalObjectAttributeAccesses"></a> customeropportunityrole_PrincipalObjectAttributeAccesses

See customeropportunityrole Entity [customeropportunityrole_PrincipalObjectAttributeAccesses](customeropportunityrole.md#BKMK_customeropportunityrole_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_discount_PrincipalObjectAttributeAccesses"></a> discount_PrincipalObjectAttributeAccesses

See discount Entity [discount_PrincipalObjectAttributeAccesses](discount.md#BKMK_discount_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_discounttype_PrincipalObjectAttributeAccesses"></a> discounttype_PrincipalObjectAttributeAccesses

See discounttype Entity [discounttype_PrincipalObjectAttributeAccesses](discounttype.md#BKMK_discounttype_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_invoice_principalobjectattributeaccess"></a> invoice_principalobjectattributeaccess

See invoice Entity [invoice_principalobjectattributeaccess](invoice.md#BKMK_invoice_principalobjectattributeaccess) One-To-Many relationship.

### <a name="BKMK_invoicedetail_principalobjectattributeaccess"></a> invoicedetail_principalobjectattributeaccess

See invoicedetail Entity [invoicedetail_principalobjectattributeaccess](invoicedetail.md#BKMK_invoicedetail_principalobjectattributeaccess) One-To-Many relationship.

### <a name="BKMK_leadcompetitors_PrincipalObjectAttributeAccesses"></a> leadcompetitors_PrincipalObjectAttributeAccesses

See leadcompetitors Entity [leadcompetitors_PrincipalObjectAttributeAccesses](leadcompetitors.md#BKMK_leadcompetitors_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_leadproduct_PrincipalObjectAttributeAccesses"></a> leadproduct_PrincipalObjectAttributeAccesses

See leadproduct Entity [leadproduct_PrincipalObjectAttributeAccesses](leadproduct.md#BKMK_leadproduct_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_leadtoopportunitysalesprocess_PrincipalObjectAttributeAccesses"></a> leadtoopportunitysalesprocess_PrincipalObjectAttributeAccesses

See leadtoopportunitysalesprocess Entity [leadtoopportunitysalesprocess_PrincipalObjectAttributeAccesses](leadtoopportunitysalesprocess.md#BKMK_leadtoopportunitysalesprocess_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_opportunity_principalobjectattributeaccess"></a> opportunity_principalobjectattributeaccess

See opportunity Entity [opportunity_principalobjectattributeaccess](opportunity.md#BKMK_opportunity_principalobjectattributeaccess) One-To-Many relationship.

### <a name="BKMK_opportunityclose_PrincipalObjectAttributeAccesses"></a> opportunityclose_PrincipalObjectAttributeAccesses

See opportunityclose Entity [opportunityclose_PrincipalObjectAttributeAccesses](opportunityclose.md#BKMK_opportunityclose_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_opportunitycompetitors_PrincipalObjectAttributeAccesses"></a> opportunitycompetitors_PrincipalObjectAttributeAccesses

See opportunitycompetitors Entity [opportunitycompetitors_PrincipalObjectAttributeAccesses](opportunitycompetitors.md#BKMK_opportunitycompetitors_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_opportunityproduct_principalobjectattributeaccess"></a> opportunityproduct_principalobjectattributeaccess

See opportunityproduct Entity [opportunityproduct_principalobjectattributeaccess](opportunityproduct.md#BKMK_opportunityproduct_principalobjectattributeaccess) One-To-Many relationship.

### <a name="BKMK_opportunitysalesprocess_PrincipalObjectAttributeAccesses"></a> opportunitysalesprocess_PrincipalObjectAttributeAccesses

See opportunitysalesprocess Entity [opportunitysalesprocess_PrincipalObjectAttributeAccesses](opportunitysalesprocess.md#BKMK_opportunitysalesprocess_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_orderclose_PrincipalObjectAttributeAccesses"></a> orderclose_PrincipalObjectAttributeAccesses

See orderclose Entity [orderclose_PrincipalObjectAttributeAccesses](orderclose.md#BKMK_orderclose_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_productsalesliterature_PrincipalObjectAttributeAccesses"></a> productsalesliterature_PrincipalObjectAttributeAccesses

See productsalesliterature Entity [productsalesliterature_PrincipalObjectAttributeAccesses](productsalesliterature.md#BKMK_productsalesliterature_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_quote_principalobjectattributeaccess"></a> quote_principalobjectattributeaccess

See quote Entity [quote_principalobjectattributeaccess](quote.md#BKMK_quote_principalobjectattributeaccess) One-To-Many relationship.

### <a name="BKMK_quoteclose_PrincipalObjectAttributeAccesses"></a> quoteclose_PrincipalObjectAttributeAccesses

See quoteclose Entity [quoteclose_PrincipalObjectAttributeAccesses](quoteclose.md#BKMK_quoteclose_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_quotedetail_principalobjectattributeaccess"></a> quotedetail_principalobjectattributeaccess

See quotedetail Entity [quotedetail_principalobjectattributeaccess](quotedetail.md#BKMK_quotedetail_principalobjectattributeaccess) One-To-Many relationship.

### <a name="BKMK_salesliterature_principalobjectattributeaccess"></a> salesliterature_principalobjectattributeaccess

See salesliterature Entity [salesliterature_principalobjectattributeaccess](salesliterature.md#BKMK_salesliterature_principalobjectattributeaccess) One-To-Many relationship.

### <a name="BKMK_salesliteratureitem_PrincipalObjectAttributeAccesses"></a> salesliteratureitem_PrincipalObjectAttributeAccesses

See salesliteratureitem Entity [salesliteratureitem_PrincipalObjectAttributeAccesses](salesliteratureitem.md#BKMK_salesliteratureitem_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_salesorder_principalobjectattributeaccess"></a> salesorder_principalobjectattributeaccess

See salesorder Entity [salesorder_principalobjectattributeaccess](salesorder.md#BKMK_salesorder_principalobjectattributeaccess) One-To-Many relationship.

### <a name="BKMK_salesorderdetail_principalobjectattributeaccess"></a> salesorderdetail_principalobjectattributeaccess

See salesorderdetail Entity [salesorderdetail_principalobjectattributeaccess](salesorderdetail.md#BKMK_salesorderdetail_principalobjectattributeaccess) One-To-Many relationship.

### <a name="BKMK_competitor_principalobjectattributeaccess"></a> competitor_principalobjectattributeaccess

See competitor Entity [competitor_principalobjectattributeaccess](competitor.md#BKMK_competitor_principalobjectattributeaccess) One-To-Many relationship.

### <a name="BKMK_msdyn_postalbum_PrincipalObjectAttributeAccesses"></a> msdyn_postalbum_PrincipalObjectAttributeAccesses

See msdyn_postalbum Entity [msdyn_postalbum_PrincipalObjectAttributeAccesses](msdyn_postalbum.md#BKMK_msdyn_postalbum_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_postconfig_PrincipalObjectAttributeAccesses"></a> msdyn_postconfig_PrincipalObjectAttributeAccesses

See msdyn_postconfig Entity [msdyn_postconfig_PrincipalObjectAttributeAccesses](msdyn_postconfig.md#BKMK_msdyn_postconfig_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_postruleconfig_PrincipalObjectAttributeAccesses"></a> msdyn_postruleconfig_PrincipalObjectAttributeAccesses

See msdyn_postruleconfig Entity [msdyn_postruleconfig_PrincipalObjectAttributeAccesses](msdyn_postruleconfig.md#BKMK_msdyn_postruleconfig_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_wallsavedquery_PrincipalObjectAttributeAccesses"></a> msdyn_wallsavedquery_PrincipalObjectAttributeAccesses

See msdyn_wallsavedquery Entity [msdyn_wallsavedquery_PrincipalObjectAttributeAccesses](msdyn_wallsavedquery.md#BKMK_msdyn_wallsavedquery_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses"></a> msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses

See msdyn_wallsavedqueryusersettings Entity [msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses](msdyn_wallsavedqueryusersettings.md#BKMK_msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_actual_PrincipalObjectAttributeAccesses"></a> msdyn_actual_PrincipalObjectAttributeAccesses

See msdyn_actual Entity [msdyn_actual_PrincipalObjectAttributeAccesses](msdyn_actual.md#BKMK_msdyn_actual_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalert_PrincipalObjectAttributeAccesses"></a> msdyn_bookingalert_PrincipalObjectAttributeAccesses

See msdyn_bookingalert Entity [msdyn_bookingalert_PrincipalObjectAttributeAccesses](msdyn_bookingalert.md#BKMK_msdyn_bookingalert_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingalertstatus_PrincipalObjectAttributeAccesses"></a> msdyn_bookingalertstatus_PrincipalObjectAttributeAccesses

See msdyn_bookingalertstatus Entity [msdyn_bookingalertstatus_PrincipalObjectAttributeAccesses](msdyn_bookingalertstatus.md#BKMK_msdyn_bookingalertstatus_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingchange_PrincipalObjectAttributeAccesses"></a> msdyn_bookingchange_PrincipalObjectAttributeAccesses

See msdyn_bookingchange Entity [msdyn_bookingchange_PrincipalObjectAttributeAccesses](msdyn_bookingchange.md#BKMK_msdyn_bookingchange_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingrule_PrincipalObjectAttributeAccesses"></a> msdyn_bookingrule_PrincipalObjectAttributeAccesses

See msdyn_bookingrule Entity [msdyn_bookingrule_PrincipalObjectAttributeAccesses](msdyn_bookingrule.md#BKMK_msdyn_bookingrule_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingsetupmetadata_PrincipalObjectAttributeAccesses"></a> msdyn_bookingsetupmetadata_PrincipalObjectAttributeAccesses

See msdyn_bookingsetupmetadata Entity [msdyn_bookingsetupmetadata_PrincipalObjectAttributeAccesses](msdyn_bookingsetupmetadata.md#BKMK_msdyn_bookingsetupmetadata_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_clientextension_PrincipalObjectAttributeAccesses"></a> msdyn_clientextension_PrincipalObjectAttributeAccesses

See msdyn_clientextension Entity [msdyn_clientextension_PrincipalObjectAttributeAccesses](msdyn_clientextension.md#BKMK_msdyn_clientextension_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_configuration_PrincipalObjectAttributeAccesses"></a> msdyn_configuration_PrincipalObjectAttributeAccesses

See msdyn_configuration Entity [msdyn_configuration_PrincipalObjectAttributeAccesses](msdyn_configuration.md#BKMK_msdyn_configuration_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_organizationalunit_PrincipalObjectAttributeAccesses"></a> msdyn_organizationalunit_PrincipalObjectAttributeAccesses

See msdyn_organizationalunit Entity [msdyn_organizationalunit_PrincipalObjectAttributeAccesses](msdyn_organizationalunit.md#BKMK_msdyn_organizationalunit_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_priority_PrincipalObjectAttributeAccesses"></a> msdyn_priority_PrincipalObjectAttributeAccesses

See msdyn_priority Entity [msdyn_priority_PrincipalObjectAttributeAccesses](msdyn_priority.md#BKMK_msdyn_priority_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementcharacteristic_PrincipalObjectAttributeAccesses"></a> msdyn_requirementcharacteristic_PrincipalObjectAttributeAccesses

See msdyn_requirementcharacteristic Entity [msdyn_requirementcharacteristic_PrincipalObjectAttributeAccesses](msdyn_requirementcharacteristic.md#BKMK_msdyn_requirementcharacteristic_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementorganizationunit_PrincipalObjectAttributeAccesses"></a> msdyn_requirementorganizationunit_PrincipalObjectAttributeAccesses

See msdyn_requirementorganizationunit Entity [msdyn_requirementorganizationunit_PrincipalObjectAttributeAccesses](msdyn_requirementorganizationunit.md#BKMK_msdyn_requirementorganizationunit_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementresourcecategory_PrincipalObjectAttributeAccesses"></a> msdyn_requirementresourcecategory_PrincipalObjectAttributeAccesses

See msdyn_requirementresourcecategory Entity [msdyn_requirementresourcecategory_PrincipalObjectAttributeAccesses](msdyn_requirementresourcecategory.md#BKMK_msdyn_requirementresourcecategory_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementresourcepreference_PrincipalObjectAttributeAccesses"></a> msdyn_requirementresourcepreference_PrincipalObjectAttributeAccesses

See msdyn_requirementresourcepreference Entity [msdyn_requirementresourcepreference_PrincipalObjectAttributeAccesses](msdyn_requirementresourcepreference.md#BKMK_msdyn_requirementresourcepreference_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_requirementstatus_PrincipalObjectAttributeAccesses"></a> msdyn_requirementstatus_PrincipalObjectAttributeAccesses

See msdyn_requirementstatus Entity [msdyn_requirementstatus_PrincipalObjectAttributeAccesses](msdyn_requirementstatus.md#BKMK_msdyn_requirementstatus_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcerequirement_PrincipalObjectAttributeAccesses"></a> msdyn_resourcerequirement_PrincipalObjectAttributeAccesses

See msdyn_resourcerequirement Entity [msdyn_resourcerequirement_PrincipalObjectAttributeAccesses](msdyn_resourcerequirement.md#BKMK_msdyn_resourcerequirement_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcerequirementdetail_PrincipalObjectAttributeAccesses"></a> msdyn_resourcerequirementdetail_PrincipalObjectAttributeAccesses

See msdyn_resourcerequirementdetail Entity [msdyn_resourcerequirementdetail_PrincipalObjectAttributeAccesses](msdyn_resourcerequirementdetail.md#BKMK_msdyn_resourcerequirementdetail_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_resourceterritory_PrincipalObjectAttributeAccesses"></a> msdyn_resourceterritory_PrincipalObjectAttributeAccesses

See msdyn_resourceterritory Entity [msdyn_resourceterritory_PrincipalObjectAttributeAccesses](msdyn_resourceterritory.md#BKMK_msdyn_resourceterritory_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_scheduleboardsetting_PrincipalObjectAttributeAccesses"></a> msdyn_scheduleboardsetting_PrincipalObjectAttributeAccesses

See msdyn_scheduleboardsetting Entity [msdyn_scheduleboardsetting_PrincipalObjectAttributeAccesses](msdyn_scheduleboardsetting.md#BKMK_msdyn_scheduleboardsetting_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_schedulingparameter_PrincipalObjectAttributeAccesses"></a> msdyn_schedulingparameter_PrincipalObjectAttributeAccesses

See msdyn_schedulingparameter Entity [msdyn_schedulingparameter_PrincipalObjectAttributeAccesses](msdyn_schedulingparameter.md#BKMK_msdyn_schedulingparameter_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_systemuserschedulersetting_PrincipalObjectAttributeAccesses"></a> msdyn_systemuserschedulersetting_PrincipalObjectAttributeAccesses

See msdyn_systemuserschedulersetting Entity [msdyn_systemuserschedulersetting_PrincipalObjectAttributeAccesses](msdyn_systemuserschedulersetting.md#BKMK_msdyn_systemuserschedulersetting_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroup_PrincipalObjectAttributeAccesses"></a> msdyn_timegroup_PrincipalObjectAttributeAccesses

See msdyn_timegroup Entity [msdyn_timegroup_PrincipalObjectAttributeAccesses](msdyn_timegroup.md#BKMK_msdyn_timegroup_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_timegroupdetail_PrincipalObjectAttributeAccesses"></a> msdyn_timegroupdetail_PrincipalObjectAttributeAccesses

See msdyn_timegroupdetail Entity [msdyn_timegroupdetail_PrincipalObjectAttributeAccesses](msdyn_timegroupdetail.md#BKMK_msdyn_timegroupdetail_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_transactionorigin_PrincipalObjectAttributeAccesses"></a> msdyn_transactionorigin_PrincipalObjectAttributeAccesses

See msdyn_transactionorigin Entity [msdyn_transactionorigin_PrincipalObjectAttributeAccesses](msdyn_transactionorigin.md#BKMK_msdyn_transactionorigin_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_workhourtemplate_PrincipalObjectAttributeAccesses"></a> msdyn_workhourtemplate_PrincipalObjectAttributeAccesses

See msdyn_workhourtemplate Entity [msdyn_workhourtemplate_PrincipalObjectAttributeAccesses](msdyn_workhourtemplate.md#BKMK_msdyn_workhourtemplate_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_accountpricelist_PrincipalObjectAttributeAccesses"></a> msdyn_accountpricelist_PrincipalObjectAttributeAccesses

See msdyn_accountpricelist Entity [msdyn_accountpricelist_PrincipalObjectAttributeAccesses](msdyn_accountpricelist.md#BKMK_msdyn_accountpricelist_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_approval_PrincipalObjectAttributeAccesses"></a> msdyn_approval_PrincipalObjectAttributeAccesses

See msdyn_approval Entity [msdyn_approval_PrincipalObjectAttributeAccesses](msdyn_approval.md#BKMK_msdyn_approval_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_batchjob_PrincipalObjectAttributeAccesses"></a> msdyn_batchjob_PrincipalObjectAttributeAccesses

See msdyn_batchjob Entity [msdyn_batchjob_PrincipalObjectAttributeAccesses](msdyn_batchjob.md#BKMK_msdyn_batchjob_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_665e73aa18c247d886bfc50499c73b82_PrincipalObjectAttributeAccesses"></a> msdyn_bpf_665e73aa18c247d886bfc50499c73b82_PrincipalObjectAttributeAccesses

See msdyn_bpf_665e73aa18c247d886bfc50499c73b82 Entity [msdyn_bpf_665e73aa18c247d886bfc50499c73b82_PrincipalObjectAttributeAccesses](msdyn_bpf_665e73aa18c247d886bfc50499c73b82.md#BKMK_msdyn_bpf_665e73aa18c247d886bfc50499c73b82_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_PrincipalObjectAttributeAccesses"></a> msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_PrincipalObjectAttributeAccesses

See msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d Entity [msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_PrincipalObjectAttributeAccesses](msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d.md#BKMK_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_characteristicreqforteammember_PrincipalObjectAttributeAccesses"></a> msdyn_characteristicreqforteammember_PrincipalObjectAttributeAccesses

See msdyn_characteristicreqforteammember Entity [msdyn_characteristicreqforteammember_PrincipalObjectAttributeAccesses](msdyn_characteristicreqforteammember.md#BKMK_msdyn_characteristicreqforteammember_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_contactpricelist_PrincipalObjectAttributeAccesses"></a> msdyn_contactpricelist_PrincipalObjectAttributeAccesses

See msdyn_contactpricelist Entity [msdyn_contactpricelist_PrincipalObjectAttributeAccesses](msdyn_contactpricelist.md#BKMK_msdyn_contactpricelist_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_contractlineinvoiceschedule_PrincipalObjectAttributeAccesses"></a> msdyn_contractlineinvoiceschedule_PrincipalObjectAttributeAccesses

See msdyn_contractlineinvoiceschedule Entity [msdyn_contractlineinvoiceschedule_PrincipalObjectAttributeAccesses](msdyn_contractlineinvoiceschedule.md#BKMK_msdyn_contractlineinvoiceschedule_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_contractlinescheduleofvalue_PrincipalObjectAttributeAccesses"></a> msdyn_contractlinescheduleofvalue_PrincipalObjectAttributeAccesses

See msdyn_contractlinescheduleofvalue Entity [msdyn_contractlinescheduleofvalue_PrincipalObjectAttributeAccesses](msdyn_contractlinescheduleofvalue.md#BKMK_msdyn_contractlinescheduleofvalue_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_dataexport_PrincipalObjectAttributeAccesses"></a> msdyn_dataexport_PrincipalObjectAttributeAccesses

See msdyn_dataexport Entity [msdyn_dataexport_PrincipalObjectAttributeAccesses](msdyn_dataexport.md#BKMK_msdyn_dataexport_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_delegation_PrincipalObjectAttributeAccesses"></a> msdyn_delegation_PrincipalObjectAttributeAccesses

See msdyn_delegation Entity [msdyn_delegation_PrincipalObjectAttributeAccesses](msdyn_delegation.md#BKMK_msdyn_delegation_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_estimate_PrincipalObjectAttributeAccesses"></a> msdyn_estimate_PrincipalObjectAttributeAccesses

See msdyn_estimate Entity [msdyn_estimate_PrincipalObjectAttributeAccesses](msdyn_estimate.md#BKMK_msdyn_estimate_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_estimateline_PrincipalObjectAttributeAccesses"></a> msdyn_estimateline_PrincipalObjectAttributeAccesses

See msdyn_estimateline Entity [msdyn_estimateline_PrincipalObjectAttributeAccesses](msdyn_estimateline.md#BKMK_msdyn_estimateline_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_expense_PrincipalObjectAttributeAccesses"></a> msdyn_expense_PrincipalObjectAttributeAccesses

See msdyn_expense Entity [msdyn_expense_PrincipalObjectAttributeAccesses](msdyn_expense.md#BKMK_msdyn_expense_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_expensecategory_PrincipalObjectAttributeAccesses"></a> msdyn_expensecategory_PrincipalObjectAttributeAccesses

See msdyn_expensecategory Entity [msdyn_expensecategory_PrincipalObjectAttributeAccesses](msdyn_expensecategory.md#BKMK_msdyn_expensecategory_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_expensereceipt_PrincipalObjectAttributeAccesses"></a> msdyn_expensereceipt_PrincipalObjectAttributeAccesses

See msdyn_expensereceipt Entity [msdyn_expensereceipt_PrincipalObjectAttributeAccesses](msdyn_expensereceipt.md#BKMK_msdyn_expensereceipt_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_fact_PrincipalObjectAttributeAccesses"></a> msdyn_fact_PrincipalObjectAttributeAccesses

See msdyn_fact Entity [msdyn_fact_PrincipalObjectAttributeAccesses](msdyn_fact.md#BKMK_msdyn_fact_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldcomputation_PrincipalObjectAttributeAccesses"></a> msdyn_fieldcomputation_PrincipalObjectAttributeAccesses

See msdyn_fieldcomputation Entity [msdyn_fieldcomputation_PrincipalObjectAttributeAccesses](msdyn_fieldcomputation.md#BKMK_msdyn_fieldcomputation_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_findworkevent_PrincipalObjectAttributeAccesses"></a> msdyn_findworkevent_PrincipalObjectAttributeAccesses

See msdyn_findworkevent Entity [msdyn_findworkevent_PrincipalObjectAttributeAccesses](msdyn_findworkevent.md#BKMK_msdyn_findworkevent_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_integrationjob_PrincipalObjectAttributeAccesses"></a> msdyn_integrationjob_PrincipalObjectAttributeAccesses

See msdyn_integrationjob Entity [msdyn_integrationjob_PrincipalObjectAttributeAccesses](msdyn_integrationjob.md#BKMK_msdyn_integrationjob_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_integrationjobdetail_PrincipalObjectAttributeAccesses"></a> msdyn_integrationjobdetail_PrincipalObjectAttributeAccesses

See msdyn_integrationjobdetail Entity [msdyn_integrationjobdetail_PrincipalObjectAttributeAccesses](msdyn_integrationjobdetail.md#BKMK_msdyn_integrationjobdetail_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_invoicefrequency_PrincipalObjectAttributeAccesses"></a> msdyn_invoicefrequency_PrincipalObjectAttributeAccesses

See msdyn_invoicefrequency Entity [msdyn_invoicefrequency_PrincipalObjectAttributeAccesses](msdyn_invoicefrequency.md#BKMK_msdyn_invoicefrequency_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_invoicefrequencydetail_PrincipalObjectAttributeAccesses"></a> msdyn_invoicefrequencydetail_PrincipalObjectAttributeAccesses

See msdyn_invoicefrequencydetail Entity [msdyn_invoicefrequencydetail_PrincipalObjectAttributeAccesses](msdyn_invoicefrequencydetail.md#BKMK_msdyn_invoicefrequencydetail_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_invoicelinetransaction_PrincipalObjectAttributeAccesses"></a> msdyn_invoicelinetransaction_PrincipalObjectAttributeAccesses

See msdyn_invoicelinetransaction Entity [msdyn_invoicelinetransaction_PrincipalObjectAttributeAccesses](msdyn_invoicelinetransaction.md#BKMK_msdyn_invoicelinetransaction_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_journal_PrincipalObjectAttributeAccesses"></a> msdyn_journal_PrincipalObjectAttributeAccesses

See msdyn_journal Entity [msdyn_journal_PrincipalObjectAttributeAccesses](msdyn_journal.md#BKMK_msdyn_journal_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_journalline_PrincipalObjectAttributeAccesses"></a> msdyn_journalline_PrincipalObjectAttributeAccesses

See msdyn_journalline Entity [msdyn_journalline_PrincipalObjectAttributeAccesses](msdyn_journalline.md#BKMK_msdyn_journalline_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_mlresultcache_PrincipalObjectAttributeAccesses"></a> msdyn_mlresultcache_PrincipalObjectAttributeAccesses

See msdyn_mlresultcache Entity [msdyn_mlresultcache_PrincipalObjectAttributeAccesses](msdyn_mlresultcache.md#BKMK_msdyn_mlresultcache_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitylineresourcecategory_PrincipalObjectAttributeAccesses"></a> msdyn_opportunitylineresourcecategory_PrincipalObjectAttributeAccesses

See msdyn_opportunitylineresourcecategory Entity [msdyn_opportunitylineresourcecategory_PrincipalObjectAttributeAccesses](msdyn_opportunitylineresourcecategory.md#BKMK_msdyn_opportunitylineresourcecategory_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitylinetransaction_PrincipalObjectAttributeAccesses"></a> msdyn_opportunitylinetransaction_PrincipalObjectAttributeAccesses

See msdyn_opportunitylinetransaction Entity [msdyn_opportunitylinetransaction_PrincipalObjectAttributeAccesses](msdyn_opportunitylinetransaction.md#BKMK_msdyn_opportunitylinetransaction_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitylinetransactioncategory_PrincipalObjectAttributeAccesses"></a> msdyn_opportunitylinetransactioncategory_PrincipalObjectAttributeAccesses

See msdyn_opportunitylinetransactioncategory Entity [msdyn_opportunitylinetransactioncategory_PrincipalObjectAttributeAccesses](msdyn_opportunitylinetransactioncategory.md#BKMK_msdyn_opportunitylinetransactioncategory_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitylinetransactionclassificatio_PrincipalObjectAttributeAccesses"></a> msdyn_opportunitylinetransactionclassificatio_PrincipalObjectAttributeAccesses

See msdyn_opportunitylinetransactionclassificatio Entity [msdyn_opportunitylinetransactionclassificatio_PrincipalObjectAttributeAccesses](msdyn_opportunitylinetransactionclassificatio.md#BKMK_msdyn_opportunitylinetransactionclassificatio_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_opportunitypricelist_PrincipalObjectAttributeAccesses"></a> msdyn_opportunitypricelist_PrincipalObjectAttributeAccesses

See msdyn_opportunitypricelist Entity [msdyn_opportunitypricelist_PrincipalObjectAttributeAccesses](msdyn_opportunitypricelist.md#BKMK_msdyn_opportunitypricelist_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_orderlineresourcecategory_PrincipalObjectAttributeAccesses"></a> msdyn_orderlineresourcecategory_PrincipalObjectAttributeAccesses

See msdyn_orderlineresourcecategory Entity [msdyn_orderlineresourcecategory_PrincipalObjectAttributeAccesses](msdyn_orderlineresourcecategory.md#BKMK_msdyn_orderlineresourcecategory_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_orderlinetransaction_PrincipalObjectAttributeAccesses"></a> msdyn_orderlinetransaction_PrincipalObjectAttributeAccesses

See msdyn_orderlinetransaction Entity [msdyn_orderlinetransaction_PrincipalObjectAttributeAccesses](msdyn_orderlinetransaction.md#BKMK_msdyn_orderlinetransaction_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_orderlinetransactioncategory_PrincipalObjectAttributeAccesses"></a> msdyn_orderlinetransactioncategory_PrincipalObjectAttributeAccesses

See msdyn_orderlinetransactioncategory Entity [msdyn_orderlinetransactioncategory_PrincipalObjectAttributeAccesses](msdyn_orderlinetransactioncategory.md#BKMK_msdyn_orderlinetransactioncategory_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_orderlinetransactionclassification_PrincipalObjectAttributeAccesses"></a> msdyn_orderlinetransactionclassification_PrincipalObjectAttributeAccesses

See msdyn_orderlinetransactionclassification Entity [msdyn_orderlinetransactionclassification_PrincipalObjectAttributeAccesses](msdyn_orderlinetransactionclassification.md#BKMK_msdyn_orderlinetransactionclassification_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_orderpricelist_PrincipalObjectAttributeAccesses"></a> msdyn_orderpricelist_PrincipalObjectAttributeAccesses

See msdyn_orderpricelist Entity [msdyn_orderpricelist_PrincipalObjectAttributeAccesses](msdyn_orderpricelist.md#BKMK_msdyn_orderpricelist_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_processnotes_PrincipalObjectAttributeAccesses"></a> msdyn_processnotes_PrincipalObjectAttributeAccesses

See msdyn_processnotes Entity [msdyn_processnotes_PrincipalObjectAttributeAccesses](msdyn_processnotes.md#BKMK_msdyn_processnotes_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_project_PrincipalObjectAttributeAccesses"></a> msdyn_project_PrincipalObjectAttributeAccesses

See msdyn_project Entity [msdyn_project_PrincipalObjectAttributeAccesses](msdyn_project.md#BKMK_msdyn_project_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_projectapproval_PrincipalObjectAttributeAccesses"></a> msdyn_projectapproval_PrincipalObjectAttributeAccesses

See msdyn_projectapproval Entity [msdyn_projectapproval_PrincipalObjectAttributeAccesses](msdyn_projectapproval.md#BKMK_msdyn_projectapproval_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_projectparameter_PrincipalObjectAttributeAccesses"></a> msdyn_projectparameter_PrincipalObjectAttributeAccesses

See msdyn_projectparameter Entity [msdyn_projectparameter_PrincipalObjectAttributeAccesses](msdyn_projectparameter.md#BKMK_msdyn_projectparameter_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_projectparameterpricelist_PrincipalObjectAttributeAccesses"></a> msdyn_projectparameterpricelist_PrincipalObjectAttributeAccesses

See msdyn_projectparameterpricelist Entity [msdyn_projectparameterpricelist_PrincipalObjectAttributeAccesses](msdyn_projectparameterpricelist.md#BKMK_msdyn_projectparameterpricelist_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_projectpricelist_PrincipalObjectAttributeAccesses"></a> msdyn_projectpricelist_PrincipalObjectAttributeAccesses

See msdyn_projectpricelist Entity [msdyn_projectpricelist_PrincipalObjectAttributeAccesses](msdyn_projectpricelist.md#BKMK_msdyn_projectpricelist_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_projecttask_PrincipalObjectAttributeAccesses"></a> msdyn_projecttask_PrincipalObjectAttributeAccesses

See msdyn_projecttask Entity [msdyn_projecttask_PrincipalObjectAttributeAccesses](msdyn_projecttask.md#BKMK_msdyn_projecttask_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_projecttaskdependency_PrincipalObjectAttributeAccesses"></a> msdyn_projecttaskdependency_PrincipalObjectAttributeAccesses

See msdyn_projecttaskdependency Entity [msdyn_projecttaskdependency_PrincipalObjectAttributeAccesses](msdyn_projecttaskdependency.md#BKMK_msdyn_projecttaskdependency_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_projecttaskstatususer_PrincipalObjectAttributeAccesses"></a> msdyn_projecttaskstatususer_PrincipalObjectAttributeAccesses

See msdyn_projecttaskstatususer Entity [msdyn_projecttaskstatususer_PrincipalObjectAttributeAccesses](msdyn_projecttaskstatususer.md#BKMK_msdyn_projecttaskstatususer_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_projectteam_PrincipalObjectAttributeAccesses"></a> msdyn_projectteam_PrincipalObjectAttributeAccesses

See msdyn_projectteam Entity [msdyn_projectteam_PrincipalObjectAttributeAccesses](msdyn_projectteam.md#BKMK_msdyn_projectteam_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_projectteammembersignup_PrincipalObjectAttributeAccesses"></a> msdyn_projectteammembersignup_PrincipalObjectAttributeAccesses

See msdyn_projectteammembersignup Entity [msdyn_projectteammembersignup_PrincipalObjectAttributeAccesses](msdyn_projectteammembersignup.md#BKMK_msdyn_projectteammembersignup_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_projecttransactioncategory_PrincipalObjectAttributeAccesses"></a> msdyn_projecttransactioncategory_PrincipalObjectAttributeAccesses

See msdyn_projecttransactioncategory Entity [msdyn_projecttransactioncategory_PrincipalObjectAttributeAccesses](msdyn_projecttransactioncategory.md#BKMK_msdyn_projecttransactioncategory_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelineanalyticsbreakdown_PrincipalObjectAttributeAccesses"></a> msdyn_quotelineanalyticsbreakdown_PrincipalObjectAttributeAccesses

See msdyn_quotelineanalyticsbreakdown Entity [msdyn_quotelineanalyticsbreakdown_PrincipalObjectAttributeAccesses](msdyn_quotelineanalyticsbreakdown.md#BKMK_msdyn_quotelineanalyticsbreakdown_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelineinvoiceschedule_PrincipalObjectAttributeAccesses"></a> msdyn_quotelineinvoiceschedule_PrincipalObjectAttributeAccesses

See msdyn_quotelineinvoiceschedule Entity [msdyn_quotelineinvoiceschedule_PrincipalObjectAttributeAccesses](msdyn_quotelineinvoiceschedule.md#BKMK_msdyn_quotelineinvoiceschedule_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelineresourcecategory_PrincipalObjectAttributeAccesses"></a> msdyn_quotelineresourcecategory_PrincipalObjectAttributeAccesses

See msdyn_quotelineresourcecategory Entity [msdyn_quotelineresourcecategory_PrincipalObjectAttributeAccesses](msdyn_quotelineresourcecategory.md#BKMK_msdyn_quotelineresourcecategory_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelinescheduleofvalue_PrincipalObjectAttributeAccesses"></a> msdyn_quotelinescheduleofvalue_PrincipalObjectAttributeAccesses

See msdyn_quotelinescheduleofvalue Entity [msdyn_quotelinescheduleofvalue_PrincipalObjectAttributeAccesses](msdyn_quotelinescheduleofvalue.md#BKMK_msdyn_quotelinescheduleofvalue_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelinetransaction_PrincipalObjectAttributeAccesses"></a> msdyn_quotelinetransaction_PrincipalObjectAttributeAccesses

See msdyn_quotelinetransaction Entity [msdyn_quotelinetransaction_PrincipalObjectAttributeAccesses](msdyn_quotelinetransaction.md#BKMK_msdyn_quotelinetransaction_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelinetransactioncategory_PrincipalObjectAttributeAccesses"></a> msdyn_quotelinetransactioncategory_PrincipalObjectAttributeAccesses

See msdyn_quotelinetransactioncategory Entity [msdyn_quotelinetransactioncategory_PrincipalObjectAttributeAccesses](msdyn_quotelinetransactioncategory.md#BKMK_msdyn_quotelinetransactioncategory_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_quotelinetransactionclassification_PrincipalObjectAttributeAccesses"></a> msdyn_quotelinetransactionclassification_PrincipalObjectAttributeAccesses

See msdyn_quotelinetransactionclassification Entity [msdyn_quotelinetransactionclassification_PrincipalObjectAttributeAccesses](msdyn_quotelinetransactionclassification.md#BKMK_msdyn_quotelinetransactionclassification_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_quotepricelist_PrincipalObjectAttributeAccesses"></a> msdyn_quotepricelist_PrincipalObjectAttributeAccesses

See msdyn_quotepricelist Entity [msdyn_quotepricelist_PrincipalObjectAttributeAccesses](msdyn_quotepricelist.md#BKMK_msdyn_quotepricelist_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_resourceassignment_PrincipalObjectAttributeAccesses"></a> msdyn_resourceassignment_PrincipalObjectAttributeAccesses

See msdyn_resourceassignment Entity [msdyn_resourceassignment_PrincipalObjectAttributeAccesses](msdyn_resourceassignment.md#BKMK_msdyn_resourceassignment_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_resourceassignmentdetail_PrincipalObjectAttributeAccesses"></a> msdyn_resourceassignmentdetail_PrincipalObjectAttributeAccesses

See msdyn_resourceassignmentdetail Entity [msdyn_resourceassignmentdetail_PrincipalObjectAttributeAccesses](msdyn_resourceassignmentdetail.md#BKMK_msdyn_resourceassignmentdetail_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcecategorypricelevel_PrincipalObjectAttributeAccesses"></a> msdyn_resourcecategorypricelevel_PrincipalObjectAttributeAccesses

See msdyn_resourcecategorypricelevel Entity [msdyn_resourcecategorypricelevel_PrincipalObjectAttributeAccesses](msdyn_resourcecategorypricelevel.md#BKMK_msdyn_resourcecategorypricelevel_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcerequest_PrincipalObjectAttributeAccesses"></a> msdyn_resourcerequest_PrincipalObjectAttributeAccesses

See msdyn_resourcerequest Entity [msdyn_resourcerequest_PrincipalObjectAttributeAccesses](msdyn_resourcerequest.md#BKMK_msdyn_resourcerequest_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_rolecompetencyrequirement_PrincipalObjectAttributeAccesses"></a> msdyn_rolecompetencyrequirement_PrincipalObjectAttributeAccesses

See msdyn_rolecompetencyrequirement Entity [msdyn_rolecompetencyrequirement_PrincipalObjectAttributeAccesses](msdyn_rolecompetencyrequirement.md#BKMK_msdyn_rolecompetencyrequirement_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_roleutilization_PrincipalObjectAttributeAccesses"></a> msdyn_roleutilization_PrincipalObjectAttributeAccesses

See msdyn_roleutilization Entity [msdyn_roleutilization_PrincipalObjectAttributeAccesses](msdyn_roleutilization.md#BKMK_msdyn_roleutilization_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_timeentry_PrincipalObjectAttributeAccesses"></a> msdyn_timeentry_PrincipalObjectAttributeAccesses

See msdyn_timeentry Entity [msdyn_timeentry_PrincipalObjectAttributeAccesses](msdyn_timeentry.md#BKMK_msdyn_timeentry_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_timeoffcalendar_PrincipalObjectAttributeAccesses"></a> msdyn_timeoffcalendar_PrincipalObjectAttributeAccesses

See msdyn_timeoffcalendar Entity [msdyn_timeoffcalendar_PrincipalObjectAttributeAccesses](msdyn_timeoffcalendar.md#BKMK_msdyn_timeoffcalendar_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_transactioncategory_PrincipalObjectAttributeAccesses"></a> msdyn_transactioncategory_PrincipalObjectAttributeAccesses

See msdyn_transactioncategory Entity [msdyn_transactioncategory_PrincipalObjectAttributeAccesses](msdyn_transactioncategory.md#BKMK_msdyn_transactioncategory_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_transactioncategoryclassification_PrincipalObjectAttributeAccesses"></a> msdyn_transactioncategoryclassification_PrincipalObjectAttributeAccesses

See msdyn_transactioncategoryclassification Entity [msdyn_transactioncategoryclassification_PrincipalObjectAttributeAccesses](msdyn_transactioncategoryclassification.md#BKMK_msdyn_transactioncategoryclassification_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_transactioncategoryhierarchyelement_PrincipalObjectAttributeAccesses"></a> msdyn_transactioncategoryhierarchyelement_PrincipalObjectAttributeAccesses

See msdyn_transactioncategoryhierarchyelement Entity [msdyn_transactioncategoryhierarchyelement_PrincipalObjectAttributeAccesses](msdyn_transactioncategoryhierarchyelement.md#BKMK_msdyn_transactioncategoryhierarchyelement_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_transactioncategorypricelevel_PrincipalObjectAttributeAccesses"></a> msdyn_transactioncategorypricelevel_PrincipalObjectAttributeAccesses

See msdyn_transactioncategorypricelevel Entity [msdyn_transactioncategorypricelevel_PrincipalObjectAttributeAccesses](msdyn_transactioncategorypricelevel.md#BKMK_msdyn_transactioncategorypricelevel_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_transactionconnection_PrincipalObjectAttributeAccesses"></a> msdyn_transactionconnection_PrincipalObjectAttributeAccesses

See msdyn_transactionconnection Entity [msdyn_transactionconnection_PrincipalObjectAttributeAccesses](msdyn_transactionconnection.md#BKMK_msdyn_transactionconnection_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_transactiontype_PrincipalObjectAttributeAccesses"></a> msdyn_transactiontype_PrincipalObjectAttributeAccesses

See msdyn_transactiontype Entity [msdyn_transactiontype_PrincipalObjectAttributeAccesses](msdyn_transactiontype.md#BKMK_msdyn_transactiontype_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_userworkhistory_PrincipalObjectAttributeAccesses"></a> msdyn_userworkhistory_PrincipalObjectAttributeAccesses

See msdyn_userworkhistory Entity [msdyn_userworkhistory_PrincipalObjectAttributeAccesses](msdyn_userworkhistory.md#BKMK_msdyn_userworkhistory_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_agreement_PrincipalObjectAttributeAccesses"></a> msdyn_agreement_PrincipalObjectAttributeAccesses

See msdyn_agreement Entity [msdyn_agreement_PrincipalObjectAttributeAccesses](msdyn_agreement.md#BKMK_msdyn_agreement_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingdate_PrincipalObjectAttributeAccesses"></a> msdyn_agreementbookingdate_PrincipalObjectAttributeAccesses

See msdyn_agreementbookingdate Entity [msdyn_agreementbookingdate_PrincipalObjectAttributeAccesses](msdyn_agreementbookingdate.md#BKMK_msdyn_agreementbookingdate_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingincident_PrincipalObjectAttributeAccesses"></a> msdyn_agreementbookingincident_PrincipalObjectAttributeAccesses

See msdyn_agreementbookingincident Entity [msdyn_agreementbookingincident_PrincipalObjectAttributeAccesses](msdyn_agreementbookingincident.md#BKMK_msdyn_agreementbookingincident_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingproduct_PrincipalObjectAttributeAccesses"></a> msdyn_agreementbookingproduct_PrincipalObjectAttributeAccesses

See msdyn_agreementbookingproduct Entity [msdyn_agreementbookingproduct_PrincipalObjectAttributeAccesses](msdyn_agreementbookingproduct.md#BKMK_msdyn_agreementbookingproduct_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservice_PrincipalObjectAttributeAccesses"></a> msdyn_agreementbookingservice_PrincipalObjectAttributeAccesses

See msdyn_agreementbookingservice Entity [msdyn_agreementbookingservice_PrincipalObjectAttributeAccesses](msdyn_agreementbookingservice.md#BKMK_msdyn_agreementbookingservice_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingservicetask_PrincipalObjectAttributeAccesses"></a> msdyn_agreementbookingservicetask_PrincipalObjectAttributeAccesses

See msdyn_agreementbookingservicetask Entity [msdyn_agreementbookingservicetask_PrincipalObjectAttributeAccesses](msdyn_agreementbookingservicetask.md#BKMK_msdyn_agreementbookingservicetask_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementbookingsetup_PrincipalObjectAttributeAccesses"></a> msdyn_agreementbookingsetup_PrincipalObjectAttributeAccesses

See msdyn_agreementbookingsetup Entity [msdyn_agreementbookingsetup_PrincipalObjectAttributeAccesses](msdyn_agreementbookingsetup.md#BKMK_msdyn_agreementbookingsetup_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicedate_PrincipalObjectAttributeAccesses"></a> msdyn_agreementinvoicedate_PrincipalObjectAttributeAccesses

See msdyn_agreementinvoicedate Entity [msdyn_agreementinvoicedate_PrincipalObjectAttributeAccesses](msdyn_agreementinvoicedate.md#BKMK_msdyn_agreementinvoicedate_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoiceproduct_PrincipalObjectAttributeAccesses"></a> msdyn_agreementinvoiceproduct_PrincipalObjectAttributeAccesses

See msdyn_agreementinvoiceproduct Entity [msdyn_agreementinvoiceproduct_PrincipalObjectAttributeAccesses](msdyn_agreementinvoiceproduct.md#BKMK_msdyn_agreementinvoiceproduct_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementinvoicesetup_PrincipalObjectAttributeAccesses"></a> msdyn_agreementinvoicesetup_PrincipalObjectAttributeAccesses

See msdyn_agreementinvoicesetup Entity [msdyn_agreementinvoicesetup_PrincipalObjectAttributeAccesses](msdyn_agreementinvoicesetup.md#BKMK_msdyn_agreementinvoicesetup_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_agreementsubstatus_PrincipalObjectAttributeAccesses"></a> msdyn_agreementsubstatus_PrincipalObjectAttributeAccesses

See msdyn_agreementsubstatus Entity [msdyn_agreementsubstatus_PrincipalObjectAttributeAccesses](msdyn_agreementsubstatus.md#BKMK_msdyn_agreementsubstatus_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingjournal_PrincipalObjectAttributeAccesses"></a> msdyn_bookingjournal_PrincipalObjectAttributeAccesses

See msdyn_bookingjournal Entity [msdyn_bookingjournal_PrincipalObjectAttributeAccesses](msdyn_bookingjournal.md#BKMK_msdyn_bookingjournal_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_bookingtimestamp_PrincipalObjectAttributeAccesses"></a> msdyn_bookingtimestamp_PrincipalObjectAttributeAccesses

See msdyn_bookingtimestamp Entity [msdyn_bookingtimestamp_PrincipalObjectAttributeAccesses](msdyn_bookingtimestamp.md#BKMK_msdyn_bookingtimestamp_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_PrincipalObjectAttributeAccesses"></a> msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_PrincipalObjectAttributeAccesses

See msdyn_bpf_2c5fe86acc8b414b8322ae571000c799 Entity [msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_PrincipalObjectAttributeAccesses](msdyn_bpf_2c5fe86acc8b414b8322ae571000c799.md#BKMK_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_989e9b1857e24af18787d5143b67523b_PrincipalObjectAttributeAccesses"></a> msdyn_bpf_989e9b1857e24af18787d5143b67523b_PrincipalObjectAttributeAccesses

See msdyn_bpf_989e9b1857e24af18787d5143b67523b Entity [msdyn_bpf_989e9b1857e24af18787d5143b67523b_PrincipalObjectAttributeAccesses](msdyn_bpf_989e9b1857e24af18787d5143b67523b.md#BKMK_msdyn_bpf_989e9b1857e24af18787d5143b67523b_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_PrincipalObjectAttributeAccesses"></a> msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_PrincipalObjectAttributeAccesses

See msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3 Entity [msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_PrincipalObjectAttributeAccesses](msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3.md#BKMK_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_PrincipalObjectAttributeAccesses"></a> msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_PrincipalObjectAttributeAccesses

See msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39 Entity [msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_PrincipalObjectAttributeAccesses](msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39.md#BKMK_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_customerasset_PrincipalObjectAttributeAccesses"></a> msdyn_customerasset_PrincipalObjectAttributeAccesses

See msdyn_customerasset Entity [msdyn_customerasset_PrincipalObjectAttributeAccesses](msdyn_customerasset.md#BKMK_msdyn_customerasset_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldservicepricelistitem_PrincipalObjectAttributeAccesses"></a> msdyn_fieldservicepricelistitem_PrincipalObjectAttributeAccesses

See msdyn_fieldservicepricelistitem Entity [msdyn_fieldservicepricelistitem_PrincipalObjectAttributeAccesses](msdyn_fieldservicepricelistitem.md#BKMK_msdyn_fieldservicepricelistitem_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldservicesetting_PrincipalObjectAttributeAccesses"></a> msdyn_fieldservicesetting_PrincipalObjectAttributeAccesses

See msdyn_fieldservicesetting Entity [msdyn_fieldservicesetting_PrincipalObjectAttributeAccesses](msdyn_fieldservicesetting.md#BKMK_msdyn_fieldservicesetting_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_fieldservicesystemjob_PrincipalObjectAttributeAccesses"></a> msdyn_fieldservicesystemjob_PrincipalObjectAttributeAccesses

See msdyn_fieldservicesystemjob Entity [msdyn_fieldservicesystemjob_PrincipalObjectAttributeAccesses](msdyn_fieldservicesystemjob.md#BKMK_msdyn_fieldservicesystemjob_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttype_PrincipalObjectAttributeAccesses"></a> msdyn_incidenttype_PrincipalObjectAttributeAccesses

See msdyn_incidenttype Entity [msdyn_incidenttype_PrincipalObjectAttributeAccesses](msdyn_incidenttype.md#BKMK_msdyn_incidenttype_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypecharacteristic_PrincipalObjectAttributeAccesses"></a> msdyn_incidenttypecharacteristic_PrincipalObjectAttributeAccesses

See msdyn_incidenttypecharacteristic Entity [msdyn_incidenttypecharacteristic_PrincipalObjectAttributeAccesses](msdyn_incidenttypecharacteristic.md#BKMK_msdyn_incidenttypecharacteristic_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeproduct_PrincipalObjectAttributeAccesses"></a> msdyn_incidenttypeproduct_PrincipalObjectAttributeAccesses

See msdyn_incidenttypeproduct Entity [msdyn_incidenttypeproduct_PrincipalObjectAttributeAccesses](msdyn_incidenttypeproduct.md#BKMK_msdyn_incidenttypeproduct_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeservice_PrincipalObjectAttributeAccesses"></a> msdyn_incidenttypeservice_PrincipalObjectAttributeAccesses

See msdyn_incidenttypeservice Entity [msdyn_incidenttypeservice_PrincipalObjectAttributeAccesses](msdyn_incidenttypeservice.md#BKMK_msdyn_incidenttypeservice_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_incidenttypeservicetask_PrincipalObjectAttributeAccesses"></a> msdyn_incidenttypeservicetask_PrincipalObjectAttributeAccesses

See msdyn_incidenttypeservicetask Entity [msdyn_incidenttypeservicetask_PrincipalObjectAttributeAccesses](msdyn_incidenttypeservicetask.md#BKMK_msdyn_incidenttypeservicetask_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustment_PrincipalObjectAttributeAccesses"></a> msdyn_inventoryadjustment_PrincipalObjectAttributeAccesses

See msdyn_inventoryadjustment Entity [msdyn_inventoryadjustment_PrincipalObjectAttributeAccesses](msdyn_inventoryadjustment.md#BKMK_msdyn_inventoryadjustment_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryadjustmentproduct_PrincipalObjectAttributeAccesses"></a> msdyn_inventoryadjustmentproduct_PrincipalObjectAttributeAccesses

See msdyn_inventoryadjustmentproduct Entity [msdyn_inventoryadjustmentproduct_PrincipalObjectAttributeAccesses](msdyn_inventoryadjustmentproduct.md#BKMK_msdyn_inventoryadjustmentproduct_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_inventoryjournal_PrincipalObjectAttributeAccesses"></a> msdyn_inventoryjournal_PrincipalObjectAttributeAccesses

See msdyn_inventoryjournal Entity [msdyn_inventoryjournal_PrincipalObjectAttributeAccesses](msdyn_inventoryjournal.md#BKMK_msdyn_inventoryjournal_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_inventorytransfer_PrincipalObjectAttributeAccesses"></a> msdyn_inventorytransfer_PrincipalObjectAttributeAccesses

See msdyn_inventorytransfer Entity [msdyn_inventorytransfer_PrincipalObjectAttributeAccesses](msdyn_inventorytransfer.md#BKMK_msdyn_inventorytransfer_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_orderinvoicingdate_PrincipalObjectAttributeAccesses"></a> msdyn_orderinvoicingdate_PrincipalObjectAttributeAccesses

See msdyn_orderinvoicingdate Entity [msdyn_orderinvoicingdate_PrincipalObjectAttributeAccesses](msdyn_orderinvoicingdate.md#BKMK_msdyn_orderinvoicingdate_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_orderinvoicingproduct_PrincipalObjectAttributeAccesses"></a> msdyn_orderinvoicingproduct_PrincipalObjectAttributeAccesses

See msdyn_orderinvoicingproduct Entity [msdyn_orderinvoicingproduct_PrincipalObjectAttributeAccesses](msdyn_orderinvoicingproduct.md#BKMK_msdyn_orderinvoicingproduct_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_orderinvoicingsetup_PrincipalObjectAttributeAccesses"></a> msdyn_orderinvoicingsetup_PrincipalObjectAttributeAccesses

See msdyn_orderinvoicingsetup Entity [msdyn_orderinvoicingsetup_PrincipalObjectAttributeAccesses](msdyn_orderinvoicingsetup.md#BKMK_msdyn_orderinvoicingsetup_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_orderinvoicingsetupdate_PrincipalObjectAttributeAccesses"></a> msdyn_orderinvoicingsetupdate_PrincipalObjectAttributeAccesses

See msdyn_orderinvoicingsetupdate Entity [msdyn_orderinvoicingsetupdate_PrincipalObjectAttributeAccesses](msdyn_orderinvoicingsetupdate.md#BKMK_msdyn_orderinvoicingsetupdate_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_payment_PrincipalObjectAttributeAccesses"></a> msdyn_payment_PrincipalObjectAttributeAccesses

See msdyn_payment Entity [msdyn_payment_PrincipalObjectAttributeAccesses](msdyn_payment.md#BKMK_msdyn_payment_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentdetail_PrincipalObjectAttributeAccesses"></a> msdyn_paymentdetail_PrincipalObjectAttributeAccesses

See msdyn_paymentdetail Entity [msdyn_paymentdetail_PrincipalObjectAttributeAccesses](msdyn_paymentdetail.md#BKMK_msdyn_paymentdetail_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentmethod_PrincipalObjectAttributeAccesses"></a> msdyn_paymentmethod_PrincipalObjectAttributeAccesses

See msdyn_paymentmethod Entity [msdyn_paymentmethod_PrincipalObjectAttributeAccesses](msdyn_paymentmethod.md#BKMK_msdyn_paymentmethod_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_paymentterm_PrincipalObjectAttributeAccesses"></a> msdyn_paymentterm_PrincipalObjectAttributeAccesses

See msdyn_paymentterm Entity [msdyn_paymentterm_PrincipalObjectAttributeAccesses](msdyn_paymentterm.md#BKMK_msdyn_paymentterm_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_postalcode_PrincipalObjectAttributeAccesses"></a> msdyn_postalcode_PrincipalObjectAttributeAccesses

See msdyn_postalcode Entity [msdyn_postalcode_PrincipalObjectAttributeAccesses](msdyn_postalcode.md#BKMK_msdyn_postalcode_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_productinventory_PrincipalObjectAttributeAccesses"></a> msdyn_productinventory_PrincipalObjectAttributeAccesses

See msdyn_productinventory Entity [msdyn_productinventory_PrincipalObjectAttributeAccesses](msdyn_productinventory.md#BKMK_msdyn_productinventory_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorder_PrincipalObjectAttributeAccesses"></a> msdyn_purchaseorder_PrincipalObjectAttributeAccesses

See msdyn_purchaseorder Entity [msdyn_purchaseorder_PrincipalObjectAttributeAccesses](msdyn_purchaseorder.md#BKMK_msdyn_purchaseorder_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderbill_PrincipalObjectAttributeAccesses"></a> msdyn_purchaseorderbill_PrincipalObjectAttributeAccesses

See msdyn_purchaseorderbill Entity [msdyn_purchaseorderbill_PrincipalObjectAttributeAccesses](msdyn_purchaseorderbill.md#BKMK_msdyn_purchaseorderbill_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderproduct_PrincipalObjectAttributeAccesses"></a> msdyn_purchaseorderproduct_PrincipalObjectAttributeAccesses

See msdyn_purchaseorderproduct Entity [msdyn_purchaseorderproduct_PrincipalObjectAttributeAccesses](msdyn_purchaseorderproduct.md#BKMK_msdyn_purchaseorderproduct_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceipt_PrincipalObjectAttributeAccesses"></a> msdyn_purchaseorderreceipt_PrincipalObjectAttributeAccesses

See msdyn_purchaseorderreceipt Entity [msdyn_purchaseorderreceipt_PrincipalObjectAttributeAccesses](msdyn_purchaseorderreceipt.md#BKMK_msdyn_purchaseorderreceipt_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseorderreceiptproduct_PrincipalObjectAttributeAccesses"></a> msdyn_purchaseorderreceiptproduct_PrincipalObjectAttributeAccesses

See msdyn_purchaseorderreceiptproduct Entity [msdyn_purchaseorderreceiptproduct_PrincipalObjectAttributeAccesses](msdyn_purchaseorderreceiptproduct.md#BKMK_msdyn_purchaseorderreceiptproduct_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_purchaseordersubstatus_PrincipalObjectAttributeAccesses"></a> msdyn_purchaseordersubstatus_PrincipalObjectAttributeAccesses

See msdyn_purchaseordersubstatus Entity [msdyn_purchaseordersubstatus_PrincipalObjectAttributeAccesses](msdyn_purchaseordersubstatus.md#BKMK_msdyn_purchaseordersubstatus_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingincident_PrincipalObjectAttributeAccesses"></a> msdyn_quotebookingincident_PrincipalObjectAttributeAccesses

See msdyn_quotebookingincident Entity [msdyn_quotebookingincident_PrincipalObjectAttributeAccesses](msdyn_quotebookingincident.md#BKMK_msdyn_quotebookingincident_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingproduct_PrincipalObjectAttributeAccesses"></a> msdyn_quotebookingproduct_PrincipalObjectAttributeAccesses

See msdyn_quotebookingproduct Entity [msdyn_quotebookingproduct_PrincipalObjectAttributeAccesses](msdyn_quotebookingproduct.md#BKMK_msdyn_quotebookingproduct_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservice_PrincipalObjectAttributeAccesses"></a> msdyn_quotebookingservice_PrincipalObjectAttributeAccesses

See msdyn_quotebookingservice Entity [msdyn_quotebookingservice_PrincipalObjectAttributeAccesses](msdyn_quotebookingservice.md#BKMK_msdyn_quotebookingservice_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingservicetask_PrincipalObjectAttributeAccesses"></a> msdyn_quotebookingservicetask_PrincipalObjectAttributeAccesses

See msdyn_quotebookingservicetask Entity [msdyn_quotebookingservicetask_PrincipalObjectAttributeAccesses](msdyn_quotebookingservicetask.md#BKMK_msdyn_quotebookingservicetask_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_quotebookingsetup_PrincipalObjectAttributeAccesses"></a> msdyn_quotebookingsetup_PrincipalObjectAttributeAccesses

See msdyn_quotebookingsetup Entity [msdyn_quotebookingsetup_PrincipalObjectAttributeAccesses](msdyn_quotebookingsetup.md#BKMK_msdyn_quotebookingsetup_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_quoteinvoicingproduct_PrincipalObjectAttributeAccesses"></a> msdyn_quoteinvoicingproduct_PrincipalObjectAttributeAccesses

See msdyn_quoteinvoicingproduct Entity [msdyn_quoteinvoicingproduct_PrincipalObjectAttributeAccesses](msdyn_quoteinvoicingproduct.md#BKMK_msdyn_quoteinvoicingproduct_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_quoteinvoicingsetup_PrincipalObjectAttributeAccesses"></a> msdyn_quoteinvoicingsetup_PrincipalObjectAttributeAccesses

See msdyn_quoteinvoicingsetup Entity [msdyn_quoteinvoicingsetup_PrincipalObjectAttributeAccesses](msdyn_quoteinvoicingsetup.md#BKMK_msdyn_quoteinvoicingsetup_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_resourcepaytype_PrincipalObjectAttributeAccesses"></a> msdyn_resourcepaytype_PrincipalObjectAttributeAccesses

See msdyn_resourcepaytype Entity [msdyn_resourcepaytype_PrincipalObjectAttributeAccesses](msdyn_resourcepaytype.md#BKMK_msdyn_resourcepaytype_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_rma_PrincipalObjectAttributeAccesses"></a> msdyn_rma_PrincipalObjectAttributeAccesses

See msdyn_rma Entity [msdyn_rma_PrincipalObjectAttributeAccesses](msdyn_rma.md#BKMK_msdyn_rma_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_rmaproduct_PrincipalObjectAttributeAccesses"></a> msdyn_rmaproduct_PrincipalObjectAttributeAccesses

See msdyn_rmaproduct Entity [msdyn_rmaproduct_PrincipalObjectAttributeAccesses](msdyn_rmaproduct.md#BKMK_msdyn_rmaproduct_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceipt_PrincipalObjectAttributeAccesses"></a> msdyn_rmareceipt_PrincipalObjectAttributeAccesses

See msdyn_rmareceipt Entity [msdyn_rmareceipt_PrincipalObjectAttributeAccesses](msdyn_rmareceipt.md#BKMK_msdyn_rmareceipt_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_rmareceiptproduct_PrincipalObjectAttributeAccesses"></a> msdyn_rmareceiptproduct_PrincipalObjectAttributeAccesses

See msdyn_rmareceiptproduct Entity [msdyn_rmareceiptproduct_PrincipalObjectAttributeAccesses](msdyn_rmareceiptproduct.md#BKMK_msdyn_rmareceiptproduct_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_rmasubstatus_PrincipalObjectAttributeAccesses"></a> msdyn_rmasubstatus_PrincipalObjectAttributeAccesses

See msdyn_rmasubstatus Entity [msdyn_rmasubstatus_PrincipalObjectAttributeAccesses](msdyn_rmasubstatus.md#BKMK_msdyn_rmasubstatus_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_rtv_PrincipalObjectAttributeAccesses"></a> msdyn_rtv_PrincipalObjectAttributeAccesses

See msdyn_rtv Entity [msdyn_rtv_PrincipalObjectAttributeAccesses](msdyn_rtv.md#BKMK_msdyn_rtv_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvproduct_PrincipalObjectAttributeAccesses"></a> msdyn_rtvproduct_PrincipalObjectAttributeAccesses

See msdyn_rtvproduct Entity [msdyn_rtvproduct_PrincipalObjectAttributeAccesses](msdyn_rtvproduct.md#BKMK_msdyn_rtvproduct_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_rtvsubstatus_PrincipalObjectAttributeAccesses"></a> msdyn_rtvsubstatus_PrincipalObjectAttributeAccesses

See msdyn_rtvsubstatus Entity [msdyn_rtvsubstatus_PrincipalObjectAttributeAccesses](msdyn_rtvsubstatus.md#BKMK_msdyn_rtvsubstatus_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_servicetasktype_PrincipalObjectAttributeAccesses"></a> msdyn_servicetasktype_PrincipalObjectAttributeAccesses

See msdyn_servicetasktype Entity [msdyn_servicetasktype_PrincipalObjectAttributeAccesses](msdyn_servicetasktype.md#BKMK_msdyn_servicetasktype_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_shipvia_PrincipalObjectAttributeAccesses"></a> msdyn_shipvia_PrincipalObjectAttributeAccesses

See msdyn_shipvia Entity [msdyn_shipvia_PrincipalObjectAttributeAccesses](msdyn_shipvia.md#BKMK_msdyn_shipvia_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_taxcode_PrincipalObjectAttributeAccesses"></a> msdyn_taxcode_PrincipalObjectAttributeAccesses

See msdyn_taxcode Entity [msdyn_taxcode_PrincipalObjectAttributeAccesses](msdyn_taxcode.md#BKMK_msdyn_taxcode_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_taxcodedetail_PrincipalObjectAttributeAccesses"></a> msdyn_taxcodedetail_PrincipalObjectAttributeAccesses

See msdyn_taxcodedetail Entity [msdyn_taxcodedetail_PrincipalObjectAttributeAccesses](msdyn_taxcodedetail.md#BKMK_msdyn_taxcodedetail_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_timeoffrequest_PrincipalObjectAttributeAccesses"></a> msdyn_timeoffrequest_PrincipalObjectAttributeAccesses

See msdyn_timeoffrequest Entity [msdyn_timeoffrequest_PrincipalObjectAttributeAccesses](msdyn_timeoffrequest.md#BKMK_msdyn_timeoffrequest_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_uniquenumber_PrincipalObjectAttributeAccesses"></a> msdyn_uniquenumber_PrincipalObjectAttributeAccesses

See msdyn_uniquenumber Entity [msdyn_uniquenumber_PrincipalObjectAttributeAccesses](msdyn_uniquenumber.md#BKMK_msdyn_uniquenumber_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_warehouse_PrincipalObjectAttributeAccesses"></a> msdyn_warehouse_PrincipalObjectAttributeAccesses

See msdyn_warehouse Entity [msdyn_warehouse_PrincipalObjectAttributeAccesses](msdyn_warehouse.md#BKMK_msdyn_warehouse_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_workorder_PrincipalObjectAttributeAccesses"></a> msdyn_workorder_PrincipalObjectAttributeAccesses

See msdyn_workorder Entity [msdyn_workorder_PrincipalObjectAttributeAccesses](msdyn_workorder.md#BKMK_msdyn_workorder_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_workordercharacteristic_PrincipalObjectAttributeAccesses"></a> msdyn_workordercharacteristic_PrincipalObjectAttributeAccesses

See msdyn_workordercharacteristic Entity [msdyn_workordercharacteristic_PrincipalObjectAttributeAccesses](msdyn_workordercharacteristic.md#BKMK_msdyn_workordercharacteristic_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderdetailsgenerationqueue_PrincipalObjectAttributeAccesses"></a> msdyn_workorderdetailsgenerationqueue_PrincipalObjectAttributeAccesses

See msdyn_workorderdetailsgenerationqueue Entity [msdyn_workorderdetailsgenerationqueue_PrincipalObjectAttributeAccesses](msdyn_workorderdetailsgenerationqueue.md#BKMK_msdyn_workorderdetailsgenerationqueue_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderincident_PrincipalObjectAttributeAccesses"></a> msdyn_workorderincident_PrincipalObjectAttributeAccesses

See msdyn_workorderincident Entity [msdyn_workorderincident_PrincipalObjectAttributeAccesses](msdyn_workorderincident.md#BKMK_msdyn_workorderincident_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderproduct_PrincipalObjectAttributeAccesses"></a> msdyn_workorderproduct_PrincipalObjectAttributeAccesses

See msdyn_workorderproduct Entity [msdyn_workorderproduct_PrincipalObjectAttributeAccesses](msdyn_workorderproduct.md#BKMK_msdyn_workorderproduct_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderresourcerestriction_PrincipalObjectAttributeAccesses"></a> msdyn_workorderresourcerestriction_PrincipalObjectAttributeAccesses

See msdyn_workorderresourcerestriction Entity [msdyn_workorderresourcerestriction_PrincipalObjectAttributeAccesses](msdyn_workorderresourcerestriction.md#BKMK_msdyn_workorderresourcerestriction_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservice_PrincipalObjectAttributeAccesses"></a> msdyn_workorderservice_PrincipalObjectAttributeAccesses

See msdyn_workorderservice Entity [msdyn_workorderservice_PrincipalObjectAttributeAccesses](msdyn_workorderservice.md#BKMK_msdyn_workorderservice_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_workorderservicetask_PrincipalObjectAttributeAccesses"></a> msdyn_workorderservicetask_PrincipalObjectAttributeAccesses

See msdyn_workorderservicetask Entity [msdyn_workorderservicetask_PrincipalObjectAttributeAccesses](msdyn_workorderservicetask.md#BKMK_msdyn_workorderservicetask_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_workordersubstatus_PrincipalObjectAttributeAccesses"></a> msdyn_workordersubstatus_PrincipalObjectAttributeAccesses

See msdyn_workordersubstatus Entity [msdyn_workordersubstatus_PrincipalObjectAttributeAccesses](msdyn_workordersubstatus.md#BKMK_msdyn_workordersubstatus_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_msdyn_workordertype_PrincipalObjectAttributeAccesses"></a> msdyn_workordertype_PrincipalObjectAttributeAccesses

See msdyn_workordertype Entity [msdyn_workordertype_PrincipalObjectAttributeAccesses](msdyn_workordertype.md#BKMK_msdyn_workordertype_PrincipalObjectAttributeAccesses) One-To-Many relationship.

### <a name="BKMK_account_principalobjectattributeaccess"></a> account_principalobjectattributeaccess

See account Entity [account_principalobjectattributeaccess](account.md#BKMK_account_principalobjectattributeaccess) One-To-Many relationship.

### <a name="BKMK_contact_principalobjectattributeaccess"></a> contact_principalobjectattributeaccess

See contact Entity [contact_principalobjectattributeaccess](contact.md#BKMK_contact_principalobjectattributeaccess) One-To-Many relationship.

### <a name="BKMK_lk_principalobjectattributeaccess_organizationid"></a> lk_principalobjectattributeaccess_organizationid

See organization Entity [lk_principalobjectattributeaccess_organizationid](organization.md#BKMK_lk_principalobjectattributeaccess_organizationid) One-To-Many relationship.

### <a name="BKMK_team_principalobjectattributeaccess_principalid"></a> team_principalobjectattributeaccess_principalid

See team Entity [team_principalobjectattributeaccess_principalid](team.md#BKMK_team_principalobjectattributeaccess_principalid) One-To-Many relationship.

### <a name="BKMK_systemuser_principalobjectattributeaccess_principalid"></a> systemuser_principalobjectattributeaccess_principalid

See systemuser Entity [systemuser_principalobjectattributeaccess_principalid](systemuser.md#BKMK_systemuser_principalobjectattributeaccess_principalid) One-To-Many relationship.

### <a name="BKMK_knowledgearticle_PrincipalObjectAttributeAccess"></a> knowledgearticle_PrincipalObjectAttributeAccess

See knowledgearticle Entity [knowledgearticle_PrincipalObjectAttributeAccess](knowledgearticle.md#BKMK_knowledgearticle_PrincipalObjectAttributeAccess) One-To-Many relationship.

### <a name="BKMK_channelaccessprofile_PrincipalObjectAttributeAccess"></a> channelaccessprofile_PrincipalObjectAttributeAccess

See channelaccessprofile Entity [channelaccessprofile_PrincipalObjectAttributeAccess](channelaccessprofile.md#BKMK_channelaccessprofile_PrincipalObjectAttributeAccess) One-To-Many relationship.

### <a name="BKMK_KnowledgeBaseRecord_PrincipalObjectAttributeAccess"></a> KnowledgeBaseRecord_PrincipalObjectAttributeAccess

See knowledgebaserecord Entity [KnowledgeBaseRecord_PrincipalObjectAttributeAccess](knowledgebaserecord.md#BKMK_KnowledgeBaseRecord_PrincipalObjectAttributeAccess) One-To-Many relationship.

### <a name="BKMK_team_principalobjectattributeaccess"></a> team_principalobjectattributeaccess

See team Entity [team_principalobjectattributeaccess](team.md#BKMK_team_principalobjectattributeaccess) One-To-Many relationship.

### <a name="BKMK_reportcategory_principalobjectattributeaccess"></a> reportcategory_principalobjectattributeaccess

See reportcategory Entity [reportcategory_principalobjectattributeaccess](reportcategory.md#BKMK_reportcategory_principalobjectattributeaccess) One-To-Many relationship.

### <a name="BKMK_mailmergetemplate_principalobjectattributeaccess"></a> mailmergetemplate_principalobjectattributeaccess

See mailmergetemplate Entity [mailmergetemplate_principalobjectattributeaccess](mailmergetemplate.md#BKMK_mailmergetemplate_principalobjectattributeaccess) One-To-Many relationship.

### <a name="BKMK_fax_principalobjectattributeaccess"></a> fax_principalobjectattributeaccess

See fax Entity [fax_principalobjectattributeaccess](fax.md#BKMK_fax_principalobjectattributeaccess) One-To-Many relationship.

### <a name="BKMK_socialactivity_principalobjectattributeaccess"></a> socialactivity_principalobjectattributeaccess

See socialactivity Entity [socialactivity_principalobjectattributeaccess](socialactivity.md#BKMK_socialactivity_principalobjectattributeaccess) One-To-Many relationship.

### <a name="BKMK_kbarticle_principalobjectattributeaccess"></a> kbarticle_principalobjectattributeaccess

See kbarticle Entity [kbarticle_principalobjectattributeaccess](kbarticle.md#BKMK_kbarticle_principalobjectattributeaccess) One-To-Many relationship.

### <a name="BKMK_phonecall_principalobjectattributeaccess"></a> phonecall_principalobjectattributeaccess

See phonecall Entity [phonecall_principalobjectattributeaccess](phonecall.md#BKMK_phonecall_principalobjectattributeaccess) One-To-Many relationship.

### <a name="BKMK_position_principalobjectattributeaccess"></a> position_principalobjectattributeaccess

See position Entity [position_principalobjectattributeaccess](position.md#BKMK_position_principalobjectattributeaccess) One-To-Many relationship.

### <a name="BKMK_customeraddress_principalobjectattributeaccess"></a> customeraddress_principalobjectattributeaccess

See customeraddress Entity [customeraddress_principalobjectattributeaccess](customeraddress.md#BKMK_customeraddress_principalobjectattributeaccess) One-To-Many relationship.

### <a name="BKMK_sharepointsite_principalobjectattributeaccess"></a> sharepointsite_principalobjectattributeaccess

See sharepointsite Entity [sharepointsite_principalobjectattributeaccess](sharepointsite.md#BKMK_sharepointsite_principalobjectattributeaccess) One-To-Many relationship.

### <a name="BKMK_systemuser_principalobjectattributeaccess"></a> systemuser_principalobjectattributeaccess

See systemuser Entity [systemuser_principalobjectattributeaccess](systemuser.md#BKMK_systemuser_principalobjectattributeaccess) One-To-Many relationship.

### <a name="BKMK_connection_principalobjectattributeaccess"></a> connection_principalobjectattributeaccess

See connection Entity [connection_principalobjectattributeaccess](connection.md#BKMK_connection_principalobjectattributeaccess) One-To-Many relationship.

### <a name="BKMK_appointment_principalobjectattributeaccess"></a> appointment_principalobjectattributeaccess

See appointment Entity [appointment_principalobjectattributeaccess](appointment.md#BKMK_appointment_principalobjectattributeaccess) One-To-Many relationship.

### <a name="BKMK_goal_principalobjectattributeaccess"></a> goal_principalobjectattributeaccess

See goal Entity [goal_principalobjectattributeaccess](goal.md#BKMK_goal_principalobjectattributeaccess) One-To-Many relationship.

### <a name="BKMK_email_principalobjectattributeaccess"></a> email_principalobjectattributeaccess

See email Entity [email_principalobjectattributeaccess](email.md#BKMK_email_principalobjectattributeaccess) One-To-Many relationship.

### <a name="BKMK_knowledgearticleview_principalobjectattributeaccess"></a> knowledgearticleview_principalobjectattributeaccess

See knowledgearticleviews Entity [knowledgearticleview_principalobjectattributeaccess](knowledgearticleviews.md#BKMK_knowledgearticleview_principalobjectattributeaccess) One-To-Many relationship.

### <a name="BKMK_feedback_principalobjectattributeaccess"></a> feedback_principalobjectattributeaccess

See feedback Entity [feedback_principalobjectattributeaccess](feedback.md#BKMK_feedback_principalobjectattributeaccess) One-To-Many relationship.

### <a name="BKMK_businessunit_principalobjectattributeaccess"></a> businessunit_principalobjectattributeaccess

See businessunit Entity [businessunit_principalobjectattributeaccess](businessunit.md#BKMK_businessunit_principalobjectattributeaccess) One-To-Many relationship.

### <a name="BKMK_sharepointdocumentlocation_principalobjectattributeaccess"></a> sharepointdocumentlocation_principalobjectattributeaccess

See sharepointdocumentlocation Entity [sharepointdocumentlocation_principalobjectattributeaccess](sharepointdocumentlocation.md#BKMK_sharepointdocumentlocation_principalobjectattributeaccess) One-To-Many relationship.

### <a name="BKMK_queueitem_principalobjectattributeaccess"></a> queueitem_principalobjectattributeaccess

See queueitem Entity [queueitem_principalobjectattributeaccess](queueitem.md#BKMK_queueitem_principalobjectattributeaccess) One-To-Many relationship.

### <a name="BKMK_queue_principalobjectattributeaccess"></a> queue_principalobjectattributeaccess

See queue Entity [queue_principalobjectattributeaccess](queue.md#BKMK_queue_principalobjectattributeaccess) One-To-Many relationship.

### <a name="BKMK_recurringappointmentmaster_principalobjectattributeaccess"></a> recurringappointmentmaster_principalobjectattributeaccess

See recurringappointmentmaster Entity [recurringappointmentmaster_principalobjectattributeaccess](recurringappointmentmaster.md#BKMK_recurringappointmentmaster_principalobjectattributeaccess) One-To-Many relationship.

### <a name="BKMK_task_principalobjectattributeaccess"></a> task_principalobjectattributeaccess

See task Entity [task_principalobjectattributeaccess](task.md#BKMK_task_principalobjectattributeaccess) One-To-Many relationship.

### <a name="BKMK_letter_principalobjectattributeaccess"></a> letter_principalobjectattributeaccess

See letter Entity [letter_principalobjectattributeaccess](letter.md#BKMK_letter_principalobjectattributeaccess) One-To-Many relationship.

### <a name="BKMK_socialprofile_principalobjectattributeaccess"></a> socialprofile_principalobjectattributeaccess

See socialprofile Entity [socialprofile_principalobjectattributeaccess](socialprofile.md#BKMK_socialprofile_principalobjectattributeaccess) One-To-Many relationship.

## See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.principalobjectattributeaccess?text=principalobjectattributeaccess EntityType" />