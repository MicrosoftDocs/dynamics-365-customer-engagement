---
title: "Set up a multilingual bot in Power Virtual Agents | MicrosoftDocs"
description: "Use this article to learn how to set up a multilingual bot in Power Virtual Agents to use in Omnichannel for Customer Service."
ms.date: 08/24/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
---

# Set up a multilingual bot in Power Virtual Agents for contact center

You can configure routing rules to route voice calls to appropriate agents based on the language that your customer has selected. A multilingual contact center helps you serve global customers who want to interact with your contact center in the language of their choice. You can also set up bots as the first contact who can handle such requests.

Use Bot Framework Composer in Power Virtual Agents to set up a bot for a multilingual contact center.

The process for setting up the multilingual bot in Power Virtual Agents is as follows:

1. Create a bot in Power Virtual Agents.

2. Create a topic in Bot Framework Composer.

3. Configure the greeting topic in Power Virtual Agents.

4. Configure the transfer to agent node by using the escalate topic.

5. Configure workstreams and queues.

6. Verify the multilingual bot.

## Prerequisites

- You must install Bot Framework Composer locally on the computer that you'll use to configure the multilingual bot.
- Your bot must be registered in the Azure app registration page. Note the application ID. More information: [Create an app registration](/azure/digital-twins/how-to-create-app-registration-portal#create-the-registration)

## Create a bot in Power Virtual Agents

You'll create a bot in Power Virtual Agents by selecting the environment in which Omnichannel for Customer Service is configured. For detailed instructions, go to [Create a bot](/power-virtual-agents/authoring-first-bot).

For example, you can create a bot with the following details:

- **Name**: A descriptive name for the bot, such as **Greeter bot**.
- **Language**: The primary language for the bot, such as **English (US)**.
- **Environment**: The environment where Omnichannel for Customer Service is configured, such as **contoso-printers**.

## Create a topic in Bot Framework Composer

1. In Power Virtual Agents, for the bot that you created, select **Topics** in the site map, and then in the **Topics** pane, select the dropdown arrow for **New topic**. A message appears stating that the application is trying to open Bot Framework Composer. For more information on how to navigate the Bot Framework Composer, see: [Tutorial: Create a weather bot with composer](/composer/tutorial-create-weather-bot).

1. Select **Open**, and on the **Import your bot to new project** dialog that appears, enter the following details:

   - **Name**: A name for the project, such as **Multilingual bot**.
   - **Location**: Select a folder on the computer.

1. In Bot Framework Composer, select **More commands** (...), select **Add a dialog**, and enter the following details:

   - **Name**: A name such as **PVA greeter dialog**.
   - **Description**: A brief description. 

1. In the site map, select **BeginDialog**, select the **Add** (+) node, and then select **Send a response**.

   1. In the **Bot responses** section, select the **Add** (+) node, and then select **Speech**.

   1. Select **Add alternative**, and then add the following text.

      `<speak version="1.0" xmlns="http://www.w3.org/2001/10/synthesis" xml:lang="en-US"><voice name="en-US-AriaNeural"><lang xml:lang="en-US">Hello ${virtualagent.msdyn_CustomerName}. Welcome to contoso customer support.</lang></voice></speak>`

      > [!NOTE]
      > The ${virtualagent.msdyn_CustomerName} variable will provide the customer name for authenticated customers only through record identification. More information: [Identify customers automatically](record-identification-rule.md)

   1. Select the **Add** (+) node in **BeginDialog**, point to **Ask a question**, and then select **Multi-choice**.

      :::image type="content" source="media/pva-ask-question.png" alt-text="Select the multiple-choice option for asking a question.":::

   1. Repeat steps a and b to add the following text.

      `<speak version="1.0" xmlns="http://www.w3.org/2001/10/synthesis" xml:lang="en-US"><voice name="en-US-AriaNeural"><lang xml:lang="en-US">Press or say 1 for English.</lang><break strength="medium"/><lang xml:lang="fr-FR"> Appuyez ou dites 2 pour le français.</lang><break strength="medium"/><lang xml:lang="pt-PT">Pressione 3 para português.</lang></voice></speak>`

   1. Select the **User input** box, and enter the following details on the rightmost pane:

      - **Property**: conversation.language_choice
      - **Array of choices**: 1, 2, 3, one, two, three, un, deux, trois, um, dois, três
       
      In **Array of choices**, specify one choice per expression.

     :::image type="content" source="media/pva-framework-setup.png" alt-text="Set calues for an Array of choices.":::
     
   f. Select the **Add** (+) node, select **Create a condition**, and then select **Branch Switch (multiple options)**. Enter the following details:

      - **Condition**: conversation.language_choice
      - **Value**: 1, 2, 3, One, Two, Three, Un, deux, trois, Um, dois, três   
       
        Enter one choice per value.
     
   g. Select the **Add** (+) node and then select **Manage properties** > **Set a property** and enter the following details:

      - **Condition**: virtualagent.va_CustomerLocale
      - **Value**: en-US   
      
     Repeat the steps to **Set a property** for fr-FR, pt-PT, hi-IN.

     :::image type="content" source="media/va-customer-locale.png" alt-text="Set customer locale by using the branch switch option.":::

      The value for the virtualagent.va_CustomerLocale variable will be updated with the language selected by the customer.

      > [!NOTE]
      > You must set the va_CustomerLocale context variable with the locale codes for the languages that you want to support. More information: [Supported locations and locale codes](voice-channel-region-availability.md#supported-languages-and-locale-codes)

   h. Select the **Add** (+) node, and then select **Begin a Power Virtual Agent topic**.

   i. In **Dialog name**, select **Escalate**.

1. In the site map, select **Publish**, and then select **Publishing profile**.

   1. Select **Edit**, and then select **Login to proceed**.

   1. Select the environment and bot, and then select **Save**.

   1. Select the **Publish** bot, select the bot, and then select **Publish selected bots**.

   1. Select **Okay** .

1. In Power Virtual Agents, refresh **Topics**. You'll see the topic listed.

2. Select **Publish**. 

## Configure the greeting topic in Power Virtual Agents

1. In Power Virtual Agents, open the **Greeting** topic in the authoring canvas, and delete all the default messages except the trigger phrases.

1. Select **Add node** (+), and then select **Redirect to another topic**.

1. Select the greeter dialog that you created, which is, **PVA greeter dialog** in our example.

1. Save the **Greeting** topic.

<a name="configure-transfer-to-agent-using-the-escalate-topic"></a>

## Configure the transfer to agent node by using the escalate topic

1. In Power Virtual Agents, open the **Escalate** topic in the authoring canvas, and delete all the default messages except the trigger phrases.

1. Select **Add node** (+), select **End the conversation**, and then select **Transfer to agent**.

1. Optionally, in **Private message to agent**, enter the following to fetch the preferred language of the customer.

   `Customer preferred language is {x} bot.va_CustomerLocale`

1. Save the topic.

1. In the site map under **Manage**, select **Channels**, and then select **Microsoft Teams** on the **Channels** page.

1. Publish the bot with the latest content.

1. In the site map under **Manage**, select **Agent transfers**, and then select **Omnichannel** on the **Agent transfers** page.

1. On the Omnichannel pane, configure the following settings:
    - **Enable voice**: Set to **Yes**.
    - **See the environment this bot is connected to**: Select the environment in which the bot will be used.
    - **Application ID**: Enter the application ID that was generated when you registered the app in Azure.
  
1. Select **Add your bot**.

1. After the bot is connected, select **View details in Omnichannel**. The Omnichannel admin center page opens on a new tab and displays the details of the bot.

1. Note the bot user information that you'll need for further configuration steps.

## Configure workstreams and queues

Use the information in the following articles to configure a voice workstream and a voice queue, and their routing rules.

- [Configure a workstream](create-workstreams.md)
- [Configure work classification](configure-work-classification.md)
- [Configure a queue](queues-omnichannel.md)
- [Configure assignment methods](configure-assignment-rules.md)

For example, ensure the following settings:

1. Configure three voice queues—one each for English, French, and Portuguese—and add the required agents.

1. Configure a voice workstream with English as the primary language, and French and Portuguese as additional languages.

    :::image type="content" source="media/multilingual-workstream.png" alt-text="Workstream with multiple language options set.":::

1. In the route to queues rule set of the workstream, use **Conversation.CustomerLanguage** as the criteria to route the incoming call to different language queues based on the option that's selected by the customer.

    :::image type="content" source="media/multilingual-route-to-queue-rules.png" alt-text="Route-to-queue rules for the multilingual contact center workstream":::

1. In the **Bot** area of the workstream, edit to add the Power Virtual Agents bot that you configured.

## Verify the multilingual bot

1. As a customer, call the number that's registered with the voice workstream.

1. When you're prompted with an interactive voice response (IVR) message, select a language. Verify that the bot routes the call to an agent who can speak with you in the language that you've selected.

### See also


[Set up a multilingual contact center](voice-channel-multi-language-contact-center.md)  
[Integrate a Power Virtual Agents bot](configure-bot-virtual-agent.md)  
