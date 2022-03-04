---
title: "Set up a multilanguage Power Virtual Agents bot | MicrosoftDocs"
description: "Use this topic to learn how to set up a multilanguage Power Virtual Agents bot in Omnichannel for Customer Service."
ms.date: 02/25/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---

# Set up a multilanguage Power Virtual Agents bot for contact center

## Introduction

To be able to service global customers who want to interact with your contact center in a language of their choice, you can configure routing rules to route the calls to appropriate agents based on the language your customer selects. You can also set up bots as the first contact who can handle such requests.

The process for setting up the multilanguage Power Virtual Agents bot is as follows:

1. Create a bot in Power Virtual Agents

1. Create a topic in Bot Framework Composer

1. Invoke the topic in Power Virtual Agents

1. Configure transfer to agent using escalate topic

1. Configure workstreams and queues

1. Verify the flow

## Create a bot in Power Virtual Agents

You'll create a bot in Power Virtual Agents by selecting the environment in which Omnichannel for Customer Service is configured. More information: [Create a bot](/power-virtual-agents/authoring-first-bot).

For example, you can create the bot with the following details:

- **Name**: *<bot name>*, such as **Greeter bot**.
- **Language**: *<primary language for the bot>*, such as **English (US)**.
- **Environment**: *<environment name where Omnichannel for Customer Service is configured>*, such as **contoso-printers**.

## Create a topic in Bot Framework Composer

You must install the Bot Framework Composer locally on the computer that you'll use to configure the multilanguage bot.

**To create a topic**

1. In Power Virtual Agents, for the bot that you created, select **Topics** on the site map, and then select the dropdown arrow for **New topic** in the **Topics** pane. A message appears stating that the application is trying to open the Bot Framework Composer.

1. Select **Open**, and on the Import your bot to new project dialog that appears, enter the following details:

   - **Name**: A name for the project, such as "Multilanguage bot".
   - **Location**: Select a folder location on the computer. 

1. In Bot Framework Composer, select **More commands** (...), select **Add a dialog**, and enter the following details.

   - **Name**
   - **Description** 

1. In the site map, select **BeginDialog**, select the **Add** (+) node, and then select **Send a response**.

   1. In the **Bot responses** section, select the **Add** (+) node, and then select **Speech**.

   1. Select **Add alternative**, and then add the following text.

      `<speak version="1.0" xmlns="http://www.w3.org/2001/10/synthesis" xml:lang="en-US"><voice name="en-US-AriaNeural"><lang xml:lang="en-US">Hello ${virtualagent.msdyn_CustomerName}. Welcome to contoso customer support.</lang></voice></speak>`

      > [!NOTE]
      > The ${virtualagent.msdyn_CustomerName} variable will provide the customer name for authenticated customers only through record identification.

   1. Select the **Add** (+) node in **BeginDialog**,  select **Ask a question**, and then select **Multi-choice** in the floating menu.

      :::image type="content" source="media/pva-ask-question.png" alt-text="Select a multi-choice option for ask a question.":::
   
   1. Repeat the steps a and b to add the following text.

      `<speak version="1.0" xmlns="http://www.w3.org/2001/10/synthesis" xml:lang="en-US"><voice name="en-US-AriaNeural"><lang xml:lang="en-US">Press or say 1 for English.</lang><break strength="medium"/><lang xml:lang="fr-FR"> Appuyez ou dites 2 pour le français.</lang><break strength="medium"/><lang xml:lang="pt-PT">Pressione 3 para português.</lang></voice></speak>`

   1. Select the **User input** box, and enter the following details in the right pane:

    - **Property**: conversation.language_choice
    - **Array of choices**: 1, 2, 3, one, two, three, un, deux, trois, um, dois, três

    1. Select the the **Add** (+) node, select **Create a condition**, and then select **Branch Switch (multiple options)**.
       
        - **Condition**: conversation.language_choice
        - **Value**: 1, 2, 3, 4, Opne, Two, Three, Un, deux, trois, Um, dois, três