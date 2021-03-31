---
title: "msdyn_playbookactivity EntityType | MicrosoftDocs"
description: "Entity reference for msdyn_playbookactivity EntityType"
ms.date: 04/08/2019
ms.service: crm-online
ms.topic: article
author: susikka
ms.author: susikka
manager: shujoshi
---
# msdyn_playbookactivity EntityType

[!INCLUDE[msdyn_playbookactivity-description](../includes/msdyn_playbookactivity-description.md)]

Entity set path: `[organizationURI]/api/data/v9.1/msdyn_playbookactivities`<br />
Display name: Playbook activity<br />
Primary key: msdyn_playbookactivityid <br />
Operations supported: Create, retrieve, update, and delete<br />

## Properties

Properties represent fields of data stored in the entity. Some properties are read-only.

|Name|Display name|Type|Description|
|-----|-----|-----|-----|
|createdby|Created By|Edm.Guid|Unique identifier of the user who created the record.|
|createdon|Created On|Edm.DateTimeOffset|Date and time when the record was created.|
|createdonbehalfby|CreatedOnBehalfBy|Edm.Guid|Unique identifier of the delegate user who created the record.|
|importsequencenumber|Import Sequence Number|Edm.Int32|Sequence number of the import that created this record.|
|modifiedby|Modified By|Edm.Guid|Unique identifier of the user who modified the record.|
|modifiedon|Modified On|Edm.DateTimeOffset|Date and time when the record was modified.|
|modifiedonbehalfby|Modified On Behalf By|Edm.Guid|Unique identifier of the delegate user who modified the record.|
|msdyn_activityLogicalName|Activity Logical name|Edm.String|The logical name of the entity.|
|msdyn_activityType|Activity type|Edm.Int32|Select the type of activity to be associated with the playbook.|
|msdyn_playbookactivity_json|Playbook Activity JSON|Edm.String|For internal use only.|
|msdyn_playbookactivityid|Playbook activities|Edm.Guid|Shows the unique identifier of the playbook activity.|
|msdyn_playbooktemplateid|Playbook template|Edm.Guid|Select the type of activity to be associated with the playbook activities.|
|msdyn_subject|Subject|Edm.String|Type a short description about the objective or primary topic of the activity.|
|overriddencreatedon|Record Created On|Edm.DateTimeOffset|Date and time that the record was migrated.|
|owner|Owner|Edm.Guid|Owner ID.|
|owningbusinessunit|Owning Business Unit|Edm.Guid|Unique identifier for the business unit that owns the record.|
|owningteam|Owning Team|Edm.Guid|Unique identifier for the team that owns the record.|
|owninguser|Owning User|Edm.Guid|Unique identifier for the user that owns the record.|
|statecode|Status|Edm.Int32|Status of the forecast definition.|
|statuscode|Status reason|Edm.Int32|Reason for the status of the forecast definition.|
|timezoneruleversionnumber|Time Zone Rule Version Number|Edm.Int32|For internal use only.|
|utcconversiontimezonecode|UTC Conversion Time Zone Code|Edm.Int32|Time zone code that was in use when the record was created.|
|versionnumber|Version Number|Edm.Int64|Version number.|

### See also

[Entity reference for playbooks](../playbook-entity-reference.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
