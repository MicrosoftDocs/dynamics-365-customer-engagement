---
title: "Microsoft Dynamics 365 Customer Engagement adx_webpage EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: f532e961-65d8-4c0c-8f51-3111ca69d207
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API adx_webpage entitytype."
---
# adx_webpage EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/adx_webpage.md](./descriptions/adx_webpage.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]adx_webpages </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Web Page</td></tr>
<tr><td><b>Primary Key:</b></td><td>adx_webpageid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>adx_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The adx_webpage entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|adx_alloworigin|Edm.String|**Display Name**: Allow Origin<br />**Description**: Defines CORS header Access-Control-Allow-Origin for cross origin requests.<br />|
|adx_category|Edm.Int32|**Display Name**: Category<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>News</td></tr><tbody></table>|
|adx_copy|Edm.String|**Display Name**: Copy<br />|
|adx_createdbyipaddress|Edm.String|**Display Name**: Created By IP Address<br />|
|adx_createdbyusername|Edm.String|**Display Name**: Created By Username<br />|
|adx_customcss|Edm.String|**Display Name**: Custom CSS<br />|
|adx_customjavascript|Edm.String|**Display Name**: Custom JavaScript<br />|
|adx_displaydate|Edm.DateTimeOffset|**Display Name**: Display Date<br />|
|adx_displayorder|Edm.Int32|**Display Name**: Display Order<br />|
|adx_editorialcomments|Edm.String|**Display Name**: Editorial Comments<br />|
|adx_enablerating|Edm.Boolean|**Display Name**: Enable Ratings<br />**Description**: Setting this value to 'Yes' will allow users to rate the web page.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_enabletracking|Edm.Boolean|**Display Name**: Enable Tracking<br />**Description**: Select whether to enable logging of users' downloads of this webpage.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_excludefromsearch|Edm.Boolean|**Display Name**: Exclude From Search<br />**Description**: Shows whether the webpage is excluded from the portal search.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_expirationdate|Edm.DateTimeOffset|**Display Name**: Expiration Date<br />|
|adx_feedbackpolicy|Edm.Int32|**Display Name**: Comment Policy<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>756150000</td><td>Inherit</td></tr><tr><td>756150001</td><td>None</td></tr><tr><td>756150002</td><td>Open</td></tr><tr><td>756150003</td><td>Open to Authenticated Users</td></tr><tr><td>756150004</td><td>Moderated</td></tr><tr><td>756150005</td><td>Closed</td></tr><tbody></table>|
|adx_hiddenfromsitemap|Edm.Boolean|**Display Name**: Hidden From Sitemap<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_imageurl|Edm.String|**Display Name**: Image URL<br />|
|adx_isroot|Edm.Boolean|**Display Name**: Is Root<br />**Description**: Defines whether this is the "root" record of this translated group of Web Pages.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_meta_description|Edm.String|**Display Name**: Description<br />|
|adx_modifiedbyipaddress|Edm.String|**Display Name**: Modified By IP Address<br />|
|adx_modifiedbyusername|Edm.String|**Display Name**: Modified By Username<br />|
|adx_name|Edm.String|**Display Name**: Name<br />**Description**: Shows the name of the custom entity.<br />|
|adx_partialurl|Edm.String|**Display Name**: Partial URL<br />|
|adx_releasedate|Edm.DateTimeOffset|**Display Name**: Release Date<br />|
|adx_sharedpageconfiguration|Edm.Boolean|**Display Name**: Shared Page Configuration<br />**Description**: Determines if the content page uses the root page configuration<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_summary|Edm.String|**Display Name**: Summary<br />|
|adx_title|Edm.String|**Display Name**: Title<br />|
|adx_webpageid|Edm.Guid|**Display Name**: Web Page<br />**Description**: Unique identifier for entity instances<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows when the record was updated.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows when the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Web Page<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Web Page<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Shows the time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_adx_authorid_value|adx_authorid<br />|Unique identifier for Contact associated with Web Page.|
|_adx_entityform_value|adx_entityform<br />|Unique identifier for Entity Form associated with Web Page.|
|_adx_entitylist_value|adx_entitylist<br />|Unique identifier for Entity List associated with Web Page.|
|_adx_image_value|adx_image<br />|Unique identifier for Web File associated with Web Page.|
|_adx_masterwebpageid_value|adx_masterwebpageid<br />|Unique identifier for Web Page associated with Web Page.|
|_adx_navigation_value|adx_navigation<br />|Unique identifier for Web Link Set associated with Web Page.|
|_adx_pagetemplateid_value|adx_pagetemplateid<br />|Unique identifier for Page Template associated with Web Page.|
|_adx_parentpageid_value|adx_parentpageid<br />|Unique identifier for Web Page associated with Web Page.|
|_adx_publishingstateid_value|adx_publishingstateid<br />|Unique identifier for Publishing State associated with Web Page.|
|_adx_rootwebpageid_value|adx_rootwebpageid<br />|Lookup to root WebPage.|
|_adx_subjectid_value|adx_subjectid<br />|Unique identifier for Subject associated with Web Page.|
|_adx_webform_value|adx_webform<br />|Unique identifier for Web Form associated with Web Page.|
|_adx_webpagelanguageid_value|adx_webpagelanguageid<br />|Language of this web page.|
|_adx_websiteid_value|adx_websiteid<br />|Unique identifier for Website associated with Web Page.|
|_createdby_value|createdby<br />|Shows the user who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_modifiedby_value|modifiedby<br />|Shows the user who updated the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who last updated the record on behalf of another user.|
|_ownerid_value|ownerid<br />|Shows the owner ID.|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|adx_authorid|[contact EntityType](contact.md)|adx_contact_webpage|
|adx_entityform|[adx_entityform EntityType](adx_entityform.md)|adx_webpage_entityform|
|adx_entitylist|[adx_entitylist EntityType](adx_entitylist.md)|adx_webpage_entitylist|
|adx_image|[adx_webfile EntityType](adx_webfile.md)|adx_webfile_webpage_image|
|adx_masterwebpageid|[adx_webpage EntityType](adx_webpage.md)|adx_webpage_masterwebpage|
|adx_navigation|[adx_weblinkset EntityType](adx_weblinkset.md)|adx_webpage_navigation_weblinkset|
|adx_pagetemplateid|[adx_pagetemplate EntityType](adx_pagetemplate.md)|adx_pagetemplate_webpage|
|adx_parentpageid|[adx_webpage EntityType](adx_webpage.md)|adx_webpage_webpage|
|adx_publishingstateid|[adx_publishingstate EntityType](adx_publishingstate.md)|adx_publishingstate_webpage|
|adx_rootwebpageid|[adx_webpage EntityType](adx_webpage.md)|adx_webpage_webpage_rootwebpageid|
|adx_subjectid|[subject EntityType](subject.md)|adx_subject_webpage|
|adx_webform|[adx_webform EntityType](adx_webform.md)|adx_webpage_webform|
|adx_webpagelanguageid|[adx_websitelanguage EntityType](adx_websitelanguage.md)|adx_websitelanguage_webpage_webpagelanguageid|
|adx_websiteid|[adx_website EntityType](adx_website.md)|adx_website_webpage|
|createdby|[systemuser EntityType](systemuser.md)|lk_adx_webpage_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_adx_webpage_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_adx_webpage_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_adx_webpage_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_adx_webpage|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_adx_webpage|
|owningteam|[team EntityType](team.md)|team_adx_webpage|
|owninguser|[systemuser EntityType](systemuser.md)|user_adx_webpage|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|adx_entityform_redirectwebpage|[adx_entityform EntityType](adx_entityform.md)|adx_redirectwebpage|  
|adx_entitylist_webpageforcreate|[adx_entitylist EntityType](adx_entitylist.md)|adx_webpageforcreate|  
|adx_entitylist_webpagefordetailsview|[adx_entitylist EntityType](adx_entitylist.md)|adx_webpagefordetailsview|  
|adx_pagetag_webpage|[adx_pagetag EntityType](adx_pagetag.md)|adx_pagetag_webpage|  
|adx_parentwebpage_shortcut|[adx_shortcut EntityType](adx_shortcut.md)|adx_ParentPage_webpageId|  
|adx_webformstep_redirectwebpage|[adx_webformstep EntityType](adx_webformstep.md)|adx_redirectwebpage|  
|adx_webpage_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_adx_webpage|  
|adx_webpage_ad|[adx_ad EntityType](adx_ad.md)|adx_webpageid|  
|adx_webpage_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_adx_webpage_adx_alertsubscription|  
|adx_webpage_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_adx_webpage_adx_inviteredemption|  
|adx_webpage_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_adx_webpage_adx_portalcomment|  
|adx_webpage_Annotations|[annotation EntityType](annotation.md)|objectid_adx_webpage|  
|adx_webpage_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_adx_webpage_appointment|  
|adx_webpage_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_adx_webpage|  
|adx_webpage_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_adx_webpage|  
|adx_webpage_connections1|[connection EntityType](connection.md)|record1id_adx_webpage|  
|adx_webpage_connections2|[connection EntityType](connection.md)|record2id_adx_webpage|  
|adx_webpage_Emails|[email EntityType](email.md)|regardingobjectid_adx_webpage_email|  
|adx_webpage_Faxes|[fax EntityType](fax.md)|regardingobjectid_adx_webpage_fax|  
|adx_webpage_Feedback|[feedback EntityType](feedback.md)|regardingobjectid_adx_webpage|  
|adx_webpage_Letters|[letter EntityType](letter.md)|regardingobjectid_adx_webpage_letter|  
|adx_webpage_masterwebpage|[adx_webpage EntityType](adx_webpage.md)|adx_masterwebpageid|  
|adx_webpage_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_adx_webpage_msdyn_approval|  
|adx_webpage_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_adx_webpage_msdyn_bookingalert|  
|adx_webpage_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_adx_webpage_msdyn_surveyinvite|  
|adx_webpage_pagealert|[adx_pagealert EntityType](adx_pagealert.md)|adx_webpageid|  
|adx_webpage_pagenotification|[adx_pagenotification EntityType](adx_pagenotification.md)|adx_webpage|  
|adx_webpage_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_adx_webpage_phonecall|  
|adx_webpage_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_adx_webpage_recurringappointmentmaster|  
|adx_webpage_redirect|[adx_redirect EntityType](adx_redirect.md)|adx_webpageid|  
|adx_webpage_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_adx_webpage_serviceappointment|  
|adx_webpage_SharePointDocumentLocations|[sharepointdocumentlocation EntityType](sharepointdocumentlocation.md)|regardingobjectid_adx_webpage|  
|adx_webpage_shortcut|[adx_shortcut EntityType](adx_shortcut.md)|adx_WebPageId|  
|adx_webpage_sitemarker|[adx_sitemarker EntityType](adx_sitemarker.md)|adx_pageid|  
|adx_webpage_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_adx_webpage_socialactivity|  
|adx_webpage_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_adx_webpage|  
|adx_webpage_tag|[adx_tag EntityType](adx_tag.md)|adx_webpage_tag|  
|adx_webpage_Tasks|[task EntityType](task.md)|regardingobjectid_adx_webpage_task|  
|adx_webpage_urlhistory|[adx_urlhistory EntityType](adx_urlhistory.md)|adx_webpageid|  
|adx_webpage_webfile|[adx_webfile EntityType](adx_webfile.md)|adx_parentpageid|  
|adx_webpage_weblink|[adx_weblink EntityType](adx_weblink.md)|adx_pageid|  
|adx_webpage_webpage|[adx_webpage EntityType](adx_webpage.md)|adx_parentpageid|  
|adx_webpage_webpage_rootwebpageid|[adx_webpage EntityType](adx_webpage.md)|adx_rootwebpageid|  
|adx_webpage_webpageaccesscontrolrule|[adx_webpageaccesscontrolrule EntityType](adx_webpageaccesscontrolrule.md)|adx_webpageid|  
|adx_webpage_webpagehistory|[adx_webpagehistory EntityType](adx_webpagehistory.md)|adx_webpageid|  
|adx_webpage_webpagelog|[adx_webpagelog EntityType](adx_webpagelog.md)|adx_webpageid|  
|msdyncrm_adx_webpage_msdyncrm_marketingpage_portalsparentpage|[msdyncrm_marketingpage EntityType](msdyncrm_marketingpage.md)|msdyncrm_portalsparentpage|  
|msdyncrm_adx_webpage_msdyncrm_marketingpage_portalswebpage|[msdyncrm_marketingpage EntityType](msdyncrm_marketingpage.md)|msdyncrm_portalswebpage|  
|msdyncrm_adx_webpage_msdyncrm_marketingpageconfiguration_portalsparentpage|[msdyncrm_marketingpageconfiguration EntityType](msdyncrm_marketingpageconfiguration.md)|msdyncrm_portalsparentpage|  

## Operations
The following operations can be used with the adx_webpage entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the adx_webpage entity type.


|Name|Description |  
|----|------------|  
|[Dynamics 365 Portals - Portal Base Solution](../solutions/microsoftcrmportalbase.md)|[!INCLUDE[../solutions/descriptions/microsoftcrmportalbase.md](../solutions/descriptions/microsoftcrmportalbase.md)]|  
|[Dynamics 365 Portals - Portal Dependencies Solution](../solutions/microsoftcrmportaldependencies.md)|[!INCLUDE[../solutions/descriptions/microsoftcrmportaldependencies.md](../solutions/descriptions/microsoftcrmportaldependencies.md)]|  
|[Dynamics 365 Portals - Feedback Solution](../solutions/feedback.md)|[!INCLUDE[../solutions/descriptions/feedback.md](../solutions/descriptions/feedback.md)]|  
|[Dynamics 365 Portals - Web Forms Solution](../solutions/microsoftwebforms.md)|[!INCLUDE[../solutions/descriptions/microsoftwebforms.md](../solutions/descriptions/microsoftwebforms.md)]|    

[!INCLUDE[./remarks/adx_webpage.md](./remarks/adx_webpage.md)]

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