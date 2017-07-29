---
title: "Microsoft Dynamics 365 Customer Engagement msdyn_question EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: c87d75ad-5d3f-4beb-910a-5e8323044b91
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API msdyn_question entitytype."
---
# msdyn_question EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/msdyn_question.md](./descriptions/msdyn_question.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]msdyn_questions </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Question</td></tr>
<tr><td><b>Primary Key:</b></td><td>msdyn_questionid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>msdyn_name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The msdyn_question entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Shows the sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was modified.<br />Read-only<br />|
|msdyn_aftersharingmessage|Edm.String|**Display Name**: After Sharing Message<br />**Description**: Short text to display to the respondent after a respondent has shared result via social media<br />|
|msdyn_allowiframes|Edm.Boolean|**Display Name**: Allow Iframes<br />**Description**: Select whether to allow iFrames in the question.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_answertag|Edm.String|**Display Name**: Answer Tag<br />**Description**: Store the answer response to a tag that can be replaced in subsequent questions and answers in the survey at run time.  Use a tag such as _UOM_ and embed this in the question and answer text.<br />|
|msdyn_columns|Edm.Int32|**Display Name**: Columns<br />**Description**: The number of columns to use for a big button answer type<br />|
|msdyn_createquestionresponse|Edm.Int32|**Display Name**: Create Question Response<br />**Description**: Create a question response.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>Yes</td></tr><tr><td>986540001</td><td>No</td></tr><tbody></table>|
|msdyn_customereffortscore|Edm.Boolean|**Display Name**: Customer Effort Score<br />**Description**: Is this question a CES score question?  If so, data is stored in a separate place on the survey response entity and other features are enabled.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_customersatisfactionscorecsat|Edm.Boolean|**Display Name**: Customer Satisfaction Score (CSAT)<br />**Description**: Is this question a CSAT question?  If so certain features are enabled.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_description|Edm.String|**Display Name**: Description<br />**Description**: Description of the question and its purpose.<br />|
|msdyn_displaylogic|Edm.Int32|**Display Name**: Display Logic<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>All are true (AND)</td></tr><tr><td>986540001</td><td>Any are true (OR)</td></tr><tbody></table>|
|msdyn_enablesocialsharing|Edm.Boolean|**Display Name**: Enable Social Sharing<br />**Description**: Enables respondents to share the result if positive through social media.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_facebook|Edm.Boolean|**Display Name**: Facebook<br />**Description**: Allow respondent to share the result via Facebook?<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_faceexpression|Edm.Int32|**Display Name**: Face Expression<br />**Description**: Select the face expression.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>Yes</td></tr><tr><td>986540001</td><td>No</td></tr><tbody></table>|
|msdyn_faceexpressionpicker|Edm.Int32|**Display Name**: Face Expression Picker<br />**Description**: Select a face expression.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>Yes</td></tr><tr><td>986540001</td><td>No</td></tr><tbody></table>|
|msdyn_filtercomparisonvalue|Edm.String|**Display Name**: Filter Comparison Value<br />**Description**: Shows the filter comparison value.<br />|
|msdyn_filteroperator|Edm.Int32|**Display Name**: Filter Operation<br />**Description**: Select the filter operation.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>Equals</td></tr><tr><td>986540001</td><td>Not equals</td></tr><tr><td>986540002</td><td>Greater than</td></tr><tr><td>986540003</td><td>Less than</td></tr><tbody></table>|
|msdyn_format|Edm.String|**Display Name**: Format<br />**Description**: Format of the response<br />|
|msdyn_globalorderindex|Edm.Int32|**Display Name**: Global Order Index<br />**Description**: Shows the global order index.<br />|
|msdyn_google|Edm.Boolean|**Display Name**: Google<br />**Description**: Allow respondent to share the result via Google +<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_help|Edm.String|**Display Name**: Help<br />**Description**: Type the Help text.<br />|
|msdyn_html|Edm.String|**Display Name**: Html<br />**Description**: Html of question<br />|
|msdyn_inputalignment|Edm.Int32|**Display Name**: Input Alignment<br />**Description**: Alignment of the input control associated with the question<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>Left</td></tr><tr><td>986540001</td><td>Center</td></tr><tr><td>986540002</td><td>Right</td></tr><tbody></table>|
|msdyn_layouttype|Edm.Int32|**Display Name**: Layout type<br />**Description**: Single question per line or multiple question per line?<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>Single question per line (HTML Block)</td></tr><tr><td>986540001</td><td>Multiple questions per line (HTML inline)</td></tr><tbody></table>|
|msdyn_linkedin|Edm.Boolean|**Display Name**: LinkedIn<br />**Description**: Allow the respondent to share the result via LinkedIn?<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_linkquestion|Edm.Int32|**Display Name**: Link Question<br />**Description**: Common question linking more than one question in separate surveys.  Used for reporting purposes.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>Link</td></tr><tr><td>986540001</td><td>Do not link</td></tr><tbody></table>|
|msdyn_maximum|Edm.Int32|**Display Name**: Maximum<br />**Description**: Maximum value for this question.  Used for multiple question types.<br />|
|msdyn_minimum|Edm.Int32|**Display Name**: Minimum<br />**Description**: Minimum value for the question.  Used for multiple question types.<br />|
|msdyn_minimumresponsesranked|Edm.Int32|**Display Name**: Minimum Responses Ranked<br />**Description**: The minimum number of responses that respondents are required to select<br />|
|msdyn_multipleresponsetype|Edm.Int32|**Display Name**: Multiple Response Type<br />**Description**: Big buttons or check boxes?<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540001</td><td>Big buttons</td></tr><tr><td>986540000</td><td>Check boxes</td></tr><tbody></table>|
|msdyn_name|Edm.String|**Display Name**: Name<br />**Description**: The name of the custom entity.<br />|
|msdyn_netpromoterscore|Edm.Boolean|**Display Name**: Net Promoter Score<br />**Description**: Is question Net Promoter Score?  If so, several other features are enabled.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_numbertype|Edm.Int32|**Display Name**: Number Type<br />**Description**: Whole number or decimal?<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>Whole number</td></tr><tr><td>986540001</td><td>Decimal</td></tr><tbody></table>|
|msdyn_orderindex|Edm.Int32|**Display Name**: Order Index<br />**Description**: Shows the order index.<br />|
|msdyn_pickresponses|Edm.Boolean|**Display Name**: Pick Responses<br />**Description**: Allow respondents to choose items to rank.  If no then rankings can be ordered only.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_pipetype|Edm.Int32|**Display Name**: Pipe Type<br />**Description**: Select the type of pipe.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>User</td></tr><tr><td>2</td><td>Product</td></tr><tr><td>3</td><td>Service</td></tr><tr><td>4</td><td>Customer</td></tr><tr><td>5</td><td>Location</td></tr><tr><td>6</td><td>Date time</td></tr><tr><td>7</td><td>Other 1</td></tr><tr><td>8</td><td>Other 2</td></tr><tr><td>9</td><td>Other 3</td></tr><tbody></table>|
|msdyn_pluginignore|Edm.String|**Display Name**: Plugin Ignore<br />**Description**: For internal use only.<br />|
|msdyn_querystring|Edm.Int32|**Display Name**: Query String<br />**Description**: If the invitation URL contains a query string argument that matches the argument selected, then the answer will be pre-populated.  Example: [url]?a=Good or [url]?ai=2<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>a</td></tr><tr><td>986540001</td><td>b</td></tr><tr><td>986540002</td><td>c</td></tr><tbody></table>|
|msdyn_questiongrouptype|Edm.Int32|**Display Name**: Question Group Type<br />**Description**: Parent question group type<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>Question and answer</td></tr><tr><td>986540002</td><td>Grid of single select questions</td></tr><tr><td>986540003</td><td>Grid of multiple select questions</td></tr><tr><td>986540001</td><td>Grid of image scales</td></tr><tr><td>986540004</td><td>Fixed sum questions</td></tr><tbody></table>|
|msdyn_questionid|Edm.Guid|**Display Name**: Question<br />**Description**: Shows the entity instances.<br />|
|msdyn_questionlayouttype|Edm.Int32|**Display Name**: Question Layout Type<br />**Description**: Layout of the question as it appears on the survey to the respondent.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>Question at the top, answer below</td></tr><tr><td>986540001</td><td>Question one third space, question left aligned</td></tr><tr><td>986540008</td><td>Question one third space, question right aligned</td></tr><tr><td>986540002</td><td>Question half space, question left aligned</td></tr><tr><td>986540003</td><td>Question half space, question right aligned</td></tr><tr><td>986540004</td><td>Question two thirds space, question left aligned</td></tr><tr><td>986540005</td><td>Question two thirds space, question right aligned</td></tr><tbody></table>|
|msdyn_questiontext|Edm.String|**Display Name**: Question Text<br />**Description**: HTML Text block for the question label<br />|
|msdyn_questiontextalignment|Edm.Int32|**Display Name**: Question text alignment<br />**Description**: Alignment of the question label associated with question<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>Left</td></tr><tr><td>986540001</td><td>Center</td></tr><tr><td>986540002</td><td>Right</td></tr><tr><td>986540003</td><td>Top</td></tr><tbody></table>|
|msdyn_questiontype|Edm.Int32|**Display Name**: Question Type<br />**Description**: Type of question to display<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Single line of text</td></tr><tr><td>2</td><td>Multiple lines of text</td></tr><tr><td>3</td><td>Numeric</td></tr><tr><td>4</td><td>Single response option set</td></tr><tr><td>5</td><td>Multiple response option set</td></tr><tr><td>6</td><td>Date Time</td></tr><tr><td>9</td><td>Rating</td></tr><tr><td>10</td><td>Descriptive text</td></tr><tr><td>11</td><td>Email</td></tr><tr><td>12</td><td>Web Site</td></tr><tr><td>13</td><td>Ranking</td></tr><tr><td>15</td><td>Fixed Sum</td></tr><tr><td>16</td><td>File</td></tr><tbody></table>|
|msdyn_randomiseresponseorder|Edm.Boolean|**Display Name**: Randomize Response Order<br />**Description**: Indicates if the responses should be randomized.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_rankfootertext|Edm.String|**Display Name**: Rank Footer Text<br />**Description**: Text to appear at the bottom of the ranking question<br />|
|msdyn_rankheadertext|Edm.String|**Display Name**: Rank Header Text<br />**Description**: Header text displayed to respondents at the top of the ranking question<br />|
|msdyn_ratinghalfstar|Edm.Boolean|**Display Name**: Rating Half<br />**Description**: Display half a rating option to respondent?<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_ratingimagesize|Edm.Int32|**Display Name**: Image Size<br />**Description**: How big is the rating?<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>24</td></tr><tbody></table>|
|msdyn_ratingimagetype|Edm.Int32|**Display Name**: Rating Image Type<br />**Description**: Rating image type<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>Star</td></tr><tr><td>986540001</td><td>Smilies - sad to happy</td></tr><tr><td>986540002</td><td>Smilies - neutral to happy</td></tr><tr><td>986540003</td><td>Flags</td></tr><tbody></table>|
|msdyn_ratingnumberofitems|Edm.Int32|**Display Name**: Number Of Items<br />**Description**: Number of items to display<br />|
|msdyn_ratingshowcancel|Edm.Boolean|**Display Name**: Show cancel<br />**Description**: Show the cancel button on the ratings<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_ratingtooltips|Edm.String|**Display Name**: Tooltips<br />**Description**: Carriage return separated list of ratings<br />|
|msdyn_regularexpressionvalidation|Edm.String|**Display Name**: Regular Expression Validation<br />**Description**: Regular expression message<br />|
|msdyn_reportingaggregation|Edm.Int32|**Display Name**: Reporting Aggregation<br />**Description**: Select the reporting aggregation.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>Average</td></tr><tr><td>986540001</td><td>Count</td></tr><tr><td>986540002</td><td>Text</td></tr><tr><td>986540003</td><td>None</td></tr><tbody></table>|
|msdyn_reportingmax|Edm.Decimal|**Display Name**: Reporting Maximum<br />**Description**: Shows the maximum value that's possible for this question, which is used for reporting purposes.<br />|
|msdyn_reportingmin|Edm.Decimal|**Display Name**: Reporting Minimum<br />**Description**: Enter the reporting minimum.<br />|
|msdyn_reportingtext|Edm.String|**Display Name**: Reporting Text<br />**Description**: Text, usually abbreviated, used for reporting.  This is overridden by the Linked Question Reporting text if this question is associated with linked question.<br />|
|msdyn_required|Edm.Int32|**Display Name**: Required<br />**Description**: Is the respondent required to complete this field<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>Yes</td></tr><tr><td>986540001</td><td>No</td></tr><tbody></table>|
|msdyn_requiredmessage|Edm.String|**Display Name**: Custom Validation Message<br />**Description**: Message displayed if validation fails<br />|
|msdyn_requireresponseforimport|Edm.Boolean|**Display Name**: Require Response For Import<br />**Description**: Require a response for import.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_responsecount|Edm.Int32|**Display Name**: Response Count<br />**Description**: Shows response count.<br />|
|msdyn_responsemapping|Edm.Int32|**Display Name**: Response Mapping<br />**Description**: Shows response mapping.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540065</td><td>None</td></tr><tr><td>986540064</td><td>NPS Comment</td></tr><tr><td>986540000</td><td>First Name</td></tr><tr><td>986540001</td><td>Last Name</td></tr><tr><td>986540002</td><td>Email</td></tr><tr><td>986540021</td><td>Salutation</td></tr><tr><td>986540003</td><td>Web site</td></tr><tr><td>986540004</td><td>Telephone</td></tr><tr><td>986540005</td><td>Job title</td></tr><tr><td>986540006</td><td>Company Name</td></tr><tr><td>986540007</td><td>Street 1</td></tr><tr><td>986540008</td><td>Street 2</td></tr><tr><td>986540009</td><td>Street 3</td></tr><tr><td>986540010</td><td>City</td></tr><tr><td>986540011</td><td>State</td></tr><tr><td>986540012</td><td>Postal code</td></tr><tr><td>986540013</td><td>Country</td></tr><tr><td>986540067</td><td>Facial Expression</td></tr><tr><td>986540068</td><td>Face Selected</td></tr><tr><td>986540014</td><td>Slot 1</td></tr><tr><td>986540015</td><td>Slot 2</td></tr><tr><td>986540016</td><td>Slot 3</td></tr><tr><td>986540017</td><td>Slot 4</td></tr><tr><td>986540018</td><td>Slot 5</td></tr><tr><td>986540019</td><td>None</td></tr><tr><td>986540020</td><td>Satisfaction Rating 1</td></tr><tr><td>986540022</td><td>Custom Text 1</td></tr><tr><td>986540023</td><td>Custom Text 2</td></tr><tr><td>986540024</td><td>Custom Text 3</td></tr><tr><td>986540025</td><td>Custom Text 4</td></tr><tr><td>986540026</td><td>Custom Text 5</td></tr><tr><td>986540048</td><td>Custom Number 1</td></tr><tr><td>986540028</td><td>Custom Number 2</td></tr><tr><td>986540029</td><td>Custom Number 3</td></tr><tr><td>986540030</td><td>Custom Number 4</td></tr><tr><td>986540031</td><td>Custom Number 5</td></tr><tr><td>986540027</td><td>Custom Number 6</td></tr><tr><td>986540035</td><td>Custom Number 7</td></tr><tr><td>986540036</td><td>Custom Number 8</td></tr><tr><td>986540034</td><td>Custom Number 9</td></tr><tr><td>986540037</td><td>Custom Number 10</td></tr><tr><td>986540038</td><td>Custom Number 11</td></tr><tr><td>986540039</td><td>Custom Number 12</td></tr><tr><td>986540040</td><td>Custom Number 13</td></tr><tr><td>986540041</td><td>Custom Number 14</td></tr><tr><td>986540042</td><td>Custom Number 15</td></tr><tr><td>986540043</td><td>Custom Number 16</td></tr><tr><td>986540044</td><td>Custom Number 17</td></tr><tr><td>986540046</td><td>Custom Number 18</td></tr><tr><td>986540045</td><td>Custom Number 19</td></tr><tr><td>986540047</td><td>Custom Number 20</td></tr><tr><td>986540032</td><td>Custom Date 1</td></tr><tr><td>986540033</td><td>Custom Date 2</td></tr><tr><td>986540049</td><td>Linked Answer 1</td></tr><tr><td>986540050</td><td>Linked Answer 2</td></tr><tr><td>986540051</td><td>Linked Answer 3</td></tr><tr><td>986540052</td><td>Linked Answer 4</td></tr><tr><td>986540053</td><td>Linked Answer 5</td></tr><tr><td>986540054</td><td>Linked Answer 6</td></tr><tr><td>986540055</td><td>Linked Answer 7</td></tr><tr><td>986540056</td><td>Linked Answer 8</td></tr><tr><td>986540057</td><td>Linked Answer 9</td></tr><tr><td>986540058</td><td>Linked Answer 10</td></tr><tr><td>986540059</td><td>Linked Answer 11</td></tr><tr><td>986540060</td><td>Linked Answer 12</td></tr><tr><td>986540061</td><td>Linked Answer 13</td></tr><tr><td>986540062</td><td>Linked Answer 14</td></tr><tr><td>986540063</td><td>Linked Answer 15</td></tr><tr><td>986540066</td><td>Customer Effort Score</td></tr><tbody></table>|
|msdyn_responses|Edm.String|**Display Name**: Responses<br />**Description**: Carriage return separated list of responses.<br />|
|msdyn_scaleleftlabel|Edm.String|**Display Name**: Scale left label<br />**Description**: Text displayed to the left of the scale<br />|
|msdyn_scalemin|Edm.Int32|**Display Name**: Scale Min<br />**Description**: Minimum value for the scale<br />|
|msdyn_scalenoofitems|Edm.Int32|**Display Name**: Scale No Of Items<br />**Description**: Number of items to the scale<br />|
|msdyn_scalerightlabel|Edm.String|**Display Name**: Scale right label<br />**Description**: Text displayed to the right of the scale<br />|
|msdyn_scoredefinition|Edm.Int32|**Display Name**: Score Definition<br />**Description**: Type of scoring / weighting for this question<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540002</td><td>Ignore</td></tr><tr><td>986540000</td><td>Auto (0-100)</td></tr><tr><td>986540001</td><td>Auto (100-0)</td></tr><tr><td>986540004</td><td>User Specified Range / Weight</td></tr><tr><td>986540003</td><td>NPS</td></tr><tbody></table>|
|msdyn_scoremaxvalue|Edm.Int32|**Display Name**: Score Max Value<br />**Description**: Maximum score value<br />|
|msdyn_scoreminvalue|Edm.Int32|**Display Name**: Score Min Value<br />**Description**: Minimum score value<br />|
|msdyn_setdirty|Edm.String|**Display Name**: Check Question State<br />**Description**: Select whether to check if the question is in a consistent state.<br />|
|msdyn_sharinglink|Edm.String|**Display Name**: Sharing Link<br />**Description**: Link that respondents can share via social media<br />|
|msdyn_sharingmessage|Edm.String|**Display Name**: Sharing Message<br />**Description**: Message that respondents are suggested to share via social media<br />|
|msdyn_sharingtext|Edm.String|**Display Name**: Sharing Text<br />**Description**: Message displayed to the respondent<br />|
|msdyn_showashelp|Edm.Boolean|**Display Name**: Show As Help<br />**Description**: Show as help.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_showimagesforsingleresponse|Edm.Boolean|**Display Name**: Show Images For Answers<br />**Description**: Enables images to be shown for single response questions<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_singleresponsetype|Edm.Int32|**Display Name**: Single Response Type<br />**Description**: Single select question type<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540002</td><td>Big buttons</td></tr><tr><td>986540003</td><td>Scale</td></tr><tr><td>986540000</td><td>Radio buttons</td></tr><tr><td>986540001</td><td>Drop down list</td></tr><tbody></table>|
|msdyn_template|Edm.Boolean|**Display Name**: Template<br />**Description**: Select the template to use for the question.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_tooltip|Edm.String|**Display Name**: Tooltip<br />**Description**: Text to display to the respondent when the mouse is hovered over the question.<br />|
|msdyn_trigger|Edm.String|**Display Name**: Trigger<br />**Description**: For internal use only.<br />|
|msdyn_twitter|Edm.Boolean|**Display Name**: Twitter<br />**Description**: Allow respondents to share the response via Twitter<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|msdyn_visibility|Edm.Int32|**Display Name**: Visibility<br />**Description**: Is the question visible by default?<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>986540000</td><td>Visible</td></tr><tr><td>986540001</td><td>Do not display</td></tr><tbody></table>|
|msdyn_yammer|Edm.Boolean|**Display Name**: Yammer<br />**Description**: Allow the respondent to be shared via Yammer?<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Shows the date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Shows the status of the question.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Shows the reason for the status of the question.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
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
|_msdyn_filteredquestionid_value|msdyn_FilteredQuestionId<br />|Shows the filtering question (if any).|
|_msdyn_measuringanswer_value|msdyn_MeasuringAnswer<br />|Used to configure responses you want to compare, for example, "rank-n-rate" for expection vs satisfaction). Usually set at the grid and automatically propagated down.|
|_msdyn_measuringquestion_value|msdyn_MeasuringQuestion<br />|Use to configure responses you want to compare, for example, "rank-n-rate" for expectation vs satisfaction.  Usually set at the grid and automatically propagated down.|
|_msdyn_pageid_value|msdyn_PageId<br />|Shows the related page.|
|_msdyn_questiongroupid_value|msdyn_QuestionGroupId<br />|Shows the unique reference ID relating to the question group.|
|_msdyn_questiontypelookup_value|msdyn_QuestionTypeLookup<br />|Shows the question type associated with the question.|
|_msdyn_surveyid_value|msdyn_SurveyId<br />|Shows the survey associated with the question.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Shows the business unit that owns the record.|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_msdyn_question_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_question_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_msdyn_question_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_msdyn_question_modifiedonbehalfby|
|msdyn_FilteredQuestionId|[msdyn_question EntityType](msdyn_question.md)|msdyn_question_filtered_question|
|msdyn_MeasuringAnswer|[msdyn_answer EntityType](msdyn_answer.md)|msdyn_msdyn_answer_msdyn_question_MeasuringAnswer|
|msdyn_MeasuringQuestion|[msdyn_question EntityType](msdyn_question.md)|msdyn_msdyn_question_msdyn_question_MeasuringQuestion|
|msdyn_PageId|[msdyn_page EntityType](msdyn_page.md)|msdyn_page_question|
|msdyn_QuestionGroupId|[msdyn_questiongroup EntityType](msdyn_questiongroup.md)|msdyn_questiongroup_question|
|msdyn_QuestionTypeLookup|[msdyn_questiontype EntityType](msdyn_questiontype.md)|msdyn_question_questiontype|
|msdyn_SurveyId|[msdyn_survey EntityType](msdyn_survey.md)|msdyn_survey_msdyn_question_SurveyId|
|ownerid|[principal EntityType](principal.md)|owner_msdyn_question|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_msdyn_question|
|owningteam|[team EntityType](team.md)|team_msdyn_question|
|owninguser|[systemuser EntityType](systemuser.md)|user_msdyn_question|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|msdyn_msdyn_question_msdyn_feedbackmapping_QuestionId|[msdyn_feedbackmapping EntityType](msdyn_feedbackmapping.md)|msdyn_QuestionId|  
|msdyn_msdyn_question_msdyn_question_MeasuringQuestion|[msdyn_question EntityType](msdyn_question.md)|msdyn_MeasuringQuestion|  
|msdyn_msdyn_question_msdyn_questiongroup_ImportQuestion|[msdyn_questiongroup EntityType](msdyn_questiongroup.md)|msdyn_ImportQuestion|  
|msdyn_msdyn_question_msdyn_responseaction_Question|[msdyn_responseaction EntityType](msdyn_responseaction.md)|msdyn_Question|  
|msdyn_msdyn_question_msdyn_survey_KeyMeasureQuestion|[msdyn_survey EntityType](msdyn_survey.md)|msdyn_KeyMeasureQuestion|  
|msdyn_question_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_msdyn_question|  
|msdyn_question_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_msdyn_question_adx_alertsubscription|  
|msdyn_question_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_msdyn_question_adx_inviteredemption|  
|msdyn_question_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_msdyn_question_adx_portalcomment|  
|msdyn_question_answer|[msdyn_answer EntityType](msdyn_answer.md)|msdyn_QuestionId|  
|msdyn_question_answer_n_n|[msdyn_answer EntityType](msdyn_answer.md)|msdyn_question_answer_n_n|  
|msdyn_question_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_msdyn_question_appointment|  
|msdyn_question_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_msdyn_question|  
|msdyn_question_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_msdyn_question|  
|msdyn_question_Emails|[email EntityType](email.md)|regardingobjectid_msdyn_question_email|  
|msdyn_question_Faxes|[fax EntityType](fax.md)|regardingobjectid_msdyn_question_fax|  
|msdyn_question_filtered_question|[msdyn_question EntityType](msdyn_question.md)|msdyn_FilteredQuestionId|  
|msdyn_question_Letters|[letter EntityType](letter.md)|regardingobjectid_msdyn_question_letter|  
|msdyn_question_logic_ComparisonQuestion|[msdyn_responsecondition EntityType](msdyn_responsecondition.md)|msdyn_ComparisonQuestion|  
|msdyn_question_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_msdyn_question_msdyn_approval|  
|msdyn_question_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_msdyn_question_msdyn_bookingalert|  
|msdyn_question_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_msdyn_question_msdyn_surveyinvite|  
|msdyn_question_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_msdyn_question_phonecall|  
|msdyn_question_questionresponse|[msdyn_questionresponse EntityType](msdyn_questionresponse.md)|msdyn_QuestionId|  
|msdyn_question_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_msdyn_question_recurringappointmentmaster|  
|msdyn_question_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_msdyn_question_serviceappointment|  
|msdyn_question_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_msdyn_question_socialactivity|  
|msdyn_question_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_msdyn_question|  
|msdyn_question_Tasks|[task EntityType](task.md)|regardingobjectid_msdyn_question_task|  

## Operations
The following operations can be used with the msdyn_question entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[IsValidStateTransition Function](../functions/isvalidstatetransition.md)|Not Bound|[!INCLUDE[../functions/descriptions/isvalidstatetransition.md](../functions/descriptions/isvalidstatetransition.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the msdyn_question entity type.


|Name|Description |  
|----|------------|  
|[Voice of the Customer for Microsoft Dynamics 365 Solution](../solutions/voiceofthecustomer.md)|[!INCLUDE[../solutions/descriptions/voiceofthecustomer.md](../solutions/descriptions/voiceofthecustomer.md)]|    

[!INCLUDE[./remarks/msdyn_question.md](./remarks/msdyn_question.md)]

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