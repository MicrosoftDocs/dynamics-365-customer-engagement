---
title: "Sales Hub app versus custom app | MicrosoftDocs"
description: "Learn the scenarios when to use the Sales Hub app over a custom app and vice versa."
ms.date: 03/30/2022
ms.topic: article

author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---

# Sales Hub app versus custom app

Sales Hub is a Microsoft first-party app that's designed and configured for ideal seller experiences. The app is designed keeping in mind the sales processes followed by majority of the organizations, across domains. However, if your organization has unique selling processes, you can either customize the Sales Hub app or create a custom app from scratch. 

Use the following table to compare the Sales Hub app and custom app, and decide which one suits your needs better: 

| **Capabilities**                                                      | **Sales Hub**                                                                                                                                | **Custom app**                                                                                                                                                                                                   |
|-----------------------------------------------------------------------|----------------------------------------------------------------------------------------------------------------------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Time to value and ROI                                                 | Faster time to value and greater ROI as the app is available right after setting up the product.                                             | Slower start as the custom app has to be built from scratch.                                                                                                                                                     |
| Accessibility and adaptability                                        | Accessibility and adaptability are built into the app. The UI can adapt to multiple devices.                                                 | Accessibility and adaptability of the app are customer's responsibility.                                                                                                                                         |
| Navigate to forms, entities, views right after purchasing the product | The default forms, view, and entities are a great start for majority of the organizations. You can start using product almost instantly. | Forms, entities, and views have to be created manually.                                                                                                                                                          |
| Time and expertise required                                           | Minimal time and effort required to maintain and customize the app.                                                                          | Extensive experience required for building the app with a good time investment to plan, develop, test, and implement the app.                                                                                   |
| App maintenance                                                       | Maintained by Microsoft. All the latest updates are tested for quality and performance before it's deployed on the customer environments.    | Maintained by the customer. Your organization is responsible for evaluating the new features, implementing them in the custom app, and testing them for quality and performance.                                 |
| Customizations                                                        | Customizations are possible. Customizations are not overwritten by any new updates to the app.                            | Completely customizable. Customers have full control of navigation and user experience.                                                                                                                          |
| New feature availability                                              | New features are instantly available in the app.                                                                                             | Adding the UI elements and controls required for the new features is solely the customer's responsibility. Some new features may not be available immediately. They could be made available in the next release. |

## When should you a create custom app instead of customizing the Sales Hub app

Every sales implementation has unique aspects and considerations that will influence the application strategy.

Create a custom app in the following cases:

- For traditional sales roles, the recommendation is to leverage the Sales Hub app. However, for non-traditional sales roles such as senior executives who just need to see Power BI dashboards and a handful of entities, or an audit supervisor who only needs to see the won opportunities, a custom app is the recommended approach.

- When you want to combine specific components and processes from two or more first-party apps such as Sales Hub and Customer Service Hub, assess which application is primary and consider the different types of personas it must cater to:

    - For a salesperson, who needs to access all the sales module components and the customer assets entity from customer service module, it is recommended to configure Sales Hub app to include customer assets entity.

    - For a customer service manager, who needs to have access to the case management module and  the opportunities pipeline, it is recommended to configure the Customer Service Hub app to include the opportunity entity.
    - For a very customized sales process where the built-in sales module is not used, many custom entities are created and the customer wants to remove all or many of the built-in components, a custom app is recommended.
- When customers need to build an XRM solution that is neither sales nor customer service and there is a need to keep the application lean without many of the OOB first party components, a custom app is recommended as well.

## How Sales Hub app updates handle customizations

To help ensure that the Sales Hub customizations are not overwritten by the Sales Hub app update, Microsoft adopts the following practices:

- Weekly updates that contain bug fixes and performance improvements are automatically pushed to the app. 

- Weekly updates can occasionally contain new features or UI disruptive updates. These updates are behind the admin toggle. Administrators can test whether the updates impact customization and then enable it in production when they're ready. 

- Quarterly releases that have new and innovative features have an early access period. It’s important for all customers to test and validate their applications and core use cases on the new build. 

- Updates to the Sales Hub site map do not overwrite the customizations that you've done to the site map. Instead, the changes will be merged.
