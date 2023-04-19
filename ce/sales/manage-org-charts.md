---
title: Manage org charts
description: How-to description #Required; article description that's displayed in search results. Don't enclose in quotation marks. Do end with a period.
author: udaykirang
ms.author: udag
ms.reviewer: shujoshi
ms.topic: how-to 
ms.collection: get-started 
ms.date: 04/22/2023
ms.custom: bap-template 
---

# Manage org charts

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

An org chart helps to visualize an account’s hierarchy, understand the roles and responsibilities of each contact in the hierarchy, and view the strength of each contact. Further, you can improve communication by reaching the right contact, and plan and develop strategies to improve sales. 

As a seller or sales manager, you can manage the org charts by doing the following tasks:  
-	Create an org chart from scratch. More information: [Create an org chart](#create-an-org-chart)
-	Edit an existing org chart. More information: [Edit an org chart](#edit-an-org-chart)

Along with the above tasks, you can also do the following tasks in the org chart:  
-	[Add a contact to chart](#add-a-contact-to-the-chart)
-	[Create hierarchy](#create-hierarchy)
-	[Set a contact as primary](#set-a-contact-as-primary)
-	[Set a contact as assistant](#set-a-contact-as-assistant)
-	[Add labels to a contact](#add-labels-to-a-contact)
-	[Remove a contact](#remove-a-contact)

## License and role requirements
| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, or Dynamics 365 Sales Professional <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Any primary sales role, such as salesperson or sales manager<br>  More information: [Primary sales roles](security-roles-for-sales.md#primary-sales-roles)|

## Prerequisites

Before you can manage org charts, the org chart feature must be enabled. Contact your administrator to [Enable org chart](enable-org-chart.md).

## Create an org chart

Create org chart for an account if it doesn’t already exist. Once created, org charts are available for all users in your organization. You can only have one organizational chart per account at any given time.

1.	Sign in to your sales app and on the site map, go to **Customers** > **Accounts**. 
2.	Select the account and then from the tool bar, select **Open org chart**.
    The org chart opens with a list of contacts that are associated with the account. 

    >[!NOTE]    
    >If you are using contacts to create org chart, open the contact and then select **Open org chart**.

3.	Select **Edit chart** and the **Add contact** option becomes active.

4. Do the following tasks on the org chart as required:
    -	[Add a contact to chart](#add-a-contact-to-the-chart)
    -	[Create hierarchy](#create-hierarchy)
    -	[Set a contact as primary](#set-a-contact-as-primary)
    -	[Set a contact as assistant](#set-a-contact-as-assistant)
    -	[Add labels to a contact](#add-labels-to-a-contact)
    -	[Remove a contact](#remove-a-contact)
5.	Select **Save chart**.
    The org chart is created and saved. 

## Edit an org chart

You can edit the structure of the sales team or department within an organization. Editing involves tasks, such as adding or removing positions, redefining roles and responsibilities, or adjusting reporting lines to improve efficiency and productivity.

1.	Open the org chart and then select **Edit chart**.
2.	Do the following tasks on the org chart as required:
    -	[Add a contact to chart](#add-a-contact-to-the-chart)
    -	[Create hierarchy](#create-hierarchy)
    -	[Set a contact as primary](#set-a-contact-as-primary)
    -	[Set a contact as assistant](#set-a-contact-as-assistant)
    -	[Add labels to a contact](#add-labels-to-a-contact)
    -	[Remove a contact](#remove-a-contact)
3.	Select **Save chart**. 
    The org chart is updated and save.

## Add a contact to the chart

When you’re creating the org chart from scratch, drag a contact from the **Contacts in the account** list and drop it onto the **Add contact** option. The contact is added to the chart.

Similarly, to add contacts to the chart, drag the desired contact and drop it onto the existing contact on the chart.

The contacts that are displayed in the **Contacts in the account** list are automatically added if they match the account. This includes primary contact and associated contacts.

If you don’t see the added contact in the list, select **Refresh** from the tool bar. 

## Create hierarchy

To create a hierarchy, drag the desired contact and drop it onto the contact for which you are creating the relationship. The added contact is automatically added as a direct report.

For example, **Lidman Anna** and **Nancy Anderson** reports to **Maria Campbell**. To create this hierarchy, drag **Lidman Anna** and **Nancy Anderson** over **Maria Campbell**’s card. The hierarchy is created as shown in the image.

:::image type="content" source="media/org-chart-hierarchy-created.png" alt-text="Screenshot showing org chart hierarchy" lightbox="media/org-chart-hierarchy-created.png"::: 

Once a contact is added to the chart, you can also use the **Contact Details** pane to add the manager and direct reports. To open the **Contact Details** pane, double-click the contact card. More information: [View contact details](understand-contact-card.md#view-contact-details)

## Set a contact as primary

A primary contact is the one go-to contact for all communications in an organization. 

To set a contact as primary in the org chart:
Hover over the contact, select **More options**, and then select **Set as primary contact**. 

The contact is set as primary, and a label is added to the contact card to indicate its status as the primary contact.

>[!NOTE]
>At any given time, you can have only one primary contact for an account.

The following image shows that **Jim Glynn** is a primary contact for the **Fabrikam, Inc.** account. 

:::image type="content" source="media/org-chart-primary-contact.png" alt-text="Screenshot showing a primary contact in org chart" lightbox="media/org-chart-primary-contact.png"::: 

## Set a contact as assistant

In general, an assistant provides administrative support to a team within the organization. In an org chart, assistants are directly below the person to whom they report to, but not at the same level as the other direct reports of that manager.

To add an assistant:
1.	Drag a contact onto the manager card and is as added as a child. 
2.	Hover over the contact, select **More options**, and then select **Set as assistant**.

The following image shows that **Patrick Sands** is added as the assistant for **Jim Glynn**.

:::image type="content" source="media/org-chart-assistant-contact.png" alt-text="Screenshot showing an assistant contact in org chart" lightbox="media/org-chart-assistant-contact.png"::: 

When you remove a contact as an assistant, they become a direct report to the manager for whom they previously worked as an assistant. To remove as assistant, hover over the contact, select **More options**, and then select **Set as direct report**. 

## Add label to a contact

Label helps you to identify contacts based on certain characteristics or criteria. Adding labels to contacts makes it easier to visualize and understand the organizational structure, allowing for informed decisions about which individuals to approach and how to allocate resources effectively. The following default labels are available: 

| Label | Description |
|-------|-------------|
| Decision maker | A decision maker typically refers to an individual or a group of individuals who are responsible for making the final decisions that affect the overall direction and strategy of the organization. |
| Influencer | An influencer typically refers to an individual or a group of individuals who could affect the decisions and actions of others within the organization. |
| Blocker | A blocker typically refers to an individual or a group of individuals who are hindering or preventing progress on a particular deal or outcome. |
| Unknown | An unknown typically refers to an individual whose position is not clearly defined or whose identity is unknown. |

To add a label:
1.	On the contact card, select the label icon.
2.	From the label list, select a suitable label for the contact.

>[!NOTE]
>You can add only one label per contact.

The following image is an example of contacts with labels:

:::image type="content" source="media/org-chart-labels-added-contacts.png" alt-text="Screenshot showing contacts with labels in org chart" lightbox="media/org-chart-labels-added-contacts.png"::: 

## Remove a contact

When a contact is no longer associated with the account, you can remove it from the chart or from the account depending on your requirement.

To remove a contact:
1.	Hover over the contact, select **More options**, and then select one of the following options as require:
    •	To remove from the chart, select **Remove from chart**. 
        When removed from the chart, the contact will still be available in the **Contacts in the account list**. When required you can add back the contact to the org chart. Also, the direct reports (if available) of that contact will move to the level of the removed contact.
    •	To remove from the account, select **Remove from account**.
        When removed from the account, the contact will be removed and disassociated with the account. 
2.	On the confirmation message, select **Remove from *type***.

When LinkedIn Sales Navigator is enabled in your organization and when contact updates organization details, a message is displayed to verify the contact’s org details. You can take appropriate action on the contact and update the org chart. More information: [LinkedIn controls](understand-contact-card.md#linkedin-controls).

### See also


[View and understand the org charts](view-and-understand-org-charts.md)  
[Understand the contact card](understand-contact-card.md)