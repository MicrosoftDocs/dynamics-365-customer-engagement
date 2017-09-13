---
title: "Microsoft Dynamics 365 Customer Engagement msdyncrm_marketingemail EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 55cdb1dd-54ed-4ff5-a53c-a4aed69b3295
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyncrm_marketingemail entitytype."
---
# msdyncrm_marketingemail EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyncrm_marketingemail.md](./descriptions/msdyncrm_marketingemail.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyncrm_marketingemails </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Marketing Email</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyncrm_marketingemailid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyncrm_subject</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyncrm_marketingemail entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyncrm_automaticallygeneratetextpart|Edm.Boolean|**Display Name**: Automatically generate text part<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyncrm_clickmap|Edm.String|**Display Name**: Click Map<br />|
|msdyncrm_description|Edm.String|**Display Name**: Description<br />|
|msdyncrm_designerhtml|Edm.String|**Display Name**: Designer Html<br />**Description**: Clean email body - html with no css inlining, no compression<br />|
|msdyncrm_emailbody|Edm.String|**Display Name**: Email Body<br />**Description**: The body of the email<br />|
|msdyncrm_fromemail|Edm.String|**Display Name**: From Email<br />|
|msdyncrm_fromname|Edm.String|**Display Name**: From Name<br />|
|msdyncrm_insights_placeholder|Edm.String|**Display Name**: Insights<br />|
|msdyncrm_marketingemailid|Edm.Guid|**Display Name**: Marketing Email<br />**Description**: Unique identifier for entity instances<br />|
|msdyncrm_name|Edm.String|**Display Name**: Name<br />|
|msdyncrm_replytoemail|Edm.String|**Display Name**: Reply-To Email<br />|
|msdyncrm_subject|Edm.String|**Display Name**: Subject<br />**Description**: The subject of the marketing email.<br />|
|msdyncrm_textpart|Edm.String|**Display Name**: Text Part<br />|
|msdyncrm_to|Edm.String|**Display Name**: To<br />|
|msdyncrm_uicentityid|Edm.String|**Display Name**: UIC Entity Id<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Marketing Email<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Marketing Email<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Draft</td></tr><tr><td>192350001</td><td>Live</td></tr><tr><td>192350002</td><td>Stopped</td></tr><tr><td>192350003</td><td>Live editable</td></tr><tr><td>192350004</td><td>Expired</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the record.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who modified the record.|
|_msdyncrm_fromuser_value|msdyncrm_FromUser<br />||
|_msdyncrm_templateid_value|msdyncrm_TemplateId<br />|Template for the email.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_marketingemail_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_marketingemail_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_marketingemail_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_marketingemail_modifiedonbehalfby|
|msdyncrm_FromUser|[systemuser EntityType](systemuser.md)|msdyncrm_systemuser_msdyncrm_marketingemail_FromUser|
|msdyncrm_TemplateId|[msdyncrm_marketingemailtemplate EntityType](msdyncrm_marketingemailtemplate.md)|msdyncrm_msdyncrm_marketingemailtemplate_msdyncrm_|
|ownerid|[principal EntityType](principal.md)|owner_msdyncrm_marketingemail|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyncrm_marketingemail|
|owningteam|[team EntityType](team.md)|team_msdyncrm_marketingemail|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyncrm_marketingemail|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyncrm_marketingemail_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyncrm_marketingemail|  
|msdyncrm_marketingemail_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyncrm_marketingemail|  
|msdyncrm_marketingemail_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyncrm_marketingemail|  
|msdyncrm_marketingpage_marketingemail|[msdyncrm_marketingpage EntityType](msdyncrm_marketingpage.md)|msdyncrm_marketingpage_marketingemail|  
|msdyncrm_msdyncrm_marketingemail_contact_emailid|[contact EntityType](contact.md)|msdyncrm_emailid|  
|msdyncrm_msdyncrm_marketingemail_lead_emailid|[lead EntityType](lead.md)|msdyncrm_emailid|  
|msdyncrm_msdyncrm_marketingemail_msdyncrm_geopin|[msdyncrm_geopin EntityType](msdyncrm_geopin.md)|msdyncrm_MarketingEmailGeoPinsId|  

## Operations
The following operations can be used with the msdyncrm_marketingemail entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyncrm_marketingemail entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics Marketing Solution](../solutions/microsoftdynamicsmarketingcrmsolution.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicsmarketingcrmsolution.md](../solutions/descriptions/microsoftdynamicsmarketingcrmsolution.md)]|    

[!INCLUDE[./remarks/msdyncrm_marketingemail.md](./remarks/msdyncrm_marketingemail.md)]

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