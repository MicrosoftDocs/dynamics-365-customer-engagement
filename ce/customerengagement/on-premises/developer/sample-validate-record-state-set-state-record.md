---
title: "Sample: Validate record state and set the state of the record (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "The sample demonstrates how to validate a change of state of an entity and set a state of an entity."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - setting record states sample
  - validating record states sample
  - record states, sample for validating and setting
ms.assetid: 6b2f00ca-dbac-47d8-ab4a-0be52b72f05d
caps.latest.revision: 15
author: JimDaly
ms.author: nabuthuk
manager: kvivek
search.audienceType: 
  - developer

---
# Sample: Validate record state and set the state of the record

This sample shows how to validate a change of state of an entity and set a state of an entity. You can download the sample from [here](https://github.com/microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/ValidateandExecuteSavedQuery).

[!include[cc-sample-note](includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## What this sample does

The `IsValidStateTransitionRequest` message is intended to be used in a scenario where it contains the data that is needed to validate the state transition.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

1. Checks for the current version of the org.
2. The `CreateRequiredRecords` method creates any entity records that this sample requires.

### Demonstrate

1. The `EntityReference` method creates a EntityReference to represent open case. 
2. The `IsValidStateTransitionRequest`  method sets the transition request to an open case.
3. The `checkState.NewState` property checks if a new state of resolved and a new state of problem solved are valid.
4. The `IsValidStateTransitionResponse` method executes the request.

### Clean up

Display an option to delete the sample data that is created in [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]