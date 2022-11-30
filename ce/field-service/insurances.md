# Insurances in Dynamics 365 Field Service

Insurance refers to a coverage by contract where one party provides a guarantee fore another against loss in specified circumstances. A policy is the common term for an insurance coverage contract.

In field service context, insurances often cover buildings and other assets. For example, an insurance that covers flooding in case of severe weather.

Insurance is a separate entity in Dynamics 365 Field Service.

## Create an insurance

You can create insurances in the Settings area or directly from related entities. We'll look at creating an insurance from scratch in this procedure.

1. In Field Service, change to the **Settings** area.

1. Go to **Service Delivery** > **Insurance** and select **New**.

1. Provide a **Policy name**.

1. Choose a service account as **Policy holder**. The policy holder is the service account that pays for insurance.

1. Choose a service account as **Insurance carrier**. The insurance carrier covers the loss of the policy holder in case of a covered event.

1. Enter the **Policy number**

1. Set the **Start Date** and the **End Date** for the insurance.

1. Optionally, add a **Description** of the insurance and upload a **Policy document**.

1. **Save** the record to apply your changes.

## View insurances in context

Insurances have a relationship to service accounts. You can now find contextual information in related entities.

For example, on *Account* records if the service account is a policy holder or insurance carrier.
