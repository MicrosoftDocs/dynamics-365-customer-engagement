---
title: "Microsoft Dynamics 365 Customer Engagement emailserverprofile EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: bc588c67-2962-4d40-9f04-ef3beb2e6b41
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API emailserverprofile entitytype."
---
# emailserverprofile EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/emailserverprofile.md](./descriptions/emailserverprofile.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]emailserverprofiles </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Email Server Profile</td></tr>
<tr><td><b>Primary Key:</b></td><td>emailserverprofileid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The emailserverprofile EntityType:
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|defaultserverlocation|Edm.String|**Display Name**: Default Email Server Location<br />**Description**: Type the default location of the server.<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: Type additional information that describes the email server profile.<br />|
|emailserverprofileid|Edm.Guid|**Display Name**: EmailServerProfile<br />**Description**: Unique identifier of the email server profile.<br />|
|emailservertypename|Edm.String|**Display Name**: Email Server Type Name<br />**Description**: Email Server Type Name<br />Read-only<br />|
|encodingcodepage|Edm.String|**Display Name**: Encoding Code Page<br />**Description**: Indicates the code page to use when encoding email content.<br />|
|entityimage|Edm.Binary|**Display Name**: Entity Image<br />**Description**: The default image for the entity.<br />|
|entityimage_timestamp|Edm.Int64|Read-only<br />|
|entityimage_url|Edm.String|Read-only<br />|
|entityimageid|Edm.Guid|**Display Name**: Entity Image Id<br />**Description**: For internal use only.<br />Read-only<br />|
|exchangeonlinetenantid|Edm.String|**Display Name**: Exchange Online Tenant Id<br />**Description**: Type the tenant ID of Exchange Online.<br />|
|exchangeversion|Edm.Int32|**Display Name**: Exchange Version<br />**Description**: Select the version of Exchange that is on the email server.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Exchange 2007</td></tr><tr><td>1</td><td>Exchange 2007 SP1</td></tr><tr><td>2</td><td>Exchange 2010</td></tr><tr><td>3</td><td>Exchange 2010 SP1</td></tr><tr><td>4</td><td>Exchange 2010 SP2</td></tr><tr><td>5</td><td>Exchange 2013</td></tr><tbody></table>|
|incomingauthenticationprotocol|Edm.Int32|**Display Name**: Incoming Authentication Protocol<br />**Description**: Select the incoming email authentication protocol that is used for connecting to the email server.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Auto Detect</td></tr><tr><td>1</td><td>Negotiate</td></tr><tr><td>2</td><td>NTLM</td></tr><tr><td>3</td><td>Basic</td></tr><tbody></table>|
|incomingcredentialretrieval|Edm.Int32|**Display Name**: Incoming Email Credential Retrieval<br />**Description**: Select how credentials will be retrieved for incoming email.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Credentials Specified by a User or Queue</td></tr><tr><td>1</td><td>Credentials Specified in Email Server Profile</td></tr><tr><td>2</td><td>Server to Server Authentication</td></tr><tr><td>3</td><td>Windows Integrated Authentication</td></tr><tr><td>4</td><td>Without Credentials (Anonymous)</td></tr><tbody></table>|
|incomingpassword|Edm.String|**Display Name**: Incoming Email Password<br />**Description**: Type the password for incoming email.<br />|
|incomingportnumber|Edm.Int32|**Display Name**: Incoming Email Port<br />**Description**: Type the Exchange port number for incoming mail.<br />|
|incomingserverlocation|Edm.String|**Display Name**: Incoming Email Server Location<br />**Description**: Type the location of the server for incoming email.<br />|
|incominguseimpersonation|Edm.Boolean|**Display Name**: Use Impersonation for Incoming Email<br />**Description**: Select whether to use impersonation to access the mailbox to process incoming emails.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|incomingusername|Edm.String|**Display Name**: Incoming Email User Name<br />**Description**: Type the user name for incoming email.<br />|
|incomingusessl|Edm.Boolean|**Display Name**: Use SSL for Incoming Email<br />**Description**: Select whether to use the Secure Sockets Layer (SSL) protocol for incoming email.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isincomingpasswordset|Edm.Boolean|Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|isoutgoingpasswordset|Edm.Boolean|Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|lastauthorizationstatus|Edm.Int32|**Display Name**: Last Test Authorization Status<br />**Description**: Shows the last test authorization status of email server profile<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Failure</td></tr><tr><td>1</td><td>Success</td></tr><tbody></table>|
|lastcrmmessage|Edm.String|**Display Name**: Last Dynamics 365 Message<br />**Description**: Shows the Dynamics 365 message obtained during the Last Test<br />|
|lasttestexecutionstatus|Edm.Int32|**Display Name**: Last Test Execution Status<br />**Description**: Shows the last test Execution status of email server profile<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Failure</td></tr><tr><td>1</td><td>Success</td></tr><tr><td>2</td><td>Warning</td></tr><tbody></table>|
|lasttestrequest|Edm.String|**Display Name**: Last Test Request<br />**Description**: Shows the EWS Request created during the Last Test<br />|
|lasttestresponse|Edm.String|**Display Name**: Last Test Response<br />**Description**: Shows the EWS Response obtained during the Last Test<br />|
|lastteststarttime|Edm.DateTimeOffset|**Display Name**: Last Test Time<br />**Description**: Shows the Last Test Start date and time<br />|
|lasttesttotalexecutiontime|Edm.Int64|**Display Name**: Last Test Time Taken<br />**Description**: Shows the Time taken while running the last test<br />|
|lasttestvalidationstatus|Edm.Int32|**Display Name**: Last Test Validation Status<br />**Description**: Shows the last test Validation status of email server profile<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Failure</td></tr><tr><td>1</td><td>Success</td></tr><tbody></table>|
|maxconcurrentconnections|Edm.Int32|**Display Name**: Maximum Concurrent Connections<br />**Description**: Maximum number of concurrent connections allowed to the email server per authenticated user.<br />|
|minpollingintervalinminutes|Edm.Int32|**Display Name**: Minimum Polling Interval In Minutes<br />**Description**: Minimum polling interval, in minutes, for mailboxes that are associated with this email server profile.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.<br />Read-only<br />|
|moveundeliveredemails|Edm.Boolean|**Display Name**: Move Undelivered Emails to the Undeliverable Folder<br />**Description**: Indicates whether to move undelivered incoming emails to the Undeliverable folder in Microsoft Exchange.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|name|Edm.String|**Display Name**: Name<br />**Description**: Type a meaningful name for the email server profile. This name is displayed when you need to select an email server profile.<br />|
|outgoingauthenticationprotocol|Edm.Int32|**Display Name**: Outgoing Authentication Protocol<br />**Description**: Select the outgoing email authentication protocol that is used for connecting to the email server.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Auto Detect</td></tr><tr><td>1</td><td>Negotiate</td></tr><tr><td>2</td><td>NTLM</td></tr><tr><td>3</td><td>Basic</td></tr><tbody></table>|
|outgoingautograntdelegateaccess|Edm.Boolean|**Display Name**: Auto Grant Delegate Access for Outgoing Email.<br />**Description**: Indicates whether the email connector will grant delegate access permissions to the accessing user when required while processing outgoing emails.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|outgoingcredentialretrieval|Edm.Int32|**Display Name**: Outgoing Email Credential Retrieval<br />**Description**: Select how credentials will be retrieved for outgoing email.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Credentials Specified by a User or Queue</td></tr><tr><td>1</td><td>Credentials Specified in Email Server Profile</td></tr><tr><td>2</td><td>Server to Server Authentication</td></tr><tr><td>3</td><td>Windows Integrated Authentication</td></tr><tr><td>4</td><td>Without Credentials (Anonymous)</td></tr><tbody></table>|
|outgoingpassword|Edm.String|**Display Name**: Outgoing Email Password<br />**Description**: Type the password for outgoing email.<br />|
|outgoingportnumber|Edm.Int32|**Display Name**: Outgoing Email Port<br />**Description**: Type the Exchange port number for outgoing mail.<br />|
|outgoingserverlocation|Edm.String|**Display Name**: Outgoing Email Server Location<br />**Description**: Type the location of the server for outgoing email.<br />|
|outgoinguseimpersonation|Edm.Boolean|**Display Name**: Use Impersonation for Outgoing Email<br />**Description**: Select whether to use impersonation for accessing the mailbox to process outgoing emails.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|outgoingusername|Edm.String|**Display Name**: Outgoing Email User Name<br />**Description**: Type the user name for outgoing email.<br />|
|outgoingusessl|Edm.Boolean|**Display Name**: Use SSL for Outgoing Email<br />**Description**: Select whether to use the Secure Sockets Layer (SSL) protocol for outgoing email.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|owneremailaddress|Edm.String|**Display Name**: Email Server Profile Owner's email address<br />**Description**: Email Server Profile Owner's email address<br />|
|processemailsreceivedafter|Edm.DateTimeOffset|**Display Name**: Process Emails Received After<br />**Description**: Shows the date and time after which email messages that are received will be processed for mailboxes associated with the email server profile.<br />|
|sendemailalert|Edm.Boolean|**Display Name**: Send an alert email to the owner of the email server profile reporting on major events<br />**Description**: Select whether to send an email alert if more than 50% of the mailboxes in this email server profile failed to synchronize in an hour period.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|servertype|Edm.Int32|**Display Name**: Email Server Type<br />**Description**: Select the profile's email server type.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Exchange Server</td></tr><tr><td>1</td><td>Other (POP3/SMTP)</td></tr><tr><td>2</td><td>Exchange Server (Hybrid)</td></tr><tr><td>3</td><td>Exchange Online (Hybrid)</td></tr><tbody></table>|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Shows whether the email server profile is active or inactive.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Select the email server profile's status.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timeoutmailboxconnection|Edm.Boolean|**Display Name**: Timeout Mailbox Connection to Exchange<br />**Description**: Select whether to timeout a single mailbox.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|timeoutmailboxconnectionafteramount|Edm.Int32|**Display Name**: Timeout a Single Mailbox Connection After this Amount of Milliseconds<br />**Description**: Type the number of milliseconds to timeout a single mailbox. The upper limit is 100 seconds.<br />|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|useautodiscover|Edm.Boolean|**Display Name**: Auto Discover Server Location<br />**Description**: Select whether to automatically discover the server location<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|usedefaulttenantid|Edm.Boolean|**Display Name**: Use Default Tenant Id<br />**Description**: Select whether to use the Exchange Online Tenant ID obtained from running Microsoft Azure PowerShell cmdlets (highly recommended). If you select No, you can edit this field manually<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|usesamesettingsforoutgoingconnections|Edm.Boolean|**Display Name**: Use Same Settings for Outgoing Connection<br />**Description**: Select whether to use the same settings for incoming and outgoing connections.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version number of the email server profile.<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|Shows who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Shows who created the record on behalf of another user.|
|_incomingpartnerapplication_value||Indicates the incoming partner application.|
|_modifiedby_value|modifiedby<br />|Shows who last updated the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Shows who last updated the record on behalf of another user.|
|_organizationid_value|organizationid<br />|Unique identifier of the organization associated with the record.|
|_outgoingpartnerapplication_value||Indicates the outgoing partner application.|
|_ownerid_value|ownerid<br />|Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.|
|_owningbusinessunit_value|owningbusinessunit<br />|Select the business unit that owns the record.|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value||Unique identifier for the user that owns the record.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_emailserverprofile_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_emailserverprofile_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_emailserverprofile_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_emailserverprofile_modifiedonbehalfby|
|organizationid|[organization EntityType](organization.md)|organization_emailserverprofile|
|ownerid|[principal EntityType](principal.md)|owner_emailserverprofile|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_emailserverprofile|
|owningteam|[team EntityType](team.md)|team_emailserverprofile|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|EmailServerProfile_Annotation|[annotation EntityType](annotation.md)|objectid_emailserverprofile|  
|emailserverprofile_asyncoperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_emailserverprofile|  
|emailserverprofile_bulkdeletefailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_emailserverprofile|  
|emailserverprofile_duplicatebaserecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_emailserverprofile|  
|emailserverprofile_duplicatematchingrecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_emailserverprofile|  
|emailserverprofile_mailbox|[mailbox EntityType](mailbox.md)|emailserverprofile|  
|EmailServerProfile_Organization|[organization EntityType](organization.md)|defaultemailserverprofileid|  
|EmailServerProfile_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_emailserverprofile_syncerror|  
|tracelog_EmailServerProfile|[tracelog EntityType](tracelog.md)|regardingobjectid_emailserverprofile|  

## Operations
The following operations can be used with the emailserverprofile entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|    

[!INCLUDE[./remarks/emailserverprofile.md](./remarks/emailserverprofile.md)]

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