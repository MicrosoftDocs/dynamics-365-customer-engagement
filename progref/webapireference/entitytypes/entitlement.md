---
title: "Microsoft Dynamics 365 Customer Engagement entitlement EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 5f36c031-5ac0-47ad-8f32-8dc0c74dd1ea
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API entitlement entitytype."
---
# entitlement EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/entitlement.md](./descriptions/entitlement.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]entitlements </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Entitlement</td></tr>
<tr><td><b>Primary Key:</b></td><td>entitlementid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  


## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|allocationtypecode|Edm.Int32|**Display Name**: Allocation Type<br />**Description**: Select the type of entitlement terms.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Number of cases</td></tr><tr><td>1</td><td>Number of hours</td></tr><tbody></table>|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: Date and time when the record was created.<br />Read-only<br />|
|decreaseremainingon|Edm.Int32|**Display Name**: Decrease Remaining On<br />**Description**: Select whether to decrease the remaining terms when the case is created or when it is resolved.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Case Resolution</td></tr><tr><td>1</td><td>Case Creation</td></tr><tbody></table>|
|description|Edm.String|**Display Name**: Description<br />**Description**: Type additional information to describe the Entitlement<br />|
|emailaddress|Edm.String|**Display Name**: Email Address<br />**Description**: The primary email address for the entity.<br />|
|enddate|Edm.DateTimeOffset|**Display Name**: End Date<br />**Description**: Enter the date when the entitlement ends.<br />|
|entitlementid|Edm.Guid|**Display Name**: Entitlement<br />**Description**: Unique identifier for entity instances<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: Exchange rate for the currency associated with the contact with respect to the base currency.<br />Read-only<br />|
|importsequencenumber|Edm.Int32|**Display Name**: Import Sequence Number<br />**Description**: Sequence number of the import that created this record.<br />|
|isdefault|Edm.Boolean|**Display Name**: Is Default<br />**Description**: Shows whether this entitlement is the default one for the specified customer.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|kbaccesslevel|Edm.Int32|**Display Name**: KB Access Level<br />**Description**: Select the access someone will have to the knowledge base on the portal.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Standard</td></tr><tr><td>1</td><td>Premium</td></tr><tr><td>2</td><td>None</td></tr><tbody></table>|
|lastonholdtime|Edm.DateTimeOffset|**Display Name**: Last On Hold Time<br />**Description**: Contains the date and time stamp of the last on-hold time<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: Date and time when the record was modified.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Entitlement Name<br />**Description**: Type a meaningful name for the entitlement.<br />|
|onholdtime|Edm.Int32|**Display Name**: On Hold Time (Minutes)<br />**Description**: Shows how long, in minutes, that the record was on hold<br />Read-only<br />|
|overriddencreatedon|Edm.DateTimeOffset|**Display Name**: Record Created On<br />**Description**: Date and time that the record was migrated.<br />|
|processid|Edm.Guid|**Display Name**: Process Id<br />**Description**: Contains the id of the process associated with the entity.<br />|
|remainingterms|Edm.Decimal|**Display Name**: Remaining Terms<br />**Description**: Type the total number of entitlement terms that are left.<br />|
|restrictcasecreation|Edm.Boolean|**Display Name**: Restrict based on entitlement terms<br />**Description**: Tells whether case creation is restricted based on entitlement terms.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>1</td><td>Yes</td></tr><tr><td>0</td><td>No</td></tr><tbody></table>|
|stageid|Edm.Guid|**Display Name**: Stage Id<br />**Description**: Contains the id of the stage where the entity is located.<br />|
|startdate|Edm.DateTimeOffset|**Display Name**: Start Date<br />**Description**: Enter the date when the entitlement starts.<br />|
|statecode|Edm.Int32|**Display Name**: Status<br />**Description**: For internal use only.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Draft</td></tr><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Cancelled</td></tr><tr><td>3</td><td>Expired</td></tr><tr><td>4</td><td>Waiting</td></tr><tbody></table>|
|statuscode|Edm.Int32|**Display Name**: Status Code<br />**Description**: Select the reason code that explains the status of the entitlement.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Draft</td></tr><tr><td>1</td><td>Active</td></tr><tr><td>2</td><td>Cancelled</td></tr><tr><td>3</td><td>Expired</td></tr><tr><td>1200</td><td>Waiting</td></tr><tbody></table>|
|timezoneruleversionnumber|Edm.Int32|**Display Name**: Time Zone Rule Version Number<br />**Description**: For internal use only.<br />|
|totalterms|Edm.Decimal|**Display Name**: Total Terms<br />**Description**: Type the total number of entitlement terms.<br />|
|traversedpath|Edm.String|**Display Name**: Traversed Path<br />**Description**: A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.<br />|
|utcconversiontimezonecode|Edm.Int32|**Display Name**: UTC Conversion Time Zone Code<br />**Description**: Time zone code that was in use when the record was created.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version Number<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_accountid_value|accountid<br />|Unique identifier for Account associated with Entitlement.|
|_contactid_value|contactid<br />|Unique identifier for Contact associated with Entitlement.|
|_createdby_value|createdby<br />|Unique identifier of the user who created the record.|
|_createdonbehalfby_value|createdonbehalfby<br />|Unique identifier of the delegate user who created the entitlement.|
|_customerid_value|customerid_account<br />customerid_contact<br />|Choose a contact or account for which this entitlement has been defined.|
|_entitlementtemplateid_value|entitlementtemplateid<br />|Unique identifier for Entitlement Template associated with Entitlement.|
|_modifiedby_value|modifiedby<br />|Unique identifier of the user who modified the record.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|Unique identifier of the delegate user who modified the record.|
|_ownerid_value|ownerid<br />|Owner Id|
|_owningbusinessunit_value|owningbusinessunit<br />|Unique identifier for the business unit that owns the record|
|_owningteam_value|owningteam<br />|Unique identifier for the team that owns the record.|
|_owninguser_value|owninguser<br />|Unique identifier for the user that owns the record.|
|_slaid_value|slaid<br />|Choose the service level agreement (SLA) associated with the entitlement.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Unique identifier of the currency associated with the contact.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|accountid|[account EntityType](account.md)|account_entitlement_Account|
|contactid|[contact EntityType](contact.md)|contact_entitlement_ContactId|
|createdby|[systemuser EntityType](systemuser.md)|lk_entitlement_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_entitlement_createdonbehalfby|
|customerid_account|[account EntityType](account.md)|account_entitlement_Customer|
|customerid_contact|[contact EntityType](contact.md)|contact_entitlement_Customer|
|entitlementtemplateid|[entitlementtemplate EntityType](entitlementtemplate.md)|entitlementtemplateid_RelationShip|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_entitlement_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_entitlement_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|owner_entitlement|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_entitlement|
|owningteam|[team EntityType](team.md)|team_entitlement|
|owninguser|[systemuser EntityType](systemuser.md)|user_entitlement|
|slaid|[sla EntityType](sla.md)|sla_entitlement|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_Entitlement|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|entitlement_ActivityParties|[activityparty EntityType](activityparty.md)|partyid_entitlement|  
|entitlement_ActivityPointers|[activitypointer EntityType](activitypointer.md)|regardingobjectid_entitlement|  
|entitlement_adx_alertsubscriptions|[adx_alertsubscription EntityType](adx_alertsubscription.md)|regardingobjectid_entitlement_adx_alertsubscription|  
|entitlement_adx_inviteredemptions|[adx_inviteredemption EntityType](adx_inviteredemption.md)|regardingobjectid_entitlement_adx_inviteredemption|  
|entitlement_adx_portalcomments|[adx_portalcomment EntityType](adx_portalcomment.md)|regardingobjectid_entitlement_adx_portalcomment|  
|entitlement_Annotations|[annotation EntityType](annotation.md)|objectid_entitlement|  
|entitlement_Appointments|[appointment EntityType](appointment.md)|regardingobjectid_entitlement_appointment|  
|entitlement_AsyncOperations|[asyncoperation EntityType](asyncoperation.md)|regardingobjectid_entitlement|  
|entitlement_BulkDeleteFailures|[bulkdeletefailure EntityType](bulkdeletefailure.md)|regardingobjectid_entitlement|  
|entitlement_cases|[incident EntityType](incident.md)|entitlementid|  
|entitlement_connections1|[connection EntityType](connection.md)|record1id_entitlement|  
|entitlement_connections2|[connection EntityType](connection.md)|record2id_entitlement|  
|entitlement_DuplicateBaseRecord|[duplicaterecord EntityType](duplicaterecord.md)|baserecordid_entitlement|  
|entitlement_DuplicateMatchingRecord|[duplicaterecord EntityType](duplicaterecord.md)|duplicaterecordid_entitlement|  
|entitlement_Emails|[email EntityType](email.md)|regardingobjectid_entitlement_email|  
|entitlement_entitlementchannel_EntitlementId|[entitlementchannel EntityType](entitlementchannel.md)|entitlementid|  
|entitlement_Faxes|[fax EntityType](fax.md)|regardingobjectid_entitlement_fax|  
|entitlement_IncidentResolutions|[incidentresolution EntityType](incidentresolution.md)|regardingobjectid_entitlement_incidentresolution|  
|entitlement_Letters|[letter EntityType](letter.md)|regardingobjectid_entitlement_letter|  
|entitlement_msdyn_approvals|[msdyn_approval EntityType](msdyn_approval.md)|regardingobjectid_entitlement_msdyn_approval|  
|entitlement_msdyn_bookingalerts|[msdyn_bookingalert EntityType](msdyn_bookingalert.md)|regardingobjectid_entitlement_msdyn_bookingalert|  
|entitlement_msdyn_surveyinvites|[msdyn_surveyinvite EntityType](msdyn_surveyinvite.md)|regardingobjectid_entitlement_msdyn_surveyinvite|  
|entitlement_OpportunityCloses|[opportunityclose EntityType](opportunityclose.md)|regardingobjectid_entitlement_opportunityclose|  
|entitlement_OrderCloses|[orderclose EntityType](orderclose.md)|regardingobjectid_entitlement_orderclose|  
|entitlement_PhoneCalls|[phonecall EntityType](phonecall.md)|regardingobjectid_entitlement_phonecall|  
|entitlement_QuoteCloses|[quoteclose EntityType](quoteclose.md)|regardingobjectid_entitlement_quoteclose|  
|entitlement_RecurringAppointmentMasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|regardingobjectid_entitlement_recurringappointmentmaster|  
|entitlement_ServiceAppointments|[serviceappointment EntityType](serviceappointment.md)|regardingobjectid_entitlement_serviceappointment|  
|entitlement_SLAKPIInstances|[slakpiinstance EntityType](slakpiinstance.md)|regarding_entitlement|  
|entitlement_SocialActivities|[socialactivity EntityType](socialactivity.md)|regardingobjectid_entitlement_socialactivity|  
|Entitlement_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_entitlement_syncerror|  
|entitlement_Tasks|[task EntityType](task.md)|regardingobjectid_entitlement_task|  
|entitlementcontacts_association|[contact EntityType](contact.md)|entitlementcontacts_association|  
|product_entitlement_association|[product EntityType](product.md)|product_entitlement_association|  

## Operations
The following operations can be used with the entitlement entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RenewEntitlement Action](../actions/renewentitlement.md)|Entity|[!INCLUDE[../actions/descriptions/renewentitlement.md](../actions/descriptions/renewentitlement.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the entitlement entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics Service Workload Solution](../solutions/service.md)|[!INCLUDE[../solutions/descriptions/service.md](../solutions/descriptions/service.md)]|    

[!INCLUDE[./remarks/entitlement.md](./remarks/entitlement.md)]

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