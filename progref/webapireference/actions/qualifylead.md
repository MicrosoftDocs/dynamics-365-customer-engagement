---
title: "QualifyLead Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: b42471bc-c9f9-43a7-85fa-f3f75d9d41f3
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# QualifyLead Action
[!INCLUDE[./descriptions/qualifylead.md](./descriptions/qualifylead.md)]



## Bound Entities 
Bound actions are invoked by appending the action name to the URI representing an entity or collection.
|EntityType|Binding Type|
|----------|-----------------|
|[lead Entitytype](../entitytypes/lead.md)|entity|

## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|CreateAccount|Edm.Boolean|false|true|Indicates whether to create an account from the originating lead.|
|CreateContact|Edm.Boolean|false|true|Indicates whether to create a contact from the originating lead. |
|CreateOpportunity|Edm.Boolean|false|true|Indicates whether to create an opportunity from the originating lead. |
|OpportunityCurrencyId|[transactioncurrency EntityType](../entitytypes/transactioncurrency.md)|true|true|The currency to use for the generated opportunity.|
|OpportunityCustomerId|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|true|true|The account or contact that is associated with the opportunity. |
|SourceCampaignId|[campaign EntityType](../entitytypes/campaign.md)|true|true|The source campaign that is associated with the opportunity. |
|Status|Edm.Int32|false|true|The status of the lead.|
|ProcessInstanceId|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|true|true|TODO: QualifyLead Action ProcessInstanceId Parameter Description |

## Return Type
The QualifyLead action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|Collection([crmbaseentity EntityType](../entitytypes/crmbaseentity.md))|false|Contains the response from the QualifyLead Action |



[!INCLUDE[./remarks/qualifylead.md](./remarks/qualifylead.md)]

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