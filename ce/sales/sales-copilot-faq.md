---
title: FAQs about Copilot in Dynamics 365 Sales
description: This article includes frequently asked questions about Copilot in Dynamics 365 Sales, covering various aspects such as privacy, data security, data management, and more.
author: lavanyakr01 # GitHub alias
ms.author: lavanyakr
ms.topic: conceptual
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ms.date: 02/07/2024
---

# FAQs about Copilot in Dynamics 365 Sales

This article includes frequently asked questions about Copilot in Dynamics 365 Sales.

## How does the data flow between Dynamics 365 and Azure OpenAI endpoints?

When you type a question in the Copilot pane, we pass the relevant data to Azure OpenAI Service through our plug-ins and services. We'll release a high-level architecture document around the GA timeframe.

## Does Copilot have abuse monitoring and human review?

No. Our Azure OpenAI resources have opted out of [abuse monitoring and human review](/legal/cognitive-services/openai/data-privacy#how-can-customers-get-an-exemption-from-abuse-monitoring-and-human-review). This helps us ensure that we don't retain any of your data outside the Dynamics 365 data boundary. We use other techniques to monitor and filter out abusive content at runtime.

## What data is included in the requests?

The data included in the requests varies based on the type of request made. For example, when you attempt to summarize an opportunity, the relevant fields of the opportunity and associated metadata are pushed to the Azure OpenAI endpoint to generate a summary.

## Is any of my data stored outside of Dynamics 365?

No, we don't save any of your data in any new data store. You can read more about the [Azure OpenAI data and privacy commitments](/azure/ai-services/openai/faq#data-and-privacy).

## How does Copilot encrypt data?

All data exchanges in Copilot are handled according to [Microsoft data management guidelines](https://www.microsoft.com/trust-center/privacy/data-management).

## What privacy controls apply to the data received by Azure OpenAI Service?

All data continues to be handled according to [Microsoft privacy guidelines](/compliance/assurance/assurance-privacy). You can read more about the Azure OpenAI data and privacy commitments at [Data and Privacy](/azure/ai-services/openai/faq#data-and-privacy).

## Where are the Azure OpenAI endpoints hosted?

Currently, the Azure OpenAI resources are only available in the North America and Europe regions. If your Dynamics 365 environment is in any other geography, your data will be moved outside of your geography to handle copilot requests. You'll be prompted to consent to this data movement when you enable Copilot in Dynamics 365 Sales. More information: [Copilot data movement](sales-copilot-data-movement.md)

## Do you use my company data to train any of the models?

No. We don't use any customer data to train Azure OpenAI or any other language models.

## What's the difference between Microsoft Sales Copilot and Copilot in Dynamics 365 Sales?

Microsoft Sales Copilot is a seller experience application that's available in Microsoft 365 and Microsoft Teams applications. It lets sellers capture, access, and update CRM data from within Microsoft 365 and Microsoft Teams applications. It also has generative AI capabilities such as record summarization and email content generation. Microsoft Sales Copilot works with Dynamics 365 Sales and Salesforce CRM. [Learn more about Microsoft Sales Copilot](/microsoft-sales-copilot/introduction). 

Copilot in Dynamics 365 Sales refers to the AI assistant that uses generative AI to summarize opportunities and leads, and generate meeting preparation notes. It's integrated with Dynamics 365 Sales apps. [Learn more about Copilot in Dynamics 365 Sales](copilot-overview.md).

## Which applications are in the exclusion list for Copilot in Dynamics 365 Sales?

Copilot in Dynamics 365 Sales can't be turned on for the following applications:

- msdyn_FSMobile
- msdyn_FieldService
- msdyn_ResourceScheduling
- AppforOutlookModule
- Customerservicehub
- msdyn_CustomerServiceWorkspace
- OmniChannelEngagementHub
- msdyn_ProjectService

## What are the early access changes related to Copilot in 2024 release wave 1?

Some Copilot features are available for early access in the 2024 release wave 1. The following table summarizes the changes related to Copilot for early access. [Learn more about Copilot early access and enabling chat and email](enable-setup-copilot.md) features.

| Setting | Orgs in North America with early access | Orgs in North America without early access | Orgs in others regions | Additional info |
|---------|-------------|----------------|--------|-----------------|
| Settings page | New | Old | Old | The new settings page has individual toggles for chat and email. The old experience has a single toggle for Copilot. |
| Changes to Copilot setting | Retained | Retained | Retained | Any changes made to the Copilot settings prior to February 5th will be retained. |
| Chat turned on by default | Yes | Yes | No<sup>1</sup> | <sup>1</sup>Needs to be turned on manually. |
| Copilot for email turned on by default | Yes | No<sup>2</sup> | No<sup>2</sup> | <sup>2</sup>Turned on only if Copilot preview toggle is enabled. |
| Copilot in email rich text editor turned on by default | Yes | No<sup>3</sup> | No<sup>3</sup> | <sup>3</sup> Turned on only if the **Enable Copilot in Rich Text Editor (preview)** is turned on for the app in the [Power Apps settings](/power-apps/maker/canvas-apps/working-with-experimental-preview?branch=main#controlling-which-features-are-enabled). |

## Why does my tenant have Sales Copilot Power Virtual Agents Bot in Microsoft Copilot Studio? 

Sales Copilot Power Virtual Agents Bot is part of the Dynamics 365 Sales solution and is deployed to all Dynamics 365 Sales environments, irrespective of whether Copilot is enabled or not. The bot is used to authenticate and authorize Copilot in Dynamics 365 Sales only when Copilot is enabled. If you've disabled Copilot in Dynamics 365 Sales, the bot remains dormant on your environment. The bot will be updated automatically. It can't be deleted or disabled either. [Learn more about Microsoft Copilot Studio overview](/microsoft-copilot-studio/fundamentals-what-is-copilot-studio).

A related app, Sales Copilot Power Virtual Agents Bot, is also created for your tenant in Azure for authentication and authorization purposes. The app will be renewed when it's nearing expiration. We recommend that you don't delete or disable the app.
