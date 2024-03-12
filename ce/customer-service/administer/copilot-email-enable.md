---
title: Enable Copilot to draft emails 
description: Learn how to enable the draft an email feature in Copilot to help agents draft emails faster.
author: gandhamm 
ms.author: mgandham 
ms.reviewer: kfend 
ms.topic: how-to 
ms.collection: bap-ai-copilot
ms.date: 04/01/2024
ms.custom: bap-template 
---

# Enable Copilot to draft emails 

Agents can draft emails faster with Copilot. You can enable agents to use Copilot to draft emails in the Copilot side pane or inline from the rich text editor. 

## Prerequisites

- [Enable data movement across regions](/power-platform/admin/geographical-availability-copilot#enable-data-movement-across-regions) in Power Platform admin center if your environment doesn't have United States, India, Australia, and United Kingdom as the geography for data processing and storage.
- [Opt in to AI terms to continue with Copilot setup](configure-copilot-features.md#opt-in-to-continue-with-copilot-setup) in Customer Service admin center.

## Regional availabilty

The draft an email feature is available in the Copilot help pane and rich text by default in the United States, India, Australia, and United Kingdom. You don't have to enable the draft an email feature in these regions. For other regions, you must perform the steps in the following sections for Copilot to assist agents with composing emails.

## Enable knowledge sources for Copilot to draft emails

By default, using knowledge sources to draft emails is disabled. If you want Copilot to use knowledge articles or trusted websites to draft emails, you must [enable knowledge sources for Copilot](copilot-enable-help-pane.md#enable-knowledge-base). 


## Enable draft an email in the rich text editor

For your agents to use the write an email feature inline in the rich text editor, do the following steps:

1. In [Power Apps](https://make.powerapps.com/), select the environment that contains your solution.
1. In **Apps**, select the required app to enable the Copilot control in the rich text editor.
1. Select **Settings** and then select **Upcoming**.
1. Switch the **Turn on write an email in the email experience** toggle to **Yes**.
1. Select **Save**.

## Enable write an email in the side pane

To enable your agents to use the write an email feature from the Copilot side pane, perform the following steps in Customer Service admin center:

1. Use one of the following navigation options:
      - **Agent Experience** > **Productivity** > **Copilot help pane**
      - **Operations** > **Insights** > **Copilot help pane**
1. Select **Manage** in **Copilot help pane**. The **Copilot help pane** page appears. 
1. Switch the **Email Copilot for sidecar** toggle to **On**.
1. Select **Save**.

### Modify the fields used to draft emails

You can modify the source case fields that Copilot uses to draft emails, thereby improving the context and accuracy of the results. You can also select a custom field that Copilot should use to generate responses.

Copilot uses the following out-of-the-box case fields to draft emails:

- Case Title
- Case Description
- Customer Contact
- Subject
- Case Notes
- Email Content

In Customer Service admin center, go to **Copilot help pane** and perform the steps in the [Modify the fields used to generate case summaries](copilot-map-custom-fields.md#modify-the-fields-used-to-generate-case-summaries) section to modify the source fields that Copilot uses to draft emails.

> [!NOTE]
> - You can modify the source fields that Copilot uses to draft emails only in the Copilot help pane. You can't modify the source fields that Copilot uses to draft emails in the rich text editor.
> - You can't modify the Case Notes and Email Content field values that Copilot uses to draft emails.
