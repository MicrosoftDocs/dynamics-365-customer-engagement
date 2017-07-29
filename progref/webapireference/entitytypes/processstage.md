---
title: "Microsoft Dynamics 365 Customer Engagement processstage EntityType Reference | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: f222d45f-85fd-455d-9173-144cd43143d8
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
meta-description: "Reference information about the Web API processstage entitytype."
---
# processstage EntityType
<table>
<tr><td><b>Description:</b></td><td>[!INCLUDE[./descriptions/processstage.md](./descriptions/processstage.md)]</td></tr>
<tr><td><b>Entity Set path:</b></td><td>[!include[current-web-api-base-uri.md](../../includes/current-web-api-base-uri.md)]processstages </td></tr>
<tr><td><b>Base Type:</b></td><td>[crmbaseentity EntityType](crmbaseentity.md)</td></tr>
<tr><td><b>Display Name:</b></td><td>Process Stage</td></tr>
<tr><td><b>Primary Key:</b></td><td>processstageid</td></tr>
<tr><td><b>Primary Name Attribute:</b></td><td>stagename</td></tr>
<tr><td><b>Operations supported:</b></td><td>GET</td></tr>
</table>
  
The processstage EntityType:
* Has no functions or actions bound to it.
* Is not included in any solutions.

## Properties
Properties represent fields of data stored in the entity. Some properties are read-only. 


|Name|Type|Details|  
|----|----|-------|  
|clientdata|Edm.String|**Display Name**: Client Data<br />**Description**: Step metadata for process stage<br />Read-only<br />|
|owningbusinessunit|Edm.Guid|**Display Name**: Owning Business Unit<br />**Description**: Select the business unit that owns the record.<br />Read-only<br />|
|primaryentitytypecode|Edm.String|**Display Name**: Primary Entity<br />**Description**: Primary entity associated with the stage.<br />|
|processstageid|Edm.Guid|**Display Name**: Process Stage<br />**Description**: Shows the ID of the process stage record.<br />|
|stagecategory|Edm.Int32|**Display Name**: Stage Category<br />**Description**: Select the category of the sales process.<br />**Default Options**:<br /><table><thead><td>**Value**</td><td>**Label**</td></thead><tbody><tr><td>0</td><td>Qualify</td></tr><tr><td>1</td><td>Develop</td></tr><tr><td>2</td><td>Propose</td></tr><tr><td>3</td><td>Close</td></tr><tr><td>4</td><td>Identify</td></tr><tr><td>5</td><td>Research</td></tr><tr><td>6</td><td>Resolve</td></tr><tr><td>7</td><td>Approval</td></tr><tbody></table>|
|stagename|Edm.String|**Display Name**: Process Stage Name<br />**Description**: Type a name for the process stage.<br />|
|versionnumber|Edm.Int64|**Display Name**: Version Number<br />**Description**: Version number of the process stage.<br />Read-only<br />|

