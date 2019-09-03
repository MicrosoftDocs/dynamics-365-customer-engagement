---
title: "Attach skill to an incoming conversation | MicrosoftDocs"
description: "Learn about how to attach skills to an incoming conversation in Omnichannel for Customer Service app." 
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 10/15/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 44298261-18A8-438C-923A-4BB4D18406F9
ms.custom: 
---

# Attach skill to incoming conversation

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

## Understand skill and context variables

In the portal, when the customer fills the pre-chat survey questions, the system receives these as context variables. The omnichannel system attaches these variables to the incoming conversation as a skill, and then the work distribution engine matches the skills of the agents based on the exact or closest match criteria. Once the skill attached to the conversation matches with the skill of an agent, then the work distribution engine assigns the conversation to that agent.

For example:

Ian Madera, a customer from Spain, uses **Xbox** product and goes to **www.contoso.com** portal to initiate a chat with the Contoso contact center. The pre-chat survey question prompts Ian Madera to choose a product, and Ian Madera chooses **Xbox**. As Ian Madera's geolocation is Spain, the Omnichannel system attaches the **Xbox** product and **Spanish** language as the skill to the conversation. After the skill attachment, the work distribution engine assigns the conversation to an agent finds an agent with skill as **Xbox** and **Spanish**.

## Prerequisites

To attach skills, you need a workstream record. Either you can create or use an existing workstream configuration. 

## Attach skill

1. Sign in to the **Omnichannel for Administrator** app.

2. Select **Work Streams** under **Work Distribution Management**.

3. Select a work stream from the list.

4. Select the **Skill Attach** tab.

5. Select **+ Add** to new a skill rule.

6. Specify the following in the **New Skill Rule** page.

    | Field | Description | Value |
    |--------|----------|-------------------|
    | Name | Provide a name to the skill rule. | Xbox product and Spanish language |
    | Description | Provide a description about the skill rule. | This is a skill matching rule for Xbox product and Spanish language. |

7. Set up the condition. <br> For example, **Hardware** equals **Xbox** and **Geolocation** equals **Spain**.

8. Select **+ Add Existing Skill**. The **Lookup Records** pane appears.

9. Select a skill from the lookup menu, and select a proficiency level from the list, and then select **Add**.

    If the responses of the pre-chat survey matches with condition, then the Omnichannel system attaches the skill.

10. Select **Save**.