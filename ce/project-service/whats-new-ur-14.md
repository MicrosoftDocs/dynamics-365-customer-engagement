---


title: What's new in Project Service Automation Update Release 14, V3
description: This topic lists the features and fixes that are available in release 14 of Project Service Automation V3.10.4.21.
author: ruhercul                
manager: kfend
ms.service: dynamics-365-projectservice
ms.custom: dyn365-projectservice
ms.date: 01/23/2020
ms.topic: article
ms.prod: 
ms.service: business-applications
ms.technology: Microsoft Dynamics 365 Project Service Automation 3.x
ms.author: ruhercul
audience: Admin
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365PS
---


# Project Service Automation V3, Update Release 14

This topic lists the features and fixes that are new or changed for Project Service Automation V3, Update Release 14 This version has a build number of V3.10.4.21 and is available on the following schedule:

- **General availability (self-update):** January 2020
- **Auto-update:** February 2020

## Features included in this release
 -   Sales

        -   Custom field values from Quote Line Details are copied to Project
            Contract Line Details when a Quote is updated to closed as won.

        -   Confirmed projects can be ‘Closed as lost’.

    -   Resource Management

        -   When extending Bookings, users will be prompted with a confirmation
            dialog to summarize booking results and provide a link to Maintain
            Bookings.

## Additional resources

### Update Release 14 bug fixes

   -   Time and Expense

        -   Fixed: Correct entries - Improved user experience when the user has
            not selected anything to be corrected.

    -   Resource Management

        -   Fixed: Booking resource multiple times overflows the name of the
            bookable resource.

    -   Sales

        -   Fixed: Total sales price is not calculated until the user also
            inputs a cost price for expense estimates on a project.

        -   Fixed: Closing Quote as Won fails if associated Project Contract is
            not in the Draft state.