## Lookup Properties
Lookup properties are read-only, computed properties which contain entity primary key Edm.Guid data for one or more corresponding single-valued navigation properties. More information: [Lookup properties](https://msdn.microsoft.com/library/mt607990.aspx#bkmk_lookupProperties) and [Retrieve data about lookup properties](https://msdn.microsoft.com/library/gg334767.aspx#bkmk_lookupProperty).


|Name|Single-valued navigation property|Description|  
|----|---------------------------------|-----------|  
|_ownerid_value||Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.|
|_processid_value|processid<br />|Shows the ID of the process.|


## Single-valued navigation properties
Single-valued navigation properties represent lookup fields where a single entity can be referenced. Each single-valued navigation property has a corresponding partner collection-valued navigation property on the related entity.


|Name|Type|Partner|  
|----|----|-------|  
|processid|[workflow EntityType](workflow.md)|process_processstage|

## Collection-valued navigation properties
Collection-valued navigation properties represent collections of entities which may represent either a one-to-many (1:N) or many-to-many (N:N) relationship between the entities.


|Name|Type|Partner|  
|----|----|-------|  
|lk_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b_activestageid|[msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b EntityType](msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b.md)|activestageid|  
|lk_msdyncrm_leadtoopportunity_activestageid|[msdyncrm_leadtoopportunity EntityType](msdyncrm_leadtoopportunity.md)|activestageid|  
|lk_msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99_activestageid|[msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99 EntityType](msevtmgt_bpf_9623d46752ae497989f62ac0d11dad99.md)|activestageid|  
|processstage_account|[account EntityType](account.md)|stageid_processstage|  
|processstage_adx_portalcomment|[adx_portalcomment EntityType](adx_portalcomment.md)|stageid_adx_portalcomment|  
|processstage_appointments|[appointment EntityType](appointment.md)|stageid_processstage|  
|processstage_campaignactivities|[campaignactivity EntityType](campaignactivity.md)|stageid_processstage|  
|processstage_campaignresponses|[campaignresponse EntityType](campaignresponse.md)|stageid_processstage|  
|processstage_campaigns|[campaign EntityType](campaign.md)|stageid_processstage|  
|processstage_competitors|[competitor EntityType](competitor.md)|stageid_processstage|  
|processstage_contact|[contact EntityType](contact.md)|stageid_processstage|  
|processstage_emails|[email EntityType](email.md)|stageid_processstage|  
|processstage_expiredprocess|[expiredprocess EntityType](expiredprocess.md)|activestageid|  
|processstage_faxes|[fax EntityType](fax.md)|stageid_processstage|  
|processstage_incident|[incident EntityType](incident.md)|stageid_processstage|  
|processstage_invoices|[invoice EntityType](invoice.md)|stageid_processstage|  
|processstage_knowledgearticle|[knowledgearticle EntityType](knowledgearticle.md)|stageid_processstage|  
|processstage_lead|[lead EntityType](lead.md)|stageid_processstage|  
|processstage_leadtoopportunitysalesprocess|[leadtoopportunitysalesprocess EntityType](leadtoopportunitysalesprocess.md)|activestageid|  
|processstage_letters|[letter EntityType](letter.md)|stageid_processstage|  
|processstage_lists|[list EntityType](list.md)|stageid_processstage|  
|processstage_msdyn_agreement|[msdyn_agreement EntityType](msdyn_agreement.md)|stageid|  
|processstage_msdyn_agreementbookingsetup|[msdyn_agreementbookingsetup EntityType](msdyn_agreementbookingsetup.md)|stageid|  
|processstage_msdyn_agreementinvoicesetup|[msdyn_agreementinvoicesetup EntityType](msdyn_agreementinvoicesetup.md)|stageid|  
|processstage_msdyn_expense|[msdyn_expense EntityType](msdyn_expense.md)|stageid|  
|processstage_msdyn_iotalert|[msdyn_iotalert EntityType](msdyn_iotalert.md)|stageid|  
|processstage_msdyn_journal|[msdyn_journal EntityType](msdyn_journal.md)|stageid|  
|processstage_msdyn_project|[msdyn_project EntityType](msdyn_project.md)|stageid|  
|processstage_msdyn_purchaseorder|[msdyn_purchaseorder EntityType](msdyn_purchaseorder.md)|stageid|  
|processstage_msdyn_purchaseorderbill|[msdyn_purchaseorderbill EntityType](msdyn_purchaseorderbill.md)|stageid|  
|processstage_msdyn_purchaseorderreceipt|[msdyn_purchaseorderreceipt EntityType](msdyn_purchaseorderreceipt.md)|stageid|  
|processstage_msdyn_quotebookingsetup|[msdyn_quotebookingsetup EntityType](msdyn_quotebookingsetup.md)|stageid|  
|processstage_msdyn_timegroup|[msdyn_timegroup EntityType](msdyn_timegroup.md)|stageid|  
|processstage_msdyn_timegroupdetail|[msdyn_timegroupdetail EntityType](msdyn_timegroupdetail.md)|stageid|  
|processstage_msdyn_workorder|[msdyn_workorder EntityType](msdyn_workorder.md)|stageid|  
|processstage_msevtmgt_Event|[msevtmgt_event EntityType](msevtmgt_event.md)|stageid|  
|processstage_msevtmgt_Speaker|[msevtmgt_speaker EntityType](msevtmgt_speaker.md)|stageid|  
|processstage_newprocess|[newprocess EntityType](newprocess.md)|activestageid|  
|processstage_opportunity|[opportunity EntityType](opportunity.md)|stageid_processstage|  
|processstage_opportunitysalesprocess|[opportunitysalesprocess EntityType](opportunitysalesprocess.md)|activestageid|  
|processstage_phonecalls|[phonecall EntityType](phonecall.md)|stageid_processstage|  
|processstage_phonetocaseprocess|[phonetocaseprocess EntityType](phonetocaseprocess.md)|activestageid|  
|processstage_productpricelevels|[productpricelevel EntityType](productpricelevel.md)|stageid_processstage|  
|processstage_products|[product EntityType](product.md)|stageid_processstage|  
|processstage_quotes|[quote EntityType](quote.md)|stageid_processstage|  
|processstage_recurringappointmentmasters|[recurringappointmentmaster EntityType](recurringappointmentmaster.md)|stageid_processstage|  
|processstage_salesliteratures|[salesliterature EntityType](salesliterature.md)|stageid_processstage|  
|processstage_salesorders|[salesorder EntityType](salesorder.md)|stageid_processstage|  
|ProcessStage_SyncErrors|[syncerror EntityType](syncerror.md)|regardingobjectid_processstage_syncerror|  
|processstage_systemusers|[systemuser EntityType](systemuser.md)|stageid_processstage|  
|processstage_tasks|[task EntityType](task.md)|stageid_processstage|  
|processstage_teams|[team EntityType](team.md)|stageid_processstage|  
|processstage_translationprocess|[translationprocess EntityType](translationprocess.md)|activestageid|  

## Operations
The following operations can be used with the processstage entity type.


|Name|Binding|Description|  
|----|-------|-----------|  
|[RetrieveActivePath Function](../functions/retrieveactivepath.md)|Not Bound|[!INCLUDE[../functions/descriptions/retrieveactivepath.md](../functions/descriptions/retrieveactivepath.md)]|    

[!INCLUDE[./remarks/processstage.md](./remarks/processstage.md)]

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