---
title: Sales Hub app versus custom app
description: Learn when to use the Sales Hub app or a custom app.
ms.date: 04/26/2022
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
---

# Sales Hub app versus custom app

Sales Hub is a Microsoft first-party app that's designed around the sales processes that most organizations follow. If your organization has unique selling processes, you can customize the Sales Hub app or create a custom app from scratch. Use the following table to help you decide when to use Sales Hub and when to create a custom app:
<!-- Please change the title/H1 and all references to it to "Sales Hub or a custom app?" or "Sales Hub versus a custom app" -->

| **Factors to consider** | **Sales Hub** | **Custom app** |
| --- | --- | --- |
| **Time to value and ROI** | Faster time to value and greater ROI as the app is available right after setting up the product.| Slower start as the custom app has to be built from scratch. |
| **Accessibility and adaptability** | Built in, and the UI adapts to multiple devices | The customer's responsibility |
| **Navigate to forms, entities, and views right after purchasing the product** | Start using the app almost instantly with out-of-the-box forms, entities, and views | If the out-of-the-box objects don't serve your purpose, custom forms, entities, and views must be created |
| **Time and expertise required** | Minimal | Extensive experience and time required to plan, develop, test, and implement |
| **App maintenance** | Microsoft takes responsibility for maintenance, and all updates are tested for quality and performance before deployment | The customer is responsible for evaluating, testing, and implementing new features |
| **Customizations**  | Customizations aren't overwritten by updates | The customer has full control of customizing the app, including navigation and user experience |
| **New feature availability** | Instant | Adding UI elements and controls required for new features is solely the customer's responsibility, and some new features may not be available immediately |

## When to customize the Sales Hub app and when to create custom app
<!-- Please change this heading to "...and when to create a custom app" -->

Every sales implementation has unique considerations that influence the application strategy.

Customize first-party apps such as Sales Hub when:

- your organization follows standard sales practices with the need for little to no customization

- you want to combine specific components and processes from two or more first-party apps, such as Sales Hub and Customer Service Hub

In the second case, assess which application is primary for the persona it caters to. For example:

- For a salesperson, who needs to access all the sales module components and the customer assets entity from the customer service module, include the customer assets entity in Sales Hub.

- For a customer service manager, who needs to access the case management module and the opportunities pipeline, include the opportunity entity in Customer Service Hub.

Create a custom app when:

- you want an app for roles that fall outside of the sales org. Examples include senior executives, who just need to see Power BI dashboards and a handful of entities, or an audit supervisor, who only needs to see won opportunities.

- your organization has a custom sales process, and the built-in sales module doesn't meet your needs

- you've created many custom entities and you want to remove all or many of the built-in components

- you want to build a solution that combines multiple work streams and isn't focused on Sales Hub or Customer Service

- you want to keep the application lean without many of the built-in first-party components

## How Sales Hub app releases handle customizations

To help make sure that app updates don't overwrite Sales Hub customizations:

- Microsoft automatically pushes weekly updates that contain bug fixes and performance improvements.

- Microsoft doesn't automatically push weekly updates that can occasionally contain new features or UI-disruptive updates. Instead, they're isolated behind an admin toggle. Administrators can test whether an update affects customization, and then turn it on when they're ready.

- Quarterly releases that have new and innovative features have an early access period. It’s important for all customers to test and validate their applications and core use cases on the new build.

- Updates to the Sales Hub site map or objects such as forms, entities, and views don't overwrite any customizations that you've made to these items. Instead, the changes are merged. For more information, see:

    - [Understand how managed solutions are merged](/power-platform/alm/how-managed-solutions-merged)
    - [Best practices and guidance for developers](/power-apps/developer/data-platform/best-practices/)

## How to revert changes to Sales Hub app
<!-- Please change the heading to "...changes to the Sales Hub app" or "...changes to Sales Hub" -->

You can't automatically revert changes to the Sales Hub app. You have to manually undo them.

For example, let's say you've removed an entry (such as Cases) from the site map and you want to add it back. You have to manually add the entry to the sitemap. For more information, see [Customize the app](manage-app.md#customize-the-app).

### See also

- [Use the Sales Hub app to access Dynamics 365 Sales features](intro-saleshub.md)
- [Build your first model-driven app](/power-apps/maker/model-driven-apps/build-first-model-driven-app)
