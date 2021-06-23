---
title: "Sample: Send an email using a template (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This sample shows how to send an email message by using a template using the SendEmailFromTemplateRequest message"
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
  - sample for sending email messages, activity entities
  - activity entities samples, sending email messages
ms.assetid: d5e9b6e6-abf1-4d27-bed0-df2cd1006487
caps.latest.revision: 25
author: JimDaly
ms.author: nabuthuk
manager: kvivek
search.audienceType: 
  - developer

---
# Sample: Send an email using a template

This sample shows how to send an email message by using a template using the [SendEmailFromTemplateRequest](/dotnet/api/microsoft.crm.sdk.messages.sendemailfromtemplaterequest?view=dynamics-general-ce-9) message. You can download the sample from [here](https://github.com/Microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/SendEmailUsingTemp).

[!include[cc-sample-note](includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## What this sample does

The `SendEmailFromTemplateRequest` message is intended to be used in a scenario where it contains data that is needed to send an email message using a template.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

1. Checks for the current version of the org.
2. Creates a contact record to send an email to (To: field).

### Demonstrate

1. The `ActivityParty` creates the `From:`  and `To:` activity party for the email.
2. Creates an email message.
3. The `QueryExpression` queries to get one of the email template of type `Contact`.
4. The `SendEmailFromTemplateRequest` sends an email message by using a template.

### Clean up

Display an option to delete the sample data that is created in [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]