---
title: "Microsoft Dynamics 365 Customer Engagement mailbox EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 55719fd5-c785-46af-8a59-ab9730f1ef2c
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API mailbox entitytype."
---
# mailbox EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/mailbox.md](./descriptions/mailbox.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]mailboxes </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Mailbox</td></tr>
<tr><td><b>Primary Key:</b></td><td>mailboxid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The mailbox entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|actdeliverymethod|Edm.Int32|**Display Name**: Appointments, Contacts, and Tasks<br />**Description**: Choose the delivery method for the mailbox for appointments, contacts, and tasks.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Microsoft Dynamics 365 for Outlook</td></tr><tr><td>1</td><td>Server-Side Synchronization</td></tr><tr><td>2</td><td>None</td></tr><tbody></table>|
|actstatus|Edm.Int32|**Display Name**: Appointments, Contacts, and Tasks Status<br />**Description**: Status of the Appointments, Contacts, and Tasks.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Not Run</td></tr><tr><td>1</td><td>Success</td></tr><tr><td>2</td><td>Failure</td></tr><tbody></table>|
|allowemailconnectortousecredentials|Edm.Boolean|**Display Name**: Allow to Use Credentials for Email Processing<br />**Description**: Choose whether to allow the email connector to use credentials.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|averagetotalduration|Edm.Int32|**Display Name**: Monitor Total Performance<br />**Description**: Mailbox Total Duration in Average<br />Read-only<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|emailaddress|Edm.String|**Display Name**: Email Address<br />**Description**: Type the email address of the mailbox.<br />|
|emailrouteraccessapproval|Edm.Int32|**Display Name**: Email Address Status<br />**Description**: Shows the status of the email address.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Empty</td></tr><tr><td>1</td><td>Approved</td></tr><tr><td>2</td><td>Pending Approval</td></tr><tr><td>3</td><td>Rejected</td></tr><tbody></table>|
|enabledforact|Edm.Boolean|**Display Name**: Enabled For Appointments, Contacts, And Tasks<br />**Description**: Indicates whether the mailbox is enabled for Appointments, Contacts, and Tasks.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|enabledforincomingemail|Edm.Boolean|**Display Name**: Enabled For Incoming Email<br />**Description**: Choose whether the mailbox is enabled for receiving email.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|enabledforoutgoingemail|Edm.Boolean|**Display Name**: Enabled For Outgoing Email<br />**Description**: Choose whether the mailbox is enabled for sending email.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|entityimage|Edm.Binary|**Display Name**: Entity Image<br />**Description**: The default image for the entity.<br />|
|entityimage_timestamp|Edm.Int64|Read-only<br />|
|entityimage_url|Edm.String|Read-only<br />|
|entityimageid|Edm.Guid|**Display Name**: Entity Image Id<br />**Description**: For internal use only.<br />Read-only<br />|
|ewsurl|Edm.String|**Display Name**: Exchange Web Services URL<br />**Description**: Exchange web services endpoint URL for the mailbox.<br />|
|exchangecontactsimportcompletedon|Edm.DateTimeOffset|**Display Name**: Exchange Contacts Import Completed On<br />**Description**: Date and time when the exchange contacts import was last completed for a mailbox record.<br />Read-only<br />|
|exchangecontactsimportstatus|Edm.Int32|**Display Name**: Exchange Contacts Import Status<br />**Description**: Indicates the exchange contacts import status for a mailbox record.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>NotImported</td></tr><tr><td>1</td><td>Imported</td></tr><tr><td>2</td><td>ImportFailed</td></tr><tbody></table>|
|exchangesyncstatexml|Edm.String|**Display Name**: Exchange Sync State<br />**Description**: Contains the exchange synchronization state in XML format.<br />|
|folderhierarchy|Edm.String|**Display Name**: Folder Hierarchy<br />**Description**: Holds the hierarchy of folders under inbox in XML format.<br />|
|forcedunlockcount|Edm.Int32|**Display Name**: Count of the number of times a mailbox gets forced unlocked<br />**Description**: For internal use only<br />Read-only<br />|
|hostid|Edm.String|**Display Name**: Host<br />**Description**: Unique identifier of the async host that is processing this mailbox.<br />Read-only<br />|
|incomingemaildeliverymethod|Edm.Int32|**Display Name**: Incoming Email<br />**Description**: Select how incoming email will be delivered to the mailbox.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>None</td></tr><tr><td>1</td><td>Microsoft Dynamics 365 for Outlook</td></tr><tr><td>2</td><td>Server-Side Synchronization or Email Router</td></tr><tr><td>3</td><td>Forward Mailbox</td></tr><tbody></table>|
|incomingemailstatus|Edm.Int32|**Display Name**: Incoming Email Status<br />**Description**: Select the status that will be assigned to incoming email messages.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Not Run</td></tr><tr><td>1</td><td>Success</td></tr><tr><td>2</td><td>Failure</td></tr><tbody></table>|
|isactsyncorgflagset|Edm.Boolean|**Display Name**: Set Current Organization as Synchronization Organization<br />**Description**: Set the current organization as the synchronization organization.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isemailaddressapprovedbyo365admin|Edm.Boolean|**Display Name**: Email Address O365 Admin Approval Status<br />**Description**: Shows the status of approval of the email address by O365 Admin.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isexchangecontactsimportscheduled|Edm.Boolean|**Display Name**: Is Exchange Contacts Import Scheduled.<br />**Description**: Is Exchange Contacts Import Scheduled.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isforwardmailbox|Edm.Boolean|**Display Name**: Is Forward Mailbox<br />**Description**: Select whether the mailbox is a forward mailbox.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|ispasswordset|Edm.Boolean|Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isserviceaccount|Edm.Boolean|**Display Name**: Is Service Account<br />**Description**: Select whether the mailbox corresponds to one for the service account.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|itemsfailedforlastsync|Edm.Int32|**Display Name**: Items Failed For Last Sync<br />**Description**: For internal use only.<br />|
|itemsprocessedforlastsync|Edm.Int32|**Display Name**: Items Processed For Last Sync<br />**Description**: For internal use only.<br />|
|lastautodiscoveredon|Edm.DateTimeOffset|**Display Name**: Last Auto Discovered On<br />**Description**: Shows the date and time when the Exchange web services URL was last discovered using the AutoDiscover service.<br />|
|lastduration|Edm.Int32|**Display Name**: Monitor last duration Performance<br />**Description**: Last Duration for the mailbox<br />Read-only<br />|
|lastmailboxforcedunlockoccurredon|Edm.DateTimeOffset|**Display Name**: Last Date Time when a mailbox got forced unlocked<br />**Description**: For internal use only.<br />Read-only<br />|
|lastsuccessfulsynccompletedon|Edm.DateTimeOffset|**Display Name**: Last Successful Sync Time<br />**Description**: Last Successful Sync Time<br />Read-only<br />|
|lastsyncerror|Edm.String|**Display Name**: Last Sync Error Stack<br />**Description**: For internal use only.<br />|
|lastsyncerrorcode|Edm.Int32|**Display Name**: Last Sync Error Code<br />**Description**: For internal use only.<br />|
|lastsyncerrorcount|Edm.Int32|**Display Name**: Last Sync Error Continuous Count<br />**Description**: For internal use only<br />|
|lastsyncerrormachinename|Edm.String|**Display Name**: Last Sync Error Machine Name<br />**Description**: For internal use only.<br />|
|lastsyncerroroccurredon|Edm.DateTimeOffset|**Display Name**: Last Sync Error Time<br />**Description**: For internal use only.<br />|
|lastsyncstartedon|Edm.DateTimeOffset|**Display Name**: Last Sync Start Time<br />**Description**: Last Sync Start Time<br />Read-only<br />|
|mailboxid|Edm.Guid|**Display Name**: Mailbox<br />**Description**: Unique identifier of the mailbox.<br />|
|mailboxprocessingcontext|Edm.Int32|**Display Name**: Processing Context of the Mailbox<br />**Description**: For internal use only.<br />|
|mailboxstatus|Edm.Int32|**Display Name**: Mailbox Status<br />**Description**: Last Sync Status for Outgoing, Incoming and ACT as a whole.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Not Run</td></tr><tr><td>1</td><td>Success</td></tr><tr><td>2</td><td>Failure</td></tr><tbody></table>|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Type the name of the mailbox.<br />|
|noactcount|Edm.Int32|**Display Name**: Zero appointment, contact, task count for mailbox<br />**Description**: For internal use only.<br />Read-only<br />|
|noemailcount|Edm.Int32|**Display Name**: Zero email count for mailbox<br />**Description**: For internal use only.<br />Read-only<br />|
|officeappsdeploymentcompleteon|Edm.DateTimeOffset|**Display Name**: Office Apps Deployment Completed On<br />**Description**: Date and time when the last office apps deployment was completed for a mailbox record.<br />Read-only<br />|
|officeappsdeploymenterror|Edm.String|**Display Name**: Office Apps Deployment Error<br />**Description**: The Office Apps deployment error.<br />Read-only<br />|
|officeappsdeploymentscheduled|Edm.Boolean|**Display Name**: Office Apps Deployment Scheduled<br />**Description**: Indicates if the office apps deployment has been scheduled for a mailbox record.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|officeappsdeploymentstatus|Edm.Int32|**Display Name**: Office Apps Deployment Type<br />**Description**: Indicates the office apps deployment type for a mailbox record.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>NotInstalled</td></tr><tr><td>1</td><td>Installed</td></tr><tr><td>2</td><td>InstallFailed</td></tr><tr><td>3</td><td>UninstallFailed</td></tr><tr><td>4</td><td>UpgradeRequired</td></tr><tbody></table>|
|orgmarkedasprimaryforexchangesync|Edm.Boolean|**Display Name**: Crm Org Marked as Primary Org for Exchange Mailbox<br />**Description**: Indicates if the crm org is to be marked as primary syncing org for the mailbox record.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|outgoingemaildeliverymethod|Edm.Int32|**Display Name**: Outgoing Email<br />**Description**: Select how outgoing email will be sent from the mailbox.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>None</td></tr><tr><td>1</td><td>Microsoft Dynamics 365 for Outlook</td></tr><tr><td>2</td><td>Server-Side Synchronization or Email Router</td></tr><tbody></table>|
|outgoingemailstatus|Edm.Int32|**Display Name**: Outgoing Email Status<br />**Description**: Select the status of outgoing email messages.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Not Run</td></tr><tr><td>1</td><td>Success</td></tr><tr><td>2</td><td>Failure</td></tr><tbody></table>|
|password|Edm.String|**Display Name**: Password<br />**Description**: Type the password for the mailbox.<br />|
|postponemailboxprocessinguntil|Edm.DateTimeOffset|**Display Name**: Postpone Mailbox Processing Until<br />**Description**: Shows the date and time when processing will begin on this mailbox.<br />|
|postponeofficeappsdeploymentuntil|Edm.DateTimeOffset|**Display Name**: Postpone Outlook Mail App Install Until<br />**Description**: Shows the date and time when the next outlook mail app install will be run for a mailbox record.<br />|
|postponesendinguntil|Edm.DateTimeOffset|**Display Name**: Postpone Sending Until<br />**Description**: Shows the date and time when the mailbox can start sending emails.<br />|
|postponetestemailconfigurationuntil|Edm.DateTimeOffset|**Display Name**: Postpone Test Email Configuration Until<br />**Description**: Shows the date and time when the next email configuration test will be run for a mailbox record.<br />|
|processanddeleteemails|Edm.Boolean|**Display Name**: Delete Emails after Processing<br />**Description**: Select whether to delete emails from the mailbox after processing.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|processedtimes|Edm.Int32|**Display Name**: Monitor Performance<br />**Description**: The number of times mailbox has processed<br />Read-only<br />|
|processemailreceivedafter|Edm.DateTimeOffset|**Display Name**: Process Email Received After<br />**Description**: Shows the date and time to start processing email received by the mailbox.<br />|
|processinglastattemptedon|Edm.DateTimeOffset|**Display Name**: Date Processing Last Attempted<br />**Description**: Date and time when the processing of the mailbox was last attempted.<br />Read-only<br />|
|processingstatecode|Edm.Int32|**Display Name**: Mailbox Processing State<br />**Description**: Information that indicates whether email will be processed for this mailbox<br />Read-only<br />|
|receivingpostponeduntil|Edm.DateTimeOffset|**Display Name**: Postpone receiving emails for the mailbox until the specified data and time.<br />**Description**: For internal use only.<br />Read-only<br />|
|receivingpostponeduntilforact|Edm.DateTimeOffset|**Display Name**: Postpone processing Appointments, Contacts, and Tasks for the mailbox until the specified data and time.<br />**Description**: For internal use only.<br />Read-only<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Shows whether the mailbox is active or inactive.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Select the mailbox's status.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|testemailconfigurationretrycount|Edm.Int32|**Display Name**: Test Email Configuration Retry Count<br />**Description**: Shows the number of times an email configuration test has been performed.<br />|
|testemailconfigurationscheduled|Edm.Boolean|**Display Name**: Test Email Configuration Scheduled<br />**Description**: Indicates if the email configuration test has been scheduled for a mailbox record.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|testmailboxaccesscompletedon|Edm.DateTimeOffset|**Display Name**: Mailbox Test Completed On<br />**Description**: Date and time when the last email configuration test was completed for a mailbox record.<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|transientfailurecount|Edm.Int32|**Display Name**: Transient Failure Count<br />**Description**: Concatenation of transient failure counts of all mailbox operations.<br />Read-only<br />|
|undeliverablefolder|Edm.String|**Display Name**: Undeliverable Folder<br />**Description**: Shows the ID of the Undeliverable folder in the mailbox managed by Microsoft Exchange.<br />|
|username|Edm.String|**Display Name**: User Name<br />**Description**: Type a user name used for mailbox authentication.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|verboseloggingenabled|Edm.Int32|**Display Name**: Verbose Logging<br />**Description**: Indicates if verbose tracing needs to be enabled for this mailbox.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version number of the mailbox.<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Shows who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_emailserverprofile_value|emailserverprofile<br />|Select the email server profile of the mailbox.|
|_modifiedby_value|modifiedby<br />|Shows who last updated the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who last updated the record on behalf of another user.|
|_organizationid_value|organizationid<br />|Unique identifier of the organization associated with the record.|
|_ownerid_value|ownerid<br />|Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.|
|_owningbusinessunit_value|owningbusinessunit<br />|Select the business unit that owns the record.|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_regardingobjectid_value|regardingobjectid<br />regardingobjectid_queue<br />|Choose the user associated to the mailbox.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_mailbox_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_mailbox_createdonbehalfby|
|emailserverprofile|[emailserverprofile EntityType](emailserverprofile.md)|emailserverprofile_mailbox|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_mailbox_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_mailbox_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_mailbox|
|ownerid|[principal EntityType](principal.md)|owner_mailbox|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_mailbox|
|owningteam|[team EntityType](team.md)|team_mailbox|
|owninguser|[systemuser EntityType](systemuser.md)|user_mailbox|
|regardingobjectid|[systemuser EntityType](systemuser.md)|mailbox_regarding_systemuser|
|regardingobjectid_queue|[queue EntityType](queue.md)|mailbox_regarding_queue|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|activitypointer_sendermailboxid_mailbox|[activitypointer EntityType](activitypointer.md)|sendermailboxid|  
|adx_alertsubscription_mailbox_sendermailboxid|[adx_alertsubscription EntityType](adx_alertsubscription.md)|sendermailboxid_adx_alertsubscription|  
|adx_inviteredemption_mailbox_sendermailboxid|[adx_inviteredemption EntityType](adx_inviteredemption.md)|sendermailboxid_adx_inviteredemption|  
|adx_portalcomment_mailbox_sendermailboxid|[adx_portalcomment EntityType](adx_portalcomment.md)|sendermailboxid_adx_portalcomment|  
|bulkoperation_mailbox_sendermailboxid|[bulkoperation EntityType](bulkoperation.md)|sendermailboxid_bulkoperation|  
|campaignactivity_mailbox_sendermailboxid|[campaignactivity EntityType](campaignactivity.md)|sendermailboxid_campaignactivity|  
|campaignresponse_mailbox_sendermailboxid|[campaignresponse EntityType](campaignresponse.md)|sendermailboxid_campaignresponse|  
|email_sendermailboxid_mailbox|[email EntityType](email.md)|sendermailboxid_email|  
|incidentresolution_mailbox_sendermailboxid|[incidentresolution EntityType](incidentresolution.md)|sendermailboxid_incidentresolution|  
|Mailbox_Annotation|[annotation EntityType](annotation.md)|objectid_mailbox|  
|mailbox_asyncoperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_mailbox|  
|Mailbox_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_mailbox_syncerror|  
|msdyn_approval_mailbox_sendermailboxid|[msdyn_approval EntityType](msdyn_approval.md)|sendermailboxid_msdyn_approval|  
|msdyn_bookingalert_mailbox_sendermailboxid|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|sendermailboxid_msdyn_bookingalert|  
|msdyn_surveyinvite_mailbox_sendermailboxid|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|sendermailboxid_msdyn_surveyinvite|  
|opportunityclose_mailbox_sendermailboxid|[opportunityclose EntityType](opportunityclose.md)|sendermailboxid_opportunityclose|  
|orderclose_mailbox_sendermailboxid|[orderclose EntityType](orderclose.md)|sendermailboxid_orderclose|  
|queue_defaultmailbox_mailbox|[queue EntityType](queue.md)|defaultmailbox|  
|quoteclose_mailbox_sendermailboxid|[quoteclose EntityType](quoteclose.md)|sendermailboxid_quoteclose|  
|serviceappointment_mailbox_sendermailboxid|[serviceappointment EntityType](serviceappointment.md)|sendermailboxid_serviceappointment|  
|systemuser_defaultmailbox_mailbox|[systemuser EntityType](systemuser.md)|defaultmailbox|  
|tracelog_Mailbox|[tracelog EntityType](tracelog.md)|regardingobjectid_mailbox|  

## Operations
The following operations can be used with the mailbox entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the mailbox entity type.


|Name|Description |  
|----|------------|  
|[AppCommon Solution](../solutions/appcommon.md)|[!INCLUDE[../solutions/descriptions/appcommon.md](../solutions/descriptions/appcommon.md)]|    

[!INCLUDE[./remarks/mailbox.md](./remarks/mailbox.md)]

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