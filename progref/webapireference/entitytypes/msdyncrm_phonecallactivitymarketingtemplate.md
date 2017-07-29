---
title: "Microsoft Dynamics 365 Customer Engagement msdyncrm_phonecallactivitymarketingtemplate EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 16c718b3-467d-4929-b009-8fe905722bca
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyncrm_phonecallactivitymarketingtemplate entitytype."
---
# msdyncrm_phonecallactivitymarketingtemplate EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyncrm_phonecallactivitymarketingtemplate.md](./descriptions/msdyncrm_phonecallactivitymarketingtemplate.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]msdyncrm_phonecallactivitymarketingtemplates </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Phone Call Activity Marketing Template</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyncrm_phonecallactivitymarketingtemplateid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyncrm_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyncrm_phonecallactivitymarketingtemplate entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyncrm_actualdurationminutes|Edm.Int32|**Display Name**: Duration<br />**Description**: Type the number of minutes spent on the phone call. The duration is used in reporting.<br />|
|msdyncrm_description|Edm.String|**Display Name**: Description<br />**Description**: Type additional information to describe the phone call, such as the primary message or the products and services discussed.<br />|
|msdyncrm_name|Edm.String|**Display Name**: Name<br />**Description**: The name of the custom entity.<br />|
|msdyncrm_phonecallactivitymarketingtemplateid|Edm.Guid|**Display Name**: Phone Call Activity Marketing Template<br />**Description**: Unique identifier for entity instances<br />|
|msdyncrm_prioritycode|Edm.Int32|**Display Name**: Priority<br />**Description**: Select the priority so that preferred customers or critical issues are handled quickly.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Low</td></tr><tr><td>1</td><td>Normal</td></tr><tr><td>2</td><td>High</td></tr><tbody></table>|
|msdyncrm_scheduletype|Edm.Int32|**Display Name**: Schedule type<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Fixed date</td></tr><tr><td>1</td><td>Delay in days</td></tr><tbody></table>|
|msdyncrm_startdate|Edm.Date|**Display Name**: Start date<br />|
|msdyncrm_startdelay|Edm.Int32|**Display Name**: Start delay<br />|
|msdyncrm_starttimehour|Edm.Int32|**Display Name**: Start Time Hour<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>00</td></tr><tr><td>1</td><td>01</td></tr><tr><td>2</td><td>02</td></tr><tr><td>3</td><td>03</td></tr><tr><td>4</td><td>04</td></tr><tr><td>5</td><td>05</td></tr><tr><td>6</td><td>06</td></tr><tr><td>7</td><td>07</td></tr><tr><td>8</td><td>08</td></tr><tr><td>9</td><td>09</td></tr><tr><td>10</td><td>10</td></tr><tr><td>11</td><td>11</td></tr><tr><td>12</td><td>12</td></tr><tr><td>13</td><td>13</td></tr><tr><td>14</td><td>14</td></tr><tr><td>15</td><td>15</td></tr><tr><td>16</td><td>16</td></tr><tr><td>17</td><td>17</td></tr><tr><td>18</td><td>18</td></tr><tr><td>19</td><td>19</td></tr><tr><td>20</td><td>20</td></tr><tr><td>21</td><td>21</td></tr><tr><td>22</td><td>22</td></tr><tr><td>23</td><td>23</td></tr><tbody></table>|
|msdyncrm_starttimeminute|Edm.Int32|**Display Name**: Start Time Minute<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>00</td></tr><tr><td>15</td><td>15</td></tr><tr><td>30</td><td>30</td></tr><tr><td>45</td><td>45</td></tr><tbody></table>|
|msdyncrm_subject|Edm.String|**Display Name**: Subject<br />**Description**: Type a short description about the objective or primary topic of the phone call.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Phone Call Activity Marketing Template<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Phone Call Activity Marketing Template<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_phonecallactivitymarketingtemplate_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_phonecallactivitymarketingtemplate_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_phonecallactivitymarketingtemplate_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyncrm_phonecallactivitymarketingtemplate_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_msdyncrm_phonecallactivitymarketingtemplate|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyncrm_phonecallactivitymarketingtemplate|
|owningteam|[team EntityType](team.md)|team_msdyncrm_phonecallactivitymarketingtemplate|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyncrm_phonecallactivitymarketingtemplate|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyncrm_phonecallactivitymarketingtemplate_Annotations|[annotation EntityType](annotation.md)|objectid_msdyncrm_phonecallactivitymarketingtemplate|  
|msdyncrm_phonecallactivitymarketingtemplate_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyncrm_phonecallactivitymarketingtemplate|  
|msdyncrm_phonecallactivitymarketingtemplate_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyncrm_phonecallactivitymarketingtemplate|  
|msdyncrm_phonecallactivitymarketingtemplate_connections1|[connection EntityType](connection.md)|record1id_msdyncrm_phonecallactivitymarketingtemplate|  
|msdyncrm_phonecallactivitymarketingtemplate_connections2|[connection EntityType](connection.md)|record2id_msdyncrm_phonecallactivitymarketingtemplate|  
|msdyncrm_phonecallactivitymarketingtemplate_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyncrm_phonecallactivitymarketingtemplate|  
|msdyncrm_phonecallactivitymarketingtemplate_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyncrm_phonecallactivitymarketingtemplate|  
|msdyncrm_phonecallactivitymarketingtemplate_Feedback|[feedback EntityType](feedback.md)|regardingobjectid_msdyncrm_phonecallactivitymarketingtemplate|  
|msdyncrm_phonecallactivitymarketingtemplate_QueueItems|[queueitem EntityType](queueitem.md)|objectid_msdyncrm_phonecallactivitymarketingtemplate|  
|msdyncrm_phonecallactivitymarketingtemplate_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyncrm_phonecallactivitymarketingtemplate|  

## Operations
The following operations can be used with the msdyncrm_phonecallactivitymarketingtemplate entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyncrm_phonecallactivitymarketingtemplate entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics Marketing Solution](../solutions/microsoftdynamicsmarketingcrmsolution.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicsmarketingcrmsolution.md](../solutions/descriptions/microsoftdynamicsmarketingcrmsolution.md)]|    

[!INCLUDE[./remarks/msdyncrm_phonecallactivitymarketingtemplate.md](./remarks/msdyncrm_phonecallactivitymarketingtemplate.md)]

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