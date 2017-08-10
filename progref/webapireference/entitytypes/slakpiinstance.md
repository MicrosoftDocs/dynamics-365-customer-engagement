---
title: "Microsoft Dynamics 365 Customer Engagement slakpiinstance EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: e44bf0cb-d6f9-4f6d-b75b-027c955c87a2
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API slakpiinstance entitytype."
---
# slakpiinstance EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/slakpiinstance.md](./descriptions/slakpiinstance.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../includes/current-web-api-base-uri.md)]slakpiinstances </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>SLA KPI Instance</td></tr>
<tr><td><b>Primary Key:</b></td><td>slakpiinstanceid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>name</td></tr>
<tr><td><b>Operations supported:</b></td><td>POST,GET,PATCH,DELETE</td></tr>
</table>
  
The slakpiinstance entitytype has no functions or actions bound to it.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|computedfailuretime|Edm.DateTimeOffset|**Display Name**: Computed Failure Time<br />**Description**: Computed Failure Date and time<br />|
|computedwarningtime|Edm.DateTimeOffset|**Display Name**: Computed Warning Time<br />**Description**: Computed Warning Date and time<br />|
|createdon|Edm.DateTimeOffset|**Display Name**: Created On<br />**Description**: For internal use only.<br />Read-only<br />|
|description|Edm.String|**Display Name**: Description<br />**Description**: For internal use only.<br />|
|exchangerate|Edm.Decimal|**Display Name**: Exchange Rate<br />**Description**: For internal use only.<br />Read-only<br />|
|failuretime|Edm.DateTimeOffset|**Display Name**: Failure Time<br />**Description**: Enter the date and time when the service level agreement (SLA) key performance indicator (KPI) will expire.<br />|
|modifiedon|Edm.DateTimeOffset|**Display Name**: Modified On<br />**Description**: For internal use only.<br />Read-only<br />|
|name|Edm.String|**Display Name**: Name<br />**Description**: Type a descriptive name for the service level agreement (SLA) key performance indicator (KPI) instance.<br />|
|slakpiinstanceid|Edm.Guid|**Display Name**: SLA KPI InstanceId<br />**Description**: Unique identifier of the SLA KPI Instance.<br />|
|status|Edm.Int32|**Display Name**: Status<br />**Description**: Reason for the status of the service level agreement (SLA) key performance indicator (KPI) instance. For example, the SLA KPI could be Noncompliant or Succeeded.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>In Progress</td></tr><tr><td>1</td><td>Noncompliant</td></tr><tr><td>2</td><td>Nearing Noncompliance</td></tr><tr><td>3</td><td>Paused</td></tr><tr><td>4</td><td>Succeeded</td></tr><tr><td>5</td><td>Canceled</td></tr><tbody></table>|
|succeededon|Edm.DateTimeOffset|**Display Name**: Succeeded On<br />**Description**: Shows the date and time when the service level agreement (SLA) key performance indicator (KPI) success criteria was met.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: For internal use only.<br />Read-only<br />|
|warningtime|Edm.DateTimeOffset|**Display Name**: Warning Time<br />**Description**: Enter the date and time when the service level agreement (SLA) key performance indicator (KPI)will go to a warning state.<br />|
|warningtimereached|Edm.Int32|**Display Name**: Warning Time Reached<br />**Description**: Shows information about whether the case has reached its warning time.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>No</td></tr><tr><td>1</td><td>Yes</td></tr><tbody></table>|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_createdby_value|createdby<br />|For internal use only.|
|_createdonbehalfby_value|createdonbehalfby<br />|For internal use only.|
|_modifiedby_value|modifiedby<br />|For internal use only.|
|_modifiedonbehalfby_value|modifiedonbehalfby<br />|For internal use only.|
|_ownerid_value|ownerid<br />|Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user or team.|
|_owningbusinessunit_value|owningbusinessunit<br />|Owning Business Unit.|
|_owningteam_value||OwningTeam.|
|_owninguser_value||Owning User.|
|_regarding_value|regarding_lead<br />regarding_entitlement<br />regarding<br />regarding_invoice<br />regarding_opportunity<br />regarding_quote<br />regarding_salesorder<br />regarding_account<br />regarding_contact<br />regarding_activitypointer<br />|Unique identifier of the record that this service level agreement (SLA) key performance indicator (KPI) instance is associated with.|
|_transactioncurrencyid_value|transactioncurrencyid<br />|Choose the local currency for the record to make sure budgets are reported in the correct currency.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|createdby|[systemuser EntityType](systemuser.md)|lk_slakpiinstancebase_createdby|
|createdonbehalfby|[systemuser EntityType](systemuser.md)|lk_slakpiinstancebase_createdonbehalfby|
|modifiedby|[systemuser EntityType](systemuser.md)|lk_slakpiinstancebase_modifiedby|
|modifiedonbehalfby|[systemuser EntityType](systemuser.md)|lk_slakpiinstancebase_modifiedonbehalfby|
|ownerid|[principal EntityType](principal.md)|slakpiinstance_owner|
|owningbusinessunit|[businessunit EntityType](businessunit.md)|business_unit_slakpiinstance|
|regarding|[incident EntityType](incident.md)|slakpiinstance_incident|
|regarding_account|[account EntityType](account.md)|slakpiinstance_account|
|regarding_activitypointer|[activitypointer EntityType](activitypointer.md)|slakpiinstance_activitypointer|
|regarding_appointment|[appointment EntityType](appointment.md)|slakpiinstance_appointment|
|regarding_contact|[contact EntityType](contact.md)|slakpiinstance_contact|
|regarding_email|[email EntityType](email.md)|slakpiinstance_email|
|regarding_entitlement|[entitlement EntityType](entitlement.md)|entitlement_SLAKPIInstances|
|regarding_fax|[fax EntityType](fax.md)|slakpiinstance_fax|
|regarding_invoice|[invoice EntityType](invoice.md)|slakpiinstance_invoice|
|regarding_lead|[lead EntityType](lead.md)|slakpiinstance_lead|
|regarding_letter|[letter EntityType](letter.md)|slakpiinstance_letter|
|regarding_opportunity|[opportunity EntityType](opportunity.md)|slakpiinstance_opportunity|
|regarding_phonecall|[phonecall EntityType](phonecall.md)|slakpiinstance_phonecall|
|regarding_quote|[quote EntityType](quote.md)|slakpiinstance_quote|
|regarding_salesorder|[salesorder EntityType](salesorder.md)|slakpiinstance_salesorder|
|regarding_serviceappointment|[serviceappointment EntityType](serviceappointment.md)|slakpiinstance_serviceappointment|
|regarding_socialactivity|[socialactivity EntityType](socialactivity.md)|slakpiinstance_socialactivity|
|regarding_task|[task EntityType](task.md)|slakpiinstance_task|
|transactioncurrencyid|[transactioncurrency EntityType](transactioncurrency.md)|TransactionCurrency_slakpiinstance|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|slakpiinstance_incident_firstresponsebykpi|[incident EntityType](incident.md)|firstresponsebykpiid|  
|slakpiinstance_incident_resolvebykpi|[incident EntityType](incident.md)|resolvebykpiid|  
|SLAKPIInstance_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_slakpiinstance_syncerror|  

