# Travel charges in Dynamics 365 Field Service

Use travel charges to bill the cost of travel for the field technician to a customer.

The system adds a travel charge item as a work order product if a [service account (*not* billing account) has a travel charge type set](accounts.md). It's added after scheduling the work order and when the status of the generated booking changes.

## Specify the travel charge item

1. In **Field Service**, open the **Settings** area.
1. Go to **Field Service Settings**.
1. On the **Work Order / Booking** tab, choose or create a product in the **Travel Charge Item** field. This is the product that will be added as a work order product.

   :::image type="content" source="media/field-service-settings-travel-charge.png" alt-text="Screenshot of travel charge item in field service settings.":::

<!-- is it based on account or price list? I guess it's price list if the travel charge product is added to the price list that is used for the service account. if no price list is used, travel charge from service account applies. -->
> [!Note]
> The unit amount of the work order product is the **Travel Charge** value provided on the entered in the [service account record](accounts.md).
> Though the unit amount price of the travel charge is dictated by the price list, list price, and travel charge, 
> The *quantity* for the travel charge work order product is based on the **Travel Charge Type** set for the service account.
> In cases of multiple bookings for a single work order, multiple travel charges will be added as work order products.