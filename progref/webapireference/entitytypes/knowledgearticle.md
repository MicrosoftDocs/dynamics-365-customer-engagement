---
title: "Microsoft Dynamics 365 Customer Engagement knowledgearticle EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 438dc89a-b8c2-4e28-b4fc-a130d70eff22
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API knowledgearticle entitytype."
---
# knowledgearticle EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/knowledgearticle.md](./descriptions/knowledgearticle.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]knowledgearticles </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Knowledge Article</td></tr>
<tr><td><b>Primary Key:</b></td><td>knowledgearticleid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>title</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The knowledgearticle entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|articlepublicnumber|Edm.String|**Display Name**: Article Public Number<br />**Description**: Shows the automatically generated ID exposed to customers, partners, and other external users to reference and look up articles.<br />|
|content|Edm.String|**Display Name**: Content<br />**Description**: Shows the body of the article stored in HTML format.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: A short overview of the article, primarily used in search results and for search engine optimization.<br />|
|exchangerate|Edm.Decimal|**Display Name**: ExchangeRate<br />**Description**: Exchange rate for the currency associated with the KnowledgeArticle with respect to the base currency.<br />Read-only<br />|
|expirationdate|Edm.DateTimeOffset|**Display Name**: Expiration Date<br />**Description**: Enter an expiration date for the article. Leave this field blank for no expiration date.<br />|
|expirationstateid|Edm.Int32|**Display Name**: Expiration State Id<br />**Description**: Contains the id of the expiration state of the entity.<br />|
|expirationstatusid|Edm.Int32|**Display Name**: Expired Status<br />**Description**: Contains the id of the expiration status of the entity.<br />|
|expiredreviewoptions|Edm.Int32|**Display Name**: Expired Review Options<br />**Description**: Expired Review Options<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Needs Updating</td></tr><tr><td>1</td><td>Republish</td></tr><tr><td>2</td><td>Archive</td></tr><tbody></table>|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|isinternal|Edm.Boolean|**Display Name**: Internal<br />**Description**: Shows whether this article is only visible internally.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|islatestversion|Edm.Boolean|**Display Name**: Is Latest Version<br />**Description**: Shows which version of the knowledge article is the latest version.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isprimary|Edm.Boolean|**Display Name**: Primary Article<br />**Description**: Select whether the article is the primary article.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isrootarticle|Edm.Boolean|**Display Name**: Root Article<br />**Description**: Select whether the article is the root article.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|keywords|Edm.String|**Display Name**: Keywords<br />**Description**: Type keywords to be used for searches in knowledge base articles. Separate keywords by using commas.<br />|
|knowledgearticleid|Edm.Guid|**Display Name**: Knowledge Article<br />**Description**: Unique identifier for entity instances<br />|
|knowledgearticleviews|Edm.Int32|**Display Name**: Knowledge Article Views<br />**Description**: Shows the total number of article views.<br />Computed<br />Read-only<br />|
|knowledgearticleviews_date|Edm.DateTimeOffset|**Display Name**: Knowledge Article View(Last Updated Time)<br />**Description**: The date time for Knowledge Article View.<br />Read-only<br />|
|knowledgearticleviews_state|Edm.Int32|**Display Name**: Knowledge Article View(State)<br />**Description**: State of Knowledge Article View.<br />Read-only<br />|
|majorversionnumber|Edm.Int32|**Display Name**: Major Version Number<br />**Description**: Shows the major version number of this article's content.<br />|
|minorversionnumber|Edm.Int32|**Display Name**: Minor Version Number<br />**Description**: Shows the minor version number of this article's content.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|processid|Edm.Guid|**Display Name**: Process Id<br />**Description**: Contains the id of the process associated with the entity.<br />|
|publishon|Edm.DateTimeOffset|**Display Name**: Publish On<br />**Description**: Date and time when the record was published.<br />|
|publishstatusid|Edm.Int32|**Display Name**: Published Status<br />**Description**: Publish Status of the Article.<br />|
|rating|Edm.Decimal|**Display Name**: Rating<br />**Description**: Information which specifies how helpful the related record was.<br />Computed<br />Read-only<br />|
|rating_count|Edm.Int32|**Display Name**: Rating(Count)<br />**Description**: Rating Count<br />Read-only<br />|
|rating_date|Edm.DateTimeOffset|**Display Name**: Rating(Last Updated Time)<br />**Description**: The date time for Rating.<br />Read-only<br />|
|rating_state|Edm.Int32|**Display Name**: Rating(State)<br />**Description**: State of Rating<br />Read-only<br />|
|rating_sum|Edm.Decimal|**Display Name**: Rating(sum)<br />**Description**: Total sum of Rating<br />Read-only<br />|
|readyforreview|Edm.Boolean|**Display Name**: Ready For Review<br />**Description**: Ready For Review<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Completed</td></tr><tr><td>0</td><td>Mark Complete</td></tr><tbody></table>|
|review|Edm.Int32|**Display Name**: Review<br />**Description**: Review<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Approved</td></tr><tr><td>1</td><td>Rejected</td></tr><tbody></table>|
|scheduledstatusid|Edm.Int32|**Display Name**: Scheduled Status<br />**Description**: Contains the id of the scheduled status of the entity.<br />|
|setcategoryassociations|Edm.Boolean|**Display Name**: Set Category Associations<br />**Description**: Shows whether category associations have been set<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Completed</td></tr><tr><td>0</td><td>Mark as Complete</td></tr><tbody></table>|
|setproductassociations|Edm.Boolean|**Display Name**: Set Product Associations<br />**Description**: Set Product Associations<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Completed</td></tr><tr><td>0</td><td>Mark As Complete</td></tr><tbody></table>|
|stageid|Edm.Guid|**Display Name**: Stage Id<br />**Description**: Contains the id of the stage where the entity is located.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Shows whether the article is a draft or is published, archived, or discarded. Draft articles aren't available externally and can be edited. Published articles are available externally, based on applicable permissions, but can't be edited. All metadata changes are reflected in the published version. Archived and discarded articles aren't available externally and can't be edited.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Draft</td></tr><tr><td>1</td><td>Approved</td></tr><tr><td>2</td><td>Scheduled</td></tr><tr><td>3</td><td>Published</td></tr><tr><td>4</td><td>Expired</td></tr><tr><td>5</td><td>Archived</td></tr><tr><td>6</td><td>Discarded</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Select the article's status.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Proposed</td></tr><tr><td>2</td><td>Draft</td></tr><tr><td>3</td><td>Needs review</td></tr><tr><td>4</td><td>In review</td></tr><tr><td>5</td><td>Approved</td></tr><tr><td>6</td><td>Scheduled</td></tr><tr><td>7</td><td>Published</td></tr><tr><td>8</td><td>Needs review</td></tr><tr><td>9</td><td>Updating</td></tr><tr><td>10</td><td>Expired</td></tr><tr><td>11</td><td>Rejected</td></tr><tr><td>12</td><td>Archived</td></tr><tr><td>13</td><td>Discarded</td></tr><tr><td>14</td><td>Rejected</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|title|Edm.String|**Display Name**: Title<br />**Description**: Type a title for the article.<br />|
|traversedpath|Edm.String|**Display Name**: Traversed Path<br />**Description**: A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.<br />|
|updatecontent|Edm.Boolean|**Display Name**: Update Content<br />**Description**: Update Content<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Content Updated</td></tr><tr><td>0</td><td>Mark When Completed</td></tr><tbody></table>|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the record.|
|_languagelocaleid_value|languagelocaleid<br />|Select the language that the article's content is in.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who modified the record.|
|_ownerid_value|ownerid<br />|Unique identifier of the user or team who owns the record.|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_parentarticlecontentid_value|ParentArticleContentId<br />|Contains the id of the parent article content associated with the entity.|
|_previousarticlecontentid_value|PreviousArticleContentId<br />|Shows the version that the current article was restored from.|
|_primaryauthorid_value|primaryauthorid<br />|Contains the id of the primary author associated with the article.|
|_rootarticleid_value|RootArticleId<br />|Contains the id of the root article.|
|_subjectid_value|subjectid<br />|Choose the subject of the article to assist with article searches. You can configure subjects under Business Management in the Settings area.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Exchange rate for the currency associated with the KnowledgeArticle with respect to the base currency.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_knowledgearticle_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_knowledgearticle_createdonbehalfby|
|languagelocaleid|[languagelocale EntityType](languagelocale.md)|knowledgearticle_languagelocaleid|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_knowledgearticle_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_knowledgearticle_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_knowledgearticle|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_knowledgearticle|
|owningteam|[team EntityType](team.md)|team_knowledgearticle|
|owninguser|[systemuser EntityType](systemuser.md)|user_knowledgearticle|
|ParentArticleContentId|[knowledgearticle EntityType](knowledgearticle.md)|knowledgearticle_parentarticle_contentid|
|PreviousArticleContentId|[knowledgearticle EntityType](knowledgearticle.md)|knowledgearticle_previousarticle_contentid|
|primaryauthorid|[systemuser EntityType](systemuser.md)|knowledgearticle_primaryauthorid|
|RootArticleId|[knowledgearticle EntityType](knowledgearticle.md)|knowledgearticle_rootarticle_id|
|stageid_processstage|[processstage EntityType](processstage.md)|processstage_knowledgearticle|
|subjectid|[subject EntityType](subject.md)|subject_knowledgearticles|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|transactioncurrency_knowledgearticle|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|incident_knowledgearticles|[knowledgearticleincident EntityType](knowledgearticleincident.md)|knowledgearticleid|  
|knowledgearticle_activity_parties|[activityparty EntityType](activityparty.md)|partyid_knowledgearticle|  
|KnowledgeArticle_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_knowledgearticle|  
|knowledgearticle_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_knowledgearticle_adx_alertsubscription|  
|knowledgearticle_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_knowledgearticle_adx_inviteredemption|  
|knowledgearticle_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_knowledgearticle_adx_portalcomment|  
|knowledgearticle_Annotations|[annotation EntityType](annotation.md)|objectid_knowledgearticle|  
|KnowledgeArticle_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_knowledgearticle_appointment|  
|knowledgearticle_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_knowledgearticle|  
|knowledgearticle_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_knowledgearticle|  
|knowledgearticle_BulkOperations|[bulkoperation EntityType](bulkoperation.md)|regardingobjectid_knowledgearticle_bulkoperation|  
|knowledgearticle_CampaignActivities|[campaignactivity EntityType](campaignactivity.md)|regardingobjectid_knowledgearticle_campaignactivity|  
|knowledgearticle_CampaignResponses|[campaignresponse EntityType](campaignresponse.md)|regardingobjectid_knowledgearticle_campaignresponse|  
|knowledgearticle_category|[category EntityType](category.md)|knowledgearticle_category|  
|knowledgearticle_connections1|[connection EntityType](connection.md)|record1id_knowledgearticle|  
|knowledgearticle_connections2|[connection EntityType](connection.md)|record2id_knowledgearticle|  
|knowledgearticle_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_knowledgearticle|  
|knowledgearticle_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_knowledgearticle|  
|KnowledgeArticle_Emails|[email EntityType](email.md)|regardingobjectid_knowledgearticle_email|  
|knowledgearticle_expiredprocess|[expiredprocess EntityType](expiredprocess.md)|knowledgearticleid|  
|KnowledgeArticle_Faxes|[fax EntityType](fax.md)|regardingobjectid_knowledgearticle_fax|  
|KnowledgeArticle_Feedback|[feedback EntityType](feedback.md)|KnowledgeArticleId|  
|knowledgearticle_IncidentResolutions|[incidentresolution EntityType](incidentresolution.md)|regardingobjectid_knowledgearticle_incidentresolution|  
|KnowledgeArticle_Letters|[letter EntityType](letter.md)|regardingobjectid_knowledgearticle_letter|  
|knowledgearticle_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_knowledgearticle_msdyn_approval|  
|knowledgearticle_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_knowledgearticle_msdyn_bookingalert|  
|knowledgearticle_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_knowledgearticle_msdyn_surveyinvite|  
|knowledgearticle_newprocess|[newprocess EntityType](newprocess.md)|knowledgearticleid|  
|knowledgearticle_OpportunityCloses|[opportunityclose EntityType](opportunityclose.md)|regardingobjectid_knowledgearticle_opportunityclose|  
|knowledgearticle_OrderCloses|[orderclose EntityType](orderclose.md)|regardingobjectid_knowledgearticle_orderclose|  
|knowledgearticle_parentarticle_contentid|[knowledgearticle EntityType](knowledgearticle.md)|ParentArticleContentId|  
|KnowledgeArticle_Phonecalls|[phonecall EntityType](phonecall.md)|regardingobjectid_knowledgearticle_phonecall|  
|knowledgearticle_PostFollows|[postfollow EntityType](postfollow.md)|regardingobjectid_knowledgearticle|  
|knowledgearticle_PostRegardings|[postregarding EntityType](postregarding.md)|regardingobjectid_knowledgearticle|  
|knowledgearticle_previousarticle_contentid|[knowledgearticle EntityType](knowledgearticle.md)|PreviousArticleContentId|  
|knowledgearticle_QueueItems|[queueitem EntityType](queueitem.md)|objectid_knowledgearticle|  
|knowledgearticle_QuoteCloses|[quoteclose EntityType](quoteclose.md)|regardingobjectid_knowledgearticle_quoteclose|  
|KnowledgeArticle_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_knowledgearticle_recurringappointmentmaster|  
|knowledgearticle_rootarticle_id|[knowledgearticle EntityType](knowledgearticle.md)|RootArticleId|  
|KnowledgeArticle_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_knowledgearticle_serviceappointment|  
|knowledgearticle_SharePointDocumentLocations|[sharepointdocumentlocation EntityType](sharepointdocumentlocation.md)|regardingobjectid_knowledgearticle|  
|KnowledgeArticle_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_knowledgearticle_socialactivity|  
|KnowledgeArticle_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_knowledgearticle_syncerror|  
|KnowledgeArticle_Tasks|[task EntityType](task.md)|regardingobjectid_knowledgearticle_task|  
|knowledgearticle_Teams|[team EntityType](team.md)|regardingobjectid_knowledgearticle|  
|knowledgearticle_translationprocess|[translationprocess EntityType](translationprocess.md)|knowledgearticleid|  
|knowledgearticle_views|[knowledgearticleviews EntityType](knowledgearticleviews.md)|knowledgearticleid|  

