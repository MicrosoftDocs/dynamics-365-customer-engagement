---
title: Manage org charts
description: Learn how to create and edit org charts, add contacts and labels, and create a hierarchy to help sellers gain insights into their customers' organizational structure and identify key decision-makers.
author: udaykirang
ms.author: udag
ms.reviewer: shujoshi
ms.topic: how-to
ms.date: 04/22/2023
ms.custom: bap-template
---

# Manage org charts (preview)

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

An organization chart helps sellers and sales managers to visualize an account's hierarchy, understand the roles and responsibilities of each contact in the hierarchy, and view the strength of each contact. You can use an org chart to make sure you're reaching the right contact and develop strategies to improve sales.

As a seller or sales manager, you can perform the following tasks to manage org charts:

- [Create or edit an org chart](#create-or-edit-an-org-chart)
- [Add a contact](#add-a-contact)
- [Create a hierarchy](#create-a-hierarchy)
- [Set a contact as primary](#set-a-contact-as-primary)
- [Set a contact as an assistant](#set-a-contact-as-an-assistant)
- [Add a label to a contact](#add-a-label-to-a-contact)
- [Remove a contact](#remove-a-contact)

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, or Dynamics 365 Sales Professional<br/>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Any primary sales role, such as Salesperson or Sales Manager<br/>More information: [Primary sales roles](security-roles-for-sales.md#primary-sales-roles)|

## Prerequisites

Your administrator has [turned on the enhanced org chart feature](enable-org-chart.md).

## Create or edit an org chart

An account can have only one org chart. You can create the org chart for an account if one doesn't exist. You can edit an org chart to add or remove positions, redefine roles and responsibilities, and adjust reporting lines. Org charts are available for all users in your organization.

1. Sign in to your sales app. On the site map, select **Customers** > **Accounts**.
1. Select the account, and then on the tool bar, select **Open org chart**.

   > [!NOTE]
   > If you're using contacts to create an org chart, open a contact and then select **Open org chart**.

1. Add contacts to create an org chart or edit the org chart:

   - To start creating an org chart, drag a contact from the **Contacts in the account** list to **Add contact**.
   - To edit the org chart, select **Edit chart**.

1. Do the following tasks, as required:

    - [Add a contact](#add-a-contact)
    - [Create a hierarchy](#create-a-hierarchy)
    - [Set a contact as primary](#set-a-contact-as-primary)
    - [Set a contact as an assistant](#set-a-contact-as-an-assistant)
    - [Add a label to a contact](#add-a-label-to-a-contact)
    - [Remove a contact](#remove-a-contact)

1. Select **Save chart**.

## Add a contact

To add a contact to the org chart, drag it from the **Contacts in the account** list to the contact card. If you don't see the contact you want to add in the list, select **Refresh** in the tool bar.

Contacts that appear in the **Contacts in the account** list are automatically added to the org chart if they match the account.

To update the org chart to show new roles, drag a contact to the new position.

## Create a hierarchy

To create a hierarchy, drag a contact to the card of the contact with whom you're creating a relationship. The contact is automatically added as a direct report of the target contact.

For example, Anna Lidman and Nancy Anderson report to Maria Campbell. To create this hierarchy, drag **Lidman Anna** and **Nancy Anderson** to **Maria Campbell**'s card, as shown in the following screenshot.

:::image type="content" source="media/org-chart-hierarchy-created.png" alt-text="Screenshot showing direct reports in an org chart hierarchy." lightbox="media/org-chart-hierarchy-created.png":::

After a contact is added to the chart, you can also use the [**Contact Details** pane](view-understand-org-charts.md) to add a manager and direct reports. To open the **Contact Details** pane, double-click the contact card.

## Set a contact as primary

A primary contact is the go-to contact for all communications in your customer's organization. An account can have only one primary contact.

To set a contact as primary in the org chart hover over the contact, select **More options**, and then select **Set as primary contact**.

A label on the contact card indicates its status as the primary contact.

The following image shows that Jim Glynn is the primary contact for the Fabrikam, Inc. account.

:::image type="content" source="media/org-chart-primary-contact.png" alt-text="Screenshot of an org chart with the primary contact highlighted." lightbox="media/org-chart-primary-contact.png":::

## Set a contact as an assistant

In general, an assistant provides administrative support to a team in the organization. In an org chart, assistants are directly below the person to whom they report, but not at the same level as the manager's other direct reports.

1. Drag a contact to the manager card.

1. Hover over the contact, select **More options**, and then select **Set as assistant**.

The following image shows that Patrick Sands is the assistant for Jim Glynn.

:::image type="content" source="media/org-chart-assistant-contact.png" alt-text="Screenshot of an org chart with the assistant highlighted." lightbox="media/org-chart-assistant-contact.png":::

To remove a contact as an assistant, hover over the contact, select **More options**, and then select **Set as direct report**.

## Add a label to a contact

Labels identify contacts based on certain characteristics or criteria. They make it easier to visualize and understand the organizational structure and make informed decisions about which individuals to approach. A contact can have only one label.

Four labels are available by default:

- **Decision maker**: Typically refers to an individual, or a group of individuals, who are responsible for making the final decisions that affect the overall direction and strategy of the organization.
- **Influencer**: Typically refers to an individual or group who can influence the decisions and actions of others in the organization.
- **Blocker**: Typically refers to an individual or group who are hindering or preventing progress on a particular deal or outcome.
- **Unknown**: Typically refers to an individual whose position isn't clearly defined or whose identity is unknown.

To add a label to a contact card, select the label icon and select a label from the list.

The following image is an example of contacts with labels.

:::image type="content" source="media/org-chart-labels-added-contacts.png" alt-text="Screenshot showing contacts with labels in an org chart." lightbox="media/org-chart-labels-added-contacts.png":::

## Remove a contact

When a contact is no longer associated with the account, you can remove it from the org chart or from the account.

1. Hover over the contact, select **More options**, and then select one of the following options:

    - **Remove from chart**. The contact is still in the **Contacts in the account** list and can be added back to the org chart. Any direct reports move to the level of the removed contact.
    - **Remove from account**. The contact is removed from the org chart and disassociated from the account.

2. Confirm the removal when prompted.

When LinkedIn Sales Navigator is turned on in your organization and contacts change their organization, their contact card displays a notification to verify the contact's organization details. You can take appropriate action on the contact and [update the org chart](view-understand-org-charts.md#contact-changes-organization-in-linkedin).

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

[Organization charts](organization-charts.md)  
[View and understand the org charts](view-understand-org-charts.md)
