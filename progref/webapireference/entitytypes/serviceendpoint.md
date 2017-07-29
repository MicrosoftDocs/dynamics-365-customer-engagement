---
title: "Microsoft Dynamics 365 Customer Engagement serviceendpoint EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 302cc977-c26b-4001-be1e-759f1af5ab6c
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API serviceendpoint entitytype."
---
# serviceendpoint EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/serviceendpoint.md](./descriptions/serviceendpoint.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]serviceendpoints </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Service Endpoint</td></tr>
<tr><td><b>Primary Key:</b></td><td>serviceendpointid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The serviceendpoint entitytype is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|authtype|Edm.Int32|**Display Name**: Specifies mode of authentication with SB<br />**Description**: Specifies mode of authentication with SB<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>ACS</td></tr><tr><td>2</td><td>SAS Key</td></tr><tr><td>3</td><td>SAS Token</td></tr><tr><td>4</td><td>Webhook Key</td></tr><tr><td>5</td><td>Http Header</td></tr><tr><td>6</td><td>Http Query String</td></tr><tbody></table>|
|authvalue|Edm.String|**Display Name**: Authentication Value<br />**Description**: Authentication Value<br />|
|componentstate|Edm.Int32|**Display Name**: Component State<br />**Description**: For internal use only.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Published</td></tr><tr><td>1</td><td>Unpublished</td></tr><tr><td>2</td><td>Deleted</td></tr><tr><td>3</td><td>Deleted Unpublished</td></tr><tbody></table>|
|connectionmode|Edm.Int32|**Display Name**: Connection Mode<br />**Description**: Connection mode to contact the service endpoint.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Normal</td></tr><tr><td>2</td><td>Federated</td></tr><tbody></table>|
|contract|Edm.Int32|**Display Name**: Contract<br />**Description**: Type of the endpoint contract.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>OneWay</td></tr><tr><td>2</td><td>Queue</td></tr><tr><td>3</td><td>Rest</td></tr><tr><td>4</td><td>TwoWay</td></tr><tr><td>5</td><td>Topic</td></tr><tr><td>6</td><td>Queue (Persistent)</td></tr><tr><td>7</td><td>Event Hub</td></tr><tr><td>8</td><td>Webhook</td></tr><tbody></table>|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the service endpoint was created.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Description of the service endpoint.<br />|
|introducedversion|Edm.String|**Display Name**: Introduced Version<br />**Description**: Version in which the form is introduced.<br />|
|isauthvalueset|Edm.Boolean|Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|iscustomizable|[BooleanManagedProperty ComplexType](../complextypes/booleanmanagedproperty.md)|**Display Name**: Customizable<br />**Description**: Information that specifies whether this component can be customized.<br />|
|ismanaged|Edm.Boolean|**Display Name**: State<br />**Description**: Information that specifies whether this component is managed.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Managed</td></tr><tr><td>0</td><td>Unmanaged</td></tr><tbody></table>|
|issaskeyset|Edm.Boolean|Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|issastokenset|Edm.Boolean|Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|messageformat|Edm.Int32|**Display Name**: Content type of the message<br />**Description**: Content type of the message<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Binary XML</td></tr><tr><td>2</td><td>Json</td></tr><tr><td>3</td><td>Text XML</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the service endpoint was last modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Name of Service end point.<br />|
|namespaceaddress|Edm.String|**Display Name**: Namespace Address<br />**Description**: Full service endpoint address.<br />|
|namespaceformat|Edm.Int32|**Display Name**: Format of Service Bus Namespace<br />**Description**: Format of Service Bus Namespace<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Namespace Name</td></tr><tr><td>2</td><td>Namespace Address</td></tr><tbody></table>|
|overwritetime|Edm.DateTimeOffset|**Display Name**: Record Overwrite Time<br />**Description**: For internal use only.<br />Read-only<br />|
|path|Edm.String|**Display Name**: Path<br />**Description**: Path to the service endpoint.<br />|
|saskey|Edm.String|**Display Name**: Shared Access Key<br />**Description**: Shared Access Key<br />|
|saskeyname|Edm.String|**Display Name**: Shared Access Key Name<br />**Description**: Shared Access Key Name<br />|
|sastoken|Edm.String|**Display Name**: Shared Access Token<br />**Description**: Shared Access Token<br />|
|serviceendpointid|Edm.Guid|**Description**: Unique identifier of the service endpoint.<br />|
|serviceendpointidunique|Edm.Guid|**Description**: Unique identifier of the service endpoint.<br />Read-only<br />|
|solutionid|Edm.Guid|**Display Name**: Solution<br />**Description**: Unique identifier of the associated solution.<br />Read-only<br />|
|solutionnamespace|Edm.String|**Display Name**: Service Namespace<br />**Description**: Namespace of the App Fabric solution.<br />|
|url|Edm.String|**Display Name**: Url Address<br />**Description**: Full service endpoint Url.<br />|
|userclaim|Edm.Int32|**Display Name**: User Claim<br />**Description**: Additional user claim value type.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>None</td></tr><tr><td>2</td><td>UserId</td></tr><tr><td>3</td><td>UserInfo</td></tr><tbody></table>|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the service endpoint.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the service endpoint.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the service endpoint.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who modified the service endpoint.|
|_organizationid_value|organizationid<br />|Unique identifier of the organization with which the service endpoint is associated.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|createdby_serviceendpoint|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_serviceendpointbase_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|modifiedby_serviceendpoint|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_serviceendpointbase_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_serviceendpoint|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|serviceendpoint_sdkmessageprocessingstep|[sdkmessageprocessingstep EntityType](sdkmessageprocessingstep.md)|eventhandler_serviceendpoint|  

## Operations
The following operations can be used with the serviceendpoint entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[TriggerServiceEndpointCheck Action](../actions/triggerserviceendpointcheck.md)|Entity|[!INCLUDE[../actions/descriptions/triggerserviceendpointcheck.md](../actions/descriptions/triggerserviceendpointcheck.md)]|    

[!INCLUDE[./remarks/serviceendpoint.md](./remarks/serviceendpoint.md)]

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