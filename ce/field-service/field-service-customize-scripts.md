---
title: Write scripts to implement complex business logic
description: Learn all about best practices when implementing custom scripts in Dynamics 365 Field Service.
ms.date: 06/24/2024
ms.topic: how-to
author: lmasieri
ms.author: lmasieri
---

# Write scripts to implement complex business logic

In some Field Service implementations, there are functionalities and complex business logic that go beyond the processes offered by out-of-the-box Field Service. Sometimes, these complexities even extend beyond the platform options, like workflow and business rules. For complex requirements, developers can create custom code.

Implementing complex business logic typically involves writing [plugins](/power-apps/developer/data-platform/plug-ins) on the server side and [JavaScript web resources](/dynamics365/customerengagement/on-premises/developer/clientapi/client-scripting?view=op-9-1&preserve-view=true) on the client side.  

This article explores these best practices:

- Research existing Field Service processes and capabilities before writing any scripts.
- Avoid writing scripts when possible and try using platform options like Power Automate and workflow first.
- Run scripts asynchronously instead of synchronously.
- Avoid loading scripts onload of a form and instead only load them when needed.
- Run solution checker on scripts.
- Don't edit or delete existing form libraries.

## Types of scripts

### Plugins

Plugins allow you to write your own custom functionality on top of Microsoft’s event-driven Dynamics 365 platform for just about any process you can imagine. Plugins act as event handlers and are registered to execute on a particular event in Dynamics 365. Plugins are written in either C# or Visual Basic and can run either in synchronous or asynchronous mode.

Custom plugins can help:

- Execute some business logic, such as updating certain fields of a record or updating related records when you create or update a Dynamics 365 record.
- Call an external web service on certain events, such as saving or updating a record.
- Dynamically calculate the field values when any record is opened.
- Automate processes, such as sending e-mails to your customers on certain events in Dynamics 365.

### JavaScript web resources

JavaScript is one of the ways to apply custom business process logic for displaying data on a form in Dynamics 365. In the context of Field Service, developers might add JavaScript to the work order and booking forms to enforce business logic. They might also add JavaScript to the schedule board to create booking rules that perform validations when a booking is created on the schedule board.

## Step 1: Understand the risks of writing custom scripts

Use caution when adding plugins and JavaScript to your Field Service implementation. Too many scripts or poorly written scripts is the leading cause for poor performance, and errors. Only write scripts if the customization is critical to run your Field Service operation. 

Read this article and related content thoroughly before, during, and after writing and implementing scripts.

## Step 2: Check if Field Service or Dynamics 365 can accomplish the requirement

Before writing a plugin or JavaScript web resource, make sure to check if Field Service, or another Dynamics 365 app can accomplish the same or similar function. Duplicate processes can cause errors and performance issues.

## Step 3: Try using platform options first

Before writing a custom script, try to accomplish your requirement with platform options like Microsoft Power Automate, workflows, and business rules. 

Can't fulfill your requirement with platform options? Decide if a workflow can get close enough to help your business. Platform options are more scalable, supportable, are less likely to break with upgrades, and are better for performance.

For more information on using platform options, go to [when to use plugins or workflows](/dynamics365/customerengagement/on-premises/developer/best-practices-sdk?view=op-9-1&preserve-view=true#when-to-use-plug-ins-vs-workflow).

## Step 4: Review best practices before writing plugins or scripts

Many best practices were established from experience with developers across thousands of Dynamics 365 implementations. Review the following best practices before and while writing plugins or scripts. 

- [Best practices and guidance regarding plug-in and workflow development for the Microsoft Dataverse](/power-apps/developer/data-platform/best-practices/business-logic/)
- [Best practices and guidance of client side scripting for model-driven apps](/power-apps/developer/model-driven-apps/best-practices/business-logic/)
- [Best practices for developing with Dynamics 365 Customer Engagement](/dynamics365/customerengagement/on-premises/developer/best-practices-sdk?view=op-9-1&preserve-view=true)
- [Make intelligent customizations when you use JavaScript on forms](/power-apps/maker/model-driven-apps/design-performant-forms#javascript-customization)
- [Scalable Customization Design in Microsoft Dataverse](/power-apps/developer/data-platform/scalable-customization-design/overview)

## Step 5: Use tools to test your scripts

After writing scripts, you must test them.

First, [use Solution Checker to validate your model-driven apps in Power Apps](/power-apps/maker/data-platform/use-powerapps-checker). Solution Checker identifies if the scripts violate best practices, like running [synchronously instead of asynchronously](/dynamics365/customerengagement/on-premises/developer/best-practices-sdk?view=op-9-1&preserve-view=true#when-to-use-plug-ins-vs-workflow).

Next, use [plugin profiler](/power-apps/developer/data-platform/tutorial-debug-plug-in?tabs=prt) to debug issues.

## Form libraries

Many Field Service record types, like work orders (as shown in the following image), have JavaScript form libraries that are included by default with Field Service. These libraries perform important processes.

> [!Note]
> Don't edit or delete form libraries.

:::image type="content" source="media/customization-form-libraries.png" alt-text="Screenshot of Power Apps showing form libraries for the work order form.":::

## JavaScript on the schedule board (booking rules)

Booking rules are a way of using JavaScript to perform validations on the schedule board. However, just like using JavaScript on other forms like work orders, proceed with caution. Don't create more than one booking rule. Consider instead using [booking alerts](booking-alert.md) to alert dispatchers of issues.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
