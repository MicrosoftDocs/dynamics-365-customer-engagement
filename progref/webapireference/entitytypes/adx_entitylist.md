---
title: "Microsoft Dynamics 365 Customer Engagement adx_entitylist EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 59e32b68-9a8a-4aee-b5ea-eede08c26658
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API adx_entitylist entitytype."
---
# adx_entitylist EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/adx_entitylist.md](./descriptions/adx_entitylist.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]adx_entitylists </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Entity List</td></tr>
<tr><td><b>Primary Key:</b></td><td>adx_entitylistid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>adx_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The adx_entitylist entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|adx_calendar_alldayfieldname|Edm.String|**Display Name**: Is All Day Field Name<br />|
|adx_calendar_descriptionfieldname|Edm.String|**Display Name**: Description Field Name<br />|
|adx_calendar_enabled|Edm.Boolean|**Display Name**: Calendar View Enabled<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_calendar_enddatefieldname|Edm.String|**Display Name**: End Date Field Name<br />|
|adx_calendar_initialdate|Edm.DateTimeOffset|**Display Name**: Calendar Initial Date<br />|
|adx_calendar_initialview|Edm.Int32|**Display Name**: Calendar Initial View<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>756150000</td><td>Year</td></tr><tr><td>756150001</td><td>Month</td></tr><tr><td>756150002</td><td>Week</td></tr><tr><td>756150003</td><td>Day</td></tr><tbody></table>|
|adx_calendar_locationfieldname|Edm.String|**Display Name**: Location Field Name<br />|
|adx_calendar_organizerfieldname|Edm.String|**Display Name**: Organizer Field Name<br />|
|adx_calendar_startdatefieldname|Edm.String|**Display Name**: Start Date Field Name<br />|
|adx_calendar_style|Edm.Int32|**Display Name**: Calendar Style<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>756150000</td><td>Full calendar</td></tr><tr><td>756150001</td><td>Event list</td></tr><tbody></table>|
|adx_calendar_summaryfieldname|Edm.String|**Display Name**: Summary Field Name<br />|
|adx_calendar_timezone|Edm.Int32|**Display Name**: Display Time Zone<br />|
|adx_calendar_timezonemode|Edm.Int32|**Display Name**: Time Zone Display Mode<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>756150000</td><td>User Local Time Zone</td></tr><tr><td>756150001</td><td>Specific Time Zone</td></tr><tbody></table>|
|adx_createbuttonlabel|Edm.String|**Display Name**: Create Button Label<br />|
|adx_detailsbuttonlabel|Edm.String|**Display Name**: Details Button Label<br />|
|adx_emptylisttext|Edm.String|**Display Name**: Empty List Text<br />|
|adx_entitylistid|Edm.Guid|**Display Name**: Entity List<br />**Description**: Unique identifier for entity instances<br />|
|adx_entityname|Edm.String|**Display Name**: Entity Name<br />|
|adx_entitypermissionsenabled|Edm.Boolean|**Display Name**: Enable Entity Permissions<br />**Description**: Indicates whether or not the entity permission provider will assert privileges on the entity type associated with this list.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_filter_applybuttonlabel|Edm.String|**Display Name**: Apply Button Label<br />|
|adx_filter_definition|Edm.String|**Display Name**: Filter Definition<br />|
|adx_filter_enabled|Edm.Boolean|**Display Name**: Filter Enabled<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_filter_orientation|Edm.Int32|**Display Name**: Filter Orientation<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>756150000</td><td>Horizontal</td></tr><tr><td>756150001</td><td>Vertical</td></tr><tbody></table>|
|adx_filteraccount|Edm.String|**Display Name**: Filter Account Attribute<br />|
|adx_filterportaluser|Edm.String|**Display Name**: Filter Portal User Attribute<br />|
|adx_filterwebsite|Edm.String|**Display Name**: Filter Website Attribute<br />|
|adx_idquerystringparametername|Edm.String|**Display Name**: ID Query String Parameter Name<br />**Description**: The name of the parameter added to the Query String of the list item's URL that will contain the list item record's ID.<br />|
|adx_key|Edm.String|**Display Name**: Key<br />**Description**: A non-localizable string that can be used by queries to retrieve the record.<br />|
|adx_map_credentials|Edm.String|**Display Name**: Credentials<br />|
|adx_map_distanceunits|Edm.Int32|**Display Name**: Distance Units<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>756150000</td><td>Km</td></tr><tr><td>756150001</td><td>miles</td></tr><tbody></table>|
|adx_map_distancevalues|Edm.String|**Display Name**: Distance Values<br />**Description**: Shows a comma-delimited list of integer values to be populated in the drop-down list  in the web portal for selecting the distance to search for a location on the map.<br />|
|adx_map_enabled|Edm.Boolean|**Display Name**: Map Enabled<br />**Description**: Indicates if a map view of the data is to be rendered.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_map_infoboxdescriptionfieldname|Edm.String|**Display Name**: Infobox Description Field Name<br />|
|adx_map_infoboxoffsetx|Edm.Int32|**Display Name**: Infobox Offset x<br />|
|adx_map_infoboxoffsety|Edm.Int32|**Display Name**: Infobox Offset y<br />|
|adx_map_infoboxtitlefieldname|Edm.String|**Display Name**: Infobox Title Field Name<br />|
|adx_map_latitude|Edm.Double|**Display Name**: Latitude<br />|
|adx_map_latitudefieldname|Edm.String|**Display Name**: Latitude Field Name<br />|
|adx_map_longitude|Edm.Double|**Display Name**: Longitude<br />|
|adx_map_longitudefieldname|Edm.String|**Display Name**: Longitude Field Name<br />|
|adx_map_pushpinheight|Edm.Int32|**Display Name**: Pin Image Height<br />|
|adx_map_pushpinurl|Edm.String|**Display Name**: Pin Image URL<br />|
|adx_map_pushpinwidth|Edm.Int32|**Display Name**: Pin Image Width<br />|
|adx_map_resturl|Edm.String|**Display Name**: REST URL<br />|
|adx_map_type|Edm.Int32|**Display Name**: Map Type<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>756150000</td><td>Bing</td></tr><tr><td>756150002</td><td>Esri</td></tr><tr><td>756150001</td><td>Google</td></tr><tbody></table>|
|adx_map_zoom|Edm.Int32|**Display Name**: Zoom<br />|
|adx_name|Edm.String|**Display Name**: Name<br />**Description**: Type the name of the custom entity.<br />|
|adx_odata_enabled|Edm.Boolean|**Display Name**: OData Enabled<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_odata_entitysetname|Edm.String|**Display Name**: OData Entity Set Name<br />|
|adx_odata_entitytypename|Edm.String|**Display Name**: OData Entity Type Name<br />|
|adx_odata_view|Edm.String|**Display Name**: OData View<br />**Description**: The entity view that defines the columns that will be mapped to properties of the entity exposed in the OData feed.<br />|
|adx_pagesize|Edm.Int32|**Display Name**: Page Size<br />|
|adx_primarykeyname|Edm.String|**Display Name**: Primary Key Name<br />|
|adx_provisionedlanguages|Edm.Int32|**Display Name**: Provisioned Languages<br />|
|adx_registerstartupscript|Edm.String|**Display Name**: Custom JavaScript<br />**Description**: Shows your custom JavaScript that will be placed at the bottom of the page right before the closing </form> element.<br />|
|adx_searchenabled|Edm.Boolean|**Display Name**: Search Enabled<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_searchplaceholdertext|Edm.String|**Display Name**: Search Placeholder Text<br />|
|adx_searchtooltiptext|Edm.String|**Display Name**: Search Tooltip Text<br />|
|adx_settings|Edm.String|**Display Name**: Settings<br />|
|adx_view|Edm.String|**Display Name**: View<br />**Description**: Deprecated<br />|
|adx_views|Edm.String|**Display Name**: Views<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in the solution options.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was updated. The date and time are displayed in the time zone selected in the solution options.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time when the record was migrated. The date and time are displayed in the time zone selected in the solution options.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Shows the status of the entity list.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Select the Entity List's status.
<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Shows the time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_adx_webpageforcreate_value|adx_webpageforcreate<br />|Unique identifier for Web Page associated with Entity List.|
|_adx_webpagefordetailsview_value|adx_webpagefordetailsview<br />|Unique identifier for Web Page associated with Entity List.|
|_adx_websiteid_value|adx_websiteid<br />|Unique identifier for Website entity associated with this record|
|_createdby_value|createdby<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who last updated the record on behalf of another user.|
|_organizationid_value|organizationid<br />|Shows the organization.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|adx_webpageforcreate|[adx_webpage EntityType](adx_webpage.md)|adx_entitylist_webpageforcreate|
|adx_webpagefordetailsview|[adx_webpage EntityType](adx_webpage.md)|adx_entitylist_webpagefordetailsview|
|adx_websiteid|[adx_website EntityType](adx_website.md)|adx_website_entitylist|
|createdby|[systemuser EntityType](systemuser.md)|lk_adx_entitylist_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_adx_entitylist_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_adx_entitylist_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_adx_entitylist_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_adx_entitylist|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|adx_entitylist_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_adx_entitylist|  
|adx_entitylist_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_adx_entitylist|  
|adx_entitylist_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_adx_entitylist|  
|adx_webpage_entitylist|[adx_webpage EntityType](adx_webpage.md)|adx_entitylist|  

## Operations
The following operations can be used with the adx_entitylist entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  

## Solutions
The following solutions include the adx_entitylist entity type.


|Name|Description |  
|----|------------|  
|[Dynamics 365 Portals - Web Forms Solution](../solutions/microsoftwebforms.md)|[!INCLUDE[../solutions/descriptions/microsoftwebforms.md](../solutions/descriptions/microsoftwebforms.md)]|    

[!INCLUDE[./remarks/adx_entitylist.md](./remarks/adx_entitylist.md)]

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