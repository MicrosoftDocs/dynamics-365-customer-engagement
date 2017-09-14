---
title: "Microsoft Dynamics 365 Customer Engagement sdkmessageprocessingstepsecureconfig EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 7de01abe-56b3-44b3-b2c8-8408025a7230
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API sdkmessageprocessingstepsecureconfig entitytype."
---
# sdkmessageprocessingstepsecureconfig EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/sdkmessageprocessingstepsecureconfig.md](./descriptions/sdkmessageprocessingstepsecureconfig.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]sdkmessageprocessingstepsecureconfigs </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Sdk Message Processing Step Secure Configuration</td></tr>
<tr><td><b>Primary Key:</b></td><td>sdkmessageprocessingstepsecureconfigid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>None</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The sdkmessageprocessingstepsecureconfig EntityType:
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the SDK message processing step was created.<br />Read-only<br />|
|customizationlevel|Edm.Int32|**Description**: Customization level of the SDK message processing step secure configuration.<br />Read-only<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the SDK message processing step was last modified.<br />Read-only<br />|
|sdkmessageprocessingstepsecureconfigid|Edm.Guid|**Description**: Unique identifier of the SDK message processing step secure configuration.<br />|
|sdkmessageprocessingstepsecureconfigidunique|Edm.Guid|**Description**: Unique identifier of the SDK message processing step.<br />Read-only<br />|
|secureconfig|Edm.String|**Display Name**: Secure Configuration<br />**Description**: Secure step-specific configuration for the plug-in type that is passed to the plug-in's constructor at run time.<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the SDK message processing step.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the sdkmessageprocessingstepsecureconfig.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the SDK message processing step.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the sdkmessageprocessingstepsecureconfig.|
|_organizationid_value|organizationid<br />|Unique identifier of the organization with which the SDK message processing step is associated.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|createdby_sdkmessageprocessingstepsecureconfig|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_sdkmessageprocessingstepsecureconfig_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|modifiedby_sdkmessageprocessingstepsecureconfig|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_sdkmessageprocessingstepsecureconfig_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_sdkmessageprocessingstepsecureconfig|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep|[sdkmessageprocessingstep EntityType](sdkmessageprocessingstep.md)|sdkmessageprocessingstepsecureconfigid|    

[!INCLUDE[./remarks/sdkmessageprocessingstepsecureconfig.md](./remarks/sdkmessageprocessingstepsecureconfig.md)]

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