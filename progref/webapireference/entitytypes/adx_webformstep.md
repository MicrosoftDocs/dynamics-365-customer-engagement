---
title: "Microsoft Dynamics 365 Customer Engagement adx_webformstep EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: e4f0ecd1-955c-4087-9951-8f68c517b6a0
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API adx_webformstep entitytype."
---
# adx_webformstep EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/adx_webformstep.md](./descriptions/adx_webformstep.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]adx_webformsteps </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Web Form Step</td></tr>
<tr><td><b>Primary Key:</b></td><td>adx_webformstepid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>adx_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The adx_webformstep entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|adx_accept|Edm.String|**Display Name**: Accept<br />**Description**: The accept attribute specifies the MIME types of files that the server accepts through file upload. To specify more than one value, separate the values with a comma (e.g. audio/*,video/*,image/*).<br />|
|adx_allowmultiplefiles|Edm.Boolean|**Display Name**: Allow Multiple Files<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_appendquerystring|Edm.Boolean|**Display Name**: Append Query String<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_associatecurrentportaluser|Edm.Boolean|**Display Name**: Associate Current Portal User<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_attachfile|Edm.Boolean|**Display Name**: Attach File<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_attachfilelabel|Edm.String|**Display Name**: Attach File Label<br />|
|adx_attachfilemaxsize|Edm.Int32|**Display Name**: Attach File Maximum Size<br />|
|adx_attachfilerequired|Edm.Boolean|**Display Name**: Attach File Required<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_attachfilerequirederrormessage|Edm.String|**Display Name**: Attach File Required Error Message<br />|
|adx_attachfilerestrictaccept|Edm.Boolean|**Display Name**: Attach File Restrict Accept<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_attachfilesizeerrormessage|Edm.String|**Display Name**: Attach File Size Error Message<br />|
|adx_attachfilestoragelocation|Edm.Int32|**Display Name**: Attach File Storage Location<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>756150000</td><td>Note Document</td></tr><tr><td>756150001</td><td>Azure Blob Storage</td></tr><tbody></table>|
|adx_attachfiletypeerrormessage|Edm.String|**Display Name**: Attach File Type Error Message<br />|
|adx_autogeneratesteps|Edm.Boolean|**Display Name**: Auto Generate Steps From Tabs<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_autonumberattributelogicalname|Edm.String|**Display Name**: Auto Number Attribute Logical Name<br />|
|adx_autonumberdefinitionname|Edm.String|**Display Name**: Auto Number Definition Name<br />|
|adx_captcharequired|Edm.Boolean|**Display Name**: Captcha Required<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_condition|Edm.String|**Display Name**: Condition<br />|
|adx_createautonumber|Edm.Boolean|**Display Name**: Create Auto Number<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_editexistingrecordpermitted|Edm.Boolean|**Display Name**: Edit Existing Record Permitted<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_editexpiredmessage|Edm.String|**Display Name**: Edit Expired Message<br />|
|adx_editexpiredstatecode|Edm.Int32|**Display Name**: Edit Expired State Code<br />|
|adx_editexpiredstatusreason|Edm.Int32|**Display Name**: Edit Expired Status Reason<br />|
|adx_editnotpermittedmessage|Edm.String|**Display Name**: Edit Not Permitted Message<br />|
|adx_entitypermissionsenabled|Edm.Boolean|**Display Name**: Enable Entity Permissions<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_entitysourcetype|Edm.Int32|**Display Name**: Entity Source Type<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000001</td><td>Query String</td></tr><tr><td>100000002</td><td>Current Portal User</td></tr><tr><td>100000003</td><td>Result From Previous Step</td></tr><tr><td>100000004</td><td>Record Associated to Current Portal User</td></tr><tbody></table>|
|adx_forceallfieldsrequired|Edm.Boolean|**Display Name**: Make All Fields Required<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_formname|Edm.String|**Display Name**: Form Name<br />**Description**: Shows the name of the entity form to render.<br />|
|adx_geolocation_addresslinefieldname|Edm.String|**Display Name**: Address Line Field Name<br />|
|adx_geolocation_cityfieldname|Edm.String|**Display Name**: City Field Name<br />|
|adx_geolocation_countryfieldname|Edm.String|**Display Name**: Country/Region Field Name<br />|
|adx_geolocation_countyfieldname|Edm.String|**Display Name**: County Field Name<br />|
|adx_geolocation_displaymap|Edm.Boolean|**Display Name**: Display Map<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_geolocation_enabled|Edm.Boolean|**Display Name**: Enabled<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_geolocation_formattedaddressfieldname|Edm.String|**Display Name**: Formatted Address Field Name<br />|
|adx_geolocation_latitudefieldname|Edm.String|**Display Name**: Latitude Field Name<br />|
|adx_geolocation_longitudefieldname|Edm.String|**Display Name**: Longitude Field Name<br />|
|adx_geolocation_maptype|Edm.Int32|**Display Name**: Map Type<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>756150000</td><td>Bing</td></tr><tr><td>756150002</td><td>Esri</td></tr><tr><td>756150001</td><td>Google</td></tr><tbody></table>|
|adx_geolocation_neighborhoodfieldname|Edm.String|**Display Name**: Neighborhood Field Name<br />|
|adx_geolocation_postalcodefieldname|Edm.String|**Display Name**: Zip/Postal Code Field Name<br />|
|adx_geolocation_statefieldname|Edm.String|**Display Name**: State or Province Field Name<br />|
|adx_hideformonsuccess|Edm.Boolean|**Display Name**: Hide Form on Success<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_instructions|Edm.String|**Display Name**: Instructions<br />|
|adx_loadeventkeyname|Edm.String|**Display Name**: Load Event Key Name<br />|
|adx_loguser|Edm.Boolean|**Display Name**: Log User<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_mode|Edm.Int32|**Display Name**: Mode<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000000</td><td>Insert</td></tr><tr><td>100000001</td><td>Edit</td></tr><tr><td>100000002</td><td>ReadOnly</td></tr><tbody></table>|
|adx_movepreviouseventkeyname|Edm.String|**Display Name**: Move Previous Event Key Name<br />|
|adx_movepreviouspermitted|Edm.Boolean|**Display Name**: Move Previous Permitted<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_multiplerecordsperuserpermitted|Edm.Boolean|**Display Name**: Multiple Records Per User Permitted<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_name|Edm.String|**Display Name**: Name<br />**Description**: Type the name of the custom entity.<br />|
|adx_nextbuttoncssclass|Edm.String|**Display Name**: Next Button CSS Class<br />|
|adx_nextbuttontext|Edm.String|**Display Name**: Next Button Text<br />|
|adx_populatereferenceentitylookupfield|Edm.Boolean|**Display Name**: Populate Entity Reference Lookup Field<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_portaluserlookupattributeisactivityparty|Edm.Boolean|**Display Name**: Is Activity Party<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_postbackurl|Edm.String|**Display Name**: Post Back URL<br />|
|adx_previousbuttoncssclass|Edm.String|**Display Name**: Previous Button CSS Class<br />|
|adx_previousbuttontext|Edm.String|**Display Name**: Previous Button Text<br />|
|adx_primarykeyattributelogicalname|Edm.String|**Display Name**: Primary Key Attribute Logical Name<br />**Description**: The logical name of the primary key attribute of the target entity.<br />|
|adx_primarykeyquerystringparametername|Edm.String|**Display Name**: Primary Key Query String Parameter Name<br />|
|adx_provisionedlanguages|Edm.Int32|**Display Name**: Provisioned Languages<br />|
|adx_recommendedfieldsrequired|Edm.Boolean|**Display Name**: Recommended Fields Required<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_recordnotfoundmessage|Edm.String|**Display Name**: Record Not Found Message<br />|
|adx_recordsourcerelationshipname|Edm.String|**Display Name**: Relationship Name<br />|
|adx_redirecturl|Edm.String|**Display Name**: Redirect URL<br />**Description**: Shows the URL to redirect to.<br />|
|adx_redirecturlappendentityidquerystring|Edm.Boolean|**Display Name**: Append Entity ID To Query String<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_redirecturlcustomquerystring|Edm.String|**Display Name**: Custom Query String<br />|
|adx_redirecturlquerystringattribute|Edm.String|**Display Name**: Attribute Logical Name<br />**Description**: Add an attribute value as a query string value by specifying the logical name of the attribute to assign its value to the query string.<br />|
|adx_redirecturlquerystringattributeparamname|Edm.String|**Display Name**: Query String Parameter Name<br />|
|adx_redirecturlquerystringname|Edm.String|**Display Name**: Redirect URL Query String Name<br />**Description**: The url to redirect to is dynamically retrieved from the query string using this parameter name<br />|
|adx_referenceentitylogicalname|Edm.String|**Display Name**: Reference Entity Logical Name<br />|
|adx_referenceentityprimarykeylogicalname|Edm.String|**Display Name**: Reference Entity Primary Key Logical Name<br />|
|adx_referenceentityreadonlyformname|Edm.String|**Display Name**: Reference Entity ReadOnly Form Name<br />|
|adx_referenceentityrelationshipname|Edm.String|**Display Name**: Reference Entity Relationship Name<br />|
|adx_referenceentityshowreadonlyform|Edm.Boolean|**Display Name**: Show Reference Entity ReadOnly Form<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_referenceentitysourcetype|Edm.Int32|**Display Name**: Reference Entity Source Type<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000000</td><td>Query String</td></tr><tr><td>100000001</td><td>Previous Step</td></tr><tr><td>100000002</td><td>Record Associated to Current Portal User</td></tr><tbody></table>|
|adx_referencequeryattributelogicalname|Edm.String|**Display Name**: Reference Query Attribute Logical Name<br />|
|adx_referencequerystringisprimarykey|Edm.Boolean|**Display Name**: Reference Query String Is Primary Key<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_referencequerystringname|Edm.String|**Display Name**: Reference Query String Name<br />|
|adx_referencerecordsourcerelationshipname|Edm.String|**Display Name**: Record Source Relationship Name<br />|
|adx_referencesourceentitylogicalname|Edm.String|**Display Name**: Reference Source Entity Logical Name<br />|
|adx_referencetargetlookupattributelogicalname|Edm.String|**Display Name**: Reference Target Lookup Attribute Logical Name<br />|
|adx_registerstartupscript|Edm.String|**Display Name**: Custom JavaScript<br />**Description**: Shows your custom JavaScript that will be placed at the bottom of the page right before the closing </form> element.<br />|
|adx_renderwebresourcesinline|Edm.Boolean|**Display Name**: Render Web Resources Inline<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_savedeventkeyname|Edm.String|**Display Name**: Saved Event Key Name<br />|
|adx_savingeventkeyname|Edm.String|**Display Name**: Saving Event Key Name<br />|
|adx_setentityreference|Edm.Boolean|**Display Name**: Set Entity Reference<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_settings|Edm.String|**Display Name**: Settings<br />|
|adx_showcaptchaforauthenticatedusers|Edm.Boolean|**Display Name**: Show Captcha for authenticated users<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_showownerfields|Edm.Boolean|**Display Name**: Show Owner Fields<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_showunsupportedfields|Edm.Boolean|**Display Name**: Show Unsupported Fields<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_submitbuttonbusytext|Edm.String|**Display Name**: Submit Button Busy Text<br />|
|adx_submitbuttoncssclass|Edm.String|**Display Name**: Submit Button CSS Class<br />|
|adx_submitbuttontext|Edm.String|**Display Name**: Submit Button Text<br />|
|adx_submiteventkeyname|Edm.String|**Display Name**: Submit Event Key Name<br />|
|adx_successmessage|Edm.String|**Display Name**: Success Message<br />|
|adx_tabname|Edm.String|**Display Name**: Tab Name<br />**Description**: The name of the tab on an entity form to render.<br />|
|adx_targetentitylogicalname|Edm.String|**Display Name**: Target Entity Logical Name<br />|
|adx_targetentityportaluserlookupattribute|Edm.String|**Display Name**: Target Entity Portal User Lookup Attribute<br />|
|adx_targetentityprimarykeylogicalname|Edm.String|**Display Name**: Target Entity Primary Key Logical Name<br />|
|adx_title|Edm.String|**Display Name**: Title<br />|
|adx_tooltipenabled|Edm.Boolean|**Display Name**: ToolTip Enabled<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_type|Edm.Int32|**Display Name**: Type<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>100000000</td><td>Condition</td></tr><tr><td>100000001</td><td>Load Form</td></tr><tr><td>100000002</td><td>Load Tab</td></tr><tr><td>100000003</td><td>Redirect</td></tr><tr><td>100000004</td><td>Load User Control</td></tr><tbody></table>|
|adx_usercontrolpath|Edm.String|**Display Name**: User Control Path<br />|
|adx_usercontroltitle|Edm.String|**Display Name**: User Control Title<br />|
|adx_userhostaddressattributelogicalname|Edm.String|**Display Name**: User Host Address Attribute Logical Name<br />|
|adx_useridentitynameattributelogicalname|Edm.String|**Display Name**: User Identity Name Attribute Logical Name<br />|
|adx_validationgroup|Edm.String|**Display Name**: Validation Group<br />|
|adx_validationsummarycssclass|Edm.String|**Display Name**: Validation Summary CSS Class<br />|
|adx_validationsummaryheadertext|Edm.String|**Display Name**: Validation Summary Header Text<br />|
|adx_validationsummarylinksenabled|Edm.Boolean|**Display Name**: Enable Validation Summary Links<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_validationsummarylinktext|Edm.String|**Display Name**: Validation Summary Link Text<br />|
|adx_webformstepid|Edm.Guid|**Display Name**: Web Form Step<br />**Description**: Unique identifier for entity instances<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in the solution options.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was updated. The date and time are displayed in the time zone selected in the solution options.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time when the record was migrated. The date and time are displayed in the time zone selected in the solution options.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Shows the status of the web form step.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Select the Web Form Step's status.
<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Shows the time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_adx_conditiondefaultnextstep_value|adx_conditiondefaultnextstep<br />|If the condition test fails, this is the next step.|
|_adx_entitysourcestep_value|adx_entitysourcestep<br />|Unique identifier for Web Form Step associated with Web Form Step.|
|_adx_nextstep_value|adx_nextstep<br />|Pointer to the next step.|
|_adx_previousstep_value|adx_previousstep<br />|Pointer to the previous step.|
|_adx_redirectwebpage_value|adx_redirectwebpage<br />|Web Page to redirect to.|
|_adx_referenceentitystep_value|adx_referenceentitystep<br />|Unique identifier for Web Form Step associated with Web Form Step.|
|_adx_webform_value|adx_webform<br />|Unique identifier for Web Form associated with Web Form Step.|
|_createdby_value|createdby<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who last updated the record on behalf of another user.|
|_organizationid_value|organizationid<br />|Shows the organization.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|adx_conditiondefaultnextstep|[adx_webformstep EntityType](adx_webformstep.md)|adx_webformstep_conditiondefaultnextstep|
|adx_entitysourcestep|[adx_webformstep EntityType](adx_webformstep.md)|adx_webformstep_entitysourcestep|
|adx_nextstep|[adx_webformstep EntityType](adx_webformstep.md)|adx_webformstep_nextstep|
|adx_previousstep|[adx_webformstep EntityType](adx_webformstep.md)|adx_webformstep_previousstep|
|adx_redirectwebpage|[adx_webpage EntityType](adx_webpage.md)|adx_webformstep_redirectwebpage|
|adx_referenceentitystep|[adx_webformstep EntityType](adx_webformstep.md)|adx_webformstep_referenceentitystep|
|adx_webform|[adx_webform EntityType](adx_webform.md)|adx_webformstep_webform|
|createdby|[systemuser EntityType](systemuser.md)|lk_adx_webformstep_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_adx_webformstep_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_adx_webformstep_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_adx_webformstep_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_adx_webformstep|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|adx_webform_startstep|[adx_webform EntityType](adx_webform.md)|adx_startstep|  
|adx_webformmetadata_webformstep|[adx_webformmetadata EntityType](adx_webformmetadata.md)|adx_webformstep|  
|adx_webformsession_currentwebformstep|[adx_webformsession EntityType](adx_webformsession.md)|adx_currentwebformstep|  
|adx_webformstep_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_adx_webformstep|  
|adx_webformstep_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_adx_webformstep|  
|adx_webformstep_conditiondefaultnextstep|[adx_webformstep EntityType](adx_webformstep.md)|adx_conditiondefaultnextstep|  
|adx_webformstep_entitysourcestep|[adx_webformstep EntityType](adx_webformstep.md)|adx_entitysourcestep|  
|adx_webformstep_nextstep|[adx_webformstep EntityType](adx_webformstep.md)|adx_nextstep|  
|adx_webformstep_previousstep|[adx_webformstep EntityType](adx_webformstep.md)|adx_previousstep|  
|adx_webformstep_referenceentitystep|[adx_webformstep EntityType](adx_webformstep.md)|adx_referenceentitystep|  
|adx_webformstep_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_adx_webformstep|  

## Operations
The following operations can be used with the adx_webformstep entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  

## Solutions
The following solutions include the adx_webformstep entity type.


|Name|Description |  
|----|------------|  
|[Dynamics 365 Portals - Web Forms Solution](../solutions/microsoftwebforms.md)|[!INCLUDE[../solutions/descriptions/microsoftwebforms.md](../solutions/descriptions/microsoftwebforms.md)]|    

[!INCLUDE[./remarks/adx_webformstep.md](./remarks/adx_webformstep.md)]

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