---
title: FAQs about Sales Copilot in Dynamics 365 Sales
description: This article includes frequently asked questions about Sales Copilot in Dynamics 365 Sales, covering aspects such as privacy, data security, data management, and more.
author: lavanyakr01 # GitHub alias
ms.author: lavanyakr
ms.topic: concept-article
search.app: salescopilot-docs
ms.date: 09/21/2023
---


# FAQs about Sales Copilot in Dynamics 365 Sales

This article includes frequently asked questions about Sales Copilot in Dynamics 365 Sales.

## How does the data flow between Dynamics 365 and Azure OpenAI endpoints?

When you type a question in the Copilot pane, we pass the relevant data to Azure OpenAI Service through our plug-ins and services. We'll release a high-level architecture document around the GA timeframe.

## Does Sales Copilot have abuse monitoring and human review?

No. Our Azure OpenAI resources have opted out of [abuse monitoring and human review](/legal/cognitive-services/openai/data-privacy#how-can-customers-get-an-exemption-from-abuse-monitoring-and-human-review). This helps us ensure that we don't retain any of your data outside the Dynamics 365 data boundary. We use other techniques to monitor and filter out abusive content at runtime.

## What data is included in the requests?

The data included in the requests varies based on the type of request made. For example, when you attempt to summarize an opportunity, the relevant fields of the opportunity and associated metadata are pushed to the Azure OpenAI endpoint to generate a summary.

## Is any of my data stored outside of Dynamics 365?

No, we don't save any of your data in any new data store. You can read more about the [Azure OpenAI data and privacy commitments](/azure/ai-services/openai/faq#data-and-privacy).

## How does Sales Copilot encrypt data?

All data exchanges in Sales Copilot are handled according to [Microsoft data management guidelines](https://www.microsoft.com/trust-center/privacy/data-management).

## What privacy controls apply to the data received by Azure OpenAI Service?

All data continues to be handled according to [Microsoft privacy guidelines](/compliance/assurance/assurance-privacy). You can read more about the Azure OpenAI data and privacy commitments at [Data and Privacy](/azure/ai-services/openai/faq#data-and-privacy).

## Where are the Azure OpenAI endpoints hosted?

Currently, the Azure OpenAI resources are only available in the North America and Europe regions. If your Dynamics 365 environment is in any other geography, your data will be moved outside of your geography to handle Sales Copilot requests. You'll be prompted to consent to this data movement when you enable Sales Copilot. More information: [Sales Copilot data movement](sales-copilot-data-movement.md)

## Do you use my company data to train any of the models?

No. We don't use any customer data to train Azure OpenAI or any other language models.

## What's the difference between Microsoft Sales Copilot and Sales Copilot in Dynamics 365 Sales?

Microsoft Sales Copilot is a seller experience application that's available in Microsoft 365 and Microsoft Teams applications. It lets sellers capture, access, and update CRM data from within Microsoft 365 and Microsoft Teams applications. It also has generative AI capabilities such as record summarization and email content generation. Microsoft Sales Copilot works with Dynamics 365 Sales and Salesforce CRM. [Learn more about Microsoft Sales Copilot](/microsoft-sales-copilot/introduction). 

Sales Copilot in Dynamics 365 Sales refers to the AI assistant that uses generative AI to summarize opportunities and leads, and generate meeting preparation notes. It's integrated with Dynamics 365 Sales apps. [Learn more about Sales Copilot in Dynamics 365 Sales](copilot-overview.md).
