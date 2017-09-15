---
title: PredictionTrainingResults Type Definition (Microsoft Dynamics 365 for Customer Insights) | MicrosoftDocs
description: Training results of the predictive analysis
keywords: Customer Insights; type; predictive analysis; prediction model status
author: Milar1
ms.author: v-milar
manager: jdaly
ms.date: 06/28/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 98986c28-da82-4236-86d4-a158f3922700
---

PredictionTrainingResults Type Definition
=====================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

PredictionTrainingResults represents the model training results of the predictive analysis.

## Properties

Property names appended with asterisks* are required.

### PredictionTrainingResults Properties

|**Property**|**JSON type**|**Description**|
| --------------- | ---------- | ------------- |
|tenantId|string|Name of the owning hub (readonly)|
|scoreName|string|Name of the score (readonly)|
|primaryProfileInstanceCount|integer|Instance count of the primary profile (readonly)|
|predictionDistribution|PredictionDistributionDefinition|Definition of the prediction distribution (see below)|
|canonicalProfiles|CanonicalProfileDefinition[ ]|Definition of the canonical profiles (see below)|
| | | |

<br>

### PredictionDistributionDefinition Properties

|**Property**|**JSON type**|**Description**|
| --------------- | ---------- | ------------- |
|totalPositives|integer|Total positive in the distribution|
|totalNegatives|integer|Total negatives in the distribution|
|distributions|{integer scoreThreshold, integer positives, integer negatives, integer positivesAboveThreshold, integer negativesAboveThreshold}[ ]|Definitions of a prediction distributions|
| | | |

<br>

### CanonicalProfileDefinition Properties

|**Property**|**JSON type**|**Description**|
| --------------- | ---------- | ------------- |
|CanonicalProfileId|string|Canonical profile identifier|
|properties|{string profileName, string profilePropertyName, integer rank,  string type, string value}[ ]|Definitions of the canonical profile properties, where **type**: [Numeric \| Categorical \| DerivedCategorical \| DerivedNumeric] |
| | | |

