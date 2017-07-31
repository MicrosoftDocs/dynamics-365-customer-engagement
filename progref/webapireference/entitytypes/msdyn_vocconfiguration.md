---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_vocconfiguration EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: bccc3214-77f2-4491-8460-58f77bb4efca
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_vocconfiguration entitytype."
---
# msdyn_vocconfiguration EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_vocconfiguration.md](./descriptions/msdyn_vocconfiguration.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyn_vocconfigurations </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Voice of the Customer Configuration</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_vocconfigurationid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_vocconfiguration entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was modified.<br />Read-only<br />|
|msdyn_cdnroot|Edm.String|**Display Name**: CDN Path or URL<br />**Description**: Enter the content delivery network (CDN) path.<br />|
|msdyn_currentdepth|Edm.Int32|**Display Name**: Current Depth<br />**Description**: Enter the current depth.<br />|
|msdyn_currentinnerloop|Edm.Int32|**Display Name**: Current inner loop of response processing<br />|
|msdyn_emailfacetemplate|Edm.String|**Display Name**: Email Body Template<br />**Description**: Enter the HTML for the body of the email.<br />|
|msdyn_emailnpstemplate|Edm.String|**Display Name**: Email NPS Template<br />**Description**: Select the email NPS template.<br />|
|msdyn_emailratingtemplate|Edm.String|**Display Name**: Email Rating Template<br />**Description**: Select the email rating template.<br />|
|msdyn_feedbackattributegenerationcount|Edm.Int32|**Display Name**: Feedback Attribute Generation Count<br />**Description**: Enter the number for the feedback generation count.<br />|
|msdyn_feedbackcharts|Edm.String|**Display Name**: Feedback Charts<br />**Description**: Enter the HTML for the feedback charts.<br />|
|msdyn_feedbackdashboards|Edm.String|**Display Name**: Feedback Dashboards<br />**Description**: Enter the HTML for the feedback dashboards.<br />|
|msdyn_feedbackformactionstab|Edm.String|**Display Name**: Feedback Form - Actions Tab<br />**Description**: Enter the HTML for the feedback form's Actions tab.<br />|
|msdyn_feedbackformemptyresponsesection|Edm.String|**Display Name**: Feedback Form - Empty Response Section<br />**Description**: Enter the HTML for the feedback form's Empty Response section.<br />|
|msdyn_feedbackformfeedbacktab|Edm.String|**Display Name**: Feedback Form - Feedback Tab<br />**Description**: Enter the HTML for the feedback form's Back tab.<br />|
|msdyn_feedbackformgeneraltab|Edm.String|**Display Name**: Feedback Form - General Tab<br />**Description**: Enter the HTML for the feedback form's General tab.<br />|
|msdyn_feedbackformscoretab|Edm.String|**Display Name**: Feedback form score<br />**Description**: Enter the HTML for the feedback form's Score tab.<br />|
|msdyn_frequency|Edm.Int32|**Display Name**: Frequency<br />**Description**: Frequency of polling<br />|
|msdyn_isconfigured|Edm.Boolean|**Display Name**: Is Configured<br />**Description**: Is VoC Configured<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_ispushmechanismenabled|Edm.Boolean|**Display Name**: Is Push Mechanism Enabled<br />**Description**: Is Push Mechanism Enabled<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_keytype|Edm.String|**Display Name**: Internal use<br />**Description**: For internal use only.<br />|
|msdyn_lastlogactivity|Edm.DateTimeOffset|**Display Name**: Last Log Activity<br />**Description**: Shows the last date and time that a log was created.<br />|
|msdyn_lastresponsefetchon|Edm.DateTimeOffset|**Display Name**: Time of Last Response<br />**Description**: Shows when the last response was retrieved.<br />|
|msdyn_manualimporttrigger|Edm.DateTimeOffset|**Display Name**: Manual Import Trigger<br />**Description**: Select when to trigger a manual import.<br />|
|msdyn_maxdepth|Edm.Int32|**Display Name**: Max Depth<br />**Description**: Maximum depth of the workflows (default 8)<br />|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: The name of the custom entity.<br />|
|msdyn_organizationapplicationurl|Edm.String|**Display Name**: Organization Application Url<br />**Description**: Stores the CRM Organization Application Url<br />|
|msdyn_organizationid|Edm.String|**Display Name**: Organization<br />**Description**: Select the organization.<br />|
|msdyn_organizationkey|Edm.String|**Display Name**: Organization Key<br />**Description**: Shows the organization key.<br />|
|msdyn_parallelcompletecount|Edm.Int32|**Display Name**: Parallel thread complete trigger<br />|
|msdyn_parallelstartcount|Edm.Int32|**Display Name**: Parallel thread start trigger<br />|
|msdyn_pauseresponseprocessing|Edm.Boolean|**Display Name**: Pause or continue response processing<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_processingtrigger|Edm.DateTimeOffset|**Display Name**: Processing Trigger<br />**Description**: Enter the date to start processing responses.<br />|
|msdyn_responseretrievaltype|Edm.Int32|**Display Name**: Response Retrieval<br />**Description**: Select whether responses are pushed or pulled.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>Push</td></tr><tr><td>986540001</td><td>Pull</td></tr><tr><td>986540002</td><td>Pull (Windows Service)</td></tr><tbody></table>|
|msdyn_responsesremaining|Edm.Int32|**Display Name**: Responses Remaining<br />|
|msdyn_responsestopull|Edm.Int32|**Display Name**: Responses to Pull<br />**Description**: Enter the number of responses to pull.<br />|
|msdyn_triggernextpoll|Edm.String|**Display Name**: Trigger Next Poll<br />**Description**: Select when to trigger the next poll.<br />|
|msdyn_vocconfigurationid|Edm.Guid|**Display Name**: Configuration<br />**Description**: Shows the entity instances.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Shows the status of the configuration.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Shows the reason for the status of the configuration.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Shows the time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Shows the user who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows the delegate user who created the record.|
|_modifiedby_value|modifiedby<br />|Shows the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows the delegate user who modified the record.|
|_msdyn_defaultsurveytemplateid_value|msdyn_DefaultsurveytemplateId<br />|Shows the related default survey template.|
|_msdyn_surveyadmin_value|msdyn_SurveyAdmin<br />|Select the user to notify about service interruptions.|
|_organizationid_value|organizationid<br />|Shows the organization.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_vocconfiguration_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_vocconfiguration_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_vocconfiguration_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_vocconfiguration_modifiedonbehalfby|
|msdyn_DefaultsurveytemplateId|[msdyn_survey EntityType](msdyn_survey.md)|msdyn_survey_configurations|
|msdyn_SurveyAdmin|[systemuser EntityType](systemuser.md)|msdyn_systemuser_msdyn_vocconfiguration_SurveyAdmin|
|organizationid|[organization EntityType](organization.md)|organization_msdyn_vocconfiguration|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_msdyn_vocconfiguration_msdyn_surveylog|[msdyn_surveylog EntityType](msdyn_surveylog.md)|msdyn_ConfigurationId|  
|msdyn_vocconfiguration_Annotations|[annotation EntityType](annotation.md)|objectid_msdyn_vocconfiguration|  
|msdyn_vocconfiguration_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_vocconfiguration|  
|msdyn_vocconfiguration_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_vocconfiguration|  
|msdyn_vocconfiguration_survey|[msdyn_survey EntityType](msdyn_survey.md)|msdyn_ConfigurationId|  
|msdyn_vocconfiguration_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_vocconfiguration|  

## Operations
The following operations can be used with the msdyn_vocconfiguration entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  

## Solutions
The following solutions include the msdyn_vocconfiguration entity type.


|Name|Description |  
|----|------------|  
|[Voice of the Customer for Microsoft Dynamics 365 Solution](../solutions/voiceofthecustomer.md)|[!INCLUDE[../solutions/descriptions/voiceofthecustomer.md](../solutions/descriptions/voiceofthecustomer.md)]|    

[!INCLUDE[./remarks/msdyn_vocconfiguration.md](./remarks/msdyn_vocconfiguration.md)]

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