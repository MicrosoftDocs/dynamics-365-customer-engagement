---
title: "Microsoft Dynamics 365 Customer Engagement list EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: ace4973a-7d83-441d-a981-0556fcd2d9b4
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API list entitytype."
---
# list EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/list.md](./descriptions/list.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]lists </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Marketing List</td></tr>
<tr><td><b>Primary Key:</b></td><td>listid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>listname</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  


## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|cost|Edm.Decimal|**Display Name**: Cost<br />**Description**: Type the cost of obtaining the marketing list.<br />|
|cost_base|Edm.Decimal|**Display Name**: Cost (Base)<br />**Description**: Value of the Cost in base currency.<br />Read-only<br />|
|createdfromcode|Edm.Int32|**Display Name**: Marketing List Member Type<br />**Description**: Select the type of members that this marketing list will contain: accounts, contacts, or leads. Each list can have only one member type and this value can't be changed after the marketing list is created.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Account</td></tr><tr><td>2</td><td>Contact</td></tr><tr><td>4</td><td>Lead</td></tr><tbody></table>|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Type additional information to describe the marketing list, such as the intended use or date of the last update.<br />|
|donotsendonoptout|Edm.Boolean|**Display Name**: Exclude Members Who Opt Out<br />**Description**: Select whether to override the opt-out settings on leads, contacts, and accounts for the members of the target marketing lists of the campaign activity. If No is selected, those who have chosen to opt out won't be excluded from the list. This means they will receive marketing materials.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.<br />Read-only<br />|
|ignoreinactivelistmembers|Edm.Boolean|**Display Name**: Ignore Inactive List Members<br />**Description**: Select whether inactive accounts, contacts, or leads should be excluded from the campaign activity distribution when the marketing list is included in a campaign.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|lastusedon|Edm.DateTimeOffset|**Display Name**: Last Used On<br />**Description**: Shows the date and time when the marketing list was last used in a campaign or in the creation of activities or opportunities.<br />|
|listid|Edm.Guid|**Display Name**: List<br />**Description**: Unique identifier of the marketing list.<br />|
|listname|Edm.String|**Display Name**: Name<br />**Description**: Type a name for the marketing list so that it is identified correctly in lists.<br />|
|lockstatus|Edm.Boolean|**Display Name**: Locked<br />**Description**: Select whether the marketing list is locked. If Yes is selected, no additional members can be added to the marketing list.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|membercount|Edm.Int32|**Display Name**: Members Count<br />**Description**: Shows the sum of all members in the marketing list.<br />|
|membertype|Edm.Int32|**Display Name**: Member Type<br />**Description**: Type of the members that can be stored in the marketing list.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|msdyncrm_issubscription|Edm.Boolean|**Display Name**: Subscription<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>True</td></tr><tr><td>0</td><td>False</td></tr><tbody></table>|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|processid|Edm.Guid|**Display Name**: Process Id<br />**Description**: Contains the id of the process associated with the entity.<br />|
|purpose|Edm.String|**Display Name**: Purpose<br />**Description**: Type the intended use of the marketing list to identify its key segments, target offers, or business group.<br />|
|query|Edm.String|**Display Name**: Query<br />**Description**: Query used for retrieving members of marketing list.<br />|
|source|Edm.String|**Display Name**: Source<br />**Description**: Type the source of the marketing list, such as a third-party supplier or internal database.<br />|
|stageid|Edm.Guid|**Display Name**: Stage Id<br />**Description**: Contains the id of the stage where the entity is located.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Shows whether the marketing list is active or inactive. Inactive marketing lists are read-only and can't be edited unless they are reactivated.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Select the marketing list's status.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|traversedpath|Edm.String|**Display Name**: Traversed Path<br />**Description**: A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.<br />|
|type|Edm.Boolean|**Display Name**: Type<br />**Description**: Select whether you want the marketing list to be static or dynamic. The members in a static marketing list are unchanging. A dynamic marketing list is based on a dynamic query that retrieves the updated list of members<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Dynamic</td></tr><tr><td>0</td><td>Static</td></tr><tbody></table>|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Shows who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_modifiedby_value|modifiedby<br />|Shows who last updated the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who last updated the record on behalf of another user.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Choose the local currency for the record to make sure budgets are reported in the correct currency.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_list_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_list_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_list_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_list_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_lists|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_list|
|owningteam|[team EntityType](team.md)|team_list|
|owninguser|[systemuser EntityType](systemuser.md)|user_list|
|stageid_processstage|[processstage EntityType](processstage.md)|processstage_lists|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|transactioncurrency_list|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|adx_website_list|[adx_website EntityType](adx_website.md)|adx_website_list|  
|campaignactivitylist_association|[campaignactivity EntityType](campaignactivity.md)|campaignactivitylist_association|  
|campaignlist_association|[campaign EntityType](campaign.md)|campaignlist_association|  
|List_Annotation|[annotation EntityType](annotation.md)|objectid_list|  
|List_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_list|  
|List_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_list|  
|List_BulkOperations|[bulkoperation EntityType](bulkoperation.md)|regardingobjectid_list|  
|list_connections1|[connection EntityType](connection.md)|record1id_list|  
|list_connections2|[connection EntityType](connection.md)|record2id_list|  
|List_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_list|  
|List_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_list|  
|List_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_list_syncerror|  
|listaccount_association|[account EntityType](account.md)|listaccount_association|  
|listcontact_association|[contact EntityType](contact.md)|listcontact_association|  
|listlead_association|[lead EntityType](lead.md)|listlead_association|  
|msdyncrm_msdyncrm_marketingform_list|[msdyncrm_marketingform EntityType](msdyncrm_marketingform.md)|msdyncrm_msdyncrm_marketingform_list|  
|msdyncrm_msdyncrm_marketingformtemplate_list|[msdyncrm_marketingformtemplate EntityType](msdyncrm_marketingformtemplate.md)|msdyncrm_msdyncrm_marketingformtemplate_list|  

