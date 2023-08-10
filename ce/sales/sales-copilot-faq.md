---
title:       FAQs about Sales Copilot in Dynamics 365 Sales
description: Includes frequently asked questions about Dynamics 365 Sales Copilot, covering various aspects such as privacy, data security, data management, and more.
author:      lavanyakr01 # GitHub alias
ms.author:    lavanyakr
ms.topic:    concept
ms.date:     07/27/2023
---

# FAQs about Sales Copilot in Dynamics 365 Sales

This article includes frequently asked questions about Sales Copilot in Dynamics 365 Sales.

## How does the data flow between Dynamics 365 and Azure Open AI endpoints?

When you type a question in the Copilot pane, we pass the relevant data to Azure Open AI through our plugins and services. We'll release a high-level architecture document around the GA timeframe.

## Does Sales Copilot have abuse monitoring and human review?

No. Our Azure Open AI resources have opted out of [abuse monitoring and human review](/legal/cognitive-services/openai/data-privacy#how-can-customers-get-an-exemption-from-abuse-monitoring-and-human-review). This helps us ensure that we don't retain any of your data outside the Dynamics 365 data boundary. We use other techniques to monitor and filter out abusive content at runtime.

## What data is included in the requests?

The data included in the requests varies based on the type of request made. For example, when you attempt to summarize an opportunity, the relevant fields of the opportunity and associated metadata are pushed to the Azure Open AI endpoint to generate a summary.

## Is any of my data stored outside of Dynamics 365?

No, we don't save any of your data in any new data store. You can read more about the [Azure Open AI data and privacy commitments](/azure/ai-services/openai/faq#data-and-privacy)

## How Sales Copilot encrypts data?

All data exchanges in Sales Copilot are handled according to [Microsoft data management guidelines](https://www.microsoft.com/trust-center/privacy/data-management).

## What privacy controls apply to the data received by the Azure Open AI service?

All data continues to be handled according to [Microsoft privacy guidelines](/compliance/assurance/assurance-privacy). You can read more about the Azure Open AI data and privacy commitments [here](/azure/ai-services/openai/faq#data-and-privacy).

## Where are the Azure Open AI endpoints hosted?

Currently, the Azure Open AI resources are available in North America and Europe. If your Dynamics 365 environment is in any of these two regions, all requests are routed to your geo's endpoint. For all other geos, your requests will be routed to the following endpoints, if you enable Sales Copilot:

- Requests from the United Kingdom (UK), Norway, Germany, France, and China are routed to the Europe endpoint. 
- Requests from all the other regions are routed to the North America endpoint.

More information: [Dynamics 365 Sales Copilot data movement](sales-copilot-data-movement.md).

## Do you use my company data to train any of the models?

No. We don't use any customer data to train Azure Open AI or any other Large Language Models.
