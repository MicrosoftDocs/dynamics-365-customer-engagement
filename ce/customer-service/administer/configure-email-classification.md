---
title: Configure email classification in Dynamics 365 Customer Service 
description: Learn how to configure email classification settings to help you control how emails are processed in Dynamics 365 Customer Service for improved efficiency.
author: lalexms
ms.author: laalexan
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: bap-ai-copilot
ms.update-cycle: 180-days 
ms.date: 03/06/2026
ms.custom: bap-template
---

# Configure email classification in Dynamics 365 Customer Service

Email classification helps you categorize incoming emails by using AI so you can control how emails are processed in Dynamics 365 Customer Service. You can use classification to reduce unnecessary case creation, improve routing, and limit downstream automation to relevant emails.

## Overview

Organizations receive many types of incoming email, including support requests, billing questions, partner inquiries, and general notifications. Email classification helps you use AI to understand the intent of each message so you can process it consistently—creating and routing cases when appropriate, and applying automation only where it adds value.

Email classification analyzes the content of incoming emails and assigns each message to a configured category. You can then use that category to determine how the email is handled—for example, whether a case is created, how the case is routed, or whether additional automation applies.

## Prerequisites

- You have the **System administrator** or **Customer Service administrator** role.
- Email-to-case is configured in your environment.
- AI features are enabled.
- You have planned the categories you want to use for classification.

## How email classification works

Email classification assigns a category to incoming emails based on content. You define the categories, specify which emails are evaluated, and enable classification so that emails are categorized automatically.

### Define email categories

You define custom categories that represent how emails should be handled, such as Billing, Marketing, or Support.

Consider the following when defining categories:

- You must configure at least two categories.
- You can configure up to 30 categories.
- Each category includes a name and description to help the AI understand classification intent.

### Scope classified emails

Because email classification uses AI resources, you can control which emails are evaluated by defining conditions.

For example, you can choose to classify only:

- Emails sent to specific mailboxes
- Emails associated with specific departments

You configure a single condition, which can contain multiple AND clauses.

### Enable email classification

After you configure categories and conditions, you enable email classification. Incoming emails that meet the configured conditions are automatically analyzed and a category is assigned.

## Use classification categories

The category assigned to an email is stored as an attribute and can be used across Customer Service features.

### Deflect nonsupport emails

You can prevent certain categories of emails from creating cases. For example, you can exclude emails classified as Marketing from case creation to reduce unnecessary SLAs and manual processing.

### Route emails by intent

You can use email categories in routing rules to route emails to the appropriate queues or customer service representatives based on email content instead of static keywords or sender rules.

### Control downstream automation

You can reference email categories in:

- Routing rules
- Automatic Record Creation (ARC) rules
- Case creation logic

This lets you control whether additional automation or AI-based processing runs for specific email categories.

## Important considerations

- Email classification always assigns one of the configured categories to an evaluated email, even if the email content doesn't clearly match any category.
- If you configure only two categories (for example, Billing and Marketing), every email is classified as either Billing or Marketing, even if the email is unrelated.
- To handle unrelated or ambiguous emails, consider adding a catch-all category, such as **Uncategorized**.
- Depending on your configuration, customer service representatives might be able to manually update the email category.

## Next steps

After you configure email classification, you can use the assigned category in your existing Customer Service workflows.

- Configure case routing rules to route or exclude cases based on email category. Learn more in [Configure case routing rules](create-rules-automatically-route-cases.md).
- Use unified routing to incorporate email categories into classification and assignment logic across channels. Learn more in [Use unified routing](overview-unified-routing.md).
- Control automatic case creation by combining email classification with record creation rules. Learn more in [Control automatic case creation](automatically-create-case-from-email.md).