## Operations
The following operations can be used with the list entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[AddItemCampaign Action](../actions/additemcampaign.md)|Entity|[!INCLUDE[../actions/descriptions/additemcampaign.md](../actions/descriptions/additemcampaign.md)]|  
|[AddListMembersList Action](../actions/addlistmemberslist.md)|Not Bound|[!INCLUDE[../actions/descriptions/addlistmemberslist.md](../actions/descriptions/addlistmemberslist.md)]|  
|[AddMemberList Action](../actions/addmemberlist.md)|Entity|[!INCLUDE[../actions/descriptions/addmemberlist.md](../actions/descriptions/addmemberlist.md)]|  
|[CopyDynamicListToStatic Action](../actions/copydynamiclisttostatic.md)|Entity|[!INCLUDE[../actions/descriptions/copydynamiclisttostatic.md](../actions/descriptions/copydynamiclisttostatic.md)]|  
|[CopyMembersList Action](../actions/copymemberslist.md)|Entity|[!INCLUDE[../actions/descriptions/copymemberslist.md](../actions/descriptions/copymemberslist.md)]|  
|[CreateActivitiesList Action](../actions/createactivitieslist.md)|Not Bound|[!INCLUDE[../actions/descriptions/createactivitieslist.md](../actions/descriptions/createactivitieslist.md)]|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[QualifyMemberList Action](../actions/qualifymemberlist.md)|Entity|[!INCLUDE[../actions/descriptions/qualifymemberlist.md](../actions/descriptions/qualifymemberlist.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the list entity type.


|Name|Description |  
|----|------------|  
|[Dynamics 365 Portals - Portal Dependencies Solution](../solutions/microsoftcrmportaldependencies.md)|[!INCLUDE[../solutions/descriptions/microsoftcrmportaldependencies.md](../solutions/descriptions/microsoftcrmportaldependencies.md)]|  
|[Microsoft Dynamics Marketing Solution](../solutions/microsoftdynamicsmarketingcrmsolution.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicsmarketingcrmsolution.md](../solutions/descriptions/microsoftdynamicsmarketingcrmsolution.md)]|  
|[Microsoft Dynamics CRM Marketing Sales Solution](../solutions/marketingsales.md)|[!INCLUDE[../solutions/descriptions/marketingsales.md](../solutions/descriptions/marketingsales.md)]|  
|[Microsoft Dynamics CRM Marketing Solution](../solutions/marketing.md)|[!INCLUDE[../solutions/descriptions/marketing.md](../solutions/descriptions/marketing.md)]|    

[!INCLUDE[./remarks/list.md](./remarks/list.md)]

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