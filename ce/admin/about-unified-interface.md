---
title: "About Unified Interface Dynamics 365 Customer Engagement | MicrosoftDocs"
ms.custom: ""
ms.date: 02/20/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 64987a8b-21e4-4c2a-9366-39dabef90bb1
caps.latest.revision: 21
author: "jimholtz"
ms.author: "jimholtz"
manager: "brycho"
---
# About Unified Interface

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

With the release of [!INCLUDE [pn-crm-9-0-0-online](../includes/pn-crm-9-0-0-online.md)], we've introduced a new user experience - Unified Interface - which uses responsive web design principles to provide an optimal viewing and interaction experience for any screen size, device, or orientation. 

The new Unified Interface brings all the rich experiences to any client that you are using. Whether you are on a browser, tablet, or phone, you will be able to consume similar experiences. Some examples: 

> - Similar form experiences to update and view your records.
> - Interactive dashboards across all devices to view your information and drill into it. 
> - Reference Panel is now available to be used in any experience and not just cases. 
> - We now support right-to-left (RTL) languages.
> - All experiences on Unified Interface are completely accessible. 

## Capabilities available in Unified Interface with Dynamics 365, version 9.0 

Most of the core functionalities of sales and customer service have moved to the Unified Interface client. 

### Dashboards and charts

You can access all the system and user dashboards from within your Unified Interface apps. The interactive dashboards are now available for all record types with richer interactive dashboard capabilities. 

![Unified Interface dashboard](media/uci-interactive-dashboard.png "Unified Interface dashboard")

### Enhanced user experience

If users work on core record types like Activities, Accounts, Contacts, Leads, Opportunities and Cases, you'll be able to move them to the Unified Interface client. 

They will have familiar capabilities on Unified Interface and will also discover productivity enhancements with the introduction of some enhanced capabilities. 

**Timeline control** - The timeline view helps you collaborate with your team by tracking customer communication in a record on a single page in an easy to read view. You can see everything from posts and voice attachments, to emails and notes. It provides a quick way to see the entire communication thread. 

**Business process enhancement** - The business process flow has been improved by the docking mechanism. You can dock the business process stage on your screen to help you stay focused on the task at hand in your business process flow. This is especially useful when the stage of the process has complex steps to complete. 

**Reference panel** - Use the reference panel for apps built on Unified Interface like Dynamics 365 for Customer Service. The reference panel is a great way to get work done without clicking away from the screen you are on. You can look up other things like knowledge base articles within the context of the record you are viewing. 

**Navigation** - The new menu options let you swiftly navigate the different apps in the system. It provides quick access to recently viewed records and pinned favorites. 

**Reflow** - The app also scales by reflowing the components on the screen. The responsive design adapts to your environment based on screen size, so the more available space that you have the more information can be displayed. 

![Unified Interface adapts to screen](media/uci-reflow.png "Unified Interface adapts to screen")

### Focused Experience
Unified interface experiences are based on [model-driven apps](https://docs.microsoft.com/powerapps/maker/model-driven-apps/model-driven-app-overview). You can scope the user experience based on the jobs they need to accomplish. Users can have single or multiple apps based on their requirements and can easily switch between apps as needed. 

### Rich controls 
Unified interface is a metadata driven experience. All controls experiences are built on the control framework that is extensible and provides a uniform experience across clients. The app display reflows to the viewport size the user is working in. 

## Getting started with Unified Interface experience
When you are provisioning a new Dynamics 365 org, depending on whether you are provisioning for Sales, Customer service, Field service, Project service automation, all the options, or an org with no customization, you will see the following Unified Interface apps:

|Choice while provisioning  |Unified Interface apps  |
|---------|---------|
|Sales     |Sales Hub         |
|Customer service     |Customer Service Hub         |
|Field service     |Field Resource Hub         |
|Project service automation     |Project Resource Hub          |
|None     |Dynamics 365 Hub         |
|All      |All the above except Dynamics 365 Hub         |

![Unified Interface apps](media/uci-apps.png "Unified Interface apps")

### Accessing Unified Interface apps on browsers
Once provisioned, you can access the installed Unified Interface and web apps from multiple interfaces. On browsers you can see all the apps both Unified Interface and web: 

1. In [https://home.dynamics.com/](https://home.dynamics.com/)

   ![Dynamics 365 Home page](media/uci-home-dynamics.png "Dynamics 365 Home page")

2. In app navigation

   ![In app navigation](media/uci-in-app-navigation.png "In app navigation")

3. In My Apps page under Settings

   ![Unified Interface apps on My Apps page](media/uci-my-apps-page.png "Unified Interface apps on My Apps page")

### Accessing Unified Interface apps on phone and tablets
Unified interface apps are the only apps supported on phones and tablets for Dynamics 365, version 9.0. When a user logs into the above org, they will only see the Unified Interface apps on their apps landing page. 

|  | |  |
|---------|---------|---------|
|On phone <br/>![Unified Interface phone app](media/uci-app-phone.png "Unified Interface phone app")     |    |On tablet <br/>![Unified Interface tablet app](media/uci-app-tablet.png "Unified Interface tablet app")    |

### Creating a new Unified Interface app
In case you have requirements to create your own experience on Unified Interface, you can create a model-driven app using the app designer. See [Overview of building model-driven apps](https://docs.microsoft.com/powerapps/maker/model-driven-apps/model-driven-app-overview).

![Create new Unified Interface app](media/uci-model-driven-app.png "Create new Unified Interface app")

![Unified Interface custom hub](media/uci-custom-hub.png "Unified Interface custom hub")

## Capabilities not yet on Unified Interface

There are certain experiences that are currently not available on Unified Interface. We are working to provide these in future releases. 

The following are not currently available with Unified Interface:

- Advanced Find 
- Bulk edit 
- Merge records
- Record sharing
- All options under **Set Personal Options** (![Settings gear](../basics/media/settings-gear-icon.png "Settings gear"))
- Chart drill down 
- Learning Path
- Creating personal dashboards and charts
- Creating personal views
- Charts as visualization for sub-grids on forms 
- Activities roll-up view
- Creating email template with slugs 
- Creating duplicate detection jobs
- Composite address control 
- Run workflow
- Filtering on read-only grids 
- Run report (SSRS)
- Letter, Fax, Recurring Appointments 
- Campaign management – campaigns, campaign activities and quick campaign
- Marketing list 
- Position entity 
- Global notifications
- Admin experiences 

### See also
[Overview of building model-driven apps](https://docs.microsoft.com/powerapps/maker/model-driven-apps/model-driven-app-overview)
