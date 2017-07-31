---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_responserouting EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: f7314e7d-d5b1-4b7a-8d18-234e0c7a46aa
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_responserouting entitytype."
---
# msdyn_responserouting EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_responserouting.md](./descriptions/msdyn_responserouting.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyn_responseroutings </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Response Routing</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_responseroutingid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_responserouting entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was modified.<br />Read-only<br />|
|msdyn_group|Edm.Int32|**Display Name**: Group<br />**Description**: Select the response routing group.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>Group AND</td></tr><tr><td>986540001</td><td>Group OR</td></tr><tbody></table>|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: The name of the custom entity.<br />|
|msdyn_orderindex|Edm.Int32|**Display Name**: Order Index<br />**Description**: Use the order index to set the order routings are run<br />|
|msdyn_responseroutingid|Edm.Guid|**Display Name**: Routing<br />**Description**: Shows the entity instances.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Shows the status of the routing.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Shows the reason for the status of the routing.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Shows the time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Shows the user who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows the delegate user who created the record.|
|_modifiedby_value|modifiedby<br />|Shows the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows the delegate user who modified the record.|
|_msdyn_survey_value|msdyn_Survey<br />|Shows the published survey associated with the logic.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Shows the business unit that owns the record.|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_responserouting_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_responserouting_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_responserouting_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_responserouting_modifiedonbehalfby|
|msdyn_Survey|[msdyn_survey EntityType](msdyn_survey.md)|msdyn_survey_routing_Survey|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_responserouting|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_responserouting|
|owningteam|[team EntityType](team.md)|team_msdyn_responserouting|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_responserouting|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_msdyn_responserouting_msdyn_responsecondition_ResponseRouting|[msdyn_responsecondition EntityType](msdyn_responsecondition.md)|msdyn_ResponseRouting|  
|msdyn_responserouting_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_responserouting|  
|msdyn_responserouting_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_responserouting|  
|msdyn_responserouting_msdyn_responseaction|[msdyn_responseaction EntityType](msdyn_responseaction.md)|msdyn_responserouting_msdyn_responseaction|  
|msdyn_responserouting_responseaction_else|[msdyn_responseaction EntityType](msdyn_responseaction.md)|msdyn_responserouting_responseaction_else|  
|msdyn_responserouting_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_responserouting|  

## Operations
The following operations can be used with the msdyn_responserouting entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_responserouting entity type.


|Name|Description |  
|----|------------|  
|[Voice of the Customer for Microsoft Dynamics 365 Solution](../solutions/voiceofthecustomer.md)|[!INCLUDE[../solutions/descriptions/voiceofthecustomer.md](../solutions/descriptions/voiceofthecustomer.md)]|    

[!INCLUDE[./remarks/msdyn_responserouting.md](./remarks/msdyn_responserouting.md)]

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