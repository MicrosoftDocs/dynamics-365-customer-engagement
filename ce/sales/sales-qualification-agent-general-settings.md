---
title: Configure general settings for the Sales Qualification Agent
description: Learn how to activate and set up the Sales Qualification Agent in Dynamics 365 Sales to help your sellers use AI for effective lead qualification.
ms.date: 07/31/2025
ms.topic: how-to
ms.service: dynamics-365-sales
ms.custom: bap-template
author: udaykirang
ms.author: udag
ms.reviewer: udag
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Configure general settings for the Sales Qualification Agent

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Define the agent profile, company information, and product information to set the context for the Sales Qualification Agent.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Configure the agent profile

1. [Open the Sales Qualification Agent settings](open-sales-qualification-agent-settings.md) page.

1. In the **Agent profile** section, provide the following information:
   - **Agent name**: Specify a meaningful name for the agent. 

   - **Agent description**: Specify a brief description of the agent's purpose and the leads it will handle.
   - **Agent user**: Select the agent app user that you created for the agent. This user will be used to run the agent and access data.

1. (Engage Agent only) If you're configuring the **Engage** agent, provide the following additional information to customize the agent's email communication:
   - **Email signature**: Enter the email signature that the agent will use when sending emails to leads. This signature will be appended to the end of each email sent by the agent. Select **Modify signature** to open the Email signature editor, where you can format the signature text and add links or images.
   - **AI disclaimer**: Enter a disclaimer that will be included in the emails sent by the agent. This disclaimer informs recipients that the email is sent by an AI agent and not a human. Work with your legal team to ensure the disclaimer meets your organization's requirements.
   - **Other terms**: Enter any other terms that the agent should include in its communications with leads. This could include terms of service, privacy policy links, or any other relevant information.


## Configure company information

The agent uses company information to generate personalized outreach emails and engage with your customers. Be sure to provide a real company name and website to ensure that the research insights and outreach emails are relevant.

1. [Open the Sales Qualification Agent settings](open-sales-qualification-agent-settings.md) page.

1. In the **Company info** section, provide the following details:

   - **Company name**: Enter the name of your company.

   - **Company website**: Enter the URL of your company's website.

## Configure product information

The agent uses product information to generate suggestions during hand off and to provide relevant product details in outreach emails. 

1. [Open the Sales Qualification Agent settings](open-sales-qualification-agent-settings.md) page.

1. In the **Products** section, enter the value proposition of your products or services, highlighting their key benefits and features. This information helps the agent understand what to emphasize when engaging with leads.