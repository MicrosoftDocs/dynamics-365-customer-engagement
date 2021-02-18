---
title: "msdyn_playbookinstance EntityType | MicrosoftDocs"
description: "Entity reference for msdyn_playbookinstance EntityType"
ms.date: 04/08/2019
ms.service: 
  - crm-online
ms.topic: article
author: susikka
ms.author: susikka
manager: shujoshi
---
# msdyn_playbookinstance EntityType

[!INCLUDE[msdyn_playbookinstance-description](../includes/msdyn_playbookinstance-description.md)]

Entity set path: `[organizationURI]/api/data/v9.1/msdyn_playbookinstances`<br />
Display name: Playbook<br />
Primary key: msdyn_playbookinstanceid <br />
Operations supported: Create, retrieve, update, and delete<br />

## Properties

Properties represent fields of data stored in the entity. Some properties are read-only.

<!--note from editor:  Please confirm that the change "createdy" to "createdby" in first row in table below is correct  -->

|Name|Display name|Type|Description|
|-----|-----|-----|-----|
|createdby|Created By|Edm.Guid|Unique identifier of the user who created the record.|
|createdon|Created On|Edm.DateTimeOffset|Date and time the record was created.|
|createdonbehalfby|CreatedOnBehalfBy|Edm.Guid|Unique identifier of the delegate user who created the record.|
|importsequencenumber|Import Sequence Number|Edm.Int32|Sequence number of the import that created this record.|
|modifiedby|Modified By|Edm.Guid|Unique identifier of the user who modified the record.|
|modifiedon|Modified On|Edm.DateTimeOffset|Date and time the record was modified.|
|modifiedonbehalfby|Modified On Behalf By|Edm.Guid|Unique identifier of the delegate user who modified the record.|
|msdyn_activitiesassociated|Edm.Int32|Total Activities|Stores the number of activities associated with a playbook.|
|msdyn_activitiesclosed|Edm.Int32|Completed Activities|Stores the number of activities associated with a playbook that has been closed.|
|msyn_categoryid|Edm.Guid|Category|Select the playbook category for the playbook.|
|msdyn_estimatedclose|Edm.DateTimeOffset|Estimated close|Estimated close date for a playbook based on the estimated duration specified for the playbook template.|
|msdyn_evaluateactivityclosure|Edm.Boolean|Evaluate Activity Closure|For internal use only.|
|msdyn_name|Edm.String|Name|Type the name of the playbook.|
|msdyn_playbookinstanceid|Edm.Guid|Playbook|Unique identifier for entity instances.|
|msdyn_playbooktemplateid|Edm.Guid|Playbook Template|Shows the unique ID of the playbook template associated with the playbook.|
|msdyn_trackprogress|Edm.Boolean|Track progress|Select whether or not to track the progress of the playbook by creating the activities in a playbook which is in turn linked to the record type the playbook applies to|
|overriddencreatedon|Record Created On|Edm.DateTimeOffset|Date and time that the record was migrated.|
|owner|Owner|Edm.Guid|Owner ID|
|owningbusinessunit|Owning Business Unit|Edm.Guid|Unique identifier for the business unit that owns the record.|
|owningteam|Owning Team|Edm.Guid|Unique identifier for the team that owns the record.|
|owninguser|Owning User|Edm.Guid|Unique identifier for the user who owns the record.|
|statecode|Status|Edm.Int32|Status of the forecast definition.|
|statuscode|Status reason|Edm.Int32|Reason for the status of the forecast definition.|
|timezoneruleversionnumber|Time Zone Rule Version Number|Edm.Int32|For internal use only.|
|utcconversiontimezonecode|UTC Conversion Time Zone Code|Edm.Int32|Time zone code that was in use when the record was created.|
|versionnumber|Version Number|Edm.Int64|Version number.|


<!--note from editor: For item "msdyn_trackprogress" in table above: Change "Description" text to this? "Select whether or not to track the progress of the playbook by creating activities in the playbook, which are in turn linked to the record type the playbook applies to."-->

### See also

[Entity reference for playbooks](../playbook-entity-reference.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]