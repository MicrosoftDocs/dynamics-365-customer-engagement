---
title: "Microsoft Dynamics 365 Customer Engagement adx_website EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 03408004-f54e-4453-bdae-2c75415231b0
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API adx_website entitytype."
---
# adx_website EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/adx_website.md](./descriptions/adx_website.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]adx_websites </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Website</td></tr>
<tr><td><b>Primary Key:</b></td><td>adx_websiteid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>adx_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The adx_website entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|adx_name|Edm.String|**Display Name**: Name<br />**Description**: Shows the name of the custom entity.<br />|
|adx_partialurl|Edm.String|**Display Name**: Partial URL<br />|
|adx_primarydomainname|Edm.String|**Display Name**: Primary Domain Name<br />**Description**: Tracks the primary domain name of the Portal<br />|
|adx_website_language|Edm.Int32|**Display Name**: Language<br />|
|adx_websiteid|Edm.Guid|**Display Name**: Website<br />**Description**: Unique identifier for entity instances<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows when the record was updated.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows when the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Website<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Website<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Shows the time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_adx_defaultlanguage_value|adx_DefaultLanguage<br />|Lookup to Website Language - the current default language of the website|
|_adx_footerwebtemplateid_value|adx_footerwebtemplateid<br />|Web Template to use as Website footer content.|
|_adx_headerwebtemplateid_value|adx_headerwebtemplateid<br />|Web Template to use as Website header content.|
|_adx_parentwebsiteid_value|adx_parentwebsiteid<br />|Unique identifier for Website associated with Website.|
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
|adx_DefaultLanguage|[adx_websitelanguage EntityType](adx_websitelanguage.md)|adx_adx_websitelanguage_adx_website_DefaultLanguage|
|adx_footerwebtemplateid|[adx_webtemplate EntityType](adx_webtemplate.md)|adx_webtemplate_website_footer|
|adx_headerwebtemplateid|[adx_webtemplate EntityType](adx_webtemplate.md)|adx_webtemplate_website_header|
|adx_parentwebsiteid|[adx_website EntityType](adx_website.md)|adx_website_parentwebsite|
|createdby|[systemuser EntityType](systemuser.md)|lk_adx_website_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_adx_website_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_adx_website_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_adx_website_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_adx_website|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_adx_website|
|owningteam|[team EntityType](team.md)|team_adx_website|
|owninguser|[systemuser EntityType](systemuser.md)|user_adx_website|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|adx_adx_website_adx_websitelanguage|[adx_websitelanguage EntityType](adx_websitelanguage.md)|adx_WebsiteId|  
|adx_invitation_website|[adx_invitation EntityType](adx_invitation.md)|adx_website|  
|adx_website_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_adx_website|  
|adx_website_ad|[adx_ad EntityType](adx_ad.md)|adx_websiteid|  
|adx_website_adplacement|[adx_adplacement EntityType](adx_adplacement.md)|adx_websiteid|  
|adx_website_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_adx_website_adx_alertsubscription|  
|adx_website_adx_entitypermission|[adx_entitypermission EntityType](adx_entitypermission.md)|adx_websiteid|  
|adx_website_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_adx_website_adx_inviteredemption|  
|adx_website_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_adx_website_adx_portalcomment|  
|adx_website_adx_webtemplate|[adx_webtemplate EntityType](adx_webtemplate.md)|adx_websiteid|  
|adx_website_Annotations|[annotation EntityType](annotation.md)|objectid_adx_website|  
|adx_website_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_adx_website_appointment|  
|adx_website_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_adx_website|  
|adx_website_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_adx_website|  
|adx_website_connections1|[connection EntityType](connection.md)|record1id_adx_website|  
|adx_website_connections2|[connection EntityType](connection.md)|record2id_adx_website|  
|adx_website_contentsnippet|[adx_contentsnippet EntityType](adx_contentsnippet.md)|adx_websiteid|  
|adx_website_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_adx_website|  
|adx_website_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_adx_website|  
|adx_website_Emails|[email EntityType](email.md)|regardingobjectid_adx_website_email|  
|adx_website_entityform|[adx_entityform EntityType](adx_entityform.md)|adx_websiteid|  
|adx_website_entitylist|[adx_entitylist EntityType](adx_entitylist.md)|adx_websiteid|  
|adx_website_Faxes|[fax EntityType](fax.md)|regardingobjectid_adx_website_fax|  
|adx_website_Letters|[letter EntityType](letter.md)|regardingobjectid_adx_website_letter|  
|adx_website_list|[list EntityType](list.md)|adx_website_list|  
|adx_website_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_adx_website_msdyn_approval|  
|adx_website_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_adx_website_msdyn_bookingalert|  
|adx_website_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_adx_website_msdyn_surveyinvite|  
|adx_website_pagenotification|[adx_pagenotification EntityType](adx_pagenotification.md)|adx_website|  
|adx_website_pagetag|[adx_pagetag EntityType](adx_pagetag.md)|adx_websiteid|  
|adx_website_pagetemplate|[adx_pagetemplate EntityType](adx_pagetemplate.md)|adx_websiteid|  
|adx_website_parentwebsite|[adx_website EntityType](adx_website.md)|adx_parentwebsiteid|  
|adx_website_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_adx_website_phonecall|  
|adx_website_poll|[adx_poll EntityType](adx_poll.md)|adx_websiteid|  
|adx_website_pollplacement|[adx_pollplacement EntityType](adx_pollplacement.md)|adx_websiteid|  
|adx_website_publishingstate|[adx_publishingstate EntityType](adx_publishingstate.md)|adx_websiteid|  
|adx_website_publishingstatetransition|[adx_publishingstatetransitionrule EntityType](adx_publishingstatetransitionrule.md)|adx_WebsiteId|  
|adx_website_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_adx_website_recurringappointmentmaster|  
|adx_website_redirect|[adx_redirect EntityType](adx_redirect.md)|adx_websiteid|  
|adx_website_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_adx_website_serviceappointment|  
|adx_website_SharePointDocumentLocations|[sharepointdocumentlocation EntityType](sharepointdocumentlocation.md)|regardingobjectid_adx_website|  
|adx_website_shortcut|[adx_shortcut EntityType](adx_shortcut.md)|adx_WebsiteId|  
|adx_website_sitemarker|[adx_sitemarker EntityType](adx_sitemarker.md)|adx_websiteid|  
|adx_website_sitesetting|[adx_sitesetting EntityType](adx_sitesetting.md)|adx_websiteid|  
|adx_website_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_adx_website_socialactivity|  
|adx_website_sponsor|[account EntityType](account.md)|adx_website_sponsor|  
|adx_website_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_adx_website|  
|adx_website_tag|[adx_tag EntityType](adx_tag.md)|adx_websiteid|  
|adx_website_Tasks|[task EntityType](task.md)|regardingobjectid_adx_website_task|  
|adx_website_urlhistory|[adx_urlhistory EntityType](adx_urlhistory.md)|adx_websiteid|  
|adx_website_webfile|[adx_webfile EntityType](adx_webfile.md)|adx_websiteid|  
|adx_website_webform|[adx_webform EntityType](adx_webform.md)|adx_websiteid|  
|adx_website_weblinkset|[adx_weblinkset EntityType](adx_weblinkset.md)|adx_websiteid|  
|adx_website_webpage|[adx_webpage EntityType](adx_webpage.md)|adx_websiteid|  
|adx_website_webpageaccesscontrolrule|[adx_webpageaccesscontrolrule EntityType](adx_webpageaccesscontrolrule.md)|adx_websiteid|  
|adx_website_webrole|[adx_webrole EntityType](adx_webrole.md)|adx_websiteid|  
|adx_website_websiteaccess|[adx_websiteaccess EntityType](adx_websiteaccess.md)|adx_websiteid|  
|adx_website_websitebinding|[adx_websitebinding EntityType](adx_websitebinding.md)|adx_websiteid|  
|msdyncrm_adx_website_msdyncrm_marketingpage_portalswebsite|[msdyncrm_marketingpage EntityType](msdyncrm_marketingpage.md)|msdyncrm_portalswebsite|  
|msdyncrm_adx_website_msdyncrm_marketingpageconfiguration_portalswebsite|[msdyncrm_marketingpageconfiguration EntityType](msdyncrm_marketingpageconfiguration.md)|msdyncrm_portalswebsite|  

## Operations
The following operations can be used with the adx_website entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the adx_website entity type.


|Name|Description |  
|----|------------|  
|[Dynamics 365 Portals - Portal Base Solution](../solutions/microsoftcrmportalbase.md)|[!INCLUDE[../solutions/descriptions/microsoftcrmportalbase.md](../solutions/descriptions/microsoftcrmportalbase.md)]|  
|[Dynamics 365 Portals - Portal Dependencies Solution](../solutions/microsoftcrmportaldependencies.md)|[!INCLUDE[../solutions/descriptions/microsoftcrmportaldependencies.md](../solutions/descriptions/microsoftcrmportaldependencies.md)]|  
|[Dynamics 365 Portals - Web Forms Solution](../solutions/microsoftwebforms.md)|[!INCLUDE[../solutions/descriptions/microsoftwebforms.md](../solutions/descriptions/microsoftwebforms.md)]|    

[!INCLUDE[./remarks/adx_website.md](./remarks/adx_website.md)]

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