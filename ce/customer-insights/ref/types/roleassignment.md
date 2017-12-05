---
title: RoleAssignment Type Definition
description: Used in the RBAC Management APIs to manage user and group assignments to built-in Roles. 
keywords: Customer Insights; type; role assignment
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 05/30/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 760dbe13-5dee-4690-bdea-3106f5011196
---

RoleAssignment Type Definition
==============================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Role Assignments are used in the RBAC Management APIs to manage user and group assignments to built-in [Roles](./role.md). Resource set descriptions enable fine-grained
resource access control.

## Properties

Property names appended with asterisks* are required. 

### RoleAssignment properties
|**Property**|**JSON type**|**Description**|
| --------------- | ---------- | ------------- |
|tenantId|string|Hub name (readonly)|
|assignmentName*|string|Name of the assignment(readonly)|
|displayName|Dictionary\<string,string\>|Localized display name for the assignment|
|description|Dictionary\<string,string\>|Localized description for the assignment|
|provisioningState|string|Assignment provisioning state: ["Provisioning" \| "Succeeded" \| "Expiring" \| "Deleting" \| "HumanIntervention" \| "Failed" ]|
|role*|string|Built-in role ["Admin" \| "Reader" \| "ManageAdmin" \| "ManageReader" \| "DataAdmin" \| "DataReader"]|
|principals*|AssignmentPrincipal[]|Assignment principal instance data (see below)|
|profiles|ResourceSetDescription|[Profiles](./profile.md) set for the assignment (see below)|
|interactions|ResourceSetDescription|[Interactions](./interaction.md) set for the assignment (see below)|
|links|ResourceSetDescription|[Links](./link.md) set for the assignment (see below)|
|kpis|ResourceSetDescription|[KPIs](./kpi.md) set for the assignment (see below)|
|sasPolicies|ResourceSetDescription|[SAS policies](./authzpolicy.md) set for the assignment (see below)|
|connectors|ResourceSetDescription|[Connectors](./connector.md) set for the assignment (see below)|
|views|ResourceSetDescription|[Views](./view.md) set for the assignment (see below)|
|relationships|ResourceSetDescription|[Relationships](./relationship.md) set for the assignment (see below)|
|relationshipLinks|ResourceSetDescription|[RelationshipLinks](./relationshiplink.md) set for the assignment (see below)|
|widgetTypes|ResourceSetDescription|[Widget](./widgettype.md) set for the assignment (see below)|
|roleAssignments|ResourceSetDescription|Role assignment access that is set for the assignment (see below)|
|conflationPolicies|ResourceSetDescription|Conflation policies set for the assignment (see below)|
|segments|ResourceSetDescription|[Segments](./segment.md) that are set for the assignment (see below)|
| | | |

<br/>

### AssignmentPrincipal properties
|**Property**|**JSON type**|**Description**|
| --------------- | ---------- | ------------- |
|principalId*|string|ID of the principal being assigned to|
|principalType*|string|Type of the principal ID ["User" \| "Group" \| "ServicePrincipal"]|
|principalMetadata|Dictionary\<string,object\>[]|Other metadata for the principal|

<br/>

### ResourceSetDescripion properties
|**Property**|**JSON type**|**Description**|
| --------------- | ---------- | ------------- |
|Elements|string[]|Elements included in the assignment set|
|Exceptions|string[]|Elements excluded from the assignment set|
| | | |

By default, elements not explicitly included in `Elements` are excluded from the assignment.  However, if `Elements` is set to "*", then all scopes are included, 
except those elements explicitly listed in `Exceptions`. This enables the scenario "allow access to everything except the following specific elements".

<br/>


## JSON example
```{json}
{ 
    "AssignmentName": "Assignment579", 
    "ProvisioningState": "Provisioning", 
    "Role": "Admin", 
    "tenantId": "sdkTestHub",
    "Principals": [ 
        { 
            "PrincipalId": "73fa56dd-f043-4619-bde4-13733d6926f4", 
            "PrincipalType": "User", 
            "PrincipalMetadata": null 
        }, 
        { 
            "PrincipalId": "8d8a7776-fe6d-42ba-9ff8-b0018aa79095", 
            "PrincipalType": "User", 
            "PrincipalMetadata": null 
        } 
    ], 
}
```


