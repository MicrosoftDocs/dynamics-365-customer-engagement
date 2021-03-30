---
title: "Sample: Create an email using a template| MicrosoftDocs"
description: "This sample shows how to instantiate an email record by using the InstantiateTemplateRequest message"
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 4a17a1b0-c111-4575-ae70-802b79a2c6ae
caps.latest.revision: 17
author: JimDaly
ms.author: nabuthuk
manager: kvivek
search.audienceType: 
  - developer

---
# Sample: Create an email using a template

This sample shows how to instantiate an email record by using [InstantiateTemplateRequest](/dotnet/api/microsoft.crm.sdk.messages.instantiatetemplaterequest?view=dynamics-general-ce-9) message. You can download the sample from [here](https://github.com/Microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/EmailTemplate). 

[!include[cc-sample-note](includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-samples.md)]

## What this sample does

The `InstantiateTemplateRequest` message is intended to be used in a scenario where it instantiates an email record.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

1. Checks for the current version of the org.
1. Creates an account record. 
2. Defines the body and subject of the email template in **XML** format.
3. Creates an email template.

### Demonstrate

1. The `InstantiateTemplateRequest` message is used to create an email message using a template. 
2. Serialize the email message to **XML** and save to a file.


### Clean up

Display an option to delete the record created in [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]