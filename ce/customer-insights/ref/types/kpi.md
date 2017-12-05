---
title: KPI Type Definitions (Microsoft Dynamics 365 for Customer Insights) | MicrosoftDocs
description: Key Performance Indicators (KPIs) represent quantifiable measures and key insights about business data or processes, or aspects thereof.
keywords: Customer Insights; type; KPI
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 06/09/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: ac912b3b-3707-4b7c-b4ef-4cc0c62467ae
---

KPI Type Definitions
====================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Key Performance Indicators (KPIs) represent quantifiable measures and key insights about business data or processes, or aspects thereof. A KPI type is defined over a [Profile](./profile.md) or [Interaction](./interaction.md) for each step of a business workflow or as a cumulative measure of a business process. A KPI can also be defined over other KPIs, this type of KPI is referred to as a KPI on KPI. KPIs are defined with a set of basic built-in _functions_, and are recomputed every 15 minutes over a specified rolling time period, called a  _calculation window_. KPIs have a number of other characteristics, which can be modified through the UI or programmatically, such as the associated metric unit, filters, threshold values, grouping values, and KPI aliases.

KPIs can also capture more complicated secondary relationships between Interactions and Profiles through the use of [Links](./link.md) and [Relationships](./relationship.md).

## Properties

Property names appended with asterisks* are required.

### KpiDefinition properties

