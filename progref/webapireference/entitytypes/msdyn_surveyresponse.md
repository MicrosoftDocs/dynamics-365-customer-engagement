---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_surveyresponse EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: fd4dabac-81e1-4f38-a099-690a4495b54a
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_surveyresponse entitytype."
---
# msdyn_surveyresponse EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_surveyresponse.md](./descriptions/msdyn_surveyresponse.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]msdyn_surveyresponses </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Survey Response</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_surveyresponseid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_surveyresponse entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Received On<br />**Description**: Shows the date and time when the record was created.<br />Read-only<br />|
|emailaddress|Edm.String|**Display Name**: E-mail Address<br />**Description**: Shows the primary email address for the entity.<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was modified.<br />Read-only<br />|
|msdyn_alerttriggered|Edm.Boolean|**Display Name**: Alert Triggered<br />**Description**: Select whether an alert should be triggered.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_campaignresponsetrigger|Edm.Boolean|**Display Name**: Campaign Response Trigger<br />**Description**: Select whether there is a campaign response trigger.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_cityresponse|Edm.String|**Display Name**: City<br />**Description**: Shows the city that the responded supplied.<br />|
|msdyn_companyresponse|Edm.String|**Display Name**: Company Response<br />**Description**: Shows the company response.<br />|
|msdyn_completedon|Edm.DateTimeOffset|**Display Name**: Completed On<br />**Description**: Shows when the response was completed.<br />|
|msdyn_countryresponse|Edm.String|**Display Name**: Country<br />**Description**: Shows the country that the respondent supplied.<br />|
|msdyn_createalerttrigger|Edm.DateTimeOffset|**Display Name**: Create Alert Trigger<br />**Description**: Create an alert trigger.<br />|
|msdyn_createleadtrigger|Edm.DateTimeOffset|**Display Name**: Create Lead Trigger<br />**Description**: Enter a trigger to create a lead.<br />|
|msdyn_customdate1|Edm.DateTimeOffset|**Display Name**: Generic date 2<br />**Description**: Enter a date.<br />|
|msdyn_customdate2|Edm.DateTimeOffset|**Display Name**: Date<br />**Description**: Enter a date.<br />|
|msdyn_customereffortscore|Edm.Decimal|**Display Name**: Customer Effort Score<br />**Description**: Shows the customer effort score.<br />|
|msdyn_customnumber1|Edm.Decimal|**Display Name**: Generic number 1<br />**Description**: Enter a number.<br />|
|msdyn_customnumber10|Edm.Decimal|**Display Name**: Generic number 10<br />**Description**: Enter a number.<br />|
|msdyn_customnumber11|Edm.Decimal|**Display Name**: Generic number 11<br />**Description**: Enter a number.<br />|
|msdyn_customnumber12|Edm.Decimal|**Display Name**: Generic number 12<br />**Description**: Enter a number.<br />|
|msdyn_customnumber13|Edm.Decimal|**Display Name**: Generic number 13<br />**Description**: Enter a number.<br />|
|msdyn_customnumber14|Edm.Decimal|**Display Name**: Generic number 14<br />**Description**: Enter a number.<br />|
|msdyn_customnumber15|Edm.Decimal|**Display Name**: Generic number 15<br />**Description**: Enter a number.<br />|
|msdyn_customnumber16|Edm.Decimal|**Display Name**: Generic number 16<br />**Description**: Enter a number.<br />|
|msdyn_customnumber17|Edm.Decimal|**Display Name**: Generic number 17<br />**Description**: Enter a number.<br />|
|msdyn_customnumber18|Edm.Decimal|**Display Name**: Custom Number<br />**Description**: Enter a number.<br />|
|msdyn_customnumber19|Edm.Decimal|**Display Name**: Generic number 19<br />**Description**: Enter a number.<br />|
|msdyn_customnumber2|Edm.Decimal|**Display Name**: Generic number 12<br />**Description**: Enter a number.<br />|
|msdyn_customnumber20|Edm.Decimal|**Display Name**: Generic number 21<br />**Description**: Enter a number.<br />|
|msdyn_customnumber3|Edm.Decimal|**Display Name**: Generic number 3<br />**Description**: Enter a number.<br />|
|msdyn_customnumber4|Edm.Decimal|**Display Name**: Generic number 4<br />**Description**: Enter a number.<br />|
|msdyn_customnumber5|Edm.Decimal|**Display Name**: Generic number 5<br />**Description**: Enter a number.<br />|
|msdyn_customnumber6|Edm.Decimal|**Display Name**: Generic number 6<br />**Description**: Enter a number.<br />|
|msdyn_customnumber7|Edm.Decimal|**Display Name**: Generic number 7<br />**Description**: Enter a number.<br />|
|msdyn_customnumber8|Edm.Decimal|**Display Name**: Generic number 8<br />**Description**: Enter a number.<br />|
|msdyn_customnumber9|Edm.Decimal|**Display Name**: Generic number 10<br />**Description**: Enter a number.<br />|
|msdyn_customvalue1|Edm.String|**Display Name**: Generic string 2<br />**Description**: Type some text.<br />|
|msdyn_customvalue2|Edm.String|**Display Name**: Custom Value<br />**Description**: Type a value.<br />|
|msdyn_customvalue3|Edm.String|**Display Name**: Generic text 4<br />**Description**: Type some text.<br />|
|msdyn_customvalue4|Edm.String|**Display Name**: Generic text value 5<br />**Description**: Type a value.<br />|
|msdyn_customvalue5|Edm.String|**Display Name**: Generic text 6<br />**Description**: Type some text.<br />|
|msdyn_documentname|Edm.String|**Display Name**: Document Name<br />**Description**: Type a name for the document.<br />|
|msdyn_emailrespondertrigger|Edm.DateTimeOffset|**Display Name**: Email Responder Trigger<br />**Description**: Select when the email response is triggered.<br />|
|msdyn_emailresponse|Edm.String|**Display Name**: Email Response<br />**Description**: Shows the email address that the respondent supplied.<br />|
|msdyn_faceexpressiontype|Edm.Int32|**Display Name**: Facial Expression Type<br />**Description**: Shows the type of facial expression used to classify the response, for example, as positive, negative, or neutral.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>Negative</td></tr><tr><td>986540001</td><td>Neutral</td></tr><tr><td>986540002</td><td>Positive</td></tr><tbody></table>|
|msdyn_facemodel|Edm.Int32|**Display Name**: Face Model<br />**Description**: Select a face model.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>Female 1</td></tr><tr><td>986540001</td><td>Male 1</td></tr><tr><td>986540002</td><td>Male 2</td></tr><tr><td>986540003</td><td>Female 2</td></tr><tr><td>986540004</td><td>Male 2</td></tr><tr><td>986540005</td><td>Female 3</td></tr><tr><td>986540006</td><td>Male 3</td></tr><tr><td>986540007</td><td>Female 4</td></tr><tr><td>986540008</td><td>Male 4</td></tr><tr><td>986540009</td><td>Female 5</td></tr><tr><td>986540010</td><td>Male 6</td></tr><tr><td>986540011</td><td>Female 7</td></tr><tbody></table>|
|msdyn_facialexpression|Edm.Int32|**Display Name**: Facial Expression<br />**Description**: Facial expression as selected by the respondent<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>No expression</td></tr><tr><td>986540001</td><td>Satisfied</td></tr><tr><td>986540002</td><td>Very Satisfied</td></tr><tr><td>986540003</td><td>Delighted</td></tr><tr><td>986540004</td><td>Not engaged</td></tr><tr><td>986540005</td><td>Not sure / don't know</td></tr><tr><td>986540006</td><td>Bored</td></tr><tr><td>986540007</td><td>Waiting</td></tr><tr><td>986540008</td><td>Disappointed</td></tr><tr><td>986540009</td><td>Sad</td></tr><tr><td>986540010</td><td>Annoyed</td></tr><tr><td>986540011</td><td>Angry</td></tr><tbody></table>|
|msdyn_fax|Edm.String|**Display Name**: Fax<br />**Description**: Shows the fax number that the responder supplied.<br />|
|msdyn_file|Edm.String|**Display Name**: File<br />**Description**: Shows the file.<br />|
|msdyn_firstnameresponse|Edm.String|**Display Name**: First Name<br />**Description**: Shows the first name that the respondent supplied.<br />|
|msdyn_jobtitleresponse|Edm.String|**Display Name**: Job Title<br />**Description**: Select whether the response requires a job title.<br />|
|msdyn_language|Edm.String|**Display Name**: Language<br />**Description**: Shows the language of the respondent.<br />|
|msdyn_lastnameresponse|Edm.String|**Display Name**: Last Name<br />**Description**: Shows the last name that the respondent supplied.<br />|
|msdyn_locale|Edm.String|**Display Name**: Locale<br />**Description**: Shows the locale of the respondent.<br />|
|msdyn_maxscore|Edm.Decimal|**Display Name**: Maximum Score<br />**Description**: Enter the maximum score.<br />|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: The name of the custom entity.<br />|
|msdyn_npscomment|Edm.String|**Display Name**: NPS Comment<br />**Description**: Shows the NPS comment.<br />|
|msdyn_npstype|Edm.Int32|**Display Name**: NPS Type<br />**Description**: NPS®, Net Promoter® & Net Promoter® Score are registered trademarks of Satmetrix Systems, Inc., Bain & Company and Fred Reichheld<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>Promoter</td></tr><tr><td>986540001</td><td>Passive</td></tr><tr><td>986540002</td><td>Detractor</td></tr><tbody></table>|
|msdyn_postalcoderesponse|Edm.String|**Display Name**: Postal Code<br />**Description**: Select a postal code.<br />|
|msdyn_processingcompletetrigger|Edm.Boolean|**Display Name**: Processing Complete Trigger<br />**Description**: Select whether to have a processing complete trigger.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_referencenumber|Edm.String|**Display Name**: Reference Number<br />**Description**: Shows the reference number.<br />|
|msdyn_respondent|Edm.String|**Display Name**: Respondent<br />**Description**: Shows the respondent.<br />|
|msdyn_responseasjson|Edm.String|**Display Name**: Response As JSON<br />**Description**: Shows the response as JSON.<br />|
|msdyn_responseid|Edm.Int32|**Display Name**: Response Id<br />**Description**: ID created by server to uniquely identify this response<br />|
|msdyn_responserulestrigger|Edm.DateTimeOffset|**Display Name**: Response Rules Trigger<br />**Description**: Enter when response rules are triggered.<br />|
|msdyn_responsesashtml|Edm.String|**Display Name**: Responses as Html<br />**Description**: Shows the response as HTML.<br />|
|msdyn_responsesashtmlrespondentlocale|Edm.String|**Display Name**: Responses As Html (Respondent Locale)<br />**Description**: Returns the response as HTML in the locale (or language) completed by the respondent.<br />|
|msdyn_salutationresponse|Edm.String|**Display Name**: Salutation<br />**Description**: Shows the salutation that the respondent supplied.<br />|
|msdyn_satisfactionrating1|Edm.Decimal|**Display Name**: Satisfaction Rating<br />**Description**: Enter a rating.<br />|
|msdyn_satisfactionrating1asint|Edm.Int32|**Display Name**: Satisfaction Rating (Whole Number)<br />**Description**: Enter a rating.<br />|
|msdyn_score|Edm.Decimal|**Display Name**: Score<br />**Description**: Enter a score.<br />|
|msdyn_scoreaspercentage|Edm.Decimal|**Display Name**: Score as Percentage<br />**Description**: Shows the score as a percentage.<br />|
|msdyn_scoreaspercentageallroutes|Edm.Decimal|**Display Name**: Score as Percentage (All Routes)<br />**Description**: Shows the score as a percentage.<br />|
|msdyn_sharedtofacebook|Edm.Boolean|**Display Name**: Shared To Facebook<br />**Description**: Shows whether the survey can be shared to Facebook.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_sharedtogoogle|Edm.Boolean|**Display Name**: Shared To Google<br />**Description**: Shows whether the survey can be shared to Google.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_sharedtolinkedin|Edm.Boolean|**Display Name**: Shared to LinkedIn<br />**Description**: Shows whether the survey can be shared to LinkedIn<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_sharedtotwitter|Edm.Boolean|**Display Name**: Shared To Twitter<br />**Description**: Select whether the response can be shared to Twitter.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_sharedtoyammer|Edm.Boolean|**Display Name**: Shared To Yammer<br />**Description**: Shows whether the survey was shared to Yammer.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_startprocessing|Edm.DateTimeOffset|**Display Name**: Start Processing<br />**Description**: Start Processing.<br />|
|msdyn_stateresponse|Edm.String|**Display Name**: State<br />**Description**: Shows the state that the responder supplied.<br />|
|msdyn_street1response|Edm.String|**Display Name**: Street1<br />**Description**: Shows the Street 1 that the respondent supplied in the address.<br />|
|msdyn_street2response|Edm.String|**Display Name**: Street 2<br />**Description**: Shows the Street 2 that the respondent supplied in the address.<br />|
|msdyn_street3response|Edm.String|**Display Name**: Street3<br />**Description**: Shows the Street 3 that the responder supplied in the address.<br />|
|msdyn_surveyresponseid|Edm.Guid|**Display Name**: Survey Response<br />**Description**: Shows the entity instances.<br />|
|msdyn_telephoneresponse|Edm.String|**Display Name**: Telephone<br />**Description**: Shows the telephone number that the respondent supplied.<br />|
|msdyn_token|Edm.Int32|**Display Name**: Token<br />**Description**: Select a token.<br />|
|msdyn_unsubscribetrigger|Edm.DateTimeOffset|**Display Name**: Unsubscribe Trigger<br />**Description**: Create an unsubscribe trigger.<br />|
|msdyn_version|Edm.String|**Display Name**: Version<br />**Description**: Shows the version of the response.<br />|
|msdyn_versioncode|Edm.String|**Display Name**: Version Code<br />**Description**: Shows the version code.<br />|
|msdyn_websiteresponse|Edm.String|**Display Name**: Website Response<br />**Description**: Shows if this was a response from a website.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Shows the status of the survey response.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Shows the reason for the status of the survey response.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyn_account_value|msdyn_Account<br />|Shows the account associated with the survey response.|
|_msdyn_case_value|msdyn_Case<br />|Shows the case associated with the survey response.|
|_msdyn_contact_value|msdyn_Contact<br />|Shows the contact associated with the survey response.|
|_msdyn_leadid_value|msdyn_Leadid<br />|Shows the lead associated with the survey response.|
|_msdyn_linkedanswer1_value|msdyn_LinkedAnswer1<br />|Shows the linked answer associated with the survey response.|
|_msdyn_linkedanswer10_value|msdyn_LinkedAnswer10<br />|Shows the linked answer associated with the survey response.|
|_msdyn_linkedanswer11_value|msdyn_LinkedAnswer11<br />|Shows the linked answer associated with the survey response.|
|_msdyn_linkedanswer12_value|msdyn_LinkedAnswer12<br />|Shows the linked answer associated with the survey response.|
|_msdyn_linkedanswer13_value|msdyn_LinkedAnswer13<br />|Shows the linked answer associated with the survey response.|
|_msdyn_linkedanswer14_value|msdyn_LinkedAnswer14<br />|Shows the linked answer associated with the survey response.|
|_msdyn_linkedanswer15_value|msdyn_LinkedAnswer15<br />|Shows the linked answer associated with the survey response.|
|_msdyn_linkedanswer2_value|msdyn_LinkedAnswer2<br />|Shows the linked answer associated with the survey response.|
|_msdyn_linkedanswer3_value|msdyn_LinkedAnswer3<br />|Shows the linked answer associated with the survey response.|
|_msdyn_linkedanswer4_value|msdyn_LinkedAnswer4<br />|Shows the linked answer associated with the survey response.|
|_msdyn_linkedanswer5_value|msdyn_LinkedAnswer5<br />|Shows the linked answer associated with the survey response.|
|_msdyn_linkedanswer6_value|msdyn_LinkedAnswer6<br />|Shows the linked answer associated with the survey response.|
|_msdyn_linkedanswer7_value|msdyn_LinkedAnswer7<br />|Shows the linked answer associated with the survey response.|
|_msdyn_linkedanswer8_value|msdyn_LinkedAnswer8<br />|Shows the linked answer associated with the survey response.|
|_msdyn_linkedanswer9_value|msdyn_LinkedAnswer9<br />|Shows the linked answer associated with the survey response.|
|_msdyn_surveyid_value|msdyn_SurveyId<br />|Shows the survey associated with the survey response.|
|_msdyn_surveyinviteid_value||Shows Survey Invitation associated with Survey Response.|
|_msdyn_user_value|msdyn_User<br />|Enter a user.|
|_msevtmgt_eventid_value|msevtmgt_eventId<br />|Event to Survey Response|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Shows the business unit that owns the record.|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_surveyresponse_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_surveyresponse_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_surveyresponse_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_surveyresponse_modifiedonbehalfby|
|msdyn_Account|[account EntityType](account.md)|msdyn_account_msdyn_surveyresponse_Account|
|msdyn_Case|[incident EntityType](incident.md)|msdyn_incident_msdyn_surveyresponse_Case|
|msdyn_Contact|[contact EntityType](contact.md)|msdyn_contact_msdyn_surveyresponse_Contact|
|msdyn_Leadid|[lead EntityType](lead.md)|msdyn_lead_msdyn_surveyresponse_Lead|
|msdyn_LinkedAnswer1|[msdyn_linkedanswer EntityType](msdyn_linkedanswer.md)|msdyn_LinkedAnswer1Id|
|msdyn_LinkedAnswer10|[msdyn_linkedanswer EntityType](msdyn_linkedanswer.md)|msdyn_LinkedAnswer10Id|
|msdyn_LinkedAnswer11|[msdyn_linkedanswer EntityType](msdyn_linkedanswer.md)|msdyn_LinkedAnswer11Id|
|msdyn_LinkedAnswer12|[msdyn_linkedanswer EntityType](msdyn_linkedanswer.md)|msdyn_LinkedAnswer12Id|
|msdyn_LinkedAnswer13|[msdyn_linkedanswer EntityType](msdyn_linkedanswer.md)|msdyn_LinkedAnswer13Id|
|msdyn_LinkedAnswer14|[msdyn_linkedanswer EntityType](msdyn_linkedanswer.md)|msdyn_LinkedAnswer14Id|
|msdyn_LinkedAnswer15|[msdyn_linkedanswer EntityType](msdyn_linkedanswer.md)|msdyn_LinkedAnswer15id|
|msdyn_LinkedAnswer2|[msdyn_linkedanswer EntityType](msdyn_linkedanswer.md)|msdyn_LinkedAnswer2Id|
|msdyn_LinkedAnswer3|[msdyn_linkedanswer EntityType](msdyn_linkedanswer.md)|msdyn_LinkedAnswer3Id|
|msdyn_LinkedAnswer4|[msdyn_linkedanswer EntityType](msdyn_linkedanswer.md)|msdyn_LinkedAnswer4Id|
|msdyn_LinkedAnswer5|[msdyn_linkedanswer EntityType](msdyn_linkedanswer.md)|msdyn_LinkedAnswer5Id|
|msdyn_LinkedAnswer6|[msdyn_linkedanswer EntityType](msdyn_linkedanswer.md)|msdyn_LinkedAnswer6Id|
|msdyn_LinkedAnswer7|[msdyn_linkedanswer EntityType](msdyn_linkedanswer.md)|msdyn_LinkedAnswer7Id|
|msdyn_LinkedAnswer8|[msdyn_linkedanswer EntityType](msdyn_linkedanswer.md)|msdyn_LinkedAnswer8Id|
|msdyn_LinkedAnswer9|[msdyn_linkedanswer EntityType](msdyn_linkedanswer.md)|msdyn_LinkedAnswer9Id|
|msdyn_SurveyId|[msdyn_survey EntityType](msdyn_survey.md)|msdyn_survey_surveyresponse|
|msdyn_surveyinviteid|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|msdyn_surveyinvite_msdyn_surveyresponse|
|msdyn_User|[systemuser EntityType](systemuser.md)|msdyn_systemuser_msdyn_surveyresponse_User|
|msevtmgt_eventId|[msevtmgt_event EntityType](msevtmgt_event.md)|msevtmgt_event_msdyn_surveyresponse_EventId|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_surveyresponse|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_surveyresponse|
|owningteam|[team EntityType](team.md)|team_msdyn_surveyresponse|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_surveyresponse|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_msdyn_surveyresponse_msdyn_surveyinvite_ClosingResponse|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|msdyn_ClosingResponse|  
|msdyn_surveyresponse_ActivityParties|[activityparty EntityType](activityparty.md)|partyid_msdyn_surveyresponse|  
|msdyn_surveyresponse_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_msdyn_surveyresponse|  
|msdyn_surveyresponse_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_msdyn_surveyresponse_adx_alertsubscription|  
|msdyn_surveyresponse_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_msdyn_surveyresponse_adx_inviteredemption|  
|msdyn_surveyresponse_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_msdyn_surveyresponse_adx_portalcomment|  
|msdyn_surveyresponse_Annotations|[annotation EntityType](annotation.md)|objectid_msdyn_surveyresponse|  
|msdyn_surveyresponse_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_msdyn_surveyresponse_appointment|  
|msdyn_surveyresponse_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_surveyresponse|  
|msdyn_surveyresponse_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_surveyresponse|  
|msdyn_surveyresponse_connections1|[connection EntityType](connection.md)|record1id_msdyn_surveyresponse|  
|msdyn_surveyresponse_connections2|[connection EntityType](connection.md)|record2id_msdyn_surveyresponse|  
|msdyn_surveyresponse_Emails|[email EntityType](email.md)|regardingobjectid_msdyn_surveyresponse_email|  
|msdyn_surveyresponse_Faxes|[fax EntityType](fax.md)|regardingobjectid_msdyn_surveyresponse_fax|  
|msdyn_surveyresponse_Letters|[letter EntityType](letter.md)|regardingobjectid_msdyn_surveyresponse_letter|  
|msdyn_surveyresponse_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_msdyn_surveyresponse_msdyn_approval|  
|msdyn_surveyresponse_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_msdyn_surveyresponse_msdyn_bookingalert|  
|msdyn_surveyresponse_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_msdyn_surveyresponse_msdyn_surveyinvite|  
|msdyn_surveyresponse_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_msdyn_surveyresponse_phonecall|  
|msdyn_surveyresponse_questionresponse|[msdyn_questionresponse EntityType](msdyn_questionresponse.md)|msdyn_SurveyResponseId|  
|msdyn_surveyresponse_QueueItems|[queueitem EntityType](queueitem.md)|objectid_msdyn_surveyresponse|  
|msdyn_surveyresponse_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_msdyn_surveyresponse_recurringappointmentmaster|  
|msdyn_surveyresponse_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_msdyn_surveyresponse_serviceappointment|  
|msdyn_surveyresponse_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_msdyn_surveyresponse_socialactivity|  
|msdyn_surveyresponse_SurveyResponse|[msdyn_responseoutcome EntityType](msdyn_responseoutcome.md)|msdyn_SurveyResponse|  
|msdyn_surveyresponse_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_surveyresponse|  
|msdyn_surveyresponse_Tasks|[task EntityType](task.md)|regardingobjectid_msdyn_surveyresponse_task|  

## Operations
The following operations can be used with the msdyn_surveyresponse entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_surveyresponse entity type.


|Name|Description |  
|----|------------|  
|[Event Management with VoC for Dynamics 365 Solution](../solutions/eventmgmtvoclink.md)|[!INCLUDE[../solutions/descriptions/eventmgmtvoclink.md](../solutions/descriptions/eventmgmtvoclink.md)]|  
|[Microsoft Dynamics Marketing Voice Of Customer Integration Solution Solution](../solutions/microsoftdynamicsmktvoclinksolution.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicsmktvoclinksolution.md](../solutions/descriptions/microsoftdynamicsmktvoclinksolution.md)]|  
|[Voice of the Customer for Microsoft Dynamics 365 Solution](../solutions/voiceofthecustomer.md)|[!INCLUDE[../solutions/descriptions/voiceofthecustomer.md](../solutions/descriptions/voiceofthecustomer.md)]|    

[!INCLUDE[./remarks/msdyn_surveyresponse.md](./remarks/msdyn_surveyresponse.md)]

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