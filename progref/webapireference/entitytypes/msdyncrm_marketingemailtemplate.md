---
title: "Microsoft Dynamics 365 Customer Engagement msdyncrm_marketingemailtemplate EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 5b218a42-e4e1-4aa1-9505-137f47770fec
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyncrm_marketingemailtemplate entitytype."
---
# msdyncrm_marketingemailtemplate EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyncrm_marketingemailtemplate.md](./descriptions/msdyncrm_marketingemailtemplate.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]msdyncrm_marketingemailtemplates </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Marketing Email Template</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyncrm_marketingemailtemplateid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyncrm_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyncrm_marketingemailtemplate entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyncrm_designerhtml|Edm.String|**Display Name**: Designer Html<br />**Description**: Clean email body - html with no css inlining, no compression<br />|
|msdyncrm_email_template_market_type_optionset|Edm.Int32|**Display Name**: Market Type<br />**Description**: Market Type<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>B2B</td></tr><tr><td>1</td><td>B2C</td></tr><tr><td>2</td><td>B2B & B2C</td></tr><tbody></table>|
|msdyncrm_email_template_optimizedfor_optionset|Edm.Int32|**Display Name**: Optimized For<br />**Description**: Optimized For<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Wide Reach</td></tr><tr><td>1</td><td>Mobile</td></tr><tr><td>2</td><td>Desktop</td></tr><tbody></table>|
|msdyncrm_email_template_purpose_optionset|Edm.Int32|**Display Name**: Purpose<br />**Description**: Purpose<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Structural</td></tr><tr><td>1</td><td>Activation</td></tr><tr><td>2</td><td>Announcement</td></tr><tr><td>3</td><td>Birthday</td></tr><tr><td>4</td><td>Blog Promotion</td></tr><tr><td>5</td><td>Content Promotion</td></tr><tr><td>6</td><td>Event Countdown</td></tr><tr><td>7</td><td>Event or Webinar Invitation</td></tr><tr><td>8</td><td>Follow-Up</td></tr><tr><td>9</td><td>Holiday Greetings</td></tr><tr><td>10</td><td>Information</td></tr><tr><td>11</td><td>Hospitality</td></tr><tr><td>12</td><td>Newsletter</td></tr><tr><td>13</td><td>Post Purchase</td></tr><tr><td>14</td><td>Promotional (Up-Sell/Cross-Sell)</td></tr><tr><td>15</td><td>Abandoned Shopping Cart</td></tr><tr><td>16</td><td>Thank You</td></tr><tr><td>17</td><td>Upcoming Event</td></tr><tr><td>18</td><td>Welcome</td></tr><tr><td>19</td><td>Win-Back/Re-Engage</td></tr><tr><td>20</td><td>Feedback Request</td></tr><tr><td>21</td><td>Anniversary</td></tr><tr><td>22</td><td>Lead Nurturing</td></tr><tbody></table>|
|msdyncrm_email_template_visual_style_optionset|Edm.Int32|**Display Name**: Visual Style<br />**Description**: Visual Style<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Other</td></tr><tr><td>1</td><td>Light</td></tr><tr><td>2</td><td>Colorful</td></tr><tr><td>3</td><td>Dark</td></tr><tbody></table>|
|msdyncrm_emailbody|Edm.String|**Display Name**: Email Body<br />|
|msdyncrm_marketingemailtemplateid|Edm.Guid|**Display Name**: Marketing Email Template<br />**Description**: Unique identifier for entity instances<br />|
|msdyncrm_name|Edm.String|**Display Name**: Name<br />**Description**: The name of the template.<br />|
|msdyncrm_sourceemailid|Edm.String|**Display Name**: sourceemailid<br />|
|msdyncrm_subject|Edm.String|**Display Name**: Subject<br />|
|msdyncrm_textpart|Edm.String|**Display Name**: Text Part<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Marketing Email Template<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Marketing Email Template<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Draft</td></tr><tr><td>192350001</td><td>Live</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_marketingemailtemplate_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_marketingemailtemplate_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_marketingemailtemplate_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_marketingemailtemplate_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_msdyncrm_marketingemailtemplate|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyncrm_marketingemailtemplate|
|owningteam|[team EntityType](team.md)|team_msdyncrm_marketingemailtemplate|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyncrm_marketingemailtemplate|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyncrm_marketingemailtemplate_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyncrm_marketingemailtemplate|  
|msdyncrm_marketingemailtemplate_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyncrm_marketingemailtemplate|  
|msdyncrm_marketingemailtemplate_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyncrm_marketingemailtemplate|  
|msdyncrm_msdyncrm_marketingemailtemplate_msdyncrm_|[msdyncrm_marketingemail EntityType](msdyncrm_marketingemail.md)|msdyncrm_TemplateId|  

## Operations
The following operations can be used with the msdyncrm_marketingemailtemplate entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyncrm_marketingemailtemplate entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics Marketing Solution](../solutions/microsoftdynamicsmarketingcrmsolution.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicsmarketingcrmsolution.md](../solutions/descriptions/microsoftdynamicsmarketingcrmsolution.md)]|    

[!INCLUDE[./remarks/msdyncrm_marketingemailtemplate.md](./remarks/msdyncrm_marketingemailtemplate.md)]

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