---
title: "Microsoft Dynamics 365 Customer Engagement interactionforemail EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 7f139a3d-9066-42f0-8d7c-8201824ae676
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API interactionforemail entitytype."
---
# interactionforemail EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/interactionforemail.md](./descriptions/interactionforemail.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]interactionforemails </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Interaction for Email</td></tr>
<tr><td><b>Primary Key:</b></td><td>interactionforemailid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>GET (RetrieveMultiple Only)</td></tr>
</table>
  
The interactionforemail EntityType:
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|emailactivityid|Edm.Guid|**Display Name**: Email Activity Id<br />**Description**: Email Activity Id.<br />Read-only<br />|
|emailinteractionreplyid|Edm.Guid|**Display Name**: Email Activity Id<br />**Description**: Email Activity Id.<br />Read-only<br />|
|emailinteractiontime|Edm.DateTimeOffset|**Display Name**: Interaction date and time of the an email<br />**Description**: Shows the Interaction date and time of the an email.<br />Read-only<br />|
|exchangerate|Edm.Decimal|**Display Name**: ExchangeRate<br />**Description**: Exchange rate for the currency associated with the InteractionForEmail with respect to the base currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|interactedcomponenttext|Edm.String|**Display Name**: Email Interaction Component Related Text<br />**Description**: For internal use only.<br />|
|interactionforemailid|Edm.Guid|**Display Name**: Interaction for Email<br />**Description**: Unique identifier for entity instances<br />|
|interactionlocation|Edm.String|**Display Name**: Location for an Interaction<br />**Description**: Shows the location for an Interaction<br />|
|interactionrepliedby|Edm.String|**Display Name**: Name who replied to email if interaction is reply<br />**Description**: Shows the Name who replied to email if interaction is reply<br />|
|interactionreplyid|Edm.String|**Display Name**: InteractionReplyId<br />**Description**: InteractionReplyId<br />|
|interactiontype|Edm.Int32|**Display Name**: Interaction Type<br />**Description**: Shows the type of Interaction.<br />Read-only<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>EmailOpen</td></tr><tr><td>1</td><td>LinkOpen</td></tr><tr><td>2</td><td>AttachmentOpen</td></tr><tr><td>3</td><td>EmailReply</td></tr><tbody></table>|
|interactionuseragent|Edm.String|**Display Name**: User Agent for an Interaction<br />**Description**: Shows the User Agent for an Interaction if available<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: The name of the custom entity.<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: Status of the Interaction for Email<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Active</td></tr><tr><td>1</td><td>Inactive</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Reason<br />**Description**: Reason for the status of the Interaction for Email<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Inactive</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdbyname<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|createdonbehalfbyname<br />|Unique identifier of the delegate user who created the record.|
|_modifiedby_value|modifiedbyname<br />|Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfbyname<br />|Unique identifier of the delegate user who modified the record.|
|_ownerid_value|ownerid<br />|Unique identifier of the user or team who owns the record.|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Exchange rate for the currency associated with the InteractionForEmail with respect to the base currency.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdbyname|[systemuser EntityType](systemuser.md)|lk_new_interactionforemail_createdby|
|createdonbehalfbyname|[systemuser EntityType](systemuser.md)|lk_new_interactionforemail_createdonbehalfby|
|modifiedbyname|[systemuser EntityType](systemuser.md)|lk_new_interactionforemail_modifiedby|
|modifiedonbehalfbyname|[systemuser EntityType](systemuser.md)|lk_new_interactionforemail_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_new_interactionforemail|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_new_interactionforemail|
|owningteam|[team EntityType](team.md)|team_new_interactionforemail|
|owninguser|[systemuser EntityType](systemuser.md)|user_new_interactionforemail|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_InteractionForEmail|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|interactionforemail_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_new_interactionforemail_adx_alertsubscription|  
|interactionforemail_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_new_interactionforemail_adx_inviteredemption|  
|interactionforemail_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_new_interactionforemail_adx_portalcomment|  
|interactionforemail_BulkOperations|[bulkoperation EntityType](bulkoperation.md)|regardingobjectid_new_interactionforemail_bulkoperation|  
|interactionforemail_CampaignActivities|[campaignactivity EntityType](campaignactivity.md)|regardingobjectid_new_interactionforemail_campaignactivity|  
|interactionforemail_CampaignResponses|[campaignresponse EntityType](campaignresponse.md)|regardingobjectid_new_interactionforemail_campaignresponse|  
|interactionforemail_IncidentResolutions|[incidentresolution EntityType](incidentresolution.md)|regardingobjectid_new_interactionforemail_incidentresolution|  
|interactionforemail_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_new_interactionforemail_msdyn_approval|  
|interactionforemail_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_new_interactionforemail_msdyn_bookingalert|  
|interactionforemail_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_new_interactionforemail_msdyn_surveyinvite|  
|interactionforemail_OpportunityCloses|[opportunityclose EntityType](opportunityclose.md)|regardingobjectid_new_interactionforemail_opportunityclose|  
|interactionforemail_OrderCloses|[orderclose EntityType](orderclose.md)|regardingobjectid_new_interactionforemail_orderclose|  
|interactionforemail_QuoteCloses|[quoteclose EntityType](quoteclose.md)|regardingobjectid_new_interactionforemail_quoteclose|  
|interactionforemail_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_new_interactionforemail_serviceappointment|  
|new_interactionforemail_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_new_interactionforemail|  
|new_interactionforemail_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_new_interactionforemail|    

[!INCLUDE[./remarks/interactionforemail.md](./remarks/interactionforemail.md)]

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