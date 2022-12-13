---
title: "Build a service history for assets"
description: Learn about all options to build a service history for assets in Dynamics 365 Field Service.
ms.date: 12/07/2022
ms.reviewer: mhart
ms.topic: article
author: jshotts
ms.author: jasonshotts
manager: shellyha
search.app: 
  - D365CE
  - D365FS
---
 
# Build a service history for assets

After [customer assets](configure-set-up-customer-assets.md) are created, you can track repairs, inspections, tests, IoT data, and issues to build out a service history. Understanding service history is important for making better repair decisions, maintaining asset lifespan and uptime, and ultimately keeping customers happy.

## Work order history

A standard and more organized way to build service history is to note the customer asset on work order incidents.

Incident types are common and distinct issues that serve as work order templates and automatically add details like work order type, work order products, services, and tasks. For more information, see the article on [creating work order templates with incident types](./configure-incident-types.md).

The most important work order incident type can be added directly from the main work order form in the **Primary Incident Type** field. For example, if the incident type is an inspection, and the purpose is to inspect a specific asset at the work order location (service account), then add a **Primary Incident Customer Asset**.

> [!div class="mx-imgBorder"]
> ![Screenshot of a work order showing the primary incident customer asset.](./media/customer-asset-primary-incident.png)

You can add multiple work order incidents to a work order by going to **Related** >  **Incidents** > **+New Work Order Incidents** and each incident can be related to the same or different customer assets as long as they all belong to the same service account.

When you add a customer asset on a work order incident, the asset will also be noted on all work order products, services, and service tasks that result from that work order incident.

Managers can then easily see a list of all work orders the customer asset is or was the subject of, and helps with reporting because you can concretely relate asset details (name, category, product) with work order details (service account, work order type, incident type).

### Work based on agreements

Similar to using work order incidents, you can also use **Agreement Incident** types to:

1. Note which customer asset recurring maintenance is intended for 
2. Make sure recurring maintenance is added to the customer asset service history

For more information on agreements, see the article on [setting up agreements to automatically generate work orders and invoices](../field-service/set-up-customer-agreements.md).  

After creating an agreement, and then adding a related **Agreement Booking Setup**, you can add an **Agreement Booking Incident**.
> [!div class="mx-imgBorder"]
> ![Screenshot of an agreement booking incident showing the related customer asset.](./media/customer-asset-agreement-incident.png)

You can then note a customer asset on the **Agreement Booking Incident**.

> [!div class="mx-imgBorder"]
> ![Screenshot of the agreement booking setup showing the related incidents.](./media/customer-asset-agreement-setup.png)

When work orders are generated from the agreement and agreement booking setup, the incidents with their respective customer asset relationships will be added to the work orders as well.

Just like work order incidents, you can add multiple agreement incidents that will all be added to the generated work orders.

## Notes on timeline

The simplest way to build service history is to use notes and the timeline feature available on Dynamics 365 forms.

For example, from Field Service Mobile, the field technician can navigate to the customer asset record and add a note.

Beyond just text, you can also add photos, videos, and voice recordings with notes in Field Service Mobile.

> [!div class="mx-imgBorder"]
> ![Screenshot of a customer asset showing the timeline with a note.](./media/customer-asset-note-web-install.png)

One drawback of using notes and the timeline is that it's less organized and hard to report on or create metrics for. Using the timeline is better for anecdotal notes that give field technicians context or tips.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
