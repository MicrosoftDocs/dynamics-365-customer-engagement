---
title: FAQ for work order creation in Outlook using Copilot in Field Service (Preview)
description: This FAQ provides information about the AI technology used in the Dynamics 365 Field Service (Preview) Outlook add-in, along with key considerations and details about how the AI is used, how it was tested and evaluated, and any specific limitations.
ms.date: 08/01/2023
ms.custom: 
  - responsible-ai-faqs
ms.topic: article
author: KishorIoT
ms.author: nandab
ms.reviewer: v-wendysmith@microsoft.com
---

# FAQ for work order creation in Outlook using Copilot in Field Service (Preview)

This FAQ describes the AI impact of the Dynamics 365 Field Service (Preview) Outlook add-in using copilot to create work orders feature.

## What is work order creation in Outlook using Copilot?

This AI-powered feature is designed to accelerate the creation of work orders based on the emails received by frontline managers from their customers. The manager can then review, revise, and save the new work order, helping them to quickly create and move to the next steps in assisting their customers.

## What are the system’s capabilities?

The system parses the contents of an email thread and uses that information to populate fields in the work order form, including generating a summary for the work order description field.

## What is the system’s intended use?

The intention is to aid front-line workers in creating work orders at scale in less time and with less manual effort. This capability completes many fields and details required to create work orders based on the email content and service account details.

## How was work order creation in Outlook using Copilot evaluated? What metrics are used to measure performance?

{TBD}

## What are the limitations of work order creation in Outlook using Copilot? How can users minimize the impact of the Outlook work order creation limitations when using the system?

- The email body length can't exceed 15788 characters.
- Customized work order create forms aren't supported.
- Non-English summaries during work order creation aren't supported.
- Autofill of all relevant fields in the work order creation might not occur.

## What operational factors and settings allow for effective and responsible use of the system?

1. Users are reminded that AI-generated content can be inaccurate both above the form and within the description box.

1. Users are prompted to review the AI-generated content before saving.

## See also

- [Create a work order in Outlook using Copilot in Field Service (Preview)](flw-outlook.md#create-a-work-order-in-outlook-using-copilot-in-field-service-preview)
- [FAQs for Dynamics 365 Field Service](responsible-ai-overview.md)