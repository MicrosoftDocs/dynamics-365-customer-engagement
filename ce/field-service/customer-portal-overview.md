---
title: Dynamics 365 Field Service Portal overview
description: Learn about how customers can manage their upcoming service visits with customer experience portals in Field Service.
ms.date: 05/03/2023
ms.topic: overview
author: m-hartmann
ms.author: mhart
search.app:
  - D365CE
  - D365FS
---

# Dynamics 365 Field Service Portal overview

> [!IMPORTANT]
> [!INCLUDE[cc_preview_features_definition](../includes/cc-preview-features-definition.md)]
> Microsoft doesn't provide support for this preview feature. Microsoft Dynamics 365 Technical Support won't be able to help you with issues or questions. Preview features aren't meant for production use and are subject to a separate [supplemental terms of use](https://go.microsoft.com/fwlink/p/?LinkId=511446).

> [!div class="mx-imgBorder"]
> ![Self-service scheduling functionality on a tablet and mobile device.](./media/SS_Hero-screens.png)

Dynamics 365 Field Service self-service scheduling capabilities provide your customers the flexibility to schedule service appointments at their discretion.

You can connect your Field Service environment seamlessly with a Power Pages website template. Creating the website only takes a few minutes. A customizable website provides a one-stop destination for your end customers with self-service capabilities. Your customers can book new appointments, manage existing appointments, provide feedback about completed work, and track the dispatched technician.

You can only use the Power Pages website template for self-scheduling in combination with a Field Service license. The self-service portals maps to a single Field Service environment. So you can have multiple portals if you have multiple environments where Field Service runs on.

Contacts of service accounts in Field Service can receive invites to sign up and create a profile on the portal. In the portal, they can choose from a list of customer assets and incident types to determine how long a service appointment takes. After selecting an available date and time, the can book their service request.

The system creates a work order for the service request and schedule an available resource to complete the job. Available resources must match criteria like territory or characteristics of the selected incident type, service account, and assets. Amongst all matching resources, the one with the shortest travel distance gets booked.

Email notifications keep the customer up to date about the status of the booking. If a customer needs to reschedule the appointment or cancel it, they can do that directly on the portal. The system handles changes in the background to ensure the right resources gets there on time to complete the job.

## Get started with self-schedule capabilities

Before inviting your customer to self-schedule service appointments, review the following articles that help you get started and set up.

1. [Create and configure the Field Service Portal (preview)](create-configure-customer-portal.md)
1. [Set up notifications for the Field Service Portal (preview)](customer-portal-notification-settings.md)
1. If you want customers to see information about their technician location and arrival time, see [Track a technician](customer-portal-technician-tracking.md)
1. To make sure end customers can use a homepage, enable self-scheduling in Field Service. [Enable customers to self-schedule service appointments (preview)](customer-portal-self-scheduling.md)

## Known limitations

- The website template for self-scheduling doesn't integrate with other Power Pages websites. It only works on its own.

- Scheduling only works user resources.

- Self-scheduling doesn't support incident types that require crews or requirements with multiple resources.

- The capability supports all languages except Arabic and Hebrew.

## Next steps

- [Create and configure the Field Service Portal](create-configure-customer-portal.md)
- [Set up notifications for the Field Service Portal](customer-portal-notification-settings.md)
- [Enable customers to self-schedule service appointments (preview)](customer-portal-self-scheduling.md)
- [Track a technician on the Field Service portal](customer-portal-technician-tracking.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
