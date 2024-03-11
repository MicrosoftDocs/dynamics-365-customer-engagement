---
title: Configure Copilot's draft an email feature
description: Learn how to enable the draft an email feature in Copilot to help agents draft emails faster.
author: gandhamm 
ms.author: mgandham 
ms.reviewer: kfend 
ms.topic: how-to 
ms.collection: bap-ai-copilot
ms.date: 04/01/2024
ms.custom: bap-template 
---

# Configure Copilot's draft an email feature

Agents can draft emails faster with Copilot. Copilot provides predefined or custom prompts to draft responses, refine the response using the multiturn experience, adjust the length and the tone of the response, and translate the response to the customer's language.

Agents can use the draft an email experience either in the Copilot features side pane or in the rich text editor. Based on your geographical location, these features are enabled by default. If the features are not enabled, you can enable them by following the steps in the sections below.

## Enable draft an email in the side pane

1. Use one of the following navigation options:
      - **Agent Experience** > **Productivity** > **Copilot help pane**
      - **Operations** > **Insights** > **Copilot help pane**
1. Select **Manage** in **Copilot help pane**. The **Copilot help pane** page appears. 
1. Switch the **Email Copilot for sidecar** toggle to **On**.
1. Select **Save**.

## Enable draft an email in the rich text editor

1. In [Power Apps](https://make.powerapps.com/), select the environment that contains your solution.
1. Select **Apps** and then select the required app.
1. Select **Settings** and then select **Upcoming**.
1. Switch the **Turn on Write an email in the experience** toggle to **On**.


## Modify the fields used to draft emails

Copilot uses the following out-of-the-box case fields to draft emails:

- Case Title
- Case Description
- Customer Contact
- Subject
- Case Notes
- Email Content

In Customer Service admin center, go to **Copilot help pane** and perform the steps in the [Modify the fields used to generate case summaries](copilot-map-custom-fields.md#modify-the-fields-used-to-generate-case-summaries) section to modify the source fields that Copilot uses to draft emails.

> [!NOTE]
> You can't modify the Case Notes and Email Content field values that Copilot uses to draft emails.

   :::image type="content" source="../media/copilot-email-conv-mini.png" alt-text="Screenshot of the data attributes that copilot email  uses" lightbox="../media/copilot-email-conv.png":::