---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_survey EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 91323d50-5efd-4435-974a-7c9c4b03fe06
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_survey entitytype."
---
# msdyn_survey EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_survey.md](./descriptions/msdyn_survey.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]msdyn_surveys </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Survey</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_surveyid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_survey entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created.<br />Read-only<br />|
|emailaddress|Edm.String|**Display Name**: E-mail Address<br />**Description**: Shows the primary email address for the entity.<br />|
|entityimage|Edm.Binary|**Display Name**: Image<br />**Description**: Select an image for the survey.<br />|
|entityimage_timestamp|Edm.Int64|Read-only<br />|
|entityimage_url|Edm.String|Read-only<br />|
|entityimageid|Edm.Guid|Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was modified.<br />Read-only<br />|
|msdyn_abbreviation|Edm.String|**Display Name**: Abbreviation<br />**Description**: Type an abbreviation for the survey.<br />|
|msdyn_acceptanonymousresponses|Edm.Boolean|**Display Name**: Accept anonymous responses<br />**Description**: Accept responses from respondents that are not currently in the Dynamics 365 system.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_addtositemap|Edm.Int32|**Display Name**: Add to Sitemap<br />**Description**: Select whether to add the survery to the site map.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>Sales</td></tr><tr><td>986540001</td><td>Marketing</td></tr><tr><td>986540002</td><td>Service</td></tr><tbody></table>|
|msdyn_alertlowertarget|Edm.Decimal|**Display Name**: Alert Lower Target<br />**Description**: Customer satisfaction score (or below) that will trigger an alert<br />|
|msdyn_allowsave|Edm.Boolean|**Display Name**: Allow Save<br />**Description**: Select whether to allow the survey to be saved and continued at another time.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_anonymoussurveyurl|Edm.String|**Display Name**: Anonymous Survey Url<br />**Description**: URL for respondents to complete surveys anonymously.  Responses won't be matched to existing Dynamics 365 records unless 'Create Lead' is specified.<br />|
|msdyn_assignresponses|Edm.Int32|**Display Name**: Assign Responses<br />**Description**: Select who to assign responses to.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>Assign to me</td></tr><tr><td>986540001</td><td>Assign to another user</td></tr><tr><td>986540002</td><td>Assign to team</td></tr><tbody></table>|
|msdyn_attributegenerationtrigger|Edm.DateTimeOffset|**Display Name**: Field Generation Trigger<br />**Description**: Shows the attribute generation trigger.<br />|
|msdyn_automaticallysendemailresponse|Edm.Int32|**Display Name**: Automatically Send Response<br />**Description**: Select whether to automatically send an email response.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540001</td><td>No</td></tr><tr><td>986540000</td><td>Yes</td></tr><tbody></table>|
|msdyn_calculatescore|Edm.Int32|**Display Name**: Calculate Score<br />**Description**: Automatically calculate the score based on the scoring configuration of individual questions<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>Yes</td></tr><tr><td>986540001</td><td>No</td></tr><tbody></table>|
|msdyn_cloneddate|Edm.DateTimeOffset|**Display Name**: Cloned Date<br />**Description**: Shows the date when the survey was cloned.<br />|
|msdyn_closeddate|Edm.DateTimeOffset|**Display Name**: Closed Date<br />**Description**: Shows the date at which respondents will no longer be able to take the survey and will be shown the redirection URL.<br />|
|msdyn_closeinvitationonresponsereceived|Edm.Boolean|**Display Name**: Close Invitation<br />**Description**: Select whether to close the invitation when a response is received.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_convertresponsestofeedback|Edm.Int32|**Display Name**: Response Conversion<br />**Description**: How should the survey responses be processed when they are received in Dynamics 365?<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>Off</td></tr><tr><td>986540001</td><td>Sub surveys only</td></tr><tr><td>986540002</td><td>Survey and sub surveys</td></tr><tbody></table>|
|msdyn_createalert|Edm.Int32|**Display Name**: Create Alert<br />**Description**: Create an alert task for the survey owner if the customer satisfaction measure equals or is less than the lower target.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>No</td></tr><tr><td>986540001</td><td>Yes</td></tr><tbody></table>|
|msdyn_createleadforanonymousresponses|Edm.Boolean|**Display Name**: Create Lead For Anonymous Responses<br />**Description**: Create a new lead for anonymous responses.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_currentpage|Edm.Int32|**Display Name**: Current Page<br />**Description**: Enter the current page number.<br />|
|msdyn_customlinkdisplayname|Edm.String|**Display Name**: Custom Link Display Name<br />**Description**: The display text of the custom link.<br />|
|msdyn_customlinkurl|Edm.String|**Display Name**: Custom Link URL<br />**Description**: If specified, the URL of the custom link.<br />|
|msdyn_description|Edm.String|**Display Name**: Description<br />**Description**: Description of survey for other Dynamics 365 users<br />|
|msdyn_donotbulkemail|Edm.Boolean|**Display Name**: Do Not Bulk Email<br />**Description**: Sets the Do Not Bulk Email field on the related entity<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Do not allow</td></tr><tr><td>0</td><td>Allow</td></tr><tbody></table>|
|msdyn_donotemail|Edm.Boolean|**Display Name**: Do Not Allow Email<br />**Description**: Sets the Do Not Allow Email field on the related entity.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Do not allow</td></tr><tr><td>0</td><td>Allow</td></tr><tbody></table>|
|msdyn_donotfax|Edm.Boolean|**Display Name**: Do Not Fax<br />**Description**: Sets the Do Not Fax field on the related entity<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Do not allow</td></tr><tr><td>0</td><td>Allow</td></tr><tbody></table>|
|msdyn_donotsendmm|Edm.Boolean|**Display Name**: Do Not Send MM<br />**Description**: Sets the Do Not Send Marketing Materials field on the related entity<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Do not allow</td></tr><tr><td>0</td><td>Allow</td></tr><tbody></table>|
|msdyn_emailtemplateid|Edm.String|**Display Name**: Email Template Id<br />**Description**: Select the email template.<br />|
|msdyn_enablesocialsharing|Edm.Boolean|**Display Name**: Enable Social Sharing<br />**Description**: Enables social sharing for scale questions allowing respondents to share positive results via selected social media<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_entitygenerationtrigger|Edm.DateTimeOffset|**Display Name**: Entity Generation Trigger<br />**Description**: Select when to generate a survey.<br />|
|msdyn_feedbackcurrentsteptimestamp|Edm.DateTimeOffset|**Display Name**: Feedback Current Stamp Timestamp<br />|
|msdyn_feedbackgenerationstatus|Edm.Int32|**Display Name**: Feedback Generation Status<br />**Description**: Status of Feedback Generation<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>Generating</td></tr><tr><td>986540001</td><td>Generated - Success</td></tr><tr><td>986540002</td><td>Generated - Error</td></tr><tbody></table>|
|msdyn_feedbackname|Edm.String|**Display Name**: Feedback Name<br />**Description**: Generated entity name<br />|
|msdyn_formsandviewstrigger|Edm.DateTimeOffset|**Display Name**: Forms And Views Trigger<br />**Description**: Used to trigger the generation of the forms and views for the feedback entity<br />|
|msdyn_generatedashboard|Edm.Boolean|**Display Name**: Generate Dashboard<br />**Description**: Generate charts and dashboards.  Turn off if already created and manually modified.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_generatefeedback|Edm.Int32|**Display Name**: Generate Feedback<br />**Description**: When to generate feedback entities when publishing this survey<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540001</td><td>Off</td></tr><tr><td>986540000</td><td>Automatically when survey published</td></tr><tr><td>986540002</td><td>Manually</td></tr><tbody></table>|
|msdyn_generateform|Edm.Boolean|**Display Name**: Generate Form<br />**Description**: Generate, or re-generate the form?  Turn off form generation if the form has been customized.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_generatesurveymanualnow|Edm.Boolean|**Display Name**: Generate Survey Manually<br />**Description**: Select whether to generate a survey now.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_generatesurveyresponses|Edm.Boolean|**Display Name**: Generate Survey Responses<br />**Description**: Select whether to generate survey responses.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_iframeurl|Edm.String|**Display Name**: IFrameUrl<br />**Description**: HTML to embed a survey within a web page.  Typically used for embedding lead capture surveys in a web page.  Copy and Paste this code.<br />|
|msdyn_invitationlinktext|Edm.String|**Display Name**: Invitation Link Text<br />**Description**: Text used for the invitation link.  For example 'Click here to take survey'<br />|
|msdyn_invitationsnippet|Edm.String|**Display Name**: Invitation Snippet<br />**Description**: Automatically created snippet used to embed anywhere in an email in Dynamics 365.  When the email is saved, this will be replaced with a hyperlink.<br />|
|msdyn_keymeasure|Edm.String|**Display Name**: Key Measure<br />**Description**: Measure used for charts and dashboards<br />|
|msdyn_language|Edm.Int32|**Display Name**: Language<br />**Description**: Default language used when generating the feedback entities.<br />|
|msdyn_languages|Edm.String|**Display Name**: languages<br />**Description**: Automatically generated - do not modify<br />|
|msdyn_lastgeneratedon|Edm.DateTimeOffset|**Display Name**: Last Generated On<br />**Description**: Shows when the survey was last generated.<br />|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: The name of the survey (not displayed to respondents).<br />|
|msdyn_nexttext|Edm.String|**Display Name**: Next Text<br />**Description**: Text displayed to respondents to progress to the next page.<br />|
|msdyn_pagenumbers|Edm.Boolean|**Display Name**: Display Page Numbers<br />**Description**: Display page numbers at the bottom of the survey navigation bar?<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_pluginexception|Edm.String|**Display Name**: Plug-In Exception<br />**Description**: For internal use only.<br />|
|msdyn_pluginignore|Edm.String|**Display Name**: Ignore Plug-In<br />**Description**: For internal use only.<br />|
|msdyn_pluralname|Edm.String|**Display Name**: Plural Name<br />**Description**: Generated entity plural name<br />|
|msdyn_previewtrigger|Edm.String|**Display Name**: Preview Trigger<br />**Description**: Shows the preview trigger.<br />|
|msdyn_previoustext|Edm.String|**Display Name**: Previous Text<br />**Description**: Text displayed to respondents to progress to the next page.<br />|
|msdyn_privacypolicylinktext|Edm.String|**Display Name**: Privacy Policy Link Text<br />**Description**: Link text displayed to respondents for the privacy policy.<br />|
|msdyn_privacypolicyurl|Edm.String|**Display Name**: Privacy Policy Url<br />**Description**: Privacy Policy URL displayed to the respondent at runtime<br />|
|msdyn_publisheddate|Edm.DateTimeOffset|**Display Name**: Published Date<br />**Description**: Shows the date that the survey was published to the server. Setting the date will also trigger a publish.<br />|
|msdyn_publishentitytrigger|Edm.DateTimeOffset|**Display Name**: Publish Trigger<br />**Description**: Enter the date when the survey will be published.<br />|
|msdyn_publishwarnings|Edm.String|**Display Name**: Publish Warnings<br />**Description**: Type the publish warnings.<br />|
|msdyn_queuegenerationdate|Edm.DateTimeOffset|**Display Name**: Queue Generation Date<br />**Description**: Select the queue generation date.<br />|
|msdyn_queuepoptrigger|Edm.DateTimeOffset|**Display Name**: Queue Pop Trigger<br />**Description**: Enter the queue pop trigger.<br />|
|msdyn_redirectlinktext|Edm.String|**Display Name**: Redirect Link Text<br />**Description**: Link text displayed to the respondent<br />|
|msdyn_redirecturl|Edm.String|**Display Name**: Redirect Link URL<br />**Description**: The URL that is displayed to the respondent if survey is paused, completed, or an unknown error is encountered with the survey.<br />|
|msdyn_relatedentity|Edm.String|**Display Name**: Regarding Entity<br />**Description**: Entity schema name that this feedback relates to, for example, if this survey (or sub survey) relates to Case then "incident."<br />|
|msdyn_relatetoaccount|Edm.Boolean|**Display Name**: Relate to Account<br />**Description**: Automatically generate a relationship to the account entity<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_relatetocontact|Edm.Boolean|**Display Name**: Relate To Contact<br />**Description**: Automatically create a relationship to the contact entity?<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_relationshipgenerationtrigger|Edm.DateTimeOffset|**Display Name**: Relationship Generation Trigger<br />**Description**: Shows the relationship generator trigger.<br />|
|msdyn_respondentdataactiontype|Edm.Int32|**Display Name**: Respondent Data Action Type<br />**Description**: How data is returned in Dynamics 365<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>Download respondent data to a single row</td></tr><tr><td>986540002</td><td>Download respondent data and expand each response to a row</td></tr><tr><td>986540001</td><td>Do not download individual responses, aggregate the data</td></tr><tbody></table>|
|msdyn_responsecount|Edm.Int32|**Display Name**: Response Count<br />**Description**: Shows the response count.<br />|
|msdyn_restrictmultiplecompletions|Edm.Boolean|**Display Name**: Restrict Multiple Completions<br />**Description**: Restrict the same respondent completing the survey more than once.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_runiniframe|Edm.Boolean|**Display Name**: Run in IFrame<br />**Description**: Should the survey be run within another web page?  Choosing 'Yes' will generate the HTML code that can be copied to your web page.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_runtimetitle|Edm.String|**Display Name**: Runtime Title<br />**Description**: Text displayed in browser title, for example, "Annual Satisfaction Survey."<br />|
|msdyn_savesurveytext|Edm.String|**Display Name**: Save Survey Text<br />**Description**: Select whether to save the survey text.<br />|
|msdyn_schemaname|Edm.String|**Display Name**: Schema Name<br />**Description**: Schema name for the feedback entity to be generated<br />|
|msdyn_showentityinnavigationpane|Edm.Boolean|**Display Name**: Show Navigation Pane<br />**Description**: Select whether to show the navigation pane for the survey.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_showprogressbar|Edm.Boolean|**Display Name**: Show Progress Bar<br />**Description**: Displays the progress bar at runtime to the respondent<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_showtechnicalhelp|Edm.Boolean|**Display Name**: Show Technical Help Link<br />**Description**: Should a 'Technical Help' link be displayed at the bottom of the page to respondents?<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_solutionname|Edm.String|**Display Name**: Solution Name<br />**Description**: Solution name (not display name) to add the newly generated feedback entity to.  Default: 'Feedback'<br />|
|msdyn_stoppeddate|Edm.DateTimeOffset|**Display Name**: Date Survey Ended<br />**Description**: Shows when the survey ended and no longer accepted responses.<br />|
|msdyn_submittext|Edm.String|**Display Name**: Submit Text<br />**Description**: Text displayed to respondents to submit the survey responses<br />|
|msdyn_summaryhtml|Edm.String|**Display Name**: Summary Html<br />**Description**: Auto generated summary of the responses received<br />|
|msdyn_support|Edm.String|**Display Name**: Support<br />**Description**: Type support information.<br />|
|msdyn_surveyalreadytakentextblock|Edm.String|**Display Name**: Survey Already Taken Text Block<br />**Description**: Message displayed to the respondent if the survey is already taken<br />|
|msdyn_surveycompletelinkurl|Edm.String|**Display Name**: Survey Complete Link URL<br />**Description**: Link displayed to the respondent when the survey is complete<br />|
|msdyn_surveycompletetext|Edm.String|**Display Name**: Survey Completed Text<br />**Description**: Type the text to display when the survey is completed.<br />|
|msdyn_surveyemailaddress|Edm.String|**Display Name**: Survey E-mail Address<br />**Description**: The email address to display to the user if there are issues with the survey (your organization email address)<br />|
|msdyn_surveyemailaddresstext|Edm.String|**Display Name**: Survey Email Address Text<br />**Description**: Text to display for the survey email address<br />|
|msdyn_surveyheadertextblock|Edm.String|**Display Name**: Survey Header Text Block<br />**Description**: Header text displayed at the top of each survey, for example, the organization or survey name.<br />|
|msdyn_surveyid|Edm.Guid|**Display Name**: Survey<br />**Description**: Shows the entity instances.<br />|
|msdyn_surveyrecordid|Edm.String|**Display Name**: Survey Id<br />**Description**: Record ID for the Survey<br />|
|msdyn_surveyurl|Edm.String|**Display Name**: Survey Url<br />**Description**: For internal use only.<br />|
|msdyn_switchtodefaultform|Edm.DateTimeOffset|**Display Name**: Switch to Default Form<br />**Description**: Enter when to switch to default form.<br />|
|msdyn_translations|Edm.String|**Display Name**: Translations<br />**Description**: Select the languages to translate the survey into.<br />|
|msdyn_translationtrigger|Edm.DateTimeOffset|**Display Name**: Translation Trigger<br />**Description**: Used to trigger the generation of the translation file<br />|
|msdyn_uniqueurldescription|Edm.String|**Display Name**: Unique URL Description<br />**Description**: Human readable unique identifier of this survey that is used to build the URL of the survey.<br />|
|msdyn_unsubscribe|Edm.Int32|**Display Name**: Unsubscribe<br />**Description**: Include a link for the respondents to unsubscribe.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>No</td></tr><tr><td>986540001</td><td>Yes</td></tr><tbody></table>|
|msdyn_unsubscribelinktext|Edm.String|**Display Name**: Unsubscribe Link Text<br />**Description**: Text for the unsubscribe link displayed to the respondent.<br />|
|msdyn_unsubscriberesponses|Edm.Boolean|**Display Name**: Unsubscribe Responses<br />**Description**: If specified, responses will be unsubscribed<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_unsubscribesurveyurl|Edm.String|**Display Name**: Unsubscribe Survey Url<br />**Description**: Enter the URL to use to unsubscribe to the survey.<br />|
|msdyn_usecaptcha|Edm.Int32|**Display Name**: Use Captcha<br />**Description**: Should the survey require respondents to enter text displayed on the screen?  This option is usually required for anonymous surveys only.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>No</td></tr><tr><td>986540001</td><td>Yes</td></tr><tbody></table>|
|msdyn_userulesengine|Edm.Boolean|**Display Name**: Use Rules Engine<br />**Description**: Should the survey apply rules logic to create actions if required<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_useversioning|Edm.Boolean|**Display Name**: Use versioning<br />**Description**: Indicate if specific versions of the survey should be included only.  Advanced use only.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_version|Edm.String|**Display Name**: Version<br />**Description**: Shows the version of the survey.<br />|
|msdyn_versioncode|Edm.String|**Display Name**: Version Code<br />**Description**: Shows the version code.<br />|
|msdyncrm_questionscount|Edm.Int32|**Display Name**: Questions Count<br />**Description**: The number of questions in the survey.<br />Computed<br />|
|msdyncrm_questionscount_date|Edm.DateTimeOffset|**Display Name**: Questions Count (Last Updated On)<br />**Description**: Last Updated time of rollup field Questions Count.<br />Read-only<br />|
|msdyncrm_questionscount_state|Edm.Int32|**Display Name**: Questions Count (State)<br />**Description**: State of rollup field Questions Count.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Shows the status of the survey.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Shows the reason for the status of the survey.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Draft</td></tr><tr><td>986540000</td><td>Stopped</td></tr><tr><td>986540001</td><td>Published</td></tr><tr><td>2</td><td>Inactive</td></tr><tr><td>986540002</td><td>Completed</td></tr><tbody></table>|
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
|_msdyn_configurationid_value|msdyn_ConfigurationId<br />|Shows the related configuration.|
|_msdyn_keymeasuremapping_value|msdyn_KeyMeasureMapping<br />|Shows the feedback mapping associated with the survey.|
|_msdyn_keymeasurequestion_value|msdyn_KeyMeasureQuestion<br />|Key question used in auto generated dashboards and charts to provide high level analysis.|
|_msdyn_publishinguser_value|msdyn_PublishingUser<br />|Shows the user associated with the survey.|
|_msdyn_surveyimageid_value|msdyn_SurveyImageId<br />|Shows the related image.|
|_msdyn_themeid_value|msdyn_ThemeId<br />|Shows the related theme.|
|_msdyn_unsubscribesurvey_value|msdyn_Unsubscribesurvey<br />|Related unsubscribe survey|
|_msevtmgt_eventid_value|msevtmgt_eventid<br />|Event to Survey|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Shows the business unit that owns the record.|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_survey_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_survey_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_survey_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_survey_modifiedonbehalfby|
|msdyn_ConfigurationId|[msdyn_vocconfiguration EntityType](msdyn_vocconfiguration.md)|msdyn_vocconfiguration_survey|
|msdyn_KeyMeasureMapping|[msdyn_feedbackmapping EntityType](msdyn_feedbackmapping.md)|msdyn_feedbackmapping_msdyn_survey_KeyMeasureMapping|
|msdyn_KeyMeasureQuestion|[msdyn_question EntityType](msdyn_question.md)|msdyn_msdyn_question_msdyn_survey_KeyMeasureQuestion|
|msdyn_PublishingUser|[systemuser EntityType](systemuser.md)|msdyn_systemuser_Survey|
|msdyn_SurveyImageId|[msdyn_image EntityType](msdyn_image.md)|msdyn_image_survey|
|msdyn_ThemeId|[msdyn_theme EntityType](msdyn_theme.md)|msdyn_theme_survey|
|msdyn_Unsubscribesurvey|[msdyn_survey EntityType](msdyn_survey.md)|msdyn_survey_unsubscribesurvey|
|msevtmgt_eventid|[msevtmgt_event EntityType](msevtmgt_event.md)|msevtmgt_event_msdyn_survey_EventId|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_survey|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_survey|
|owningteam|[team EntityType](team.md)|team_msdyn_survey|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_survey|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_feedbacksubsurvey_msdyn_survey|[msdyn_feedbacksubsurvey EntityType](msdyn_feedbacksubsurvey.md)|msdyn_feedbacksubsurvey_msdyn_survey|  
|msdyn_msdyn_survey_msdyn_import_AppendToSurvey|[msdyn_import EntityType](msdyn_import.md)|msdyn_AppendToSurvey|  
|msdyn_msdyn_survey_msdyn_import_SurveyCreated|[msdyn_import EntityType](msdyn_import.md)|msdyn_SurveyCreated|  
|msdyn_msdyn_survey_msdyn_responseaction_ChainDestinationSurvey|[msdyn_responseaction EntityType](msdyn_responseaction.md)|msdyn_ChainDestinationSurvey|  
|msdyn_msdyn_survey_msdyn_responseoutcome_SurveyId|[msdyn_responseoutcome EntityType](msdyn_responseoutcome.md)|msdyn_SurveyId|  
|msdyn_survey_ActivityParties|[activityparty EntityType](activityparty.md)|partyid_msdyn_survey|  
|msdyn_survey_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_msdyn_survey|  
|msdyn_survey_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_msdyn_survey_adx_alertsubscription|  
|msdyn_survey_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_msdyn_survey_adx_inviteredemption|  
|msdyn_survey_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_msdyn_survey_adx_portalcomment|  
|msdyn_survey_Annotations|[annotation EntityType](annotation.md)|objectid_msdyn_survey|  
|msdyn_survey_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_msdyn_survey_appointment|  
|msdyn_survey_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_survey|  
|msdyn_survey_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_survey|  
|msdyn_survey_configurations|[msdyn_vocconfiguration EntityType](msdyn_vocconfiguration.md)|msdyn_DefaultsurveytemplateId|  
|msdyn_survey_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_msdyn_survey|  
|msdyn_survey_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_msdyn_survey|  
|msdyn_survey_Emails|[email EntityType](email.md)|regardingobjectid_msdyn_survey_email|  
|msdyn_survey_Faxes|[fax EntityType](fax.md)|regardingobjectid_msdyn_survey_fax|  
|msdyn_survey_feedbackmapping_SurveyId|[msdyn_feedbackmapping EntityType](msdyn_feedbackmapping.md)|msdyn_SurveyId|  
|msdyn_survey_feedbacksubsurvey_ChildSurvey|[msdyn_feedbacksubsurvey EntityType](msdyn_feedbacksubsurvey.md)|msdyn_ChildSurvey|  
|msdyn_survey_import_SurveyToAttach|[msdyn_import EntityType](msdyn_import.md)|msdyn_SurveyToAttach|  
|msdyn_survey_Letters|[letter EntityType](letter.md)|regardingobjectid_msdyn_survey_letter|  
|msdyn_survey_logic_Survey|[msdyn_responsecondition EntityType](msdyn_responsecondition.md)|msdyn_Survey|  
|msdyn_survey_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_msdyn_survey_msdyn_approval|  
|msdyn_survey_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_msdyn_survey_msdyn_bookingalert|  
|msdyn_survey_msdyn_question_SurveyId|[msdyn_question EntityType](msdyn_question.md)|msdyn_SurveyId|  
|msdyn_survey_msdyn_questionresponse|[msdyn_questionresponse EntityType](msdyn_questionresponse.md)|msdyn_SurveyId|  
|msdyn_survey_msdyn_responseaction_Survey|[msdyn_responseaction EntityType](msdyn_responseaction.md)|msdyn_Survey|  
|msdyn_survey_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_msdyn_survey_msdyn_surveyinvite|  
|msdyn_survey_page|[msdyn_page EntityType](msdyn_page.md)|msdyn_SurveyId|  
|msdyn_survey_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_msdyn_survey_phonecall|  
|msdyn_survey_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_msdyn_survey_recurringappointmentmaster|  
|msdyn_survey_routing_Survey|[msdyn_responserouting EntityType](msdyn_responserouting.md)|msdyn_Survey|  
|msdyn_survey_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_msdyn_survey_serviceappointment|  
|msdyn_survey_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_msdyn_survey_socialactivity|  
|msdyn_survey_surveyinvite|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|msdyn_surveyid|  
|msdyn_survey_surveyresponse|[msdyn_surveyresponse EntityType](msdyn_surveyresponse.md)|msdyn_SurveyId|  
|msdyn_survey_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_survey|  
|msdyn_survey_Tasks|[task EntityType](task.md)|regardingobjectid_msdyn_survey_task|  
|msdyn_survey_unsubscribesurvey|[msdyn_survey EntityType](msdyn_survey.md)|msdyn_Unsubscribesurvey|  

## Operations
The following operations can be used with the msdyn_survey entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_survey entity type.


|Name|Description |  
|----|------------|  
|[Event Management with VoC for Dynamics 365 Solution](../solutions/eventmgmtvoclink.md)|[!INCLUDE[../solutions/descriptions/eventmgmtvoclink.md](../solutions/descriptions/eventmgmtvoclink.md)]|  
|[Microsoft Dynamics Marketing Voice Of Customer Integration Solution Solution](../solutions/microsoftdynamicsmktvoclinksolution.md)|[!INCLUDE[../solutions/descriptions/microsoftdynamicsmktvoclinksolution.md](../solutions/descriptions/microsoftdynamicsmktvoclinksolution.md)]|  
|[Voice of the Customer for Microsoft Dynamics 365 Solution](../solutions/voiceofthecustomer.md)|[!INCLUDE[../solutions/descriptions/voiceofthecustomer.md](../solutions/descriptions/voiceofthecustomer.md)]|    

[!INCLUDE[./remarks/msdyn_survey.md](./remarks/msdyn_survey.md)]

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