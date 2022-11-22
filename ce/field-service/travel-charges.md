# Travel charges in Dynamics 365 Field Service

Use travel charges to bill the cost of travel for the field technician to a customer.

The system adds a travel charge item as a work order product If a service account (*not* billing account) on a work order has a travel charge type set. It's added after scheduling the work order and when the status of the generated booking changes.

First, go to **Field Service > Settings > Field Service Settings** and specify a product in the **Travel Charge Item** field. 

> [!div class="mx-imgBorder"]
> ![Screenshot of travel charge item in field service settings.](./media/field-service-settings-travel-charge.png)

This is the product that will later show as a work order product.

> [!div class="mx-imgBorder"]
> ![Screenshot of travel charge added as a work order product.](./media/work-order-service-account-travel-charge-product.png)

> [!Note]
> The travel charge work order product's unit amount price will be the value entered in the service account **travel charge**.

Though the unit amount price of the travel charge is dictated by the price list, list price, and travel charge, the *quantity* is dictated by the **Travel Charge Type** on the service account. Here's what the quantity options mean: 

- **Hourly:** Quantity will be the **Actual Travel Duration** of the booking per 60 minutes. For example, if the unit amount price of the **Travel Charge** is set to $60 and actual travel duration is 30 minutes, the travel charge work order product will be priced as $30.
- **Mileage:** Quantity is the **Miles Traveled** of the booking. For example, if the unit amount price of the **Travel Charge** is set to $1 and miles traveled is 20 miles, the travel charge work order product will be priced as $20.
- **Fixed:** Quantity is **1**. For example, if the unit amount price of the **Travel Charge** is set to $50, the travel charge work order product will be priced as $50, regardless of miles or time spent traveling. 
- **None:** No travel charge will be added to the work order.

> [!Note]
> In cases of multiple bookings for a single work order, multiple travel charges will be added as work order products.