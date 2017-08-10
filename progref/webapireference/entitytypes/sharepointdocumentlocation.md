---
title: "Microsoft Dynamics 365 Customer Engagement sharepointdocumentlocation EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: e36b40e6-57b5-4e1b-9d6c-885579320dc6
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API sharepointdocumentlocation entitytype."
---
# sharepointdocumentlocation EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/sharepointdocumentlocation.md](./descriptions/sharepointdocumentlocation.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]sharepointdocumentlocations </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Document Location</td></tr>
<tr><td><b>Primary Key:</b></td><td>sharepointdocumentlocationid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  


## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|absoluteurl|Edm.String|**Display Name**: Absolute URL<br />**Description**: Absolute URL of the SharePoint document location.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the SharePoint document location record was created.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Description of the SharePoint document location record.<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Exchange rate between the currency associated with the SharePoint document location record and the base currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created the SharePoint document location record.<br />|
|locationtype|Edm.Int32|**Display Name**: Location Type <br />**Description**: Location type of the SharePoint document location.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>General</td></tr><tr><td>1</td><td>Dedicated for OneNote Integration</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the SharePoint document location record was last modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Name of the SharePoint document location record.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|relativeurl|Edm.String|**Display Name**: Relative URL<br />**Description**: Relative URL of the SharePoint document location.<br />|
|servicetype|Edm.Int32|**Display Name**: Service Type<br />**Description**: Shows the service type of the SharePoint site.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>SharePoint</td></tr><tr><td>1</td><td>OneDrive</td></tr><tr><td>2</td><td>Shared with me</td></tr><tbody></table>|
|sharepointdocumentlocationid|Edm.Guid|**Display Name**: SharePoint Document Location ID<br />**Description**: Unique identifier of the SharePoint document location record.<br />|
|sitecollectionid|Edm.Guid|**Description**: For internal use only.<br />Read-only<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the SharePoint document location record.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the SharePoint document location record.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Description**: For internal use only.<br />|
|userid|Edm.Guid|**Display Name**: SharePoint Document Location Owner<br />**Description**: Choose the user who owns the SharePoint document location.<br />|
|utcconversiontimezonecode|Edm.Int32|**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the SharePoint document location record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the SharePoint document location record.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the SharePoint document location record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who modified the SharePoint document location record.|
|_ownerid_value|ownerid<br />|Unique identifier of the user or team who owns the SharePoint document location record.|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier of the business unit that owns the SharePoint document location record.|
|_owningteam_value|owningteam<br />|Unique identifier of the team who owns the SharePoint document location record.|
|_owninguser_value|owninguser<br />|Unique identifier of the user who owns the SharePoint document location record.|
|_parentsiteorlocation_value|parentsiteorlocation_sharepointdocumentlocation<br />parentsiteorlocation_sharepointsite<br />|Unique identifier of the parent site or location.|
|_regardingobjectid_value|regardingobjectid_lead<br />regardingobjectid_product<br />regardingobjectid_opportunity<br />regardingobjectid_quote<br />regardingobjectid_salesliterature<br />regardingobjectid_adx_webpage<br />regardingobjectid_adx_website<br />regardingobjectid_msdyn_resourceterritory<br />regardingobjectid_msdyn_timegroup<br />regardingobjectid_msdyn_timegroupdetail<br />regardingobjectid_msdyn_agreement<br />regardingobjectid_msdyn_agreementbookingdate<br />regardingobjectid_msdyn_agreementbookingsetup<br />regardingobjectid_msdyn_agreementinvoicedate<br />regardingobjectid_msdyn_agreementinvoicesetup<br />regardingobjectid_msdyn_bookingtimestamp<br />regardingobjectid_msdyn_incidenttypeproduct<br />regardingobjectid_msdyn_inventoryadjustment<br />regardingobjectid_msdyn_inventoryadjustmentproduct<br />regardingobjectid_msdyn_inventorytransfer<br />regardingobjectid_msdyn_purchaseorder<br />regardingobjectid_msdyn_purchaseorderproduct<br />regardingobjectid_msdyn_purchaseorderreceipt<br />regardingobjectid_msdyn_rma<br />regardingobjectid_msdyn_rmareceipt<br />regardingobjectid_msdyn_rtv<br />regardingobjectid_msdyn_warehouse<br />regardingobjectid_msdyn_workorder<br />regardingobjectid_msdyn_workorderincident<br />regardingobjectid_msdyn_workorderproduct<br />regardingobjectid_msdyn_workorderservice<br />regardingobjectid_msdyn_workorderservicetask<br />regardingobjectid_msdyn_expense<br />regardingobjectid_msdyn_project<br />regardingobjectid_knowledgearticle<br />regardingobjectid_account<br />regardingobjectid_kbarticle<br />|Unique identifier of the object with which the SharePoint document location record is associated.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Unique identifier of the currency associated with the SharePoint document location record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_sharepointdocumentlocationbase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_sharepointdocumentlocationbase_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_sharepointdocumentlocationbase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_sharepointdocumentlocationbase_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_sharepointdocumentlocation|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_sharepointdocumentlocation|
|owningteam|[team EntityType](team.md)|team_sharepointdocumentlocation|
|owninguser|[systemuser EntityType](systemuser.md)|user_sharepointdocumentlocation|
|parentsiteorlocation_sharepointdocumentlocation|[sharepointdocumentlocation EntityType](sharepointdocumentlocation.md)|sharepointdocumentlocation_parent_sharepointdocumentlocation|
|parentsiteorlocation_sharepointsite|[sharepointsite EntityType](sharepointsite.md)|sharepointdocumentlocation_parent_sharepointsite|
|regardingobjectid_account|[account EntityType](account.md)|Account_SharepointDocumentLocation|
|regardingobjectid_adx_portalcomment|[adx_portalcomment EntityType](adx_portalcomment.md)|adx_portalcomment_SharePointDocumentLocations|
|regardingobjectid_adx_webpage|[adx_webpage EntityType](adx_webpage.md)|adx_webpage_SharePointDocumentLocations|
|regardingobjectid_adx_website|[adx_website EntityType](adx_website.md)|adx_website_SharePointDocumentLocations|
|regardingobjectid_kbarticle|[kbarticle EntityType](kbarticle.md)|KbArticle_SharepointDocumentLocation|
|regardingobjectid_knowledgearticle|[knowledgearticle EntityType](knowledgearticle.md)|knowledgearticle_SharePointDocumentLocations|
|regardingobjectid_lead|[lead EntityType](lead.md)|Lead_SharepointDocumentLocation|
|regardingobjectid_msdyn_agreement|[msdyn_agreement EntityType](msdyn_agreement.md)|msdyn_agreement_SharePointDocumentLocations|
|regardingobjectid_msdyn_agreementbookingdate|[msdyn_agreementbookingdate EntityType](msdyn_agreementbookingdate.md)|msdyn_agreementbookingdate_SharePointDocumentLocations|
|regardingobjectid_msdyn_agreementbookingsetup|[msdyn_agreementbookingsetup EntityType](msdyn_agreementbookingsetup.md)|msdyn_agreementbookingsetup_SharePointDocumentLocations|
|regardingobjectid_msdyn_agreementinvoicedate|[msdyn_agreementinvoicedate EntityType](msdyn_agreementinvoicedate.md)|msdyn_agreementinvoicedate_SharePointDocumentLocations|
|regardingobjectid_msdyn_agreementinvoicesetup|[msdyn_agreementinvoicesetup EntityType](msdyn_agreementinvoicesetup.md)|msdyn_agreementinvoicesetup_SharePointDocumentLocations|
|regardingobjectid_msdyn_bookingtimestamp|[msdyn_bookingtimestamp EntityType](msdyn_bookingtimestamp.md)|msdyn_bookingtimestamp_SharePointDocumentLocations|
|regardingobjectid_msdyn_expense|[msdyn_expense EntityType](msdyn_expense.md)|msdyn_expense_SharePointDocumentLocations|
|regardingobjectid_msdyn_incidenttypeproduct|[msdyn_incidenttypeproduct EntityType](msdyn_incidenttypeproduct.md)|msdyn_incidenttypeproduct_SharePointDocumentLocations|
|regardingobjectid_msdyn_inventoryadjustment|[msdyn_inventoryadjustment EntityType](msdyn_inventoryadjustment.md)|msdyn_inventoryadjustment_SharePointDocumentLocations|
|regardingobjectid_msdyn_inventoryadjustmentproduct|[msdyn_inventoryadjustmentproduct EntityType](msdyn_inventoryadjustmentproduct.md)|msdyn_inventoryadjustmentproduct_SharePointDocumentLocations|
|regardingobjectid_msdyn_inventorytransfer|[msdyn_inventorytransfer EntityType](msdyn_inventorytransfer.md)|msdyn_inventorytransfer_SharePointDocumentLocations|
|regardingobjectid_msdyn_project|[msdyn_project EntityType](msdyn_project.md)|msdyn_project_SharePointDocumentLocations|
|regardingobjectid_msdyn_purchaseorder|[msdyn_purchaseorder EntityType](msdyn_purchaseorder.md)|msdyn_purchaseorder_SharePointDocumentLocations|
|regardingobjectid_msdyn_purchaseorderproduct|[msdyn_purchaseorderproduct EntityType](msdyn_purchaseorderproduct.md)|msdyn_purchaseorderproduct_SharePointDocumentLocations|
|regardingobjectid_msdyn_purchaseorderreceipt|[msdyn_purchaseorderreceipt EntityType](msdyn_purchaseorderreceipt.md)|msdyn_purchaseorderreceipt_SharePointDocumentLocations|
|regardingobjectid_msdyn_resourceterritory|[msdyn_resourceterritory EntityType](msdyn_resourceterritory.md)|msdyn_resourceterritory_SharePointDocumentLocations|
|regardingobjectid_msdyn_rma|[msdyn_rma EntityType](msdyn_rma.md)|msdyn_rma_SharePointDocumentLocations|
|regardingobjectid_msdyn_rmareceipt|[msdyn_rmareceipt EntityType](msdyn_rmareceipt.md)|msdyn_rmareceipt_SharePointDocumentLocations|
|regardingobjectid_msdyn_rtv|[msdyn_rtv EntityType](msdyn_rtv.md)|msdyn_rtv_SharePointDocumentLocations|
|regardingobjectid_msdyn_timegroup|[msdyn_timegroup EntityType](msdyn_timegroup.md)|msdyn_timegroup_SharePointDocumentLocations|
|regardingobjectid_msdyn_timegroupdetail|[msdyn_timegroupdetail EntityType](msdyn_timegroupdetail.md)|msdyn_timegroupdetail_SharePointDocumentLocations|
|regardingobjectid_msdyn_warehouse|[msdyn_warehouse EntityType](msdyn_warehouse.md)|msdyn_warehouse_SharePointDocumentLocations|
|regardingobjectid_msdyn_workorder|[msdyn_workorder EntityType](msdyn_workorder.md)|msdyn_workorder_SharePointDocumentLocations|
|regardingobjectid_msdyn_workorderincident|[msdyn_workorderincident EntityType](msdyn_workorderincident.md)|msdyn_workorderincident_SharePointDocumentLocations|
|regardingobjectid_msdyn_workorderproduct|[msdyn_workorderproduct EntityType](msdyn_workorderproduct.md)|msdyn_workorderproduct_SharePointDocumentLocations|
|regardingobjectid_msdyn_workorderservice|[msdyn_workorderservice EntityType](msdyn_workorderservice.md)|msdyn_workorderservice_SharePointDocumentLocations|
|regardingobjectid_msdyn_workorderservicetask|[msdyn_workorderservicetask EntityType](msdyn_workorderservicetask.md)|msdyn_workorderservicetask_SharePointDocumentLocations|
|regardingobjectid_opportunity|[opportunity EntityType](opportunity.md)|Opportunity_SharepointDocumentLocation|
|regardingobjectid_product|[product EntityType](product.md)|Product_SharepointDocumentLocation|
|regardingobjectid_quote|[quote EntityType](quote.md)|Quote_SharepointDocumentLocation|
|regardingobjectid_salesliterature|[salesliterature EntityType](salesliterature.md)|SalesLiterature_SharepointDocumentLocation|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_SharePointDocumentLocation|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|SharePointDocumentLocation_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_sharepointdocumentlocation|  
|SharePointDocumentLocation_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_sharepointdocumentlocation|  
|SharePointDocumentLocation_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_sharepointdocumentlocation|  
|sharepointdocumentlocation_parent_sharepointdocumentlocation|[sharepointdocumentlocation EntityType](sharepointdocumentlocation.md)|parentsiteorlocation_sharepointdocumentlocation|  
|SharePointDocumentLocation_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_sharepointdocumentlocation_syncerror|  

