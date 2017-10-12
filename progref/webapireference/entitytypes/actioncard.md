---
title: "Microsoft Dynamics 365 Customer Engagement actioncard EntityType Reference | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 83b4cfe3-5b08-456a-80a8-20ccea1833be
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API actioncard entitytype."
---
# actioncard EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/actioncard.md](./descriptions/actioncard.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]actioncards </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Action Card</td></tr>
<tr><td><b>Primary Key:</b></td><td>actioncardid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>title</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The actioncard entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|actioncardid|Edm.Guid|**Display Name**: Action Card<br />**Description**: Unique identifier of the action card.<br />|
|cardtype|Edm.Int32|**Display Name**: CardType ENUM<br />**Description**: The CardType ENUM value.<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when action card was created.<br />Read-only<br />|
|data|Edm.String|**Display Name**: Data Associated with Card Commandbar Actions<br />**Description**: For internal use only.<br />|
|description|Edm.String|**Display Name**: Card Description<br />**Description**: For internal use only.<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Exchange rate for the currency associated with the action card with respect to the base currency.<br />Read-only<br />|
|expirydate|Edm.DateTimeOffset|**Display Name**: Expiry Date<br />**Description**: Shows the Expiry Date<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when action card was last modified.<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|priority|Edm.Int32|**Display Name**: Priority<br />**Description**: Priority of the ActionCard<br />|
|recordidobjecttypecode2|Edm.Int32|**Display Name**: RecordIdObjectTypeCode2<br />**Description**: RecordIdObjectTypeCode2 of the ActionCard<br />|
|referencetokens|Edm.String|**Display Name**: Data Associated constructing title and body<br />**Description**: For internal use only.<br />|
|source|Edm.Int32|**Display Name**: Action Card Source<br />**Description**: Source for the Action Card<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>CRM</td></tr><tr><td>2</td><td>Exchange</td></tr><tbody></table>|
|startdate|Edm.DateTimeOffset|**Display Name**: Start Date<br />**Description**: Shows the Start Date<br />|
|state|Edm.Int32|**Display Name**: Action Card State<br />**Description**: State of the Action Card<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Dismissed</td></tr><tr><td>2</td><td>Completed</td></tr><tbody></table>|
|title|Edm.String|**Display Name**: Title<br />**Description**: Title of the ActionCard<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version number of the action card.<br />Read-only<br />|
|visibility|Edm.Boolean|**Display Name**: Visibiliy Status of ActionCard<br />**Description**: Select whether the visibility should be set to public/private.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Private</td></tr><tr><td>0</td><td>Public</td></tr><tbody></table>|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_cardtypeid_value||Unique identifier of the card type.|
|_createdby_value|createdby<br />|Unique identifier of the user who created the action card.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the action card.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who last modified the action card.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who last modified action card.|
|_ownerid_value|ownerid<br />|Unique identifier of the user or team who owns the action card.|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier of the business unit that owns the action card.|
|_owningteam_value||Unique identifier of the team who owns the action card.|
|_owninguser_value||Unique identifier of the user who owns the action card.|
|_recordid_value||Shows the record ID.|
|_regardingobjectid_value|regardingobjectid_lead_actioncard<br />regardingobjectid_incident_actioncard<br />regardingobjectid_opportunity_actioncard<br />regardingobjectid_contact_actioncard<br />regardingobjectid_account_actioncard<br />|Choose the record that the card relates to.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Unique identifier of the currency associated with the action card.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_actioncardbase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_actioncardbase_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_actioncardbase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_actioncardbase_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_actioncards|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_actioncards|
|regardingobjectid_account_actioncard|[account EntityType](account.md)|account_actioncard|
|regardingobjectid_adx_alertsubscription|[adx_alertsubscription EntityType](adx_alertsubscription.md)|adx_alertsubscription_ActionCards|
|regardingobjectid_adx_inviteredemption|[adx_inviteredemption EntityType](adx_inviteredemption.md)|adx_inviteredemption_ActionCards|
|regardingobjectid_adx_portalcomment|[adx_portalcomment EntityType](adx_portalcomment.md)|adx_portalcomment_ActionCards|
|regardingobjectid_appointment_actioncard|[appointment EntityType](appointment.md)|appointment_actioncard|
|regardingobjectid_contact_actioncard|[contact EntityType](contact.md)|contact_actioncard|
|regardingobjectid_email_actioncard|[email EntityType](email.md)|email_actioncard|
|regardingobjectid_fax_actioncard|[fax EntityType](fax.md)|fax_actioncard|
|regardingobjectid_incident_actioncard|[incident EntityType](incident.md)|incident_actioncard|
|regardingobjectid_lead_actioncard|[lead EntityType](lead.md)|Lead_actioncard|
|regardingobjectid_letter_actioncard|[letter EntityType](letter.md)|letter_actioncard|
|regardingobjectid_msdyn_approval|[msdyn_approval EntityType](msdyn_approval.md)|msdyn_approval_ActionCards|
|regardingobjectid_msdyn_bookingalert|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|msdyn_bookingalert_ActionCards|
|regardingobjectid_msdyn_surveyinvite|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|msdyn_surveyinvite_ActionCards|
|regardingobjectid_opportunity_actioncard|[opportunity EntityType](opportunity.md)|opportunity_actioncard|
|regardingobjectid_phonecall_actioncard|[phonecall EntityType](phonecall.md)|phonecall_actioncard|
|regardingobjectid_recurringappointmentmaster_actioncard|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|recurringappointmentmaster_actioncard|
|regardingobjectid_serviceappointment_actioncard|[serviceappointment EntityType](serviceappointment.md)|serviceappointment_actioncard|
|regardingobjectid_task_actioncard|[task EntityType](task.md)|task_actioncard|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|transactioncurrency_actioncard|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|ActionCardUserState_ActionCard|[actioncarduserstate EntityType](actioncarduserstate.md)|actioncardid|  

## Solutions
The following solutions include the actioncard entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics Sales Workload Solution](../solutions/sales.md)|[!INCLUDE[../solutions/descriptions/sales.md](../solutions/descriptions/sales.md)]|  
|[Microsoft Dynamics Service Workload Solution](../solutions/service.md)|[!INCLUDE[../solutions/descriptions/service.md](../solutions/descriptions/service.md)]|    

[!INCLUDE[./remarks/actioncard.md](./remarks/actioncard.md)]

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