---
title: Setup pricing dimensions in Project Service (Dynamics 365 for Project Service) | MicrosoftDocs
description: Introduction to setup of pricing dimensions in project service solution 
author: Rumant
manager: eichimur
ms.custom:
  - dyn365-projectservice
ms.date: 11/06/2018
ms.topic: article
ms.prod: Project Service
ms.service: business-applications
ms.author: rumant
audience: Admin
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
    - D365PS
---


Project Service has many fields on the Actuals entity that can work as pricing dimensions for resource-based pricing in project organizations. One common example is Bookable Resource. Companies that are small and have fewer than 20-30 billable resources can find that having a bill rate and cost rate that is specific to each resource may be a simpler approach. As the billable workforce grows, this may become unmaintainable quickly since resource cost and bill rates may begin to vary as the resource gets promoted, gains more experience, or acquires a different skill set, etc. However, since this approach still works for companies of certain size, the below steps will use this (using Bookable Resource as a Pricing Dimension) example to illustrate how an existing Project Service field can be used as a Pricing Dimension.
Another example is that of transaction category. Customers and Implementers have used the Transaction Category in PSA to classify work and use that field to price and cost differently based on the category of work.
In the Spring 2018 release of PSA, we have made changes to PSA to include the required constructs to make it easy to setup some of the common examples that we heard from customers for existing PSA fields that they would like to use as pricing dimensions: Bookable Resource and/or Transaction Category. The steps below list the changes required to enable this. You will notice that due to the changes made to PSA, the list of steps required to make this possible is very small.
