---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_taxcode EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: f0679071-21ce-4285-8652-a4e509a26020
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_taxcode entitytype."
---
# msdyn_taxcode EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_taxcode.md](./descriptions/msdyn_taxcode.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]msdyn_taxcodes </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Tax Code</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_taxcodeid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_taxcode entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|msdyn_actastaxgroup|Edm.Boolean|**Display Name**: Act as Tax Group<br />**Description**: If set as a Tax Group the tax rate will be the total of all the Tax Code details combined<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_agreementtaxable|Edm.Boolean|**Display Name**: Agreement Taxable<br />**Description**: Select whether this tax code applies to service agreements.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: Type the sales tax code name.<br />|
|msdyn_productstaxable|Edm.Boolean|**Display Name**: Products Taxable<br />**Description**: Select whether this tax code applies to products.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_servicestaxable|Edm.Boolean|**Display Name**: Services Taxable<br />**Description**: Select whether this tax code applies to services.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_taxcodeid|Edm.Guid|**Display Name**: Tax Code<br />**Description**: Shows the entity instances.<br />|
|msdyn_taxrate|Edm.Double|**Display Name**: Tax Rate %<br />**Description**: Enter the rate of this sales tax code.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Tax Code<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Tax Code<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Shows the time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who last updated the record on behalf of another user.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_taxcode_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_taxcode_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_taxcode_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_taxcode_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_taxcode|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_taxcode|
|owningteam|[team EntityType](team.md)|team_msdyn_taxcode|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_taxcode|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_msdyn_taxcode_account_SalesTaxCode|[account EntityType](account.md)|msdyn_salestaxcode|  
|msdyn_msdyn_taxcode_msdyn_actual_TaxCode|[msdyn_actual EntityType](msdyn_actual.md)|msdyn_TaxCode|  
|msdyn_msdyn_taxcode_msdyn_agreement_SalesTaxCode|[msdyn_agreement EntityType](msdyn_agreement.md)|msdyn_salestaxcode|  
|msdyn_msdyn_taxcode_msdyn_purchaseorderbill_TaxCode|[msdyn_purchaseorderbill EntityType](msdyn_purchaseorderbill.md)|msdyn_taxcode|  
|msdyn_msdyn_taxcode_msdyn_rma_TaxCode|[msdyn_rma EntityType](msdyn_rma.md)|msdyn_taxcode|  
|msdyn_msdyn_taxcode_msdyn_rtv_TaxCode|[msdyn_rtv EntityType](msdyn_rtv.md)|msdyn_taxcode|  
|msdyn_msdyn_taxcode_msdyn_taxcodedetail_ParentTaxCode|[msdyn_taxcodedetail EntityType](msdyn_taxcodedetail.md)|msdyn_parenttaxcode|  
|msdyn_msdyn_taxcode_msdyn_taxcodedetail_TaxCode|[msdyn_taxcodedetail EntityType](msdyn_taxcodedetail.md)|msdyn_taxcode|  
|msdyn_msdyn_taxcode_msdyn_workorder_TaxCode|[msdyn_workorder EntityType](msdyn_workorder.md)|msdyn_taxcode|  
|msdyn_msdyn_taxcode_quotedetail_SalesTaxCode|[quotedetail EntityType](quotedetail.md)|msdyn_SalesTaxCode|  
|msdyn_taxcode_Annotations|[annotation EntityType](annotation.md)|objectid_msdyn_taxcode|  
|msdyn_taxcode_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_taxcode|  
|msdyn_taxcode_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_taxcode|  
|msdyn_taxcode_connections1|[connection EntityType](connection.md)|record1id_msdyn_taxcode|  
|msdyn_taxcode_connections2|[connection EntityType](connection.md)|record2id_msdyn_taxcode|  
|msdyn_taxcode_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_taxcode|  
|msdyn_taxcode_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_taxcode|  
|msdyn_taxcode_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_taxcode|  

## Operations
The following operations can be used with the msdyn_taxcode entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_taxcode entity type.


|Name|Description |  
|----|------------|  
|[Field Service Solution](../solutions/fieldservice.md)|[!INCLUDE[../solutions/descriptions/fieldservice.md](../solutions/descriptions/fieldservice.md)]|    

[!INCLUDE[./remarks/msdyn_taxcode.md](./remarks/msdyn_taxcode.md)]

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