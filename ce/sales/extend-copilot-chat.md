---
title: Customize Copilot in Dynamics 365 Sales
description: Learn how to extend Copilot in Dynamics 365 Sales to customize the welcome message, add prompts, and the prompt guide.
ms.date: 01/16/2026
ms.update-cycle: 180-days
ms.topic: how-to
ms.service: dynamics-365-sales
ms.custom: bap-template
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ai-usage: ai-assisted
---

# Customize Copilot in Dynamics 365 Sales

Customize Copilot chat to make it more intelligent and relevant for your organization. You can customize the following aspects of the Copilot chat experience in Dynamics 365 Sales:

- Add additional topics to help Copilot learn from your organization's data, content, and processes.
- Customize the prompt guide to include the most relevant prompts for your organization.
- Add glossary terms to help Copilot understand your business terms.

> [!NOTE]
>- This article applies only to Copilot in Dynamics 365 Sales. You can also customize Copilot in other model-driven apps. Learn more at [Customize Copilot chat using Copilot Studio(preview)](/power-apps/maker/model-driven-apps/customize-copilot-chat).

## Prerequisites for customization

To customize Copilot in Dynamics 365 Sales, you must have the **Copilot Studio Author** role. Contact your tenant administrator to assign the role to you in the Power Platform Admin Center. To know more about the role, see [Copilot Studio authors](/microsoft-copilot-studio/billing-licensing#copilot-studio-authors).  


## Customize Copilot using Copilot Studio (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner-section.md)]

Use a solution to manage your customizations so that you can easily deploy them across different environments. Learn more at [Create a solution in Copilot Studio](/microsoft-copilot-studio/authoring-solutions-overview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

1. Sign in to [Copilot Studio](https://copilotstudio.microsoft.com/).
1. Select your Dynamics 365 environment and then select **Agents**.
1. Select **Copilot in Dynamics 365 Sales** to customize Copilot in Dynamics 365 Sales.
1. Customize the following aspects of Copilot chat experience:

    - [Create or edit topics in Copilot Studio](/microsoft-copilot-studio/authoring-create-edit-topics). You can create new topics or edit existing topics to add more relevant data and actions specific to your organization. 
      > [!NOTE]
      >- Custom topics will be charged as per the Copilot Studio credits consumed. Learn more about capacity in [Manage consumption-based billing for agent capabilities](copilot-consumption-based-billing.md).
      >- Knowledge source isn't supported currently for Copilot in Dynamics 365 Sales.
      >- The [Image](/microsoft-copilot-studio/authoring-send-message#add-an-image) and [Video](/microsoft-copilot-studio/authoring-send-message#add-an-image) message types from agent to user aren't supported. As a workaround, you can use Adaptive Cards.
    - Edit the **SalesSparks** topic to [customize the prompt guide](/power-apps/maker/model-driven-apps/customize-copilot-chat#prompt-guide-customizations).

<a name="add-glossary"></a>

## Add glossary and synonyms to help Copilot understand your business terms

You can train Copilot in Dynamics 365 Sales to understand your business terms. Use glossary to map your business terms to columns in your tables so that sellers can seamlessly ask Copilot questions using your business terms. Use synonyms to add alternative names for columns in your tables. This helps Copilot understand different ways sellers might refer to the same data. 

Let's say that you have a custom field called **custom revenue** in the **opportunity** table that stores the estimated revenue for an opportunity. You can add **opportunity revenue** as a synonym to the **custom revenue** column in the **opportunity** table.  

**To add synonyms and glossary terms:**

1. Open [Copilot Studio](https://copilotstudio.microsoft.com) and select your Dynamics 365 Sales environment.

1. Select **Agents** > **Copilot in Dynamics 365 Sales**.
1. Under the **Knowledge** section, select **SalesSpecificQnA**.
1. Select the **Glossary** section and enter the term and description. 
1. Select the **Synonyms** section and add synonyms for the relevant columns in your tables.
1. Select **Publish** to save your changes.

## Watch videos

Watch these videos to learn more about customizing Copilot in Dynamics 365 Sales:

> [!IMPORTANT]
> The agent has been renamed to **Copilot in Dynamics 365 Sales**. However, the videos still show the old agent name **Sales Copilot Power Virtual Agent Bot**. We'll update the videos soon.

[Extending Copilot in Sales Part 1](https://www.youtube.com/watch?v=638gZ8yLCIc&t=1s)  
[Extending Copilot in Sales Part 2](https://www.youtube.com/watch?v=4u9h0OBFOiA&t=7s)  
[Extending Copilot in Sales Part 3](https://www.youtube.com/watch?v=gTaQaZ8XxJk&t=1s)   
[Extending Copilot in Sales Part 4](https://www.youtube.com/watch?v=PxUP8NLbtEY) 


## Related information

[FAQ for Copilot chat in model-driven apps](/power-apps/maker/common/faqs-copilot-model-driven-app)  
[Responsible AI FAQs for Power Apps](/power-apps/maker/common/responsible-ai-overview)  
