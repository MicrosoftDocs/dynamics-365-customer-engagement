---
title: Configure general settings for the Sales Qualification Agent
description: Configure the Sales Qualification Agent's general settings, including agent profile, company details, and product information, to set the context for the agent.
ms.date: 08/01/2025
ms.topic: how-to
ms.service: dynamics-365-sales
ms.custom: bap-template
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Configure general settings for the Sales Qualification Agent

Define the agent profile, company information, and product information to set the context for the Sales Qualification Agent.

## Configure the agent profile

1. [Open the Sales Qualification Agent settings](open-sales-qualification-agent-settings.md) page.

1. In the **Agent profile** section, provide the following information:
   - **Agent name**: Specify a meaningful name for the agent. 

   - **Agent description**: Specify a brief description of the agent's purpose and the leads it will handle.
   - **Agent user**: Select the [agent app user you created for the agent](configure-requirements-for-sqa-agent.md#create-an-app-user-in-dataverse-and-assign-aisalesperson-role). This user account is used to perform all the agent tasks such as owning leads, handing over leads, sending emails, and accessing data.

1. (Applicable for Research and engage mode) If you're configuring the Research and engage mode, provide the following additional information to customize the agent's email communication:
   - **Email signature**: Enter the email signature that the agent will use when sending emails to leads. This signature will be appended to the end of each email sent by the agent. Select **Modify signature** to open the Email signature editor, where you can format the signature text and add links or images.
   - **AI disclaimer**: Enter a disclaimer that will be included in the emails sent by the agent. This disclaimer informs recipients that the email is sent by an AI agent and not a human. Work with your legal team to ensure the disclaimer meets your organization's requirements.
   - **Other terms**: Enter any other terms that the agent should include in its communications with leads. This could include terms of service, privacy policy links, or any other relevant information.

## Configure company information

The agent uses company information to generate personalized outreach emails and engage with your customers. Be sure to provide a real company name and website to ensure that the research insights and outreach emails are relevant.

1. Under **General Settings** > **Company info**, provide the following details:

   - **Company name**: Enter the name of your company.

   - **Company website**: Enter the URL of your company's website.

## Configure product information

The agent uses product information to generate suggestions during hand over and to provide relevant product details in outreach emails. 

1. Under **General Settings** > **Products**, enter the value proposition of your products or services, highlighting their key benefits and features. This information helps the agent tailor its research and generate relevant outreach emails and follow-up email. It's also used to auto-generate [handoff criteria](configure-sales-qualification-agent-handoff-criteria.md) later in the setup.

## Next step

[Configure selection criteria](sales-qualification-agent-selection-criteria.md)

## Related information

[Configure the Sales Qualification Agent](configure-sales-qualification-agent.md)