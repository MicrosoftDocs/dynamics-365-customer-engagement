---
title: "Field Sharing (PrincipalObjectAttributeAccess)  entity reference (Dynamics 365 Customer Engagement) | Microsoft Docs"
description: "Includes schema information and supported messages for the Field Sharing (PrincipalObjectAttributeAccess)  entity."
ms.date: 08/30/2022
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "KumarVivek"
ms.author: "kvivek"
search.audienceType: 
  - developer
---

# Field Sharing (PrincipalObjectAttributeAccess)  entity reference

Defines CRM security principals (users and teams) access rights to secured field for an entity instance.


## Messages

|Message|SDK class or method|
|-|-|
|Create|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*>|
|Delete|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*>|
|Retrieve|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|Update|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|PrincipalObjectAttributeAccesses|
|DisplayCollectionName|Field Sharing|
|DisplayName|Field Sharing|
|EntitySetName|principalobjectattributeaccessset|
|IsBPFEntity|False|
|LogicalCollectionName|principalobjectattributeaccesses|
|LogicalName|principalobjectattributeaccess|
|OwnershipType|OrganizationOwned|
|PrimaryIdAttribute|principalobjectattributeaccessid|
|PrimaryNameAttribute||
|SchemaName|PrincipalObjectAttributeAccess|

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

|Property|Value|
|--------|-----|
|Description|Unique identifier of the shared secured field|
|DisplayName|Secured field|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|attributeid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_ObjectId"></a> ObjectId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the entity instance with shared secured field|
|DisplayName|Entity instance|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|objectid|
|RequiredLevel|SystemRequired|
|Targets|account,accountleads,appointment,bookableresource,bookableresourcebooking,bookableresourcebookingexchangesyncidmapping,bookableresourcebookingheader,bookableresourcecategory,bookableresourcecategoryassn,bookableresourcecharacteristic,bookableresourcegroup,bookingstatus,bulkoperation,bulkoperationlog,businessunit,campaign,campaignactivity,campaignactivityitem,campaignitem,campaignresponse,channelaccessprofile,characteristic,childincidentcount,commitment,competitor,competitoraddress,competitorproduct,competitorsalesliterature,connection,constraintbasedgroup,contact,contactinvoices,contactleads,contactorders,contactquotes,contract,contractdetail,contracttemplate,customeraddress,customeropportunityrole,discount,discounttype,dynamicproperty,dynamicpropertyassociation,dynamicpropertyinstance,dynamicpropertyoptionsetitem,email,entitlement,entitlementchannel,entitlementcontacts,entitlementproducts,entitlementtemplate,entitlementtemplatechannel,entitlementtemplateproducts,equipment,fax,feedback,goal,incident,incidentknowledgebaserecord,incidentresolution,invoice,invoicedetail,kbarticle,knowledgearticle,knowledgearticleincident,knowledgearticleviews,knowledgebaserecord,lead,leadaddress,leadcompetitors,leadproduct,leadtoopportunitysalesprocess,letter,list,listmember,mailmergetemplate,msdyn_postalbum,msdyn_postconfig,msdyn_postruleconfig,msdyn_relationshipinsightsunifiedconfig,msdyn_siconfig,msdyn_wallsavedquery,msdyn_wallsavedqueryusersettings,opportunity,opportunityclose,opportunitycompetitors,opportunityproduct,opportunitysalesprocess,orderclose,phonecall,phonetocaseprocess,position,pricelevel,product,productassociation,productpricelevel,productsalesliterature,productsubstitute,queue,queueitem,quote,quoteclose,quotedetail,ratingmodel,ratingvalue,recurringappointmentmaster,reportcategory,resource,resourcegroup,resourcegroupexpansion,resourcespec,salesliterature,salesliteratureitem,salesorder,salesorderdetail,salesprocessinstance,service,serviceappointment,servicecontractcontacts,sharepointdocumentlocation,sharepointsite,site,socialactivity,socialprofile,systemuser,task,team,territory,topic,topichistory,topicmodel,topicmodelconfiguration,topicmodelexecutionhistory,uom,uomschedule|
|Type|Lookup|


### <a name="BKMK_ObjectTypeCode"></a> ObjectTypeCode

|Property|Value|
|--------|-----|
|Description|Type of the record with shared secured field|
|DisplayName|Entity object type|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|objecttypecode|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_PrincipalId"></a> PrincipalId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the principal to which secured field is shared|
|DisplayName|Principal|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|principalid|
|RequiredLevel|SystemRequired|
|Targets|systemuser,team|
|Type|Lookup|


### <a name="BKMK_PrincipalIdType"></a> PrincipalIdType

|Property|Value|
|--------|-----|
|Description|Type of the principal to which secured field is shared|
|DisplayName|Principal type|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|principalidtype|
|RequiredLevel|SystemRequired|
|Type|EntityName|


### <a name="BKMK_PrincipalObjectAttributeAccessId"></a> PrincipalObjectAttributeAccessId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the shared secured field instance|
|DisplayName|Shared secured field|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|principalobjectattributeaccessid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_ReadAccess"></a> ReadAccess

|Property|Value|
|--------|-----|
|Description|Read permission for secured field instance|
|DisplayName|Read permission|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|readaccess|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### ReadAccess Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0



### <a name="BKMK_UpdateAccess"></a> UpdateAccess

|Property|Value|
|--------|-----|
|Description|Update permission for secured field instance|
|DisplayName|Update permission|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|updateaccess|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### UpdateAccess Choices/Options

|Value|Label|Description|
|-----|-----|--------|
|1|Yes||
|0|No||

**DefaultValue**: 0


<a name="read-only-attributes"></a>

## Read-only attributes

