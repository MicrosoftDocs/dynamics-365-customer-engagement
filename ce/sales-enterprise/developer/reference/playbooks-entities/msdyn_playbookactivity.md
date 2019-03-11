---
title: "msdyn_playbookactivity EntityType | MicrosoftDocs"
description: "Entity reference for msdyn_playbookactivity EntityType"
keywords: 
ms.date: 03/11/2019
ms.service: crm-online
ms.custom: 
ms.topic: article
applies_to:
  - Dynamics 365 for Customer Engagement (online)
  - Dynamics 365 for Customer Engagement Version 9.x
ms.assetid: AAF5B63C-876E-4A56-93F4-D4E027997C05
author: susikka
ms.author: susikka
manager: shujoshi
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 22
topic-status: Drafting
---
# msdyn_playbookactivity EntityType

Stores the details of the activities to be created when a playbook is launched.

Entity Set Path: `[organizationURI]/api/data/v9.1/msdyn_playbookactivities`<br />
Display Name: Playbook activity<br />
Primary key: msdyn_playbookactivityid <br />
Operations supported: Create, Retrieve, Update and Delete<br />

## Properties

Properties represent fields of data stored in the entity. Some properties are read-only.

|Name|Display name|Type|Description|
|-----|-----|-----|-----|
|createdby|Created By|Edm.Guid|Unique identifier of the user who created the record|
|createdon|Created On|Edm.DateTimeOffset|Date and time when the record was created|
|createdonbehalfby|CreatedOnBehalfBy|Edm.Guid|Unique identifier of the delegate user who created the record|
|importsequencenumber|Import Sequence Number|Edm.Int32|Sequence number of the import that created this record|
|modifiedby|Modified By|Edm.Guid|Unique identifier of the user who modified the record|
|modifiedon|Modified On|Edm.DateTimeOffset|Date and time when the record was modified|
|modifiedonbehalfby|Modified On Behalf By|Edm.Guid|Unique identifier of the delegate user who modified the record|
|msdyn_activityLogicalName|Activity Logical name|Edm.String|The logical name of the entity|
|msdyn_activityType|Activity type|Edm.Int32|Select the type of activity to be associated with the Playbook|
|msdyn_playbookactivity_json|Playbook Activity JSON|Edm.String|For internal use only|
|msdyn_playbookactivityid|Playbook activities|Edm.Guid|Shows the unique identifier of the Playbook activity|
|msdyn_playbooktemplateid|Playbook template|Edm.Guid|Select the type of activity to be associated with the playbook activities|
|msdyn_subject|Subject|Edm.String|Type a short description about the objective or primary topic of the activity|
|overriddencreatedon|Record Created On|Edm.DateTimeOffset|Date and time that the record was migrated|
|owner|Owner|Edm.Guid|Owner Id|
|owningbusinessunit|Owning Business Unit|Edm.Guid|Unique identifier for the business unit that owns the record|
|owningteam|Owning Team|Edm.Guid|Unique identifier for the team that owns the record|
|owninguser|Owning User|Edm.Guid|Unique identifier for the user that owns the record|
|statecode|Status|Edm.Int32|Status of the Forecast Definition|
|statuscode|Status reason|Edm.Int32|Reason for the status of the Forecast Definition|
|timezoneruleversionnumber|Time Zone Rule Version Number|Edm.Int32|For internal use only|
|utcconversiontimezonecode|UTC Conversion Time Zone Code|Edm.Int32|Time zone code that was in use when the record was created|
|versionnumber|Version Number|Edm.Int64|Version Number|

## See also

[Entity reference for Playbooks](playbook-entity-reference.md)