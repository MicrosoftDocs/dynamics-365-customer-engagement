---
title: Dynamics 365 Field Service portal overview
description: Learn how customers can manage their upcoming service visits with customer experience portals in Field Service.
ms.date: 10/15/2025
ms.topic: overview
author: mkelleher-msft
ms.author: mkelleher
ms.reviewer: puneetsingh
search.app:
  - D365CE
  - D365FS
---

# Dynamics 365 Field Service portal overview

Dynamics 365 Field Service self-service scheduling lets your customers schedule service appointments when it works best for them.

:::image type="content" source="./media/SS_Hero-screens.png" alt-text="Screenshot of self-service scheduling functionality on a tablet and mobile device.":::

You can connect your Field Service environment seamlessly with a Power Pages website template. Creating the website takes only a few minutes. A customizable website provides a one-stop destination for your customers with self-service capabilities. Your customers can book appointments, manage existing appointments, provide feedback about completed work, and track the dispatched technician.

You can use the Power Pages website template for self-scheduling only with a Field Service license. The self-service portal maps to one Field Service environment. You can create multiple portals if you have multiple environments running Field Service.

Contacts of service accounts in Field Service receive invitations to sign up and create a profile on the portal. In the portal, they choose from a list of customer assets and incident types to determine how long a service appointment takes. After selecting an available date and time, they book their service request.  

The system creates a work order for the service request and schedules an available resource to complete the job. Resources must match criteria such as territory, characteristics of the selected incident type, service account, and assets. Among matching resources, the one with the shortest travel distance is booked.

Email notifications keep customers informed about booking status. Customers can reschedule or cancel appointments directly on the portal. The system processes changes in the background to ensure resources arrive on time to complete the job.

## Get started with self-schedule capabilities

Before inviting your customer to self-schedule service appointments, review the following articles to assist with the setup process.

1. [Create and configure the Field Service portal](create-configure-customer-portal.md).
1. [Set up notifications for the Field Service portal](customer-portal-notification-settings.md).
1. If you want customers to see information about their technician's location and arrival time, see [Track a technician](customer-portal-technician-tracking.md).
1. To ensure customers can use a home page, enable self-scheduling in Field Service. [Enable customers to self-schedule service appointments (preview)](customer-portal-self-scheduling.md).

## Known limitations

The following limitations apply to the self-scheduling portal:

- The website template for self-scheduling works independently and doesn't integrate with other Power Pages websites.

- Scheduling works only for user resources.

- Self-scheduling doesn't support incident types requiring crews or multiple resources.  

- This capability supports all languages except Arabic and Hebrew.

## Next steps

- [Create and configure the Field Service portal](create-configure-customer-portal.md)
- [Set up notifications for the Field Service portal](customer-portal-notification-settings.md)
- [Enable customers to self-schedule service appointments (preview)](customer-portal-self-scheduling.md)
- [Track a technician on the Field Service portal](customer-portal-technician-tracking.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