## Operations
The following operations can be used with the slakpiinstance entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[GrantAccess Action](../actions/grantaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/grantaccess.md](../actions/descriptions/grantaccess.md)]|  
|[ModifyAccess Action](../actions/modifyaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/modifyaccess.md](../actions/descriptions/modifyaccess.md)]|  
|[RetrievePrincipalAccess Function](../functions/retrieveprincipalaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveprincipalaccess.md](../functions/descriptions/retrieveprincipalaccess.md)]|  
|[RetrieveSharedPrincipalsAndAccess Function](../functions/retrievesharedprincipalsandaccess.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrievesharedprincipalsandaccess.md](../functions/descriptions/retrievesharedprincipalsandaccess.md)]|  
|[RevokeAccess Action](../actions/revokeaccess.md)|Not Bound|[!INCLUDE[../actions/descriptions/revokeaccess.md](../actions/descriptions/revokeaccess.md)]|  

## Solutions
The following solutions include the slakpiinstance entity type.


|Name|Description |  
|----|------------|  
|[Microsoft Dynamics CRM Service Level Agreement (SLA) Solution](../solutions/servicelevelagreement.md)|[!INCLUDE[../solutions/descriptions/servicelevelagreement.md](../solutions/descriptions/servicelevelagreement.md)]|  
|[Microsoft Dynamics Service Workload Solution](../solutions/service.md)|[!INCLUDE[../solutions/descriptions/service.md](../solutions/descriptions/service.md)]|    

[!INCLUDE[./remarks/slakpiinstance.md](./remarks/slakpiinstance.md)]

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