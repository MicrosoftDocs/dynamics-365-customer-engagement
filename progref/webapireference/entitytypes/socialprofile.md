---
title: "Microsoft Dynamics 365 Customer Engagement socialprofile EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 28159a25-5aae-4273-b467-991b8520e6ff
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API socialprofile entitytype."
---
# socialprofile EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/socialprofile.md](./descriptions/socialprofile.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]socialprofiles </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Social Profile</td></tr>
<tr><td><b>Primary Key:</b></td><td>socialprofileid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>profilename</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  


## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|blocked|Edm.Boolean|**Display Name**: Blocked<br />**Description**: Identifies if the social profile has been blocked.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|community|Edm.Int32|**Display Name**: Social Channel<br />**Description**: Identifies where the social profile originated from, such as Twitter, or Facebook.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Facebook</td></tr><tr><td>2</td><td>Twitter</td></tr><tr><td>0</td><td>Other</td></tr><tbody></table>|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Unique identifier of the data import or data migration that created this record.<br />|
|influencescore|Edm.Double|**Display Name**: Influence Score<br />**Description**: Shows the score that determines the online social influence of the social profile.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|profilefullname|Edm.String|**Display Name**: Full Name<br />**Description**: Shows the display name of the customer on this social profile.<br />|
|profilelink|Edm.String|**Display Name**: Profile Link<br />**Description**: Shows the customer that this social profile belongs to.<br />|
|profilename|Edm.String|**Display Name**: Profile Name<br />**Description**: Shows the name of the social profile on the corresponding social channel.<br />|
|socialprofileid|Edm.Guid|**Display Name**: Social Profile ID<br />**Description**: Unique Identifier of the social profile name.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Social Profile<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Social Profile<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|uniqueprofileid|Edm.String|**Display Name**: Unique Profile ID<br />**Description**: Unique ID of the Profile ID<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version number of the social profile.<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value||Unique identifier of the user who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the record.|
|_customerid_value|customerid_contact<br />customerid_account<br />|Shows the customer that this social profile belongs to.|
|_modifiedby_value||Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who modified the record.|
|_ownerid_value|ownerid<br />|Shows the user or team that is assigned to manage the record. This field is updated every time the record is assigned to a different user.|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value||Unique identifier of the team who owns the contact.|
|_owninguser_value|owninguser<br />|Unique identifier of the user who owns the contact.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Choose the local currency for the record to make sure budgets are reported in the correct currency.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_SocialProfile_createdonbehalfby|
|customerid_account|[account EntityType](account.md)|Socialprofile_customer_accounts|
|customerid_contact|[contact EntityType](contact.md)|Socialprofile_customer_contacts|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_SocialProfile_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_SocialProfile|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_socialprofiles|
|owninguser|[systemuser EntityType](systemuser.md)|socialProfile_owning_user|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|transactioncurrency_SocialProfile|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|SocialProfile_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_socialprofile|  
|socialprofile_cases|[incident EntityType](incident.md)|socialprofileid|  
|socialprofile_connections1|[connection EntityType](connection.md)|record1id_socialprofile|  
|socialprofile_connections2|[connection EntityType](connection.md)|record2id_socialprofile|  
|SocialProfile_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_socialprofile|  
|SocialProfile_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_socialprofile|  
|Socialprofile_SocialActivities|[socialactivity EntityType](socialactivity.md)|postfromprofileid|  
|SocialProfile_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_socialprofile_syncerror|  

## Operations
The following operations can be used with the socialprofile entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GenerateSocialProfile Action](../actions/generatesocialprofile.md)|Collection|[!INCLUDE[../actions/descriptions/generatesocialprofile.md](../actions/descriptions/generatesocialprofile.md)]|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the socialprofile entity type.


|Name|Description |  
|----|------------|  
|[SocialProfile Solution](../solutions/socialprofile.md)|[!INCLUDE[../solutions/descriptions/socialprofile.md](../solutions/descriptions/socialprofile.md)]|  
|[SalesService Solution](../solutions/salesservice.md)|[!INCLUDE[../solutions/descriptions/salesservice.md](../solutions/descriptions/salesservice.md)]|  
|[Microsoft Dynamics Sales Workload Solution](../solutions/sales.md)|[!INCLUDE[../solutions/descriptions/sales.md](../solutions/descriptions/sales.md)]|  
|[Microsoft Dynamics Service Workload Solution](../solutions/service.md)|[!INCLUDE[../solutions/descriptions/service.md](../solutions/descriptions/service.md)]|    

[!INCLUDE[./remarks/socialprofile.md](./remarks/socialprofile.md)]

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