|**Property**|**JSON type**|**Description**|
| --------------- | ---------- | ------------- |
|kpiName|string|Name of the KPI (readonly)|
|entityType*|string|Type of the associated entity: ["None" (KPI on KPI) \| "Profile" \| "Interaction" \| "Relationship" ]|
|entityTypeName*|string|Name of the type on which the KPI is defined. Empty in the case of a KPI on KPI|
|function*|string|KPI computation function: ["None (KPI on KPI)" \| "Sum" \| "Avg" \| "Min" \| "Max" \| "Count" \| "CountDistinct"|
|expression*|string|KPI computation expression. This is '*' in case the function is "Count". Otherwise, any mathematical expression composed of the properties in the profile/ interaction type/alias can be used here. The expression should evaluate to a number. In case of a KPI on KPI, this will be an expression composed of other KPI names|
|calculationWindow*|string|Time window over which the KPI computation will be done. : ["Lifetime" \| "Hour" \| "Day" \| "Week" \| "Month"]|
|calculationWindowFieldName|string|By default, for an interaction KPI, the KPI Time is based on the interactions' timestamp property. This calculationWindowFieldName field is used to explicitly declare the DateTimeOffset field name of the interaction that should be used instead for KPI Time|
|filter|string|This expression will be used to filter out data before computation is done. |
|groupBy|string[ ]|Specifies the dimensions for the KPI. Up to 14 dimensions are supported. |
|aliases|KpiAlias[ ]|Aliases for the current KPI (see below). Up to 50 aliases are supported. |
|extracts|KpiExtract[ ]|Extracts for the KPI (see below). Up to 50 extracts are supported. |
|unit|string|Measurement unit for the KPI|
|thresHolds|KpiThresholds|KPI threshold limits (see below)|
|displayName|dictionary<string, string>|Localized display name(s) for the property|
|description|dictionary<string, string>|Localized description of the KPI|
|provisioningState|string|KPI provisioning state: ["Provisioning" \| "Succeeded" \| "Expiring" \| "Deleting" \| "HumanIntervention" \| "Failed" ] \(readonly)|
|groupByMetadata|KpiGroupByMetadata[ ]|Specifies the metadata for the groupby properties (readonly, see below)|
|participantProfilesMetadata|KpiParticipantProfilesMetadata[ ]|Participant profiles (readonly, see below)|
|tenantId|string|Hub name (readonly)|
| | | |


### KpiAlias properties
|**Property**|**JSON type**|**Description**|
| --------------- | ---------- | ------------- |
|aliasName*|string|KPI alias name|
|expression*|string|Alias expression; Aliases allow using complex operation expressions as fieldnames in KPI expression; Aliases support set operations (Union, Intersect, CrossApply), date functions and string functions. <br/><br/>Example1:  ColumnName1*ColumnName2 <br/>Example2: Union(ColumnName1, ColumnName2, .. ColumnNameN) <br/>Example3: Intersect(ColumnName1, ColumnName2, .. ColumnNameN) <br/>Example4: CrossApply(ColumnName1, ColumnName2, .. ColumnNameN) <br/>Example5: CountElements(ColumnName1, ColumnName2, .. ColumnNameN) <br/>Example6: DateAdd(day, 4, date1) <br/>Example7: DateDiff (month, date1, date2) <br/>Example8: DateTimeUtcNow() <br/>Example9: StartsWith(ColumnName1, ColumnName2) <br/>Example10: Contains(ColumnName1, ColumnName2) |
| | | |


### KpiExtract properties
|**Property**|**JSON type**|**Description**|
| --------------- | ---------- | ------------- |
|extractName*|string|KPI extract name. Extracts allow using complex operation expression as fieldnames to extract information from relationship graph|
|expression*|string|KPI extract expression. <br/><br/>For KPIs on profiles: TRAVERSE(RelationshipTypeName).FILTER(ProfileFieldName == ‘Field1’).SELECT(ProfileFieldName) <br/> >For KPIs on interactions: TRAVERSE(LinkTypeName).TRAVERSE(RelationshipTypeName).FILTER(ProfileFieldname == ‘Field1’).SELECT(ProfileFieldName)<br /><br/> Example1: TRAVERSE(RelationshipTypeName).SELECT(profileFieldName) <br /> Example2: TRAVERSE(RelationshipTypeName,DEPTH(5)).SELECT(profileFieldName) <br /> Example3: TRAVERSE(RelationshipTypeName).FILTER(ProfileFieldname == ‘Field1’).SELECT(profileFieldName) <br /> Example4: TRAVERSE(RelationshipTypeName,DEPTH(2)).FILTER(ProfileFielname == ‘Field1’).SELECT(profileFieldName) <br /> Example5: TRAVERSE(LinkTypeName).TRAVERSE(RelationshipTypeName,DEPTH(2)).FILTER(ProfileFielname == ‘Field1’).SELECT(profileFieldName) <br /> <br /> The output of an extract statement is an array which can be used as extractName.profileFieldName. For example, to count the number of elements returned by an extract, use alias expression: CountElements(extractName.profileFieldName)|
| | | |

### KpiGroupByMetadata (readonly) properties
|**Property**|**JSON type**|**Description**|
| --------------- | ---------- | ------------- |
|displayName|dictionary<string, string>|Localized display name(s) for the property|
|fieldName|string|Name of the field|
|fieldType|string|Type of the field|
| | | |

### KpiParticipantProfilesMetadata (readonly) properties
|**Property**|**JSON type**|**Description**|
| --------------- | ---------- | ------------- |
|typeName|string|Name of the type|
| | | |


### KpiThresholds properties
|**Property**|**JSON type**|**Description**|
| --------------- | ---------- | ------------- |
|lowerLimit|decimal*|Lower threshold limit|
|upperLimit|decimal*|Upper threshold limit|
|increasingKpi*|boolean|True if the increasing KPI values are desirable |
| | | |

<br>


## JSON example
```{json}
{
    "aliases": [{
        "aliasName": "customer",
        "expression": "CrossApply(Customers.customerName)"
    }],
    "calculationWindow": "Day",
    "entityType": "Profile",
    "entityTypeName": "BranchProfile",
    "expression": "SavingAccountBalanceField",
    "function": "Sum",
    "groupBy": "customer",
    "kpiName": "TotalSavingsKpi",
    "extracts": { "ExtractName": "Customers", "Expression": "TRAVERSE(branch_customer_relationship).SELECT(customerName)" }
    "thresHolds": {
        "increasingKpi": true,
        "lowerLimit": 5.0,
        "upperLimit": 50.0
    },
    "unit": "USD"
}
```

