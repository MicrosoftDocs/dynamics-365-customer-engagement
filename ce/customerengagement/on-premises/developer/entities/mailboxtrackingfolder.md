---
title: "Mailbox Auto Tracking Folder (MailboxTrackingFolder)  entity reference (Dynamics 365 Customer Engagement) | Microsoft Docs"
description: "Includes schema information and supported messages for the Mailbox Auto Tracking Folder (MailboxTrackingFolder)  entity."
ms.date: 08/30/2022
ms.topic: "reference"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "KumarVivek"
ms.author: "kvivek"
search.audienceType: 
  - developer
---

# Mailbox Auto Tracking Folder (MailboxTrackingFolder)  entity reference

Stores data about what folders for a mailbox are auto tracked


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
|CollectionSchemaName|MailboxTrackingFolders|
|DisplayCollectionName|Mailbox Auto Tracking Folders|
|DisplayName|Mailbox Auto Tracking Folder|
|EntitySetName|mailboxtrackingfolders|
|IsBPFEntity|False|
|LogicalCollectionName|mailboxtrackingfolders|
|LogicalName|mailboxtrackingfolder|
|OwnershipType|UserOwned|
|PrimaryIdAttribute|mailboxtrackingfolderid|
|PrimaryNameAttribute||
|SchemaName|MailboxTrackingFolder|

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

|Property|Value|
|--------|-----|
|Description|Folder Id for a folder in Exchange|
|DisplayName|Exchange Folder Id|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|exchangefolderid|
|MaxLength|120|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ExchangeFolderName"></a> ExchangeFolderName

|Property|Value|
|--------|-----|
|Description|Exchange Folder Name|
|DisplayName|Exchange Folder Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|exchangefoldername|
|MaxLength|256|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_FolderOnboardingStatus"></a> FolderOnboardingStatus

|Property|Value|
|--------|-----|
|Description|Information to indicate whether the folder has been on boarded for auto tracking|
|DisplayName|Folder on boarding Status|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|folderonboardingstatus|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_MailboxId"></a> MailboxId

|Property|Value|
|--------|-----|
|Description|Mailbox id associated with this record.|
|DisplayName|MailboxId|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|mailboxid|
|RequiredLevel|SystemRequired|
|Targets|mailbox|
|Type|Lookup|


### <a name="BKMK_OwnerId"></a> OwnerId

|Property|Value|
|--------|-----|
|Description|Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.|
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
|Description|The regarding object such as Account, Contact, Lead etc. that the folder relates to.|
|DisplayName|Regarding Object Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|regardingobjectid|
|RequiredLevel|None|
|Targets|account,accountleads,asyncoperation,bookableresource,bookableresourcebooking,bookableresourcebookingexchangesyncidmapping,bookableresourcebookingheader,bookableresourcecategory,bookableresourcecategoryassn,bookableresourcecharacteristic,bookableresourcegroup,bookingstatus,bulkoperation,bulkoperationlog,campaign,campaignactivity,campaignactivityitem,campaignitem,campaignresponse,characteristic,childincidentcount,commitment,competitor,competitoraddress,competitorproduct,competitorsalesliterature,constraintbasedgroup,contact,contactinvoices,contactleads,contactorders,contactquotes,contract,contractdetail,contracttemplate,customeropportunityrole,discount,discounttype,dynamicproperty,dynamicpropertyassociation,dynamicpropertyinstance,dynamicpropertyoptionsetitem,entitlement,entitlementchannel,entitlementcontacts,entitlementproducts,entitlementtemplate,entitlementtemplatechannel,entitlementtemplateproducts,equipment,incident,incidentknowledgebaserecord,incidentresolution,invoice,invoicedetail,knowledgearticleincident,lead,leadaddress,leadcompetitors,leadproduct,leadtoopportunitysalesprocess,list,listmember,msdyn_postalbum,msdyn_postconfig,msdyn_postruleconfig,msdyn_relationshipinsightsunifiedconfig,msdyn_siconfig,msdyn_wallsavedquery,msdyn_wallsavedqueryusersettings,opportunity,opportunityclose,opportunitycompetitors,opportunityproduct,opportunitysalesprocess,orderclose,phonetocaseprocess,pricelevel,product,productassociation,productpricelevel,productsalesliterature,productsubstitute,quote,quoteclose,quotedetail,ratingmodel,ratingvalue,resource,resourcegroup,resourcegroupexpansion,resourcespec,salesliterature,salesliteratureitem,salesorder,salesorderdetail,salesprocessinstance,service,serviceappointment,servicecontractcontacts,site,territory,topic,topichistory,topicmodel,topicmodelconfiguration,topicmodelexecutionhistory,uom,uomschedule|
|Type|Lookup|


### <a name="BKMK_RegardingObjectIdName"></a> RegardingObjectIdName

|Property|Value|
|--------|-----|
|Description|Regarding Object Name|
|DisplayName|Regarding Object Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|regardingobjectidname|
|MaxLength|400|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_RegardingObjectTypeCode"></a> RegardingObjectTypeCode

|Property|Value|
|--------|-----|
|Description|Information that indicates the type of regarding object associated with the folder|
|DisplayName|Regarding Object Type Code|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|regardingobjecttypecode|
|RequiredLevel|None|
|Type|EntityName|

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
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the record.|
|DisplayName|Created By|
|IsValidForForm|False|
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
|MaxLength|160|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the entry was created.|
|DisplayName|Created On|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Shows who created the record on behalf of another user.|
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
|MaxLength|160|
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
|MaxLength|160|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_MailboxTrackingFolderId"></a> MailboxTrackingFolderId

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|mailboxtrackingfolderid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who modified the record.|
|DisplayName|Modified By|
|IsValidForForm|False|
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
|MaxLength|160|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the entry was last modified.|
|DisplayName|Modified On|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who modified the record.|
|DisplayName|Modified By (Delegate)|
|IsValidForForm|False|
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
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the organization associated with the record.|
|DisplayName|Organization|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationid|
|RequiredLevel|SystemRequired|
|Targets|organization|
|Type|Lookup|


