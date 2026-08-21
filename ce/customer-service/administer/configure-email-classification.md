---
title: Configure email classification in Customer Service 
description: Learn how to configure email classification settings to help you control how emails are processed in Dynamics 365 Customer Service for improved efficiency.
author: lalexms
ms.author: laalexan
ms.reviewer: mgandham
ms.topic: how-to 
ms.date: 08/21/2026
ms.collection: bap-ai-copilot
ms.update-cycle: 180-days
---

# Configure email classification in Customer Service

Email classification helps you categorize incoming emails by using AI so you can control how emails are processed in Dynamics 365 Customer Service. You can use classification to reduce unnecessary case creation, improve routing, and limit downstream automation to relevant messages.

## Overview

Organizations receive many types of incoming email, including support requests, billing questions, partner inquiries, and general notifications. Email classification helps you use AI to analyze the content each message so you can process it consistently—creating and routing cases when appropriate, and applying automation only where it adds value.

Email classification analyzes the content of incoming emails and assigns each message to a configured category. You can then use that category to determine how the email is handled—for example, whether a case is created, how the case is routed, or whether other automation applies.

Configure email classification in the Copilot Service admin center app, under **Email settings**.

## Prerequisites

- [Pay-as-you-go billing](/copilot/microsoft-365/pay-as-you-go/overview) is enabled for your environment.
- You have the **System Administrator** or **CSR Manager** security role.

## How email classification works

Configuring email classification involves five high-level tasks:

1. Define email categories and subcategories that represent the types of messages your organization receives.
1. Specify which incoming emails to evaluate by setting scope conditions.
1. Choose when qualifying emails are classified, and then enable email classification.
1. Run a simulation to test the configuration against historical email and refine the taxonomy.
1. Use the assigned email category in downstream processes, such as routing rules or automatic case creation.

## Define custom categories and subcategories

Define a custom taxonomy of categories and subcategories that represents how your organization handles emails, such as **Billing**, **Marketing**, or **Support**.

Consider the following criteria when defining the taxonomy:

- You must configure at least two categories.
- You can configure up to 20 categories at the top level. Each category can have up to 10 subcategories at each level, and the hierarchy can contain up to four levels. For example: **Billing** > **Payments** > **Failed payments** > **Credit card**.
- Each category includes a name and description.
- Create a hierarchy by assigning each subcategory to the category directly above it.
- Use distinct, actionable category names and descriptions.
- Consider adding a catch-all category, such as "Uncategorized", for email that doesn't clearly match another category.

### Add a category or subcategory

1. In Copilot Service admin center, go to **Email settings** > **Email classification**, and then select **Manage**.
1. In **Define taxonomy**, select **+ Add**.
1. In the **Add category** pane, enter the category name and description.
1. Select whether the category is active or inactive.
1. To create a subcategory, in **Parent**, select the category directly above it in the hierarchy. Leave **Parent** empty to create a top-level category.
1. Select **Save**.

## Scope classified emails

Because email classification uses AI resources, you can control which emails are evaluated by defining conditions.

1. In Copilot Service admin center, go to **Email settings** > **Email classification**, and then select **Manage**.
1. Under **Choose which emails to categorize**, select **Manage rule**.
1. Add a condition that identifies the emails to classify. For example, you can classify emails sent to specific mailboxes or associated with specific departments.
1. Select **Save and close**.

You can create one condition with multiple clauses. An email must meet all the clauses to be classified.

## Choose when to classify emails

Under **Choose when to categorize emails**, select one of the following options:

- **As soon as they arrive**: Automatically classifies qualifying incoming emails.
- **In your own customization using API**: Allows your custom automation to control when emails are classified. After you select this option, configure your customization to call the `msdyn_EmailClassificationCustomAction` Dataverse action. Learn more in [Use the email classification custom action](../develop/use-email-classification-custom-action.md).

## Enable email classification

1. In Copilot Service admin center, go to **Email settings** > **Email classification**, and then select **Manage**.
1. Under **Enable feature**, select **Turn on email classification**.
1. Select **Save and close**.

## Run a simulation for email classification

Run a simulation to test how AI classifies historical email. You can use the results to review predicted categories and explanations, measure accuracy when expected categories are provided, and refine the taxonomy before applying changes to incoming email.

### Create and run a simulation

1. On the email classification page, select **Go to simulation**.
1. Enter a name for the simulation, such as **July emails**.
1. Select a data source, and then complete the corresponding action:
   - If you select **Excel Upload**, upload an `.xlsx` or `.xls` file. The file can contain up to 50 records and must be no larger than 1 MB. The first row must contain column headers, with the columns in this order:
     1. Email subject
     1. Email body
     1. Expected category (optional)
     
     When you include expected categories, the simulation results include an accuracy percentage.

   - If you select **Organization records**, use the condition builder to select email records, such as all emails from the previous week.
1. Select **Run simulation**.

The time required to complete a simulation depends on the volume of email being evaluated.

### Review simulation results

When the simulation is complete, select the **Simulation result** tab, and then select **View**. The results show the predicted category and the reason for each prediction. You can download the results as an Excel workbook to share them for review.

### Rerun a simulation

After you add, edit, or remove categories or update category descriptions, rerun the simulation to compare the results and determine whether the revised configuration improves classification.

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

- Routing rules.
- Automatic record creation and update rules.
- Case creation logic.

## Important considerations

- Email classification always assigns one of the configured categories to an evaluated email, even if the email content doesn't clearly match any category.
- If you configure only two categories (for example, Billing and Marketing), every email is classified as either Billing or Marketing, even if the email is unrelated.
- Depending on your configuration, service representatives might be able to manually update the email category.
- When you use a hierarchical taxonomy, ensure that category and subcategory names and descriptions clearly distinguish each branch.

> [!TIP]
> Rerun a simulation after you change the taxonomy to review the classification results before you use the updated configuration with incoming email.

## Next steps

After you configure email classification, you can use the assigned category in your existing Customer Service workflows.

- Use the email classification custom action to classify email records in custom integrations. Learn more in [Use the email classification custom action](../develop/use-email-classification-custom-action.md).
- Configure case routing rules to route or exclude cases based on email category. Learn more in [Configure case routing rules](create-rules-automatically-route-cases.md).
- Use unified routing to incorporate email categories into classification and assignment logic across channels. Learn more in [Use unified routing](overview-unified-routing.md).
- Control automatic case creation by combining email classification with record creation rules. Learn more in [Control automatic case creation](automatically-create-case-from-email.md).
