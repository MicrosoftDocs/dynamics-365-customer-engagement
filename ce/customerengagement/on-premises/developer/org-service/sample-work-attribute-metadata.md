---
title: "Sample: Work with attribute metadata (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The sample shows how to perform various actions on attributes."
keywords: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 377198f5-ac08-40e1-a727-f3ac51e7a01e
author: JimDaly
ms.author: nabuthuk
manager: kvivek
search.audienceType: 
  - developer

---

# Sample: Work with attribute metadata

This sample shows how to perform various actions on attributes. You can download the sample from [here](https://github.com/microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/WorkWithAttributes).

[!include[cc-sample-note](../includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](../includes/cc-how-to-run-PA-samples.md)]

## What this sample does

This sample shows how to create different types of attributes in Dataverse.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

Checks for the current version of the org.

### Demonstrate

1. The `BooleanAttributeMetadata` method creates an attribute of type boolean.
2. The `DateTimeAttributeMetadata` message creates an attribute of type date time.
3. The `DecimalAttributeMetadata` message creates an attribute of type decimal.
4. The `IntegerAttributeMetadata` message creates an attribute of type integer.
5. The `MemoAttributeMetadata` message creates an attribute of type memo.
6. The `MoneyAttributeMetadata` message creates an attribute of type money.
7. The `PicklistAttributeMetadata` message creates an attribute of type picklist.

### Clean up

Displays an option to delete all the data created in the sample. The deletion is optional in case you want to examine the data created by the sample. You can manually delete the data to achieve same results.

[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]