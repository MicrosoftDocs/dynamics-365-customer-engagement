  
## Build service history 

After customer assets are created, you can track repairs, inspections, tests, IoT data, and issues to build out a service history. Understanding service history is important for making better repair decisions, maintaining asset lifespan and uptime, and ultimately keeping customers happy. There are a few ways to build out a service history, including: 

- With notes on the timeline
- Work orders
- With agreements

### With notes on timeline

The simplest way to build service history is to use notes and the timeline feature available on Dynamics 365 forms.

For example, from Field Service Mobile, the field technician can navigate to the customer asset record and add a note.

> [!div class="mx-imgBorder"]
> ![Screenshot of Field Service Mobile showing a list of customer assets.](./media/customer-asset-note-mobile-install.png)

Beyond just text, you can also add pictures, videos, and voice recordings with notes in Field Service Mobile.

> [!div class="mx-imgBorder"]
> ![Screenshot of a customer asset showing the timeline with a note.](./media/customer-asset-note-web-install.png)

Notes will appear in the customer asset form timeline and other elements like pictures will show as attachments.

One drawback of using notes and the timeline is that it's less organized and hard to report on or create metrics for. For example, imagine as a field service organization you want to report on the number of times a specific asset or asset class has needed repairs; the timeline would be too unorganized to see this information. Using the timeline is better for anecdotal notes that give field technicians context or tips.

### With work orders

A standard and more organized way to build service history is to note the customer asset on work order incidents.

As a reminder, incident types are common and distinct issues that serve as work order templates and automatically add details like work order type, work order products, services, and tasks. For more information, see the article on [creating work order templates with incident types](./configure-incident-types.md).

The most important work order incident type can be added directly from the main work order form in the **Primary Incident Type** field. For example, if the incident type is an inspection, and the purpose is to inspect a specific asset at the work order location (service account), then add a **Primary Incident Customer Asset**.

> [!div class="mx-imgBorder"]
> ![Screenshot of a work order showing the primary incident customer asset.](./media/customer-asset-primary-incident.png)

See the note in configuration considerations about adding customer assets to work orders that are not related to the work order service account.

Keep in mind you can add multiple work order incidents to a work order by going to **Related** >  **Incidents** > **+New Work Order Incidents** and each incident can be related to the same or different customer assets as long as they all belong to the same service account.

> [!Note]
> When noting a customer asset on a work order incident, the customer asset will also be noted on all work order products, services, and service tasks that result from that work order incident.


> [!div class="mx-imgBorder"]
> ![Screenshot of a work order product showing the related customer asset.](./media/customer-asset-product-asset-relation.png)

Anytime a customer asset appears on a work order incident, the work order will appear in the **Related Work Orders** section of the customer asset. 

> [!div class="mx-imgBorder"]
> ![Screenshot of a customer asset showing the related work orders.](./media/customer-asset-related-work-orders.png)

Managers can then easily see a list of all work orders the customer asset is or was the subject of, and helps with reporting because you can concretely relate asset details (name, category, product) with work order details (service account, work order type, incident type).

### With agreements

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