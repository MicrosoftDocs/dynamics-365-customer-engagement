---
title: Write scripts to implement complex business logic
description: Learn about best practices when implementing custom scripts in Dynamics 365 Field Service.
ms.date: 06/24/2024
ms.topic: how-to
author: lmasieri
ms.author: lmasieri
---

# Write scripts to implement complex business logic

Some implementations of Dynamics 365 Field Service include functionality and complex business logic that go beyond the processes that Field Service offers out of the box. Sometimes, these complexities extend even beyond the platform options, such as workflows and business rules. For complex requirements, developers can create custom code.

Implementing complex business logic typically involves writing [plugins](/power-apps/developer/data-platform/plug-ins) on the server side and [JavaScript web resources](/dynamics365/customerengagement/on-premises/developer/clientapi/client-scripting?view=op-9-1&preserve-view=true) on the client side.

This article explores these best practices:

- Before you write any scripts, research existing Field Service processes and capabilities.
- Avoid writing scripts when possible. First try to use platform options such as Power Automate and workflows instead.
- Run scripts asynchronously instead of synchronously.
- Avoid loading scripts when a form is loaded. Instead, load them only when they are needed.
- Run solution checker on scripts.
- Don't edit or delete existing form libraries.

## Types of scripts

### Plugins

Plugins provide a way to write your own custom functionality on top of Microsoft's event-driven Dynamics 365 platform for almost any process that you can imagine. Plugins act as event handlers and are registered to run on a specific event in Dynamics 365. Plugins are written in either C# or Visual Basic, and they can run in either synchronous mode or asynchronous mode.

Custom plugins can help:

- Run some business logic, such as updating specific fields of a record or updating related records when you create or update a Dynamics 365 record.
- Call an external web service on specific events, such as when a record is saved or updated.
- Dynamically calculate field values when any record is opened.
- Automate processes, such as sending emails to your customers on specific events in Dynamics 365.

### JavaScript web resources

JavaScript provides one way to apply custom business process logic to show data on a form in Dynamics 365. In the context of Field Service, developers might add JavaScript to the work order and booking forms to enforce business logic. They might also add JavaScript to the schedule board to create booking rules that perform validations when a booking is created on the schedule board.

## Step 1. Understand the risks of writing custom scripts

Use caution when you add plugins and JavaScript to your Field Service implementation. Too many scripts and poorly written scripts are the leading causes of poor performance and errors. Write scripts only if the customization is critical to running your Field Service operation.

Thoroughly read this article and related content before, while, and after you write and implement scripts.

## Step 2. Check if Field Service or Dynamics 365 can meet the requirement

Before you write a plugin or JavaScript web resource, be sure to check whether Field Service or another Dynamics 365 app can perform the same function or a similar function. Duplicate processes can cause errors and performance issues.

## Step 3. Try using platform options first

Before you write a custom script, try to meet your requirement by using platform options such as Power Automate, workflows, and business rules. 

If you can't meet your requirement by using platform options, decide whether a workflow can get close enough to help your business. Platform options are more scalable, more supportable, less likely to break during upgrades, and better for performance.

To learn more about how to use platform options, go to [When to use plug-ins vs. workflow?](/dynamics365/customerengagement/on-premises/developer/best-practices-sdk?view=op-9-1&preserve-view=true#when-to-use-plug-ins-vs-workflow)

## Step 4. Review best practices before writing plugins or scripts

Many best practices were established from experience with developers across thousands of Dynamics 365 implementations. Review the following best practices before and while you write plugins or scripts:

- [Best practices and guidance regarding plug-in and workflow development for the Microsoft Dataverse](/power-apps/developer/data-platform/best-practices/business-logic/)
- [Best practices and guidance for client-side scripting for model-driven apps](/power-apps/developer/model-driven-apps/best-practices/business-logic/)
- [Best practices for developing with Dynamics 365 Customer Engagement](/dynamics365/customerengagement/on-premises/developer/best-practices-sdk?view=op-9-1&preserve-view=true)
- [JavaScript customization](/power-apps/maker/model-driven-apps/design-performant-forms#javascript-customization)
- [Scalable Customization Design in Microsoft Dataverse](/power-apps/developer/data-platform/scalable-customization-design/overview)

## Step 5. Use tools to test your scripts

After you write scripts, you must test them.

First, [use solution checker to validate your model-driven apps in Power Apps](/power-apps/maker/data-platform/use-powerapps-checker). Solution checker identifies whether the scripts violate best practices such as running [synchronously instead of asynchronously](/dynamics365/customerengagement/on-premises/developer/best-practices-sdk?view=op-9-1&preserve-view=true#when-to-use-plug-ins-vs-workflow).

Next, use [plugin profiler](/power-apps/developer/data-platform/tutorial-debug-plug-in?tabs=prt) to debug issues.

## Form libraries

Many Field Service record types, such as work orders (shown in the following image), have JavaScript form libraries that are included by default with Field Service. These libraries perform important processes.

> [!IMPORTANT]
> Don't edit or delete form libraries.

:::image type="content" source="media/customization-form-libraries.png" alt-text="Screenshot showing form libraries for the work order form in Power Apps.":::

## JavaScript on the schedule board (booking rules)

Booking rules provide a way to use JavaScript to perform validations on the schedule board. However, as when you use JavaScript on other forms, such as work orders, proceed with caution. Don't create more than one booking rule. Instead, consider using [booking alerts](booking-alert.md) to alert dispatchers about issues.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
