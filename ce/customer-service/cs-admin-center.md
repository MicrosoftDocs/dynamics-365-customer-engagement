---
title: "Customer Service admin center | MicrosoftDocs"
description: "Get started with Customer Service admin center"
ms.date: 11/19/2021
ms.topic: get-started-article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---

# Get started with Customer Service admin center

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]

## Introduction

Welcome to Dynamics 365 Customer Service admin center (preview), a new app that unifies and simplifies administration experience across the Customer Service suite including Service management in Customer service Hub, Omnichannel admin center, and app profile manager.

Use the Customer Service admin center app to set up everything related to customer service, such as defining parent-child case hierarchy, creating queues, rules for automatic case creation, service-level agreements (SLAs), entitlements, and customer service schedules.

Some of the highlighted improvements include:  

- Consolidation of administration experiences across Customer Service Hub, Omnichannel for Customer Service and app profile manager

- Re-organized sitemap to be task oriented 

- Overview pages for each area which list at-a-glance information with deep links to manage features 

- Feature landing page to provide an overview of all capabilities for that feature 

Adapts to the capabilities that are provisioned. Based in core Customer service, if omnichannel is provisioned, additional features are lighted up.

## Prerequisites

You will need one of the below security roles to access this new app (acronym as CSAC). The last three are for back compatibility with current admin access to CSH, Omnichannel admin center and App profile managers.  

- System Administrator – can access and edit all the sitemap entries  

- System Customizer – can access and edit all the sitemap entries 

- Customer service manager – can access the entities which are original service management   

- App profile administrator – can access the app and edit App profile related entities.  

- Omnichannel administrator – can access to the app and edit all the Omnichannel related entities as Omnichannel admin center does today.

## Access the app

Go to all Apps, you will find Customer service admin center(preview), it is automatically installed in all the Customer service organizations.  

The app is designed in a self-service way, it should provide all the necessary guides for admins to set up customer service.  

## FAQ

Q: What is the difference between Omnichannel admin center and customer service admin center (CSAC), and how to move to CSAC?  

A: Customer service admin center unify all the administration settings from Omnichannel with case management together, it is a superset of omnichannel admin center. From UI side, sitemap becomes task oriented, but no changes to backend entities and APIs, you do not need to migration data, you just need to start to use this new app and get used to it.  

Q: When do you plan to deprecate existing admin experience?  

A: Once Customer service admin center becomes general availability, we will leave some time for customers to get used it and provide feedback, so there is a period this new app will co-exist with existing admin experience. Then we will announce the deprecation of old experience. We highly recommend you to start use this app as early as possible, you should be able to find the benefits to use this new app.  

Q: You integrate existing App profiles manager experience into this new app, why and did you change any functionality?  

A: We get lots of feedbacks from customer that they need to go to App profiles manager to create profiles and then jump between it and UCI app for all the setting, which is time consuming and not intuitive, so we make the change to make it connected with all the other admin experience. There is no core functionality change, we just improve the user experience.  

Q: Can I customize this new application?

A: Same as the other App modules, you can use App designer to  add additional entries to sitemap. Hence if you have custom entities that admins use to manage aspects of your business, then you add them to CSAC sitemap, so your admins don’t have to use a separate app. To reduce conflicts with sitemap that ships by default with CSAC, we recommend you create a new sub-area and add your sitemap entries there.

### See also
