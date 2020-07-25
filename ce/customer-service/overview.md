---
title: "Customer Service Overview (Dynamics 365 Customer Service) | MicrosoftDocs"
description: "Overview of Dynamics 365 Customer Service"
author: kabala123
ms.author: kabala
manager: shujoshi
ms.date: 08/3/2020
ms.topic: get-started-article
ms.service: 
  - dynamics-365-customerservice
ms.custom: 
  - dyn365-customerservice
---

# Overview of Dynamics 365 Customer Service

Welcome to Dynamics 365 Customer Service! We are delighted to offer you a suite of capabilities to ensure your business can deliver the best customer service experience possible to your customers. We believe knowing your customer enables you to personalize each experience and optimize agent productivity to earn customer for life. 

We offer several app experiences depending on your support organization’s needs and the data is all stored in CDS, which makes it seamless for users to switch between apps and still be able to work with the customer’s existing data across them. 

[!INCLUDE[cc-app-definition-customer-service](../includes/cc-app-definition-customer-service.md)]

Use [!include[](../includes/pn-ms-dyn-365-for-customer-service.md)] to:

- Track customer issues through cases.
- Record all interactions related to a case.
- Share information in the knowledge base.
- Create queues, and route cases to the right channels.
- Create and track service levels through service level agreements (SLAs). 
- Define service terms through entitlements.
- Manage performance and productivity through reports and dashboards.
- Create and schedule services.

The following capabilities are available in the different app experiences depending on your needs: 

|   | Customer Service Workspace | Omnichannel for Customer Service | Customer Service Hub | Customer Service Team Member | Customer Service app (deprecating) |
|---------------------------------------------------------------------|------------|------------|------------|------------|------------|
| Multisession          | X | X |  |  |  |
| Conversations (with Chat or Digital Messaging Offers)  | X | X |  |  |  |
| Channels (with Digital Messaging Offer)  | X | X |  |  |  |
| Case Management  | X |  X  |  X  |  X  |  X  |
| Knowledge Management  |  X  |  X  |  X  | Read Only |  |
| Insights  | X | X | X |  |  |
| Service Scheduling  |  | N/A | X |  |  |
| Connected Service with IoT  |  |  |  |  |  |
| Extensibility  | CIF v2,BYOC | CIF v2,BYOC, Mobile SDK | CIF v1 |  |  |
| UCI Compliant  | Yes | Yes | Yes | Yes |  |
| Basic Administration  | Customer Service Hub -> Service Manager | Omnichannel Administration |  |  |  |
| Case Routing & Queue Configuration  | Customer Service Hub -> Service Manager | Omnichannel Administration |  |  |  |
| Add & Configure Channels  | App Profile Manager  | Omnichannel Administration |  |  |  |
| Conversation Routing & Queue Configuration  | App Profile Manager  | Omnichannel Administration |  |  |  |

##   Available anywhere, on any device
There are two flavors of [!include[](../includes/pn-ms-dyn-365-for-customer-service.md)]:


- The **Customer Service Hub** app is a case and knowledge management app that’s built on the Unified Interface framework. The Unified Interface framework uses responsive web design principles to provide an optimal viewing and interaction experience for any screen size, device, or orientation. The Customer Service Hub app is optimized to use on mobile devices as well as desktops. [!include[](../includes/proc-more-information.md)] [User guide for Customer Service Hub](user-guide-customer-service-hub.md)

- The **Customer Service** app is designed for the legacy web client. [!include[](../includes/proc-more-information.md)] [User guide for Customer Service](user-guide-customer-service.md)

> [!NOTE]
> For mobile devices, you'll also need to [Install Dynamics 365 for phones and tablets](../mobile-app/Install-Dynamics-365-for-phones-and-tablets.md).

If you're using a desktop browser, you'll see the **Customer Service Hub** app and the **Customer Service** app in the app switcher as shown here:

![open-sitemap](media/open-csh-sitemap-overview.png "Customer Service Hub sitemap")

If you're using a mobile device with Dynamics 365 for phones and tablets installed, you'll see the **Customer Service Hub** app in the app switcher as shown here:

![csh-mobile](media/ChooseAnApp_1.png "Customer Service Hub on mobile")

> [!NOTE]
> Looking forward to upgrade to the Customer Service Hub app? See [Upgrade to Customer Service Hub](upgrade-ish-csh.md)


## Set up Customer Service Hub or Customer Service app

Easily set up the Customer Service Hub and the Customer Service app by using the [Service Manager Guide](service-manager-guide.md).  

The Service Manager Guide helps you set up everything related to customer service, like defining parent-child case hierarchy, creating queues, routing rule sets, rules for automatic case creation, service level agreements (SLAs), entitlements, and customer service schedule.

> [!NOTE]
> If you have previously installed any portal solution, to create a case in the Customer Service Hub or to use the Merge cases command, you must turn off the **Read-only in mobile** option for the Case entity. More information: [Turn off Read-only in mobile option](../customerengagement/on-premises/customize/edit-entities.md#enable-or-disable-entity-options).

## Accessibility and GDPR in the Customer Service Hub 

Customer Service Hub is committed towards inclusive design and accessible content. The app is designed around accessibility so that all users can be effortlessly productive.

For more details about the app's accessibility and GDPR compliance, see [Accessibility and GDPR](user-guide-customer-service-hub.md#accessibility-and-gdpr).

## What's more in the Customer Service Hub

 - [What's new in Dynamics 365 Customer Service](whats-new-customer-service.md)
 - [Service Management Guide (Customer Service Hub and Customer Service app)](service-manager-guide.md)
 - [Service Scheduling Guide](basics-service-service-scheduling.md)


### See also  

[Dynamics 365 Customer Service](https://www.microsoft.com/en-in/dynamics365/customer-service)




