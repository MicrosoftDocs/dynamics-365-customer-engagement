---
title: "msdyn_playbooktempate EntityType | MicrosoftDocs"
description: "Entity reference for msdyn_playbooktemplate EntityType"
ms.date: 04/08/2019
ms.service: crm-online
ms.topic: article
author: susikka
ms.author: susikka
manager: shujoshi
---
# msdyn_playbooktemplate EntityType

[!INCLUDE[msdyn_playbooktemplate-description](../includes/msdyn_playbooktemplate-description.md)]

Entity set path: `[organizationURI]/api/data/v9.1/msdyn_playbooktemplates`<br />
Display name: Playbook template<br />
Primary key: msdyn_playbooktemplateid <br />
Operations supported: Create, retrieve, update, and delete<br />

## Properties

Properties represent fields of data stored in the entity. Some properties are read-only.

|Name|Display name|Type|Description|
|-----|-----|-----|-----|
|createdby|Created By|Edm.Guid|Unique identifier of the user who created the record.|
|createdon|Created On|Edm.DateTimeOffset|Date and time the record was created.|
|createdonbehalfby|CreatedOnBehalfBy|Edm.Guid|Unique identifier of the delegate user who created the record.|
|importsequencenumber|Import Sequence Number|Edm.Int32|Sequence number of the import that created this record.|
|modifiedby|Modified By|Edm.Guid|Unique identifier of the user who modified the record.|
|modifiedon|Modified On|Edm.DateTimeOffset|Date and time the record was modified.|
|modifiedonbehalfby|Modified On Behalf By|Edm.Guid|Unique identifier of the delegate user who modified the record.|
|msdyn_categoryid|Category|Edm.Guid|Shows the unique ID of the playbook category associated with the playbook template.|
|msdyn_description|Description|Edm.String|Type additional information to describe the playbook template.|
|msdyn_estimatedduration|Estimated duration (days)|Edm.Int32|Enter the estimated duration in days to indicate the time it might take to complete the playbook template once launched.|
|msdyn_fullentitylist|Entities enabled for playbook|Edm.String|For internal use only.|
|msdyn_name|Name|Edm.String|Type the name of the playbook template.|
|msdyn_playbooktemplateid|Playbook template|Edm.Guid|Shows the unique ID of the playbook template.|
|msdyn_relatedentitylist|Entities to which a playbook applies|Edm.String|For internal use only.|
|msdyn_trackprogress|Track progress|Edm.Boolean|Select whether or not to track the progress of the playbook by creating activities under a playbook, which in turn are related to the record type the playbook applies to.|
|overriddencreatedon|Record Created On|Edm.DateTimeOffset|Date and time that the record was migrated.|
|owner|Owner|Edm.Guid|Owner ID.|
|owningbusinessunit|Owning Business Unit|Edm.Guid|Unique identifier for the business unit that owns the record.|
|owningteam|Owning Team|Edm.Guid|Unique identifier for the team that owns the record.|
|owninguser|Owning User|Edm.Guid|Unique identifier for the user who owns the record.|
|statecode|Status|Edm.Int32|Status of the forecast definition.|
|statuscode|Status reason|Edm.Int32|Reason for the status of the forecast definition.|
|timezoneruleversionnumber|Time Zone Rule Version Number|Edm.Int32|For internal use only.|
|utcconversiontimezonecode|UTC Conversion Time Zone Code|Edm.Int32|Time zone code that was in use when the record was created.|
|versionnumber|Version Number|Edm.Int64|Version number.|

### See also

[Entity reference for playbooks](../playbook-entity-reference.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
