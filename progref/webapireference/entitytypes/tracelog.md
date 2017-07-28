---
title: "Microsoft Dynamics 365 Customer Engagement tracelog EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 5b3f8060-76cb-4299-8b02-7b0784c93cab
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API tracelog entitytype."
---
# tracelog EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/tracelog.md](./descriptions/tracelog.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]tracelogs </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Trace</td></tr>
<tr><td><b>Primary Key:</b></td><td>tracelogid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>text</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,DELETE</td></tr>
</table>
  
The tracelog EntityType:
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|canbedeleted|Edm.Boolean|**Display Name**: Trace CanBeDeleted Flag<br />**Description**: Indicates if this trace log can be deleted.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|collationlevel|Edm.Int32|**Display Name**: Collation Level<br />**Description**: Indicates the collation level<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Time the error is created and logged.<br />Read-only<br />|
|errordetails|Edm.String||
|errortypedisplay|Edm.String|**Display Name**: Trace Error Details<br />|
|isunique|Edm.Boolean|**Display Name**: Is Unique Trace<br />**Description**: Tells if this traceLog is created uniquely(only one) for the associated entity.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|level|Edm.Int32|**Display Name**: Level<br />**Description**: Information about the trace level.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Information</td></tr><tr><td>2</td><td>Warning</td></tr><tr><td>3</td><td>Error</td></tr><tbody></table>|
|machinename|Edm.String||
|modifiedon|Edm.DateTimeOffset|**Display Name**: Last Update On<br />**Description**: Time the error is updated and logged for the same regarding object.<br />Read-only<br />|
|text|Edm.String|**Display Name**: Text<br />**Description**: Text of the trace.<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|traceactionxml|Edm.String|**Display Name**: Trace Actions XML<br />**Description**: XML representation of the trace actions.<br />|
|tracecode|Edm.Int32|**Display Name**: Error Code<br />**Description**: Error code.<br />|
|tracedetailxml|Edm.String|**Display Name**: Trace Detail XML<br />**Description**: XML representation of the trace details.<br />|
|tracelogid|Edm.Guid|**Display Name**: Trace<br />**Description**: Unique identifier of the trace.<br />|
|traceparameterhash|Edm.Int32|**Display Name**: Trace Parameter Hash<br />**Description**: Stores the hash of the entity object associated with this tracelog. Hash is computed using the object type code and its id.<br />Read-only<br />|
|traceparameterxml|Edm.String|**Display Name**: Trace Parameter XML<br />**Description**: XML representation of the trace parameters.<br />|
|tracestatus|Edm.Boolean|**Display Name**: Trace Status<br />**Description**: Status about the trace.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Success</td></tr><tr><td>0</td><td>Failure</td></tr><tbody></table>|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the trace was created.<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the trace.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the trace.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who modified the trace.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who modified the trace.|
|_organizationid_value|organizationid<br />|Unique identifier of the organization associated with the trace.|
|_parenttracelogid_value|parenttracelogid<br />|Indicates the parent ID of the trace log.|
|_regardingobjectid_value|regardingobjectid_mailbox<br />regardingobjectid_emailserverprofile<br />|Regarding mailbox or email server profile.|
|_regardingobjectownerid_value||Unique identifier of the user or team who owns the regarding object.|
|_regardingobjectowningbusinessunit_value||Unique identifier of the business unit that owns the regarding object.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_tracelog_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_tracelog_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_tracelog_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_tracelog_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_tracelog|
|parenttracelogid|[tracelog EntityType](tracelog.md)|tracelog_parent_tracelog|
|regardingobjectid_emailserverprofile|[emailserverprofile EntityType](emailserverprofile.md)|tracelog_EmailServerProfile|
|regardingobjectid_mailbox|[mailbox EntityType](mailbox.md)|tracelog_Mailbox|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|tracelog_parent_tracelog|[tracelog EntityType](tracelog.md)|parenttracelogid|    

[!INCLUDE[./remarks/tracelog.md](./remarks/tracelog.md)]

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