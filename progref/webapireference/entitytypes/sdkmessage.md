---
title: "Microsoft Dynamics 365 Customer Engagement sdkmessage EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 5cf179ce-706b-4a59-8f1d-4c629174e452
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API sdkmessage entitytype."
---
# sdkmessage EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/sdkmessage.md](./descriptions/sdkmessage.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]sdkmessages </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Sdk Message</td></tr>
<tr><td><b>Primary Key:</b></td><td>sdkmessageid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>GET</td></tr>
</table>
  
The sdkmessage EntityType:
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|autotransact|Edm.Boolean|**Display Name**: Auto Transact<br />**Description**: Information about whether the SDK message is automatically transacted.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|availability|Edm.Int32|**Display Name**: Availability<br />**Description**: Identifies where a method will be exposed. 0 - Server, 1 - Client, 2 - both.<br />|
|categoryname|Edm.String|**Display Name**: Category Name<br />**Description**: If this is a categorized method, this is the name, otherwise None.<br />|
|componentstate|Edm.Int32|**Display Name**: Component State<br />**Description**: For internal use only.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Published</td></tr><tr><td>1</td><td>Unpublished</td></tr><tr><td>2</td><td>Deleted</td></tr><tr><td>3</td><td>Deleted Unpublished</td></tr><tbody></table>|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the SDK message was created.<br />Read-only<br />|
|customizationlevel|Edm.Int32|**Description**: Customization level of the SDK message.<br />Read-only<br />|
|expand|Edm.Boolean|**Display Name**: Expand<br />**Description**: Indicates whether the SDK message should have its requests expanded per primary entity defined in its filters.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|introducedversion|Edm.String|**Display Name**: Introduced Version<br />**Description**: Version in which the component is introduced.<br />|
|isactive|Edm.Boolean|**Display Name**: Is Active<br />**Description**: Information about whether the SDK message is active.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|ismanaged|Edm.Boolean|**Display Name**: State<br />**Description**: Information that specifies whether this component is managed.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Managed</td></tr><tr><td>0</td><td>Unmanaged</td></tr><tbody></table>|
|isprivate|Edm.Boolean|**Display Name**: Is Private<br />**Description**: Indicates whether the SDK message is private.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isreadonly|Edm.Boolean|**Display Name**: Intent<br />**Description**: Identifies whether an SDK message will be ReadOnly or Read Write. false - ReadWrite, true - ReadOnly .<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isvalidforexecuteasync|Edm.Boolean|**Display Name**: Is Valid for Execute Async<br />**Description**: For internal use only.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the SDK message was last modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Name of the SDK message.<br />|
|overwritetime|Edm.DateTimeOffset|**Display Name**: Record Overwrite Time<br />**Description**: For internal use only.<br />Read-only<br />|
|sdkmessageid|Edm.Guid|**Description**: Unique identifier of the SDK message entity.<br />|
|sdkmessageidunique|Edm.Guid|**Description**: Unique identifier of the SDK message.<br />Read-only<br />|
|solutionid|Edm.Guid|**Display Name**: Solution<br />**Description**: Unique identifier of the associated solution.<br />Read-only<br />|
|template|Edm.Boolean|**Display Name**: Template<br />**Description**: Indicates whether the SDK message is a template.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|throttlesettings|Edm.String|**Display Name**: Throttle Settings<br />**Description**: For internal use only.<br />Read-only<br />|
|versionnumber|Edm.Int64|**Description**: Number that identifies a specific revision of the SDK message. <br />Read-only<br />|
|workflowsdkstepenabled|Edm.Boolean|**Display Name**: WorkflowSdkStepEnabled<br />**Description**: Whether or not the SDK message can be called from a workflow.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the SDK message.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the sdkmessage.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the SDK message.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the sdkmessage.|
|_organizationid_value|organizationid<br />|Unique identifier of the organization with which the SDK message is associated.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|createdby_sdkmessage|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_sdkmessage_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|modifiedby_sdkmessage|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_sdkmessage_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_sdkmessage|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|sdkmessageid_sdkmessagefilter|[sdkmessagefilter EntityType](sdkmessagefilter.md)|sdkmessageid|  
|sdkmessageid_sdkmessageprocessingstep|[sdkmessageprocessingstep EntityType](sdkmessageprocessingstep.md)|sdkmessageid|    

[!INCLUDE[./remarks/sdkmessage.md](./remarks/sdkmessage.md)]

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