---
title: Enable Copilot to draft emails 
description: Learn how to enable the draft an email feature in Copilot to help agents draft emails faster.
author: gandhamm 
ms.author: mgandham 
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: bap-ai-copilot
ms.date: 11/28/2024
ms.custom: bap-template 
---

# Enable Copilot to draft emails 

Agents can draft emails faster with Copilot. Agents can draft emails in the Copilot side pane or inline from the rich text editor. 

## Prerequisites

- [Enable data movement across regions](/power-platform/admin/geographical-availability-copilot#enable-data-movement-across-regions) in Power Platform admin center if your environment doesn't have United States, India, Australia, and United Kingdom as the geography for data processing and storage.
- [Opt in to AI terms to continue with Copilot setup](configure-copilot-features.md#opt-in-to-continue-with-copilot-setup) in Customer Service admin center.

## Region availability

The draft an email feature is enabled by default in the Copilot help pane and rich text editor by default in the United States, India, Australia, and United Kingdom. For other regions, you must perform the steps in the following sections for Copilot to assist agents with composing emails.

## Enable knowledge sources for Copilot to draft emails

By default, the option to use knowledge sources to draft emails is disabled. If you want Copilot to use knowledge articles or trusted websites to draft emails, you must [enable knowledge sources for Copilot](copilot-enable-help-pane.md#enable-knowledge-base).


## Enable draft an email in the rich text editor

For your agents to use the write an email feature inline in the rich text editor, do the following steps:

1. In [Power Apps](https://make.powerapps.com/), select the environment that contains your solution.
1. In **Apps**, select the required app to enable the Copilot control in the rich text editor.
1. Select **Settings** and then select **Features**.
1. Switch the **Contextual email drafting with AI** toggle to **Yes**.
1. Select **Save**.

### Rich text editor version support

The Copilot control for rich text editors is available only for version two of the rich text editor.

## Enable write an email in the side pane

To enable your agents to use the write an email feature from the Copilot side pane, perform the following steps in Customer Service admin center:

1. Go to **Copilot for questions and emails** using one of following options:
      - **Agent Experience** > **Productivity** 
      - **Operations** > **Insights**
1. Select **Manage** in **Copilot help pane**. The **Copilot help pane** page appears. 
1. Switch the **Write an email - Help pane** toggle to **On**.
1. Select **Save**.

### Modify the fields used to draft emails

You can modify the source case fields that Copilot uses to draft emails and improve the context and accuracy of the results. You can also select a custom field that Copilot uses to generate responses.

Copilot uses the following out-of-the-box case fields to draft emails:

- Case Title
- Case Description
- Customer Contact
- Subject
- Case Notes
- Email Content

In Customer Service admin center, go to **Copilot for questions and emails** and then select **Manage data**. The steps to modify the source fields that Copilot uses to draft emails are like the steps to modify the fields used to generate case summaries. Learn more in [modify the fields used to generate case summaries](copilot-map-custom-fields.md#modify-the-fields-used-to-generate-case-summaries).

> [!NOTE]
> - You can modify the source fields that Copilot uses to draft emails in the Copilot help pane only and not in the rich text editor.
> - You can't modify the Case Notes and Email Content field values that Copilot uses to draft emails.

## Next Step

[Write an email with Copilot](../use/use-copilot-email.md)

### Related information

[Understand Copilot language support](../use/copilot-language-support.md)  
[Manage copilot features in Customer Service](../administer/configure-copilot-features.md)   
[FAQ for Copilot in Customer Service](../administer/faq-copilot-features.md)    
[Responsible AI FAQ for copilot features](../implement/faq-responsible-ai-copilot.md)   