These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [OrganizationId](#BKMK_OrganizationId)
- [OrganizationIdName](#BKMK_OrganizationIdName)
- [PrincipalIdName](#BKMK_PrincipalIdName)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the associated organization.|
|DisplayName|Organization|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationid|
|RequiredLevel|SystemRequired|
|Targets|organization|
|Type|Lookup|


### <a name="BKMK_OrganizationIdName"></a> OrganizationIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationidname|
|MaxLength|160|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_PrincipalIdName"></a> PrincipalIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|principalidname|
|MaxLength|160|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|versionnumber|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [account_principalobjectattributeaccess](#BKMK_account_principalobjectattributeaccess)
- [contact_principalobjectattributeaccess](#BKMK_contact_principalobjectattributeaccess)
- [lk_principalobjectattributeaccess_organizationid](#BKMK_lk_principalobjectattributeaccess_organizationid)
- [team_principalobjectattributeaccess_principalid](#BKMK_team_principalobjectattributeaccess_principalid)
- [systemuser_principalobjectattributeaccess_principalid](#BKMK_systemuser_principalobjectattributeaccess_principalid)
- [knowledgearticle_PrincipalObjectAttributeAccess](#BKMK_knowledgearticle_PrincipalObjectAttributeAccess)
- [territory_principalobjectattributeaccess](#BKMK_territory_principalobjectattributeaccess)
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
- [campaignresponse_principalobjectattributeaccess](#BKMK_campaignresponse_principalobjectattributeaccess)
- [list_principalobjectattributeaccess](#BKMK_list_principalobjectattributeaccess)
- [constraintbasedgroup_PrincipalObjectAttributeAccesses](#BKMK_constraintbasedgroup_PrincipalObjectAttributeAccesses)
- [contract_principalobjectattributeaccess](#BKMK_contract_principalobjectattributeaccess)
- [contractdetail_principalobjectattributeaccess](#BKMK_contractdetail_principalobjectattributeaccess)
- [contracttemplate_PrincipalObjectAttributeAccesses](#BKMK_contracttemplate_PrincipalObjectAttributeAccesses)
- [entitlement_PrincipalObjectAttributeAccesses](#BKMK_entitlement_PrincipalObjectAttributeAccesses)
- [entitlementchannel_PrincipalObjectAttributeAccesses](#BKMK_entitlementchannel_PrincipalObjectAttributeAccesses)
- [entitlementtemplate_PrincipalObjectAttributeAccesses](#BKMK_entitlementtemplate_PrincipalObjectAttributeAccesses)
- [entitlementtemplatechannel_PrincipalObjectAttributeAccesses](#BKMK_entitlementtemplatechannel_PrincipalObjectAttributeAccesses)
- [equipment_principalobjectattributeaccess](#BKMK_equipment_principalobjectattributeaccess)
- [incident_principalobjectattributeaccess](#BKMK_incident_principalobjectattributeaccess)
- [incidentresolution_PrincipalObjectAttributeAccesses](#BKMK_incidentresolution_PrincipalObjectAttributeAccesses)
- [knowledgearticleincident_principalobjectattributeaccess](#BKMK_knowledgearticleincident_principalobjectattributeaccess)
- [phonetocaseprocess_PrincipalObjectAttributeAccesses](#BKMK_phonetocaseprocess_PrincipalObjectAttributeAccesses)
- [resource_PrincipalObjectAttributeAccesses](#BKMK_resource_PrincipalObjectAttributeAccesses)
- [resourcegroup_PrincipalObjectAttributeAccesses](#BKMK_resourcegroup_PrincipalObjectAttributeAccesses)
- [resourcespec_PrincipalObjectAttributeAccesses](#BKMK_resourcespec_PrincipalObjectAttributeAccesses)
- [service_PrincipalObjectAttributeAccesses](#BKMK_service_PrincipalObjectAttributeAccesses)
- [serviceappointment_principalobjectattributeaccess](#BKMK_serviceappointment_principalobjectattributeaccess)
- [site_PrincipalObjectAttributeAccesses](#BKMK_site_PrincipalObjectAttributeAccesses)
- [discount_PrincipalObjectAttributeAccesses](#BKMK_discount_PrincipalObjectAttributeAccesses)
- [discounttype_PrincipalObjectAttributeAccesses](#BKMK_discounttype_PrincipalObjectAttributeAccesses)
- [invoice_principalobjectattributeaccess](#BKMK_invoice_principalobjectattributeaccess)
- [invoicedetail_principalobjectattributeaccess](#BKMK_invoicedetail_principalobjectattributeaccess)
- [leadtoopportunitysalesprocess_PrincipalObjectAttributeAccesses](#BKMK_leadtoopportunitysalesprocess_PrincipalObjectAttributeAccesses)
- [opportunity_principalobjectattributeaccess](#BKMK_opportunity_principalobjectattributeaccess)
- [opportunityclose_PrincipalObjectAttributeAccesses](#BKMK_opportunityclose_PrincipalObjectAttributeAccesses)
- [opportunityproduct_principalobjectattributeaccess](#BKMK_opportunityproduct_principalobjectattributeaccess)
- [opportunitysalesprocess_PrincipalObjectAttributeAccesses](#BKMK_opportunitysalesprocess_PrincipalObjectAttributeAccesses)
- [orderclose_PrincipalObjectAttributeAccesses](#BKMK_orderclose_PrincipalObjectAttributeAccesses)
- [quote_principalobjectattributeaccess](#BKMK_quote_principalobjectattributeaccess)
- [quoteclose_PrincipalObjectAttributeAccesses](#BKMK_quoteclose_PrincipalObjectAttributeAccesses)
- [quotedetail_principalobjectattributeaccess](#BKMK_quotedetail_principalobjectattributeaccess)
- [salesliterature_principalobjectattributeaccess](#BKMK_salesliterature_principalobjectattributeaccess)
- [salesliteratureitem_PrincipalObjectAttributeAccesses](#BKMK_salesliteratureitem_PrincipalObjectAttributeAccesses)
- [salesorder_principalobjectattributeaccess](#BKMK_salesorder_principalobjectattributeaccess)
- [salesorderdetail_principalobjectattributeaccess](#BKMK_salesorderdetail_principalobjectattributeaccess)
- [competitor_principalobjectattributeaccess](#BKMK_competitor_principalobjectattributeaccess)
- [msdyn_relationshipinsightsunifiedconfig_PrincipalObjectAttributeAccesses](#BKMK_msdyn_relationshipinsightsunifiedconfig_PrincipalObjectAttributeAccesses)
- [msdyn_siconfig_PrincipalObjectAttributeAccesses](#BKMK_msdyn_siconfig_PrincipalObjectAttributeAccesses)
- [msdyn_postalbum_PrincipalObjectAttributeAccesses](#BKMK_msdyn_postalbum_PrincipalObjectAttributeAccesses)
- [msdyn_postconfig_PrincipalObjectAttributeAccesses](#BKMK_msdyn_postconfig_PrincipalObjectAttributeAccesses)
- [msdyn_postruleconfig_PrincipalObjectAttributeAccesses](#BKMK_msdyn_postruleconfig_PrincipalObjectAttributeAccesses)
- [msdyn_wallsavedquery_PrincipalObjectAttributeAccesses](#BKMK_msdyn_wallsavedquery_PrincipalObjectAttributeAccesses)
- [msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses](#BKMK_msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses)
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


### <a name="BKMK_account_principalobjectattributeaccess"></a> account_principalobjectattributeaccess

See the [account_principalobjectattributeaccess](account.md#BKMK_account_principalobjectattributeaccess) one-to-many relationship for the [account](account.md) entity.

### <a name="BKMK_contact_principalobjectattributeaccess"></a> contact_principalobjectattributeaccess

See the [contact_principalobjectattributeaccess](contact.md#BKMK_contact_principalobjectattributeaccess) one-to-many relationship for the [contact](contact.md) entity.

### <a name="BKMK_lk_principalobjectattributeaccess_organizationid"></a> lk_principalobjectattributeaccess_organizationid

See the [lk_principalobjectattributeaccess_organizationid](organization.md#BKMK_lk_principalobjectattributeaccess_organizationid) one-to-many relationship for the [organization](organization.md) entity.

### <a name="BKMK_team_principalobjectattributeaccess_principalid"></a> team_principalobjectattributeaccess_principalid

See the [team_principalobjectattributeaccess_principalid](team.md#BKMK_team_principalobjectattributeaccess_principalid) one-to-many relationship for the [team](team.md) entity.

### <a name="BKMK_systemuser_principalobjectattributeaccess_principalid"></a> systemuser_principalobjectattributeaccess_principalid

See the [systemuser_principalobjectattributeaccess_principalid](systemuser.md#BKMK_systemuser_principalobjectattributeaccess_principalid) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_knowledgearticle_PrincipalObjectAttributeAccess"></a> knowledgearticle_PrincipalObjectAttributeAccess

See the [knowledgearticle_PrincipalObjectAttributeAccess](knowledgearticle.md#BKMK_knowledgearticle_PrincipalObjectAttributeAccess) one-to-many relationship for the [knowledgearticle](knowledgearticle.md) entity.

### <a name="BKMK_territory_principalobjectattributeaccess"></a> territory_principalobjectattributeaccess

**Added by**: Application Common Solution

See the [territory_principalobjectattributeaccess](territory.md#BKMK_territory_principalobjectattributeaccess) one-to-many relationship for the [territory](territory.md) entity.

### <a name="BKMK_leadaddress_PrincipalObjectAttributeAccesses"></a> leadaddress_PrincipalObjectAttributeAccesses

**Added by**: Lead Management Solution

See the [leadaddress_PrincipalObjectAttributeAccesses](leadaddress.md#BKMK_leadaddress_PrincipalObjectAttributeAccesses) one-to-many relationship for the [leadaddress](leadaddress.md) entity.

### <a name="BKMK_lead_principalobjectattributeaccess"></a> lead_principalobjectattributeaccess

**Added by**: Lead Management Solution

See the [lead_principalobjectattributeaccess](lead.md#BKMK_lead_principalobjectattributeaccess) one-to-many relationship for the [lead](lead.md) entity.

### <a name="BKMK_dynamicproperty_PrincipalObjectAttributeAccesses"></a> dynamicproperty_PrincipalObjectAttributeAccesses

**Added by**: Product Management Solution

See the [dynamicproperty_PrincipalObjectAttributeAccesses](dynamicproperty.md#BKMK_dynamicproperty_PrincipalObjectAttributeAccesses) one-to-many relationship for the [dynamicproperty](dynamicproperty.md) entity.

### <a name="BKMK_dynamicpropertyassociation_PrincipalObjectAttributeAccesses"></a> dynamicpropertyassociation_PrincipalObjectAttributeAccesses

**Added by**: Product Management Solution

See the [dynamicpropertyassociation_PrincipalObjectAttributeAccesses](dynamicpropertyassociation.md#BKMK_dynamicpropertyassociation_PrincipalObjectAttributeAccesses) one-to-many relationship for the [dynamicpropertyassociation](dynamicpropertyassociation.md) entity.

### <a name="BKMK_dynamicpropertyinstance_PrincipalObjectAttributeAccesses"></a> dynamicpropertyinstance_PrincipalObjectAttributeAccesses

**Added by**: Product Management Solution

See the [dynamicpropertyinstance_PrincipalObjectAttributeAccesses](dynamicpropertyinstance.md#BKMK_dynamicpropertyinstance_PrincipalObjectAttributeAccesses) one-to-many relationship for the [dynamicpropertyinstance](dynamicpropertyinstance.md) entity.

### <a name="BKMK_dynamicpropertyoptionsetitem_PrincipalObjectAttributeAccesses"></a> dynamicpropertyoptionsetitem_PrincipalObjectAttributeAccesses

**Added by**: Product Management Solution

See the [dynamicpropertyoptionsetitem_PrincipalObjectAttributeAccesses](dynamicpropertyoptionsetitem.md#BKMK_dynamicpropertyoptionsetitem_PrincipalObjectAttributeAccesses) one-to-many relationship for the [dynamicpropertyoptionsetitem](dynamicpropertyoptionsetitem.md) entity.

### <a name="BKMK_pricelevel_principalobjectattributeaccess"></a> pricelevel_principalobjectattributeaccess

**Added by**: Product Management Solution

See the [pricelevel_principalobjectattributeaccess](pricelevel.md#BKMK_pricelevel_principalobjectattributeaccess) one-to-many relationship for the [pricelevel](pricelevel.md) entity.

### <a name="BKMK_product_principalobjectattributeaccess"></a> product_principalobjectattributeaccess

**Added by**: Product Management Solution

See the [product_principalobjectattributeaccess](product.md#BKMK_product_principalobjectattributeaccess) one-to-many relationship for the [product](product.md) entity.

### <a name="BKMK_ProductAssociation_PrincipalObjectAttributeAccess"></a> ProductAssociation_PrincipalObjectAttributeAccess

**Added by**: Product Management Solution

See the [ProductAssociation_PrincipalObjectAttributeAccess](productassociation.md#BKMK_ProductAssociation_PrincipalObjectAttributeAccess) one-to-many relationship for the [productassociation](productassociation.md) entity.

### <a name="BKMK_productpricelevel_PrincipalObjectAttributeAccesses"></a> productpricelevel_PrincipalObjectAttributeAccesses

**Added by**: Product Management Solution

See the [productpricelevel_PrincipalObjectAttributeAccesses](productpricelevel.md#BKMK_productpricelevel_PrincipalObjectAttributeAccesses) one-to-many relationship for the [productpricelevel](productpricelevel.md) entity.

### <a name="BKMK_ProductSubstitute_PrincipalObjectAttributeAccess"></a> ProductSubstitute_PrincipalObjectAttributeAccess

**Added by**: Product Management Solution

See the [ProductSubstitute_PrincipalObjectAttributeAccess](productsubstitute.md#BKMK_ProductSubstitute_PrincipalObjectAttributeAccess) one-to-many relationship for the [productsubstitute](productsubstitute.md) entity.

### <a name="BKMK_uom_PrincipalObjectAttributeAccesses"></a> uom_PrincipalObjectAttributeAccesses

**Added by**: Product Management Solution

See the [uom_PrincipalObjectAttributeAccesses](uom.md#BKMK_uom_PrincipalObjectAttributeAccesses) one-to-many relationship for the [uom](uom.md) entity.

### <a name="BKMK_uomschedule_PrincipalObjectAttributeAccesses"></a> uomschedule_PrincipalObjectAttributeAccesses

**Added by**: Product Management Solution

See the [uomschedule_PrincipalObjectAttributeAccesses](uomschedule.md#BKMK_uomschedule_PrincipalObjectAttributeAccesses) one-to-many relationship for the [uomschedule](uomschedule.md) entity.

### <a name="BKMK_bookableresource_PrincipalObjectAttributeAccess"></a> bookableresource_PrincipalObjectAttributeAccess

**Added by**: Scheduling Solution

See the [bookableresource_PrincipalObjectAttributeAccess](bookableresource.md#BKMK_bookableresource_PrincipalObjectAttributeAccess) one-to-many relationship for the [bookableresource](bookableresource.md) entity.

### <a name="BKMK_bookableresourcebooking_PrincipalObjectAttributeAccess"></a> bookableresourcebooking_PrincipalObjectAttributeAccess

**Added by**: Scheduling Solution

See the [bookableresourcebooking_PrincipalObjectAttributeAccess](bookableresourcebooking.md#BKMK_bookableresourcebooking_PrincipalObjectAttributeAccess) one-to-many relationship for the [bookableresourcebooking](bookableresourcebooking.md) entity.

### <a name="BKMK_bookableresourcebookingheader_PrincipalObjectAttributeAccess"></a> bookableresourcebookingheader_PrincipalObjectAttributeAccess

**Added by**: Scheduling Solution

See the [bookableresourcebookingheader_PrincipalObjectAttributeAccess](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_PrincipalObjectAttributeAccess) one-to-many relationship for the [bookableresourcebookingheader](bookableresourcebookingheader.md) entity.

### <a name="BKMK_bookableresourcecategory_PrincipalObjectAttributeAccess"></a> bookableresourcecategory_PrincipalObjectAttributeAccess

**Added by**: Scheduling Solution

See the [bookableresourcecategory_PrincipalObjectAttributeAccess](bookableresourcecategory.md#BKMK_bookableresourcecategory_PrincipalObjectAttributeAccess) one-to-many relationship for the [bookableresourcecategory](bookableresourcecategory.md) entity.

### <a name="BKMK_bookableresourcecategoryassn_PrincipalObjectAttributeAccess"></a> bookableresourcecategoryassn_PrincipalObjectAttributeAccess

**Added by**: Scheduling Solution

See the [bookableresourcecategoryassn_PrincipalObjectAttributeAccess](bookableresourcecategoryassn.md#BKMK_bookableresourcecategoryassn_PrincipalObjectAttributeAccess) one-to-many relationship for the [bookableresourcecategoryassn](bookableresourcecategoryassn.md) entity.

### <a name="BKMK_bookableresourcecharacteristic_PrincipalObjectAttributeAccess"></a> bookableresourcecharacteristic_PrincipalObjectAttributeAccess

**Added by**: Scheduling Solution

See the [bookableresourcecharacteristic_PrincipalObjectAttributeAccess](bookableresourcecharacteristic.md#BKMK_bookableresourcecharacteristic_PrincipalObjectAttributeAccess) one-to-many relationship for the [bookableresourcecharacteristic](bookableresourcecharacteristic.md) entity.

### <a name="BKMK_bookableresourcegroup_PrincipalObjectAttributeAccess"></a> bookableresourcegroup_PrincipalObjectAttributeAccess

**Added by**: Scheduling Solution

See the [bookableresourcegroup_PrincipalObjectAttributeAccess](bookableresourcegroup.md#BKMK_bookableresourcegroup_PrincipalObjectAttributeAccess) one-to-many relationship for the [bookableresourcegroup](bookableresourcegroup.md) entity.

### <a name="BKMK_bookingstatus_PrincipalObjectAttributeAccess"></a> bookingstatus_PrincipalObjectAttributeAccess

**Added by**: Scheduling Solution

See the [bookingstatus_PrincipalObjectAttributeAccess](bookingstatus.md#BKMK_bookingstatus_PrincipalObjectAttributeAccess) one-to-many relationship for the [bookingstatus](bookingstatus.md) entity.

### <a name="BKMK_characteristic_PrincipalObjectAttributeAccess"></a> characteristic_PrincipalObjectAttributeAccess

**Added by**: Scheduling Solution

See the [characteristic_PrincipalObjectAttributeAccess](characteristic.md#BKMK_characteristic_PrincipalObjectAttributeAccess) one-to-many relationship for the [characteristic](characteristic.md) entity.

### <a name="BKMK_ratingmodel_PrincipalObjectAttributeAccess"></a> ratingmodel_PrincipalObjectAttributeAccess

**Added by**: Scheduling Solution

See the [ratingmodel_PrincipalObjectAttributeAccess](ratingmodel.md#BKMK_ratingmodel_PrincipalObjectAttributeAccess) one-to-many relationship for the [ratingmodel](ratingmodel.md) entity.

### <a name="BKMK_ratingvalue_PrincipalObjectAttributeAccess"></a> ratingvalue_PrincipalObjectAttributeAccess

**Added by**: Scheduling Solution

See the [ratingvalue_PrincipalObjectAttributeAccess](ratingvalue.md#BKMK_ratingvalue_PrincipalObjectAttributeAccess) one-to-many relationship for the [ratingvalue](ratingvalue.md) entity.

### <a name="BKMK_bulkoperation_PrincipalObjectAttributeAccesses"></a> bulkoperation_PrincipalObjectAttributeAccesses

**Added by**: Marketing Solution

See the [bulkoperation_PrincipalObjectAttributeAccesses](bulkoperation.md#BKMK_bulkoperation_PrincipalObjectAttributeAccesses) one-to-many relationship for the [bulkoperation](bulkoperation.md) entity.

### <a name="BKMK_bulkoperationlog_PrincipalObjectAttributeAccesses"></a> bulkoperationlog_PrincipalObjectAttributeAccesses

**Added by**: Marketing Solution

See the [bulkoperationlog_PrincipalObjectAttributeAccesses](bulkoperationlog.md#BKMK_bulkoperationlog_PrincipalObjectAttributeAccesses) one-to-many relationship for the [bulkoperationlog](bulkoperationlog.md) entity.

### <a name="BKMK_campaign_principalobjectattributeaccess"></a> campaign_principalobjectattributeaccess

**Added by**: Marketing Solution

See the [campaign_principalobjectattributeaccess](campaign.md#BKMK_campaign_principalobjectattributeaccess) one-to-many relationship for the [campaign](campaign.md) entity.

### <a name="BKMK_campaignactivity_principalobjectattributeaccess"></a> campaignactivity_principalobjectattributeaccess

**Added by**: Marketing Solution

See the [campaignactivity_principalobjectattributeaccess](campaignactivity.md#BKMK_campaignactivity_principalobjectattributeaccess) one-to-many relationship for the [campaignactivity](campaignactivity.md) entity.

### <a name="BKMK_campaignresponse_principalobjectattributeaccess"></a> campaignresponse_principalobjectattributeaccess

**Added by**: Marketing Solution

See the [campaignresponse_principalobjectattributeaccess](campaignresponse.md#BKMK_campaignresponse_principalobjectattributeaccess) one-to-many relationship for the [campaignresponse](campaignresponse.md) entity.

### <a name="BKMK_list_principalobjectattributeaccess"></a> list_principalobjectattributeaccess

**Added by**: Marketing Solution

See the [list_principalobjectattributeaccess](list.md#BKMK_list_principalobjectattributeaccess) one-to-many relationship for the [list](list.md) entity.

### <a name="BKMK_constraintbasedgroup_PrincipalObjectAttributeAccesses"></a> constraintbasedgroup_PrincipalObjectAttributeAccesses

**Added by**: Service Solution

See the [constraintbasedgroup_PrincipalObjectAttributeAccesses](constraintbasedgroup.md#BKMK_constraintbasedgroup_PrincipalObjectAttributeAccesses) one-to-many relationship for the [constraintbasedgroup](constraintbasedgroup.md) entity.

### <a name="BKMK_contract_principalobjectattributeaccess"></a> contract_principalobjectattributeaccess

**Added by**: Service Solution

See the [contract_principalobjectattributeaccess](contract.md#BKMK_contract_principalobjectattributeaccess) one-to-many relationship for the [contract](contract.md) entity.

### <a name="BKMK_contractdetail_principalobjectattributeaccess"></a> contractdetail_principalobjectattributeaccess

**Added by**: Service Solution

See the [contractdetail_principalobjectattributeaccess](contractdetail.md#BKMK_contractdetail_principalobjectattributeaccess) one-to-many relationship for the [contractdetail](contractdetail.md) entity.

### <a name="BKMK_contracttemplate_PrincipalObjectAttributeAccesses"></a> contracttemplate_PrincipalObjectAttributeAccesses

**Added by**: Service Solution

See the [contracttemplate_PrincipalObjectAttributeAccesses](contracttemplate.md#BKMK_contracttemplate_PrincipalObjectAttributeAccesses) one-to-many relationship for the [contracttemplate](contracttemplate.md) entity.

### <a name="BKMK_entitlement_PrincipalObjectAttributeAccesses"></a> entitlement_PrincipalObjectAttributeAccesses

**Added by**: Service Solution

See the [entitlement_PrincipalObjectAttributeAccesses](entitlement.md#BKMK_entitlement_PrincipalObjectAttributeAccesses) one-to-many relationship for the [entitlement](entitlement.md) entity.

### <a name="BKMK_entitlementchannel_PrincipalObjectAttributeAccesses"></a> entitlementchannel_PrincipalObjectAttributeAccesses

**Added by**: Service Solution

See the [entitlementchannel_PrincipalObjectAttributeAccesses](entitlementchannel.md#BKMK_entitlementchannel_PrincipalObjectAttributeAccesses) one-to-many relationship for the [entitlementchannel](entitlementchannel.md) entity.

### <a name="BKMK_entitlementtemplate_PrincipalObjectAttributeAccesses"></a> entitlementtemplate_PrincipalObjectAttributeAccesses

**Added by**: Service Solution

See the [entitlementtemplate_PrincipalObjectAttributeAccesses](entitlementtemplate.md#BKMK_entitlementtemplate_PrincipalObjectAttributeAccesses) one-to-many relationship for the [entitlementtemplate](entitlementtemplate.md) entity.

### <a name="BKMK_entitlementtemplatechannel_PrincipalObjectAttributeAccesses"></a> entitlementtemplatechannel_PrincipalObjectAttributeAccesses

**Added by**: Service Solution

See the [entitlementtemplatechannel_PrincipalObjectAttributeAccesses](entitlementtemplatechannel.md#BKMK_entitlementtemplatechannel_PrincipalObjectAttributeAccesses) one-to-many relationship for the [entitlementtemplatechannel](entitlementtemplatechannel.md) entity.

### <a name="BKMK_equipment_principalobjectattributeaccess"></a> equipment_principalobjectattributeaccess

**Added by**: Service Solution

See the [equipment_principalobjectattributeaccess](equipment.md#BKMK_equipment_principalobjectattributeaccess) one-to-many relationship for the [equipment](equipment.md) entity.

### <a name="BKMK_incident_principalobjectattributeaccess"></a> incident_principalobjectattributeaccess

**Added by**: Service Solution

See the [incident_principalobjectattributeaccess](incident.md#BKMK_incident_principalobjectattributeaccess) one-to-many relationship for the [incident](incident.md) entity.

### <a name="BKMK_incidentresolution_PrincipalObjectAttributeAccesses"></a> incidentresolution_PrincipalObjectAttributeAccesses

**Added by**: Service Solution

See the [incidentresolution_PrincipalObjectAttributeAccesses](incidentresolution.md#BKMK_incidentresolution_PrincipalObjectAttributeAccesses) one-to-many relationship for the [incidentresolution](incidentresolution.md) entity.

### <a name="BKMK_knowledgearticleincident_principalobjectattributeaccess"></a> knowledgearticleincident_principalobjectattributeaccess

**Added by**: Service Solution

See the [knowledgearticleincident_principalobjectattributeaccess](knowledgearticleincident.md#BKMK_knowledgearticleincident_principalobjectattributeaccess) one-to-many relationship for the [knowledgearticleincident](knowledgearticleincident.md) entity.

### <a name="BKMK_phonetocaseprocess_PrincipalObjectAttributeAccesses"></a> phonetocaseprocess_PrincipalObjectAttributeAccesses

**Added by**: Service Solution

See the [phonetocaseprocess_PrincipalObjectAttributeAccesses](phonetocaseprocess.md#BKMK_phonetocaseprocess_PrincipalObjectAttributeAccesses) one-to-many relationship for the [phonetocaseprocess](phonetocaseprocess.md) entity.

### <a name="BKMK_resource_PrincipalObjectAttributeAccesses"></a> resource_PrincipalObjectAttributeAccesses

**Added by**: Service Solution

See the [resource_PrincipalObjectAttributeAccesses](resource.md#BKMK_resource_PrincipalObjectAttributeAccesses) one-to-many relationship for the [resource](resource.md) entity.

### <a name="BKMK_resourcegroup_PrincipalObjectAttributeAccesses"></a> resourcegroup_PrincipalObjectAttributeAccesses

**Added by**: Service Solution

See the [resourcegroup_PrincipalObjectAttributeAccesses](resourcegroup.md#BKMK_resourcegroup_PrincipalObjectAttributeAccesses) one-to-many relationship for the [resourcegroup](resourcegroup.md) entity.

### <a name="BKMK_resourcespec_PrincipalObjectAttributeAccesses"></a> resourcespec_PrincipalObjectAttributeAccesses

**Added by**: Service Solution

See the [resourcespec_PrincipalObjectAttributeAccesses](resourcespec.md#BKMK_resourcespec_PrincipalObjectAttributeAccesses) one-to-many relationship for the [resourcespec](resourcespec.md) entity.

### <a name="BKMK_service_PrincipalObjectAttributeAccesses"></a> service_PrincipalObjectAttributeAccesses

**Added by**: Service Solution

See the [service_PrincipalObjectAttributeAccesses](service.md#BKMK_service_PrincipalObjectAttributeAccesses) one-to-many relationship for the [service](service.md) entity.

### <a name="BKMK_serviceappointment_principalobjectattributeaccess"></a> serviceappointment_principalobjectattributeaccess

**Added by**: Service Solution

See the [serviceappointment_principalobjectattributeaccess](serviceappointment.md#BKMK_serviceappointment_principalobjectattributeaccess) one-to-many relationship for the [serviceappointment](serviceappointment.md) entity.

### <a name="BKMK_site_PrincipalObjectAttributeAccesses"></a> site_PrincipalObjectAttributeAccesses

**Added by**: Service Solution

See the [site_PrincipalObjectAttributeAccesses](site.md#BKMK_site_PrincipalObjectAttributeAccesses) one-to-many relationship for the [site](site.md) entity.

### <a name="BKMK_discount_PrincipalObjectAttributeAccesses"></a> discount_PrincipalObjectAttributeAccesses

**Added by**: Sales Solution

See the [discount_PrincipalObjectAttributeAccesses](discount.md#BKMK_discount_PrincipalObjectAttributeAccesses) one-to-many relationship for the [discount](discount.md) entity.

### <a name="BKMK_discounttype_PrincipalObjectAttributeAccesses"></a> discounttype_PrincipalObjectAttributeAccesses

**Added by**: Sales Solution

See the [discounttype_PrincipalObjectAttributeAccesses](discounttype.md#BKMK_discounttype_PrincipalObjectAttributeAccesses) one-to-many relationship for the [discounttype](discounttype.md) entity.

### <a name="BKMK_invoice_principalobjectattributeaccess"></a> invoice_principalobjectattributeaccess

**Added by**: Sales Solution

See the [invoice_principalobjectattributeaccess](invoice.md#BKMK_invoice_principalobjectattributeaccess) one-to-many relationship for the [invoice](invoice.md) entity.

### <a name="BKMK_invoicedetail_principalobjectattributeaccess"></a> invoicedetail_principalobjectattributeaccess

**Added by**: Sales Solution

See the [invoicedetail_principalobjectattributeaccess](invoicedetail.md#BKMK_invoicedetail_principalobjectattributeaccess) one-to-many relationship for the [invoicedetail](invoicedetail.md) entity.

### <a name="BKMK_leadtoopportunitysalesprocess_PrincipalObjectAttributeAccesses"></a> leadtoopportunitysalesprocess_PrincipalObjectAttributeAccesses

**Added by**: Sales Solution

See the [leadtoopportunitysalesprocess_PrincipalObjectAttributeAccesses](leadtoopportunitysalesprocess.md#BKMK_leadtoopportunitysalesprocess_PrincipalObjectAttributeAccesses) one-to-many relationship for the [leadtoopportunitysalesprocess](leadtoopportunitysalesprocess.md) entity.

### <a name="BKMK_opportunity_principalobjectattributeaccess"></a> opportunity_principalobjectattributeaccess

**Added by**: Sales Solution

See the [opportunity_principalobjectattributeaccess](opportunity.md#BKMK_opportunity_principalobjectattributeaccess) one-to-many relationship for the [opportunity](opportunity.md) entity.

### <a name="BKMK_opportunityclose_PrincipalObjectAttributeAccesses"></a> opportunityclose_PrincipalObjectAttributeAccesses

**Added by**: Sales Solution

See the [opportunityclose_PrincipalObjectAttributeAccesses](opportunityclose.md#BKMK_opportunityclose_PrincipalObjectAttributeAccesses) one-to-many relationship for the [opportunityclose](opportunityclose.md) entity.

### <a name="BKMK_opportunityproduct_principalobjectattributeaccess"></a> opportunityproduct_principalobjectattributeaccess

**Added by**: Sales Solution

See the [opportunityproduct_principalobjectattributeaccess](opportunityproduct.md#BKMK_opportunityproduct_principalobjectattributeaccess) one-to-many relationship for the [opportunityproduct](opportunityproduct.md) entity.

### <a name="BKMK_opportunitysalesprocess_PrincipalObjectAttributeAccesses"></a> opportunitysalesprocess_PrincipalObjectAttributeAccesses

**Added by**: Sales Solution

See the [opportunitysalesprocess_PrincipalObjectAttributeAccesses](opportunitysalesprocess.md#BKMK_opportunitysalesprocess_PrincipalObjectAttributeAccesses) one-to-many relationship for the [opportunitysalesprocess](opportunitysalesprocess.md) entity.

### <a name="BKMK_orderclose_PrincipalObjectAttributeAccesses"></a> orderclose_PrincipalObjectAttributeAccesses

**Added by**: Sales Solution

See the [orderclose_PrincipalObjectAttributeAccesses](orderclose.md#BKMK_orderclose_PrincipalObjectAttributeAccesses) one-to-many relationship for the [orderclose](orderclose.md) entity.

### <a name="BKMK_quote_principalobjectattributeaccess"></a> quote_principalobjectattributeaccess

**Added by**: Sales Solution

See the [quote_principalobjectattributeaccess](quote.md#BKMK_quote_principalobjectattributeaccess) one-to-many relationship for the [quote](quote.md) entity.

### <a name="BKMK_quoteclose_PrincipalObjectAttributeAccesses"></a> quoteclose_PrincipalObjectAttributeAccesses

**Added by**: Sales Solution

See the [quoteclose_PrincipalObjectAttributeAccesses](quoteclose.md#BKMK_quoteclose_PrincipalObjectAttributeAccesses) one-to-many relationship for the [quoteclose](quoteclose.md) entity.

### <a name="BKMK_quotedetail_principalobjectattributeaccess"></a> quotedetail_principalobjectattributeaccess

**Added by**: Sales Solution

See the [quotedetail_principalobjectattributeaccess](quotedetail.md#BKMK_quotedetail_principalobjectattributeaccess) one-to-many relationship for the [quotedetail](quotedetail.md) entity.

### <a name="BKMK_salesliterature_principalobjectattributeaccess"></a> salesliterature_principalobjectattributeaccess

**Added by**: Sales Solution

See the [salesliterature_principalobjectattributeaccess](salesliterature.md#BKMK_salesliterature_principalobjectattributeaccess) one-to-many relationship for the [salesliterature](salesliterature.md) entity.

### <a name="BKMK_salesliteratureitem_PrincipalObjectAttributeAccesses"></a> salesliteratureitem_PrincipalObjectAttributeAccesses

**Added by**: Sales Solution

See the [salesliteratureitem_PrincipalObjectAttributeAccesses](salesliteratureitem.md#BKMK_salesliteratureitem_PrincipalObjectAttributeAccesses) one-to-many relationship for the [salesliteratureitem](salesliteratureitem.md) entity.

### <a name="BKMK_salesorder_principalobjectattributeaccess"></a> salesorder_principalobjectattributeaccess

**Added by**: Sales Solution

See the [salesorder_principalobjectattributeaccess](salesorder.md#BKMK_salesorder_principalobjectattributeaccess) one-to-many relationship for the [salesorder](salesorder.md) entity.

### <a name="BKMK_salesorderdetail_principalobjectattributeaccess"></a> salesorderdetail_principalobjectattributeaccess

**Added by**: Sales Solution

See the [salesorderdetail_principalobjectattributeaccess](salesorderdetail.md#BKMK_salesorderdetail_principalobjectattributeaccess) one-to-many relationship for the [salesorderdetail](salesorderdetail.md) entity.

### <a name="BKMK_competitor_principalobjectattributeaccess"></a> competitor_principalobjectattributeaccess

**Added by**: Sales Solution

See the [competitor_principalobjectattributeaccess](competitor.md#BKMK_competitor_principalobjectattributeaccess) one-to-many relationship for the [competitor](competitor.md) entity.

### <a name="BKMK_msdyn_relationshipinsightsunifiedconfig_PrincipalObjectAttributeAccesses"></a> msdyn_relationshipinsightsunifiedconfig_PrincipalObjectAttributeAccesses

**Added by**: SI Common Solution

See the [msdyn_relationshipinsightsunifiedconfig_PrincipalObjectAttributeAccesses](msdyn_relationshipinsightsunifiedconfig.md#BKMK_msdyn_relationshipinsightsunifiedconfig_PrincipalObjectAttributeAccesses) one-to-many relationship for the [msdyn_relationshipinsightsunifiedconfig](msdyn_relationshipinsightsunifiedconfig.md) entity.

### <a name="BKMK_msdyn_siconfig_PrincipalObjectAttributeAccesses"></a> msdyn_siconfig_PrincipalObjectAttributeAccesses

**Added by**: SI Common Solution

See the [msdyn_siconfig_PrincipalObjectAttributeAccesses](msdyn_siconfig.md#BKMK_msdyn_siconfig_PrincipalObjectAttributeAccesses) one-to-many relationship for the [msdyn_siconfig](msdyn_siconfig.md) entity.

### <a name="BKMK_msdyn_postalbum_PrincipalObjectAttributeAccesses"></a> msdyn_postalbum_PrincipalObjectAttributeAccesses

**Added by**: Activity Feeds Solution

See the [msdyn_postalbum_PrincipalObjectAttributeAccesses](msdyn_postalbum.md#BKMK_msdyn_postalbum_PrincipalObjectAttributeAccesses) one-to-many relationship for the [msdyn_postalbum](msdyn_postalbum.md) entity.

### <a name="BKMK_msdyn_postconfig_PrincipalObjectAttributeAccesses"></a> msdyn_postconfig_PrincipalObjectAttributeAccesses

**Added by**: Activity Feeds Solution

See the [msdyn_postconfig_PrincipalObjectAttributeAccesses](msdyn_postconfig.md#BKMK_msdyn_postconfig_PrincipalObjectAttributeAccesses) one-to-many relationship for the [msdyn_postconfig](msdyn_postconfig.md) entity.

### <a name="BKMK_msdyn_postruleconfig_PrincipalObjectAttributeAccesses"></a> msdyn_postruleconfig_PrincipalObjectAttributeAccesses

**Added by**: Activity Feeds Solution

See the [msdyn_postruleconfig_PrincipalObjectAttributeAccesses](msdyn_postruleconfig.md#BKMK_msdyn_postruleconfig_PrincipalObjectAttributeAccesses) one-to-many relationship for the [msdyn_postruleconfig](msdyn_postruleconfig.md) entity.

### <a name="BKMK_msdyn_wallsavedquery_PrincipalObjectAttributeAccesses"></a> msdyn_wallsavedquery_PrincipalObjectAttributeAccesses

**Added by**: Activity Feeds Solution

See the [msdyn_wallsavedquery_PrincipalObjectAttributeAccesses](msdyn_wallsavedquery.md#BKMK_msdyn_wallsavedquery_PrincipalObjectAttributeAccesses) one-to-many relationship for the [msdyn_wallsavedquery](msdyn_wallsavedquery.md) entity.

### <a name="BKMK_msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses"></a> msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses

**Added by**: Activity Feeds Solution

See the [msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses](msdyn_wallsavedqueryusersettings.md#BKMK_msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses) one-to-many relationship for the [msdyn_wallsavedqueryusersettings](msdyn_wallsavedqueryusersettings.md) entity.

### <a name="BKMK_KnowledgeBaseRecord_PrincipalObjectAttributeAccess"></a> KnowledgeBaseRecord_PrincipalObjectAttributeAccess

See the [KnowledgeBaseRecord_PrincipalObjectAttributeAccess](knowledgebaserecord.md#BKMK_KnowledgeBaseRecord_PrincipalObjectAttributeAccess) one-to-many relationship for the [knowledgebaserecord](knowledgebaserecord.md) entity.

### <a name="BKMK_team_principalobjectattributeaccess"></a> team_principalobjectattributeaccess

See the [team_principalobjectattributeaccess](team.md#BKMK_team_principalobjectattributeaccess) one-to-many relationship for the [team](team.md) entity.

### <a name="BKMK_reportcategory_principalobjectattributeaccess"></a> reportcategory_principalobjectattributeaccess

See the [reportcategory_principalobjectattributeaccess](reportcategory.md#BKMK_reportcategory_principalobjectattributeaccess) one-to-many relationship for the [reportcategory](reportcategory.md) entity.

### <a name="BKMK_mailmergetemplate_principalobjectattributeaccess"></a> mailmergetemplate_principalobjectattributeaccess

See the [mailmergetemplate_principalobjectattributeaccess](mailmergetemplate.md#BKMK_mailmergetemplate_principalobjectattributeaccess) one-to-many relationship for the [mailmergetemplate](mailmergetemplate.md) entity.

### <a name="BKMK_fax_principalobjectattributeaccess"></a> fax_principalobjectattributeaccess

See the [fax_principalobjectattributeaccess](fax.md#BKMK_fax_principalobjectattributeaccess) one-to-many relationship for the [fax](fax.md) entity.

### <a name="BKMK_socialactivity_principalobjectattributeaccess"></a> socialactivity_principalobjectattributeaccess

See the [socialactivity_principalobjectattributeaccess](socialactivity.md#BKMK_socialactivity_principalobjectattributeaccess) one-to-many relationship for the [socialactivity](socialactivity.md) entity.

### <a name="BKMK_kbarticle_principalobjectattributeaccess"></a> kbarticle_principalobjectattributeaccess

See the [kbarticle_principalobjectattributeaccess](kbarticle.md#BKMK_kbarticle_principalobjectattributeaccess) one-to-many relationship for the [kbarticle](kbarticle.md) entity.

### <a name="BKMK_phonecall_principalobjectattributeaccess"></a> phonecall_principalobjectattributeaccess

See the [phonecall_principalobjectattributeaccess](phonecall.md#BKMK_phonecall_principalobjectattributeaccess) one-to-many relationship for the [phonecall](phonecall.md) entity.

### <a name="BKMK_position_principalobjectattributeaccess"></a> position_principalobjectattributeaccess

See the [position_principalobjectattributeaccess](position.md#BKMK_position_principalobjectattributeaccess) one-to-many relationship for the [position](position.md) entity.

### <a name="BKMK_customeraddress_principalobjectattributeaccess"></a> customeraddress_principalobjectattributeaccess

See the [customeraddress_principalobjectattributeaccess](customeraddress.md#BKMK_customeraddress_principalobjectattributeaccess) one-to-many relationship for the [customeraddress](customeraddress.md) entity.

### <a name="BKMK_sharepointsite_principalobjectattributeaccess"></a> sharepointsite_principalobjectattributeaccess

See the [sharepointsite_principalobjectattributeaccess](sharepointsite.md#BKMK_sharepointsite_principalobjectattributeaccess) one-to-many relationship for the [sharepointsite](sharepointsite.md) entity.

### <a name="BKMK_systemuser_principalobjectattributeaccess"></a> systemuser_principalobjectattributeaccess

See the [systemuser_principalobjectattributeaccess](systemuser.md#BKMK_systemuser_principalobjectattributeaccess) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_connection_principalobjectattributeaccess"></a> connection_principalobjectattributeaccess

See the [connection_principalobjectattributeaccess](connection.md#BKMK_connection_principalobjectattributeaccess) one-to-many relationship for the [connection](connection.md) entity.

### <a name="BKMK_appointment_principalobjectattributeaccess"></a> appointment_principalobjectattributeaccess

See the [appointment_principalobjectattributeaccess](appointment.md#BKMK_appointment_principalobjectattributeaccess) one-to-many relationship for the [appointment](appointment.md) entity.

### <a name="BKMK_goal_principalobjectattributeaccess"></a> goal_principalobjectattributeaccess

See the [goal_principalobjectattributeaccess](goal.md#BKMK_goal_principalobjectattributeaccess) one-to-many relationship for the [goal](goal.md) entity.

### <a name="BKMK_email_principalobjectattributeaccess"></a> email_principalobjectattributeaccess

See the [email_principalobjectattributeaccess](email.md#BKMK_email_principalobjectattributeaccess) one-to-many relationship for the [email](email.md) entity.

### <a name="BKMK_knowledgearticleview_principalobjectattributeaccess"></a> knowledgearticleview_principalobjectattributeaccess

See the [knowledgearticleview_principalobjectattributeaccess](knowledgearticleviews.md#BKMK_knowledgearticleview_principalobjectattributeaccess) one-to-many relationship for the [knowledgearticleviews](knowledgearticleviews.md) entity.

### <a name="BKMK_feedback_principalobjectattributeaccess"></a> feedback_principalobjectattributeaccess

See the [feedback_principalobjectattributeaccess](feedback.md#BKMK_feedback_principalobjectattributeaccess) one-to-many relationship for the [feedback](feedback.md) entity.

### <a name="BKMK_businessunit_principalobjectattributeaccess"></a> businessunit_principalobjectattributeaccess

See the [businessunit_principalobjectattributeaccess](businessunit.md#BKMK_businessunit_principalobjectattributeaccess) one-to-many relationship for the [businessunit](businessunit.md) entity.

### <a name="BKMK_sharepointdocumentlocation_principalobjectattributeaccess"></a> sharepointdocumentlocation_principalobjectattributeaccess

See the [sharepointdocumentlocation_principalobjectattributeaccess](sharepointdocumentlocation.md#BKMK_sharepointdocumentlocation_principalobjectattributeaccess) one-to-many relationship for the [sharepointdocumentlocation](sharepointdocumentlocation.md) entity.

### <a name="BKMK_queueitem_principalobjectattributeaccess"></a> queueitem_principalobjectattributeaccess

See the [queueitem_principalobjectattributeaccess](queueitem.md#BKMK_queueitem_principalobjectattributeaccess) one-to-many relationship for the [queueitem](queueitem.md) entity.

### <a name="BKMK_queue_principalobjectattributeaccess"></a> queue_principalobjectattributeaccess

See the [queue_principalobjectattributeaccess](queue.md#BKMK_queue_principalobjectattributeaccess) one-to-many relationship for the [queue](queue.md) entity.

### <a name="BKMK_recurringappointmentmaster_principalobjectattributeaccess"></a> recurringappointmentmaster_principalobjectattributeaccess

See the [recurringappointmentmaster_principalobjectattributeaccess](recurringappointmentmaster.md#BKMK_recurringappointmentmaster_principalobjectattributeaccess) one-to-many relationship for the [recurringappointmentmaster](recurringappointmentmaster.md) entity.

### <a name="BKMK_task_principalobjectattributeaccess"></a> task_principalobjectattributeaccess

See the [task_principalobjectattributeaccess](task.md#BKMK_task_principalobjectattributeaccess) one-to-many relationship for the [task](task.md) entity.

### <a name="BKMK_letter_principalobjectattributeaccess"></a> letter_principalobjectattributeaccess

See the [letter_principalobjectattributeaccess](letter.md#BKMK_letter_principalobjectattributeaccess) one-to-many relationship for the [letter](letter.md) entity.

### <a name="BKMK_socialprofile_principalobjectattributeaccess"></a> socialprofile_principalobjectattributeaccess

See the [socialprofile_principalobjectattributeaccess](socialprofile.md#BKMK_socialprofile_principalobjectattributeaccess) one-to-many relationship for the [socialprofile](socialprofile.md) entity.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Web API EntityType Reference](/power-apps/developer/data-platform/webapi/reference/entitytypes)
