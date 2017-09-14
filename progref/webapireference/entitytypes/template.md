---
title: "Microsoft Dynamics 365 Customer Engagement template EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: b9687de4-dec1-42a4-8a5a-ff5c756528d5
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API template entitytype."
---
# template EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/template.md](./descriptions/template.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]templates </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Email Template</td></tr>
<tr><td><b>Primary Key:</b></td><td>templateid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>title</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The template entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|body|Edm.String|**Display Name**: Body<br />**Description**: Body text of the email template.<br />|
|componentstate|Edm.Int32|**Display Name**: Component State<br />**Description**: For internal use only.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Published</td></tr><tr><td>1</td><td>Unpublished</td></tr><tr><td>2</td><td>Deleted</td></tr><tr><td>3</td><td>Deleted Unpublished</td></tr><tbody></table>|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the email template was created.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Description of the email template.<br />|
|generationtypecode|Edm.Int32|**Display Name**: Generation Type Code<br />**Description**: For internal use only.<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Unique identifier of the data import or data migration that created this record.<br />|
|introducedversion|Edm.String|**Display Name**: Introduced Version<br />**Description**: Version in which the form is introduced.<br />|
|iscustomizable|[BooleanManagedProperty ComplexType](../complextypes/booleanmanagedproperty.md)|**Display Name**: Customizable<br />**Description**: Information that specifies whether this component can be customized.<br />|
|ismanaged|Edm.Boolean|**Display Name**: Is Managed<br />**Description**: Indicates whether the solution component is part of a managed solution.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Managed</td></tr><tr><td>0</td><td>Unmanaged</td></tr><tbody></table>|
|ispersonal|Edm.Boolean|**Display Name**: Viewable By<br />**Description**: Information about whether the template is personal or is available to all users.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Individual</td></tr><tr><td>0</td><td>Organization</td></tr><tbody></table>|
|isrecommended|Edm.Boolean|**Display Name**: Recommended<br />**Description**: Indicates if a template is recommended by Dynamics 365.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|languagecode|Edm.Int32|**Display Name**: Language<br />**Description**: Language of the email template.<br />|
|mimetype|Edm.String|**Display Name**: Mime Type<br />**Description**: MIME type of the email template.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the email template was last modified.<br />Read-only<br />|
|opencount|Edm.Int32|**Display Name**: Open Count<br />**Description**: For internal use only. Shows the number of times emails that use this template have been opened.<br />Read-only<br />|
|openrate|Edm.Int32|**Display Name**: Open Rate<br />**Description**: Shows the open rate of this template. This is based on number of opens on followed emails that use this template.<br />Read-only<br />|
|overwritetime|Edm.DateTimeOffset|**Display Name**: Record Overwrite Time<br />**Description**: For internal use only.<br />Read-only<br />|
|presentationxml|Edm.String|**Display Name**: Presentation XML<br />**Description**: XML data for the body of the email template.<br />|
|replycount|Edm.Int32|**Display Name**: Reply Count<br />**Description**: For internal use only. Shows the number of times emails that use this template have received replies.<br />Read-only<br />|
|replyrate|Edm.Int32|**Display Name**: Reply Rate<br />**Description**: Shows the reply rate for this template. This is based on number of replies received on followed emails that use this template.<br />Read-only<br />|
|solutionid|Edm.Guid|**Display Name**: Solution<br />**Description**: Unique identifier of the associated solution.<br />Read-only<br />|
|subject|Edm.String|**Display Name**: Subject<br />**Description**: Subject associated with the email template.<br />|
|subjectpresentationxml|Edm.String|**Display Name**: Subject XML<br />**Description**: XML data for the subject of the email template.<br />|
|templateid|Edm.Guid|**Display Name**: Email Template<br />**Description**: Unique identifier of the template.<br />|
|templateidunique|Edm.Guid|**Description**: For internal use only.<br />Read-only<br />|
|templatetypecode|Edm.String|**Display Name**: Template Type<br />**Description**: Type of email template.<br />|
|title|Edm.String|**Display Name**: Title<br />**Description**: Title of the template.<br />|
|usedcount|Edm.Int32|**Display Name**: Sent email count<br />**Description**: Shows the number of sent emails that use this template.<br />Read-only<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version number of the template.<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the email template.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the template.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the template.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified the template.|
|_ownerid_value|ownerid<br />|Unique identifier of the user or team who owns the template for the email activity.|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier of the business unit that owns the template.|
|_owningteam_value|owningteam<br />|Unique identifier of the team who owns the template.|
|_owninguser_value|owninguser<br />|Unique identifier of the user who owns the template.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_templatebase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_templatebase_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_templatebase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_templatebase_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_templates|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_templates|
|owningteam|[team EntityType](team.md)|team_email_templates|
|owninguser|[systemuser EntityType](systemuser.md)|system_user_email_templates|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|Email_EmailTemplate|[email EntityType](email.md)|templateid|  
|template_activity_mime_attachments|[activitymimeattachment EntityType](activitymimeattachment.md)|objectid_template|  
|Template_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_template|  
|Template_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_template|  
|Template_Organization|[organization EntityType](organization.md)|acknowledgementtemplateid|  
|Template_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_template_syncerror|  

## Operations
The following operations can be used with the template entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[InstantiateTemplate Action](../actions/instantiatetemplate.md)|Not Bound|[!INCLUDE[../actions/descriptions/instantiatetemplate.md](../actions/descriptions/instantiatetemplate.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  
|[SendEmail Action](../actions/sendemail.md)|Not Bound|[!INCLUDE[../actions/descriptions/sendemail.md](../actions/descriptions/sendemail.md)]|  
|[SendFax Action](../actions/sendfax.md)|Not Bound|[!INCLUDE[../actions/descriptions/sendfax.md](../actions/descriptions/sendfax.md)]|  
|[SendTemplate Action](../actions/sendtemplate.md)|Not Bound|[!INCLUDE[../actions/descriptions/sendtemplate.md](../actions/descriptions/sendtemplate.md)]|  

## Solutions
The following solutions include the template entity type.


|Name|Description |  
|----|------------|  
|[App for Outlook Solution](../solutions/appforoutlook.md)|[!INCLUDE[../solutions/descriptions/appforoutlook.md](../solutions/descriptions/appforoutlook.md)]|  
|[Activities Solution](../solutions/activities.md)|[!INCLUDE[../solutions/descriptions/activities.md](../solutions/descriptions/activities.md)]|  
|[Microsoft Dynamics Sales Workload Solution](../solutions/sales.md)|[!INCLUDE[../solutions/descriptions/sales.md](../solutions/descriptions/sales.md)]|  
|[Microsoft Dynamics Service Workload Solution](../solutions/service.md)|[!INCLUDE[../solutions/descriptions/service.md](../solutions/descriptions/service.md)]|  
|[Microsoft Dynamics CRM Marketing Solution](../solutions/marketing.md)|[!INCLUDE[../solutions/descriptions/marketing.md](../solutions/descriptions/marketing.md)]|    

[!INCLUDE[./remarks/template.md](./remarks/template.md)]

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