## Operations
The following operations can be used with the sharepointdocumentlocation entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrieveAbsoluteAndSiteCollectionUrl Function](../functions/retrieveabsoluteandsitecollectionurl.md)|Entity|[!INCLUDE[../functions/descriptions/retrieveabsoluteandsitecollectionurl.md](../functions/descriptions/retrieveabsoluteandsitecollectionurl.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the sharepointdocumentlocation entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics CRM Marketing Sales Solution](../solutions/marketingsales.md)|[!INCLUDE[../solutions/descriptions/marketingsales.md](../solutions/descriptions/marketingsales.md)]|  
|[Microsoft Dynamics Sales Workload Solution](../solutions/sales.md)|[!INCLUDE[../solutions/descriptions/sales.md](../solutions/descriptions/sales.md)]|  
|[Microsoft Dynamics Lead Management Workload Solution](../solutions/leadmanagement.md)|[!INCLUDE[../solutions/descriptions/leadmanagement.md](../solutions/descriptions/leadmanagement.md)]|    

[!INCLUDE[./remarks/sharepointdocumentlocation.md](./remarks/sharepointdocumentlocation.md)]

### See also  
 [Use the Microsoft Dynamics CRM Web API](https://msdn.microsoft.com/library/mt593051.aspx)<br />
 [Web API EntityType Reference](../entitytypereference.md)<br />
 [Web API Action Reference](../actionreference.md)<br />
 [Web API Function Reference](../functionreference.md)<br />
 [Web API Query Function Reference](../queryfunctionreference.md)<br />
 [Web API EnumType Reference](../enumtypereference.md)<br />
 [Web API ComplexType Reference](../complextypereference.md)<br />
 [Web API Metadata EntityType Reference](../entitytypereference.md)<br />
 [Web API Solutions Reference](../solutionreference.md)<br />