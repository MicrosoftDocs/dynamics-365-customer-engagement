---
title: Work order form and component experience
description: The new work order experience simplifies work order creation, management, and scheduling.
ms.date: 06/30/2023
ms.topic: how-to
author: lmasieri
ms.author: lmasieri
ms.custom: bap-template
---

# Work order form and component experience (preview)

With 2023 release wave 2, Dynamics 365 Field Service introduces a refreshed user experience to manage work orders. The new experience simplifies how you [create, manage, and schedule work orders](create-work-order.md). It also provides more information at a glance and uses more visually appealing forms that let you quickly update fields on the form.

In this article, we'll discuss the work order form and the components that it uses. You also find information about customizing the new controls and forms and potential limitations.

## Work order list

### Work order list grid

To change between the old read-only grid and the new editable grid, use the **Show as** control in the command bar. There's also a new default view, which is called **Work Orders (preview)**. Use the view switcher to get to other views that you created.

:::image type="content" source="media/work-order-list-grid.png" alt-text="Screenshot of a list grid for work orders.":::

The new grid shows work orders in a list and lets you priority of items inline and [update several other fields in a side pane](#side-pane-for-quick-edits).

### Side pane for quick edits

The side pane for the work order form is a simplified form. It enables quick actions like status updates, booking a work order, or editing instructions without switching to the detailed work order form.

To open a work order in the side pane, hover over a work order in the list and select the **Work Order Side Pane** icon. You can open multiple work orders in the side pane and switch between them in the right border or the side pane.

:::image type="content" source="media/work-order-side-pane.png" alt-text="Screenshot of a work order list with the Work Order Side Pane icon highlighted.":::

## Work order form

The form for a work order record shows all the available details that relate to the work order. It consists of a *form header* and multiple *sections* that show *cards* with contextual information in the main form. the form header shows the [price not-to-exceed](work-order-not-to-exceed.md), the creation date of the work order, and the [service account](accounts.md).

To change between the old form Work Order and the new form, use the form switcher under the record name.

### General section

:::image type="content" source="media/work-order-record-general.png" alt-text="Screenshot of a work order record on the General tab.":::

The *General* section on the work order form contains the following cards:

- [Details](#details-card)
- [Functional location](#functional-location-card)
- [Financial](#financial-card)
- [Dynamic bookings](#dynamic-bookings-card)
- [Contacts](#contacts-card)
- [Assets](#assets-card)

#### Details card

The details card contains a high level overview of the work order. Here you can see and change its status, substatus, priority, or committed dates and add a instructions or write a summary of the work order.

#### Functional location card

The location card shows location-related information and a map. The **Service Address** is populated be the address of the selected functional location. If no functional location is selected, it uses to the service address. If no service address is present, it uses the address of the contact that reported the issue which lead to the the work order.

#### Financial card

The financial card is your hub for all things finances for a work order. It lets you set the [billing account](accounts.md), configure if the work order is taxable, select the [price list](create-price-list.md), and [define NTE](work-order-not-to-exceed.md) information.  

#### Dynamic bookings card

The dynamic card is the key change in the new work order form. It replaces the previously used business process flow, and it's designed to help you take the next action to [move a work order through its lifecycle](work-order-status-booking-status.md). The card has different states, depending on the work order status:

- **Unscheduled work orders**: Get booking suggestions that fit within the time frame (date/time promised) for the work order and meets the required skills to get this work done. The suggestions are based on the work order requirement. For each resource you get the appointment time and information on their travel time from the previous appointment. If no suggestion works, select **Find availability** to open the schedule assistant and choose a resource to book them.

- **Scheduled work orders**: See booking details, contact information of the technician, appointment time, duration of the booking, and the expected travel time. You can change the status of a booking and rebook it if needed.

- **Completed work orders**: Find a summary of the completed work completed, including the resolution for the work order and number of products and services used. If the work order isn't posted, you can review this information and  post it or print a service report. For posted work orders, you can print the service report, view the invoice, or print the invoice.  

#### Contacts card

Get contact information for all involved stakeholders. Select the contact name to open the contact page and edit details or see additional details about the contact.

The phone number defaults to the accounts business phone, but if that’s not present we’ll pull in their mobile phone. You can start a phone call or email using the default client set in your browser. The message hyperlink opens Microsoft Teams.  

#### Assets card

The asset card is the unified place to see all assets associated with the work order across products, services, and tasks.  

In its empty state, the assets card asks for the primary asset for this work order. If the work order has products and services associated, the primary asset establishes a relationship with each of the products and services. When you add more products and services, you can associate them with different assets.  

Expand or collapse the assets in the tree to get sub-asset information. Select an asset in the tree to open the side pane and make changes to the asset.

### Products and services section

The **Products and services** section on the work order form lets you see and manage [products and services](create-product-or-service.md) for the work order with ease. Important information, such as estimates and used quantities or duration, shows at a glance and you can change the status from estimated to used, or make updates in the contextual side pane for a product or service. To add products or services to the work order, select the **Add service** or **Add product** buttons.

For products, you can see its name, whether it’s an inventory or non-inventory product, the estimated and used quantities, the estimated and total price, and the status of whether the product was used or not.

For services, you can see the name of the service, the estimated and total duration, the estimated and total price for the service, and the status of whether the service was performed or not.

Select the side pane icon to open the product or service on the side pane and make further changes in context. Select the name of a product or service to open the full form.  

### Tasks section

The tasks summary includes a summary of how many tasks are on the work order, how many are completed, and the estimated and actual durations – giving you at a glance information about work completed and remaining.

Manage your tasks right here and set their completion status quickly. For tasks with associated [inspections](inspections.md), you get a reference to the name of the inspection. A dropdown on the results column lets you choose whether the inspection passed, failed, or partially passed. Tasks that [map to Dynamics 365 Guides](mixed-reality-guides-integration.md) show a reference with the name of the guide.  

### Reference section

The reference section is the hub for all reference information, media and text, that highlights either how to get work done, or what work was completed.

The knowledge articles card contains important information that helps technicians to complete a task or troubleshoot an issue. You can link [existing knowledge articles](field-service-knowledge-management.md), create a new article, and review or edit attached articles.

### Timeline section

The timeline is the place to see an audit log of activity required to get work done. The timelines lists phone calls, emails, and notes.

### Related section

In the related section, you find references to entities that have a relationship to the work order entity.

## Trade coverage validation for work orders

Depending on the [configuration of trade coverages](trades.md), work orders check if the selected account or functional location are covered.

If trade coverage is set to not cover a trade, a warning shows on the work order. However, you can still save the work order.

The validation interprets service accounts and hierarchies in functional locations.

> [!NOTE]
> If no trade coverage is defined for a trade, the system assumes that the trade is covered for all parameters. Work order won’t show any warnings if trade coverage isn’t defined.

## Customization considerations

For more information about work order customizations, see [Customization considerations for the work order form](work-order-customization.md).

## Next steps

- [Create a work order](create-work-order.md)
- [Create work order types](create-work-order-types.md)
- [Set up booking statuses](set-up-booking-statuses.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
