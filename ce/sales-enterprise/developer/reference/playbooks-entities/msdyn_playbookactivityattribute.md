---
title: "msdyn_playbookactivityattribute EntityType | MicrosoftDocs"
description: "Entity reference for msdyn_playbookactivityattribute EntityType"
ms.date: 04/08/2019
ms.service: crm-online
ms.topic: article
author: susikka
ms.author: susikka
manager: shujoshi
---
# msdyn_playbookactivityattribute EntityType

[!INCLUDE[msdyn_playbookactivityattribute-description](../includes/msdyn_playbookactivityattribute-description.md)]

Entity set path: `[organizationURI]/api/data/v9.1/msdyn_playbookactivityattributes`<br />
Display name: Playbook activity attribute <br />
Primary key: msdyn_playbookactivityattributeid <br />
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
|msdyn_attributeLogicalName|Attribute Name|Edm.String|Type the name of the playbook activity attribute.|
|msdyn_attributeType|Attribute type|Edm.Int32|Stores the data type of the attribute.|
|msdyn_attributeValue|Attribute value|Edm.String|Stores the value of the attribute.|
|msdyn_playbookactivityattributeid|Playbook activity attribute|Edm.Guid|Shows the ID of the playbook activity attribute.|
|msdyn_playbookactivityid|Playbook activity|Edm.Guid|Shows the ID of the playbook activity associated with the playbook activity attribute.|
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

### See also

[Entity reference for playbooks](../playbook-entity-reference.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
