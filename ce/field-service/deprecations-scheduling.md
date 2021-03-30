---

title: "Deprecations in Universal Resource Scheduling | MicrosoftDocs"
description: Visit this page to see what's recently deprecated in Dynamics 365 Universal Resource Scheduling
ms.custom: 
  - dyn365-fieldservice
ms.date: 03/29/2021
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.topic: article
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: salehasiddique-msft
ms.author: salsiddi
manager: shellyha
search.app: 
  - D365CE
  - D365FS
---

# Deprecations in Universal Resource Scheduling

The features that have been deprecated in Universal Resoure Scheduling are listed in this article.

Administrators and IT professionals can use this information to prepare for future releases.

> [!Important]
>
> "Deprecated" means we intend to remove the feature or capability in a major future release. The feature or capability will continue to work and is fully supported until it is officially removed. This deprecation notification will span at least 6 months. After removal, the feature or capability will no longer work. We are notifying you now so that you have sufficient time to plan and update your code before the feature or capability is removed.


## Configuration to automatically create a booking when an appointment is created is deprecated <a name ="deprecated-appointment-handling"></a>

Effective from April 01, 2021, the configuration to [automatically create a booking when an appointment is created](schedule-new-entity#appointment-scheduling-with-universal-resource-scheduling) is deprecated. Customers who already use the new schedule board should start moving to the [improved way of including appointments without needing corresponding bookings](appointment-scheduling.md). Those customers who rely on functions of the old schedule board that are not in the new schedule board (such as assisted scheduling / **Find Availability** should be aware that the product roadmap plans for parity between the old and new schedule board experiences in October 2021. End of life for handling appointments through bookings is planned for April 2022, and customers should accordingly make plans to migrate to the new functionality that directly includes appointments. 





[!INCLUDE[footer-include](../includes/footer-banner.md)]
