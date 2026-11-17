---
title: Use the canvas experience for contacts (preview)
description: Use the contact canvas in Dynamics 365 Customer Service to review contact details, insights, notes, activities, business involvement, and relationships.
ms.date: 11/17/2026
ms.topic: how-to
ms.service: dynamics-365-customer-service
author: gandhamm
ms.author: mgandham
ai-usage: ai-generated
---

# Use the canvas experience for contacts (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

Use the contact canvas to review contact details, engagement insights, notes, activity history, relationships, and related business records. Update supported information without switching between forms.

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## Prerequisites

- Your administrator enabled the contact canvas. Learn more in [Manage canvases in CRM Canvas Designer](manage-canvases.md).
- You have the required license and access to the contact and its related records. For supported licenses, see the [Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/?LinkId=866544).


## Open the contact canvas

1. In Copilot Service workspace or Sales Hub, go to **Contacts**.
2. Open the contact you want to review. The contact opens in the canvas experience.

## Understand the contact canvas

Use section navigation to move around the page.

:::image type="content" source="media/use-contact-canvas/contact-canvas.png" alt-text="Screenshot of the full contact canvas with its command bar, insights, personal context, timeline, and relationships." lightbox="media/use-contact-canvas/contact-canvas.png":::

| Area | What you see | What you can do |
| --- | --- | --- |
| Command bar | **Assign**, **Deactivate**, **Open classic view**, and **Refresh**. | <ul><li>Select **Assign** to change the contact record owner.</li><li>Select **Deactivate** to deactivate the contact record.</li><li>Select **Refresh** to reload the contact canvas.</li><li>Select **Open classic view** for fields, commands, or customizations that the canvas doesn't support. Select **Open canvas view** on the classic form to return.</li></ul> |
| Contact header | Contact name, job title, decision-maker designation, phone, email, account, status, deals, and latest activity. | <ul><li>Review the contact's details, account context, status, and latest activity.</li></ul> |
| **What's important now?** | Insight cards about engagement, outreach, and meeting cadence. By default, the component initially shows up to three cards. To view insights, your administrator must [set up and configure insights](set-up-configure-insights.md). | <ul><li>Select **See more** to display additional cards, or **See less** to return to the initial set.</li><li>Select the information icon on a card to learn what the insight measures.</li><li>Select the refresh icon on a card to refresh that insight.</li><li>Check the **As of** timestamp to see when the calculation ran.</li><li>Review related records and recent activities before acting on a result.</li><li>If a card offers an email action, review the recipient and supporting facts, and edit the draft before sending it. The action doesn't send the message automatically, create a related record, or book a meeting.</li></ul> |
| Personal context: **Contact information** | Contact details such as email, phone numbers, company, job title, address, preferred contact method, and owner. | <ul><li>Review contact details and select linked records, such as the company or owner, where available.</li><li>Use **Open classic view** if you need to update fields that aren't editable on the canvas.</li></ul> |
| Personal context: **Consent** | Communication preferences for email, phone calls, mail, and bulk email. | <ul><li>Review the **Allow** or **Do Not Allow** value for each communication type.</li><li>Use **Open classic view** if you need to update consent settings that aren't editable on the canvas.</li></ul> |
| Personal context: **Notes** | Notes associated with the contact. You need permission to create notes; adding a note doesn't send a message or complete a follow-up task. | <ul><li>Select **Add note** to record important context about the contact.</li><li>Review existing notes when available.</li></ul> |
| **What's happened before?** | **Timeline** of recorded activities and notes. Conversations that weren't recorded don't appear. | <ul><li>Select **Log activity** to add an activity to the timeline.</li><li>Select **Emails**, **Appointments**, **Notes**, or **Other** to filter by activity type, or **All** to show all types.</li><li>Use the search icon to find activities and the sort control to change their order.</li><li>Select an activity's chevron to expand its details.</li><li>Select **Show more** to load additional activities.</li><li>Use the expand icon to open a larger timeline view.</li></ul> |
| Business involvement | Related **Opportunities**, **Accounts**, **Cases**, and **Entitlements**, with available impact, status, and last-activity details. | <ul><li>Select a record category to view the contact's related records.</li><li>You can add the corresponding record.</li><li>Select the refresh icon to reload the records.</li><li>Use search, filters, and column sorting to find records in the selected category.</li><li>Select a record name to open it.</li><li>Select **Show more** and use the page controls to review additional loaded records.</li><li>Search, filtering, and sorting apply only to the loaded records shown in the component.</li><li>Use the classic form for record actions that aren't available on the canvas.</li></ul> |
| **Relationship map** | An **Org chart** view and a **Who knows whom** view of recorded relationships and connections. The map can't identify an introduction path to someone with no recorded connection. | <ul><li>Select **Add stakeholder** to add a stakeholder to the relationship map.</li><li>Select **Org chart** to review the contact's organizational relationships, or **Who knows whom** to review connection paths.</li><li>Use search and filters to locate people in the map.</li><li>Select a people-count control beneath a person to expand additional connections where available.</li><li>Use the expand icon for a larger org chart view.</li></ul> |

## Understand insights and recommendations

Compare contact insights to distinguish your team's outreach attempts from the contact's responses. Your permissions, available data, and enabled insights determine which results you can see. Cards can show a value, comparison, trend, or list of records.

| Insight | Description |
| --- | --- |
| Contact Two-Way Engagement Recency | Shows the number of days since the contact last responded or otherwise engaged through a qualifying activity. The insight doesn't count unanswered outbound attempts. When qualifying history exists, the insight shows **Warm**, **Cooling**, or **Cold**. |
| Contact Outbound Outreach Recency | Shows the number of days since your team last attempted to contact the person, regardless of whether they responded. It measures outreach activity, not relationship health. |
| Meeting Cadence | Compares the number of qualifying recorded meetings in the past 30 days with the previous 30 days. It doesn't show a trend when there isn't enough history. |

For example, your team might have emailed a contact two days ago, but the contact last responded 60 days ago. Outbound outreach recency shows two days, while two-way engagement recency shows 60 days and **Cold**.

### Interpret insight results

Check these limitations when you assess a result.

| Consideration | What to know |
| --- | --- |
| Recorded data | Built-in preview insights use Dynamics 365 data stored in Dataverse. They don't directly read untracked Outlook, Teams, or LinkedIn activity and might not reflect all customer activity. |
| Calculation time | Changes made after the **As of** timestamp might not appear in the result. |
| Copilot credits | Calculating insights in this preview uses your organization's Copilot credits; viewing them doesn't. If credits run out, insights keep their last result and **As of** timestamp until more credits are available. |
| Meeting records | Completed appointments can identify invited contacts but don't confirm attendance. Insights might not count meetings that are still scheduled or aren't tracked in Dataverse. |
| Limited history | Don't interpret an empty engagement result as **Cold** or assume that a missing result means there's no risk. Cards might not show a result when they lack data. |

If a result appears incomplete, check the related records or ask your administrator to review data availability and configuration.

## Related information

- [Use the canvas experience for accounts](use-account-canvas.md)
- [Manage your accounts and contacts](../sales/accounts-contacts.md)
- [Insights overview for administrators](insights-overview.md)
- [Set up and configure insights](set-up-configure-insights.md)
- [Create and manage custom insights](create-manage-custom-insights.md)
