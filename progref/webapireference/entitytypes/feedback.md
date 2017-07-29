---
title: "Microsoft Dynamics 365 Customer Engagement feedback EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: c17e82ee-466a-49f4-b456-248d66077206
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API feedback entitytype."
---
# feedback EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/feedback.md](./descriptions/feedback.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]feedback </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Feedback</td></tr>
<tr><td><b>Primary Key:</b></td><td>feedbackid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>title</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The feedback entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|adx_approved|Edm.Boolean|**Display Name**: Published To Web<br />**Description**: Shows whether the feedback is approved for display.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|adx_authorurl|Edm.String|**Display Name**: Author URL<br />**Description**: The URL of the author’s home page/blog.<br />|
|adx_contactemail|Edm.String|**Display Name**: Email<br />**Description**: Email of the contact who created the record.<br />|
|adx_contactusername|Edm.String|**Display Name**: Username<br />**Description**: Username of the contact who created the record.<br />|
|adx_createdbycontact|Edm.String|**Display Name**: Created By Name (Contact)<br />**Description**: Name of the contact who created the record.<br />|
|closedon|Edm.DateTimeOffset|**Display Name**: Closed On<br />**Description**: Shows the date and time when the record was closed. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|comments|Edm.String|**Display Name**: Comments<br />**Description**: Type the feedback comments.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.<br />Read-only<br />|
|feedbackid|Edm.Guid|**Display Name**: Feedback<br />**Description**: FeedbackId<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Unique identifier of the data import or data migration that created this record.<br />|
|maxrating|Edm.Int32|**Display Name**: Maximum Rating<br />**Description**: Enter the maximum rating value.<br />|
|minrating|Edm.Int32|**Display Name**: Minimum Rating<br />**Description**: Enter the minimum rating value.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|normalizedrating|Edm.Decimal|**Display Name**: Normalized Rating<br />**Description**: Shows the rating scaled to a value between 0 and 1 based on minimum and maximum ratings.<br />Computed<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|rating|Edm.Int32|**Display Name**: Rating<br />**Description**: Specifies how helpful the related record was.<br />|
|source|Edm.Int32|**Display Name**: Source<br />**Description**: Shows where the feedback was submitted from.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Internal</td></tr><tr><td>1</td><td>Portal</td></tr><tbody></table>|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Shows whether the feedback is open, rejected or closed.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Open</td></tr><tr><td>1</td><td>Closed</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Select the feedback's status.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Proposed</td></tr><tr><td>2</td><td>Accepted</td></tr><tr><td>3</td><td>Closed</td></tr><tr><td>4</td><td>Rejected</td></tr><tbody></table>|
|title|Edm.String|**Display Name**: Title<br />**Description**: Type a title for the feedback.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version number of the feedback.<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_closedby_value|closedby<br />|Shows who closed the record.|
|_createdby_value|createdby<br />|Shows who created the record.|
|_createdbycontact_value|CreatedByContact<br />|Shows the contact who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_createdonbehalfbycontact_value|CreatedOnBehalfByContact<br />|Shows the contact who created the record on behalf of another user.|
|_modifiedby_value|modifiedby<br />|Shows who last updated the record.|
|_modifiedonbehalfby_value|ModifiedOnBehalfBy<br />|Unique identifier of the delegate user who modified the record.|
|_ownerid_value|ownerid<br />|Unique identifier of the user or team who owns the knowledge article views.|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier of the business unit that owns the knowledge article views.|
|_owningteam_value||Unique identifier of the team that owns the feedback.|
|_owninguser_value||Unique identifier of the user who owns this feedback.|
|_regardingobjectid_value|regardingobjectid_adx_webpage<br />regardingobjectid_msdyncrm_appointmentactivitymarketingtemplate<br />regardingobjectid_msdyncrm_contentsettings<br />regardingobjectid_msdyncrm_customerjourney<br />regardingobjectid_msdyncrm_marketingdynamiccontentmetadata<br />regardingobjectid_msdyncrm_marketingemaildynamiccontentmetadata<br />regardingobjectid_msdyncrm_marketingemailtestsend<br />regardingobjectid_msdyncrm_mktactivity<br />regardingobjectid_msdyncrm_phonecallactivitymarketingtemplate<br />regardingobjectid_msdyncrm_taskactivitymarketingtemplate<br />regardingobjectid_msdyncrm_leadscoremodel<br />regardingobjectid_msdyncrm_linkedinaccount<br />regardingobjectid_msdyncrm_linkedinactivity<br />regardingobjectid_msdyncrm_linkedinfieldmapping<br />regardingobjectid_msdyncrm_linkedinform<br />regardingobjectid_msdyncrm_linkedinformanswer<br />regardingobjectid_msdyncrm_linkedinformquestion<br />regardingobjectid_msdyncrm_linkedinformsubmission<br />regardingobjectid_msdyncrm_linkedinleadmatchingstrategy<br />regardingobjectid_msdyncrm_linkedinuserprofile<br />ContactId<br />FeedbackId<br />KnowledgeArticleId<br />|Shows the record that the feedback is associated with.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Choose the local currency for the record to make sure budgets are reported in the correct currency.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|closedby|[systemuser EntityType](systemuser.md)|lk_feedback_closedby|
|ContactId|[contact EntityType](contact.md)|Contact_Feedback|
|createdby|[systemuser EntityType](systemuser.md)|lk_feedback_createdby|
|CreatedByContact|[contact EntityType](contact.md)|lk_contact_feedback_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_feedback_createdonbehalfby|
|CreatedOnBehalfByContact|[contact EntityType](contact.md)|lk_contact_feedback_createdonbehalfby|
|FeedbackId|[feedback EntityType](feedback.md)|feedback_feedback|
|KnowledgeArticleId|[knowledgearticle EntityType](knowledgearticle.md)|KnowledgeArticle_Feedback|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_feedback_modifiedby|
|ModifiedOnBehalfBy|[systemuser EntityType](systemuser.md)|lk_feedback_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_feedback|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_feedback|
|regardingobjectid_adx_webpage|[adx_webpage EntityType](adx_webpage.md)|adx_webpage_Feedback|
|regardingobjectid_msdyncrm_appointmentactivitymarketingtemplate|[msdyncrm_appointmentactivitymarketingtemplate EntityType](msdyncrm_appointmentactivitymarketingtemplate.md)|msdyncrm_appointmentactivitymarketingtemplate_Feedback|
|regardingobjectid_msdyncrm_contentsettings|[msdyncrm_contentsettings EntityType](msdyncrm_contentsettings.md)|msdyncrm_contentsettings_Feedback|
|regardingobjectid_msdyncrm_customerjourney|[msdyncrm_customerjourney EntityType](msdyncrm_customerjourney.md)|msdyncrm_customerjourney_Feedback|
|regardingobjectid_msdyncrm_leadscoremodel|[msdyncrm_leadscoremodel EntityType](msdyncrm_leadscoremodel.md)|msdyncrm_leadscoremodel_Feedback|
|regardingobjectid_msdyncrm_linkedinaccount|[msdyncrm_linkedinaccount EntityType](msdyncrm_linkedinaccount.md)|msdyncrm_linkedinaccount_Feedback|
|regardingobjectid_msdyncrm_linkedinactivity|[msdyncrm_linkedinactivity EntityType](msdyncrm_linkedinactivity.md)|msdyncrm_linkedinactivity_Feedback|
|regardingobjectid_msdyncrm_linkedinfieldmapping|[msdyncrm_linkedinfieldmapping EntityType](msdyncrm_linkedinfieldmapping.md)|msdyncrm_linkedinfieldmapping_Feedback|
|regardingobjectid_msdyncrm_linkedinform|[msdyncrm_linkedinform EntityType](msdyncrm_linkedinform.md)|msdyncrm_linkedinform_Feedback|
|regardingobjectid_msdyncrm_linkedinformanswer|[msdyncrm_linkedinformanswer EntityType](msdyncrm_linkedinformanswer.md)|msdyncrm_linkedinformanswer_Feedback|
|regardingobjectid_msdyncrm_linkedinformquestion|[msdyncrm_linkedinformquestion EntityType](msdyncrm_linkedinformquestion.md)|msdyncrm_linkedinformquestion_Feedback|
|regardingobjectid_msdyncrm_linkedinformsubmission|[msdyncrm_linkedinformsubmission EntityType](msdyncrm_linkedinformsubmission.md)|msdyncrm_linkedinformsubmission_Feedback|
|regardingobjectid_msdyncrm_linkedinleadmatchingstrategy|[msdyncrm_linkedinleadmatchingstrategy EntityType](msdyncrm_linkedinleadmatchingstrategy.md)|msdyncrm_linkedinleadmatchingstrategy_Feedback|
|regardingobjectid_msdyncrm_linkedinuserprofile|[msdyncrm_linkedinuserprofile EntityType](msdyncrm_linkedinuserprofile.md)|msdyncrm_linkedinuserprofile_Feedback|
|regardingobjectid_msdyncrm_marketingdynamiccontentmetadata|[msdyncrm_marketingdynamiccontentmetadata EntityType](msdyncrm_marketingdynamiccontentmetadata.md)|msdyncrm_marketingdynamiccontentmetadata_Feedback|
|regardingobjectid_msdyncrm_marketingemaildynamiccontentmetadata|[msdyncrm_marketingemaildynamiccontentmetadata EntityType](msdyncrm_marketingemaildynamiccontentmetadata.md)|msdyncrm_marketingemaildynamiccontentmetadata_Feedback|
|regardingobjectid_msdyncrm_marketingemailtestsend|[msdyncrm_marketingemailtestsend EntityType](msdyncrm_marketingemailtestsend.md)|msdyncrm_marketingemailtestsend_Feedback|
|regardingobjectid_msdyncrm_mktactivity|[msdyncrm_mktactivity EntityType](msdyncrm_mktactivity.md)|msdyncrm_mktactivity_Feedback|
|regardingobjectid_msdyncrm_phonecallactivitymarketingtemplate|[msdyncrm_phonecallactivitymarketingtemplate EntityType](msdyncrm_phonecallactivitymarketingtemplate.md)|msdyncrm_phonecallactivitymarketingtemplate_Feedback|
|regardingobjectid_msdyncrm_taskactivitymarketingtemplate|[msdyncrm_taskactivitymarketingtemplate EntityType](msdyncrm_taskactivitymarketingtemplate.md)|msdyncrm_taskactivitymarketingtemplate_Feedback|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|transactioncurrency_feedback|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|feedback_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_feedback|  
|feedback_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_feedback|  
|feedback_feedback|[feedback EntityType](feedback.md)|FeedbackId|  
|Feedback_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_feedback_syncerror|  

## Operations
The following operations can be used with the feedback entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the feedback entity type.


|Name|Description |  
|----|------------|  
|[Dynamics 365 Portals - Feedback Solution](../solutions/feedback.md)|[!INCLUDE[../solutions/descriptions/feedback.md](../solutions/descriptions/feedback.md)]|    

[!INCLUDE[./remarks/feedback.md](./remarks/feedback.md)]

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