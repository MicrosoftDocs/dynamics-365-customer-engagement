---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_invoicefrequencydetail EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 5e64e1aa-6fa0-4741-ad2a-1dafe20458ea
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_invoicefrequencydetail entitytype."
---
# msdyn_invoicefrequencydetail EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_invoicefrequencydetail.md](./descriptions/msdyn_invoicefrequencydetail.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyn_invoicefrequencydetails </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Invoice Frequency Detail</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_invoicefrequencydetailid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_invoicefrequencydetail entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyn_dayofmonth|Edm.Int32|**Display Name**: Day of month<br />**Description**: Specify the day(s) of the month on which invoicing should run<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350001</td><td>1</td></tr><tr><td>192350002</td><td>2</td></tr><tr><td>192350003</td><td>3</td></tr><tr><td>192350004</td><td>4</td></tr><tr><td>192350005</td><td>5</td></tr><tr><td>192350006</td><td>6</td></tr><tr><td>192350007</td><td>7</td></tr><tr><td>192350008</td><td>8</td></tr><tr><td>192350009</td><td>9</td></tr><tr><td>192350010</td><td>10</td></tr><tr><td>192350011</td><td>11</td></tr><tr><td>192350012</td><td>12</td></tr><tr><td>192350013</td><td>13</td></tr><tr><td>192350014</td><td>14</td></tr><tr><td>192350015</td><td>15</td></tr><tr><td>192350016</td><td>16</td></tr><tr><td>192350017</td><td>17</td></tr><tr><td>192350018</td><td>18</td></tr><tr><td>192350019</td><td>19</td></tr><tr><td>192350020</td><td>20</td></tr><tr><td>192350021</td><td>21</td></tr><tr><td>192350022</td><td>22</td></tr><tr><td>192350023</td><td>23</td></tr><tr><td>192350024</td><td>24</td></tr><tr><td>192350025</td><td>25</td></tr><tr><td>192350026</td><td>26</td></tr><tr><td>192350027</td><td>27</td></tr><tr><td>192350028</td><td>28</td></tr><tr><td>192350029</td><td>29</td></tr><tr><td>192350030</td><td>30</td></tr><tr><td>192350031</td><td>31</td></tr><tbody></table>|
|msdyn_invoicefrequencydetailid|Edm.Guid|**Display Name**: Invoice Frequency Detail<br />**Description**: Unique identifier for entity instances<br />|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: Type the name of the custom entity.<br />|
|msdyn_occurrenceofweekday|Edm.Int32|**Display Name**: Occurrence of weekday<br />**Description**: Specifies which occurrence of a weekday the invoicing job should run if there are multiple occurrences of a weekday in the selected period<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>First</td></tr><tr><td>192350001</td><td>Second</td></tr><tr><td>192350002</td><td>Third</td></tr><tr><td>192350003</td><td>Fourth</td></tr><tr><td>192350004</td><td>Last</td></tr><tbody></table>|
|msdyn_weekday|Edm.Int32|**Display Name**: Weekday<br />**Description**: Select the weekday of the invoicing job run.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>192350000</td><td>Sunday</td></tr><tr><td>192350001</td><td>Monday</td></tr><tr><td>192350002</td><td>Tuesday</td></tr><tr><td>192350003</td><td>Wednesday</td></tr><tr><td>192350004</td><td>Thursday</td></tr><tr><td>192350005</td><td>Friday</td></tr><tr><td>192350006</td><td>Saturday</td></tr><tbody></table>|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Invoice Frequency Detail<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Invoice Frequency Detail<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyn_invoicefrequency_value|msdyn_invoicefrequency<br />|Select the invoice frequency.|
|_organizationid_value|organizationid<br />|Unique identifier for the organization|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_invoicefrequencydetail_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_invoicefrequencydetail_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_invoicefrequencydetail_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_invoicefrequencydetail_modifiedonbehalfby|
|msdyn_invoicefrequency|[msdyn_invoicefrequency EntityType](msdyn_invoicefrequency.md)|msdyn_msdyn_invoicefrequency_msdyn_invoicefrequencydetail_invoicefrequency|
|organizationid|[organization EntityType](organization.md)|organization_msdyn_invoicefrequencydetail|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_invoicefrequencydetail_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_invoicefrequencydetail|  
|msdyn_invoicefrequencydetail_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_invoicefrequencydetail|  
|msdyn_invoicefrequencydetail_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_invoicefrequencydetail|  
|msdyn_invoicefrequencydetail_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_invoicefrequencydetail|  
|msdyn_invoicefrequencydetail_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_invoicefrequencydetail|  

## Operations
The following operations can be used with the msdyn_invoicefrequencydetail entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  

## Solutions
The following solutions include the msdyn_invoicefrequencydetail entity type.


|Name|Description |  
|----|------------|  
|[Project Service Automation Solution](../solutions/projectservice.md)|[!INCLUDE[../solutions/descriptions/projectservice.md](../solutions/descriptions/projectservice.md)]|    

[!INCLUDE[./remarks/msdyn_invoicefrequencydetail.md](./remarks/msdyn_invoicefrequencydetail.md)]

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