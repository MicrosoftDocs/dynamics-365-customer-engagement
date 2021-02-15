---
title: "Sample: Send an email (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This sample shows how to send an email SendEmailRequest message"
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
ms.assetid: c95bec08-bdd2-420a-93aa-ee7c0f20fa16
caps.latest.revision: 18
author: JimDaly
ms.author: nabuthuk
manager: kvivek
search.audienceType: 
  - developer

---
# Sample: Send an email

This sample shows how to send an email using [SendEmailRequest](https://docs.microsoft.com/dotnet/api/microsoft.crm.sdk.messages.sendemailrequest?view=dynamics-general-ce-9) message. You can download the sample from [here](https://github.com/Microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/SendEmail).

[!include[cc-sample-note](includes/cc-sample-note.md)]

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## What this sample does

The `SendEmailRequest` message is intended to be used in a scenario where it contains data that is needed to send an email message.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

1. Checks for the current version of the org.
1. The `Contact` method creates a contact to send an email to `(To: field)`.
1. The `WhoAmIRequest` method gets the current user information to send the email `(From: field)`.
1. The `ActivityParty`method creates  `To` and `From` activity party for the email.
1. The `Email` method creates an email message.

### Demonstrate

The `SendEmailRequest` method sends an email message created in the [Setup](#setup).

### Clean up

Display an option to delete the records created in the [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]