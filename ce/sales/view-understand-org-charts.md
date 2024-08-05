---
title: View and understand the org charts
description: Learn how to use the org charts to gain insights into your customers' organizational structure and identify key decision-makers.
author: udaykirang
ms.author: udag
ms.reviewer: udag
ms.topic: how-to
ms.date: 07/25/2024
ms.custom: bap-template
---

# View and understand the org charts

The org chart is accessible from accounts and contacts. To view the org chart for an account or a contact, select **Open org chart** in the command bar. If an organizational chart exists for the selected record, it's displayed. If not, you can [create one](manage-org-charts.md#create-or-edit-an-org-chart).

>[!NOTE]
>
>- Org charts that were previously created using the legacy org chart feature are automatically upgraded to the new org chart format.
>- Org charts are available only for accounts and contacts.

The following image is an example of an org chart:

:::image type="content" source="media/org-chart-example.svg" alt-text="Screenshot showing an example of an org chart for an account." lightbox="media/org-chart-example.svg":::

You can do the following actions in the org chart for better accessibility and understanding:

- **Zoom in and out**: Adjust the view of the org chart by zooming in and out to display more or fewer levels of the organizational structure within the available screen space. You can also move the org chart around to focus on a specific area. Use the **Zoom in**, **Zoom out**, and **Reset zoom** options in the org chart to adjust the view. The current zoom selection will be remembered and applied the next time you open the org chart.

- **Highlight specific contact**: To highlight a contact card in the org chart, select a contact from the left contact pane. 

- **Collapse or expand org chart**: You can collapse or expand the structure to concentrate on a particular section of the org chart. Use the contacts icon in between the contact cards for collapsing or expanding the chart. When the chart is collapsed, the contact icon displays the number of contacts in the collapsed section.

- **Contact card details**: The contact card in the org chart provides high-level information about individuals in the org, such as the relationship health, a label, and contact details. Select a contact and the card is highlighted in the org chart.  
    
    The following image is an example of a contact card in an org chart:
    
    :::image type="content" source="media/org-chart-contact-card.png" alt-text="Screenshot showing a contact card in an org chart." lightbox="media/org-chart-contact-card.png":::
    
    Contact cards include the following information:

    - [A label](manage-org-charts.md#add-a-label-to-a-contact) such as "Decision maker" or "Influencer" helps you to visualize the individual's role in the organizational structure, so that you can make an informed decision about whom to approach. A contact can also be [marked as the primary contact](manage-org-charts.md#set-a-contact-as-primary) in the org chart.
    - A colored circle around the contact photo or initials indicates the contact's relationship health. To view the [relationship health state and trend](relationship-analytics-kpi-calculations.md#compute-the-relationship-health-and-health-trend), hover over the circle. You can also open the [**Contact Details** pane](#view-contact-details) to see the relationship health.

  > [!NOTE]
  > To view relationship health, your administrator must [turn on relationship analytics](configure-relationship-analytics.md).

## View contact details

The **Contact Details** pane provides more information about individuals in an organization, such as their email address, job title, the name of their manager, the names of any direct reports, and their relationship health. When your organization turns on LinkedIn Sales Navigator for you, you also see LinkedIn tools like Sales Navigator and InMail. You can also add notes about the contact for future reference.

To open the **Contact Details** pane, double-click a contact card.

:::image type="content" source="media/org-chart-contact-details-pane.png" alt-text="Screenshot showing the Contact Details pane of a contact." lightbox="media/org-chart-contact-details-pane.png":::

### LinkedIn tools

If you have a Sales Navigator license, contacts' LinkedIn profiles are always just a few clicks away.

To sign in to the service and open the LinkedIn Sales Navigator widget, select **Sales Navigator**. Here you can match the contact and view their LinkedIn profile.

To send an email to the contact, select **InMail**.

### Contact changes organization in LinkedIn

When a contact leaves the organization and updates their LinkedIn profile, the org chart puts a red border around the contact card and displays a notification to verify the contact's details.

1. On the notification, select **Verify details**.

1. On the **Verify Contact Details** pane, review the details and update the contact information as required.

    - If the contact has moved to a new organization, update the account information in the **Update Company info in your contacts** section and select **Update Contact**.
    - If the contact is still with the current organization, select **Ignore Update**.

A red border around a contact card indicates the contact's organization has changed and needs your review.

### Add notes

Add notes to keep and share important information or tasks related to the contact. Notes are available in the **Contact Details** pane and on the contact's timeline.

1. In the **Seller notes** section, select **Create a note**.
1. In the note editor, enter a title and the content of your note.
1. Select **Save**.

The note is added to the contact with information about the author and the time it was created.

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

## Related information

[Organization charts](organization-charts.md)  
[Manage org charts](manage-org-charts.md)
