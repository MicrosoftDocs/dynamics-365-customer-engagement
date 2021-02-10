---
title: What's new in Dynamics 365 Customer Service | MicrosoftDocs
description: Visit this page to see what's recently updated or added in Dynamics 365 Customer Service
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 11/09/2020
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# What's new in Dynamics 365 Customer Service

Welcome to Dynamics 365 Customer Service. Visit this page to learn about new or updated features for Customer Service.

## What's new in October 2020 update

For information about the features that released in October 2020, see:

[2020 release wave 2 plan - Customer Service](https://docs.microsoft.com/dynamics365-release-plan/2020wave2/service/dynamics365-customer-service/customer-service)

## What's new in August 2020 update

For information about the features that released in August 2020, see:

[2020 release wave 2 plan - Customer Service](https://docs.microsoft.com/dynamics365-release-plan/2020wave2/service/dynamics365-customer-service/customer-service)

## What's new in April 2020 update

For information about the features that released in April 2020, see:

[2020 release wave 1 plan - Customer Service](https://docs.microsoft.com/dynamics365-release-plan/2020wave1/dynamics365-customer-service/customer-service)

## What's new in February 2020 update

Preview: Visualizing device readings

This feature helps you understand the current state of a device, its repair history, and the effect of performed work orders, the Connected Customer Service add-in displays near realtime device readings and historical sensor measurements in a chart alongside work order details.

The device readings chart is available on the IoT alert, work order, case, device, and asset forms.

To learn more, see [Time series insights on IoT devices](cs-iot-visualize-device-readings.md)

### Early Access

- <b>Connected Customer Service (IoT + Customer Service)</b>

  Connected Customer Service helps organizations evolve a proactive and predictive service model by fully integrating IoT diagnostics, IoT device updates, and case management. Key capabilities in this release include:
  - Convert IoT Alert to a support case.
  - View all devices registered to the customer.
  - View all IoT Alerts from devices registered to the customer.
  - Send command to the customer’s device.
  - View IoT activity in the case timeline.
  
  To learn more, see [Connected Customer Service - Overview](cs-iot-overview.md)

- <b>Agent productivity enhancements to knowledge capabilities</b>

  In this release, we're enhancing agent access to and usability of knowledge articles so that agents can:
  - Use an improved layout of knowledge search results to simplify scanning, reading, and action.
  - Review knowledge articles in a separate, full screen.
  - Search the knowledge base outside the context of a customer case. (Knowledge search is now available in the Customer Service Hub app navigation for anytime access.)

  To learn more, see [Search for knowledge articles in the Customer Service Hub](search-knowledge-articles-csh.md)

- <b>Configurable case resolution page</b>

  With this release, administrators can:
  - Add fields such as resolution type in the form/dialog box for case resolution.
  - Introduce new client-side business validations or remove existing ones.
  - Customize the case resolution entity.
  - Choose between the non-customizable modal dialog experience (default setting) and the customizable form experience.

  To learn more, see [Modify Case Resolution Dialog](customer-service-hub-user-guide-modify-case-resolution-dialog.md)

- <B>Customer Service app available for users with Team Member license</b>

  Customer Service Team Member is a new app module that will be available to users with the Dynamics 365 Team Member license. In the customer service context, this app module enables the following limited set of use cases provided by the Team Member license for employee self-service:
  - Create cases.
  - Read and update the cases that they created.
  - Search and view knowledge articles.

  To learn more, see [Customer Service Team Member app](customer-service-team-member.md)

- <B>Customer Service Hub app is now available by default</b>

  As previously announced, customers will need to migrate to the Unified Interface experience by October 1, 2020. The Customer Service Hub solution that is built on the Unified Interface framework will be automatically installed in all the environments in this release. Existing customers will have access to the Customer Service Hub app, and users with the Customer service app access security role will be able to view and use the app.

  To learn more, see [Availability of Customer Service Hub](availability-customer-service-hub.md)

- <B>Enhancements in case routing rules</b>
  Case routing rules help trigger automatic or manual routing of cases to the right support resources. This release provides a new experience built on the Unified Interface that enables easy configuration of routing rules and brings feature parity with the legacy web client.

  To learn more, see [Automatically route cases using routing rule sets](create-rules-automatically-route-cases.md)

- <B>Enhancements in the queue page</b>

  In this release, the user experience has been enhanced for agents to manage their queues. The agents can now select an item in the queue and view its details on the same page without having to switch contexts. They can also go through the list of items in the queue without the need to navigate away from the page.

  To learn more, see [Learn the basics of the Customer Service Hub
](customer-service-hub-user-guide-basics.md)

- <B>Familiar, modern email experience for agents</b>

  Agents spend a significant amount of time using email to communicate with customers. Simple and intuitive email experiences help improve agent productivity and quality of service to customers. In this release, we are bringing the following modern email capabilities to the agent experience:
  - Author emails using a complete rich text experience, including the ability to send, receive, and manage images inline.
  - Use a modern toolbar and have the ability to cut and paste formatted content from Office documents such as Word and Excel, while maintaining formatting.
  - Preview email templates prior to applying them to email.
  - Compose email in a pop-up, non-blocking window, with the ability to write an email with context of the current record, navigate between records, and have multiple active draft emails open simultaneously.

  To learn more, see [Set up timeline section (control)](https://docs.microsoft.com/powerapps/maker/model-driven-apps/set-up-timeline-control) and [Learn the basics of the Customer Service Hub](customer-service-hub-user-guide-basics.md)

- <b>License enforcement - users with new Team Member licenses</b>

  For Team Member licenses purchased during or after October 2018, the license-based access feature will restrict users to the following set of designated app modules:
  - Customer Service Team Member
  - Sales Team Member
  - Project Resource Hub

  During the early access phase, users with the Team Member licenses will be able to use the designated app modules alongside all existing apps. After the licenses are enforced (starting April 1, 2020), restricted apps, such as Customer Service Hub, Sales Hub, and custom apps, will not be accessible to users with the Team Member licenses. 
  
  Customers can also proactively preview full enforcement before general availability. We recommend that the Team Member scenarios be tested and customizations migrated to the designated app modules, as needed.

  To learn more, see Customer Service Team Member app](customer-service-team-member.md)

- <B>New work hour calendar in Service Scheduling</b>

  Administrators currently navigate several screens to access a resource's calendar and update work hours and time off. With this release, we are delivering a new experience using an accessible Power Control Framework (PCF) calendar control in the Unified Interface. 
  
  Organizations will have flexibility to design new experiences (for example, using canvas apps) that modify resources' working hours from outside entity forms and views.

  To learn more, see [Learn the basics of the Customer Service Hub](customer-service-hub-user-guide-basics.md)

- <b>Rich text notes and keyword search in the timeline</b>

  Enhancements to the Dynamics 365 timeline control include:
  - Create rich text notes that provide detail about the case and enable formatting for emphasis and readability.
  - Perform keyword search filter to quickly display matching records.
  - Identify closed or completed activities visually.
Show only User or System records with the additional filter.

  To learn more, see [Set up timeline section (control)](https://docs.microsoft.com/powerapps/maker/model-driven-apps/set-up-timeline-control)

- <b>Support for Site entity in the Unified Interface</b>
 
  To provide business continuity during transition to the Unified Interface, this release delivers support for administrator configuration and interaction with the Site entity used to define customer service locations.

  To learn more, see [Learn the basics of the Customer Service Hub](customer-service-hub-user-guide-basics.md)

- <b>Enhancements in service level agreements</b>

  In this release, a new SLA administration experience has been enabled on the Unified Interface that brings feature parity with the legacy web client. Administrators can now leverage the various out-of-the-box actions available with Microsoft Power Automate to easily configure actions, such as success, failure, and warning actions for SLAs. For example, the administrator can post a Microsoft Teams message to an agent when an SLA is violated.

  To learn more, see [Define Service Level Agreements (SLAs)](define-service-level-agreements.md)

- <b> Automatically create and update records</b>

  This feature enables a new record creation administration experience on the Unified Interface and brings feature parity with the legacy web client. The new experience uses Microsoft Power Automate and provides an easy-to-use interface to create or update conditions and actions.

  To learn more, see [Automatically create or update records in Customer Service Hub](automatically-create-update-records.md)

## Dynamics 365 Customer Service app

Customer Service introduces some new features for enhanced customer satisfaction by facilitating improved operational efficiency and organizational productivity.

New features introduced in this release are:

- [What's new in Dynamics 365 Customer Service](#whats-new-in-dynamics-365-customer-service)
  - [What's new in October 2020 update](#whats-new-in-october-2020-update)
  - [What's new in August 2020 update](#whats-new-in-august-2020-update)
  - [What's new in April 2020 update](#whats-new-in-april-2020-update)
  - [What's new in February 2020 update](#whats-new-in-february-2020-update)
    - [Early Access](#early-access)
  - [Dynamics 365 Customer Service app](#dynamics-365-customer-service-app)
    - [Advanced similarity rules to view similar case suggestions](#advanced-similarity-rules-to-view-similar-case-suggestions)
    - [Service scheduling powered by Universal Resource Scheduling](#service-scheduling-powered-by-universal-resource-scheduling)
    - [Relevance search enabled for knowledge management](#relevance-search-enabled-for-knowledge-management)
    - [Enhanced customer service admin settings using Service Management](#enhanced-customer-service-admin-settings-using-service-management)
    - [See also](#see-also)

### Advanced similarity rules to view similar case suggestions

With the help of advanced similarity rules, you can now view cases similar to your current case and resolve customer issues in the first contact and within minimal time.

Using Relevance search mechanism, you can leverage keywords or key phrases in a service case to quickly find related cases and use them to resolve your current case.

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use advanced similarity rules to view similar case suggestions](suggest-similar-cases-for-a-case.md)


### Service scheduling powered by Universal Resource Scheduling 
Service scheduling, now built atop Universal Resource Scheduling, provides an efficient way to schedule resources for service activity. It considers the availability of employees, facilities, and equipment to plan schedules accordingly. It also helps to improve service quality by preventing over-scheduling.

To learn more about the new scheduling in Customer Service, see [Service scheduling overview](basics-service-service-scheduling.md).

Have some questions? See the [Service Scheduling FAQ](service-scheduling-faq.md).

### Relevance search enabled for knowledge management 

Knowledge base search control in Customer Service is now powered by Relevance search to deliver results with improved performance and accuracy. With this feature, agents can search and choose the most relevant articles quickly with the help of highlighted search term matches in the results list. 

To learn more about how knowledge base search control works with Relevance search, see [Search for knowledge articles](search-knowledge-articles-csh.md).

To learn more about Relevance search, see [Use Relevance Search for faster, comprehensive search results](../basics/relevance-search-results.md).

### Enhanced customer service admin settings using Service Management

With the latest release of Dynamics 365 Customer Service app, Service Management moves under the Customer Service Hub, enabling customer service managers to access and manage the configurations from inside the application. Built on the Unified Interface framework, the new Service Management helps to easily configure admin settings, enabling increased productivity.

See the [Configure Customer Service](configure-cs.md) to learn more about Customer Service admin settings.

> [!NOTE]
> With the latest release of Dynamics 365 Customer Service app, you can access and manage all admin settings from the Customer Service Hub sitemap except for **Routing Rule sets**, **Automatic Record Creation,** and **Service Level Agreements**. </br> To access and manage these three admin settings, go to **Settings** > **Service Management** in the web application.

### See also

[User Guide (Customer Service Hub)](user-guide-customer-service-hub.md)
