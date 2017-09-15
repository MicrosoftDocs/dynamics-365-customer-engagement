---
title: Prediction Type Definition (Microsoft Dynamics 365 for Customer Insights) | MicrosoftDocs
description: Represents the outcome of a machine learning analysis.
keywords: Customer Insights; type; predictive analysis; prediction
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 06/28/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 98986c28-da82-4236-86d4-a158f3920700
---

Prediction Type Definition
=========================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

A Prediction represents the outcome of a machine learning model analysis on a data set. 

## Prediction Properties
Property names appended with asterisks* are required.

|**Property**|**JSON type**|**Description**|
| --------------- | ---------- | ------------- |
|predictionName*|string|Name of the prediction|
|displayName|dictionary<string,string>|Localized display names for the link|
|description|string|Localized description of the link|
|tenantId|string|Name of the owning hub (readonly)|
|involvedInteractionTypes|string[ ]|Interaction types involved in the prediction|
|involvedKpiTypes|string[ ]|KPI types involved in the prediction|
|involvedRelationships|string[ ]|Relationships involved in the prediction|
|negativeOutcomeExpression*|string|Negative outcome expression|
|positiveOutcomeExpression*|string |Positive outcome expression|
|primaryProfileType*|string |Primary profile type|
|provisioningState|string|["Provisioning" \| "Succeeded" \| "Expiring" \| "Deleting" \| "HumanIntervention" \| "Failed" ]|
|scopeExpression*|string|Scope expression|
|autoAnalyze*|boolean|True if analysis is automatically performed; otherwise false|
|scoreLabel*|string|Score label|
|mappings*|{string score, string grade, string reason}[ ]|Link mapping definitions for the prediction|
|grades|{string gradeName, integer minScoreThreshold, integer maxScoreThreshold}[ ]|Grades defined for this prediction|
|systemGeneratedEntities|{string generatedInteractionTypes[ ], string generatedLinks[ ], generatedKpis<string,string>}|System generated entities|
| | | |