## Operations
The following operations can be used with the knowledgearticle entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[CreateKnowledgeArticleTranslation Action](../actions/createknowledgearticletranslation.md)|Not Bound|[!INCLUDE[../actions/descriptions/createknowledgearticletranslation.md](../actions/descriptions/createknowledgearticletranslation.md)]|  
|[CreateKnowledgeArticleVersion Action](../actions/createknowledgearticleversion.md)|Not Bound|[!INCLUDE[../actions/descriptions/createknowledgearticleversion.md](../actions/descriptions/createknowledgearticleversion.md)]|  
|[FullTextSearchKnowledgeArticle Action](../actions/fulltextsearchknowledgearticle.md)|Not Bound|[!INCLUDE[../actions/descriptions/fulltextsearchknowledgearticle.md](../actions/descriptions/fulltextsearchknowledgearticle.md)]|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the knowledgearticle entity type.


|Name|Description |  
|----|------------|  
|[KnowledgeManagementCore Solution](../solutions/knowledgemanagementcore.md)|[!INCLUDE[../solutions/descriptions/knowledgemanagementcore.md](../solutions/descriptions/knowledgemanagementcore.md)]|  
|[Microsoft Dynamics Product Management Workload Solution](../solutions/productmanagement.md)|[!INCLUDE[../solutions/descriptions/productmanagement.md](../solutions/descriptions/productmanagement.md)]|  
|[App for Outlook Solution](../solutions/appforoutlook.md)|[!INCLUDE[../solutions/descriptions/appforoutlook.md](../solutions/descriptions/appforoutlook.md)]|  
|[Microsoft Dynamics Service Workload Solution](../solutions/service.md)|[!INCLUDE[../solutions/descriptions/service.md](../solutions/descriptions/service.md)]|    

[!INCLUDE[./remarks/knowledgearticle.md](./remarks/knowledgearticle.md)]

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