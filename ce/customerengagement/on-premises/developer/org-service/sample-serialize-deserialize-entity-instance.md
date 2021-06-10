---
title: "Sample: Serialize and deserialize an entity Instance (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This sample shows how to serialize early-bound and late-bound entity instances into an XML format, and how to de-serialize from an XML format to an early-bound entity instance"
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
  - samples for early-bound classes, serializing and deserializing entities sample
  - sample for serializing and deserializing entities
  - serializing and deserializing entities sample, early-bound class samples
  - early-bound class samples, serializing and deserializing entities sample
ms.assetid: 705f78dc-c392-4ca7-bc48-0ed3fc687a6f
caps.latest.revision: 20
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Sample: Serialize and deserialize an entity Instance

This sample shows how to serialize early-bound and late-bound entity instances into an XML format, and how to de-serialize from an XML format to an early-bound entity instance.

You can download the sample from [here](https://github.com/microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/SerializeDeserializeEntity).

[!include[cc-sample-note](../includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](../includes/cc-how-to-run-PA-samples.md)]

## What this sample does

The `DataContractSerializer` message is intended to be used in a scenario where it Serializes and deserializes an instance of a type into an XML stream or document using a supplied data contract. This class cannot be inherited.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

1. Checks for the current version of the org.
1. The `CreateRequiredRecords` method creates required sample data for the sample.

### Demonstrate

1. The `DataContractSerializer` method serializes the contact records into XML and write it to the hard drive. 
1. The `earlyBoundSerializer` method deserializes the entity instance.

### Clean up

Display an option to delete the records created in the [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.




[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]