### <a name="BKMK_OwningBusinessUnit"></a> OwningBusinessUnit

|Property|Value|
|--------|-----|
|Description|Unique identifier of the business unit that owns the folder mapping.|
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
|Description|Unique identifier of the team who owns the folder mapping.|
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
|Description|Unique identifier for the user that owns the record.|
|DisplayName|Owning User|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|owninguser|
|RequiredLevel|None|
|Targets||
|Type|Lookup|


### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|--------|-----|
|Description|Version number of the mailbox tracking folder.|
|DisplayName|Version number|
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

- [territory_MailboxTrackingFolders](#BKMK_territory_MailboxTrackingFolders)
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
- [campaignresponse_MailboxTrackingFolders](#BKMK_campaignresponse_MailboxTrackingFolders)
- [list_MailboxTrackingFolders](#BKMK_list_MailboxTrackingFolders)
- [constraintbasedgroup_MailboxTrackingFolders](#BKMK_constraintbasedgroup_MailboxTrackingFolders)
- [Contract_MailboxTrackingFolder](#BKMK_Contract_MailboxTrackingFolder)
- [contractdetail_MailboxTrackingFolders](#BKMK_contractdetail_MailboxTrackingFolders)
- [contracttemplate_MailboxTrackingFolders](#BKMK_contracttemplate_MailboxTrackingFolders)
- [Entitlement_MailboxTrackingFolder](#BKMK_Entitlement_MailboxTrackingFolder)
- [entitlementchannel_MailboxTrackingFolders](#BKMK_entitlementchannel_MailboxTrackingFolders)
- [EntitlementTemplate_MailboxTrackingFolder](#BKMK_EntitlementTemplate_MailboxTrackingFolder)
- [entitlementtemplatechannel_MailboxTrackingFolders](#BKMK_entitlementtemplatechannel_MailboxTrackingFolders)
- [equipment_MailboxTrackingFolders](#BKMK_equipment_MailboxTrackingFolders)
- [Incident_MailboxTrackingFolder](#BKMK_Incident_MailboxTrackingFolder)
- [incidentresolution_MailboxTrackingFolders](#BKMK_incidentresolution_MailboxTrackingFolders)
- [knowledgearticleincident_MailboxTrackingFolders](#BKMK_knowledgearticleincident_MailboxTrackingFolders)
- [phonetocaseprocess_MailboxTrackingFolders](#BKMK_phonetocaseprocess_MailboxTrackingFolders)
- [resource_MailboxTrackingFolders](#BKMK_resource_MailboxTrackingFolders)
- [resourcegroup_MailboxTrackingFolders](#BKMK_resourcegroup_MailboxTrackingFolders)
- [resourcespec_MailboxTrackingFolders](#BKMK_resourcespec_MailboxTrackingFolders)
- [service_MailboxTrackingFolders](#BKMK_service_MailboxTrackingFolders)
- [serviceappointment_MailboxTrackingFolders](#BKMK_serviceappointment_MailboxTrackingFolders)
- [site_MailboxTrackingFolders](#BKMK_site_MailboxTrackingFolders)
- [discount_MailboxTrackingFolders](#BKMK_discount_MailboxTrackingFolders)
- [discounttype_MailboxTrackingFolders](#BKMK_discounttype_MailboxTrackingFolders)
- [Invoice_MailboxTrackingFolder](#BKMK_Invoice_MailboxTrackingFolder)
- [invoicedetail_MailboxTrackingFolders](#BKMK_invoicedetail_MailboxTrackingFolders)
- [leadtoopportunitysalesprocess_MailboxTrackingFolders](#BKMK_leadtoopportunitysalesprocess_MailboxTrackingFolders)
- [Opportunity_MailboxTrackingFolder](#BKMK_Opportunity_MailboxTrackingFolder)
- [opportunityclose_MailboxTrackingFolders](#BKMK_opportunityclose_MailboxTrackingFolders)
- [opportunityproduct_MailboxTrackingFolders](#BKMK_opportunityproduct_MailboxTrackingFolders)
- [opportunitysalesprocess_MailboxTrackingFolders](#BKMK_opportunitysalesprocess_MailboxTrackingFolders)
- [orderclose_MailboxTrackingFolders](#BKMK_orderclose_MailboxTrackingFolders)
- [Quote_MailboxTrackingFolder](#BKMK_Quote_MailboxTrackingFolder)
- [quoteclose_MailboxTrackingFolders](#BKMK_quoteclose_MailboxTrackingFolders)
- [quotedetail_MailboxTrackingFolders](#BKMK_quotedetail_MailboxTrackingFolders)
- [salesliterature_MailboxTrackingFolders](#BKMK_salesliterature_MailboxTrackingFolders)
- [salesliteratureitem_MailboxTrackingFolders](#BKMK_salesliteratureitem_MailboxTrackingFolders)
- [SalesOrder_MailboxTrackingFolder](#BKMK_SalesOrder_MailboxTrackingFolder)
- [salesorderdetail_MailboxTrackingFolders](#BKMK_salesorderdetail_MailboxTrackingFolders)
- [competitor_MailboxTrackingFolders](#BKMK_competitor_MailboxTrackingFolders)
- [msdyn_relationshipinsightsunifiedconfig_MailboxTrackingFolders](#BKMK_msdyn_relationshipinsightsunifiedconfig_MailboxTrackingFolders)
- [msdyn_siconfig_MailboxTrackingFolders](#BKMK_msdyn_siconfig_MailboxTrackingFolders)
- [msdyn_postalbum_MailboxTrackingFolders](#BKMK_msdyn_postalbum_MailboxTrackingFolders)
- [msdyn_postconfig_MailboxTrackingFolders](#BKMK_msdyn_postconfig_MailboxTrackingFolders)
- [msdyn_postruleconfig_MailboxTrackingFolders](#BKMK_msdyn_postruleconfig_MailboxTrackingFolders)
- [msdyn_wallsavedquery_MailboxTrackingFolders](#BKMK_msdyn_wallsavedquery_MailboxTrackingFolders)
- [msdyn_wallsavedqueryusersettings_MailboxTrackingFolders](#BKMK_msdyn_wallsavedqueryusersettings_MailboxTrackingFolders)
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


### <a name="BKMK_territory_MailboxTrackingFolders"></a> territory_MailboxTrackingFolders

**Added by**: Application Common Solution

See the [territory_MailboxTrackingFolders](territory.md#BKMK_territory_MailboxTrackingFolders) one-to-many relationship for the [territory](territory.md) entity.

### <a name="BKMK_leadaddress_MailboxTrackingFolders"></a> leadaddress_MailboxTrackingFolders

**Added by**: Lead Management Solution

See the [leadaddress_MailboxTrackingFolders](leadaddress.md#BKMK_leadaddress_MailboxTrackingFolders) one-to-many relationship for the [leadaddress](leadaddress.md) entity.

### <a name="BKMK_Lead_MailboxTrackingFolder"></a> Lead_MailboxTrackingFolder

**Added by**: Lead Management Solution

See the [Lead_MailboxTrackingFolder](lead.md#BKMK_Lead_MailboxTrackingFolder) one-to-many relationship for the [lead](lead.md) entity.

### <a name="BKMK_dynamicproperty_MailboxTrackingFolders"></a> dynamicproperty_MailboxTrackingFolders

**Added by**: Product Management Solution

See the [dynamicproperty_MailboxTrackingFolders](dynamicproperty.md#BKMK_dynamicproperty_MailboxTrackingFolders) one-to-many relationship for the [dynamicproperty](dynamicproperty.md) entity.

### <a name="BKMK_dynamicpropertyassociation_MailboxTrackingFolders"></a> dynamicpropertyassociation_MailboxTrackingFolders

**Added by**: Product Management Solution

See the [dynamicpropertyassociation_MailboxTrackingFolders](dynamicpropertyassociation.md#BKMK_dynamicpropertyassociation_MailboxTrackingFolders) one-to-many relationship for the [dynamicpropertyassociation](dynamicpropertyassociation.md) entity.

### <a name="BKMK_dynamicpropertyinstance_MailboxTrackingFolders"></a> dynamicpropertyinstance_MailboxTrackingFolders

**Added by**: Product Management Solution

See the [dynamicpropertyinstance_MailboxTrackingFolders](dynamicpropertyinstance.md#BKMK_dynamicpropertyinstance_MailboxTrackingFolders) one-to-many relationship for the [dynamicpropertyinstance](dynamicpropertyinstance.md) entity.

### <a name="BKMK_dynamicpropertyoptionsetitem_MailboxTrackingFolders"></a> dynamicpropertyoptionsetitem_MailboxTrackingFolders

**Added by**: Product Management Solution

See the [dynamicpropertyoptionsetitem_MailboxTrackingFolders](dynamicpropertyoptionsetitem.md#BKMK_dynamicpropertyoptionsetitem_MailboxTrackingFolders) one-to-many relationship for the [dynamicpropertyoptionsetitem](dynamicpropertyoptionsetitem.md) entity.

### <a name="BKMK_pricelevel_MailboxTrackingFolders"></a> pricelevel_MailboxTrackingFolders

**Added by**: Product Management Solution

See the [pricelevel_MailboxTrackingFolders](pricelevel.md#BKMK_pricelevel_MailboxTrackingFolders) one-to-many relationship for the [pricelevel](pricelevel.md) entity.

### <a name="BKMK_product_MailboxTrackingFolders"></a> product_MailboxTrackingFolders

**Added by**: Product Management Solution

See the [product_MailboxTrackingFolders](product.md#BKMK_product_MailboxTrackingFolders) one-to-many relationship for the [product](product.md) entity.

### <a name="BKMK_productassociation_MailboxTrackingFolders"></a> productassociation_MailboxTrackingFolders

**Added by**: Product Management Solution

See the [productassociation_MailboxTrackingFolders](productassociation.md#BKMK_productassociation_MailboxTrackingFolders) one-to-many relationship for the [productassociation](productassociation.md) entity.

### <a name="BKMK_productpricelevel_MailboxTrackingFolders"></a> productpricelevel_MailboxTrackingFolders

**Added by**: Product Management Solution

See the [productpricelevel_MailboxTrackingFolders](productpricelevel.md#BKMK_productpricelevel_MailboxTrackingFolders) one-to-many relationship for the [productpricelevel](productpricelevel.md) entity.

### <a name="BKMK_productsubstitute_MailboxTrackingFolders"></a> productsubstitute_MailboxTrackingFolders

**Added by**: Product Management Solution

See the [productsubstitute_MailboxTrackingFolders](productsubstitute.md#BKMK_productsubstitute_MailboxTrackingFolders) one-to-many relationship for the [productsubstitute](productsubstitute.md) entity.

### <a name="BKMK_uom_MailboxTrackingFolders"></a> uom_MailboxTrackingFolders

**Added by**: Product Management Solution

See the [uom_MailboxTrackingFolders](uom.md#BKMK_uom_MailboxTrackingFolders) one-to-many relationship for the [uom](uom.md) entity.

### <a name="BKMK_uomschedule_MailboxTrackingFolders"></a> uomschedule_MailboxTrackingFolders

**Added by**: Product Management Solution

See the [uomschedule_MailboxTrackingFolders](uomschedule.md#BKMK_uomschedule_MailboxTrackingFolders) one-to-many relationship for the [uomschedule](uomschedule.md) entity.

### <a name="BKMK_bookableresource_MailboxTrackingFolders"></a> bookableresource_MailboxTrackingFolders

**Added by**: Scheduling Solution

See the [bookableresource_MailboxTrackingFolders](bookableresource.md#BKMK_bookableresource_MailboxTrackingFolders) one-to-many relationship for the [bookableresource](bookableresource.md) entity.

### <a name="BKMK_bookableresourcebooking_MailboxTrackingFolders"></a> bookableresourcebooking_MailboxTrackingFolders

**Added by**: Scheduling Solution

See the [bookableresourcebooking_MailboxTrackingFolders](bookableresourcebooking.md#BKMK_bookableresourcebooking_MailboxTrackingFolders) one-to-many relationship for the [bookableresourcebooking](bookableresourcebooking.md) entity.

### <a name="BKMK_bookableresourcebookingheader_MailboxTrackingFolders"></a> bookableresourcebookingheader_MailboxTrackingFolders

**Added by**: Scheduling Solution

See the [bookableresourcebookingheader_MailboxTrackingFolders](bookableresourcebookingheader.md#BKMK_bookableresourcebookingheader_MailboxTrackingFolders) one-to-many relationship for the [bookableresourcebookingheader](bookableresourcebookingheader.md) entity.

### <a name="BKMK_bookableresourcecategory_MailboxTrackingFolders"></a> bookableresourcecategory_MailboxTrackingFolders

**Added by**: Scheduling Solution

See the [bookableresourcecategory_MailboxTrackingFolders](bookableresourcecategory.md#BKMK_bookableresourcecategory_MailboxTrackingFolders) one-to-many relationship for the [bookableresourcecategory](bookableresourcecategory.md) entity.

### <a name="BKMK_bookableresourcecategoryassn_MailboxTrackingFolders"></a> bookableresourcecategoryassn_MailboxTrackingFolders

**Added by**: Scheduling Solution

See the [bookableresourcecategoryassn_MailboxTrackingFolders](bookableresourcecategoryassn.md#BKMK_bookableresourcecategoryassn_MailboxTrackingFolders) one-to-many relationship for the [bookableresourcecategoryassn](bookableresourcecategoryassn.md) entity.

### <a name="BKMK_bookableresourcecharacteristic_MailboxTrackingFolders"></a> bookableresourcecharacteristic_MailboxTrackingFolders

**Added by**: Scheduling Solution

See the [bookableresourcecharacteristic_MailboxTrackingFolders](bookableresourcecharacteristic.md#BKMK_bookableresourcecharacteristic_MailboxTrackingFolders) one-to-many relationship for the [bookableresourcecharacteristic](bookableresourcecharacteristic.md) entity.

### <a name="BKMK_bookableresourcegroup_MailboxTrackingFolders"></a> bookableresourcegroup_MailboxTrackingFolders

**Added by**: Scheduling Solution

See the [bookableresourcegroup_MailboxTrackingFolders](bookableresourcegroup.md#BKMK_bookableresourcegroup_MailboxTrackingFolders) one-to-many relationship for the [bookableresourcegroup](bookableresourcegroup.md) entity.

### <a name="BKMK_bookingstatus_MailboxTrackingFolders"></a> bookingstatus_MailboxTrackingFolders

**Added by**: Scheduling Solution

See the [bookingstatus_MailboxTrackingFolders](bookingstatus.md#BKMK_bookingstatus_MailboxTrackingFolders) one-to-many relationship for the [bookingstatus](bookingstatus.md) entity.

### <a name="BKMK_characteristic_MailboxTrackingFolders"></a> characteristic_MailboxTrackingFolders

**Added by**: Scheduling Solution

See the [characteristic_MailboxTrackingFolders](characteristic.md#BKMK_characteristic_MailboxTrackingFolders) one-to-many relationship for the [characteristic](characteristic.md) entity.

### <a name="BKMK_ratingmodel_MailboxTrackingFolders"></a> ratingmodel_MailboxTrackingFolders

**Added by**: Scheduling Solution

See the [ratingmodel_MailboxTrackingFolders](ratingmodel.md#BKMK_ratingmodel_MailboxTrackingFolders) one-to-many relationship for the [ratingmodel](ratingmodel.md) entity.

### <a name="BKMK_ratingvalue_MailboxTrackingFolders"></a> ratingvalue_MailboxTrackingFolders

**Added by**: Scheduling Solution

See the [ratingvalue_MailboxTrackingFolders](ratingvalue.md#BKMK_ratingvalue_MailboxTrackingFolders) one-to-many relationship for the [ratingvalue](ratingvalue.md) entity.

### <a name="BKMK_BulkOperation_MailboxTrackingFolder"></a> BulkOperation_MailboxTrackingFolder

**Added by**: Marketing Solution

See the [BulkOperation_MailboxTrackingFolder](bulkoperation.md#BKMK_BulkOperation_MailboxTrackingFolder) one-to-many relationship for the [bulkoperation](bulkoperation.md) entity.

### <a name="BKMK_bulkoperationlog_MailboxTrackingFolders"></a> bulkoperationlog_MailboxTrackingFolders

**Added by**: Marketing Solution

See the [bulkoperationlog_MailboxTrackingFolders](bulkoperationlog.md#BKMK_bulkoperationlog_MailboxTrackingFolders) one-to-many relationship for the [bulkoperationlog](bulkoperationlog.md) entity.

### <a name="BKMK_Campaign_MailboxTrackingFolder"></a> Campaign_MailboxTrackingFolder

**Added by**: Marketing Solution

See the [Campaign_MailboxTrackingFolder](campaign.md#BKMK_Campaign_MailboxTrackingFolder) one-to-many relationship for the [campaign](campaign.md) entity.

### <a name="BKMK_CampaignActivity_MailboxTrackingFolder"></a> CampaignActivity_MailboxTrackingFolder

**Added by**: Marketing Solution

See the [CampaignActivity_MailboxTrackingFolder](campaignactivity.md#BKMK_CampaignActivity_MailboxTrackingFolder) one-to-many relationship for the [campaignactivity](campaignactivity.md) entity.

### <a name="BKMK_campaignresponse_MailboxTrackingFolders"></a> campaignresponse_MailboxTrackingFolders

**Added by**: Marketing Solution

See the [campaignresponse_MailboxTrackingFolders](campaignresponse.md#BKMK_campaignresponse_MailboxTrackingFolders) one-to-many relationship for the [campaignresponse](campaignresponse.md) entity.

### <a name="BKMK_list_MailboxTrackingFolders"></a> list_MailboxTrackingFolders

**Added by**: Marketing Solution

See the [list_MailboxTrackingFolders](list.md#BKMK_list_MailboxTrackingFolders) one-to-many relationship for the [list](list.md) entity.

### <a name="BKMK_constraintbasedgroup_MailboxTrackingFolders"></a> constraintbasedgroup_MailboxTrackingFolders

**Added by**: Service Solution

See the [constraintbasedgroup_MailboxTrackingFolders](constraintbasedgroup.md#BKMK_constraintbasedgroup_MailboxTrackingFolders) one-to-many relationship for the [constraintbasedgroup](constraintbasedgroup.md) entity.

### <a name="BKMK_Contract_MailboxTrackingFolder"></a> Contract_MailboxTrackingFolder

**Added by**: Service Solution

See the [Contract_MailboxTrackingFolder](contract.md#BKMK_Contract_MailboxTrackingFolder) one-to-many relationship for the [contract](contract.md) entity.

### <a name="BKMK_contractdetail_MailboxTrackingFolders"></a> contractdetail_MailboxTrackingFolders

**Added by**: Service Solution

See the [contractdetail_MailboxTrackingFolders](contractdetail.md#BKMK_contractdetail_MailboxTrackingFolders) one-to-many relationship for the [contractdetail](contractdetail.md) entity.

### <a name="BKMK_contracttemplate_MailboxTrackingFolders"></a> contracttemplate_MailboxTrackingFolders

**Added by**: Service Solution

See the [contracttemplate_MailboxTrackingFolders](contracttemplate.md#BKMK_contracttemplate_MailboxTrackingFolders) one-to-many relationship for the [contracttemplate](contracttemplate.md) entity.

### <a name="BKMK_Entitlement_MailboxTrackingFolder"></a> Entitlement_MailboxTrackingFolder

**Added by**: Service Solution

See the [Entitlement_MailboxTrackingFolder](entitlement.md#BKMK_Entitlement_MailboxTrackingFolder) one-to-many relationship for the [entitlement](entitlement.md) entity.

### <a name="BKMK_entitlementchannel_MailboxTrackingFolders"></a> entitlementchannel_MailboxTrackingFolders

**Added by**: Service Solution

See the [entitlementchannel_MailboxTrackingFolders](entitlementchannel.md#BKMK_entitlementchannel_MailboxTrackingFolders) one-to-many relationship for the [entitlementchannel](entitlementchannel.md) entity.

### <a name="BKMK_EntitlementTemplate_MailboxTrackingFolder"></a> EntitlementTemplate_MailboxTrackingFolder

**Added by**: Service Solution

See the [EntitlementTemplate_MailboxTrackingFolder](entitlementtemplate.md#BKMK_EntitlementTemplate_MailboxTrackingFolder) one-to-many relationship for the [entitlementtemplate](entitlementtemplate.md) entity.

### <a name="BKMK_entitlementtemplatechannel_MailboxTrackingFolders"></a> entitlementtemplatechannel_MailboxTrackingFolders

**Added by**: Service Solution

See the [entitlementtemplatechannel_MailboxTrackingFolders](entitlementtemplatechannel.md#BKMK_entitlementtemplatechannel_MailboxTrackingFolders) one-to-many relationship for the [entitlementtemplatechannel](entitlementtemplatechannel.md) entity.

### <a name="BKMK_equipment_MailboxTrackingFolders"></a> equipment_MailboxTrackingFolders

**Added by**: Service Solution

See the [equipment_MailboxTrackingFolders](equipment.md#BKMK_equipment_MailboxTrackingFolders) one-to-many relationship for the [equipment](equipment.md) entity.

### <a name="BKMK_Incident_MailboxTrackingFolder"></a> Incident_MailboxTrackingFolder

**Added by**: Service Solution

See the [Incident_MailboxTrackingFolder](incident.md#BKMK_Incident_MailboxTrackingFolder) one-to-many relationship for the [incident](incident.md) entity.

### <a name="BKMK_incidentresolution_MailboxTrackingFolders"></a> incidentresolution_MailboxTrackingFolders

**Added by**: Service Solution

See the [incidentresolution_MailboxTrackingFolders](incidentresolution.md#BKMK_incidentresolution_MailboxTrackingFolders) one-to-many relationship for the [incidentresolution](incidentresolution.md) entity.

### <a name="BKMK_knowledgearticleincident_MailboxTrackingFolders"></a> knowledgearticleincident_MailboxTrackingFolders

**Added by**: Service Solution

See the [knowledgearticleincident_MailboxTrackingFolders](knowledgearticleincident.md#BKMK_knowledgearticleincident_MailboxTrackingFolders) one-to-many relationship for the [knowledgearticleincident](knowledgearticleincident.md) entity.

### <a name="BKMK_phonetocaseprocess_MailboxTrackingFolders"></a> phonetocaseprocess_MailboxTrackingFolders

**Added by**: Service Solution

See the [phonetocaseprocess_MailboxTrackingFolders](phonetocaseprocess.md#BKMK_phonetocaseprocess_MailboxTrackingFolders) one-to-many relationship for the [phonetocaseprocess](phonetocaseprocess.md) entity.

### <a name="BKMK_resource_MailboxTrackingFolders"></a> resource_MailboxTrackingFolders

**Added by**: Service Solution

See the [resource_MailboxTrackingFolders](resource.md#BKMK_resource_MailboxTrackingFolders) one-to-many relationship for the [resource](resource.md) entity.

### <a name="BKMK_resourcegroup_MailboxTrackingFolders"></a> resourcegroup_MailboxTrackingFolders

**Added by**: Service Solution

See the [resourcegroup_MailboxTrackingFolders](resourcegroup.md#BKMK_resourcegroup_MailboxTrackingFolders) one-to-many relationship for the [resourcegroup](resourcegroup.md) entity.

### <a name="BKMK_resourcespec_MailboxTrackingFolders"></a> resourcespec_MailboxTrackingFolders

**Added by**: Service Solution

See the [resourcespec_MailboxTrackingFolders](resourcespec.md#BKMK_resourcespec_MailboxTrackingFolders) one-to-many relationship for the [resourcespec](resourcespec.md) entity.

### <a name="BKMK_service_MailboxTrackingFolders"></a> service_MailboxTrackingFolders

**Added by**: Service Solution

See the [service_MailboxTrackingFolders](service.md#BKMK_service_MailboxTrackingFolders) one-to-many relationship for the [service](service.md) entity.

### <a name="BKMK_serviceappointment_MailboxTrackingFolders"></a> serviceappointment_MailboxTrackingFolders

**Added by**: Service Solution

See the [serviceappointment_MailboxTrackingFolders](serviceappointment.md#BKMK_serviceappointment_MailboxTrackingFolders) one-to-many relationship for the [serviceappointment](serviceappointment.md) entity.

### <a name="BKMK_site_MailboxTrackingFolders"></a> site_MailboxTrackingFolders

**Added by**: Service Solution

See the [site_MailboxTrackingFolders](site.md#BKMK_site_MailboxTrackingFolders) one-to-many relationship for the [site](site.md) entity.

### <a name="BKMK_discount_MailboxTrackingFolders"></a> discount_MailboxTrackingFolders

**Added by**: Sales Solution

See the [discount_MailboxTrackingFolders](discount.md#BKMK_discount_MailboxTrackingFolders) one-to-many relationship for the [discount](discount.md) entity.

### <a name="BKMK_discounttype_MailboxTrackingFolders"></a> discounttype_MailboxTrackingFolders

**Added by**: Sales Solution

See the [discounttype_MailboxTrackingFolders](discounttype.md#BKMK_discounttype_MailboxTrackingFolders) one-to-many relationship for the [discounttype](discounttype.md) entity.

### <a name="BKMK_Invoice_MailboxTrackingFolder"></a> Invoice_MailboxTrackingFolder

**Added by**: Sales Solution

See the [Invoice_MailboxTrackingFolder](invoice.md#BKMK_Invoice_MailboxTrackingFolder) one-to-many relationship for the [invoice](invoice.md) entity.

### <a name="BKMK_invoicedetail_MailboxTrackingFolders"></a> invoicedetail_MailboxTrackingFolders

**Added by**: Sales Solution

See the [invoicedetail_MailboxTrackingFolders](invoicedetail.md#BKMK_invoicedetail_MailboxTrackingFolders) one-to-many relationship for the [invoicedetail](invoicedetail.md) entity.

### <a name="BKMK_leadtoopportunitysalesprocess_MailboxTrackingFolders"></a> leadtoopportunitysalesprocess_MailboxTrackingFolders

**Added by**: Sales Solution

See the [leadtoopportunitysalesprocess_MailboxTrackingFolders](leadtoopportunitysalesprocess.md#BKMK_leadtoopportunitysalesprocess_MailboxTrackingFolders) one-to-many relationship for the [leadtoopportunitysalesprocess](leadtoopportunitysalesprocess.md) entity.

### <a name="BKMK_Opportunity_MailboxTrackingFolder"></a> Opportunity_MailboxTrackingFolder

**Added by**: Sales Solution

See the [Opportunity_MailboxTrackingFolder](opportunity.md#BKMK_Opportunity_MailboxTrackingFolder) one-to-many relationship for the [opportunity](opportunity.md) entity.

### <a name="BKMK_opportunityclose_MailboxTrackingFolders"></a> opportunityclose_MailboxTrackingFolders

**Added by**: Sales Solution

See the [opportunityclose_MailboxTrackingFolders](opportunityclose.md#BKMK_opportunityclose_MailboxTrackingFolders) one-to-many relationship for the [opportunityclose](opportunityclose.md) entity.

### <a name="BKMK_opportunityproduct_MailboxTrackingFolders"></a> opportunityproduct_MailboxTrackingFolders

**Added by**: Sales Solution

See the [opportunityproduct_MailboxTrackingFolders](opportunityproduct.md#BKMK_opportunityproduct_MailboxTrackingFolders) one-to-many relationship for the [opportunityproduct](opportunityproduct.md) entity.

### <a name="BKMK_opportunitysalesprocess_MailboxTrackingFolders"></a> opportunitysalesprocess_MailboxTrackingFolders

**Added by**: Sales Solution

See the [opportunitysalesprocess_MailboxTrackingFolders](opportunitysalesprocess.md#BKMK_opportunitysalesprocess_MailboxTrackingFolders) one-to-many relationship for the [opportunitysalesprocess](opportunitysalesprocess.md) entity.

### <a name="BKMK_orderclose_MailboxTrackingFolders"></a> orderclose_MailboxTrackingFolders

**Added by**: Sales Solution

See the [orderclose_MailboxTrackingFolders](orderclose.md#BKMK_orderclose_MailboxTrackingFolders) one-to-many relationship for the [orderclose](orderclose.md) entity.

### <a name="BKMK_Quote_MailboxTrackingFolder"></a> Quote_MailboxTrackingFolder

**Added by**: Sales Solution

See the [Quote_MailboxTrackingFolder](quote.md#BKMK_Quote_MailboxTrackingFolder) one-to-many relationship for the [quote](quote.md) entity.

### <a name="BKMK_quoteclose_MailboxTrackingFolders"></a> quoteclose_MailboxTrackingFolders

**Added by**: Sales Solution

See the [quoteclose_MailboxTrackingFolders](quoteclose.md#BKMK_quoteclose_MailboxTrackingFolders) one-to-many relationship for the [quoteclose](quoteclose.md) entity.

### <a name="BKMK_quotedetail_MailboxTrackingFolders"></a> quotedetail_MailboxTrackingFolders

**Added by**: Sales Solution

See the [quotedetail_MailboxTrackingFolders](quotedetail.md#BKMK_quotedetail_MailboxTrackingFolders) one-to-many relationship for the [quotedetail](quotedetail.md) entity.

### <a name="BKMK_salesliterature_MailboxTrackingFolders"></a> salesliterature_MailboxTrackingFolders

**Added by**: Sales Solution

See the [salesliterature_MailboxTrackingFolders](salesliterature.md#BKMK_salesliterature_MailboxTrackingFolders) one-to-many relationship for the [salesliterature](salesliterature.md) entity.

### <a name="BKMK_salesliteratureitem_MailboxTrackingFolders"></a> salesliteratureitem_MailboxTrackingFolders

**Added by**: Sales Solution

See the [salesliteratureitem_MailboxTrackingFolders](salesliteratureitem.md#BKMK_salesliteratureitem_MailboxTrackingFolders) one-to-many relationship for the [salesliteratureitem](salesliteratureitem.md) entity.

### <a name="BKMK_SalesOrder_MailboxTrackingFolder"></a> SalesOrder_MailboxTrackingFolder

**Added by**: Sales Solution

See the [SalesOrder_MailboxTrackingFolder](salesorder.md#BKMK_SalesOrder_MailboxTrackingFolder) one-to-many relationship for the [salesorder](salesorder.md) entity.

### <a name="BKMK_salesorderdetail_MailboxTrackingFolders"></a> salesorderdetail_MailboxTrackingFolders

**Added by**: Sales Solution

See the [salesorderdetail_MailboxTrackingFolders](salesorderdetail.md#BKMK_salesorderdetail_MailboxTrackingFolders) one-to-many relationship for the [salesorderdetail](salesorderdetail.md) entity.

### <a name="BKMK_competitor_MailboxTrackingFolders"></a> competitor_MailboxTrackingFolders

**Added by**: Sales Solution

See the [competitor_MailboxTrackingFolders](competitor.md#BKMK_competitor_MailboxTrackingFolders) one-to-many relationship for the [competitor](competitor.md) entity.

### <a name="BKMK_msdyn_relationshipinsightsunifiedconfig_MailboxTrackingFolders"></a> msdyn_relationshipinsightsunifiedconfig_MailboxTrackingFolders

**Added by**: SI Common Solution

See the [msdyn_relationshipinsightsunifiedconfig_MailboxTrackingFolders](msdyn_relationshipinsightsunifiedconfig.md#BKMK_msdyn_relationshipinsightsunifiedconfig_MailboxTrackingFolders) one-to-many relationship for the [msdyn_relationshipinsightsunifiedconfig](msdyn_relationshipinsightsunifiedconfig.md) entity.

### <a name="BKMK_msdyn_siconfig_MailboxTrackingFolders"></a> msdyn_siconfig_MailboxTrackingFolders

**Added by**: SI Common Solution

See the [msdyn_siconfig_MailboxTrackingFolders](msdyn_siconfig.md#BKMK_msdyn_siconfig_MailboxTrackingFolders) one-to-many relationship for the [msdyn_siconfig](msdyn_siconfig.md) entity.

### <a name="BKMK_msdyn_postalbum_MailboxTrackingFolders"></a> msdyn_postalbum_MailboxTrackingFolders

**Added by**: Activity Feeds Solution

See the [msdyn_postalbum_MailboxTrackingFolders](msdyn_postalbum.md#BKMK_msdyn_postalbum_MailboxTrackingFolders) one-to-many relationship for the [msdyn_postalbum](msdyn_postalbum.md) entity.

### <a name="BKMK_msdyn_postconfig_MailboxTrackingFolders"></a> msdyn_postconfig_MailboxTrackingFolders

**Added by**: Activity Feeds Solution

See the [msdyn_postconfig_MailboxTrackingFolders](msdyn_postconfig.md#BKMK_msdyn_postconfig_MailboxTrackingFolders) one-to-many relationship for the [msdyn_postconfig](msdyn_postconfig.md) entity.

### <a name="BKMK_msdyn_postruleconfig_MailboxTrackingFolders"></a> msdyn_postruleconfig_MailboxTrackingFolders

**Added by**: Activity Feeds Solution

See the [msdyn_postruleconfig_MailboxTrackingFolders](msdyn_postruleconfig.md#BKMK_msdyn_postruleconfig_MailboxTrackingFolders) one-to-many relationship for the [msdyn_postruleconfig](msdyn_postruleconfig.md) entity.

### <a name="BKMK_msdyn_wallsavedquery_MailboxTrackingFolders"></a> msdyn_wallsavedquery_MailboxTrackingFolders

**Added by**: Activity Feeds Solution

See the [msdyn_wallsavedquery_MailboxTrackingFolders](msdyn_wallsavedquery.md#BKMK_msdyn_wallsavedquery_MailboxTrackingFolders) one-to-many relationship for the [msdyn_wallsavedquery](msdyn_wallsavedquery.md) entity.

### <a name="BKMK_msdyn_wallsavedqueryusersettings_MailboxTrackingFolders"></a> msdyn_wallsavedqueryusersettings_MailboxTrackingFolders

**Added by**: Activity Feeds Solution

See the [msdyn_wallsavedqueryusersettings_MailboxTrackingFolders](msdyn_wallsavedqueryusersettings.md#BKMK_msdyn_wallsavedqueryusersettings_MailboxTrackingFolders) one-to-many relationship for the [msdyn_wallsavedqueryusersettings](msdyn_wallsavedqueryusersettings.md) entity.

### <a name="BKMK_lk_mailboxtrackingfolder_modifiedby"></a> lk_mailboxtrackingfolder_modifiedby

See the [lk_mailboxtrackingfolder_modifiedby](systemuser.md#BKMK_lk_mailboxtrackingfolder_modifiedby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_lk_mailboxtrackingfolder_createdby"></a> lk_mailboxtrackingfolder_createdby

See the [lk_mailboxtrackingfolder_createdby](systemuser.md#BKMK_lk_mailboxtrackingfolder_createdby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_Account_MailboxTrackingFolder"></a> Account_MailboxTrackingFolder

See the [Account_MailboxTrackingFolder](account.md#BKMK_Account_MailboxTrackingFolder) one-to-many relationship for the [account](account.md) entity.

### <a name="BKMK_team_mailboxtrackingfolder"></a> team_mailboxtrackingfolder

See the [team_mailboxtrackingfolder](team.md#BKMK_team_mailboxtrackingfolder) one-to-many relationship for the [team](team.md) entity.

### <a name="BKMK_Contact_MailboxTrackingFolder"></a> Contact_MailboxTrackingFolder

See the [Contact_MailboxTrackingFolder](contact.md#BKMK_Contact_MailboxTrackingFolder) one-to-many relationship for the [contact](contact.md) entity.

### <a name="BKMK_lk_mailboxtrackingfolder_createdonbehalfby"></a> lk_mailboxtrackingfolder_createdonbehalfby

See the [lk_mailboxtrackingfolder_createdonbehalfby](systemuser.md#BKMK_lk_mailboxtrackingfolder_createdonbehalfby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_lk_mailboxtrackingfolder_modifiedonbehalfby"></a> lk_mailboxtrackingfolder_modifiedonbehalfby

See the [lk_mailboxtrackingfolder_modifiedonbehalfby](systemuser.md#BKMK_lk_mailboxtrackingfolder_modifiedonbehalfby) one-to-many relationship for the [systemuser](systemuser.md) entity.

### <a name="BKMK_Organization_MailboxTrackingFolder"></a> Organization_MailboxTrackingFolder

See the [Organization_MailboxTrackingFolder](organization.md#BKMK_Organization_MailboxTrackingFolder) one-to-many relationship for the [organization](organization.md) entity.

### <a name="BKMK_Mailbox_MailboxTrackingFolder"></a> Mailbox_MailboxTrackingFolder

See the [Mailbox_MailboxTrackingFolder](mailbox.md#BKMK_Mailbox_MailboxTrackingFolder) one-to-many relationship for the [mailbox](mailbox.md) entity.

### <a name="BKMK_businessunit_mailboxtrackingfolder"></a> businessunit_mailboxtrackingfolder

See the [businessunit_mailboxtrackingfolder](businessunit.md#BKMK_businessunit_mailboxtrackingfolder) one-to-many relationship for the [businessunit](businessunit.md) entity.

### <a name="BKMK_AsyncOperation_MailboxTrackingFolder"></a> AsyncOperation_MailboxTrackingFolder

See the [AsyncOperation_MailboxTrackingFolder](asyncoperation.md#BKMK_AsyncOperation_MailboxTrackingFolder) one-to-many relationship for the [asyncoperation](asyncoperation.md) entity.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Web API EntityType Reference](/power-apps/developer/data-platform/webapi/reference/entitytypes)
