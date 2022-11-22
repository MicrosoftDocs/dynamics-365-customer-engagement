# Create and manage accounts

An account represents a customer that receives service from a field service organization. Accounts are a fundamental entity in Dynamics 365 Field Service and they are used in several areas of the application.

There are two main types of accounts:

- **Service account** is the account that receives the on-site service by a field technician.

- **Billing account** represents the account that receives invoices for the work provided. Usually, it's a shared account for multiple service accounts that belong to a central organization.

Example: Multiple vineyards are owned by a wine producer corporation. Every vineyard is a service account that share the corporation as a billing account.

:::image type="content" source="media/service-account-overview.png" alt-text="Screenshot of an account summary.":::

## Create a service account

In this section, we'll create a service account with a geocoded address that represents a specific customer location where work orders will be performed.

1. In Field Service, open the **Service** area.

1. Go to **Customers** > **Accounts** and select **+New**.

1. Enter an **Account name** and a **Service address**.

1. Select **Geo Code** at the top of the form. You can also [enable the auto-geocoding setting](turn-on-auto-geocoding.md).

1. Select **Save** to create the account record.

## Add account information

On the **Summary** section, you can provide additional information about the account. These fields are optional.

- **Phone**
- **Fax**
- **Website**
- **Parent Account**: For larger organizations, you can define parent/child relations between accounts that define the organization hierarchy.
- **Ticker Symbol**: Stock ticker symbol of the company if it's publicly listed.
- **Relationship Type**: Type of relationship between your organization and account.
- **Product Price List**: [Price list configuration](create-price-list.md) for this account.

## Add contacts for an account

Contacts are individuals that are related to an account. You can add contacts on the **Summary** section.

- **Primary Contact**: The individual that is your main point of [contact for an account](contacts.md).

- **Contacts**: Create more contacts or add an existing contact as a reference to the account form.

## Specify details for an account

The **Details** section lets you add more information and preferences to the account record.

- **Company Profile**
- **Description**
- **Contact Preferences**: Preferred contact method and which contact methods are allowed.
- **Billing**: Default billing options for the account.
- **Shipping**: Default shipping method and terms.

## Configure servicing details for an account

The **Servicing** section of the account form lists details to provide services to the account and the work orders that are associated to it.

### Accounting

- **Billing Account**: Sets the billing account field on the work order when this account is selected as the service account. If no billing account is selected, the service account acts as both the service account and the billing account.

- **Product Price List**: [Price list configuration](create-price-list.md) for this account. If a billing account is selected, the price list on the billing account record will be used. If products or services are not listed on the selected price list, the list price on the product record is used.

- **Tax Exempt**: Defines if sales tax gets added to the price of related work orders. Set to **Yes** to *not* add sales tax. Set to **No** to [specify a sales tax code](set-up-tax-codes.md) for the work order price and invoice.

### Service

- **Service Territory**:

In this field, you choose the geographical region in which this account is located. This value will be passed down to the related work orders and work order requirements, and is considered in the scheduling process on the schedule board, in the schedule assistant, and with Resource Scheduling Optimization (RSO).

- **Travel Charge Type**:

This decides if and how travel by a field technician to this service account should be priced and billed on work orders. For more information, see configuration considerations in this article.

- **Work Hour Template**
- **Work Order Instructions**

This value serves as a text note and populates the **Instructions** field on all related work orders. This is a good way to ensure field technicians follow processes specific to this account. See an example in the following screenshot.

> [!div class="mx-imgBorder"]
> ![Screenshot of Field Service related values for a specific account.](./media/service-account-field-service-section.png)

> [!Note]
> Updating these values will not update previous work orders, only future work orders.

### Currency

Work order products and work order services will inherit the currency value noted on the work order service accounts and billing accounts. 