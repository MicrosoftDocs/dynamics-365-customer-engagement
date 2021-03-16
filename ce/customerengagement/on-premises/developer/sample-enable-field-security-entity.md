---
title: "Sample: Enable field security for an entity| MicrosoftDocs"
description: "The sample shows how to enable field security for an entity."
ms.custom: 
ms.date: 01/08/2020
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - field security entities sample, enabling
  - enabling field security, sample
ms.assetid: e0219990-26af-46d2-beba-f021b26021cc
caps.latest.revision: 19
author: JimDaly
ms.author: nabuthuk
manager: kvivek
search.audienceType: 
  - developer

---
# Sample: Enable field security for an entity

This sample shows how to enable field security for an entity.  You can download the sample from [here](https://github.com/Microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/FieldSecurity). 

This sample requires additional users that are not in your system. Create the required users manually in **Office 365** in order to run the sample without any errors. For this sample, create a user profile **as is** shown below. 

**First Name**: Samantha<br/>
**Last Name**: Smith<br/>
**Security Role**: Marketing Manager<br/>
**UserName**: ssmith@yourorg.onmicrosoft.com<br/>

[!include[cc-sample-note](includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## How this sample works

In order to simulate the scenario described above, the sample will do the following:

### Setup

1. Checks for the current version of the org.
2. Gets the user that you have created manually in **Office 365**.
3. Retrieve the security role needed to assign to the user. 
4. Retrieve the default business unit needed to create the team.
5. Instantiate a team entity record and set its property values. 

### Demonstrate

1. Creates field security profile and create the request object and set the monikers with the teamprofiles_assocation relationship.
2. Creates custom activity entity and attributes using the `CreateEntityRequest` and `CreateAttributeRequest` message.
3. Create the field permission for the identity attribute.

### Clean up

Display an option to delete the records in [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]