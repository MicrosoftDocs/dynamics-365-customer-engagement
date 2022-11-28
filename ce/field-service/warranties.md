# Warranties in Dynamics 365 Field Service

Warranties are usually a written guarantee of the integrity of a product and of the producer's responsibility for the repair or replacement of defective parts.

In field service context, several scenarios can involve warranties. For example, when an asset is installed on-site or when work gets completed in a functional location.

Dynamics 365 Field Service implements warranties as a separate entity.

## Warranty types

Field Service includes three default warranty types.

- Asset warranty: Covers an individual [customer asset](configure-set-up-customer-assets.md).
- Functional location warranty: Covers a [functional location](assets-functional-location.md), for example, an entire building or a room.
- Account warranty: Covers an entire [service account](accounts.md).

## Create a warranty

You can create warranties in the Settings area or directly from related entities. We'll look at creating a warranty from scratch in this procedure.

1. In Field Service, change to the **Settings** area.

1. Go to **Service Delivery** > **Warranties** and select **New**.

1. Provide a **Name**.

1. Choose a service account as **Warranty holder**. The Warranty holder is the service account that receives replacement if a part is defective.

1. Choose a service account as **Warranty provider**. The warranty provider guarantees to replace defective parts.

1. Optionally, enter the **Start Date** and the **End Date** for the warranty.

1. Choose the **Type** of the warranty. Depending on the warranty type, data for other fields is required.

   - Asset warranty: Choose the customer asset the warranty applies to.
   - Functional location warranty: Choose the functional location for the warranty.

1. **Save** the record to apply your changes.

## View warranties in context

Because warranties have a relationship to service accounts, you can now find contextual information in related entities. 

Examples:

- *Work orders* related to a warranty holder service account.
- *Account* records if the service account is a warranty holder or provider.


