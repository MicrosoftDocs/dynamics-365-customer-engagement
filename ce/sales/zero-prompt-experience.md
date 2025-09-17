---
title: Configure zero prompt experience for Copilot in Dynamics 365 Sales (preview)
description: Learn how to configure the zero prompt experience for Copilot in Dynamics 365 Sales.
ms.date: 09/17/2025
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.date: 09/17/2025
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Configure zero prompt experience for Copilot in Dynamics 365 Sales (preview)

The zero prompt experience helps you enhance user engagement and streamline interactions at the start of a Copilot chat session. The zero prompt experience helps users quickly access relevant information and actions related to their work and reduces the need for additional prompts and iterations. The zero prompt experience can be context aware and hence, can be selectively shown for targeted pages.

> [!NOTE]
>- Customizing the zero prompt experience for Copilot in Dynamics 365 Sales involves a different process compared to customizing the experience for the [Power Platform bots](/power-apps/maker/model-driven-apps/copilot-chat-zpe-guide).
>- The customization is only supported for the `Conversation Start` topic in English language.

:::image type="content" source="media/copilot-zero-prompt-experience.png" alt-text="Screenshot of the zero prompt experience card in Copilot in Dynamics 365 Sales.":::

## Configure the zero prompt experience

Follow these steps to customize the zero prompt experience for Copilot in Dynamics 365 Sales:

1. In [Copilot Studio](https://copilotstudio.microsoft.com/), go to **Agents** and select the **Copilot in Dynamics 365 Sales** agent.
1. Go to **Topics** and open **Conversation Start Topic**.
1. Scroll to the bottom of the topic and locate the section where the Adaptive Card is defined.  
   :::image type="content" source="media/topic-adaptive-card.png" alt-text="Screenshot of the section where the Adaptive Card is defined.":::
1. Double-click on the Adaptive Card to open it for editing.

  - Add, update, or remove the `Container` nodes as needed.
  - Ensure that any `Action` nodes follow the same schema as the existing ones.
  - Ensure that all changes adhere to the existing schema for `selectedAction` to avoid runtime errors.
1. Save the topic.
1. Select **Test** to verify the changes made to the card.  
    :::image type="content" source="media/test-adaptive-card.png" alt-text="Screenshot of Copilot displaying updated zero prompt experience card.":::
1. Select **Publish** to publish the changes.


## Sample Code for Conversation Start customization

The sample code includes customization to the `Conversation Start` topic for the zero prompt experience. This example adds a new prompt to the card "Redmond Accounts".

The following changes are made to the existing code:

- A new variable named `Topic.AccountScenario` is added to hold the account scenario.
- A variable named `Topic.AccountScenarioPayload` is added to hold the payload for the account scenario.
- The Adaptive Card is updated to include the new scenario and its payload.

```yaml
kind: AdaptiveDialog
beginDialog:
    kind: OnConversationStart
    id: main
    actions:
        - kind: SetTextVariable
          id: setTextVariable_uV3wX4
          variable: Topic.GetLatestNewsForAccounts
          value: Get latest news for accounts
        - kind: SetTextVariable
          id: setTextVariable_yZ9aB0
          variable: Topic.WhatsNewlyAassignedToMe
          value: What's newly assigned to me
        - kind: SetTextVariable
          id: setTextVariable_eF5gH6
          variable: Topic.PrepareForSalesAppointments
          value: Prepare for sales meetings
        - kind: SetTextVariable
          id: setTextVariable_yZ5aB6
          variable: Topic.Hi
          value: Hi
        - kind: SetTextVariable
          id: setTextVariable_cD7eF8
          variable: Topic.WelcomeMessage
          value: Welcome to Copilot. Select one of the suggestions below to get started.
        - kind: SetTextVariable
          id: setTextVariable_7buPHx
          variable: Topic.EmptyWelcomeMessage
          value: Welcome to Copilot.
        - kind: SetTextVariable
          id: setTextVariable_gH9iJ0
          variable: Topic.MenuForMoreSuggestions
          value: Use "View Prompts" for more suggestions.
        - kind: SetTextVariable
          id: setTextVariable_sT5uV6
          variable: Topic.GetInfo
          value: Get info
        - kind: SetTextVariable
          id: setTextVariable_wX7yZ8
          variable: Topic.AskQuestions
          value: Ask questions
        - kind: SetVariable
          id: setVariable_x6BNry
          variable: Topic.AccountScenario
          value: "={skillType: \"PromptTextSkill\", optionGroup: \"Redmond Accounts!\", prompt: \"What are the accounts located in Redmond?\" }"
        - kind: SetVariable
          id: setVariable_x33Nry
          variable: Topic.AccountScenarioPayload
          value: "={action: \"MS.PA.SalesAccountNews\", forActivityId: \"\", text: \"\", toolInput: \"{\"\"entity\"\": \"\"account\"\"}\", actionPayload: \"{\"\"entity\"\": \"\"account\"\"}\", type: \"followUpSuggestion\"}"
        - kind: SetTextVariable
          id: setTextVariable_F1eG2
          variable: Topic.StayAhead
          value: Stay ahead
        - kind: SetTextVariable
          id: setTextVariable_F1eGH
          variable: Topic.Prompt
          value: Prompt
        # ... (rest of the dialog actions)
```

