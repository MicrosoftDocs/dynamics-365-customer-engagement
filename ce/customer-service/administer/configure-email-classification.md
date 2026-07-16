---
title: Configure email classification in Customer Service 
description: Learn how to configure email classification settings to help you control how emails are processed in Dynamics 365 Customer Service for improved efficiency.
author: lalexms
ms.author: laalexan
ms.reviewer: mgandham
ms.topic: how-to 
ms.date: 07/16/2026
ms.collection: bap-ai-copilot
ms.update-cycle: 180-days
---

# Configure email classification in Customer Service

Email classification helps you categorize incoming emails by using AI so you can control how emails are processed in Dynamics 365 Customer Service. You can use classification to reduce unnecessary case creation, improve routing, and limit downstream automation to relevant messages.

## Overview

Organizations receive many types of incoming email, including support requests, billing questions, partner inquiries, and general notifications. Email classification helps you use AI to analyze the content each message so you can process it consistently—creating and routing cases when appropriate, and applying automation only where it adds value.

Email classification analyzes the content of incoming emails and assigns each message to a configured category. You can then use that category to determine how the email is handled—for example, whether a case is created, how the case is routed, or whether other automation applies.

Configure email classification in the Customer Service admin center, under **Email settings**.

## Prerequisites

- [Pay-as-you-go billing](/copilot/microsoft-365/pay-as-you-go/overview) is enabled for your environment.
- You have the **System Administrator** or **CSR Manager** security role.

## How email classification works

Configuring email classification involves four high-level tasks:

- Define email categories that represent the types of messages your organization receives.
- Specify which incoming emails are evaluated by setting scope conditions.
- Enable email classification so incoming emails are automatically analyzed and assigned a category.
- Use the assigned email category in downstream processes, such as routing rules or automatic case creation.

### Define custom categories

Define custom categories that represent how to handle emails, such as **Billing**, **Marketing**, or **Support**.

Consider the following criteria when defining categories:

- You must configure at least two categories.
- You can configure up to nine categories.
- Each category includes a name and description.

### Scope classified emails
Because email classification uses AI resources, you can control which emails are evaluated by defining conditions.

For example, you can choose to classify only:

- Emails sent to specific mailboxes
- Emails associated with specific departments

You configure a single condition, which can contain multiple AND clauses.

### Enable email classification

After you configure categories and conditions, you enable email classification. Incoming emails that meet the configured conditions are automatically analyzed and a category is assigned.

## Add the email classification experience to the email form

Add the email classification experience to the email form so that customer service representatives (service representatives) can view AI-generated email categories, change assigned categories, and provide feedback on categorizations.

1. Open [Power Apps](https://make.powerapps.com/).
1. Open the **Email** table, and then open the email form that you want to customize.
1. In **Table columns**, locate **Email category (AI)** and drag the field onto the form where you want it to appear.
1. Select the **Email category (AI)** field.
1. Expand **Components**, and then select **+ Component**.
1. Select **Get more components**.
1. Search for **EmailClassificationControl**, and then select **Add**.
1. Select the newly added **EmailClassificationControl** component.
1. Select the clients where you want the component to appear:
   - Web
   - Mobile
   - Tablet
1. Select **Done**.
1. Save and publish the form.
1. Refresh the browser before testing the updated form.

## Use classification categories

The category assigned to an email is stored as an attribute and can be used across Customer Service features.

### Exclude emails from automatic case creation

Prevent certain categories of emails from creating cases. For example, you can exclude emails classified as **Marketing** from case creation to reduce unnecessary SLAs and manual processing.

### Route emails by category

Use email categories in routing rules to send emails to the right queues or service representatives based on what the email is about.

### Control downstream automation

You can reference email categories in:
- Routing rules
- Automatic record creation and update rules
- Case creation logic

## Important considerations

- Email classification always assigns one of the configured categories to an evaluated email, even if the email content doesn't clearly match any category.
- If you configure only two categories (for example, Billing and Marketing), every email is classified as either Billing or Marketing, even if the email is unrelated.
- To handle unrelated or ambiguous emails, consider adding a catch-all category, such as **Uncategorized**.
- Depending on your configuration, service representatives might be able to manually update the email category.

## Next steps

After you configure email classification, you can use the assigned category in your existing Customer Service workflows.

- Configure case routing rules to route or exclude cases based on email category. Learn more in [Configure case routing rules](create-rules-automatically-route-cases.md).
- Use unified routing to incorporate email categories into classification and assignment logic across channels. Learn more in [Use unified routing](overview-unified-routing.md).
- Control automatic case creation by combining email classification with record creation rules. Learn more in [Control automatic case creation](automatically-create-case-from-email.md).
