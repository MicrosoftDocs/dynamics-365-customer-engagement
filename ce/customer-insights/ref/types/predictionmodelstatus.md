---
title: PredictionModelStatus Type Definition (Microsoft Dynamics 365 for Customer Insights) | MicrosoftDocs
description: Status of the training model used for predictive analysis
keywords: Customer Insights; type; predictive analysis; prediction model status
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.date: 06/28/2017
ms.topic: reference
ms.service: customer-insights 
ms.assetid: 98986c28-da82-4236-86d4-a158f3921700
---

PredictionModelStatus Type Definition
=================================

[!include[pre release disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

Prediction Model Status represents the status of the machine learning training model used for predictive analysis.

## PredictionModelStatus Properties

Property names appended with asterisks* are required.

|**Property**|**JSON type**|**Description**|
| --------------- | ---------- | ------------- |
|tenantId|string|Name of the owning hub (readonly)|
|predictionName|string|Name of the associated prediction (readonly)|
|predictionGuidId|string (GUID)|ID of the associated prediction (readonly)|
|status*|string|Current point in prediction model life cycle: [New \| Provisioning \| ProvisioningFailed \| PendingDiscovering \| Discovering \| PendingFeaturing \| Featuring \| FeaturingFailed \| PendingTraining \| Training \| TrainingFailed \| Evaluating \| EvaluatingFailed \| PendingModelConfirmation \| Active \| Deleted \| HumanIntervention \| Failed] |
|message|string|Model status message (readonly)|
|trainingSetCount|integer|Count of the test set (readonly)|
|testSetCount|integer|Count of the test set (readonly)|
|validationSetCount|integer|Count of the validation set (readonly)|
|trainingAccuracy|integer|Training accuracy (readonly)|
|signalsUsed|integer|Signals used in the training (readonly)|
|modelVersion|string|Version of the model (readonly)|
| | | |

